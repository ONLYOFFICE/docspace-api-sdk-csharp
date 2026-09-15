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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// One entry to move to a given position inside its folder.
    /// </summary>
    [DataContract(Name = "OrdersItemRequestDtoInteger")]
    public partial class OrdersItemRequestDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Which of the two the identifier names, because a file and a folder may carry the same number.
        /// </summary>
        [DataMember(Name = "entryType", IsRequired = true, EmitDefaultValue = true)]
        public FileEntryType EntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItemRequestDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrdersItemRequestDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItemRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="entryId">The file or folder to move. (required).</param>
        /// <param name="entryType">Which of the two the identifier names, because a file and a folder may carry the same number. (required).</param>
        /// <param name="order">The position the entry is to take, counting from 1. The entry that held it, and everything after it, is  shifted to make room. A dotted path such as 1.2.3 is accepted as well, of which only the last segment is  read. (required).</param>
        public OrdersItemRequestDtoInteger(int entryId = default, FileEntryType entryType = default, int order = default)
        {
            this.EntryId = entryId;
            this.EntryType = entryType;
            this.Order = order;
        }

        /// <summary>
        /// The file or folder to move.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "entryId", IsRequired = true, EmitDefaultValue = true)]
        public int EntryId { get; set; }

        /// <summary>
        /// The position the entry is to take, counting from 1. The entry that held it, and everything after it, is  shifted to make room. A dotted path such as 1.2.3 is accepted as well, of which only the last segment is  read.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
