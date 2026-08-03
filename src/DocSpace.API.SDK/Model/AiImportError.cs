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
    /// Per-entry error reported by  {@link  PromptsEngine.importBundle } .
    /// </summary>
    [DataContract(Name = "AiImportError")]
    public partial class AiImportError : IValidatableObject
    {
        /// <summary>
        /// &#x60;folder&#x60; or &#x60;prompt&#x60;, plus the offending name or id.
        /// </summary>
        /// <value>&#x60;folder&#x60; or &#x60;prompt&#x60;, plus the offending name or id.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum Folder for value: folder
            /// </summary>
            [EnumMember(Value = "folder")]
            Folder,

            /// <summary>
            /// Enum Prompt for value: prompt
            /// </summary>
            [EnumMember(Value = "prompt")]
            Prompt
        }

        /// <summary>
        /// &#x60;folder&#x60; or &#x60;prompt&#x60;, plus the offending name or id.
        /// </summary>
        /// <value>&#x60;folder&#x60; or &#x60;prompt&#x60;, plus the offending name or id.</value>
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public KindEnum Kind { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiImportError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiImportError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiImportError" /> class.
        /// </summary>
        /// <param name="kind">&#x60;folder&#x60; or &#x60;prompt&#x60;, plus the offending name or id. (required).</param>
        /// <param name="ref">@ref (required).</param>
        /// <param name="error">error (required).</param>
        public AiImportError(KindEnum kind = default, string @ref = default, AiTErrorData error = default)
        {
            this.Kind = kind;
            // to ensure "@ref" is required (not null)
            if (@ref == null)
            {
                throw new ArgumentNullException("@ref is a required property for AiImportError and cannot be null");
            }
            this.Ref = @ref;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for AiImportError and cannot be null");
            }
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name = "ref", IsRequired = true, EmitDefaultValue = true)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public AiTErrorData Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiImportError {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
