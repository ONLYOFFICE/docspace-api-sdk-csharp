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
    /// The metadata field information.
    /// </summary>
    [DataContract(Name = "MetadataFieldDto")]
    public partial class MetadataFieldDto : IValidatableObject
    {

        /// <summary>
        /// The field type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MetadataFieldType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFieldDto" /> class.
        /// </summary>
        /// <param name="id">The field ID..</param>
        /// <param name="templateId">The ID of the template the field belongs to..</param>
        /// <param name="name">The field name..</param>
        /// <param name="type">The field type..</param>
        /// <param name="options">The choice options of the field..</param>
        /// <param name="order">The field display order inside the template..</param>
        public MetadataFieldDto(int id = default, int templateId = default, string name = default, MetadataFieldType? type = default, List<MetadataFieldOptionDto> options = default, int order = default)
        {
            this.Id = id;
            this.TemplateId = templateId;
            this.Name = name;
            this.Type = type;
            this.Options = options;
            this.Order = order;
        }

        /// <summary>
        /// The field ID.
        /// </summary>
        /// <example>9</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the template the field belongs to.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public int TemplateId { get; set; }

        /// <summary>
        /// The field name.
        /// </summary>
        /// <example>Customer</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The choice options of the field.
        /// </summary>
        /// <example>[{"id":"4f1e2d3c-5b6a-4788-99aa-0c1d2e3f4a55","value":"Red"}]</example>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<MetadataFieldOptionDto> Options { get; set; }

        /// <summary>
        /// The field display order inside the template.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataFieldDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            yield break;
        }

    }


}
