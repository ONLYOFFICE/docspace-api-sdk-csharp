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
    /// Represents the user limits of a DocsCloud license.
    /// </summary>
    [DataContract(Name = "DocsCloudUsersLimit")]
    public partial class DocsCloudUsersLimit : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudUsersLimit" /> class.
        /// </summary>
        /// <param name="edit">The maximum number of users who can edit documents..</param>
        /// <param name="view">The maximum number of users who can view documents..</param>
        public DocsCloudUsersLimit(int edit = default, int view = default)
        {
            this.Edit = edit;
            this.View = view;
        }

        /// <summary>
        /// The maximum number of users who can edit documents.
        /// </summary>
        /// <value>The maximum number of users who can edit documents.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "edit", EmitDefaultValue = false)]
        public int Edit { get; set; }

        /// <summary>
        /// The maximum number of users who can view documents.
        /// </summary>
        /// <value>The maximum number of users who can view documents.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "view", EmitDefaultValue = false)]
        public int View { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudUsersLimit {\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
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
