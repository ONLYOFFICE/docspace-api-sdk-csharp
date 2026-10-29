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
    /// AiEntryMetadata
    /// </summary>
    [DataContract(Name = "AiEntryMetadata")]
    public partial class AiEntryMetadata : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiEntryMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryMetadata" /> class.
        /// </summary>
        /// <param name="templates">templates (required).</param>
        /// <param name="customFields">customFields (required).</param>
        public AiEntryMetadata(List<AiEntryMetadataTemplatesInner> templates = default, List<AiEntryMetadataCustomFieldsInner> customFields = default)
        {
            // to ensure "templates" is required (not null)
            if (templates == null)
            {
                throw new ArgumentNullException("templates is a required property for AiEntryMetadata and cannot be null");
            }
            this.Templates = templates;
            // to ensure "customFields" is required (not null)
            if (customFields == null)
            {
                throw new ArgumentNullException("customFields is a required property for AiEntryMetadata and cannot be null");
            }
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name = "templates", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryMetadataTemplatesInner> Templates { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryMetadataCustomFieldsInner> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiEntryMetadata {\n");
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
