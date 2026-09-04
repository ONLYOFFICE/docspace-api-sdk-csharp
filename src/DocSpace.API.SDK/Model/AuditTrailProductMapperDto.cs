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
    /// The audit trail actions of one product, grouped by module.
    /// </summary>
    [DataContract(Name = "AuditTrailProductMapperDto")]
    public partial class AuditTrailProductMapperDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailProductMapperDto" /> class.
        /// </summary>
        /// <param name="productType">The product name..</param>
        /// <param name="modules">The modules of the product..</param>
        public AuditTrailProductMapperDto(string productType = default, List<AuditTrailModuleMapperDto> modules = default)
        {
            this.ProductType = productType;
            this.Modules = modules;
        }

        /// <summary>
        /// The product name.
        /// </summary>
        /// <example>Documents</example>
        [DataMember(Name = "productType", EmitDefaultValue = true)]
        public string ProductType { get; set; }

        /// <summary>
        /// The modules of the product.
        /// </summary>
        [DataMember(Name = "modules", EmitDefaultValue = true)]
        public List<AuditTrailModuleMapperDto> Modules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditTrailProductMapperDto {\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
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
