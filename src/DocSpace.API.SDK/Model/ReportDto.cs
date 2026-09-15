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
    /// One page of the portal wallet&#39;s money movements, with the paging figures needed to walk the rest.
    /// </summary>
    [DataContract(Name = "ReportDto")]
    public partial class ReportDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDto" /> class.
        /// </summary>
        /// <param name="collection">The movements on this page - top-ups, charges, refunds and corrections alike, newest first. It is empty  for a page past the end of the report as well as for a period in which nothing happened..</param>
        /// <param name="offset">How many movements were skipped before this page, echoed from the request so a client need not remember  what it asked for..</param>
        /// <param name="limit">How many movements one page may hold, echoed from the request; it is 25 unless another value was asked  for. A full page is not proof that more exist - compare &#x60;currentPage&#x60; with &#x60;totalPage&#x60;..</param>
        /// <param name="totalQuantity">How many movements match the filters in total, across every page..</param>
        /// <param name="totalPage">How many pages those movements come to at the current &#x60;limit&#x60;..</param>
        /// <param name="currentPage">Which of those pages this one is, as the billing service numbers them. Page through by advancing &#x60;offset&#x60;  rather than this value, which nothing accepts as an argument..</param>
        public ReportDto(List<OperationDto> collection = default, int offset = default, int limit = default, long totalQuantity = default, int totalPage = default, int currentPage = default)
        {
            this.Collection = collection;
            this.Offset = offset;
            this.Limit = limit;
            this.TotalQuantity = totalQuantity;
            this.TotalPage = totalPage;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// The movements on this page - top-ups, charges, refunds and corrections alike, newest first. It is empty  for a page past the end of the report as well as for a period in which nothing happened.
        /// </summary>
        /// <example>[{"service":"disk-storage","debit":14.0}]</example>
        [DataMember(Name = "collection", EmitDefaultValue = true)]
        public List<OperationDto> Collection { get; set; }

        /// <summary>
        /// How many movements were skipped before this page, echoed from the request so a client need not remember  what it asked for.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// How many movements one page may hold, echoed from the request; it is 25 unless another value was asked  for. A full page is not proof that more exist - compare &#x60;currentPage&#x60; with &#x60;totalPage&#x60;.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// How many movements match the filters in total, across every page.
        /// </summary>
        /// <example>137</example>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public long TotalQuantity { get; set; }

        /// <summary>
        /// How many pages those movements come to at the current &#x60;limit&#x60;.
        /// </summary>
        /// <example>6</example>
        [DataMember(Name = "totalPage", EmitDefaultValue = false)]
        public int TotalPage { get; set; }

        /// <summary>
        /// Which of those pages this one is, as the billing service numbers them. Page through by advancing &#x60;offset&#x60;  rather than this value, which nothing accepts as an argument.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "currentPage", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDto {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  TotalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
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
