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
    /// The request parameters for updating the trash bin auto-clearing setting.
    /// </summary>
    [DataContract(Name = "AutoCleanupRequestDto")]
    public partial class AutoCleanupRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Gap
        /// </summary>
        [DataMember(Name = "gap", EmitDefaultValue = false)]
        public DateToAutoCleanUp? Gap { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoCleanupRequestDto" /> class.
        /// </summary>
        /// <param name="set">Specifies whether to enable the auto-clearing or not..</param>
        /// <param name="gap">gap.</param>
        public AutoCleanupRequestDto(bool set = default, DateToAutoCleanUp? gap = default)
        {
            this.Set = set;
            this.Gap = gap;
        }

        /// <summary>
        /// Specifies whether to enable the auto-clearing or not.
        /// </summary>
        /// <value>Specifies whether to enable the auto-clearing or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "set", EmitDefaultValue = true)]
        public bool Set { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoCleanupRequestDto {\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
            sb.Append("  Gap: ").Append(Gap).Append("\n");
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
