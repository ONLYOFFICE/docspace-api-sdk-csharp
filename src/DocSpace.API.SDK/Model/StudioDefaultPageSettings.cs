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
    /// StudioDefaultPageSettings
    /// </summary>
    [DataContract(Name = "StudioDefaultPageSettings")]
    public partial class StudioDefaultPageSettings : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DefaultFolderType
        /// </summary>
        [DataMember(Name = "defaultFolderType", EmitDefaultValue = false)]
        public FolderType? DefaultFolderType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StudioDefaultPageSettings" /> class.
        /// </summary>
        /// <param name="defaultFolderType">defaultFolderType.</param>
        /// <param name="lastModified">The timestamp indicating when the settings were last modified..</param>
        public StudioDefaultPageSettings(FolderType? defaultFolderType = default, DateTime lastModified = default)
        {
            this.DefaultFolderType = defaultFolderType;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The timestamp indicating when the settings were last modified.
        /// </summary>
        /// <value>The timestamp indicating when the settings were last modified.</value>
        /*
        <example>1990-01-01T00:00Z</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudioDefaultPageSettings {\n");
            sb.Append("  DefaultFolderType: ").Append(DefaultFolderType).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
