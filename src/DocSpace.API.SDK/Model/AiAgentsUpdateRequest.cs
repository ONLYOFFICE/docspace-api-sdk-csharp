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
    /// AiAgentsUpdateRequest
    /// </summary>
    [DataContract(Name = "aiAgentsUpdate_request")]
    public partial class AiAgentsUpdateRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAgentsUpdateRequest" /> class.
        /// </summary>
        /// <param name="profileId">Profile id to rebind (optional)..</param>
        /// <param name="chatSettings">Chat settings (&#x60;ChatSettings&#x60;); requires a valid provider/model..</param>
        /// <param name="sendFormToExternalDB">Whether form results are sent to an external DB..</param>
        /// <param name="saveFormAsXLSX">Whether forms are saved as XLSX..</param>
        /// <param name="title">Agent (room) title..</param>
        /// <param name="quota">Room quota in bytes..</param>
        /// <param name="indexing">Whether room content is indexed for search..</param>
        /// <param name="denyDownload">Whether downloading room content is denied..</param>
        /// <param name="lifetime">Room data lifetime policy (&#x60;RoomDataLifetimeDto&#x60;)..</param>
        /// <param name="watermark">Watermark settings (&#x60;WatermarkRequestDto&#x60;)..</param>
        /// <param name="logo">Room logo (&#x60;LogoRequest&#x60;)..</param>
        /// <param name="tags">Room tags..</param>
        /// <param name="color">Room accent color..</param>
        /// <param name="cover">Room cover image id..</param>
        public AiAgentsUpdateRequest(string profileId = default, Object chatSettings = default, bool sendFormToExternalDB = default, bool saveFormAsXLSX = default, string title = default, decimal quota = default, bool indexing = default, bool denyDownload = default, Object lifetime = default, Object watermark = default, Object logo = default, List<string> tags = default, string color = default, string cover = default)
        {
            this.ProfileId = profileId;
            this.ChatSettings = chatSettings;
            this.SendFormToExternalDB = sendFormToExternalDB;
            this.SaveFormAsXLSX = saveFormAsXLSX;
            this.Title = title;
            this.Quota = quota;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Logo = logo;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
        }

        /// <summary>
        /// Profile id to rebind (optional).
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Chat settings (&#x60;ChatSettings&#x60;); requires a valid provider/model.
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public Object ChatSettings { get; set; }

        /// <summary>
        /// Whether form results are sent to an external DB.
        /// </summary>
        [DataMember(Name = "sendFormToExternalDB", EmitDefaultValue = true)]
        public bool SendFormToExternalDB { get; set; }

        /// <summary>
        /// Whether forms are saved as XLSX.
        /// </summary>
        [DataMember(Name = "saveFormAsXLSX", EmitDefaultValue = true)]
        public bool SaveFormAsXLSX { get; set; }

        /// <summary>
        /// Agent (room) title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Room quota in bytes.
        /// </summary>
        [DataMember(Name = "quota", EmitDefaultValue = false)]
        public decimal Quota { get; set; }

        /// <summary>
        /// Whether room content is indexed for search.
        /// </summary>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Whether downloading room content is denied.
        /// </summary>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// Room data lifetime policy (&#x60;RoomDataLifetimeDto&#x60;).
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public Object Lifetime { get; set; }

        /// <summary>
        /// Watermark settings (&#x60;WatermarkRequestDto&#x60;).
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public Object Watermark { get; set; }

        /// <summary>
        /// Room logo (&#x60;LogoRequest&#x60;).
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Object Logo { get; set; }

        /// <summary>
        /// Room tags.
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Room accent color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Room cover image id.
        /// </summary>
        [DataMember(Name = "cover", EmitDefaultValue = false)]
        public string Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAgentsUpdateRequest {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  ChatSettings: ").Append(ChatSettings).Append("\n");
            sb.Append("  SendFormToExternalDB: ").Append(SendFormToExternalDB).Append("\n");
            sb.Append("  SaveFormAsXLSX: ").Append(SaveFormAsXLSX).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
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
