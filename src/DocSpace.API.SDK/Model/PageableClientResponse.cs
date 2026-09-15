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
    /// One page of full client records together with the next-page cursor.
    /// </summary>
    [DataContract(Name = "PageableClientResponse")]
    public partial class PageableClientResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PageableClientResponse" /> class.
        /// </summary>
        /// <param name="data">The items on this page, at most as many as the requested limit. An empty array means there is nothing further to read..</param>
        /// <param name="limit">The page size that was applied to this request, between 1 and 50..</param>
        /// <param name="lastClientId">The cursor to send back as last_client_id to ask for the next page, together with last_created_on. It is null when the page is empty..</param>
        /// <param name="lastCreatedOn">The cursor to send back as last_created_on to ask for the next page, together with last_client_id. It is null when the page is empty..</param>
        public PageableClientResponse(List<ClientResponse> data = default, int limit = default, string lastClientId = default, DateTime lastCreatedOn = default)
        {
            this.Data = data;
            this.Limit = limit;
            this.LastClientId = lastClientId;
            this.LastCreatedOn = lastCreatedOn;
        }

        /// <summary>
        /// The items on this page, at most as many as the requested limit. An empty array means there is nothing further to read.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<ClientResponse> Data { get; set; }

        /// <summary>
        /// The page size that was applied to this request, between 1 and 50.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// The cursor to send back as last_client_id to ask for the next page, together with last_created_on. It is null when the page is empty.
        /// </summary>
        /// <example>6c7cf17b-1bd3-47d5-94c6-be2d3570e168</example>
        [DataMember(Name = "last_client_id", EmitDefaultValue = false)]
        public string LastClientId { get; set; }

        /// <summary>
        /// The cursor to send back as last_created_on to ask for the next page, together with last_client_id. It is null when the page is empty.
        /// </summary>
        /// <example>2024-04-04T12:00:00Z</example>
        [DataMember(Name = "last_created_on", EmitDefaultValue = false)]
        public DateTime LastCreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageableClientResponse {\n");
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
