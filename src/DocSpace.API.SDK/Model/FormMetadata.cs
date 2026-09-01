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
    /// FormMetadata
    /// </summary>
    [DataContract(Name = "FormMetadata")]
    public partial class FormMetadata : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormMetadata" /> class.
        /// </summary>
        /// <param name="key">The form field key..</param>
        /// <param name="type">The form field type..</param>
        /// <param name="format">The form field format..</param>
        /// <param name="possibleValues">The list of possible values for the form field..</param>
        public FormMetadata(string key = default, string type = default, string format = default, List<string> possibleValues = default)
        {
            this.Key = key;
            this.Type = type;
            this.Format = format;
            this.PossibleValues = possibleValues;
        }

        /// <summary>
        /// The form field key.
        /// </summary>
        /// <example>name</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The form field type.
        /// </summary>
        /// <example>text</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The form field format.
        /// </summary>
        /// <example>date</example>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// The list of possible values for the form field.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "possibleValues", EmitDefaultValue = true)]
        public List<string> PossibleValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormMetadata {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  PossibleValues: ").Append(PossibleValues).Append("\n");
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
