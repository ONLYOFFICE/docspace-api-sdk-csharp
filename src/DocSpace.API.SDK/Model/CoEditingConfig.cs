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
    /// The co-editing configuration parameters.
    /// </summary>
    [DataContract(Name = "CoEditingConfig")]
    public partial class CoEditingConfig : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public CoEditingConfigMode? Mode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CoEditingConfig" /> class.
        /// </summary>
        /// <param name="change">Specifies if the co-editing mode can be changed in the editor interface or not..</param>
        /// <param name="fast">Specifies if the co-editing mode is fast..</param>
        /// <param name="mode">mode.</param>
        public CoEditingConfig(bool change = default, bool fast = default, CoEditingConfigMode? mode = default)
        {
            this.Change = change;
            this.Fast = fast;
            this.Mode = mode;
        }

        /// <summary>
        /// Specifies if the co-editing mode can be changed in the editor interface or not.
        /// </summary>
        /// <value>Specifies if the co-editing mode can be changed in the editor interface or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "change", EmitDefaultValue = true)]
        public bool Change { get; set; }

        /// <summary>
        /// Specifies if the co-editing mode is fast.
        /// </summary>
        /// <value>Specifies if the co-editing mode is fast.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "fast", EmitDefaultValue = true)]
        public bool Fast { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoEditingConfig {\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Fast: ").Append(Fast).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
