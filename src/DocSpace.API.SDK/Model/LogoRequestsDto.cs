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
    /// The two theme variants of one branding logo.
    /// </summary>
    [DataContract(Name = "LogoRequestsDto")]
    public partial class LogoRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoRequestsDto" /> class.
        /// </summary>
        /// <param name="light">The image used on a light background, either as a &#x60;data:image/png;base64,...&#x60; payload - &#x60;png&#x60;, &#x60;jpg&#x60; and  &#x60;svg&#x60; are accepted - or as the name of a file already put in the temporary store..</param>
        /// <param name="dark">The image used on a dark background, in the same two forms as &#x60;light&#x60;. It is only stored for the slots that  have a dark variant and is ignored for the favicon and the editor logos..</param>
        public LogoRequestsDto(string light = default, string dark = default)
        {
            this.Light = light;
            this.Dark = dark;
        }

        /// <summary>
        /// The image used on a light background, either as a &#x60;data:image/png;base64,...&#x60; payload - &#x60;png&#x60;, &#x60;jpg&#x60; and  &#x60;svg&#x60; are accepted - or as the name of a file already put in the temporary store.
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANS...</example>
        [DataMember(Name = "light", EmitDefaultValue = true)]
        public string Light { get; set; }

        /// <summary>
        /// The image used on a dark background, in the same two forms as &#x60;light&#x60;. It is only stored for the slots that  have a dark variant and is ignored for the favicon and the editor logos.
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANS...</example>
        [DataMember(Name = "dark", EmitDefaultValue = true)]
        public string Dark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoRequestsDto {\n");
            sb.Append("  Light: ").Append(Light).Append("\n");
            sb.Append("  Dark: ").Append(Dark).Append("\n");
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
