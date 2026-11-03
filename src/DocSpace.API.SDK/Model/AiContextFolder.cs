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
    /// The rooms of one account the caller can connect as context, grouped under the account.
    /// </summary>
    [DataContract(Name = "AiContextFolder")]
    public partial class AiContextFolder : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiContextFolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiContextFolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiContextFolder" /> class.
        /// </summary>
        /// <param name="cloud">The account the rooms belong to; &#x60;docspace&#x60; for this portal. (required).</param>
        /// <param name="rooms">The rooms of that account the caller can connect. (required).</param>
        public AiContextFolder(string cloud = default, List<AiContextRoom> rooms = default)
        {
            // to ensure "cloud" is required (not null)
            if (cloud == null)
            {
                throw new ArgumentNullException("cloud is a required property for AiContextFolder and cannot be null");
            }
            this.Cloud = cloud;
            // to ensure "rooms" is required (not null)
            if (rooms == null)
            {
                throw new ArgumentNullException("rooms is a required property for AiContextFolder and cannot be null");
            }
            this.Rooms = rooms;
        }

        /// <summary>
        /// The account the rooms belong to; &#x60;docspace&#x60; for this portal.
        /// </summary>
        /// <example>docspace</example>
        [DataMember(Name = "cloud", IsRequired = true, EmitDefaultValue = true)]
        public string Cloud { get; set; }

        /// <summary>
        /// The rooms of that account the caller can connect.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "rooms", IsRequired = true, EmitDefaultValue = true)]
        public List<AiContextRoom> Rooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiContextFolder {\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
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
