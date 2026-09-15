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
    /// The external link of a folder, as it is to be created or rewritten.
    /// </summary>
    [DataContract(Name = "FolderLinkRequest")]
    public partial class FolderLinkRequest : IValidatableObject
    {

        /// <summary>
        /// The rights a visitor following the link is given. The value that grants nothing revokes the link instead of  setting it, and the answer is then empty.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderLinkRequest" /> class.
        /// </summary>
        /// <param name="linkId">Which link the request addresses: the identifier of an existing link rewrites that link, while an identifier  that is not in use, the empty one included, creates a new link. Take an existing identifier from  &#x60;GET api/2.0/files/folder/{id}/links&#x60;..</param>
        /// <param name="access">The rights a visitor following the link is given. The value that grants nothing revokes the link instead of  setting it, and the answer is then empty..</param>
        /// <param name="expirationDate">The moment the link stops working, sent as an ISO-8601 stamp. A moment that lies in the past is ignored,  and leaving the field out gives the link no expiry..</param>
        /// <param name="title">The name the link is listed under for the people who manage the folder; a visitor following it never sees the  name..</param>
        /// <param name="password">The secret a visitor has to enter before the link opens. Leave it out for a link that opens without one; the  secret itself is never given back, only the fact that one is set..</param>
        /// <param name="denyDownload">Whether visitors are left with viewing alone: with true downloading and copying through the link are blocked,  with false they are allowed..</param>
        /// <param name="internal">Whether the link admits signed-in portal members only: with true a visitor has to sign in before the link  opens, with false anyone holding the address may follow it..</param>
        /// <param name="primary">Whether this link becomes the primary link of the folder, the one the Copy link action of a client hands  out; a folder has one primary link at a time..</param>
        public FolderLinkRequest(Guid linkId = default, FileShare? access = default, ApiDateTime expirationDate = default, string title = default, string password = default, bool denyDownload = default, bool @internal = default, bool primary = default)
        {
            this.LinkId = linkId;
            this.Access = access;
            this.ExpirationDate = expirationDate;
            this.Title = title;
            this.Password = password;
            this.DenyDownload = denyDownload;
            this.Internal = @internal;
            this.Primary = primary;
        }

        /// <summary>
        /// Which link the request addresses: the identifier of an existing link rewrites that link, while an identifier  that is not in use, the empty one included, creates a new link. Take an existing identifier from  &#x60;GET api/2.0/files/folder/{id}/links&#x60;.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// The moment the link stops working, sent as an ISO-8601 stamp. A moment that lies in the past is ignored,  and leaving the field out gives the link no expiry.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The name the link is listed under for the people who manage the folder; a visitor following it never sees the  name.
        /// </summary>
        /// <example>Public link</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The secret a visitor has to enter before the link opens. Leave it out for a link that opens without one; the  secret itself is never given back, only the fact that one is set.
        /// </summary>
        /// <example>p@ssw0rd</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Whether visitors are left with viewing alone: with true downloading and copying through the link are blocked,  with false they are allowed.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// Whether the link admits signed-in portal members only: with true a visitor has to sign in before the link  opens, with false anyone holding the address may follow it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; set; }

        /// <summary>
        /// Whether this link becomes the primary link of the folder, the one the Copy link action of a client hands  out; a folder has one primary link at a time.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderLinkRequest {\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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

            yield break;
        }

    }


}
