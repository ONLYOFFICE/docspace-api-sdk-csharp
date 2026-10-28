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
        /// <param name="systemName">The region code to send as the region value when configuring an Amazon S3 storage or backup target. It is  the one field of this object that is an argument elsewhere; a code the server does not list here cannot be  reached, so pick one from this list rather than typing it..</param>
        /// <param name="displayName">The region name as Amazon writes it, in English regardless of the portal language, for showing in a  picker next to &#x60;systemName&#x60;..</param>
        /// <param name="partitionName">The Amazon partition the region sits in - the ordinary commercial cloud, the Chinese one, or a government  one. Regions of different partitions are not reachable with the same credentials..</param>
        /// <param name="partitionDnsSuffix">The domain the partition&#39;s service host names end in, which differs from partition to partition..</param>
        /// <param name="partitionRegionRegex">The pattern every region code of this partition matches, for validating a code before sending it..</param>
        /// <param name="hostnameTemplate">How a service host name of the partition is assembled, with &#x60;{service}&#x60;, &#x60;{region}&#x60; and &#x60;{dnsSuffix}&#x60; to  be filled in. It is reference material - the portal builds its own endpoints from &#x60;systemName&#x60;..</param>
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
        /// The region code to send as the region value when configuring an Amazon S3 storage or backup target. It is  the one field of this object that is an argument elsewhere; a code the server does not list here cannot be  reached, so pick one from this list rather than typing it.
        /// </summary>
        /// <example>eu-west-1</example>
        [DataMember(Name = "systemName", EmitDefaultValue = true)]
        public string SystemName { get; set; }

        /// <summary>
        /// The region name as Amazon writes it, in English regardless of the portal language, for showing in a  picker next to &#x60;systemName&#x60;.
        /// </summary>
        /// <example>Europe (Ireland)</example>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The Amazon partition the region sits in - the ordinary commercial cloud, the Chinese one, or a government  one. Regions of different partitions are not reachable with the same credentials.
        /// </summary>
        /// <example>aws</example>
        [DataMember(Name = "partitionName", EmitDefaultValue = true)]
        public string PartitionName { get; set; }

        /// <summary>
        /// The domain the partition&#39;s service host names end in, which differs from partition to partition.
        /// </summary>
        /// <example>amazonaws.com</example>
        [DataMember(Name = "partitionDnsSuffix", EmitDefaultValue = true)]
        public string PartitionDnsSuffix { get; set; }

        /// <summary>
        /// The pattern every region code of this partition matches, for validating a code before sending it.
        /// </summary>
        /// <example>^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$</example>
        [DataMember(Name = "partitionRegionRegex", EmitDefaultValue = true)]
        public string PartitionRegionRegex { get; set; }

        /// <summary>
        /// How a service host name of the partition is assembled, with &#x60;{service}&#x60;, &#x60;{region}&#x60; and &#x60;{dnsSuffix}&#x60; to  be filled in. It is reference material - the portal builds its own endpoints from &#x60;systemName&#x60;.
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
