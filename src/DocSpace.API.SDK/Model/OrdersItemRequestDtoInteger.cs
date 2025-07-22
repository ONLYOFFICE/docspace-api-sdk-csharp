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
    /// An item in the ordering request with its entry type and ID.
    /// </summary>
    [DataContract(Name = "OrdersItemRequestDtoInteger")]
    public partial class OrdersItemRequestDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name = "entryType", EmitDefaultValue = false)]
        public FileEntryType? EntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItemRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="entryId">The entry unique identifier (file or folder)..</param>
        /// <param name="entryType">entryType.</param>
        /// <param name="order">The order value..</param>
        public OrdersItemRequestDtoInteger(int entryId = default, FileEntryType? entryType = default, int order = default)
        {
            this.EntryId = entryId;
            this.EntryType = entryType;
            this.Order = order;
        }

        /// <summary>
        /// The entry unique identifier (file or folder).
        /// </summary>
        /// <value>The entry unique identifier (file or folder).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "entryId", EmitDefaultValue = false)]
        public int EntryId { get; set; }

        /// <summary>
        /// The order value.
        /// </summary>
        /// <value>The order value.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrdersItemRequestDtoInteger {\n");
            sb.Append("  EntryId: ").Append(EntryId).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            // Order (int) maximum
            if (this.Order > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value less than or equal to 2147483647.", new [] { "Order" });
            }

            // Order (int) minimum
            if (this.Order < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value greater than or equal to 1.", new [] { "Order" });
            }

            yield break;
        }
    }


}
