/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The session request parameters.
    /// </summary>
    [DataContract(Name = "SessionRequest")]
    public partial class SessionRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        /// <param name="fileName">The file name. (required).</param>
        /// <param name="fileSize">The file size..</param>
        /// <param name="relativePath">The relative path to the file..</param>
        /// <param name="createOn">createOn.</param>
        /// <param name="encrypted">Specifies whether the file is encrypted or not..</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists..</param>
        public SessionRequest(string fileName = default, long fileSize = default, string relativePath = default, ApiDateTime createOn = default, bool encrypted = default, bool createNewIfExist = default)
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for SessionRequest and cannot be null");
            }
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.RelativePath = relativePath;
            this.CreateOn = createOn;
            this.Encrypted = encrypted;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        /// <value>The file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The file size.
        /// </summary>
        /// <value>The file size.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public long FileSize { get; set; }

        /// <summary>
        /// The relative path to the file.
        /// </summary>
        /// <value>The relative path to the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "relativePath", EmitDefaultValue = true)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or Sets CreateOn
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// Specifies whether the file is encrypted or not.
        /// </summary>
        /// <value>Specifies whether the file is encrypted or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool Encrypted { get; set; }

        /// <summary>
        /// Specifies whether to create a new file if it already exists.
        /// </summary>
        /// <value>Specifies whether to create a new file if it already exists.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionRequest {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
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
