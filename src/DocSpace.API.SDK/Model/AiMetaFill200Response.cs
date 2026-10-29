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
    /// AiMetaFill200Response
    /// </summary>
    [DataContract(Name = "aiMetaFill_200_response")]
    public partial class AiMetaFill200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaFill200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200Response" /> class.
        /// </summary>
        /// <param name="dryRun">Whether the values were only proposed (&#x60;true&#x60;) or written as well. (required).</param>
        /// <param name="metadata">The entry&#39;s metadata after the write (or as it stands, with &#x60;dryRun&#x60;), as &#x60;GET api/2.0/files/metadata/{kind}/{id}&#x60; returns it. (required).</param>
        /// <param name="filled">The values written, or proposed with &#x60;dryRun&#x60;: a typed value for a template field, a string for a custom field. (required).</param>
        /// <param name="unresolved">The fields left as they were, with the reason for each. (required).</param>
        /// <param name="sources">The documents the values were read from. (required).</param>
        /// <param name="skipped">The entries that were left out, with the reason for each. (required).</param>
        public AiMetaFill200Response(bool dryRun = default, AiEntryMetadata metadata = default, List<AiMetaFill200ResponseFilledInner> filled = default, List<AiMetaFill200ResponseUnresolvedInner> unresolved = default, List<AiMetaFill200ResponseSourcesInner> sources = default, List<AiMetaGenerate200ResponseSkippedInner> skipped = default)
        {
            this.DryRun = dryRun;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for AiMetaFill200Response and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "filled" is required (not null)
            if (filled == null)
            {
                throw new ArgumentNullException("filled is a required property for AiMetaFill200Response and cannot be null");
            }
            this.Filled = filled;
            // to ensure "unresolved" is required (not null)
            if (unresolved == null)
            {
                throw new ArgumentNullException("unresolved is a required property for AiMetaFill200Response and cannot be null");
            }
            this.Unresolved = unresolved;
            // to ensure "sources" is required (not null)
            if (sources == null)
            {
                throw new ArgumentNullException("sources is a required property for AiMetaFill200Response and cannot be null");
            }
            this.Sources = sources;
            // to ensure "skipped" is required (not null)
            if (skipped == null)
            {
                throw new ArgumentNullException("skipped is a required property for AiMetaFill200Response and cannot be null");
            }
            this.Skipped = skipped;
        }

        /// <summary>
        /// Whether the values were only proposed (&#x60;true&#x60;) or written as well.
        /// </summary>
        [DataMember(Name = "dryRun", IsRequired = true, EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// The entry&#39;s metadata after the write (or as it stands, with &#x60;dryRun&#x60;), as &#x60;GET api/2.0/files/metadata/{kind}/{id}&#x60; returns it.
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public AiEntryMetadata Metadata { get; set; }

        /// <summary>
        /// The values written, or proposed with &#x60;dryRun&#x60;: a typed value for a template field, a string for a custom field.
        /// </summary>
        [DataMember(Name = "filled", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaFill200ResponseFilledInner> Filled { get; set; }

        /// <summary>
        /// The fields left as they were, with the reason for each.
        /// </summary>
        [DataMember(Name = "unresolved", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaFill200ResponseUnresolvedInner> Unresolved { get; set; }

        /// <summary>
        /// The documents the values were read from.
        /// </summary>
        [DataMember(Name = "sources", IsRequired = true, EmitDefaultValue = true)]
        public List<AiMetaFill200ResponseSourcesInner> Sources { get; set; }

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
            sb.Append("class AiMetaFill200Response {\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Filled: ").Append(Filled).Append("\n");
            sb.Append("  Unresolved: ").Append(Unresolved).Append("\n");
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
