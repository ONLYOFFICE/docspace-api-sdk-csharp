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
    /// Represents a discount category applied to the price.
    /// </summary>
    [DataContract(Name = "DiscountCategory")]
    public partial class DiscountCategory : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountCategory" /> class.
        /// </summary>
        /// <param name="id">The discount category unique identifier..</param>
        /// <param name="valueDiscount">The discount value..</param>
        /// <param name="description">The discount category description..</param>
        /// <param name="created">The date and time when the discount category was created..</param>
        public DiscountCategory(int id = default, double valueDiscount = default, string description = default, DateTime created = default)
        {
            this.Id = id;
            this.ValueDiscount = valueDiscount;
            this.Description = description;
            this.Created = created;
        }

        /// <summary>
        /// The discount category unique identifier.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The discount value.
        /// </summary>
        /// <example>10.5</example>
        [DataMember(Name = "valueDiscount", EmitDefaultValue = false)]
        public double ValueDiscount { get; set; }

        /// <summary>
        /// The discount category description.
        /// </summary>
        /// <example>Annual subscription discount</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the discount category was created.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountCategory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ValueDiscount: ").Append(ValueDiscount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            yield break;
        }

    }


}
