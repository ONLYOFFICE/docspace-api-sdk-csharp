// (c) Copyright Ascensio System SIA 2025
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// A shareable link for a file with its configuration and status.
    /// </summary>
    [DataContract(Name = "FileShareLink")]
    public partial class FileShareLink : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name = "linkType", EmitDefaultValue = false)]
        public LinkType? LinkType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareLink" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the shared link..</param>
        /// <param name="title">The title of the shared content..</param>
        /// <param name="shareLink">The URL for accessing the shared content..</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="linkType">linkType.</param>
        /// <param name="password">The password protection for accessing the shared content..</param>
        /// <param name="denyDownload">Indicates whether downloading of the shared content is prohibited..</param>
        /// <param name="isExpired">Indicates whether the shared link has expired..</param>
        /// <param name="primary">Indicates whether this is the primary shared link..</param>
        /// <param name="@internal">Indicates whether the link is for the internal sharing only..</param>
        /// <param name="requestToken">The token for validating access requests..</param>
        public FileShareLink(Guid id = default, string title = default, string shareLink = default, ApiDateTime expirationDate = default, LinkType? linkType = default, string password = default, bool? denyDownload = default, bool? isExpired = default, bool primary = default, bool? @internal = default, string requestToken = default)
        {
            this.Id = id;
            this.Title = title;
            this.ShareLink = shareLink;
            this.ExpirationDate = expirationDate;
            this.LinkType = linkType;
            this.Password = password;
            this.DenyDownload = denyDownload;
            this.IsExpired = isExpired;
            this.Primary = primary;
            this.Internal = @internal;
            this.RequestToken = requestToken;
        }

        /// <summary>
        /// The unique identifier of the shared link.
        /// </summary>
        /// <value>The unique identifier of the shared link.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The title of the shared content.
        /// </summary>
        /// <value>The title of the shared content.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The URL for accessing the shared content.
        /// </summary>
        /// <value>The URL for accessing the shared content.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shareLink", EmitDefaultValue = true)]
        public string ShareLink { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The password protection for accessing the shared content.
        /// </summary>
        /// <value>The password protection for accessing the shared content.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Indicates whether downloading of the shared content is prohibited.
        /// </summary>
        /// <value>Indicates whether downloading of the shared content is prohibited.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool? DenyDownload { get; set; }

        /// <summary>
        /// Indicates whether the shared link has expired.
        /// </summary>
        /// <value>Indicates whether the shared link has expired.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isExpired", EmitDefaultValue = true)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Indicates whether this is the primary shared link.
        /// </summary>
        /// <value>Indicates whether this is the primary shared link.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// Indicates whether the link is for the internal sharing only.
        /// </summary>
        /// <value>Indicates whether the link is for the internal sharing only.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool? Internal { get; set; }

        /// <summary>
        /// The token for validating access requests.
        /// </summary>
        /// <value>The token for validating access requests.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileShareLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ShareLink: ").Append(ShareLink).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }


}
