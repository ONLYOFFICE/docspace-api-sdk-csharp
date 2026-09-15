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
    /// The revision of the form to open and what the caller intends to do with it.
    /// </summary>
    [DataContract(Name = "CheckFillFormDraft")]
    public partial class CheckFillFormDraft : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckFillFormDraft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckFillFormDraft() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckFillFormDraft" /> class.
        /// </summary>
        /// <param name="version">The revision of the form to open. Pass 0 for the current revision; a positive number addresses that entry of  the file history and is accepted only from a caller who may read the history, so a member who only has  fill-forms access must send 0. (required).</param>
        /// <param name="action">What the caller intends to do with the form. &#x60;view&#x60; asks for a read-only address and &#x60;embedded&#x60; for an address  to be shown inside a frame; both only resolve the address and leave the file untouched. Leave it out to enter  the filling flow, where the personal draft is created or reused. The value is matched case-insensitively, and  anything else behaves like an empty value..</param>
        public CheckFillFormDraft(int version = default, string action = default)
        {
            this.@Version = version;
            this.Action = action;
        }

        /// <summary>
        /// The revision of the form to open. Pass 0 for the current revision; a positive number addresses that entry of  the file history and is accepted only from a caller who may read the history, so a member who only has  fill-forms access must send 0.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// What the caller intends to do with the form. &#x60;view&#x60; asks for a read-only address and &#x60;embedded&#x60; for an address  to be shown inside a frame; both only resolve the address and leave the file untouched. Leave it out to enter  the filling flow, where the personal draft is created or reused. The value is matched case-insensitively, and  anything else behaves like an empty value.
        /// </summary>
        /// <example>view</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Whether the caller asked for a read-only address. The server derives it from &#x60;action&#x60; being &#x60;view&#x60; and ignores  any value sent with the request.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "requestView", EmitDefaultValue = true)]
        public bool RequestView { get; private set; }

        /// <summary>
        /// Returns false as RequestView should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestView()
        {
            return false;
        }
        /// <summary>
        /// Whether the caller asked for an address to be shown inside a frame. The server derives it from &#x60;action&#x60; being  &#x60;embedded&#x60; and ignores any value sent with the request.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "requestEmbedded", EmitDefaultValue = true)]
        public bool RequestEmbedded { get; private set; }

        /// <summary>
        /// Returns false as RequestEmbedded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestEmbedded()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckFillFormDraft {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  RequestView: ").Append(RequestView).Append("\n");
            sb.Append("  RequestEmbedded: ").Append(RequestEmbedded).Append("\n");
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
