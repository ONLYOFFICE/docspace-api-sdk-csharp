// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The Firebase-related request parameters.
    /// </summary>
    [DataContract(Name = "FirebaseRequestsDto")]
    public partial class FirebaseRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseRequestsDto" /> class.
        /// </summary>
        /// <param name="firebaseDeviceToken">The Firebase device token..</param>
        /// <param name="isSubscribed">Specifies whether the user is subscribed to the push notifications or not..</param>
        public FirebaseRequestsDto(string firebaseDeviceToken = default, bool isSubscribed = default)
        {
            this.FirebaseDeviceToken = firebaseDeviceToken;
            this.IsSubscribed = isSubscribed;
        }

        /// <summary>
        /// The Firebase device token.
        /// </summary>
        /// <value>The Firebase device token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "firebaseDeviceToken", EmitDefaultValue = true)]
        public string FirebaseDeviceToken { get; set; }

        /// <summary>
        /// Specifies whether the user is subscribed to the push notifications or not.
        /// </summary>
        /// <value>Specifies whether the user is subscribed to the push notifications or not.</value>
        /*
        <example>true</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
