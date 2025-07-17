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
    /// MigrationApiInfo
    /// </summary>
    [DataContract(Name = "MigrationApiInfo")]
    public partial class MigrationApiInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationApiInfo" /> class.
        /// </summary>
        /// <param name="migratorName">migratorName.</param>
        /// <param name="operation">operation.</param>
        /// <param name="failedArchives">failedArchives.</param>
        /// <param name="users">users.</param>
        /// <param name="withoutEmailUsers">withoutEmailUsers.</param>
        /// <param name="existUsers">existUsers.</param>
        /// <param name="groups">groups.</param>
        /// <param name="importPersonalFiles">importPersonalFiles.</param>
        /// <param name="importSharedFiles">importSharedFiles.</param>
        /// <param name="importSharedFolders">importSharedFolders.</param>
        /// <param name="importCommonFiles">importCommonFiles.</param>
        /// <param name="importProjectFiles">importProjectFiles.</param>
        /// <param name="importGroups">importGroups.</param>
        /// <param name="successedUsers">successedUsers.</param>
        /// <param name="failedUsers">failedUsers.</param>
        /// <param name="files">files.</param>
        /// <param name="errors">errors.</param>
        public MigrationApiInfo(string migratorName = default, string operation = default, List<string> failedArchives = default, List<MigratingApiUser> users = default, List<MigratingApiUser> withoutEmailUsers = default, List<MigratingApiUser> existUsers = default, List<MigratingApiGroup> groups = default, bool importPersonalFiles = default, bool importSharedFiles = default, bool importSharedFolders = default, bool importCommonFiles = default, bool importProjectFiles = default, bool importGroups = default, int successedUsers = default, int failedUsers = default, List<string> files = default, List<string> errors = default)
        {
            this.MigratorName = migratorName;
            this.Operation = operation;
            this.FailedArchives = failedArchives;
            this.Users = users;
            this.WithoutEmailUsers = withoutEmailUsers;
            this.ExistUsers = existUsers;
            this.Groups = groups;
            this.ImportPersonalFiles = importPersonalFiles;
            this.ImportSharedFiles = importSharedFiles;
            this.ImportSharedFolders = importSharedFolders;
            this.ImportCommonFiles = importCommonFiles;
            this.ImportProjectFiles = importProjectFiles;
            this.ImportGroups = importGroups;
            this.SuccessedUsers = successedUsers;
            this.FailedUsers = failedUsers;
            this.Files = files;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets MigratorName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "migratorName", EmitDefaultValue = true)]
        public string MigratorName { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets FailedArchives
        /// </summary>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "failedArchives", EmitDefaultValue = true)]
        public List<string> FailedArchives { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<MigratingApiUser> Users { get; set; }

        /// <summary>
        /// Gets or Sets WithoutEmailUsers
        /// </summary>
        [DataMember(Name = "withoutEmailUsers", EmitDefaultValue = true)]
        public List<MigratingApiUser> WithoutEmailUsers { get; set; }

        /// <summary>
        /// Gets or Sets ExistUsers
        /// </summary>
        [DataMember(Name = "existUsers", EmitDefaultValue = true)]
        public List<MigratingApiUser> ExistUsers { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<MigratingApiGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets ImportPersonalFiles
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importPersonalFiles", EmitDefaultValue = true)]
        public bool ImportPersonalFiles { get; set; }

        /// <summary>
        /// Gets or Sets ImportSharedFiles
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importSharedFiles", EmitDefaultValue = true)]
        public bool ImportSharedFiles { get; set; }

        /// <summary>
        /// Gets or Sets ImportSharedFolders
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importSharedFolders", EmitDefaultValue = true)]
        public bool ImportSharedFolders { get; set; }

        /// <summary>
        /// Gets or Sets ImportCommonFiles
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importCommonFiles", EmitDefaultValue = true)]
        public bool ImportCommonFiles { get; set; }

        /// <summary>
        /// Gets or Sets ImportProjectFiles
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importProjectFiles", EmitDefaultValue = true)]
        public bool ImportProjectFiles { get; set; }

        /// <summary>
        /// Gets or Sets ImportGroups
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "importGroups", EmitDefaultValue = true)]
        public bool ImportGroups { get; set; }

        /// <summary>
        /// Gets or Sets SuccessedUsers
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "successedUsers", EmitDefaultValue = false)]
        public int SuccessedUsers { get; set; }

        /// <summary>
        /// Gets or Sets FailedUsers
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "failedUsers", EmitDefaultValue = false)]
        public int FailedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<string> Files { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationApiInfo {\n");
            sb.Append("  MigratorName: ").Append(MigratorName).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  FailedArchives: ").Append(FailedArchives).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  WithoutEmailUsers: ").Append(WithoutEmailUsers).Append("\n");
            sb.Append("  ExistUsers: ").Append(ExistUsers).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  ImportPersonalFiles: ").Append(ImportPersonalFiles).Append("\n");
            sb.Append("  ImportSharedFiles: ").Append(ImportSharedFiles).Append("\n");
            sb.Append("  ImportSharedFolders: ").Append(ImportSharedFolders).Append("\n");
            sb.Append("  ImportCommonFiles: ").Append(ImportCommonFiles).Append("\n");
            sb.Append("  ImportProjectFiles: ").Append(ImportProjectFiles).Append("\n");
            sb.Append("  ImportGroups: ").Append(ImportGroups).Append("\n");
            sb.Append("  SuccessedUsers: ").Append(SuccessedUsers).Append("\n");
            sb.Append("  FailedUsers: ").Append(FailedUsers).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
