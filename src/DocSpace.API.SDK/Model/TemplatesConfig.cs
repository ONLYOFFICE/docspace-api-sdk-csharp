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
    /// The presence or absence of the templates in the Create New... menu option.
    /// </summary>
    [DataContract(Name = "TemplatesConfig")]
    public partial class TemplatesConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesConfig" /> class.
        /// </summary>
        /// <param name="image">The absolute URL to the image for template..</param>
        /// <param name="title">The template title that will be displayed in the Create New... menu option..</param>
        /// <param name="url">The absolute URL to the document where it will be created and available after creation..</param>
        public TemplatesConfig(string image = default, string title = default, string url = default)
        {
            this.Image = image;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// The absolute URL to the image for template.
        /// </summary>
        /// <value>The absolute URL to the image for template.</value>
        /*
        <example>https://portal.example.com/templates/template1.png</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The template title that will be displayed in the Create New... menu option.
        /// </summary>
        /// <value>The template title that will be displayed in the Create New... menu option.</value>
        /*
        <example>Blank Document</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The absolute URL to the document where it will be created and available after creation.
        /// </summary>
        /// <value>The absolute URL to the document where it will be created and available after creation.</value>
        /*
        <example>https://portal.example.com/editor/new?template=blank</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplatesConfig {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
