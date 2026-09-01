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
    /// MigrationStatusWrapper
    /// </summary>
    [DataContract(Name = "MigrationStatusWrapper")]
    public partial class MigrationStatusWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationStatusWrapper" /> class.
        /// </summary>
        /// <param name="response">response.</param>
        /// <param name="count">The total number of items in the response.</param>
        /// <param name="links">List of links related to the response.</param>
        /// <param name="status">HTTP status code of the response.</param>
        /// <param name="statusCode">HTTP status code of the response (duplicate of status).</param>
        public MigrationStatusWrapper(MigrationStatusDto response = default, int count = default, List<GetPortalPrices200ResponseLinksInner> links = default, int status = default, int statusCode = default)
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
        public MigrationStatusDto Response { get; set; }

        /// <summary>
        /// The total number of items in the response
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// List of links related to the response
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<GetPortalPrices200ResponseLinksInner> Links { get; set; }

        /// <summary>
        /// HTTP status code of the response
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// HTTP status code of the response (duplicate of status)
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
            sb.Append("class MigrationStatusWrapper {\n");
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
