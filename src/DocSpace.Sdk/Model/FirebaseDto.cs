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
    /// The Firebase parameters.
    /// </summary>
    [DataContract(Name = "FirebaseDto")]
    public partial class FirebaseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseDto" /> class.
        /// </summary>
        /// <param name="apiKey">The Firebase API key..</param>
        /// <param name="authDomain">The Firebase authentication domain..</param>
        /// <param name="projectId">The Firebase project ID..</param>
        /// <param name="storageBucket">The Firebase storage bucket..</param>
        /// <param name="messagingSenderId">The Firebase messaging sender ID..</param>
        /// <param name="appId">The Firebase application ID..</param>
        /// <param name="measurementId">The Firebase measurement ID..</param>
        /// <param name="databaseURL">The Firebase database URL..</param>
        public FirebaseDto(string apiKey = default, string authDomain = default, string projectId = default, string storageBucket = default, string messagingSenderId = default, string appId = default, string measurementId = default, string databaseURL = default)
        {
            this.ApiKey = apiKey;
            this.AuthDomain = authDomain;
            this.ProjectId = projectId;
            this.StorageBucket = storageBucket;
            this.MessagingSenderId = messagingSenderId;
            this.AppId = appId;
            this.MeasurementId = measurementId;
            this.DatabaseURL = databaseURL;
        }

        /// <summary>
        /// The Firebase API key.
        /// </summary>
        /// <value>The Firebase API key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "apiKey", EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// The Firebase authentication domain.
        /// </summary>
        /// <value>The Firebase authentication domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "authDomain", EmitDefaultValue = true)]
        public string AuthDomain { get; set; }

        /// <summary>
        /// The Firebase project ID.
        /// </summary>
        /// <value>The Firebase project ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "projectId", EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The Firebase storage bucket.
        /// </summary>
        /// <value>The Firebase storage bucket.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "storageBucket", EmitDefaultValue = true)]
        public string StorageBucket { get; set; }

        /// <summary>
        /// The Firebase messaging sender ID.
        /// </summary>
        /// <value>The Firebase messaging sender ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "messagingSenderId", EmitDefaultValue = true)]
        public string MessagingSenderId { get; set; }

        /// <summary>
        /// The Firebase application ID.
        /// </summary>
        /// <value>The Firebase application ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "appId", EmitDefaultValue = true)]
        public string AppId { get; set; }

        /// <summary>
        /// The Firebase measurement ID.
        /// </summary>
        /// <value>The Firebase measurement ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "measurementId", EmitDefaultValue = true)]
        public string MeasurementId { get; set; }

        /// <summary>
        /// The Firebase database URL.
        /// </summary>
        /// <value>The Firebase database URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "databaseURL", EmitDefaultValue = true)]
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
