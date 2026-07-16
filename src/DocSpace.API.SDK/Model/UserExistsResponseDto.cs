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
    /// The user existence check response parameters.
    /// </summary>
    [DataContract(Name = "UserExistsResponseDto")]
    public partial class UserExistsResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public EmployeeStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExistsResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserExistsResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExistsResponseDto" /> class.
        /// </summary>
        /// <param name="exists">Specifies whether the user exists or not. (required).</param>
        /// <param name="status">status.</param>
        public UserExistsResponseDto(bool exists = default, EmployeeStatus? status = default)
        {
            this.Exists = exists;
            this.Status = status;
        }

        /// <summary>
        /// Specifies whether the user exists or not.
        /// </summary>
        /// <value>Specifies whether the user exists or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "exists", IsRequired = true, EmitDefaultValue = true)]
        public bool Exists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserExistsResponseDto {\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
