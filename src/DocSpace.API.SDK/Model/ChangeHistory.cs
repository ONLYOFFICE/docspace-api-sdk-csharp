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
    /// The parameters for changing version history.
    /// </summary>
    [DataContract(Name = "ChangeHistory")]
    public partial class ChangeHistory : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeHistory" /> class.
        /// </summary>
        /// <param name="version">The file version of the change history. (required).</param>
        /// <param name="continueVersion">Specifies whether to start a new version or continue revision of the change history..</param>
        public ChangeHistory(int version = default, bool continueVersion = default)
        {
            this.@Version = version;
            this.ContinueVersion = continueVersion;
        }

        /// <summary>
        /// The file version of the change history.
        /// </summary>
        /// <value>The file version of the change history.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// Specifies whether to start a new version or continue revision of the change history.
        /// </summary>
        /// <value>Specifies whether to start a new version or continue revision of the change history.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "continueVersion", EmitDefaultValue = true)]
        public bool ContinueVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeHistory {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  ContinueVersion: ").Append(ContinueVersion).Append("\n");
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
