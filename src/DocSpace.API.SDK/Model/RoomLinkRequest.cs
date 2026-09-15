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
    /// The link of a room to create, change or revoke.
    /// </summary>
    [DataContract(Name = "RoomLinkRequest")]
    public partial class RoomLinkRequest : IValidatableObject
    {

        /// <summary>
        /// What whoever opens the link may do in the room. The value 0 revokes the link instead of changing it, and the  levels a room accepts depend on its kind.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Which kind of link to create: an invitation link makes whoever opens it a member of the room, while an  external link opens the room without an account. It is fixed when the link is created and is ignored on later  changes.
        /// </summary>
        [DataMember(Name = "linkType", EmitDefaultValue = false)]
        public LinkType? LinkType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomLinkRequest" /> class.
        /// </summary>
        /// <param name="linkId">Which link to change, taken from &#x60;GET api/2.0/files/rooms/{id}/links&#x60;. Leaving it out creates a link, and an  identifier the room does not know creates a link carrying that identifier..</param>
        /// <param name="access">What whoever opens the link may do in the room. The value 0 revokes the link instead of changing it, and the  levels a room accepts depend on its kind..</param>
        /// <param name="expirationDate">When the link stops working, written with the offset of the portal time zone. A date already past is dropped  silently for an external link and refused for an invitation link, and a date further ahead than the portal  allows is refused as well; leaving it out means the link does not expire..</param>
        /// <param name="internal">Whether the external link works only for people already signed in to the portal. With it off the link opens  the room for anyone who has the address, subject to the password..</param>
        /// <param name="title">The name the link is shown under in the room. An empty value is accepted and the portal names the link itself,  so the answer is what tells the caller the name in use..</param>
        /// <param name="linkType">Which kind of link to create: an invitation link makes whoever opens it a member of the room, while an  external link opens the room without an account. It is fixed when the link is created and is ignored on later  changes..</param>
        /// <param name="password">The password an external link asks for before it opens the room. An empty value leaves the link open to anyone  who has the address, and the password is never returned when links are listed..</param>
        /// <param name="denyDownload">Whether people arriving through the link are stopped from downloading and printing what they open. They can  still read the documents in the editor..</param>
        /// <param name="maxUseCount">How many people an invitation link may still let in before it stops working. A value below the number of  people who already used it is refused, and leaving it out puts no ceiling on the link..</param>
        /// <param name="currentUseCount">How many people have already joined through this invitation link. The value is kept by the portal: it is  reported back when links are listed and anything sent here is ignored..</param>
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
        /// Which link to change, taken from &#x60;GET api/2.0/files/rooms/{id}/links&#x60;. Leaving it out creates a link, and an  identifier the room does not know creates a link carrying that identifier.
        /// </summary>
        /// <example>b3f1c8de-5a64-4d1e-9f27-6c0a8d5b7e41</example>
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// When the link stops working, written with the offset of the portal time zone. A date already past is dropped  silently for an external link and refused for an invitation link, and a date further ahead than the portal  allows is refused as well; leaving it out means the link does not expire.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// Whether the external link works only for people already signed in to the portal. With it off the link opens  the room for anyone who has the address, subject to the password.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; set; }

        /// <summary>
        /// The name the link is shown under in the room. An empty value is accepted and the portal names the link itself,  so the answer is what tells the caller the name in use.
        /// </summary>
        /// <example>Read-only access for auditors</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The password an external link asks for before it opens the room. An empty value leaves the link open to anyone  who has the address, and the password is never returned when links are listed.
        /// </summary>
        /// <example>S3cret-Phrase</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Whether people arriving through the link are stopped from downloading and printing what they open. They can  still read the documents in the editor.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// How many people an invitation link may still let in before it stops working. A value below the number of  people who already used it is refused, and leaving it out puts no ceiling on the link.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

        /// <summary>
        /// How many people have already joined through this invitation link. The value is kept by the portal: it is  reported back when links are listed and anything sent here is ignored.
        /// </summary>
        /// <example>0</example>
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
