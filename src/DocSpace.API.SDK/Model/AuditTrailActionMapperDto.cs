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
    /// One audit trail action and what it does to what.
    /// </summary>
    [DataContract(Name = "AuditTrailActionMapperDto")]
    public partial class AuditTrailActionMapperDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailActionMapperDto" /> class.
        /// </summary>
        /// <param name="messageAction">The audit event action name..</param>
        /// <param name="actionType">The action type name..</param>
        /// <param name="entity">The name of the entry type the action targets..</param>
        public AuditTrailActionMapperDto(string messageAction = default, string actionType = default, string entity = default)
        {
            this.MessageAction = messageAction;
            this.ActionType = actionType;
            this.Entity = entity;
        }

        /// <summary>
        /// The audit event action name.
        /// </summary>
        /// <example>FileCreated</example>
        [DataMember(Name = "messageAction", EmitDefaultValue = true)]
        public string MessageAction { get; set; }

        /// <summary>
        /// The action type name.
        /// </summary>
        /// <example>Create</example>
        [DataMember(Name = "actionType", EmitDefaultValue = true)]
        public string ActionType { get; set; }

        /// <summary>
        /// The name of the entry type the action targets.
        /// </summary>
        /// <example>File</example>
        [DataMember(Name = "entity", EmitDefaultValue = true)]
        public string Entity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditTrailActionMapperDto {\n");
            sb.Append("  MessageAction: ").Append(MessageAction).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
