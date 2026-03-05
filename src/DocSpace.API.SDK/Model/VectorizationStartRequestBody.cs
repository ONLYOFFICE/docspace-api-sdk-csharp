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
    /// Parameters for submitting files for vectorization.
    /// </summary>
    [DataContract(Name = "VectorizationStartRequestBody")]
    public partial class VectorizationStartRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorizationStartRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VectorizationStartRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorizationStartRequestBody" /> class.
        /// </summary>
        /// <param name="files">The set of file identifiers to submit for vectorization. (required).</param>
        public VectorizationStartRequestBody(List<int> files = default)
        {
            // to ensure "files" is required (not null)
            if (files == null)
            {
                throw new ArgumentNullException("files is a required property for VectorizationStartRequestBody and cannot be null");
            }
            this.Files = files;
        }

        /// <summary>
        /// The set of file identifiers to submit for vectorization.
        /// </summary>
        /// <value>The set of file identifiers to submit for vectorization.</value>
        /*
        <example>[101,102,103]</example>
        */
        [DataMember(Name = "files", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VectorizationStartRequestBody {\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
