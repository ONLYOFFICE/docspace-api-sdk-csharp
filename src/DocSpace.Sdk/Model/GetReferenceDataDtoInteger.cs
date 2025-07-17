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
    /// The request parameters for getting reference data.
    /// </summary>
    [DataContract(Name = "GetReferenceDataDtoInteger")]
    public partial class GetReferenceDataDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetReferenceDataDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDtoInteger" /> class.
        /// </summary>
        /// <param name="fileKey">The unique document identifier used by the service to get a link to the file. (required).</param>
        /// <param name="instanceId">The unique system identifier..</param>
        /// <param name="sourceFileId">The source file ID..</param>
        /// <param name="path">The file name or relative path for the formula editor..</param>
        /// <param name="link">The file link..</param>
        public GetReferenceDataDtoInteger(string fileKey = default, string instanceId = default, int sourceFileId = default, string path = default, string link = default)
        {
            // to ensure "fileKey" is required (not null)
            if (fileKey == null)
            {
                throw new ArgumentNullException("fileKey is a required property for GetReferenceDataDtoInteger and cannot be null");
            }
            this.FileKey = fileKey;
            this.InstanceId = instanceId;
            this.SourceFileId = sourceFileId;
            this.Path = path;
            this.Link = link;
        }

        /// <summary>
        /// The unique document identifier used by the service to get a link to the file.
        /// </summary>
        /// <value>The unique document identifier used by the service to get a link to the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileKey", IsRequired = true, EmitDefaultValue = true)]
        public string FileKey { get; set; }

        /// <summary>
        /// The unique system identifier.
        /// </summary>
        /// <value>The unique system identifier.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "instanceId", EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The source file ID.
        /// </summary>
        /// <value>The source file ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "sourceFileId", EmitDefaultValue = false)]
        public int SourceFileId { get; set; }

        /// <summary>
        /// The file name or relative path for the formula editor.
        /// </summary>
        /// <value>The file name or relative path for the formula editor.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The file link.
        /// </summary>
        /// <value>The file link.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReferenceDataDtoInteger {\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  SourceFileId: ").Append(SourceFileId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
