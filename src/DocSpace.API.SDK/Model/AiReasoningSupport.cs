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
    /// What one model can do with extended thinking. Providers describe each model through this shape so the UI offers only the choices that change the request, and the request builders clamp to the same table.
    /// </summary>
    [DataContract(Name = "AiReasoningSupport")]
    public partial class AiReasoningSupport : IValidatableObject
    {

        /// <summary>
        /// The depth the model runs at when nothing asks for one — what a stored &#x60;off&#x60; means on a model that cannot be switched off. Known only where a catalogue reports it (OpenRouter&#39;s &#x60;default_effort&#x60;); otherwise &#x60;DEFAULT_REASONING_LEVEL&#x60; clamped to &#x60;depths&#x60; is assumed.
        /// </summary>
        [DataMember(Name = "defaultDepth", EmitDefaultValue = false)]
        public AiReasoningDepth? DefaultDepth { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiReasoningSupport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiReasoningSupport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiReasoningSupport" /> class.
        /// </summary>
        /// <param name="thinks">Whether the model can think at all. False hides the whole control. (required).</param>
        /// <param name="canDisable">Whether &#x60;off&#x60; really turns thinking off. False means the model thinks always and off only drops to its lowest depth (or leaves the default depth, where there is no knob). (required).</param>
        /// <param name="depths">Depths the model distinguishes, lowest first. Empty when thinking is an on/off switch with no depth (or the model doesn&#39;t think). A level not listed is clamped to the nearest one — see &#x60;clampReasoningLevel&#x60;. (required).</param>
        /// <param name="defaultDepth">The depth the model runs at when nothing asks for one — what a stored &#x60;off&#x60; means on a model that cannot be switched off. Known only where a catalogue reports it (OpenRouter&#39;s &#x60;default_effort&#x60;); otherwise &#x60;DEFAULT_REASONING_LEVEL&#x60; clamped to &#x60;depths&#x60; is assumed..</param>
        public AiReasoningSupport(bool thinks = default, bool canDisable = default, List<AiReasoningDepth> depths = default, AiReasoningDepth? defaultDepth = default)
        {
            this.Thinks = thinks;
            this.CanDisable = canDisable;
            // to ensure "depths" is required (not null)
            if (depths == null)
            {
                throw new ArgumentNullException("depths is a required property for AiReasoningSupport and cannot be null");
            }
            this.Depths = depths;
            this.DefaultDepth = defaultDepth;
        }

        /// <summary>
        /// Whether the model can think at all. False hides the whole control.
        /// </summary>
        [DataMember(Name = "thinks", IsRequired = true, EmitDefaultValue = true)]
        public bool Thinks { get; set; }

        /// <summary>
        /// Whether &#x60;off&#x60; really turns thinking off. False means the model thinks always and off only drops to its lowest depth (or leaves the default depth, where there is no knob).
        /// </summary>
        [DataMember(Name = "canDisable", IsRequired = true, EmitDefaultValue = true)]
        public bool CanDisable { get; set; }

        /// <summary>
        /// Depths the model distinguishes, lowest first. Empty when thinking is an on/off switch with no depth (or the model doesn&#39;t think). A level not listed is clamped to the nearest one — see &#x60;clampReasoningLevel&#x60;.
        /// </summary>
        [DataMember(Name = "depths", IsRequired = true, EmitDefaultValue = true)]
        public List<AiReasoningDepth> Depths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiReasoningSupport {\n");
            sb.Append("  Thinks: ").Append(Thinks).Append("\n");
            sb.Append("  CanDisable: ").Append(CanDisable).Append("\n");
            sb.Append("  Depths: ").Append(Depths).Append("\n");
            sb.Append("  DefaultDepth: ").Append(DefaultDepth).Append("\n");
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
