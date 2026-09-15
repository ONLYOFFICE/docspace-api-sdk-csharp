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
    /// Which member is granted or denied the administrator role of which portal module.
    /// </summary>
    [DataContract(Name = "SecurityRequestsDto")]
    public partial class SecurityRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRequestsDto" /> class.
        /// </summary>
        /// <param name="productId">The module the role applies to, given by its GUID. The all-zero GUID stands for the portal itself and grants  or revokes the DocSpace administrator role, which covers every module at once; a GUID that names no module  group is stored without effect rather than refused. (required).</param>
        /// <param name="userId">The portal member the role is given to or taken from, by user ID. The member has to exist already - nobody is  created here - and promoting a guest or a plain member turns them into a paid one. (required).</param>
        /// <param name="administrator">Which way the role goes: &#x60;true&#x60; adds the member to the module administrator group, &#x60;false&#x60; removes them from  it. Taking away the portal-wide role also drops the member from every product group..</param>
        public SecurityRequestsDto(Guid productId = default, Guid userId = default, bool administrator = default)
        {
            this.ProductId = productId;
            this.UserId = userId;
            this.Administrator = administrator;
        }

        /// <summary>
        /// The module the role applies to, given by its GUID. The all-zero GUID stands for the portal itself and grants  or revokes the DocSpace administrator role, which covers every module at once; a GUID that names no module  group is stored without effect rather than refused.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProductId { get; set; }

        /// <summary>
        /// The portal member the role is given to or taken from, by user ID. The member has to exist already - nobody is  created here - and promoting a guest or a plain member turns them into a paid one.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Which way the role goes: &#x60;true&#x60; adds the member to the module administrator group, &#x60;false&#x60; removes them from  it. Taking away the portal-wide role also drops the member from every product group.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "administrator", EmitDefaultValue = true)]
        public bool Administrator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityRequestsDto {\n");
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
