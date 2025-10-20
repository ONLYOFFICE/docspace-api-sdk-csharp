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
    /// The parameters for locking a file.
    /// </summary>
    [DataContract(Name = "LockFileParameters")]
    public partial class LockFileParameters : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LockFileParameters" /> class.
        /// </summary>
        /// <param name="lockFile">Specifies whether to lock a file or not..</param>
        public LockFileParameters(bool lockFile = default)
        {
            this.LockFile = lockFile;
        }

        /// <summary>
        /// Specifies whether to lock a file or not.
        /// </summary>
        /// <value>Specifies whether to lock a file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "lockFile", EmitDefaultValue = true)]
        public bool LockFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockFileParameters {\n");
            sb.Append("  LockFile: ").Append(LockFile).Append("\n");
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
