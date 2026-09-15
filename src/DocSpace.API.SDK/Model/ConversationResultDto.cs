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
    /// The progress of one file conversion, together with the converted file once it exists.
    /// </summary>
    [DataContract(Name = "ConversationResultDto")]
    public partial class ConversationResultDto : IValidatableObject
    {

        /// <summary>
        /// Tells which kind of file operation the entry describes, so that a conversion can be told apart from the copy,  move and download entries that share this envelope. A conversion entry reports the conversion type.
        /// </summary>
        [DataMember(Name = "Operation", IsRequired = true, EmitDefaultValue = true)]
        public FileOperationType Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResultDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationResultDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResultDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the conversion entry. The portal leaves it empty for file conversions, so a caller follows  its own conversion by the file it queued rather than by this value. (required).</param>
        /// <param name="operation">Tells which kind of file operation the entry describes, so that a conversion can be told apart from the copy,  move and download entries that share this envelope. A conversion entry reports the conversion type. (required).</param>
        /// <param name="progress">How far the conversion has got, counted in percent from 0 while it is only queued to 100 once it is over -  whether it ended with a converted file or with an error. 100 is the value a polling caller waits for. (required).</param>
        /// <param name="source">Describes what is being converted: the identifier of the source file, the version that was taken and whether  an existing result may be overwritten, packed as a JSON object inside a string. It is what identifies the  entry when several conversions of the same caller are in flight..</param>
        /// <param name="result">result.</param>
        /// <param name="error">The reason the conversion stopped, in the language of the caller, and empty while it is running and after it  has succeeded. &#x60;progress&#x60; reaches 100 for a failure as well, so this field is what separates a converted file  from a broken conversion; a conversion still unfinished after ten minutes ends with a timeout reported here..</param>
        /// <param name="processed">Reports whether the portal has taken the entry as far as it goes: &#x60;1&#x60; once the conversion has finished or  failed, and empty while it is still queued or still being converted. It is the bookkeeping of the conversion  queue rather than a result - what happened is in &#x60;progress&#x60;, &#x60;error&#x60; and &#x60;result&#x60;..</param>
        public ConversationResultDto(string id = default, FileOperationType operation = default, int progress = default, string source = default, Object result = default, string error = default, string processed = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ConversationResultDto and cannot be null");
            }
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            this.Source = source;
            this.Result = result;
            this.Error = error;
            this.Processed = processed;
        }

        /// <summary>
        /// The identifier of the conversion entry. The portal leaves it empty for file conversions, so a caller follows  its own conversion by the file it queued rather than by this value.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// How far the conversion has got, counted in percent from 0 while it is only queued to 100 once it is over -  whether it ended with a converted file or with an error. 100 is the value a polling caller waits for.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public int Progress { get; set; }

        /// <summary>
        /// Describes what is being converted: the identifier of the source file, the version that was taken and whether  an existing result may be overwritten, packed as a JSON object inside a string. It is what identifies the  entry when several conversions of the same caller are in flight.
        /// </summary>
        /// <example>{"id":9846,"version":1,"updateIfExist":false}</example>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// The reason the conversion stopped, in the language of the caller, and empty while it is running and after it  has succeeded. &#x60;progress&#x60; reaches 100 for a failure as well, so this field is what separates a converted file  from a broken conversion; a conversion still unfinished after ten minutes ends with a timeout reported here.
        /// </summary>
        /// <example>Conversion failed</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Reports whether the portal has taken the entry as far as it goes: &#x60;1&#x60; once the conversion has finished or  failed, and empty while it is still queued or still being converted. It is the bookkeeping of the conversion  queue rather than a result - what happened is in &#x60;progress&#x60;, &#x60;error&#x60; and &#x60;result&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "processed", EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
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
