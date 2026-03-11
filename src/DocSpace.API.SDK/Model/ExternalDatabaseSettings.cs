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
    /// ExternalDatabaseSettings
    /// </summary>
    [DataContract(Name = "ExternalDatabaseSettings")]
    public partial class ExternalDatabaseSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDatabaseSettings" /> class.
        /// </summary>
        /// <param name="databaseType">databaseType.</param>
        /// <param name="dbHost">dbHost.</param>
        /// <param name="dbPort">dbPort.</param>
        /// <param name="dbName">dbName.</param>
        /// <param name="dbUser">dbUser.</param>
        /// <param name="dbPassword">dbPassword.</param>
        /// <param name="dbSsl">dbSsl.</param>
        /// <param name="sqliteFilePath">sqliteFilePath.</param>
        public ExternalDatabaseSettings(string databaseType = default, string dbHost = default, int dbPort = default, string dbName = default, string dbUser = default, string dbPassword = default, bool dbSsl = default, string sqliteFilePath = default)
        {
            this.DatabaseType = databaseType;
            this.DbHost = dbHost;
            this.DbPort = dbPort;
            this.DbName = dbName;
            this.DbUser = dbUser;
            this.DbPassword = dbPassword;
            this.DbSsl = dbSsl;
            this.SqliteFilePath = sqliteFilePath;
        }

        /// <summary>
        /// Gets or Sets DatabaseType
        /// </summary>
        [DataMember(Name = "databaseType", EmitDefaultValue = true)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// Gets or Sets DbHost
        /// </summary>
        [DataMember(Name = "dbHost", EmitDefaultValue = true)]
        public string DbHost { get; set; }

        /// <summary>
        /// Gets or Sets DbPort
        /// </summary>
        [DataMember(Name = "dbPort", EmitDefaultValue = false)]
        public int DbPort { get; set; }

        /// <summary>
        /// Gets or Sets DbName
        /// </summary>
        [DataMember(Name = "dbName", EmitDefaultValue = true)]
        public string DbName { get; set; }

        /// <summary>
        /// Gets or Sets DbUser
        /// </summary>
        [DataMember(Name = "dbUser", EmitDefaultValue = true)]
        public string DbUser { get; set; }

        /// <summary>
        /// Gets or Sets DbPassword
        /// </summary>
        [DataMember(Name = "dbPassword", EmitDefaultValue = true)]
        public string DbPassword { get; set; }

        /// <summary>
        /// Gets or Sets DbSsl
        /// </summary>
        [DataMember(Name = "dbSsl", EmitDefaultValue = true)]
        public bool DbSsl { get; set; }

        /// <summary>
        /// Gets or Sets SqliteFilePath
        /// </summary>
        [DataMember(Name = "sqliteFilePath", EmitDefaultValue = true)]
        public string SqliteFilePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDatabaseSettings {\n");
            sb.Append("  DatabaseType: ").Append(DatabaseType).Append("\n");
            sb.Append("  DbHost: ").Append(DbHost).Append("\n");
            sb.Append("  DbPort: ").Append(DbPort).Append("\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  DbUser: ").Append(DbUser).Append("\n");
            sb.Append("  DbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  DbSsl: ").Append(DbSsl).Append("\n");
            sb.Append("  SqliteFilePath: ").Append(SqliteFilePath).Append("\n");
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
