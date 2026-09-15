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
    /// One page of the per-service consumption totals, with the paging figures needed to walk the rest.
    /// </summary>
    [DataContract(Name = "CustomerServiceUsageReportDto")]
    public partial class CustomerServiceUsageReportDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerServiceUsageReportDto" /> class.
        /// </summary>
        /// <param name="collection">The services on this page, one entry per service rather than per charge. It is empty for a period in  which nothing was consumed as well as for a page past the end of the report..</param>
        /// <param name="offset">How many entries were skipped before this page, echoed from the request..</param>
        /// <param name="limit">How many entries one page may hold, echoed from the request; it is 25 unless another value was asked for..</param>
        /// <param name="totalQuantity">How many services match the filters in total, across every page - services, not charges..</param>
        /// <param name="totalPage">How many pages those entries come to at the current &#x60;limit&#x60;..</param>
        /// <param name="currentPage">Which of those pages this one is, as the billing service numbers them. Page through by advancing &#x60;offset&#x60;  rather than this value, which nothing accepts as an argument..</param>
        public CustomerServiceUsageReportDto(List<CustomerServiceUsageDto> collection = default, int offset = default, int limit = default, long totalQuantity = default, int totalPage = default, int currentPage = default)
        {
            this.Collection = collection;
            this.Offset = offset;
            this.Limit = limit;
            this.TotalQuantity = totalQuantity;
            this.TotalPage = totalPage;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// The services on this page, one entry per service rather than per charge. It is empty for a period in  which nothing was consumed as well as for a page past the end of the report.
        /// </summary>
        /// <example>[{"service":"backup","totalAmount":49.99}]</example>
        [DataMember(Name = "collection", EmitDefaultValue = true)]
        public List<CustomerServiceUsageDto> Collection { get; set; }

        /// <summary>
        /// How many entries were skipped before this page, echoed from the request.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// How many entries one page may hold, echoed from the request; it is 25 unless another value was asked for.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// How many services match the filters in total, across every page - services, not charges.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public long TotalQuantity { get; set; }

        /// <summary>
        /// How many pages those entries come to at the current &#x60;limit&#x60;.
        /// </summary>
        /// <example>1</example>
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
            sb.Append("class CustomerServiceUsageReportDto {\n");
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
