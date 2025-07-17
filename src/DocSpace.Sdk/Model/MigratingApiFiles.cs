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
    /// MigratingApiFiles
    /// </summary>
    [DataContract(Name = "MigratingApiFiles")]
    public partial class MigratingApiFiles : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratingApiFiles" /> class.
        /// </summary>
        /// <param name="foldersCount">foldersCount.</param>
        /// <param name="filesCount">filesCount.</param>
        /// <param name="bytesTotal">bytesTotal.</param>
        public MigratingApiFiles(int foldersCount = default, int filesCount = default, long bytesTotal = default)
        {
            this.FoldersCount = foldersCount;
            this.FilesCount = filesCount;
            this.BytesTotal = bytesTotal;
        }

        /// <summary>
        /// Gets or Sets FoldersCount
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "foldersCount", EmitDefaultValue = false)]
        public int FoldersCount { get; set; }

        /// <summary>
        /// Gets or Sets FilesCount
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "filesCount", EmitDefaultValue = false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// Gets or Sets BytesTotal
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "bytesTotal", EmitDefaultValue = false)]
        public long BytesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigratingApiFiles {\n");
            sb.Append("  FoldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  BytesTotal: ").Append(BytesTotal).Append("\n");
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
