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
    /// The connection parameters of an external database.
    /// </summary>
    [DataContract(Name = "ExternalDatabaseSettings")]
    public partial class ExternalDatabaseSettings : IValidatableObject
    {

        /// <summary>
        /// The engine of an external database.
        /// </summary>
        [DataMember(Name = "databaseTypeEnum", EmitDefaultValue = false)]
        public ExternalDatabaseType? DatabaseTypeEnum { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDatabaseSettings" /> class.
        /// </summary>
        /// <param name="databaseType">The engine of the external database..</param>
        /// <param name="databaseTypeEnum">The engine of an external database..</param>
        /// <param name="dbHost">The host name or the IP address of the database server..</param>
        /// <param name="dbPort">The port the database server listens on..</param>
        /// <param name="dbName">The name of the database to connect to..</param>
        /// <param name="dbUser">The user name to connect with..</param>
        /// <param name="dbPassword">The password to connect with..</param>
        /// <param name="dbSsl">Specifies whether the connection to the database is secured with SSL..</param>
        /// <param name="sqliteFilePath">The path to the database file, used by the SQLite engine only..</param>
        public ExternalDatabaseSettings(string databaseType = default, ExternalDatabaseType? databaseTypeEnum = default, string dbHost = default, int dbPort = default, string dbName = default, string dbUser = default, string dbPassword = default, bool dbSsl = default, string sqliteFilePath = default)
        {
            this.DatabaseType = databaseType;
            this.DatabaseTypeEnum = databaseTypeEnum;
            this.DbHost = dbHost;
            this.DbPort = dbPort;
            this.DbName = dbName;
            this.DbUser = dbUser;
            this.DbPassword = dbPassword;
            this.DbSsl = dbSsl;
            this.SqliteFilePath = sqliteFilePath;
        }

        /// <summary>
        /// The engine of the external database.
        /// </summary>
        /// <example>mysql</example>
        [DataMember(Name = "databaseType", EmitDefaultValue = true)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// The host name or the IP address of the database server.
        /// </summary>
        /// <example>localhost</example>
        [DataMember(Name = "dbHost", EmitDefaultValue = true)]
        public string DbHost { get; set; }

        /// <summary>
        /// The port the database server listens on.
        /// </summary>
        /// <example>3306</example>
        [DataMember(Name = "dbPort", EmitDefaultValue = false)]
        public int DbPort { get; set; }

        /// <summary>
        /// The name of the database to connect to.
        /// </summary>
        /// <example>docspace</example>
        [DataMember(Name = "dbName", EmitDefaultValue = true)]
        public string DbName { get; set; }

        /// <summary>
        /// The user name to connect with.
        /// </summary>
        /// <example>root</example>
        [DataMember(Name = "dbUser", EmitDefaultValue = true)]
        public string DbUser { get; set; }

        /// <summary>
        /// The password to connect with.
        /// </summary>
        /// <example>my-secret-password</example>
        [DataMember(Name = "dbPassword", EmitDefaultValue = true)]
        public string DbPassword { get; set; }

        /// <summary>
        /// Specifies whether the connection to the database is secured with SSL.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "dbSsl", EmitDefaultValue = true)]
        public bool DbSsl { get; set; }

        /// <summary>
        /// The path to the database file, used by the SQLite engine only.
        /// </summary>
        /// <example>/var/lib/docspace/external.db</example>
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
            sb.Append("  DatabaseTypeEnum: ").Append(DatabaseTypeEnum).Append("\n");
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
