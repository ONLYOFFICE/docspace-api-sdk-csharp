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
    /// The response containing paginated modification information.
    /// </summary>
    [DataContract(Name = "PageableModificationResponse")]
    public partial class PageableModificationResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PageableModificationResponse" /> class.
        /// </summary>
        /// <param name="data">The paginated modification data..</param>
        /// <param name="limit">The maximum number of results returned per page..</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified..</param>
        public PageableModificationResponse(Object data = default, int limit = default, DateTime lastModifiedOn = default)
        {
            this.Data = data;
            this.Limit = limit;
            this.LastModifiedOn = lastModifiedOn;
        }

        /// <summary>
        /// The paginated modification data.
        /// </summary>
        /// <value>The paginated modification data.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Object Data { get; set; }

        /// <summary>
        /// The maximum number of results returned per page.
        /// </summary>
        /// <value>The maximum number of results returned per page.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// The date when the user consent was last modified.
        /// </summary>
        /// <value>The date when the user consent was last modified.</value>
        [DataMember(Name = "last_modified_on", EmitDefaultValue = false)]
        public DateTime LastModifiedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageableModificationResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
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
