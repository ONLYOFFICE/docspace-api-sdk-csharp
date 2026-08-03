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
    /// An image attachment draft to persist.
    /// </summary>
    [DataContract(Name = "aiAttachmentsSaveImage_request_input")]
    public partial class AiAttachmentsSaveImageRequestInput : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAttachmentsSaveImageRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAttachmentsSaveImageRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAttachmentsSaveImageRequestInput" /> class.
        /// </summary>
        /// <param name="name">Image name. (required).</param>
        /// <param name="base64">Full &#x60;data:image/...;base64,…&#x60; data URL. (required).</param>
        /// <param name="title">Optional display title..</param>
        public AiAttachmentsSaveImageRequestInput(string name = default, string base64 = default, string title = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiAttachmentsSaveImageRequestInput and cannot be null");
            }
            this.Name = name;
            // to ensure "base64" is required (not null)
            if (base64 == null)
            {
                throw new ArgumentNullException("base64 is a required property for AiAttachmentsSaveImageRequestInput and cannot be null");
            }
            this.Base64 = base64;
            this.Title = title;
        }

        /// <summary>
        /// Image name.
        /// </summary>
        /// <value>Image name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Full &#x60;data:image/...;base64,…&#x60; data URL.
        /// </summary>
        /// <value>Full &#x60;data:image/...;base64,…&#x60; data URL.</value>
        [DataMember(Name = "base64", IsRequired = true, EmitDefaultValue = true)]
        public string Base64 { get; set; }

        /// <summary>
        /// Optional display title.
        /// </summary>
        /// <value>Optional display title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAttachmentsSaveImageRequestInput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Base64: ").Append(Base64).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
