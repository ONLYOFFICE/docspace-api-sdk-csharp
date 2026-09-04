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
    /// The generate presentation tool call parameters.
    /// </summary>
    [DataContract(Name = "GeneratePresentationToolCallParametersDto")]
    public partial class GeneratePresentationToolCallParametersDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePresentationToolCallParametersDto" /> class.
        /// </summary>
        /// <param name="topic">The presentation topic..</param>
        /// <param name="slideCount">The number of slides..</param>
        /// <param name="style">The visual style..</param>
        public GeneratePresentationToolCallParametersDto(string topic = default, string slideCount = default, string style = default)
        {
            this.Topic = topic;
            this.SlideCount = slideCount;
            this.Style = style;
        }

        /// <summary>
        /// The presentation topic.
        /// </summary>
        [DataMember(Name = "topic", EmitDefaultValue = true)]
        public string Topic { get; set; }

        /// <summary>
        /// The number of slides.
        /// </summary>
        [DataMember(Name = "slideCount", EmitDefaultValue = true)]
        public string SlideCount { get; set; }

        /// <summary>
        /// The visual style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = true)]
        public string Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratePresentationToolCallParametersDto {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  SlideCount: ").Append(SlideCount).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
