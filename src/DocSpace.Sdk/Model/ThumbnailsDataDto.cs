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
    /// The thumbnails data parameters.
    /// </summary>
    [DataContract(Name = "ThumbnailsDataDto")]
    public partial class ThumbnailsDataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailsDataDto" /> class.
        /// </summary>
        /// <param name="original">The thumbnail original photo..</param>
        /// <param name="retina">The thumbnail retina..</param>
        /// <param name="max">The thumbnail maximum size photo..</param>
        /// <param name="big">The thumbnail big size photo..</param>
        /// <param name="medium">The thumbnail medium size photo..</param>
        /// <param name="small">The thumbnail small size photo..</param>
        public ThumbnailsDataDto(string original = default, string retina = default, string max = default, string big = default, string medium = default, string small = default)
        {
            this.Original = original;
            this.Retina = retina;
            this.Max = max;
            this.Big = big;
            this.Medium = medium;
            this.Small = small;
        }

        /// <summary>
        /// The thumbnail original photo.
        /// </summary>
        /// <value>The thumbnail original photo.</value>
        /*
        <example>default_user_photo_size_1280-1280.png</example>
        */
        [DataMember(Name = "original", EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// The thumbnail retina.
        /// </summary>
        /// <value>The thumbnail retina.</value>
        /*
        <example>default_user_photo_size_360-360.png</example>
        */
        [DataMember(Name = "retina", EmitDefaultValue = true)]
        public string Retina { get; set; }

        /// <summary>
        /// The thumbnail maximum size photo.
        /// </summary>
        /// <value>The thumbnail maximum size photo.</value>
        /*
        <example>default_user_photo_size_200-200.png</example>
        */
        [DataMember(Name = "max", EmitDefaultValue = true)]
        public string Max { get; set; }

        /// <summary>
        /// The thumbnail big size photo.
        /// </summary>
        /// <value>The thumbnail big size photo.</value>
        /*
        <example>default_user_photo_size_82-82.png</example>
        */
        [DataMember(Name = "big", EmitDefaultValue = true)]
        public string Big { get; set; }

        /// <summary>
        /// The thumbnail medium size photo.
        /// </summary>
        /// <value>The thumbnail medium size photo.</value>
        /*
        <example>default_user_photo_size_48-48.png</example>
        */
        [DataMember(Name = "medium", EmitDefaultValue = true)]
        public string Medium { get; set; }

        /// <summary>
        /// The thumbnail small size photo.
        /// </summary>
        /// <value>The thumbnail small size photo.</value>
        /*
        <example>default_user_photo_size_32-32.png</example>
        */
        [DataMember(Name = "small", EmitDefaultValue = true)]
        public string Small { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailsDataDto {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Retina: ").Append(Retina).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Big: ").Append(Big).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
