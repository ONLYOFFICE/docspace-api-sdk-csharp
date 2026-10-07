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
    /// The typed form of the metadata search of a folder: the same filter the folder listing takes in the metadataTemplateId  and metadataFilters query parameters, with the conditions as objects instead of a JSON string.
    /// </summary>
    [DataContract(Name = "FolderMetadataSearch")]
    public partial class FolderMetadataSearch : IValidatableObject
    {

        /// <summary>
        /// The filter type.
        /// </summary>
        [DataMember(Name = "filterType", EmitDefaultValue = false)]
        public FilterType? FilterType { get; set; }

        /// <summary>
        /// The sort order.
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public SortOrder? SortOrder { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderMetadataSearch" /> class.
        /// </summary>
        /// <param name="metadataTemplateId">The ID of the metadata template the entries must be assigned to. On its own it narrows the listing to the entries  carrying the template; together with the conditions it also pins the template the filtered fields belong to..</param>
        /// <param name="metadataFilters">The metadata filter conditions, combined with AND. A custom field is addressed by its name instead of the field ID..</param>
        /// <param name="filterValue">The text to search for in the titles and in the custom fields..</param>
        /// <param name="withSubFolders">Specifies whether to search the whole subtree of the folder (the default) or its direct children only..</param>
        /// <param name="filterType">The filter type..</param>
        /// <param name="count">The number of entries to return, from 1 to 100..</param>
        /// <param name="startIndex">The zero-based index of the first entry to return..</param>
        /// <param name="sortBy">The field to sort by, a name of the SortedByType values..</param>
        /// <param name="sortOrder">The sort order..</param>
        public FolderMetadataSearch(int? metadataTemplateId = default, List<MetadataFilterConditionRequest> metadataFilters = default, string filterValue = default, bool? withSubFolders = default, FilterType? filterType = default, int count = default, int startIndex = default, string sortBy = default, SortOrder? sortOrder = default)
        {
            this.MetadataTemplateId = metadataTemplateId;
            this.MetadataFilters = metadataFilters;
            this.FilterValue = filterValue;
            this.WithSubFolders = withSubFolders;
            this.FilterType = filterType;
            this.Count = count;
            this.StartIndex = startIndex;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// The ID of the metadata template the entries must be assigned to. On its own it narrows the listing to the entries  carrying the template; together with the conditions it also pins the template the filtered fields belong to.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "metadataTemplateId", EmitDefaultValue = true)]
        public int? MetadataTemplateId { get; set; }

        /// <summary>
        /// The metadata filter conditions, combined with AND. A custom field is addressed by its name instead of the field ID.
        /// </summary>
        /// <example>[{"fieldId":1,"op":"eq","value":"ACME"},{"name":"Client","op":"eq","value":"ACME"}]</example>
        [DataMember(Name = "metadataFilters", EmitDefaultValue = true)]
        public List<MetadataFilterConditionRequest> MetadataFilters { get; set; }

        /// <summary>
        /// The text to search for in the titles and in the custom fields.
        /// </summary>
        /// <example>ACME</example>
        [DataMember(Name = "filterValue", EmitDefaultValue = true)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Specifies whether to search the whole subtree of the folder (the default) or its direct children only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "withSubFolders", EmitDefaultValue = true)]
        public bool? WithSubFolders { get; set; }

        /// <summary>
        /// The number of entries to return, from 1 to 100.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// The zero-based index of the first entry to return.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// The field to sort by, a name of the SortedByType values.
        /// </summary>
        /// <example>DateAndTime</example>
        [DataMember(Name = "sortBy", EmitDefaultValue = true)]
        public string SortBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderMetadataSearch {\n");
            sb.Append("  MetadataTemplateId: ").Append(MetadataTemplateId).Append("\n");
            sb.Append("  MetadataFilters: ").Append(MetadataFilters).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  WithSubFolders: ").Append(WithSubFolders).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            // Count (int) maximum
            if (this.Count > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 100.", new [] { "Count" });
            }

            // Count (int) minimum
            if (this.Count < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 1.", new [] { "Count" });
            }

            // StartIndex (int) maximum
            if (this.StartIndex > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartIndex, must be a value less than or equal to 2147483647.", new [] { "StartIndex" });
            }

            // StartIndex (int) minimum
            if (this.StartIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartIndex, must be a value greater than or equal to 0.", new [] { "StartIndex" });
            }

            yield break;
        }

    }


}
