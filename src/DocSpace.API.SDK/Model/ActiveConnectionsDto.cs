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
    /// The connections the calling user currently has open, and which of them the request itself was made with.
    /// </summary>
    [DataContract(Name = "ActiveConnectionsDto")]
    public partial class ActiveConnectionsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActiveConnectionsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsDto" /> class.
        /// </summary>
        /// <param name="loginEvent">The &#x60;id&#x60; of the item in &#x60;items&#x60; that the current request is authenticated by. It is &#x60;0&#x60; when the request  carried a token in the &#x60;Authorization&#x60; header instead of the portal cookie, and in that case none of the  items is the current connection. (required).</param>
        /// <param name="items">One item per sign-in of the caller that is still active, ordered newest sign-in first, with the connection  the request itself uses moved to the front. Sign-ins older than a year are left out, and a caller with no  stored connection gets a single item describing the current request rather than an empty list..</param>
        public ActiveConnectionsDto(int loginEvent = default, List<ActiveConnectionsItemDto> items = default)
        {
            this.LoginEvent = loginEvent;
            this.Items = items;
        }

        /// <summary>
        /// The &#x60;id&#x60; of the item in &#x60;items&#x60; that the current request is authenticated by. It is &#x60;0&#x60; when the request  carried a token in the &#x60;Authorization&#x60; header instead of the portal cookie, and in that case none of the  items is the current connection.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "loginEvent", IsRequired = true, EmitDefaultValue = true)]
        public int LoginEvent { get; set; }

        /// <summary>
        /// One item per sign-in of the caller that is still active, ordered newest sign-in first, with the connection  the request itself uses moved to the front. Sign-ins older than a year are left out, and a caller with no  stored connection gets a single item describing the current request rather than an empty list.
        /// </summary>
        /// <example>[{"id":1234,"ip":"192.0.2.1"}]</example>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<ActiveConnectionsItemDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveConnectionsDto {\n");
            sb.Append("  LoginEvent: ").Append(LoginEvent).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
