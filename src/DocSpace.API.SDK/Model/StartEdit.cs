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
    /// The parameters for starting file editing.
    /// </summary>
    [DataContract(Name = "StartEdit")]
    public partial class StartEdit : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StartEdit" /> class.
        /// </summary>
        /// <param name="editingAlone">Specifies whether to share the file with other users for editing or not..</param>
        public StartEdit(bool editingAlone = default)
        {
            this.EditingAlone = editingAlone;
        }

        /// <summary>
        /// Specifies whether to share the file with other users for editing or not.
        /// </summary>
        /// <value>Specifies whether to share the file with other users for editing or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "editingAlone", EmitDefaultValue = true)]
        public bool EditingAlone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartEdit {\n");
            sb.Append("  EditingAlone: ").Append(EditingAlone).Append("\n");
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
