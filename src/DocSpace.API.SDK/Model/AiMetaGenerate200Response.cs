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
    /// AiMetaGenerate200Response
    /// </summary>
    [DataContract(Name = "aiMetaGenerate_200_response")]
    public partial class AiMetaGenerate200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaGenerate200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate200Response" /> class.
        /// </summary>
        /// <param name="fields">The proposed custom metadata fields with the values the text supports. (required).</param>
        /// <param name="sources">The documents the proposal was read from. (required).</param>
        /// <param name="skipped">The entries that were left out, with the reason for each. (required).</param>
        public AiMetaGenerate200Response(List<AiMetaGenerate200ResponseFieldsInner> fields = default, List<AiMetaGenerate200ResponseSourcesInner> sources = default, List<AiMetaGenerate200ResponseSkippedInner> skipped = default)
        {
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for AiMetaGenerate200Response and cannot be null");
            }
            this.Fields = fields;
            // to ensure "sources" is required (not null)
            if (sources == null)
            {
                throw new ArgumentNullException("sources is a required property for AiMetaGenerate200Response and cannot be null");
            }
            this.Sources = sources;
            // to ensure "skipped" is required (not null)
            if (skipped == null)
            {
                throw new ArgumentNullException("skipped is a required property for AiMetaGenerate200Response and cannot be null");
            }
            this.Skipped = skipped;
        }

        /// <summary>
        /// The proposed custom metadata fields with the values the text supports.
        /// </summary>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaGenerate200ResponseFieldsInner> Fields { get; set; }

        /// <summary>
        /// The documents the proposal was read from.
        /// </summary>
        [DataMember(Name = "sources", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaGenerate200ResponseSourcesInner> Sources { get; set; }

        /// <summary>
        /// The entries that were left out, with the reason for each.
        /// </summary>
        [DataMember(Name = "skipped", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaGenerate200ResponseSkippedInner> Skipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaGenerate200Response {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
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
