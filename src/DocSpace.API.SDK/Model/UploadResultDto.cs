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
    /// The upload result parameters.
    /// </summary>
    [DataContract(Name = "UploadResultDto")]
    public partial class UploadResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResultDto" /> class.
        /// </summary>
        /// <param name="success">Specifies if the upload operation is successful or not..</param>
        /// <param name="data">The uploaded data..</param>
        /// <param name="message">The message sent after the successful upload operation..</param>
        public UploadResultDto(bool success = default, Object data = default, string message = default)
        {
            this.Success = success;
            this.Data = data;
            this.Message = message;
        }

        /// <summary>
        /// Specifies if the upload operation is successful or not.
        /// </summary>
        /// <value>Specifies if the upload operation is successful or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// The uploaded data.
        /// </summary>
        /// <value>The uploaded data.</value>
        /*
        <example>{&quot;id&quot;:10,&quot;title&quot;:&quot;document.docx&quot;}</example>
        */
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// The message sent after the successful upload operation.
        /// </summary>
        /// <value>The message sent after the successful upload operation.</value>
        /*
        <example>File uploaded successfully</example>
        */
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadResultDto {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
