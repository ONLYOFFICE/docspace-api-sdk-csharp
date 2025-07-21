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
    /// Represents a report containing a collection of operations.
    /// </summary>
    [DataContract(Name = "ReportDto")]
    public partial class ReportDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDto" /> class.
        /// </summary>
        /// <param name="collection">Collection of operations..</param>
        /// <param name="offset">Offset of the report data..</param>
        /// <param name="limit">Limit of the report data..</param>
        /// <param name="totalQuantity">Total quantity of operations in the report..</param>
        /// <param name="totalPage">Total number of pages in the report..</param>
        /// <param name="currentPage">Current page number of the report..</param>
        public ReportDto(List<OperationDto> collection = default, int offset = default, int limit = default, int totalQuantity = default, int totalPage = default, int currentPage = default)
        {
            this.Collection = collection;
            this.Offset = offset;
            this.Limit = limit;
            this.TotalQuantity = totalQuantity;
            this.TotalPage = totalPage;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// Collection of operations.
        /// </summary>
        /// <value>Collection of operations.</value>
        [DataMember(Name = "collection", EmitDefaultValue = true)]
        public List<OperationDto> Collection { get; set; }

        /// <summary>
        /// Offset of the report data.
        /// </summary>
        /// <value>Offset of the report data.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// Limit of the report data.
        /// </summary>
        /// <value>Limit of the report data.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Total quantity of operations in the report.
        /// </summary>
        /// <value>Total quantity of operations in the report.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Total number of pages in the report.
        /// </summary>
        /// <value>Total number of pages in the report.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "totalPage", EmitDefaultValue = false)]
        public int TotalPage { get; set; }

        /// <summary>
        /// Current page number of the report.
        /// </summary>
        /// <value>Current page number of the report.</value>
        /*
        <example>1234</example>
        */
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
