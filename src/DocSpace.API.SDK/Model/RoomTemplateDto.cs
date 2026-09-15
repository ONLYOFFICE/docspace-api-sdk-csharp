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
    /// The parameters of a room template built from an existing room.
    /// </summary>
    [DataContract(Name = "RoomTemplateDto")]
    public partial class RoomTemplateDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomTemplateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateDto" /> class.
        /// </summary>
        /// <param name="roomId">The identifier of the room the template is built from. Take it from the room listing of  &#x60;GET api/2.0/files/rooms&#x60;; a folder identifier is not accepted. (required).</param>
        /// <param name="title">The title the template is saved under in the Templates section. Characters that a folder name cannot contain  are replaced with an underscore on save, and two templates may share a title. (required).</param>
        /// <param name="logo">A picture of the caller&#39;s own for the template, cropped out of an image already placed in the temporary  storage..</param>
        /// <param name="copyLogo">Whether the template takes over the picture already set on the source room. When false the template gets no  picture from that room..</param>
        /// <param name="share">The email addresses of the portal members who are granted read access to the finished template..</param>
        /// <param name="groups">The identifiers of the portal groups whose members are granted read access to the finished template..</param>
        /// <param name="public">Whether the finished template is shared with everyone allowed to create rooms. When false it stays reachable  only for the recipients named for it..</param>
        /// <param name="tags">The labels attached to the template and shown next to it in listings..</param>
        /// <param name="color">The accent colour of the generated cover, written as six hexadecimal digits with no leading hash sign. When it  is left empty a colour is picked at random..</param>
        /// <param name="cover">The identifier of a built-in cover picture, as listed by &#x60;GET api/2.0/files/rooms/covers&#x60;. When it is left  empty the template gets no cover..</param>
        /// <param name="quota">The storage limit assigned to the template, in bytes. When it is not set the template keeps the limit of the  source room..</param>
        public RoomTemplateDto(int roomId = default, string title = default, LogoRequest logo = default, bool copyLogo = default, List<string> share = default, List<Guid> groups = default, bool @public = default, List<string> tags = default, string color = default, string cover = default, long? quota = default)
        {
            this.RoomId = roomId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for RoomTemplateDto and cannot be null");
            }
            this.Title = title;
            this.Logo = logo;
            this.CopyLogo = copyLogo;
            this.Share = share;
            this.Groups = groups;
            this.Public = @public;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
            this.Quota = quota;
        }

        /// <summary>
        /// The identifier of the room the template is built from. Take it from the room listing of  &#x60;GET api/2.0/files/rooms&#x60;; a folder identifier is not accepted.
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name = "roomId", IsRequired = true, EmitDefaultValue = true)]
        public int RoomId { get; set; }

        /// <summary>
        /// The title the template is saved under in the Templates section. Characters that a folder name cannot contain  are replaced with an underscore on save, and two templates may share a title.
        /// </summary>
        /// <example>Sales agreement room</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// A picture of the caller&#39;s own for the template, cropped out of an image already placed in the temporary  storage.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Whether the template takes over the picture already set on the source room. When false the template gets no  picture from that room.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "copyLogo", EmitDefaultValue = true)]
        public bool CopyLogo { get; set; }

        /// <summary>
        /// The email addresses of the portal members who are granted read access to the finished template.
        /// </summary>
        /// <example>["user1@example.com","user2@example.com"]</example>
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<string> Share { get; set; }

        /// <summary>
        /// The identifiers of the portal groups whose members are granted read access to the finished template.
        /// </summary>
        /// <example>["9924256a-739c-462b-af15-e652a3b1b6eb"]</example>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Whether the finished template is shared with everyone allowed to create rooms. When false it stays reachable  only for the recipients named for it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool Public { get; set; }

        /// <summary>
        /// The labels attached to the template and shown next to it in listings.
        /// </summary>
        /// <example>["Contracts","Sales"]</example>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The accent colour of the generated cover, written as six hexadecimal digits with no leading hash sign. When it  is left empty a colour is picked at random.
        /// </summary>
        /// <example>FF5733</example>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The identifier of a built-in cover picture, as listed by &#x60;GET api/2.0/files/rooms/covers&#x60;. When it is left  empty the template gets no cover.
        /// </summary>
        /// <example>bookmark</example>
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// The storage limit assigned to the template, in bytes. When it is not set the template keeps the limit of the  source room.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public long? Quota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomTemplateDto {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CopyLogo: ").Append(CopyLogo).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
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
            if (this.Title != null && this.Title.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 400.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

            // Color (string) maxLength
            if (this.Color != null && this.Color.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be less than 6.", new [] { "Color" });
            }

            // Color (string) minLength
            if (this.Color != null && this.Color.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be greater than 0.", new [] { "Color" });
            }

            // Cover (string) maxLength
            if (this.Cover != null && this.Cover.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cover, length must be less than 50.", new [] { "Cover" });
            }

            // Cover (string) minLength
            if (this.Cover != null && this.Cover.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cover, length must be greater than 0.", new [] { "Cover" });
            }

            yield break;
        }

    }


}
