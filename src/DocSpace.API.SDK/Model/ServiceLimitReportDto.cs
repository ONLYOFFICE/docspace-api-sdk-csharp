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
    /// A page of the spending limits in force for the portal users.
    /// </summary>
    [DataContract(Name = "ServiceLimitReportDto")]
    public partial class ServiceLimitReportDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLimitReportDto" /> class.
        /// </summary>
        /// <param name="collection">The limits of this page, one per user; empty when no limit applies to any user or the page is past the end..</param>
        /// <param name="offset">The number of limits skipped before this page..</param>
        /// <param name="limit">The page size the page was read with..</param>
        /// <param name="totalPage">The number of pages the whole list takes at this page size..</param>
        /// <param name="currentPage">The number of this page, starting from 1..</param>
        /// <param name="totalQuantity">The number of users with a limit in force across all pages..</param>
        public ServiceLimitReportDto(List<ServiceLimitDto> collection = default, int offset = default, int limit = default, int totalPage = default, int currentPage = default, int totalQuantity = default)
        {
            this.Collection = collection;
            this.Offset = offset;
            this.Limit = limit;
            this.TotalPage = totalPage;
            this.CurrentPage = currentPage;
            this.TotalQuantity = totalQuantity;
        }

        /// <summary>
        /// The limits of this page, one per user; empty when no limit applies to any user or the page is past the end.
        /// </summary>
        /// <example>[{"id":42,"serviceGroupName":"ai-services","customerAccountNumber":12345,"scope":"Custom","userId":"3f2504e0-4f89-11d3-9a0c-0305e82c3301","amountValue":40,"currency":"USD","period":"Day","periodEnd":"2026-10-18T23:59:59Z","enabled":true,"created":"2026-09-01T10:30:00Z","modified":"2026-09-15T08:00:00Z","usage":{"periodStart":"2026-10-18T00:00:00Z","periodEnd":"2026-10-18T23:59:59Z","amountConsumed":12.5,"amountAvailable":27.5,"quantityConsumed":0}}]</example>
        [DataMember(Name = "collection", EmitDefaultValue = true)]
        public List<ServiceLimitDto> Collection { get; set; }

        /// <summary>
        /// The number of limits skipped before this page.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// The page size the page was read with.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// The number of pages the whole list takes at this page size.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "totalPage", EmitDefaultValue = false)]
        public int TotalPage { get; set; }

        /// <summary>
        /// The number of this page, starting from 1.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "currentPage", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// The number of users with a limit in force across all pages.
        /// </summary>
        /// <example>60</example>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLimitReportDto {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TotalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
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
