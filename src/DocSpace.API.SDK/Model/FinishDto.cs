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
    /// Whether the finished import mails the imported people their activation links before it is cleared away.
    /// </summary>
    [DataContract(Name = "FinishDto")]
    public partial class FinishDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinishDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinishDto" /> class.
        /// </summary>
        /// <param name="isSendWelcomeEmail">Whether every imported account that has not been activated yet is mailed its activation link. Setting it  requires the finished job to still be in the queue, so the import must not have been cleared first; the  letters go out again on each call, and already active accounts are skipped either way. Setting it false ends  the import quietly and leaves inviting those people for later. (required).</param>
        public FinishDto(bool isSendWelcomeEmail = default)
        {
            this.IsSendWelcomeEmail = isSendWelcomeEmail;
        }

        /// <summary>
        /// Whether every imported account that has not been activated yet is mailed its activation link. Setting it  requires the finished job to still be in the queue, so the import must not have been cleared first; the  letters go out again on each call, and already active accounts are skipped either way. Setting it false ends  the import quietly and leaves inviting those people for later.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isSendWelcomeEmail", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSendWelcomeEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinishDto {\n");
            sb.Append("  IsSendWelcomeEmail: ").Append(IsSendWelcomeEmail).Append("\n");
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
