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
    /// The backup progress parameters.
    /// </summary>
    [DataContract(Name = "BackupProgress")]
    public partial class BackupProgress : IValidatableObject
    {

        /// <summary>
        /// The backup progress type.
        /// </summary>
        [DataMember(Name = "backupProgressEnum", EmitDefaultValue = false)]
        public BackupProgressEnum? BackupProgressEnum { get; set; }

        /// <summary>
        /// The backup progress status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DistributedTaskStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupProgress" /> class.
        /// </summary>
        /// <param name="isCompleted">Specifies if the backup is completed or not..</param>
        /// <param name="progress">The backup progress in percentage..</param>
        /// <param name="error">The backup error message..</param>
        /// <param name="warning">The backup warning message..</param>
        /// <param name="link">The backup link..</param>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="backupProgressEnum">The backup progress type..</param>
        /// <param name="status">The backup progress status..</param>
        /// <param name="taskId">The task ID..</param>
        public BackupProgress(bool isCompleted = default, int progress = default, string error = default, string warning = default, string link = default, int tenantId = default, BackupProgressEnum? backupProgressEnum = default, DistributedTaskStatus? status = default, string taskId = default)
        {
            this.IsCompleted = isCompleted;
            this.Progress = progress;
            this.Error = error;
            this.Warning = warning;
            this.Link = link;
            this.TenantId = tenantId;
            this.BackupProgressEnum = backupProgressEnum;
            this.Status = status;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Specifies if the backup is completed or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The backup progress in percentage.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// The backup error message.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The backup warning message.
        /// </summary>
        [DataMember(Name = "warning", EmitDefaultValue = true)]
        public string Warning { get; set; }

        /// <summary>
        /// The backup link.
        /// </summary>
        /// <example>https://example.com/backup/task_123</example>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        /// <example>task_123</example>
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
            sb.Append("  Warning: ").Append(Warning).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  BackupProgressEnum: ").Append(BackupProgressEnum).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
