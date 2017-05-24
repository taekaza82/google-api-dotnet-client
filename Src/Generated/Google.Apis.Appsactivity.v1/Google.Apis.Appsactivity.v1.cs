// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.26.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   G Suite Activity API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/google-apps/activity/'>G Suite Activity API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20170215 (776)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/google-apps/activity/'>
 *              https://developers.google.com/google-apps/activity/</a>
 *      <tr><th>Discovery Name<td>appsactivity
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using G Suite Activity API can be found at
 * <a href='https://developers.google.com/google-apps/activity/'>https://developers.google.com/google-apps/activity/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Appsactivity.v1
{
    /// <summary>The Appsactivity Service.</summary>
    public class AppsactivityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AppsactivityService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AppsactivityService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            activities = new ActivitiesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "appsactivity"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/appsactivity/v1/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "appsactivity/v1/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the G Suite Activity API.</summary>
        public class Scope
        {
            /// <summary>View the activity history of your Google apps</summary>
            public static string Activity = "https://www.googleapis.com/auth/activity";

            /// <summary>View and manage the files in your Google Drive</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>View and manage metadata of files in your Google Drive</summary>
            public static string DriveMetadata = "https://www.googleapis.com/auth/drive.metadata";

            /// <summary>View metadata for files in your Google Drive</summary>
            public static string DriveMetadataReadonly = "https://www.googleapis.com/auth/drive.metadata.readonly";

            /// <summary>View the files in your Google Drive</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

        }



        private readonly ActivitiesResource activities;

        /// <summary>Gets the Activities resource.</summary>
        public virtual ActivitiesResource Activities
        {
            get { return activities; }
        }
    }

    ///<summary>A base abstract class for Appsactivity requests.</summary>
    public abstract class AppsactivityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AppsactivityBaseServiceRequest instance.</summary>
        protected AppsactivityBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Appsactivity parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "activities" collection of methods.</summary>
    public class ActivitiesResource
    {
        private const string Resource = "activities";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ActivitiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns a list of activities visible to the current logged in user. Visible activities are
        /// determined by the visiblity settings of the object that was acted on, e.g. Drive files a user can see. An
        /// activity is a record of past events. Multiple events may be merged if they are similar. A request is scoped
        /// to activities from a given Google service using the source parameter.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Returns a list of activities visible to the current logged in user. Visible activities are
        /// determined by the visiblity settings of the object that was acted on, e.g. Drive files a user can see. An
        /// activity is a record of past events. Multiple events may be merged if they are similar. A request is scoped
        /// to activities from a given Google service using the source parameter.</summary>
        public class ListRequest : AppsactivityBaseServiceRequest<Google.Apis.Appsactivity.v1.Data.ListActivitiesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Identifies the Drive folder containing the items for which to return activities.</summary>
            [Google.Apis.Util.RequestParameterAttribute("drive.ancestorId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveAncestorId { get; set; }

            /// <summary>Identifies the Drive item to return activities for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("drive.fileId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DriveFileId { get; set; }

            /// <summary>Indicates the strategy to use when grouping singleEvents items in the associated combinedEvent
            /// object.</summary>
            /// [default: driveUi]
            [Google.Apis.Util.RequestParameterAttribute("groupingStrategy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<GroupingStrategyEnum> GroupingStrategy { get; set; }

            /// <summary>Indicates the strategy to use when grouping singleEvents items in the associated combinedEvent
            /// object.</summary>
            public enum GroupingStrategyEnum
            {
                [Google.Apis.Util.StringValueAttribute("driveUi")]
                DriveUi,
                [Google.Apis.Util.StringValueAttribute("none")]
                None,
            }

            /// <summary>The maximum number of events to return on a page. The response includes a continuation token if
            /// there are more events.</summary>
            /// [default: 50]
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token to retrieve a specific page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The Google service from which to return activities. Possible values of source are: -
            /// drive.google.com</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }

            /// <summary>Indicates the user to return activity for. Use the special value me to indicate the currently
            /// authenticated user.</summary>
            /// [default: me]
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserId { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "activities"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "drive.ancestorId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "drive.ancestorId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "drive.fileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "drive.fileId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "groupingStrategy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupingStrategy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "driveUi",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "50",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "me",
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Appsactivity.v1.Data
{    

    /// <summary>An Activity resource is a combined view of multiple events. An activity has a list of individual events
    /// and a combined view of the common fields among all events.</summary>
    public class Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fields common to all of the singleEvents that make up the Activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedEvent")]
        public virtual Event CombinedEvent { get; set; } 

        /// <summary>A list of all the Events that make up the Activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleEvents")]
        public virtual System.Collections.Generic.IList<Event> SingleEvents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the changes associated with an action taken by a user.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional event types. Some events may have multiple types when multiple actions are part of a
        /// single event. For example, creating a document, renaming it, and sharing it may be part of a single file-
        /// creation event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalEventTypes")]
        public virtual System.Collections.Generic.IList<string> AdditionalEventTypes { get; set; } 

        /// <summary>The time at which the event occurred formatted as Unix time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTimeMillis")]
        public virtual System.Nullable<ulong> EventTimeMillis { get; set; } 

        /// <summary>Whether this event is caused by a user being deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUserDeletion")]
        public virtual System.Nullable<bool> FromUserDeletion { get; set; } 

        /// <summary>Extra information for move type events, such as changes in an object's parents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("move")]
        public virtual Move Move { get; set; } 

        /// <summary>Extra information for permissionChange type events, such as the user or group the new permission
        /// applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionChanges")]
        public virtual System.Collections.Generic.IList<PermissionChange> PermissionChanges { get; set; } 

        /// <summary>The main type of event that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEventType")]
        public virtual string PrimaryEventType { get; set; } 

        /// <summary>Extra information for rename type events, such as the old and new names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rename")]
        public virtual Rename Rename { get; set; } 

        /// <summary>Information specific to the Target object modified by the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Target Target { get; set; } 

        /// <summary>Represents the user responsible for the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response from the list request. Contains a list of activities and a token to retrieve the next page
    /// of results.</summary>
    public class ListActivitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activities")]
        public virtual System.Collections.Generic.IList<Activity> Activities { get; set; } 

        /// <summary>Token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about changes in an object's parents as a result of a move type event.</summary>
    public class Move : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The added parent(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedParents")]
        public virtual System.Collections.Generic.IList<Parent> AddedParents { get; set; } 

        /// <summary>The removed parent(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedParents")]
        public virtual System.Collections.Generic.IList<Parent> RemovedParents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about a parent object. For example, a folder in Drive is a parent for all files
    /// within it.</summary>
    public class Parent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The parent's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Whether this is the root folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRoot")]
        public virtual System.Nullable<bool> IsRoot { get; set; } 

        /// <summary>The parent's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about the permissions and type of access allowed with regards to a Google Drive
    /// object. This is a subset of the fields contained in a corresponding Drive Permissions object.</summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the user or group the permission applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ID for this permission. Corresponds to the Drive API's permission ID returned as part of the
        /// Drive Permissions resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; } 

        /// <summary>Indicates the Google Drive permissions role. The role determines a user's ability to read, write,
        /// or comment on the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>Indicates how widely permissions are granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The user's information if the type is USER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; } 

        /// <summary>Whether the permission requires a link to the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withLink")]
        public virtual System.Nullable<bool> WithLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about a Drive object's permissions that changed as a result of a permissionChange
    /// type event.</summary>
    public class PermissionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Lists all Permission objects added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedPermissions")]
        public virtual System.Collections.Generic.IList<Permission> AddedPermissions { get; set; } 

        /// <summary>Lists all Permission objects removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedPermissions")]
        public virtual System.Collections.Generic.IList<Permission> RemovedPermissions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Photo information for a user.</summary>
    public class Photo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL of the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about a renametype event.</summary>
    public class Rename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTitle")]
        public virtual string NewTitle { get; set; } 

        /// <summary>The old title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldTitle")]
        public virtual string OldTitle { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the object modified by the event.</summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the target. For example, in Google Drive, this is the file or folder ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The MIME type of the target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; } 

        /// <summary>The name of the target. For example, in Google Drive, this is the title of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A representation of a user.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean which indicates whether the specified User was deleted. If true, name, photo and
        /// permission_id will be omitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDeleted")]
        public virtual System.Nullable<bool> IsDeleted { get; set; } 

        /// <summary>Whether the user is the authenticated user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMe")]
        public virtual System.Nullable<bool> IsMe { get; set; } 

        /// <summary>The displayable name of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The permission ID associated with this user. Equivalent to the Drive API's permission ID for this
        /// user, returned as part of the Drive Permissions resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; } 

        /// <summary>The profile photo of the user. Not present if the user has no profile photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photo")]
        public virtual Photo Photo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
