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
    /// The body of the conversion prompt switch: which of the two prompts to hide.
    /// </summary>
    [DataContract(Name = "HideConfirmConvertRequestDto")]
    public partial class HideConfirmConvertRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HideConfirmConvertRequestDto" /> class.
        /// </summary>
        /// <param name="save">Chooses the prompt to hide rather than the state to store: true hides the prompt that offers to keep a copy in  the original format when a document is converted, false hides the prompt that offers to open the conversion  result. Each of the two flags is stored separately for the calling account, and both are one-way - the portal  can hide a prompt but has no way to show it again..</param>
        public HideConfirmConvertRequestDto(bool save = default)
        {
            this.Save = save;
        }

        /// <summary>
        /// Chooses the prompt to hide rather than the state to store: true hides the prompt that offers to keep a copy in  the original format when a document is converted, false hides the prompt that offers to open the conversion  result. Each of the two flags is stored separately for the calling account, and both are one-way - the portal  can hide a prompt but has no way to show it again.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "save", EmitDefaultValue = true)]
        public bool Save { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HideConfirmConvertRequestDto {\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
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
