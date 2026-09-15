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
    /// A sharing link of a file, a folder or a room, with everything set on it.
    /// </summary>
    [DataContract(Name = "FileShareLink")]
    public partial class FileShareLink : IValidatableObject
    {

        /// <summary>
        /// Which of the two jobs the link does: letting somebody into the room as a member, or handing out the entry  itself. The counters of uses are filled in for the first kind only.
        /// </summary>
        [DataMember(Name = "linkType", EmitDefaultValue = false)]
        public LinkType? LinkType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareLink" /> class.
        /// </summary>
        /// <param name="id">The identifier of the link, the one to send back as &#x60;linkId&#x60; to change or delete it..</param>
        /// <param name="title">The name the link is listed under, which its author is free to choose and to leave empty..</param>
        /// <param name="shareLink">The shortened address to hand out. Opening it is what turns the link into access; the address stays the same  while the link exists..</param>
        /// <param name="expirationDate">The moment the link stops working, written with the offset of the portal time zone. Null when the link was  left without an end..</param>
        /// <param name="linkType">Which of the two jobs the link does: letting somebody into the room as a member, or handing out the entry  itself. The counters of uses are filled in for the first kind only..</param>
        /// <param name="password">The password a visitor has to send before the link resolves, readable only by those who may manage the link.  Empty when the link asks for none..</param>
        /// <param name="denyDownload">Whether visitors coming through this link may only read the entry in the editor and not download or print it..</param>
        /// <param name="isExpired">Whether the moment in &#x60;expirationDate&#x60; has already passed, which leaves the link in place but refuses  everybody who opens it..</param>
        /// <param name="primary">Whether this is the one link the entry always keeps: a public or a form-filling room is given it at creation,  and deleting it there only makes a new one..</param>
        /// <param name="internal">Whether the visitor has to sign in to the portal before the link resolves, as opposed to it being open to  anybody who has the address..</param>
        /// <param name="requestToken">The key that stands for this link in the calls that resolve it, such as &#x60;GET api/2.0/files/share/{key}&#x60;. It is  filled in for links that hand out the entry, and empty for the ones that invite into a room..</param>
        /// <param name="maxUseCount">How many accounts may still join the room through this invitation link in total. Null on a link that hands out  the entry, where nothing is counted..</param>
        /// <param name="currentUseCount">How many accounts have already joined through this invitation link. Once it reaches &#x60;maxUseCount&#x60; the link  stops letting anybody else in. Null on a link that hands out the entry..</param>
        public FileShareLink(Guid id = default, string title = default, string shareLink = default, ApiDateTime expirationDate = default, LinkType? linkType = default, string password = default, bool? denyDownload = default, bool? isExpired = default, bool primary = default, bool? @internal = default, string requestToken = default, int? maxUseCount = default, int? currentUseCount = default)
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
            this.MaxUseCount = maxUseCount;
            this.CurrentUseCount = currentUseCount;
        }

        /// <summary>
        /// The identifier of the link, the one to send back as &#x60;linkId&#x60; to change or delete it.
        /// </summary>
        /// <example>9a2c1b3e-6d47-4f10-9b52-ac7d3e5f0812</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The name the link is listed under, which its author is free to choose and to leave empty.
        /// </summary>
        /// <example>Shared document</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The shortened address to hand out. Opening it is what turns the link into access; the address stays the same  while the link exists.
        /// </summary>
        /// <example>https://portal.example.com/s/a1b2c3d4</example>
        [DataMember(Name = "shareLink", EmitDefaultValue = true)]
        public string ShareLink { get; set; }

        /// <summary>
        /// The moment the link stops working, written with the offset of the portal time zone. Null when the link was  left without an end.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The password a visitor has to send before the link resolves, readable only by those who may manage the link.  Empty when the link asks for none.
        /// </summary>
        /// <example>S3cretPhrase</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Whether visitors coming through this link may only read the entry in the editor and not download or print it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool? DenyDownload { get; set; }

        /// <summary>
        /// Whether the moment in &#x60;expirationDate&#x60; has already passed, which leaves the link in place but refuses  everybody who opens it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isExpired", EmitDefaultValue = true)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Whether this is the one link the entry always keeps: a public or a form-filling room is given it at creation,  and deleting it there only makes a new one.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// Whether the visitor has to sign in to the portal before the link resolves, as opposed to it being open to  anybody who has the address.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool? Internal { get; set; }

        /// <summary>
        /// The key that stands for this link in the calls that resolve it, such as &#x60;GET api/2.0/files/share/{key}&#x60;. It is  filled in for links that hand out the entry, and empty for the ones that invite into a room.
        /// </summary>
        /// <example>gg9J4mBW7pW9Wk0HqQoQ9L2mS1x6bK8vTnQ0aZ3</example>
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// How many accounts may still join the room through this invitation link in total. Null on a link that hands out  the entry, where nothing is counted.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

        /// <summary>
        /// How many accounts have already joined through this invitation link. Once it reaches &#x60;maxUseCount&#x60; the link  stops letting anybody else in. Null on a link that hands out the entry.
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "currentUseCount", EmitDefaultValue = true)]
        public int? CurrentUseCount { get; set; }

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
            yield break;
        }

    }


}
