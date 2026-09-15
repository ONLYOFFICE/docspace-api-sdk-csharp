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
    /// The Firebase project a client initialises its SDK with to receive push notifications from this portal.
    /// </summary>
    [DataContract(Name = "FirebaseDto")]
    public partial class FirebaseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirebaseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseDto" /> class.
        /// </summary>
        /// <param name="apiKey">The web API key of the project. Every field of this object is an empty string on an installation that  configures no Firebase project, and an empty &#x60;projectId&#x60; is the cheapest thing to test for before  initialising an SDK. None of these values is a secret - they are meant to be embedded in a client. (required).</param>
        /// <param name="authDomain">The host the Firebase SDK performs its own authentication against. (required).</param>
        /// <param name="projectId">The identifier of the Firebase project itself, which ties all the other fields together. (required).</param>
        /// <param name="storageBucket">The Cloud Storage bucket of the project. The portal does not store portal files there; it is part of the  SDK configuration. (required).</param>
        /// <param name="messagingSenderId">The sender ID that push messages of this project arrive under, which a client checks an incoming message  against. (required).</param>
        /// <param name="appId">The identifier of the Firebase application registration this client is to use. (required).</param>
        /// <param name="measurementId">The Google Analytics measurement ID of the project, empty when the project reports no analytics. (required).</param>
        /// <param name="databaseURL">The Realtime Database endpoint of the project, empty when the project has no such database. (required).</param>
        public FirebaseDto(string apiKey = default, string authDomain = default, string projectId = default, string storageBucket = default, string messagingSenderId = default, string appId = default, string measurementId = default, string databaseURL = default)
        {
            // to ensure "apiKey" is required (not null)
            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey is a required property for FirebaseDto and cannot be null");
            }
            this.ApiKey = apiKey;
            // to ensure "authDomain" is required (not null)
            if (authDomain == null)
            {
                throw new ArgumentNullException("authDomain is a required property for FirebaseDto and cannot be null");
            }
            this.AuthDomain = authDomain;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for FirebaseDto and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "storageBucket" is required (not null)
            if (storageBucket == null)
            {
                throw new ArgumentNullException("storageBucket is a required property for FirebaseDto and cannot be null");
            }
            this.StorageBucket = storageBucket;
            // to ensure "messagingSenderId" is required (not null)
            if (messagingSenderId == null)
            {
                throw new ArgumentNullException("messagingSenderId is a required property for FirebaseDto and cannot be null");
            }
            this.MessagingSenderId = messagingSenderId;
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new ArgumentNullException("appId is a required property for FirebaseDto and cannot be null");
            }
            this.AppId = appId;
            // to ensure "measurementId" is required (not null)
            if (measurementId == null)
            {
                throw new ArgumentNullException("measurementId is a required property for FirebaseDto and cannot be null");
            }
            this.MeasurementId = measurementId;
            // to ensure "databaseURL" is required (not null)
            if (databaseURL == null)
            {
                throw new ArgumentNullException("databaseURL is a required property for FirebaseDto and cannot be null");
            }
            this.DatabaseURL = databaseURL;
        }

        /// <summary>
        /// The web API key of the project. Every field of this object is an empty string on an installation that  configures no Firebase project, and an empty &#x60;projectId&#x60; is the cheapest thing to test for before  initialising an SDK. None of these values is a secret - they are meant to be embedded in a client.
        /// </summary>
        /// <example>AIzaSyDxK9L3j4H8mN2pQ5rS6tU7vW8xY9zA1bC</example>
        [DataMember(Name = "apiKey", IsRequired = true, EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// The host the Firebase SDK performs its own authentication against.
        /// </summary>
        /// <example>myapp-12345.firebaseapp.com</example>
        [DataMember(Name = "authDomain", IsRequired = true, EmitDefaultValue = true)]
        public string AuthDomain { get; set; }

        /// <summary>
        /// The identifier of the Firebase project itself, which ties all the other fields together.
        /// </summary>
        /// <example>myapp-12345</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The Cloud Storage bucket of the project. The portal does not store portal files there; it is part of the  SDK configuration.
        /// </summary>
        /// <example>myapp-12345.appspot.com</example>
        [DataMember(Name = "storageBucket", IsRequired = true, EmitDefaultValue = true)]
        public string StorageBucket { get; set; }

        /// <summary>
        /// The sender ID that push messages of this project arrive under, which a client checks an incoming message  against.
        /// </summary>
        /// <example>123456789012</example>
        [DataMember(Name = "messagingSenderId", IsRequired = true, EmitDefaultValue = true)]
        public string MessagingSenderId { get; set; }

        /// <summary>
        /// The identifier of the Firebase application registration this client is to use.
        /// </summary>
        /// <example>1:123456789012:web:a1b2c3d4e5f6g7h8</example>
        [DataMember(Name = "appId", IsRequired = true, EmitDefaultValue = true)]
        public string AppId { get; set; }

        /// <summary>
        /// The Google Analytics measurement ID of the project, empty when the project reports no analytics.
        /// </summary>
        /// <example>G-ABCD123456</example>
        [DataMember(Name = "measurementId", IsRequired = true, EmitDefaultValue = true)]
        public string MeasurementId { get; set; }

        /// <summary>
        /// The Realtime Database endpoint of the project, empty when the project has no such database.
        /// </summary>
        /// <example>https://myapp-12345.firebaseio.com</example>
        [DataMember(Name = "databaseURL", IsRequired = true, EmitDefaultValue = true)]
        public string DatabaseURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirebaseDto {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  AuthDomain: ").Append(AuthDomain).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  StorageBucket: ").Append(StorageBucket).Append("\n");
            sb.Append("  MessagingSenderId: ").Append(MessagingSenderId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  MeasurementId: ").Append(MeasurementId).Append("\n");
            sb.Append("  DatabaseURL: ").Append(DatabaseURL).Append("\n");
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
