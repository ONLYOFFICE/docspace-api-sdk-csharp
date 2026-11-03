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
    /// An &#x60;audio&#x60; part&#39;s sound.
    /// </summary>
    [DataContract(Name = "AiThreadMessageLike_content_anyOf_inner_audio")]
    public partial class AiThreadMessageLikeContentAnyOfInnerAudio : IValidatableObject
    {
        /// <summary>
        /// Audio format: &#x60;mp3&#x60; or &#x60;wav&#x60;.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            [EnumMember(Value = "mp3")]
            Mp3,

            /// <summary>
            /// Enum Wav for value: wav
            /// </summary>
            [EnumMember(Value = "wav")]
            Wav
        }

        /// <summary>
        /// Audio format: &#x60;mp3&#x60; or &#x60;wav&#x60;.
        /// </summary>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeContentAnyOfInnerAudio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadMessageLikeContentAnyOfInnerAudio() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeContentAnyOfInnerAudio" /> class.
        /// </summary>
        /// <param name="data">The audio data, base64. (required).</param>
        /// <param name="format">Audio format: &#x60;mp3&#x60; or &#x60;wav&#x60;. (required).</param>
        public AiThreadMessageLikeContentAnyOfInnerAudio(string data = default, FormatEnum format = default)
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AiThreadMessageLikeContentAnyOfInnerAudio and cannot be null");
            }
            this.Data = data;
            this.Format = format;
        }

        /// <summary>
        /// The audio data, base64.
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThreadMessageLikeContentAnyOfInnerAudio {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
