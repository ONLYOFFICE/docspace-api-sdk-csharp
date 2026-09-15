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
    /// How co-editing is preset when the document opens, and whether the user may switch it afterwards.
    /// </summary>
    [DataContract(Name = "CoEditingConfig")]
    public partial class CoEditingConfig : IValidatableObject
    {

        /// <summary>
        /// The mode the two settings above amount to, as the editors name it.
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public CoEditingConfigMode? Mode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CoEditingConfig" /> class.
        /// </summary>
        /// <param name="change">Whether the user may switch between the two co-editing modes from the editor interface, or is held to the one  the portal preset..</param>
        /// <param name="fast">Whether other participants see each change as it is typed. Left off, changes are exchanged only when a  participant saves, and the paragraph being edited is locked for the others meanwhile..</param>
        /// <param name="mode">The mode the two settings above amount to, as the editors name it..</param>
        public CoEditingConfig(bool change = default, bool fast = default, CoEditingConfigMode? mode = default)
        {
            this.Change = change;
            this.Fast = fast;
            this.Mode = mode;
        }

        /// <summary>
        /// Whether the user may switch between the two co-editing modes from the editor interface, or is held to the one  the portal preset.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "change", EmitDefaultValue = true)]
        public bool Change { get; set; }

        /// <summary>
        /// Whether other participants see each change as it is typed. Left off, changes are exchanged only when a  participant saves, and the paragraph being edited is locked for the others meanwhile.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fast", EmitDefaultValue = true)]
        public bool Fast { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoEditingConfig {\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Fast: ").Append(Fast).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
