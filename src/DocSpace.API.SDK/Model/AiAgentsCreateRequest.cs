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
    /// AiAgentsCreateRequest
    /// </summary>
    [DataContract(Name = "aiAgentsCreate_request")]
    public partial class AiAgentsCreateRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAgentsCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAgentsCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAgentsCreateRequest" /> class.
        /// </summary>
        /// <param name="profileId">Profile id bound to the agent. (required).</param>
        /// <param name="prompt">Agent system prompt; stored as the room&#39;s &#x60;chatSettings.prompt&#x60;. (required).</param>
        /// <param name="private">Whether the agent room is private..</param>
        /// <param name="share">Initial share entries (&#x60;FileShareParams&#x60;)..</param>
        /// <param name="attachDefaultTools">Whether to attach the default DocSpace MCP tool server..</param>
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
        public AiAgentsCreateRequest(string profileId = default, string prompt = default, bool @private = default, List<Object> share = default, bool attachDefaultTools = default, string title = default, decimal quota = default, bool indexing = default, bool denyDownload = default, Object lifetime = default, Object watermark = default, Object logo = default, List<string> tags = default, string color = default, string cover = default)
        {
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new ArgumentNullException("profileId is a required property for AiAgentsCreateRequest and cannot be null");
            }
            this.ProfileId = profileId;
            // to ensure "prompt" is required (not null)
            if (prompt == null)
            {
                throw new ArgumentNullException("prompt is a required property for AiAgentsCreateRequest and cannot be null");
            }
            this.Prompt = prompt;
            this.Private = @private;
            this.Share = share;
            this.AttachDefaultTools = attachDefaultTools;
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
        /// Profile id bound to the agent.
        /// </summary>
        /// <value>Profile id bound to the agent.</value>
        [DataMember(Name = "profileId", IsRequired = true, EmitDefaultValue = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Agent system prompt; stored as the room&#39;s &#x60;chatSettings.prompt&#x60;.
        /// </summary>
        /// <value>Agent system prompt; stored as the room&#39;s &#x60;chatSettings.prompt&#x60;.</value>
        [DataMember(Name = "prompt", IsRequired = true, EmitDefaultValue = true)]
        public string Prompt { get; set; }

        /// <summary>
        /// Whether the agent room is private.
        /// </summary>
        /// <value>Whether the agent room is private.</value>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Initial share entries (&#x60;FileShareParams&#x60;).
        /// </summary>
        /// <value>Initial share entries (&#x60;FileShareParams&#x60;).</value>
        [DataMember(Name = "share", EmitDefaultValue = false)]
        public List<Object> Share { get; set; }

        /// <summary>
        /// Whether to attach the default DocSpace MCP tool server.
        /// </summary>
        /// <value>Whether to attach the default DocSpace MCP tool server.</value>
        [DataMember(Name = "attachDefaultTools", EmitDefaultValue = true)]
        public bool AttachDefaultTools { get; set; }

        /// <summary>
        /// Agent (room) title.
        /// </summary>
        /// <value>Agent (room) title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Room quota in bytes.
        /// </summary>
        /// <value>Room quota in bytes.</value>
        [DataMember(Name = "quota", EmitDefaultValue = false)]
        public decimal Quota { get; set; }

        /// <summary>
        /// Whether room content is indexed for search.
        /// </summary>
        /// <value>Whether room content is indexed for search.</value>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Whether downloading room content is denied.
        /// </summary>
        /// <value>Whether downloading room content is denied.</value>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// Room data lifetime policy (&#x60;RoomDataLifetimeDto&#x60;).
        /// </summary>
        /// <value>Room data lifetime policy (&#x60;RoomDataLifetimeDto&#x60;).</value>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public Object Lifetime { get; set; }

        /// <summary>
        /// Watermark settings (&#x60;WatermarkRequestDto&#x60;).
        /// </summary>
        /// <value>Watermark settings (&#x60;WatermarkRequestDto&#x60;).</value>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public Object Watermark { get; set; }

        /// <summary>
        /// Room logo (&#x60;LogoRequest&#x60;).
        /// </summary>
        /// <value>Room logo (&#x60;LogoRequest&#x60;).</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Object Logo { get; set; }

        /// <summary>
        /// Room tags.
        /// </summary>
        /// <value>Room tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Room accent color.
        /// </summary>
        /// <value>Room accent color.</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Room cover image id.
        /// </summary>
        /// <value>Room cover image id.</value>
        [DataMember(Name = "cover", EmitDefaultValue = false)]
        public string Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAgentsCreateRequest {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  AttachDefaultTools: ").Append(AttachDefaultTools).Append("\n");
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
