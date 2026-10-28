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
    /// The extension whose custom blank is dropped in favour of the built-in one.
    /// </summary>
    [DataContract(Name = "DefaultTemplateSettingsResetRequestDto")]
    public partial class DefaultTemplateSettingsResetRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsResetRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultTemplateSettingsResetRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsResetRequestDto" /> class.
        /// </summary>
        /// <param name="fileExtension">The extension whose custom blank is dropped, written in lower case with the leading dot. Only the extensions  the portal&#39;s built-in template set covers are accepted, and &#x60;GET api/2.0/files/settings/defaulttemplate&#x60;  returns exactly that list; an extension outside it leaves the settings unchanged instead of failing. (required).</param>
        public DefaultTemplateSettingsResetRequestDto(string fileExtension = default)
        {
            // to ensure "fileExtension" is required (not null)
            if (fileExtension == null)
            {
                throw new ArgumentNullException("fileExtension is a required property for DefaultTemplateSettingsResetRequestDto and cannot be null");
            }
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// The extension whose custom blank is dropped, written in lower case with the leading dot. Only the extensions  the portal&#39;s built-in template set covers are accepted, and &#x60;GET api/2.0/files/settings/defaulttemplate&#x60;  returns exactly that list; an extension outside it leaves the settings unchanged instead of failing.
        /// </summary>
        /// <example>.docx</example>
        [DataMember(Name = "fileExtension", IsRequired = true, EmitDefaultValue = true)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultTemplateSettingsResetRequestDto {\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
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
