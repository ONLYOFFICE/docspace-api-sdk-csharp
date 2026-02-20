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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// Request parameters for deleting one or more AI providers.
    /// </summary>
    [DataContract(Name = "RemoveProviderRequestDto")]
    public partial class RemoveProviderRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProviderRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoveProviderRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProviderRequestDto" /> class.
        /// </summary>
        /// <param name="ids">The set of AI provider identifiers to delete. (required).</param>
        public RemoveProviderRequestDto(List<int> ids = default)
        {
            // to ensure "ids" is required (not null)
            if (ids == null)
            {
                throw new ArgumentNullException("ids is a required property for RemoveProviderRequestDto and cannot be null");
            }
            this.Ids = ids;
        }

        /// <summary>
        /// The set of AI provider identifiers to delete.
        /// </summary>
        /// <value>The set of AI provider identifiers to delete.</value>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveProviderRequestDto {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
