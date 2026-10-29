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
    /// AiMetaFillRequest
    /// </summary>
    [DataContract(Name = "AiMetaFillRequest")]
    public partial class AiMetaFillRequest : IValidatableObject
    {
        /// <summary>
        /// The entry&#39;s table. Only &#x60;file&#x60; for now: a folder or a room answers 400.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum File for value: file
            /// </summary>
            [EnumMember(Value = "file")]
            File
        }

        /// <summary>
        /// The entry&#39;s table. Only &#x60;file&#x60; for now: a folder or a room answers 400.
        /// </summary>
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public KindEnum Kind { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFillRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaFillRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFillRequest" /> class.
        /// </summary>
        /// <param name="kind">The entry&#39;s table. Only &#x60;file&#x60; for now: a folder or a room answers 400. (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="prompt">What to pay attention to; a hint for the model..</param>
        /// <param name="overwrite">Also replace the fields that already carry a value. Default false..</param>
        /// <param name="dryRun">Resolve the values but write nothing; the caller writes what the user confirms. Default true: a write needs an explicit false..</param>
        public AiMetaFillRequest(KindEnum kind = default, AiMetaGenerateRequestId id = default, string prompt = default, bool overwrite = default, bool dryRun = default)
        {
            this.Kind = kind;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiMetaFillRequest and cannot be null");
            }
            this.Id = id;
            this.Prompt = prompt;
            this.Overwrite = overwrite;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public AiMetaGenerateRequestId Id { get; set; }

        /// <summary>
        /// What to pay attention to; a hint for the model.
        /// </summary>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public string Prompt { get; set; }

        /// <summary>
        /// Also replace the fields that already carry a value. Default false.
        /// </summary>
        [DataMember(Name = "overwrite", EmitDefaultValue = true)]
        public bool Overwrite { get; set; }

        /// <summary>
        /// Resolve the values but write nothing; the caller writes what the user confirms. Default true: a write needs an explicit false.
        /// </summary>
        [DataMember(Name = "dryRun", EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaFillRequest {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Overwrite: ").Append(Overwrite).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
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
