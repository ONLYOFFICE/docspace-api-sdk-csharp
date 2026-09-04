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
    /// An Amazon S3 region.
    /// </summary>
    [DataContract(Name = "AmazonS3RegionDto")]
    public partial class AmazonS3RegionDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonS3RegionDto" /> class.
        /// </summary>
        /// <param name="systemName">The region system name..</param>
        /// <param name="displayName">The human-readable region name..</param>
        /// <param name="partitionName">The name of the AWS partition the region belongs to..</param>
        /// <param name="partitionDnsSuffix">The DNS suffix of the partition..</param>
        /// <param name="partitionRegionRegex">The pattern the region names of the partition match..</param>
        /// <param name="hostnameTemplate">The template the partition builds service endpoint hostnames from..</param>
        public AmazonS3RegionDto(string systemName = default, string displayName = default, string partitionName = default, string partitionDnsSuffix = default, string partitionRegionRegex = default, string hostnameTemplate = default)
        {
            this.SystemName = systemName;
            this.DisplayName = displayName;
            this.PartitionName = partitionName;
            this.PartitionDnsSuffix = partitionDnsSuffix;
            this.PartitionRegionRegex = partitionRegionRegex;
            this.HostnameTemplate = hostnameTemplate;
        }

        /// <summary>
        /// The region system name.
        /// </summary>
        /// <example>eu-west-1</example>
        [DataMember(Name = "systemName", EmitDefaultValue = true)]
        public string SystemName { get; set; }

        /// <summary>
        /// The human-readable region name.
        /// </summary>
        /// <example>Europe (Ireland)</example>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the AWS partition the region belongs to.
        /// </summary>
        /// <example>aws</example>
        [DataMember(Name = "partitionName", EmitDefaultValue = true)]
        public string PartitionName { get; set; }

        /// <summary>
        /// The DNS suffix of the partition.
        /// </summary>
        /// <example>amazonaws.com</example>
        [DataMember(Name = "partitionDnsSuffix", EmitDefaultValue = true)]
        public string PartitionDnsSuffix { get; set; }

        /// <summary>
        /// The pattern the region names of the partition match.
        /// </summary>
        /// <example>^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$</example>
        [DataMember(Name = "partitionRegionRegex", EmitDefaultValue = true)]
        public string PartitionRegionRegex { get; set; }

        /// <summary>
        /// The template the partition builds service endpoint hostnames from.
        /// </summary>
        /// <example>{service}.{region}.{dnsSuffix}</example>
        [DataMember(Name = "hostnameTemplate", EmitDefaultValue = true)]
        public string HostnameTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmazonS3RegionDto {\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PartitionName: ").Append(PartitionName).Append("\n");
            sb.Append("  PartitionDnsSuffix: ").Append(PartitionDnsSuffix).Append("\n");
            sb.Append("  PartitionRegionRegex: ").Append(PartitionRegionRegex).Append("\n");
            sb.Append("  HostnameTemplate: ").Append(HostnameTemplate).Append("\n");
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
