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
    /// The new item parameters.
    /// </summary>
    [DataContract(Name = "NewItemsDtoRoomNewItemsDto")]
    public partial class NewItemsDtoRoomNewItemsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewItemsDtoRoomNewItemsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewItemsDtoRoomNewItemsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewItemsDtoRoomNewItemsDto" /> class.
        /// </summary>
        /// <param name="date">date (required).</param>
        /// <param name="items">The list of items. (required).</param>
        public NewItemsDtoRoomNewItemsDto(ApiDateTime date = default, List<RoomNewItemsDto> items = default)
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new ArgumentNullException("date is a required property for NewItemsDtoRoomNewItemsDto and cannot be null");
            }
            this.Date = date;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for NewItemsDtoRoomNewItemsDto and cannot be null");
            }
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The list of items.
        /// </summary>
        /// <value>The list of items.</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<RoomNewItemsDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewItemsDtoRoomNewItemsDto {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
