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
    /// The migration status parameters.
    /// </summary>
    [DataContract(Name = "MigrationStatusDto")]
    public partial class MigrationStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationStatusDto" /> class.
        /// </summary>
        /// <param name="progress">The migration progress..</param>
        /// <param name="error">The migration error..</param>
        /// <param name="parseResult">parseResult.</param>
        /// <param name="isCompleted">Specifies whether the migration is completed or not..</param>
        public MigrationStatusDto(double progress = default, string error = default, MigrationApiInfo parseResult = default, bool isCompleted = default)
        {
            this.Progress = progress;
            this.Error = error;
            this.ParseResult = parseResult;
            this.IsCompleted = isCompleted;
        }

        /// <summary>
        /// The migration progress.
        /// </summary>
        /// <value>The migration progress.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public double Progress { get; set; }

        /// <summary>
        /// The migration error.
        /// </summary>
        /// <value>The migration error.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ParseResult
        /// </summary>
        [DataMember(Name = "parseResult", EmitDefaultValue = false)]
        public MigrationApiInfo ParseResult { get; set; }

        /// <summary>
        /// Specifies whether the migration is completed or not.
        /// </summary>
        /// <value>Specifies whether the migration is completed or not.</value>
        /*
        <example>true</example>
        */
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
