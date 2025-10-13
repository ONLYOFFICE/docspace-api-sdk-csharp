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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The Firebase parameters.
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
        /// <param name="apiKey">The Firebase API key. (required).</param>
        /// <param name="authDomain">The Firebase authentication domain. (required).</param>
        /// <param name="projectId">The Firebase project ID. (required).</param>
        /// <param name="storageBucket">The Firebase storage bucket. (required).</param>
        /// <param name="messagingSenderId">The Firebase messaging sender ID. (required).</param>
        /// <param name="appId">The Firebase application ID. (required).</param>
        /// <param name="measurementId">The Firebase measurement ID. (required).</param>
        /// <param name="databaseURL">The Firebase database URL. (required).</param>
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
        /// The Firebase API key.
        /// </summary>
        /// <value>The Firebase API key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "apiKey", IsRequired = true, EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// The Firebase authentication domain.
        /// </summary>
        /// <value>The Firebase authentication domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "authDomain", IsRequired = true, EmitDefaultValue = true)]
        public string AuthDomain { get; set; }

        /// <summary>
        /// The Firebase project ID.
        /// </summary>
        /// <value>The Firebase project ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The Firebase storage bucket.
        /// </summary>
        /// <value>The Firebase storage bucket.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "storageBucket", IsRequired = true, EmitDefaultValue = true)]
        public string StorageBucket { get; set; }

        /// <summary>
        /// The Firebase messaging sender ID.
        /// </summary>
        /// <value>The Firebase messaging sender ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "messagingSenderId", IsRequired = true, EmitDefaultValue = true)]
        public string MessagingSenderId { get; set; }

        /// <summary>
        /// The Firebase application ID.
        /// </summary>
        /// <value>The Firebase application ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "appId", IsRequired = true, EmitDefaultValue = true)]
        public string AppId { get; set; }

        /// <summary>
        /// The Firebase measurement ID.
        /// </summary>
        /// <value>The Firebase measurement ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "measurementId", IsRequired = true, EmitDefaultValue = true)]
        public string MeasurementId { get; set; }

        /// <summary>
        /// The Firebase database URL.
        /// </summary>
        /// <value>The Firebase database URL.</value>
        /*
        <example>some text</example>
        */
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
