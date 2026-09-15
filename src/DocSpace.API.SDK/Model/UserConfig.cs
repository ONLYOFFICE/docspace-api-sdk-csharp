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
    /// The account the editors attribute the changes of this session to.
    /// </summary>
    [DataContract(Name = "UserConfig")]
    public partial class UserConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfig" /> class.
        /// </summary>
        /// <param name="id">The account the changes are recorded under. Two sessions carrying the same value are taken by the editors for  the same person..</param>
        /// <param name="name">The name shown next to the changes and in the list of participants..</param>
        /// <param name="image">An absolute address of the avatar shown for this participant..</param>
        /// <param name="roles">The filling roles this participant holds in the form being filled out. It is set only for a form in a virtual  data room, where the role decides which fields open for them..</param>
        /// <param name="customerId">Identifies the paying customer this participant belongs to, on deployments where the editors are licensed per  customer..</param>
        public UserConfig(string id = default, string name = default, string image = default, List<string> roles = default, string customerId = default)
        {
            this.Id = id;
            this.Name = name;
            this.Image = image;
            this.Roles = roles;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// The account the changes are recorded under. Two sessions carrying the same value are taken by the editors for  the same person.
        /// </summary>
        /// <example>9924256b-447c-4f19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name shown next to the changes and in the list of participants.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// An absolute address of the avatar shown for this participant.
        /// </summary>
        /// <example>https://portal.example.com/storage/userphotos/9924256b_medium.png</example>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The filling roles this participant holds in the form being filled out. It is set only for a form in a virtual  data room, where the role decides which fields open for them.
        /// </summary>
        /// <example>["Manager"]</example>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Identifies the paying customer this participant belongs to, on deployments where the editors are licensed per  customer.
        /// </summary>
        /// <example>cust_001</example>
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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
