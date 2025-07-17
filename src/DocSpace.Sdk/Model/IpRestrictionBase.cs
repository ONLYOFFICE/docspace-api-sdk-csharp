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
    /// IpRestrictionBase
    /// </summary>
    [DataContract(Name = "IpRestrictionBase")]
    public partial class IpRestrictionBase : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRestrictionBase" /> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        /// <param name="forAdmin">forAdmin.</param>
        public IpRestrictionBase(string ip = default, bool forAdmin = default)
        {
            this.Ip = ip;
            this.ForAdmin = forAdmin;
        }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets ForAdmin
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "forAdmin", EmitDefaultValue = true)]
        public bool ForAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpRestrictionBase {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  ForAdmin: ").Append(ForAdmin).Append("\n");
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
