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
    /// The parameters for checking file conversion.
    /// </summary>
    [DataContract(Name = "CheckConversionRequestDtoInteger")]
    public partial class CheckConversionRequestDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckConversionRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="fileId">The file ID to check conversion proccess..</param>
        /// <param name="sync">Specifies if the conversion process is synchronous or not..</param>
        /// <param name="startConvert">Specifies whether to start a conversion process or not..</param>
        /// <param name="version">The file version that is converted..</param>
        /// <param name="password">The password of the converted file..</param>
        /// <param name="outputType">The conversion output type..</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it exists or not..</param>
        public CheckConversionRequestDtoInteger(int fileId = default, bool sync = default, bool startConvert = default, int version = default, string password = default, string outputType = default, bool createNewIfExist = default)
        {
            this.FileId = fileId;
            this.Sync = sync;
            this.StartConvert = startConvert;
            this.@Version = version;
            this.Password = password;
            this.OutputType = outputType;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The file ID to check conversion proccess.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// Specifies if the conversion process is synchronous or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        public bool Sync { get; set; }

        /// <summary>
        /// Specifies whether to start a conversion process or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "startConvert", EmitDefaultValue = true)]
        public bool StartConvert { get; set; }

        /// <summary>
        /// The file version that is converted.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The password of the converted file.
        /// </summary>
        /// <example>password123</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The conversion output type.
        /// </summary>
        /// <example>pdf</example>
        [DataMember(Name = "outputType", EmitDefaultValue = true)]
        public string OutputType { get; set; }

        /// <summary>
        /// Specifies whether to create a new file if it exists or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckConversionRequestDtoInteger {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
            sb.Append("  StartConvert: ").Append(StartConvert).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  OutputType: ").Append(OutputType).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
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
