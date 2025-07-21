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
    /// The parameters for copying a file.
    /// </summary>
    [DataContract(Name = "CopyAsJsonElement")]
    public partial class CopyAsJsonElement : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyAsJsonElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyAsJsonElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyAsJsonElement" /> class.
        /// </summary>
        /// <param name="destTitle">The copied file name. (required).</param>
        /// <param name="destFolderId">destFolderId (required).</param>
        /// <param name="enableExternalExt">Specifies whether to allow creating the copied file of an external extension or not..</param>
        /// <param name="password">The copied file password..</param>
        /// <param name="toForm">Specifies whether to convert the file to form or not..</param>
        public CopyAsJsonElement(string destTitle = default, CopyAsJsonElementDestFolderId destFolderId = default, bool enableExternalExt = default, string password = default, bool toForm = default)
        {
            // to ensure "destTitle" is required (not null)
            if (destTitle == null)
            {
                throw new ArgumentNullException("destTitle is a required property for CopyAsJsonElement and cannot be null");
            }
            this.DestTitle = destTitle;
            // to ensure "destFolderId" is required (not null)
            if (destFolderId == null)
            {
                throw new ArgumentNullException("destFolderId is a required property for CopyAsJsonElement and cannot be null");
            }
            this.DestFolderId = destFolderId;
            this.EnableExternalExt = enableExternalExt;
            this.Password = password;
            this.ToForm = toForm;
        }

        /// <summary>
        /// The copied file name.
        /// </summary>
        /// <value>The copied file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "destTitle", IsRequired = true, EmitDefaultValue = true)]
        public string DestTitle { get; set; }

        /// <summary>
        /// Gets or Sets DestFolderId
        /// </summary>
        [DataMember(Name = "destFolderId", IsRequired = true, EmitDefaultValue = true)]
        public CopyAsJsonElementDestFolderId DestFolderId { get; set; }

        /// <summary>
        /// Specifies whether to allow creating the copied file of an external extension or not.
        /// </summary>
        /// <value>Specifies whether to allow creating the copied file of an external extension or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableExternalExt", EmitDefaultValue = true)]
        public bool EnableExternalExt { get; set; }

        /// <summary>
        /// The copied file password.
        /// </summary>
        /// <value>The copied file password.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to convert the file to form or not.
        /// </summary>
        /// <value>Specifies whether to convert the file to form or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "toForm", EmitDefaultValue = true)]
        public bool ToForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyAsJsonElement {\n");
            sb.Append("  DestTitle: ").Append(DestTitle).Append("\n");
            sb.Append("  DestFolderId: ").Append(DestFolderId).Append("\n");
            sb.Append("  EnableExternalExt: ").Append(EnableExternalExt).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ToForm: ").Append(ToForm).Append("\n");
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
