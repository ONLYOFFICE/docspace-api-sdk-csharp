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
    /// The request parameters for creating a metadata template.
    /// </summary>
    [DataContract(Name = "CreateMetadataTemplateRequestDto")]
    public partial class CreateMetadataTemplateRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetadataTemplateRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMetadataTemplateRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetadataTemplateRequestDto" /> class.
        /// </summary>
        /// <param name="name">The template name. (required).</param>
        /// <param name="visible">Specifies if the template is visible in the UI pickers..</param>
        /// <param name="fields">The template metadata fields..</param>
        public CreateMetadataTemplateRequestDto(string name = default, bool visible = default, List<MetadataFieldRequest> fields = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateMetadataTemplateRequestDto and cannot be null");
            }
            this.Name = name;
            this.Visible = visible;
            this.Fields = fields;
        }

        /// <summary>
        /// The template name.
        /// </summary>
        /// <example>Contracts</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies if the template is visible in the UI pickers.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// The template metadata fields.
        /// </summary>
        /// <example>[{"name":"Contract number","type":0},{"name":"Signed on","type":1}]</example>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<MetadataFieldRequest> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMetadataTemplateRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
