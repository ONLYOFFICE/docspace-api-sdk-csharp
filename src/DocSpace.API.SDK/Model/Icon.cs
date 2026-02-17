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
    /// Icon
    /// </summary>
    [DataContract(Name = "Icon")]
    public partial class Icon : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Icon" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Icon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Icon" /> class.
        /// </summary>
        /// <param name="icon48">icon48 (required).</param>
        /// <param name="icon32">icon32 (required).</param>
        /// <param name="icon24">icon24 (required).</param>
        /// <param name="icon16">icon16 (required).</param>
        public Icon(string icon48 = default, string icon32 = default, string icon24 = default, string icon16 = default)
        {
            // to ensure "icon48" is required (not null)
            if (icon48 == null)
            {
                throw new ArgumentNullException("icon48 is a required property for Icon and cannot be null");
            }
            this.Icon48 = icon48;
            // to ensure "icon32" is required (not null)
            if (icon32 == null)
            {
                throw new ArgumentNullException("icon32 is a required property for Icon and cannot be null");
            }
            this.Icon32 = icon32;
            // to ensure "icon24" is required (not null)
            if (icon24 == null)
            {
                throw new ArgumentNullException("icon24 is a required property for Icon and cannot be null");
            }
            this.Icon24 = icon24;
            // to ensure "icon16" is required (not null)
            if (icon16 == null)
            {
                throw new ArgumentNullException("icon16 is a required property for Icon and cannot be null");
            }
            this.Icon16 = icon16;
        }

        /// <summary>
        /// Gets or Sets Icon48
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "icon48", IsRequired = true, EmitDefaultValue = true)]
        public string Icon48 { get; set; }

        /// <summary>
        /// Gets or Sets Icon32
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "icon32", IsRequired = true, EmitDefaultValue = true)]
        public string Icon32 { get; set; }

        /// <summary>
        /// Gets or Sets Icon24
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "icon24", IsRequired = true, EmitDefaultValue = true)]
        public string Icon24 { get; set; }

        /// <summary>
        /// Gets or Sets Icon16
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "icon16", IsRequired = true, EmitDefaultValue = true)]
        public string Icon16 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Icon {\n");
            sb.Append("  Icon48: ").Append(Icon48).Append("\n");
            sb.Append("  Icon32: ").Append(Icon32).Append("\n");
            sb.Append("  Icon24: ").Append(Icon24).Append("\n");
            sb.Append("  Icon16: ").Append(Icon16).Append("\n");
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
