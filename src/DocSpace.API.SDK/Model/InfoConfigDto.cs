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
    /// The facts the editor information panel shows about the open document.
    /// </summary>
    [DataContract(Name = "InfoConfigDto")]
    public partial class InfoConfigDto : IValidatableObject
    {

        /// <summary>
        /// The layout the information panel is rendered for.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EditorType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoConfigDto" /> class.
        /// </summary>
        /// <param name="favorite">Whether the caller has this document among their favorites. It is empty when favorites do not apply - for an  anonymous caller, for a guest, and for an encrypted document..</param>
        /// <param name="folder">The place of the document as a readable path, its folders joined from the root downwards. It is empty in the  embedded layout, which shows no such panel..</param>
        /// <param name="owner">The display name of the owner of the document. It is empty for an anonymous session..</param>
        /// <param name="sharingSettings">Who the document is shared with, as the information panel lists it. An empty list means it is shared with  nobody beyond its owner..</param>
        /// <param name="type">The layout the information panel is rendered for..</param>
        /// <param name="uploaded">When the document was created on the portal, already formatted for reading in the culture of the caller rather  than as a machine timestamp..</param>
        public InfoConfigDto(bool? favorite = default, string folder = default, string owner = default, List<AceShortWrapper> sharingSettings = default, EditorType? type = default, string uploaded = default)
        {
            this.Favorite = favorite;
            this.Folder = folder;
            this.Owner = owner;
            this.SharingSettings = sharingSettings;
            this.Type = type;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Whether the caller has this document among their favorites. It is empty when favorites do not apply - for an  anonymous caller, for a guest, and for an encrypted document.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "favorite", EmitDefaultValue = true)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// The place of the document as a readable path, its folders joined from the root downwards. It is empty in the  embedded layout, which shows no such panel.
        /// </summary>
        /// <example>My documents \\ Reports</example>
        [DataMember(Name = "folder", EmitDefaultValue = true)]
        public string Folder { get; set; }

        /// <summary>
        /// The display name of the owner of the document. It is empty for an anonymous session.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Who the document is shared with, as the information panel lists it. An empty list means it is shared with  nobody beyond its owner.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "sharingSettings", EmitDefaultValue = true)]
        public List<AceShortWrapper> SharingSettings { get; set; }

        /// <summary>
        /// When the document was created on the portal, already formatted for reading in the culture of the caller rather  than as a machine timestamp.
        /// </summary>
        /// <example>01/01/2026 12:00 PM</example>
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public string Uploaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoConfigDto {\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SharingSettings: ").Append(SharingSettings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
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
