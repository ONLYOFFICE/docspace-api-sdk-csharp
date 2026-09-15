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
    /// The state of one backup or restoring job.
    /// </summary>
    [DataContract(Name = "BackupProgress")]
    public partial class BackupProgress : IValidatableObject
    {

        /// <summary>
        /// Whether this is a backup or a restoring job, reported as a number rather than as a name.
        /// </summary>
        [DataMember(Name = "backupProgressEnum", EmitDefaultValue = false)]
        public BackupProgressEnum? BackupProgressEnum { get; set; }

        /// <summary>
        /// The state of the job: &#x60;Created&#x60; while it waits for a worker to pick it up, &#x60;Running&#x60; while it works,  &#x60;Completed&#x60; once it has finished on its own, &#x60;Canceled&#x60; after it was cancelled, and &#x60;Failted&#x60; when it  stopped on an error, in which case &#x60;error&#x60; carries the reason. Reported as a number rather than as a  name.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DistributedTaskStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupProgress" /> class.
        /// </summary>
        /// <param name="isCompleted">Specifies whether the job has stopped running. This is the field to poll: true means the job will not  change any more, whether it succeeded, failed or was cancelled, and &#x60;status&#x60; tells which of the three  it is..</param>
        /// <param name="progress">The share of the job that is already done, from 0 to 100. A job that has only been queued reports 0,  because the work starts when a separate worker service picks it up..</param>
        /// <param name="error">The message of the error that stopped the job. It is an empty string, not null, while the job runs  and after a job that succeeded, so the sign of a failure is a non-empty value - and this is the only  place where the reason is reported..</param>
        /// <param name="warning">A message about a job that stopped without failing: it names the entry inside the archive that lists  the files which could not be read, when a backup finished without some of them, and it says so when  the job was cancelled. It is an empty string otherwise, and it is only ever filled in for a backup  job - a cancelled restoring job leaves it empty..</param>
        /// <param name="link">The link to download the stored archive. It is an empty string until the archive has been uploaded,  and it is only ever filled in for a backup job, never for a restoring one..</param>
        /// <param name="tenantId">The ID of the portal the job belongs to, or -1 for a job that covers the whole server..</param>
        /// <param name="backupProgressEnum">Whether this is a backup or a restoring job, reported as a number rather than as a name..</param>
        /// <param name="status">The state of the job: &#x60;Created&#x60; while it waits for a worker to pick it up, &#x60;Running&#x60; while it works,  &#x60;Completed&#x60; once it has finished on its own, &#x60;Canceled&#x60; after it was cancelled, and &#x60;Failted&#x60; when it  stopped on an error, in which case &#x60;error&#x60; carries the reason. Reported as a number rather than as a  name..</param>
        /// <param name="taskId">The ID of the job. It is the handle to poll this operation with, and for a backup job it also becomes  the &#x60;id&#x60; of the record in &#x60;GET api/2.0/backup/getbackuphistory&#x60;..</param>
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
        /// Specifies whether the job has stopped running. This is the field to poll: true means the job will not  change any more, whether it succeeded, failed or was cancelled, and &#x60;status&#x60; tells which of the three  it is.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The share of the job that is already done, from 0 to 100. A job that has only been queued reports 0,  because the work starts when a separate worker service picks it up.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// The message of the error that stopped the job. It is an empty string, not null, while the job runs  and after a job that succeeded, so the sign of a failure is a non-empty value - and this is the only  place where the reason is reported.
        /// </summary>
        /// <example>An error occurred during processing</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// A message about a job that stopped without failing: it names the entry inside the archive that lists  the files which could not be read, when a backup finished without some of them, and it says so when  the job was cancelled. It is an empty string otherwise, and it is only ever filled in for a backup  job - a cancelled restoring job leaves it empty.
        /// </summary>
        /// <example>Some files were not included in the backup. For more details, please check storage/missing_info</example>
        [DataMember(Name = "warning", EmitDefaultValue = true)]
        public string Warning { get; set; }

        /// <summary>
        /// The link to download the stored archive. It is an empty string until the archive has been uploaded,  and it is only ever filled in for a backup job, never for a restoring one.
        /// </summary>
        /// <example>https://example.com/products/files/httphandlers/filehandler.ashx?action=download&amp;fileid=1234</example>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// The ID of the portal the job belongs to, or -1 for a job that covers the whole server.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// The ID of the job. It is the handle to poll this operation with, and for a backup job it also becomes  the &#x60;id&#x60; of the record in &#x60;GET api/2.0/backup/getbackuphistory&#x60;.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
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
