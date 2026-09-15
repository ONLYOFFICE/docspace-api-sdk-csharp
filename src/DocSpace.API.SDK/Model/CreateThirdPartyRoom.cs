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
    /// The room to be created out of a folder of a connected third-party storage account.
    /// </summary>
    [DataContract(Name = "CreateThirdPartyRoom")]
    public partial class CreateThirdPartyRoom : IValidatableObject
    {

        /// <summary>
        /// The kind of room the folder becomes, which decides the default access rules of its members and cannot be  changed afterwards.
        /// </summary>
        [DataMember(Name = "roomType", IsRequired = true, EmitDefaultValue = true)]
        public RoomType RoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateThirdPartyRoom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        /// <param name="createAsNewFolder">Creates a new folder named after &#x60;title&#x60; inside the folder named in the path and turns that subfolder into the  room, leaving the named folder itself untouched. When omitted, the named folder becomes the room and keeps  everything it already holds..</param>
        /// <param name="title">The name the room is shown under. It is stored on the connected account, so it does not have to match the name  of the folder in the storage; with &#x60;createAsNewFolder&#x60; it is also the name given to the created subfolder. (required).</param>
        /// <param name="roomType">The kind of room the folder becomes, which decides the default access rules of its members and cannot be  changed afterwards. (required).</param>
        /// <param name="private">Restricts the room to the members explicitly invited into it. The flag is kept on the connected storage  account rather than on the folder, so every folder read through that account reports the same value..</param>
        /// <param name="indexing">Keeps the contents of the room in an explicit numbered order, the one reported as &#x60;order&#x60; on every entry,  instead of leaving the order to the reader..</param>
        /// <param name="denyDownload">Forbids downloading and printing the contents of the room, which leaves the members with viewing and editing  in the editor only..</param>
        /// <param name="color">The background colour drawn behind the cover of the room, as six hexadecimal digits without a leading number  sign. An empty value restores the colour the portal picks by default..</param>
        /// <param name="cover">The drawing shown on the room tile, named by one of the built-in cover identifiers returned by  &#x60;GET api/2.0/files/rooms/covers&#x60;. An empty value leaves the room without a cover, and any other unknown value  is rejected as an invalid request..</param>
        /// <param name="tags">The tags to attach to the room, named by their text. A name that is not in the portal tag catalogue yet is  added to it, and &#x60;GET api/2.0/files/tags&#x60; lists the names already there..</param>
        /// <param name="logo">The picture to use as the room logo, which has to be uploaded with &#x60;POST api/2.0/files/logos&#x60; first; leaving  it out keeps the room on its cover and colour..</param>
        public CreateThirdPartyRoom(bool createAsNewFolder = default, string title = default, RoomType roomType = default, bool @private = default, bool indexing = default, bool denyDownload = default, string color = default, string cover = default, List<string> tags = default, LogoRequest logo = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateThirdPartyRoom and cannot be null");
            }
            this.Title = title;
            this.RoomType = roomType;
            this.CreateAsNewFolder = createAsNewFolder;
            this.Private = @private;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Color = color;
            this.Cover = cover;
            this.Tags = tags;
            this.Logo = logo;
        }

        /// <summary>
        /// Creates a new folder named after &#x60;title&#x60; inside the folder named in the path and turns that subfolder into the  room, leaving the named folder itself untouched. When omitted, the named folder becomes the room and keeps  everything it already holds.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "createAsNewFolder", EmitDefaultValue = true)]
        public bool CreateAsNewFolder { get; set; }

        /// <summary>
        /// The name the room is shown under. It is stored on the connected account, so it does not have to match the name  of the folder in the storage; with &#x60;createAsNewFolder&#x60; it is also the name given to the created subfolder.
        /// </summary>
        /// <example>Third-party project room</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Restricts the room to the members explicitly invited into it. The flag is kept on the connected storage  account rather than on the folder, so every folder read through that account reports the same value.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Keeps the contents of the room in an explicit numbered order, the one reported as &#x60;order&#x60; on every entry,  instead of leaving the order to the reader.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Forbids downloading and printing the contents of the room, which leaves the members with viewing and editing  in the editor only.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The background colour drawn behind the cover of the room, as six hexadecimal digits without a leading number  sign. An empty value restores the colour the portal picks by default.
        /// </summary>
        /// <example>FF5733</example>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The drawing shown on the room tile, named by one of the built-in cover identifiers returned by  &#x60;GET api/2.0/files/rooms/covers&#x60;. An empty value leaves the room without a cover, and any other unknown value  is rejected as an invalid request.
        /// </summary>
        /// <example>bookmark</example>
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// The tags to attach to the room, named by their text. A name that is not in the portal tag catalogue yet is  added to it, and &#x60;GET api/2.0/files/tags&#x60; lists the names already there.
        /// </summary>
        /// <example>["Marketing","Q3"]</example>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The picture to use as the room logo, which has to be uploaded with &#x60;POST api/2.0/files/logos&#x60; first; leaving  it out keeps the room on its cover and colour.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThirdPartyRoom {\n");
            sb.Append("  CreateAsNewFolder: ").Append(CreateAsNewFolder).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
