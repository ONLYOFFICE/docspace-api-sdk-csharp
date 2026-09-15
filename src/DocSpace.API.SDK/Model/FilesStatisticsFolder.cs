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
    /// One section of the portal and the space its documents take.
    /// </summary>
    [DataContract(Name = "FilesStatisticsFolder")]
    public partial class FilesStatisticsFolder : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatisticsFolder" /> class.
        /// </summary>
        /// <param name="title">The name of the section as the interface shows it, translated into the language used by the caller, so it  suits display but not matching - which section an entry describes is told by the field that carries it..</param>
        /// <param name="usedSpace">The size of the files kept in the section, in bytes, counting every folder and room inside it; 0 means the  section holds nothing. The counter is brought up to date as an operation finishes, so a reading taken right  after an upload or a delete can still show the previous value..</param>
        public FilesStatisticsFolder(string title = default, long usedSpace = default)
        {
            this.Title = title;
            this.UsedSpace = usedSpace;
        }

        /// <summary>
        /// The name of the section as the interface shows it, translated into the language used by the caller, so it  suits display but not matching - which section an entry describes is told by the field that carries it.
        /// </summary>
        /// <example>Files</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The size of the files kept in the section, in bytes, counting every folder and room inside it; 0 means the  section holds nothing. The counter is brought up to date as an operation finishes, so a reading taken right  after an upload or a delete can still show the previous value.
        /// </summary>
        /// <example>1048576</example>
        [DataMember(Name = "usedSpace", EmitDefaultValue = false)]
        public long UsedSpace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesStatisticsFolder {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UsedSpace: ").Append(UsedSpace).Append("\n");
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
