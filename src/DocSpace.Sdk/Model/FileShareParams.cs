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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The collection of file sharing parameters.
    /// </summary>
    [DataContract(Name = "FileShareParams")]
    public partial class FileShareParams : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareParams" /> class.
        /// </summary>
        /// <param name="shareTo">The ID of the user to whom the file will be shared..</param>
        /// <param name="email">The user email address..</param>
        /// <param name="access">access.</param>
        public FileShareParams(Guid shareTo = default, string email = default, FileShare? access = default)
        {
            this.ShareTo = shareTo;
            this.Email = email;
            this.Access = access;
        }

        /// <summary>
        /// The ID of the user to whom the file will be shared.
        /// </summary>
        /// <value>The ID of the user to whom the file will be shared.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "shareTo", EmitDefaultValue = false)]
        public Guid ShareTo { get; set; }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileShareParams {\n");
            sb.Append("  ShareTo: ").Append(ShareTo).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
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
