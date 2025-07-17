/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// ContentType
    /// </summary>
    [DataContract(Name = "ContentType")]
    public partial class ContentType : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentType" /> class.
        /// </summary>
        /// <param name="boundary">boundary.</param>
        /// <param name="charSet">charSet.</param>
        /// <param name="mediaType">mediaType.</param>
        /// <param name="name">name.</param>
        public ContentType(string boundary = default, string charSet = default, string mediaType = default, string name = default)
        {
            this.Boundary = boundary;
            this.CharSet = charSet;
            this.MediaType = mediaType;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "boundary", EmitDefaultValue = true)]
        public string Boundary { get; set; }

        /// <summary>
        /// Gets or Sets CharSet
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "charSet", EmitDefaultValue = true)]
        public string CharSet { get; set; }

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mediaType", EmitDefaultValue = true)]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public List<Object> Parameters { get; private set; }

        /// <summary>
        /// Returns false as Parameters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParameters()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentType {\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
            sb.Append("  CharSet: ").Append(CharSet).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
