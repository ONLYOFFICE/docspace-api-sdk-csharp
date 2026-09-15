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
    /// The blank document the portal creates for each extension it covers.
    /// </summary>
    [DataContract(Name = "DefaultTemplateSettingsDto")]
    public partial class DefaultTemplateSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultTemplateSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsDto" /> class.
        /// </summary>
        /// <param name="items">One entry per extension the portal&#39;s built-in template set covers, whether or not a custom blank has been  chosen for it, so the list is never empty and its length follows the template set rather than the number of  custom blanks. Entries come in the order an interface shows them: text document, spreadsheet, presentation and  PDF first, everything else by extension. (required).</param>
        public DefaultTemplateSettingsDto(List<DefaultTemplateItemDto> items = default)
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for DefaultTemplateSettingsDto and cannot be null");
            }
            this.Items = items;
        }

        /// <summary>
        /// One entry per extension the portal&#39;s built-in template set covers, whether or not a custom blank has been  chosen for it, so the list is never empty and its length follows the template set rather than the number of  custom blanks. Entries come in the order an interface shows them: text document, spreadsheet, presentation and  PDF first, everything else by extension.
        /// </summary>
        /// <example>[{"fileExtension":".docx","fileTitle":"Company letter.docx","selectedFile":123}]</example>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<DefaultTemplateItemDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultTemplateSettingsDto {\n");
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
