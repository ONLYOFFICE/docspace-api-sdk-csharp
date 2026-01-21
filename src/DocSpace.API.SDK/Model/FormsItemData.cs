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
    /// The data of the separate form item.
    /// </summary>
    [DataContract(Name = "FormsItemData")]
    public partial class FormsItemData : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormsItemData" /> class.
        /// </summary>
        /// <param name="key">The form data key..</param>
        /// <param name="tag">The form data tag..</param>
        /// <param name="value">The form data value..</param>
        /// <param name="type">The form data type..</param>
        public FormsItemData(string key = default, string tag = default, string value = default, string type = default)
        {
            this.Key = key;
            this.Tag = tag;
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// The form data key.
        /// </summary>
        /// <value>The form data key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The form data tag.
        /// </summary>
        /// <value>The form data tag.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// The form data value.
        /// </summary>
        /// <value>The form data value.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The form data type.
        /// </summary>
        /// <value>The form data type.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormsItemData {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
