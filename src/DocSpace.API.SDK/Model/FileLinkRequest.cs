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
    /// The settings of an external link to a file.
    /// </summary>
    [DataContract(Name = "FileLinkRequest")]
    public partial class FileLinkRequest : IValidatableObject
    {

        /// <summary>
        /// The rights the link grants to whoever follows it. The value that denies everything revokes the link.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLinkRequest" /> class.
        /// </summary>
        /// <param name="linkId">The link to rewrite, as reported by &#x60;GET api/2.0/files/file/{id}/links&#x60;. An identifier that is not yet in use,  the empty one included, creates a link instead..</param>
        /// <param name="access">The rights the link grants to whoever follows it. The value that denies everything revokes the link..</param>
        /// <param name="expirationDate">The moment the link stops working, read in the time zone of the portal. A date more than a few years ahead is  rejected as an invalid request; left out, the link does not expire on its own..</param>
        /// <param name="title">The name the link carries in the sharing list of the file, for the people who manage it; it is not shown to  whoever follows the link..</param>
        /// <param name="internal">Who may follow the link: &#x60;true&#x60; admits only accounts that are signed in to the portal, &#x60;false&#x60; admits anybody  who has the address..</param>
        /// <param name="primary">Whether this link becomes the primary link of the file - the one the Copy link action of a client hands out.  A file has one primary link at a time..</param>
        /// <param name="denyDownload">What a visitor may do with the content: &#x60;true&#x60; leaves them with viewing in the browser, &#x60;false&#x60; lets them  download and print it as their rights allow..</param>
        /// <param name="password">The secret a visitor has to type before the file opens; left out, the link opens without one..</param>
        public FileLinkRequest(Guid linkId = default, FileShare? access = default, ApiDateTime expirationDate = default, string title = default, bool @internal = default, bool primary = default, bool denyDownload = default, string password = default)
        {
            this.LinkId = linkId;
            this.Access = access;
            this.ExpirationDate = expirationDate;
            this.Title = title;
            this.Internal = @internal;
            this.Primary = primary;
            this.DenyDownload = denyDownload;
            this.Password = password;
        }

        /// <summary>
        /// The link to rewrite, as reported by &#x60;GET api/2.0/files/file/{id}/links&#x60;. An identifier that is not yet in use,  the empty one included, creates a link instead.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// The moment the link stops working, read in the time zone of the portal. A date more than a few years ahead is  rejected as an invalid request; left out, the link does not expire on its own.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The name the link carries in the sharing list of the file, for the people who manage it; it is not shown to  whoever follows the link.
        /// </summary>
        /// <example>My Document</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Who may follow the link: &#x60;true&#x60; admits only accounts that are signed in to the portal, &#x60;false&#x60; admits anybody  who has the address.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; set; }

        /// <summary>
        /// Whether this link becomes the primary link of the file - the one the Copy link action of a client hands out.  A file has one primary link at a time.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// What a visitor may do with the content: &#x60;true&#x60; leaves them with viewing in the browser, &#x60;false&#x60; lets them  download and print it as their rights allow.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The secret a visitor has to type before the file opens; left out, the link opens without one.
        /// </summary>
        /// <example>p@ssw0rd</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLinkRequest {\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
