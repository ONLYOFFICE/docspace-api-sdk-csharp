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
    /// Represents the usage statistics of a DocsCloud tenant for the current period.
    /// </summary>
    [DataContract(Name = "DocsCloudStats")]
    public partial class DocsCloudStats : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudStats" /> class.
        /// </summary>
        /// <param name="periodDay">The length of the statistics period in days..</param>
        /// <param name="editor">editor.</param>
        /// <param name="viewer">viewer.</param>
        public DocsCloudStats(int periodDay = default, DocsCloudUserStats editor = default, DocsCloudUserStats viewer = default)
        {
            this.PeriodDay = periodDay;
            this.Editor = editor;
            this.Viewer = viewer;
        }

        /// <summary>
        /// The length of the statistics period in days.
        /// </summary>
        /// <value>The length of the statistics period in days.</value>
        /*
        <example>30</example>
        */
        [DataMember(Name = "periodDay", EmitDefaultValue = false)]
        public int PeriodDay { get; set; }

        /// <summary>
        /// Gets or Sets Editor
        /// </summary>
        [DataMember(Name = "editor", EmitDefaultValue = false)]
        public DocsCloudUserStats Editor { get; set; }

        /// <summary>
        /// Gets or Sets Viewer
        /// </summary>
        [DataMember(Name = "viewer", EmitDefaultValue = false)]
        public DocsCloudUserStats Viewer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudStats {\n");
            sb.Append("  PeriodDay: ").Append(PeriodDay).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  Viewer: ").Append(Viewer).Append("\n");
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
