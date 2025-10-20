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
    /// The logo cover information.
    /// </summary>
    [DataContract(Name = "LogoCover")]
    public partial class LogoCover : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoCover" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogoCover() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoCover" /> class.
        /// </summary>
        /// <param name="id">The logo cover ID. (required).</param>
        /// <param name="data">The logo cover data. (required).</param>
        public LogoCover(string id = default, string data = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LogoCover and cannot be null");
            }
            this.Id = id;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for LogoCover and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// The logo cover ID.
        /// </summary>
        /// <value>The logo cover ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The logo cover data.
        /// </summary>
        /// <value>The logo cover data.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoCover {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
