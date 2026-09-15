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
    /// The rights to apply to a single file or folder, and how to announce them.
    /// </summary>
    [DataContract(Name = "SecurityInfoSimpleRequestDto")]
    public partial class SecurityInfoSimpleRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityInfoSimpleRequestDto" /> class.
        /// </summary>
        /// <param name="share">One record per account or group whose rights are being set, each naming the subject and the level it gets; a  level of &#x60;None&#x60; takes the access away. An empty collection makes the call change nothing..</param>
        /// <param name="notify">Set to true to have every account named in &#x60;share&#x60; emailed about the access it just received; false changes  the rights without telling anyone..</param>
        /// <param name="sharingMessage">The text put into that email, ignored while &#x60;notify&#x60; is false. Markup is stripped before sending, so only the  plain text of the value survives..</param>
        public SecurityInfoSimpleRequestDto(List<FileShareParams> share = default, bool notify = default, string sharingMessage = default)
        {
            this.Share = share;
            this.Notify = notify;
            this.SharingMessage = sharingMessage;
        }

        /// <summary>
        /// One record per account or group whose rights are being set, each naming the subject and the level it gets; a  level of &#x60;None&#x60; takes the access away. An empty collection makes the call change nothing.
        /// </summary>
        /// <example>[{"access":2,"shareTo":"9924256a-739c-462b-af15-e652a3b1b6eb"}]</example>
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<FileShareParams> Share { get; set; }

        /// <summary>
        /// Set to true to have every account named in &#x60;share&#x60; emailed about the access it just received; false changes  the rights without telling anyone.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// The text put into that email, ignored while &#x60;notify&#x60; is false. Markup is stripped before sending, so only the  plain text of the value survives.
        /// </summary>
        /// <example>You have been granted access to the file</example>
        [DataMember(Name = "sharingMessage", EmitDefaultValue = true)]
        public string SharingMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityInfoSimpleRequestDto {\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  SharingMessage: ").Append(SharingMessage).Append("\n");
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
            // SharingMessage (string) maxLength
            if (this.SharingMessage != null && this.SharingMessage.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharingMessage, length must be less than 255.", new [] { "SharingMessage" });
            }

            // SharingMessage (string) minLength
            if (this.SharingMessage != null && this.SharingMessage.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharingMessage, length must be greater than 0.", new [] { "SharingMessage" });
            }

            yield break;
        }

    }


}
