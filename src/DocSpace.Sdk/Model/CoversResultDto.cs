// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The result of the cover request containing the cover image data.
    /// </summary>
    [DataContract(Name = "CoversResultDto")]
    public partial class CoversResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CoversResultDto" /> class.
        /// </summary>
        /// <param name="id">The cover unique identifier..</param>
        /// <param name="data">The cover image data..</param>
        public CoversResultDto(string id = default, string data = default)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// The cover unique identifier.
        /// </summary>
        /// <value>The cover unique identifier.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The cover image data.
        /// </summary>
        /// <value>The cover image data.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoversResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
