// (c) Copyright Ascensio System SIA 2026
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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The room link parameters.
    /// </summary>
    [DataContract(Name = "RoomLinkRequest")]
    public partial class RoomLinkRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name = "linkType", EmitDefaultValue = false)]
        public LinkType? LinkType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomLinkRequest" /> class.
        /// </summary>
        /// <param name="linkId">The room link ID..</param>
        /// <param name="access">access.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="internal">The link scope, whether it is internal or not..</param>
        /// <param name="title">The link name..</param>
        /// <param name="linkType">linkType.</param>
        /// <param name="password">The link password..</param>
        /// <param name="denyDownload">Specifies if downloading the file from the link is disabled or not..</param>
        /// <param name="maxUseCount">The maximum number of times the invitation link can be used..</param>
        /// <param name="currentUseCount">The current number of times the invitation link has been used..</param>
        public RoomLinkRequest(Guid linkId = default, FileShare? access = default, ApiDateTime expirationDate = default, bool @internal = default, string title = default, LinkType? linkType = default, string password = default, bool denyDownload = default, int? maxUseCount = default, int currentUseCount = default)
        {
            this.LinkId = linkId;
            this.Access = access;
            this.ExpirationDate = expirationDate;
            this.Internal = @internal;
            this.Title = title;
            this.LinkType = linkType;
            this.Password = password;
            this.DenyDownload = denyDownload;
            this.MaxUseCount = maxUseCount;
            this.CurrentUseCount = currentUseCount;
        }

        /// <summary>
        /// The room link ID.
        /// </summary>
        /// <value>The room link ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The link scope, whether it is internal or not.
        /// </summary>
        /// <value>The link scope, whether it is internal or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; set; }

        /// <summary>
        /// The link name.
        /// </summary>
        /// <value>The link name.</value>
        /*
        <example>My Document</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The link password.
        /// </summary>
        /// <value>The link password.</value>
        /*
        <example>doc_key_123</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies if downloading the file from the link is disabled or not.
        /// </summary>
        /// <value>Specifies if downloading the file from the link is disabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The maximum number of times the invitation link can be used.
        /// </summary>
        /// <value>The maximum number of times the invitation link can be used.</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

        /// <summary>
        /// The current number of times the invitation link has been used.
        /// </summary>
        /// <value>The current number of times the invitation link has been used.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "currentUseCount", EmitDefaultValue = false)]
        public int CurrentUseCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomLinkRequest {\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  MaxUseCount: ").Append(MaxUseCount).Append("\n");
            sb.Append("  CurrentUseCount: ").Append(CurrentUseCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 255.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 0.", new [] { "Password" });
            }

            // MaxUseCount (int?) maximum
            if (this.MaxUseCount > (int?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value less than or equal to 1000.", new [] { "MaxUseCount" });
            }

            // MaxUseCount (int?) minimum
            if (this.MaxUseCount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value greater than or equal to 1.", new [] { "MaxUseCount" });
            }

            yield break;
        }

    }


}
