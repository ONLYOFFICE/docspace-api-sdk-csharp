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
    /// The migration API information.
    /// </summary>
    [DataContract(Name = "MigrationApiInfo")]
    public partial class MigrationApiInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationApiInfo" /> class.
        /// </summary>
        /// <param name="migratorName">The migrator name..</param>
        /// <param name="operation">The migration operation..</param>
        /// <param name="failedArchives">The list of failed archives..</param>
        /// <param name="users">The list of migrating users..</param>
        /// <param name="withoutEmailUsers">The list of migrating users without email..</param>
        /// <param name="existUsers">The list of existing migrating users..</param>
        /// <param name="groups">The list of migrating groups..</param>
        /// <param name="importPersonalFiles">Specifies whether to import personal files or not..</param>
        /// <param name="importSharedFiles">Specifies whether to import shared files or not..</param>
        /// <param name="importSharedFolders">Specifies whether to import shared folders or not..</param>
        /// <param name="importCommonFiles">Specifies whether to import common files or not..</param>
        /// <param name="importProjectFiles">Specifies whether to import project files or not..</param>
        /// <param name="importGroups">Specifies whether to import groups or not..</param>
        /// <param name="successedUsers">The number of successfully migrated users..</param>
        /// <param name="failedUsers">The number of unsuccessfully migrated users..</param>
        /// <param name="files">The list of migrated files..</param>
        /// <param name="errors">The list of migration errors..</param>
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
        /// The migrator name.
        /// </summary>
        /// <example>Nextcloud</example>
        [DataMember(Name = "migratorName", EmitDefaultValue = true)]
        public string MigratorName { get; set; }

        /// <summary>
        /// The migration operation.
        /// </summary>
        /// <example>parse</example>
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// The list of failed archives.
        /// </summary>
        /// <example>["archive1.zip","archive2.zip"]</example>
        [DataMember(Name = "failedArchives", EmitDefaultValue = true)]
        public List<string> FailedArchives { get; set; }

        /// <summary>
        /// The list of migrating users.
        /// </summary>
        /// <example>[{"id":"9924256B-447C-4F19-9dbd-8ad8c39e8ff5","email":"user@example.com","shouldImport":true}]</example>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<MigratingApiUser> Users { get; set; }

        /// <summary>
        /// The list of migrating users without email.
        /// </summary>
        /// <example>[{"id":"9924256B-447C-4F19-9dbd-8ad8c39e8ff5","shouldImport":false}]</example>
        [DataMember(Name = "withoutEmailUsers", EmitDefaultValue = true)]
        public List<MigratingApiUser> WithoutEmailUsers { get; set; }

        /// <summary>
        /// The list of existing migrating users.
        /// </summary>
        /// <example>[{"id":"9924256B-447C-4F19-9dbd-8ad8c39e8ff5","email":"existing@example.com","shouldImport":true}]</example>
        [DataMember(Name = "existUsers", EmitDefaultValue = true)]
        public List<MigratingApiUser> ExistUsers { get; set; }

        /// <summary>
        /// The list of migrating groups.
        /// </summary>
        /// <example>[{"id":"1","name":"Group1","shouldImport":true}]</example>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<MigratingApiGroup> Groups { get; set; }

        /// <summary>
        /// Specifies whether to import personal files or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "importPersonalFiles", EmitDefaultValue = true)]
        public bool ImportPersonalFiles { get; set; }

        /// <summary>
        /// Specifies whether to import shared files or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "importSharedFiles", EmitDefaultValue = true)]
        public bool ImportSharedFiles { get; set; }

        /// <summary>
        /// Specifies whether to import shared folders or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "importSharedFolders", EmitDefaultValue = true)]
        public bool ImportSharedFolders { get; set; }

        /// <summary>
        /// Specifies whether to import common files or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "importCommonFiles", EmitDefaultValue = true)]
        public bool ImportCommonFiles { get; set; }

        /// <summary>
        /// Specifies whether to import project files or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "importProjectFiles", EmitDefaultValue = true)]
        public bool ImportProjectFiles { get; set; }

        /// <summary>
        /// Specifies whether to import groups or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "importGroups", EmitDefaultValue = true)]
        public bool ImportGroups { get; set; }

        /// <summary>
        /// The number of successfully migrated users.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "successedUsers", EmitDefaultValue = false)]
        public int SuccessedUsers { get; set; }

        /// <summary>
        /// The number of unsuccessfully migrated users.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "failedUsers", EmitDefaultValue = false)]
        public int FailedUsers { get; set; }

        /// <summary>
        /// The list of migrated files.
        /// </summary>
        /// <example>["document.docx","spreadsheet.xlsx"]</example>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<string> Files { get; set; }

        /// <summary>
        /// The list of migration errors.
        /// </summary>
        /// <example>["User not found","File access denied"]</example>
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
