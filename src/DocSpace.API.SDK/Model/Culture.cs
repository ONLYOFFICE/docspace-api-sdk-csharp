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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The culture name parameters.
    /// </summary>
    [DataContract(Name = "Culture")]
    public partial class Culture : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Culture" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Culture() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Culture" /> class.
        /// </summary>
        /// <param name="cultureName">The user culture name (en-US, de, fr, es, ...). (required).</param>
        public Culture(string cultureName = default)
        {
            // to ensure "cultureName" is required (not null)
            if (cultureName == null)
            {
                throw new ArgumentNullException("cultureName is a required property for Culture and cannot be null");
            }
            this.CultureName = cultureName;
        }

        /// <summary>
        /// The user culture name (en-US, de, fr, es, ...).
        /// </summary>
        /// <value>The user culture name (en-US, de, fr, es, ...).</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cultureName", IsRequired = true, EmitDefaultValue = true)]
        public string CultureName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Culture {\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
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
            // CultureName (string) maxLength
            if (this.CultureName != null && this.CultureName.Length > 85)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CultureName, length must be less than 85.", new [] { "CultureName" });
            }

            // CultureName (string) minLength
            if (this.CultureName != null && this.CultureName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CultureName, length must be greater than 0.", new [] { "CultureName" });
            }

            yield break;
        }

    }


}
