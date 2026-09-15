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
    /// An anchor inside a document, as the editor writes it.
    /// </summary>
    [DataContract(Name = "ActionConfig")]
    public partial class ActionConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionConfig" /> class.
        /// </summary>
        /// <param name="data">The anchor value produced by the editor, opaque to the portal: it names the comment, the mention or the  place the document is scrolled to..</param>
        /// <param name="type">What the anchor points at, as the editor names it - a comment thread, for instance..</param>
        public ActionConfig(string data = default, string type = default)
        {
            this.Data = data;
            this.Type = type;
        }

        /// <summary>
        /// The anchor value produced by the editor, opaque to the portal: it names the comment, the mention or the  place the document is scrolled to.
        /// </summary>
        /// <example>section-42</example>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// What the anchor points at, as the editor names it - a comment thread, for instance.
        /// </summary>
        /// <example>comment</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionConfig {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            // Data (string) maxLength
            if (this.Data != null && this.Data.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be less than 256.", new [] { "Data" });
            }

            // Data (string) minLength
            if (this.Data != null && this.Data.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be greater than 0.", new [] { "Data" });
            }

            // Type (string) maxLength
            if (this.Type != null && this.Type.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 128.", new [] { "Type" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 0.", new [] { "Type" });
            }

            yield break;
        }

    }


}
