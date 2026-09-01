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
    /// The new item parameters.
    /// </summary>
    [DataContract(Name = "NewItemsDtoFileEntryBaseDto")]
    public partial class NewItemsDtoFileEntryBaseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewItemsDtoFileEntryBaseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewItemsDtoFileEntryBaseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewItemsDtoFileEntryBaseDto" /> class.
        /// </summary>
        /// <param name="date">The date and time when the new item was created. (required).</param>
        /// <param name="items">The list of items. (required).</param>
        public NewItemsDtoFileEntryBaseDto(DateTime? date = default, List<FileEntryBaseDto> items = default)
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new ArgumentNullException("date is a required property for NewItemsDtoFileEntryBaseDto and cannot be null");
            }
            this.Date = date;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for NewItemsDtoFileEntryBaseDto and cannot be null");
            }
            this.Items = items;
        }

        /// <summary>
        /// The date and time when the new item was created.
        /// </summary>
        /// <example>2025-01-01T00:00:00Z</example>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The list of items.
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewItemsDtoFileEntryBaseDto {\n");
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
