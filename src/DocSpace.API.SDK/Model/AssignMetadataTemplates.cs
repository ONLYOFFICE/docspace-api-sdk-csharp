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
    /// The parameters for assigning metadata templates.
    /// </summary>
    [DataContract(Name = "AssignMetadataTemplates")]
    public partial class AssignMetadataTemplates : IValidatableObject
    {

        /// <summary>
        /// The conflict resolve type for the cascade assignment.
        /// </summary>
        [DataMember(Name = "conflictResolveType", EmitDefaultValue = false)]
        public MetadataConflictResolveType? ConflictResolveType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignMetadataTemplates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignMetadataTemplates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignMetadataTemplates" /> class.
        /// </summary>
        /// <param name="templateIds">The metadata template IDs. (required).</param>
        /// <param name="cascade">Specifies if the templates are propagated to the folder sub-entries..</param>
        /// <param name="conflictResolveType">The conflict resolve type for the cascade assignment..</param>
        public AssignMetadataTemplates(List<int> templateIds = default, bool cascade = default, MetadataConflictResolveType? conflictResolveType = default)
        {
            // to ensure "templateIds" is required (not null)
            if (templateIds == null)
            {
                throw new ArgumentNullException("templateIds is a required property for AssignMetadataTemplates and cannot be null");
            }
            this.TemplateIds = templateIds;
            this.Cascade = cascade;
            this.ConflictResolveType = conflictResolveType;
        }

        /// <summary>
        /// The metadata template IDs.
        /// </summary>
        /// <example>[1,2]</example>
        [DataMember(Name = "templateIds", IsRequired = true, EmitDefaultValue = true)]
        public List<int> TemplateIds { get; set; }

        /// <summary>
        /// Specifies if the templates are propagated to the folder sub-entries.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "cascade", EmitDefaultValue = true)]
        public bool Cascade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignMetadataTemplates {\n");
            sb.Append("  TemplateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("  Cascade: ").Append(Cascade).Append("\n");
            sb.Append("  ConflictResolveType: ").Append(ConflictResolveType).Append("\n");
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
