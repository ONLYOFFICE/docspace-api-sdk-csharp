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
    /// One mobile device of the calling user registered for push notifications.
    /// </summary>
    [DataContract(Name = "FirebaseDeviceDto")]
    public partial class FirebaseDeviceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseDeviceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the registration..</param>
        /// <param name="userId">The account the device belongs to; always the caller..</param>
        /// <param name="tenantId">The portal the registration belongs to; always the current one..</param>
        /// <param name="firebaseDeviceToken">The Firebase token the device was issued, as it was sent at registration..</param>
        /// <param name="application">The application the registration is for; &#x60;doc&#x60; for the Documents application..</param>
        /// <param name="isSubscribed">Whether the device is currently sent push notifications..</param>
        public FirebaseDeviceDto(int id = default, Guid userId = default, int tenantId = default, string firebaseDeviceToken = default, string application = default, bool? isSubscribed = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.TenantId = tenantId;
            this.FirebaseDeviceToken = firebaseDeviceToken;
            this.Application = application;
            this.IsSubscribed = isSubscribed;
        }

        /// <summary>
        /// The id of the registration.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The account the device belongs to; always the caller.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The portal the registration belongs to; always the current one.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// The Firebase token the device was issued, as it was sent at registration.
        /// </summary>
        /// <example>fcm-token-123</example>
        [DataMember(Name = "firebaseDeviceToken", EmitDefaultValue = true)]
        public string FirebaseDeviceToken { get; set; }

        /// <summary>
        /// The application the registration is for; &#x60;doc&#x60; for the Documents application.
        /// </summary>
        /// <example>doc</example>
        [DataMember(Name = "application", EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Whether the device is currently sent push notifications.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isSubscribed", EmitDefaultValue = true)]
        public bool? IsSubscribed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirebaseDeviceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  FirebaseDeviceToken: ").Append(FirebaseDeviceToken).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  IsSubscribed: ").Append(IsSubscribed).Append("\n");
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
