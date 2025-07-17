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
    /// The response containing paginated data.
    /// </summary>
    [DataContract(Name = "PageableResponse")]
    public partial class PageableResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PageableResponse" /> class.
        /// </summary>
        /// <param name="data">The paginated data..</param>
        /// <param name="limit">The maximum number of results returned per page..</param>
        /// <param name="lastClientId">The identifier of the last retrieved client..</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client..</param>
        public PageableResponse(Object data = default, int limit = default, string lastClientId = default, DateTime lastCreatedOn = default)
        {
            this.Data = data;
            this.Limit = limit;
            this.LastClientId = lastClientId;
            this.LastCreatedOn = lastCreatedOn;
        }

        /// <summary>
        /// The paginated data.
        /// </summary>
        /// <value>The paginated data.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Object Data { get; set; }

        /// <summary>
        /// The maximum number of results returned per page.
        /// </summary>
        /// <value>The maximum number of results returned per page.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// The identifier of the last retrieved client.
        /// </summary>
        /// <value>The identifier of the last retrieved client.</value>
        [DataMember(Name = "last_client_id", EmitDefaultValue = false)]
        public string LastClientId { get; set; }

        /// <summary>
        /// The creation date of the last retrieved client.
        /// </summary>
        /// <value>The creation date of the last retrieved client.</value>
        [DataMember(Name = "last_created_on", EmitDefaultValue = false)]
        public DateTime LastCreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageableResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  LastClientId: ").Append(LastClientId).Append("\n");
            sb.Append("  LastCreatedOn: ").Append(LastCreatedOn).Append("\n");
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
