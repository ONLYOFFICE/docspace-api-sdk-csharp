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
    /// The parameters for deleting a file.
    /// </summary>
    [DataContract(Name = "Delete")]
    public partial class Delete : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Delete" /> class.
        /// </summary>
        /// <param name="deleteAfter">Specifies whether to delete a file after the editing session is finished or not..</param>
        /// <param name="immediately">Specifies whether to move a file to the \\Trash\\ folder or delete it immediately..</param>
        public Delete(bool deleteAfter = default, bool immediately = default)
        {
            this.DeleteAfter = deleteAfter;
            this.Immediately = immediately;
        }

        /// <summary>
        /// Specifies whether to delete a file after the editing session is finished or not.
        /// </summary>
        /// <value>Specifies whether to delete a file after the editing session is finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// Specifies whether to move a file to the \\Trash\\ folder or delete it immediately.
        /// </summary>
        /// <value>Specifies whether to move a file to the \\Trash\\ folder or delete it immediately.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "immediately", EmitDefaultValue = true)]
        public bool Immediately { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Delete {\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  Immediately: ").Append(Immediately).Append("\n");
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
