﻿/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator
{
    /// <summary>
    /// Helper class for all decorators.
    /// </summary>
    internal static class DecoratorUtil
    {
        /// <summary>
        /// Creates and adds a public auto-property (property and backening field) to the class.
        /// </summary>
        /// <typeparam name="TProperty">Type used for the propery.</typeparam>
        public static CodeTypeMemberCollection CreateAutoProperty<TProperty>(CodeTypeDeclaration serviceClass,
                                                                    string name,
                                                                    string summaryComment)
        {
            // Validate parameters.
            serviceClass.ThrowIfNull("serviceClass");
            name.ThrowIfNullOrEmpty("name");

            // Check if the name has already been used.
            if (serviceClass.Members.FindPropertyByName(name) != null)
            {
                throw new ArgumentException(
                    string.Format("The property name [{0}] was already used within this class", name), "name");
            }

            // Create backening field.
            var field = CreateBackingField<TProperty>(serviceClass, name);
            string fieldName = field.Name;
            var fieldNameRef = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);

            // Add property.
            var property = new CodeMemberProperty();
            property.Name = name;
            property.Attributes = MemberAttributes.Public;

            if (summaryComment.IsNotNullOrEmpty())
            {
                property.Comments.Add(new CodeCommentStatement("<summary>" + summaryComment + "</summary>", true));
            }
            property.Type = new CodeTypeReference(typeof(TProperty));
            property.HasGet = true;
            property.HasSet = true;

            // Add getter and setter.
            property.GetStatements.Add(new CodeMethodReturnStatement(fieldNameRef));

            property.SetStatements.Add(
                new CodeAssignStatement(fieldNameRef, new CodePropertySetValueReferenceExpression()));

            // Return the result.
            var col = new CodeTypeMemberCollection();
            col.Add(field);
            col.Add(property);
            return col;
        }

        /// <summary>
        /// Creates a backening field for the name provided.
        /// </summary>
        /// <typeparam name="TProperty">Type used for the propery.</typeparam>
        /// <param name="name">The name of the property.</param>
        /// <returns></returns>
        public static CodeMemberField CreateBackingField<TProperty>(CodeTypeDeclaration serviceClass, string name)
        {
            // Validate parameters.
            serviceClass.ThrowIfNull("serviceClass");
            name.ThrowIfNullOrEmpty("name");

            // Generate field name.
            var fieldName = Char.IsLower(name[0]) ? "_" + name : GeneratorUtils.LowerFirstLetter(name);

            // Check if it was already used.
            if (serviceClass.Members.FindFieldByName(fieldName) != null)
            {
                throw new ArgumentException(
                    string.Format("The property name [{0}] was already used within this class", name), "name");
            }

            // Create the field.
            var field = new CodeMemberField(typeof(TProperty), fieldName);
            field.Attributes = MemberAttributes.Private;
            return field;
        }

        /// <summary>
        /// Creates a summary comment containing the text specified.
        /// Returns an empty collection if the summary string is null or empty.
        /// </summary>
        public static CodeCommentStatementCollection CreateSummaryComment(string summary)
        {
            var comments = new CodeCommentStatementCollection();
            if (summary.IsNotNullOrEmpty())
            {
                var text = "<summary>" + XmlEscapeComment(summary) + "</summary>";
                comments.Add(new CodeCommentStatement(new CodeComment(text, true)));
            }
            return comments;
        }

        /// <summary>
        /// Escapes a string for use in a XML comment.
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public static string XmlEscapeComment(string description)
        {
            return SecurityElement.Escape(description);
        }

        /// <summary>
        /// Creates an enumeration from the provided data.
        /// </summary>
        /// <param name="proposedName">The proposed name of the enumeration.</param>
        /// <param name="description">Description of the enum class.</param>
        /// <param name="entries">Enum entries in the form (name, comment/description).</param>
        /// <returns>Generated enum type.</returns>
        public static CodeTypeDeclaration GenerateEnum(string proposedName, string description,
                                                          IEnumerable<KeyValuePair<string, string>> entries)
        {
            // Create a safe enum name
            string name = GeneratorUtils.GetEnumName(proposedName, new string[0]);

            // Create the enum type
            var decl = new CodeTypeDeclaration(name);
            decl.IsEnum = true;

            // Add the [TypeConverter(typeof(EnumStringValueTypeConverter))] attribute.
            Type converterType = typeof(EnumStringValueTypeConverter);
            var typeConvAttribute = new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(TypeConverterAttribute)));
            typeConvAttribute.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(converterType)));
            decl.CustomAttributes.Add(typeConvAttribute);

            foreach (KeyValuePair<string, string> enumEntry in entries)
            {
                var usedNames = from CodeTypeMember m in decl.Members select m.Name;
                string safeName = GeneratorUtils.GetEnumValueName(enumEntry.Key, usedNames);
                var member = new CodeMemberField(typeof(int), safeName);

                // Attribute:
                var valueAttribute = new CodeAttributeDeclaration();
                valueAttribute.Name = typeof(StringValueAttribute).FullName;
                valueAttribute.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(enumEntry.Key)));
                member.CustomAttributes.Add(valueAttribute);

                // Comments:
                member.Comments.AddRange(CreateSummaryComment(enumEntry.Value));

                // Add member to enum.
                decl.Members.Add(member);
            }

            // Class comment:
            decl.Comments.AddRange(CreateSummaryComment(description));

            return decl;
        }

        /// <summary>
        /// Creates an enumeration from the provided data.
        /// </summary>
        /// <param name="proposedName">The proposed name of the enumeration.</param>
        /// <param name="description">Description of the enum class.</param>
        /// <param name="enumValues">All enumeration values.</param>
        /// <param name="enumDescriptions">All enumeration comments.</param>
        /// <returns>Generated enum type.</returns>
        public static CodeTypeDeclaration GenerateEnum(string proposedName,
                                                       string description,
                                                       IEnumerable<string> enumValues,
                                                       IEnumerable<string> enumDescriptions)
        {
            return GenerateEnum(proposedName, description, GetEnumerablePairs(enumValues, enumDescriptions));
        }
    
        [VisibleForTestOnly]
        internal static IEnumerable<KeyValuePair<K, V>> GetEnumerablePairs<K, V>(IEnumerable<K> keys,
                                                                                IEnumerable<V> values)
        {
            keys.ThrowIfNull("keys");
            values.ThrowIfNull("values");

            if (keys.Count() != values.Count())
            {
                throw new ArgumentException("Both enumerables must be of the the same length.");
            }

            IEnumerator<K> keysEnumerator = keys.GetEnumerator();
            IEnumerator<V> valuesEnumerator = values.GetEnumerator();

            // Return both enumerables as KeyValuePairs
            while (keysEnumerator.MoveNext() && valuesEnumerator.MoveNext())
            {
                yield return new KeyValuePair<K, V>(keysEnumerator.Current, valuesEnumerator.Current);
            }
        }
    }
}