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
    /// One line of a document sharing list in display form: who the document is shared with and the label of their access  level, rather than an access record with identifiers. Entries that deny access and invitation links are left out,  so the list names only the subjects and links that can currently open the document.
    /// </summary>
    [DataContract(Name = "AceShortWrapper")]
    public partial class AceShortWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AceShortWrapper" /> class.
        /// </summary>
        /// <param name="user">Who or what the line stands for, as a display string: the display name of a member, the name of a group, or  the title given to a shared link when &#x60;isLink&#x60; is true. It is empty when the subject has no name to show - a  shared link that was never given a title, for instance..</param>
        /// <param name="permissions">The access level of that subject as a localized label, not a code: inside a room it usually names the role the  subject holds there (Viewer, Editor, Room Manager), while outside a room it names the access itself  (Read Only, Full Access). The wording comes from the portal resources and is translated for the current  language, so show it to a person rather than compare it in code..</param>
        /// <param name="isLink">Whether the line stands for a shared link instead of a member or a group. Clients use it to draw a link badge  where they would otherwise draw an avatar..</param>
        public AceShortWrapper(string user = default, string permissions = default, bool isLink = default)
        {
            this.User = user;
            this.Permissions = permissions;
            this.IsLink = isLink;
        }

        /// <summary>
        /// Who or what the line stands for, as a display string: the display name of a member, the name of a group, or  the title given to a shared link when &#x60;isLink&#x60; is true. It is empty when the subject has no name to show - a  shared link that was never given a title, for instance.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The access level of that subject as a localized label, not a code: inside a room it usually names the role the  subject holds there (Viewer, Editor, Room Manager), while outside a room it names the access itself  (Read Only, Full Access). The wording comes from the portal resources and is translated for the current  language, so show it to a person rather than compare it in code.
        /// </summary>
        /// <example>Read Only</example>
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public string Permissions { get; set; }

        /// <summary>
        /// Whether the line stands for a shared link instead of a member or a group. Clients use it to draw a link badge  where they would otherwise draw an avatar.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLink", EmitDefaultValue = true)]
        public bool IsLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AceShortWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  IsLink: ").Append(IsLink).Append("\n");
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
