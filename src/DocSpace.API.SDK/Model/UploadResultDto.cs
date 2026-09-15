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
    /// The outcome of storing an image in temporary storage before it is used as a room logo.
    /// </summary>
    [DataContract(Name = "UploadResultDto")]
    public partial class UploadResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResultDto" /> class.
        /// </summary>
        /// <param name="success">True when the image was stored and its path is in the data field. A rejected image is reported with an error  response rather than with a false here, so this field is true in every answer that carries a body..</param>
        /// <param name="data">data.</param>
        /// <param name="message">Left empty by this operation: nothing is reported here, and a refused image comes back as an error response  instead..</param>
        public UploadResultDto(bool success = default, Object data = default, string message = default)
        {
            this.Success = success;
            this.Data = data;
            this.Message = message;
        }

        /// <summary>
        /// True when the image was stored and its path is in the data field. A rejected image is reported with an error  response rather than with a false here, so this field is true in every answer that carries a body.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// Left empty by this operation: nothing is reported here, and a refused image comes back as an error response  instead.
        /// </summary>
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
