// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The parameters for checking the form draft filling.
    /// </summary>
    [DataContract(Name = "CheckFillFormDraft")]
    public partial class CheckFillFormDraft : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckFillFormDraft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckFillFormDraft() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckFillFormDraft" /> class.
        /// </summary>
        /// <param name="version">The file version of the form draft. (required).</param>
        /// <param name="action">The action with the form draft..</param>
        public CheckFillFormDraft(int version = default, string action = default)
        {
            this.@Version = version;
            this.Action = action;
        }

        /// <summary>
        /// The file version of the form draft.
        /// </summary>
        /// <value>The file version of the form draft.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// The action with the form draft.
        /// </summary>
        /// <value>The action with the form draft.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Specifies whether to request the form for viewing or not.
        /// </summary>
        /// <value>Specifies whether to request the form for viewing or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "requestView", EmitDefaultValue = true)]
        public bool RequestView { get; private set; }

        /// <summary>
        /// Returns false as RequestView should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestView()
        {
            return false;
        }
        /// <summary>
        /// Specifies whether to request an embedded form or not.
        /// </summary>
        /// <value>Specifies whether to request an embedded form or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "requestEmbedded", EmitDefaultValue = true)]
        public bool RequestEmbedded { get; private set; }

        /// <summary>
        /// Returns false as RequestEmbedded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestEmbedded()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckFillFormDraft {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  RequestView: ").Append(RequestView).Append("\n");
            sb.Append("  RequestEmbedded: ").Append(RequestEmbedded).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
