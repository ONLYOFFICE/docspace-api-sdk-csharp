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
    /// ThumbnailsDataWrapper
    /// </summary>
    [DataContract(Name = "ThumbnailsDataWrapper")]
    public partial class ThumbnailsDataWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailsDataWrapper" /> class.
        /// </summary>
        /// <param name="response">response.</param>
        /// <param name="count">count.</param>
        /// <param name="links">links.</param>
        /// <param name="status">status.</param>
        /// <param name="statusCode">statusCode.</param>
        public ThumbnailsDataWrapper(ThumbnailsDataDto response = default, int count = default, List<ActiveConnectionsWrapperLinksInner> links = default, int status = default, int statusCode = default)
        {
            this.Response = response;
            this.Count = count;
            this.Links = links;
            this.Status = status;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public ThumbnailsDataDto Response { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<ActiveConnectionsWrapperLinksInner> Links { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "statusCode", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailsDataWrapper {\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
