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
    /// How far the parse or the import queued for this portal has got, and what it produced once it stopped.
    /// </summary>
    [DataContract(Name = "MigrationStatusDto")]
    public partial class MigrationStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationStatusDto" /> class.
        /// </summary>
        /// <param name="progress">The share of the job that is done, from 0 to 100. It advances unevenly, since the stages differ in  length, so poll &#x60;isCompleted&#x60; rather than waiting for this to reach 100..</param>
        /// <param name="error">The message that ended the job, in the portal language. It stays empty while nothing has gone wrong, so  once &#x60;isCompleted&#x60; is &#x60;true&#x60; this field is what tells success from failure..</param>
        /// <param name="parseResult">What the migrator has read so far. After a parse pass it holds the users, the groups and the archives it  could not read, which is the body to edit and post to &#x60;POST api/2.0/migration/migrate&#x60;; during an import it  also carries the accounts that were created and the ones that failed. Its own &#x60;operation&#x60; field, &#x60;parse&#x60;  or &#x60;migration&#x60;, is what tells the two stages apart..</param>
        /// <param name="isCompleted">Whether the job has stopped, successfully or not. It is the field to poll on; the whole body comes back  empty instead when the portal has no job at all, which is not an error..</param>
        public MigrationStatusDto(double progress = default, string error = default, MigrationApiInfo parseResult = default, bool isCompleted = default)
        {
            this.Progress = progress;
            this.Error = error;
            this.ParseResult = parseResult;
            this.IsCompleted = isCompleted;
        }

        /// <summary>
        /// The share of the job that is done, from 0 to 100. It advances unevenly, since the stages differ in  length, so poll &#x60;isCompleted&#x60; rather than waiting for this to reach 100.
        /// </summary>
        /// <example>99.99</example>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public double Progress { get; set; }

        /// <summary>
        /// The message that ended the job, in the portal language. It stays empty while nothing has gone wrong, so  once &#x60;isCompleted&#x60; is &#x60;true&#x60; this field is what tells success from failure.
        /// </summary>
        /// <example>Connection failed</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// What the migrator has read so far. After a parse pass it holds the users, the groups and the archives it  could not read, which is the body to edit and post to &#x60;POST api/2.0/migration/migrate&#x60;; during an import it  also carries the accounts that were created and the ones that failed. Its own &#x60;operation&#x60; field, &#x60;parse&#x60;  or &#x60;migration&#x60;, is what tells the two stages apart.
        /// </summary>
        [DataMember(Name = "parseResult", EmitDefaultValue = false)]
        public MigrationApiInfo ParseResult { get; set; }

        /// <summary>
        /// Whether the job has stopped, successfully or not. It is the field to poll on; the whole body comes back  empty instead when the portal has no job at all, which is not an error.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationStatusDto {\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ParseResult: ").Append(ParseResult).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
