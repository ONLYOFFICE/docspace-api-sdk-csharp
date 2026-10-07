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
    /// A colour theme to store.
    /// </summary>
    [DataContract(Name = "CustomColorThemeRequestDto")]
    public partial class CustomColorThemeRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemeRequestDto" /> class.
        /// </summary>
        /// <param name="id">The id of the custom theme to replace, or an id no stored theme has to add a new one..</param>
        /// <param name="name">Accepted for compatibility with earlier clients and not read: a custom theme is always stored without a name..</param>
        /// <param name="main">The accent and button colours of the interface. Left out, a stored theme keeps its own..</param>
        /// <param name="text">The colours of the text shown on the accent and on the buttons. Left out, a stored theme keeps its own..</param>
        public CustomColorThemeRequestDto(int id = default, string name = default, ColorThemeColorsRequestDto main = default, ColorThemeColorsRequestDto text = default)
        {
            this.Id = id;
            this.Name = name;
            this.Main = main;
            this.Text = text;
        }

        /// <summary>
        /// The id of the custom theme to replace, or an id no stored theme has to add a new one.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: a custom theme is always stored without a name.
        /// </summary>
        /// <example>Custom theme</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The accent and button colours of the interface. Left out, a stored theme keeps its own.
        /// </summary>
        [DataMember(Name = "main", EmitDefaultValue = false)]
        public ColorThemeColorsRequestDto Main { get; set; }

        /// <summary>
        /// The colours of the text shown on the accent and on the buttons. Left out, a stored theme keeps its own.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public ColorThemeColorsRequestDto Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColorThemeRequestDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Main: ").Append(Main).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
