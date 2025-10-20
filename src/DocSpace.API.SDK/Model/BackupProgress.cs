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
    /// BackupProgress
    /// </summary>
    [DataContract(Name = "BackupProgress")]
    public partial class BackupProgress : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BackupProgressEnum
        /// </summary>
        [DataMember(Name = "backupProgressEnum", EmitDefaultValue = false)]
        public BackupProgressEnum? BackupProgressEnum { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupProgress" /> class.
        /// </summary>
        /// <param name="isCompleted">isCompleted.</param>
        /// <param name="progress">progress.</param>
        /// <param name="error">error.</param>
        /// <param name="link">link.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="backupProgressEnum">backupProgressEnum.</param>
        /// <param name="taskId">taskId.</param>
        public BackupProgress(bool isCompleted = default, int progress = default, string error = default, string link = default, int tenantId = default, BackupProgressEnum? backupProgressEnum = default, string taskId = default)
        {
            this.IsCompleted = isCompleted;
            this.Progress = progress;
            this.Error = error;
            this.Link = link;
            this.TenantId = tenantId;
            this.BackupProgressEnum = backupProgressEnum;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Gets or Sets IsCompleted
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupProgress {\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  BackupProgressEnum: ").Append(BackupProgressEnum).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
