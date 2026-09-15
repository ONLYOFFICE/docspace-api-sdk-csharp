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
    /// Which mobile device receives the Documents push notifications, and whether it is subscribed.
    /// </summary>
    [DataContract(Name = "FirebaseRequestsDto")]
    public partial class FirebaseRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseRequestsDto" /> class.
        /// </summary>
        /// <param name="firebaseDeviceToken">The registration token Firebase issued to the mobile client for this device, obtained on the device itself.  It is kept as an opaque string of up to 255 characters and is never verified here; it identifies the device  and is matched but never changed, and a token belonging to another member or another portal matches nothing..</param>
        /// <param name="isSubscribed">Whether the device is to receive the room activity messages - an invitation, a role change, an archived room,  a new document. On a first registration it is stored as given; on a registration that already exists it is  ignored, because registering does not update, and the subscription is changed with  &#x60;PUT api/2.0/settings/push/docsubscribe&#x60; instead..</param>
        public FirebaseRequestsDto(string firebaseDeviceToken = default, bool isSubscribed = default)
        {
            this.FirebaseDeviceToken = firebaseDeviceToken;
            this.IsSubscribed = isSubscribed;
        }

        /// <summary>
        /// The registration token Firebase issued to the mobile client for this device, obtained on the device itself.  It is kept as an opaque string of up to 255 characters and is never verified here; it identifies the device  and is matched but never changed, and a token belonging to another member or another portal matches nothing.
        /// </summary>
        /// <example>dGhpc2lzYXRva2Vu...</example>
        [DataMember(Name = "firebaseDeviceToken", EmitDefaultValue = true)]
        public string FirebaseDeviceToken { get; set; }

        /// <summary>
        /// Whether the device is to receive the room activity messages - an invitation, a role change, an archived room,  a new document. On a first registration it is stored as given; on a registration that already exists it is  ignored, because registering does not update, and the subscription is changed with  &#x60;PUT api/2.0/settings/push/docsubscribe&#x60; instead.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isSubscribed", EmitDefaultValue = true)]
        public bool IsSubscribed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirebaseRequestsDto {\n");
            sb.Append("  FirebaseDeviceToken: ").Append(FirebaseDeviceToken).Append("\n");
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
