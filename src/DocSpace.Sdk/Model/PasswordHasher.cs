/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// PasswordHasher
    /// </summary>
    [DataContract(Name = "PasswordHasher")]
    public partial class PasswordHasher : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordHasher" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PasswordHasher()
        {
        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; private set; }

        /// <summary>
        /// Returns false as Size should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSize()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Iterations
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "iterations", EmitDefaultValue = false)]
        public int Iterations { get; private set; }

        /// <summary>
        /// Returns false as Iterations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIterations()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Salt
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "salt", EmitDefaultValue = true)]
        public string Salt { get; private set; }

        /// <summary>
        /// Returns false as Salt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalt()
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
            sb.Append("class PasswordHasher {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
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
