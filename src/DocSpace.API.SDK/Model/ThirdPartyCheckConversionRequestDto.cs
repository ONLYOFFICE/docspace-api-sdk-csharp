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
    /// The parameters of one file conversion.
    /// </summary>
    [DataContract(Name = "ThirdPartyCheckConversionRequestDto")]
    public partial class ThirdPartyCheckConversionRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyCheckConversionRequestDto" /> class.
        /// </summary>
        /// <param name="fileId">The file to convert. It is taken from the route of the operation, so a value sent in the body is overwritten..</param>
        /// <param name="sync">How to wait for the result: &#x60;true&#x60; converts inside the request and answers with the finished result, which is  only sensible for small documents, while &#x60;false&#x60; queues the conversion and answers with an entry to poll..</param>
        /// <param name="startConvert">Whether the conversion is to be started. It is set by the operation itself, so a value sent in the body is  overwritten..</param>
        /// <param name="version">The version to convert; 0 or less means the current version..</param>
        /// <param name="password">The password that opens the source document, for a file that is protected by one; anything else may be left  out..</param>
        /// <param name="outputType">The extension of the format to convert into, without the dot, and one the portal can produce from that  source format; left out, the default of the portal for that kind of document is used..</param>
        /// <param name="createNewIfExist">Where the result goes when the file has been converted before: &#x60;true&#x60; creates another file beside the source,  &#x60;false&#x60; replaces the converted file that already exists..</param>
        public ThirdPartyCheckConversionRequestDto(string fileId = default, bool sync = default, bool startConvert = default, int version = default, string password = default, string outputType = default, bool createNewIfExist = default)
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
        /// The file to convert. It is taken from the route of the operation, so a value sent in the body is overwritten.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "fileId", EmitDefaultValue = true)]
        public string FileId { get; set; }

        /// <summary>
        /// How to wait for the result: &#x60;true&#x60; converts inside the request and answers with the finished result, which is  only sensible for small documents, while &#x60;false&#x60; queues the conversion and answers with an entry to poll.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        public bool Sync { get; set; }

        /// <summary>
        /// Whether the conversion is to be started. It is set by the operation itself, so a value sent in the body is  overwritten.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "startConvert", EmitDefaultValue = true)]
        public bool StartConvert { get; set; }

        /// <summary>
        /// The version to convert; 0 or less means the current version.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The password that opens the source document, for a file that is protected by one; anything else may be left  out.
        /// </summary>
        /// <example>password123</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The extension of the format to convert into, without the dot, and one the portal can produce from that  source format; left out, the default of the portal for that kind of document is used.
        /// </summary>
        /// <example>pdf</example>
        [DataMember(Name = "outputType", EmitDefaultValue = true)]
        public string OutputType { get; set; }

        /// <summary>
        /// Where the result goes when the file has been converted before: &#x60;true&#x60; creates another file beside the source,  &#x60;false&#x60; replaces the converted file that already exists.
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
            sb.Append("class ThirdPartyCheckConversionRequestDto {\n");
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
