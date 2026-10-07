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
    /// The metadata template information.
    /// </summary>
    [DataContract(Name = "MetadataTemplateDto")]
    public partial class MetadataTemplateDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataTemplateDto" /> class.
        /// </summary>
        /// <param name="id">The template ID..</param>
        /// <param name="name">The template name..</param>
        /// <param name="visible">Specifies if the template is visible in the UI pickers..</param>
        /// <param name="createBy">The user who created the template..</param>
        /// <param name="createOn">The template creation date..</param>
        /// <param name="modifiedBy">The user who modified the template last..</param>
        /// <param name="modifiedOn">The date when the template was modified last..</param>
        /// <param name="fields">The template metadata fields..</param>
        public MetadataTemplateDto(int id = default, string name = default, bool visible = default, Guid createBy = default, ApiDateTime createOn = default, Guid modifiedBy = default, ApiDateTime modifiedOn = default, List<MetadataFieldDto> fields = default)
        {
            this.Id = id;
            this.Name = name;
            this.Visible = visible;
            this.CreateBy = createBy;
            this.CreateOn = createOn;
            this.ModifiedBy = modifiedBy;
            this.ModifiedOn = modifiedOn;
            this.Fields = fields;
        }

        /// <summary>
        /// The template ID.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The template name.
        /// </summary>
        /// <example>Contracts</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies if the template is visible in the UI pickers.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// The user who created the template.
        /// </summary>
        /// <example>9a7d5f3e-1c2b-4e8a-9f60-3b7c2d1e5a44</example>
        [DataMember(Name = "createBy", EmitDefaultValue = false)]
        public Guid CreateBy { get; set; }

        /// <summary>
        /// The template creation date.
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// The user who modified the template last.
        /// </summary>
        /// <example>9a7d5f3e-1c2b-4e8a-9f60-3b7c2d1e5a44</example>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public Guid ModifiedBy { get; set; }

        /// <summary>
        /// The date when the template was modified last.
        /// </summary>
        [DataMember(Name = "modifiedOn", EmitDefaultValue = false)]
        public ApiDateTime ModifiedOn { get; set; }

        /// <summary>
        /// The template metadata fields.
        /// </summary>
        /// <example>[{"id":9,"templateId":3,"name":"Customer","type":0,"order":0}]</example>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<MetadataFieldDto> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataTemplateDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  CreateBy: ").Append(CreateBy).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
