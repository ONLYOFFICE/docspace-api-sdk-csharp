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
    /// Whether one user administers one portal module, echoing back the pair that was asked about.
    /// </summary>
    [DataContract(Name = "ProductAdministratorDto")]
    public partial class ProductAdministratorDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAdministratorDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductAdministratorDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAdministratorDto" /> class.
        /// </summary>
        /// <param name="productId">The module the verdict is about, echoed from the request. The all-zero GUID stands for the portal as a  whole rather than for any single module. (required).</param>
        /// <param name="userId">The user the verdict is about, echoed from the request unchanged - it is not checked for existing. (required).</param>
        /// <param name="administrator">Whether that user administers that module. It is &#x60;true&#x60; for a DocSpace administrator whatever the module,  since the portal-wide role covers every one of them. A &#x60;false&#x60; can also mean the identifiers name no user  or no module at all, so it is not proof that the user exists, and it says nothing about whether the module  is enabled for the portal - &#x60;GET api/2.0/settings/security/{id}&#x60; reports that. (required).</param>
        public ProductAdministratorDto(Guid productId = default, Guid userId = default, bool administrator = default)
        {
            this.ProductId = productId;
            this.UserId = userId;
            this.Administrator = administrator;
        }

        /// <summary>
        /// The module the verdict is about, echoed from the request. The all-zero GUID stands for the portal as a  whole rather than for any single module.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProductId { get; set; }

        /// <summary>
        /// The user the verdict is about, echoed from the request unchanged - it is not checked for existing.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Whether that user administers that module. It is &#x60;true&#x60; for a DocSpace administrator whatever the module,  since the portal-wide role covers every one of them. A &#x60;false&#x60; can also mean the identifiers name no user  or no module at all, so it is not proof that the user exists, and it says nothing about whether the module  is enabled for the portal - &#x60;GET api/2.0/settings/security/{id}&#x60; reports that.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "administrator", IsRequired = true, EmitDefaultValue = true)]
        public bool Administrator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductAdministratorDto {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Administrator: ").Append(Administrator).Append("\n");
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
