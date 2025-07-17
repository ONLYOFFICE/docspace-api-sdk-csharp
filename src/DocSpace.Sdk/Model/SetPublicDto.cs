/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The public settings of the room template to set.
    /// </summary>
    [DataContract(Name = "SetPublicDto")]
    public partial class SetPublicDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPublicDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetPublicDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPublicDto" /> class.
        /// </summary>
        /// <param name="id">The room template ID. (required).</param>
        /// <param name="@public">Specifies whether the room template is public or not..</param>
        public SetPublicDto(int id = default, bool @public = default)
        {
            this.Id = id;
            this.Public = @public;
        }

        /// <summary>
        /// The room template ID.
        /// </summary>
        /// <value>The room template ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Specifies whether the room template is public or not.
        /// </summary>
        /// <value>Specifies whether the room template is public or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool Public { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPublicDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
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
