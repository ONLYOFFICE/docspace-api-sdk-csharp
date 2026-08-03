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
    /// NewAiAgentsUpdateQuotaRequest
    /// </summary>
    [DataContract(Name = "newAiAgentsUpdateQuota_request")]
    public partial class NewAiAgentsUpdateQuotaRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAgentsUpdateQuotaRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiAgentsUpdateQuotaRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAgentsUpdateQuotaRequest" /> class.
        /// </summary>
        /// <param name="roomIds">Agent (room) ids to update. (required).</param>
        /// <param name="quota">New quota in bytes; a negative value disables the custom quota. (required).</param>
        public NewAiAgentsUpdateQuotaRequest(List<NewAiAgentsUpdateQuotaRequestRoomIdsInner> roomIds = default, decimal quota = default)
        {
            // to ensure "roomIds" is required (not null)
            if (roomIds == null)
            {
                throw new ArgumentNullException("roomIds is a required property for NewAiAgentsUpdateQuotaRequest and cannot be null");
            }
            this.RoomIds = roomIds;
            this.Quota = quota;
        }

        /// <summary>
        /// Agent (room) ids to update.
        /// </summary>
        /// <value>Agent (room) ids to update.</value>
        [DataMember(Name = "roomIds", IsRequired = true, EmitDefaultValue = true)]
        public List<NewAiAgentsUpdateQuotaRequestRoomIdsInner> RoomIds { get; set; }

        /// <summary>
        /// New quota in bytes; a negative value disables the custom quota.
        /// </summary>
        /// <value>New quota in bytes; a negative value disables the custom quota.</value>
        [DataMember(Name = "quota", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiAgentsUpdateQuotaRequest {\n");
            sb.Append("  RoomIds: ").Append(RoomIds).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
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
