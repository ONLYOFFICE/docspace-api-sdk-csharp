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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The parameters of the usage space statistics item.
    /// </summary>
    [DataContract(Name = "UsageSpaceStatItemDto")]
    public partial class UsageSpaceStatItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSpaceStatItemDto" /> class.
        /// </summary>
        /// <param name="name">The item name..</param>
        /// <param name="icon">The item icon path..</param>
        /// <param name="disabled">Specifies if the item is disabled or not..</param>
        /// <param name="size">The item used space..</param>
        /// <param name="url">The item URL..</param>
        public UsageSpaceStatItemDto(string name = default, string icon = default, bool disabled = default, string size = default, string url = default)
        {
            this.Name = name;
            this.Icon = icon;
            this.Disabled = disabled;
            this.Size = size;
            this.Url = url;
        }

        /// <summary>
        /// The item name.
        /// </summary>
        /// <value>The item name.</value>
        /*
        <example>Item name</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The item icon path.
        /// </summary>
        /// <value>The item icon path.</value>
        /*
        <example>Item icon path</example>
        */
        [DataMember(Name = "icon", EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// Specifies if the item is disabled or not.
        /// </summary>
        /// <value>Specifies if the item is disabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// The item used space.
        /// </summary>
        /// <value>The item used space.</value>
        /*
        <example>0 Byte</example>
        */
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// The item URL.
        /// </summary>
        /// <value>The item URL.</value>
        /*
        <example>Item url</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageSpaceStatItemDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
