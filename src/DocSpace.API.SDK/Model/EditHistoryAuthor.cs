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
    /// The person a saved revision of a file, or one single change in it, is attributed to.
    /// </summary>
    [DataContract(Name = "EditHistoryAuthor")]
    public partial class EditHistoryAuthor : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryAuthor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditHistoryAuthor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryAuthor" /> class.
        /// </summary>
        /// <param name="id">The account the revision or the change is attributed to, as the editing service stored it. It is normally the  identifier of a portal account; the empty identifier stands for a change nobody could be named for. (required).</param>
        /// <param name="name">The display name of that account as the portal spells it now, which need not be the name that was stored with  the revision. An account that cannot be resolved - one removed from the portal, or a change made through an  anonymous link - is reported as a guest..</param>
        public EditHistoryAuthor(string id = default, string name = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EditHistoryAuthor and cannot be null");
            }
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// The account the revision or the change is attributed to, as the editing service stored it. It is normally the  identifier of a portal account; the empty identifier stands for a change nobody could be named for.
        /// </summary>
        /// <example>9924256b-447c-4f19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The display name of that account as the portal spells it now, which need not be the name that was stored with  the revision. An account that cannot be resolved - one removed from the portal, or a change made through an  anonymous link - is reported as a guest.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryAuthor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
