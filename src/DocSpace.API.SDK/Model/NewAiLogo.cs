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
    /// The room logo information.
    /// </summary>
    [DataContract(Name = "NewAiLogo")]
    public partial class NewAiLogo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiLogo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiLogo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiLogo" /> class.
        /// </summary>
        /// <param name="original">The original logo. (required).</param>
        /// <param name="large">The large logo. (required).</param>
        /// <param name="medium">The medium logo. (required).</param>
        /// <param name="small">The small logo. (required).</param>
        /// <param name="color">The logo color..</param>
        /// <param name="cover">cover.</param>
        public NewAiLogo(string original = default, string large = default, string medium = default, string small = default, string color = default, NewAiLogoCover cover = default)
        {
            // to ensure "original" is required (not null)
            if (original == null)
            {
                throw new ArgumentNullException("original is a required property for NewAiLogo and cannot be null");
            }
            this.Original = original;
            // to ensure "large" is required (not null)
            if (large == null)
            {
                throw new ArgumentNullException("large is a required property for NewAiLogo and cannot be null");
            }
            this.Large = large;
            // to ensure "medium" is required (not null)
            if (medium == null)
            {
                throw new ArgumentNullException("medium is a required property for NewAiLogo and cannot be null");
            }
            this.Medium = medium;
            // to ensure "small" is required (not null)
            if (small == null)
            {
                throw new ArgumentNullException("small is a required property for NewAiLogo and cannot be null");
            }
            this.Small = small;
            this.Color = color;
            this.Cover = cover;
        }

        /// <summary>
        /// The original logo.
        /// </summary>
        /// <value>The original logo.</value>
        /*
        <example>https://portal.example.com/logo/original.png</example>
        */
        [DataMember(Name = "original", IsRequired = true, EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// The large logo.
        /// </summary>
        /// <value>The large logo.</value>
        /*
        <example>https://portal.example.com/logo/large.png</example>
        */
        [DataMember(Name = "large", IsRequired = true, EmitDefaultValue = true)]
        public string Large { get; set; }

        /// <summary>
        /// The medium logo.
        /// </summary>
        /// <value>The medium logo.</value>
        /*
        <example>https://portal.example.com/logo/medium.png</example>
        */
        [DataMember(Name = "medium", IsRequired = true, EmitDefaultValue = true)]
        public string Medium { get; set; }

        /// <summary>
        /// The small logo.
        /// </summary>
        /// <value>The small logo.</value>
        /*
        <example>https://portal.example.com/logo/small.png</example>
        */
        [DataMember(Name = "small", IsRequired = true, EmitDefaultValue = true)]
        public string Small { get; set; }

        /// <summary>
        /// The logo color.
        /// </summary>
        /// <value>The logo color.</value>
        /*
        <example>#4781D1</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Cover
        /// </summary>
        [DataMember(Name = "cover", EmitDefaultValue = false)]
        public NewAiLogoCover Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiLogo {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
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
