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
    /// One time zone the host offers, as its identifier and the label to show for it.
    /// </summary>
    [DataContract(Name = "TimezonesRequestsDto")]
    public partial class TimezonesRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimezonesRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesRequestsDto" /> class.
        /// </summary>
        /// <param name="id">The IANA identifier of the time zone. This is the value the portal time zone is set to, so pass it on  unchanged to &#x60;PUT api/2.0/settings/timeandlanguage&#x60;. (required).</param>
        /// <param name="displayName">The label to show for the zone, carrying its UTC offset as it stood when the list was built. The offset is a  snapshot rather than a rule, so a zone observing daylight saving reads differently at other times of the  year; sort and match on &#x60;id&#x60; instead. (required).</param>
        public TimezonesRequestsDto(string id = default, string displayName = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TimezonesRequestsDto and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for TimezonesRequestsDto and cannot be null");
            }
            this.DisplayName = displayName;
        }

        /// <summary>
        /// The IANA identifier of the time zone. This is the value the portal time zone is set to, so pass it on  unchanged to &#x60;PUT api/2.0/settings/timeandlanguage&#x60;.
        /// </summary>
        /// <example>America/New_York</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The label to show for the zone, carrying its UTC offset as it stood when the list was built. The offset is a  snapshot rather than a rule, so a zone observing daylight saving reads differently at other times of the  year; sort and match on &#x60;id&#x60; instead.
        /// </summary>
        /// <example>(UTC-05:00) Eastern Time (US and Canada)</example>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimezonesRequestsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
