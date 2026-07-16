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
    /// ContentDisposition
    /// </summary>
    [DataContract(Name = "ContentDisposition")]
    public partial class ContentDisposition : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentDisposition" /> class.
        /// </summary>
        /// <param name="dispositionType">dispositionType.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="modificationDate">modificationDate.</param>
        /// <param name="inline">inline.</param>
        /// <param name="readDate">readDate.</param>
        /// <param name="size">size.</param>
        public ContentDisposition(string dispositionType = default, string fileName = default, DateTime creationDate = default, DateTime modificationDate = default, bool inline = default, DateTime readDate = default, long size = default)
        {
            this.DispositionType = dispositionType;
            this.FileName = fileName;
            this.CreationDate = creationDate;
            this.ModificationDate = modificationDate;
            this.Inline = inline;
            this.ReadDate = readDate;
            this.Size = size;
        }

        /// <summary>
        /// Gets or Sets DispositionType
        /// </summary>
        [DataMember(Name = "dispositionType", EmitDefaultValue = true)]
        public string DispositionType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public List<Object> Parameters { get; private set; }

        /// <summary>
        /// Returns false as Parameters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParameters()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        [DataMember(Name = "modificationDate", EmitDefaultValue = false)]
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Gets or Sets Inline
        /// </summary>
        [DataMember(Name = "inline", EmitDefaultValue = true)]
        public bool Inline { get; set; }

        /// <summary>
        /// Gets or Sets ReadDate
        /// </summary>
        [DataMember(Name = "readDate", EmitDefaultValue = false)]
        public DateTime ReadDate { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDisposition {\n");
            sb.Append("  DispositionType: ").Append(DispositionType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  Inline: ").Append(Inline).Append("\n");
            sb.Append("  ReadDate: ").Append(ReadDate).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
