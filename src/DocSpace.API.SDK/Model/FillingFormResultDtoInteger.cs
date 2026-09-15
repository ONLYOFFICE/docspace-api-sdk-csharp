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
    /// The outcome of one completed form-filling session, as the person who has just filled the form sees it.
    /// </summary>
    [DataContract(Name = "FillingFormResultDtoInteger")]
    public partial class FillingFormResultDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FillingFormResultDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FillingFormResultDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FillingFormResultDtoInteger" /> class.
        /// </summary>
        /// <param name="formNumber">The number this copy was given among the copies made of the same form, counting up from 1. It is the number  the results of the form are ordered by and the one the title of the copy carries. (required).</param>
        /// <param name="completedForm">The filled copy that the session produced, as an ordinary file: it can be read and downloaded with the file  operations of this API..</param>
        /// <param name="originalForm">The form the copy was made from, so that a client can offer filling it once more..</param>
        /// <param name="manager">The account that owns the original form, reported with its email address, so that the person who has just  filled the form knows who receives it and whom to ask about it..</param>
        /// <param name="roomId">The room the form was filled in. It comes back as 0 when the session was reached through a link shared for  that single form rather than for its room, in which case there is no room the caller could be sent to. (required).</param>
        /// <param name="isRoomMember">Tells whether the calling account may open that room: true for a member of the room and for a portal  administrator, in which case a client can offer going to the room; false for the anonymous caller who filled  the form through a link and can only be shown the copy itself..</param>
        public FillingFormResultDtoInteger(int formNumber = default, FileDtoInteger completedForm = default, FileDtoInteger originalForm = default, EmployeeFullDto manager = default, int roomId = default, bool isRoomMember = default)
        {
            this.FormNumber = formNumber;
            this.RoomId = roomId;
            this.CompletedForm = completedForm;
            this.OriginalForm = originalForm;
            this.Manager = manager;
            this.IsRoomMember = isRoomMember;
        }

        /// <summary>
        /// The number this copy was given among the copies made of the same form, counting up from 1. It is the number  the results of the form are ordered by and the one the title of the copy carries.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "formNumber", IsRequired = true, EmitDefaultValue = true)]
        public int FormNumber { get; set; }

        /// <summary>
        /// The filled copy that the session produced, as an ordinary file: it can be read and downloaded with the file  operations of this API.
        /// </summary>
        [DataMember(Name = "completedForm", EmitDefaultValue = false)]
        public FileDtoInteger CompletedForm { get; set; }

        /// <summary>
        /// The form the copy was made from, so that a client can offer filling it once more.
        /// </summary>
        [DataMember(Name = "originalForm", EmitDefaultValue = false)]
        public FileDtoInteger OriginalForm { get; set; }

        /// <summary>
        /// The account that owns the original form, reported with its email address, so that the person who has just  filled the form knows who receives it and whom to ask about it.
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public EmployeeFullDto Manager { get; set; }

        /// <summary>
        /// The room the form was filled in. It comes back as 0 when the session was reached through a link shared for  that single form rather than for its room, in which case there is no room the caller could be sent to.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "roomId", IsRequired = true, EmitDefaultValue = true)]
        public int RoomId { get; set; }

        /// <summary>
        /// Tells whether the calling account may open that room: true for a member of the room and for a portal  administrator, in which case a client can offer going to the room; false for the anonymous caller who filled  the form through a link and can only be shown the copy itself.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isRoomMember", EmitDefaultValue = true)]
        public bool IsRoomMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FillingFormResultDtoInteger {\n");
            sb.Append("  FormNumber: ").Append(FormNumber).Append("\n");
            sb.Append("  CompletedForm: ").Append(CompletedForm).Append("\n");
            sb.Append("  OriginalForm: ").Append(OriginalForm).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  IsRoomMember: ").Append(IsRoomMember).Append("\n");
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
