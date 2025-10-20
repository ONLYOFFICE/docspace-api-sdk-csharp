// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The request parameters for handling the authorization service.
    /// </summary>
    [DataContract(Name = "AuthServiceRequestsDto")]
    public partial class AuthServiceRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthServiceRequestsDto" /> class.
        /// </summary>
        /// <param name="name">The name of the authorization service..</param>
        /// <param name="title">The user-friendly display title of the authorization service..</param>
        /// <param name="description">The brief description of the authorization service..</param>
        /// <param name="instruction">The detailed instructions for configuring or using the authorization service..</param>
        /// <param name="canSet">Specifies whether the authorization service can be configured by the user..</param>
        /// <param name="props">The collection of authorization keys associated with the authorization service..</param>
        public AuthServiceRequestsDto(string name = default, string title = default, string description = default, string instruction = default, bool canSet = default, List<AuthKey> props = default)
        {
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.Instruction = instruction;
            this.CanSet = canSet;
            this.Props = props;
        }

        /// <summary>
        /// The name of the authorization service.
        /// </summary>
        /// <value>The name of the authorization service.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The user-friendly display title of the authorization service.
        /// </summary>
        /// <value>The user-friendly display title of the authorization service.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The brief description of the authorization service.
        /// </summary>
        /// <value>The brief description of the authorization service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The detailed instructions for configuring or using the authorization service.
        /// </summary>
        /// <value>The detailed instructions for configuring or using the authorization service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "instruction", EmitDefaultValue = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Specifies whether the authorization service can be configured by the user.
        /// </summary>
        /// <value>Specifies whether the authorization service can be configured by the user.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canSet", EmitDefaultValue = true)]
        public bool CanSet { get; set; }

        /// <summary>
        /// The collection of authorization keys associated with the authorization service.
        /// </summary>
        /// <value>The collection of authorization keys associated with the authorization service.</value>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<AuthKey> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthServiceRequestsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  CanSet: ").Append(CanSet).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
