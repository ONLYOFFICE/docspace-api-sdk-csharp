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
    /// How a folder is to be deleted.
    /// </summary>
    [DataContract(Name = "DeleteFolder")]
    public partial class DeleteFolder : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolder" /> class.
        /// </summary>
        /// <param name="deleteAfter">Whether the deletion waits for the editing sessions on the contents to end: with true a folder somebody is  working in is removed once they are done, with false the deletion starts at once..</param>
        /// <param name="immediately">Whether the folder is discarded for good instead of being moved to the Trash section: with false it can be  restored from Trash, with true it cannot be recovered. Inside a room there is no Trash and the deletion is  final either way..</param>
        public DeleteFolder(bool deleteAfter = default, bool immediately = default)
        {
            this.DeleteAfter = deleteAfter;
            this.Immediately = immediately;
        }

        /// <summary>
        /// Whether the deletion waits for the editing sessions on the contents to end: with true a folder somebody is  working in is removed once they are done, with false the deletion starts at once.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// Whether the folder is discarded for good instead of being moved to the Trash section: with false it can be  restored from Trash, with true it cannot be recovered. Inside a room there is no Trash and the deletion is  final either way.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "immediately", EmitDefaultValue = true)]
        public bool Immediately { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFolder {\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  Immediately: ").Append(Immediately).Append("\n");
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
