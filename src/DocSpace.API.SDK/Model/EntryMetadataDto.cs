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
    /// The metadata of an entry: the assigned templates with their values, and the custom fields holding a value.
    /// </summary>
    [DataContract(Name = "EntryMetadataDto")]
    public partial class EntryMetadataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryMetadataDto" /> class.
        /// </summary>
        /// <param name="templates">The assigned metadata templates, each field carrying its value on the entry..</param>
        /// <param name="customFields">The custom fields with their values..</param>
        public EntryMetadataDto(List<EntryTemplateDto> templates = default, List<CustomFieldValueDto> customFields = default)
        {
            this.Templates = templates;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// The assigned metadata templates, each field carrying its value on the entry.
        /// </summary>
        /// <example>[{"id":3,"name":"Contracts","visible":true,"fields":[]}]</example>
        [DataMember(Name = "templates", EmitDefaultValue = true)]
        public List<EntryTemplateDto> Templates { get; set; }

        /// <summary>
        /// The custom fields with their values.
        /// </summary>
        /// <example>[{"name":"Project code","value":"A-42"}]</example>
        [DataMember(Name = "customFields", EmitDefaultValue = true)]
        public List<CustomFieldValueDto> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntryMetadataDto {\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
