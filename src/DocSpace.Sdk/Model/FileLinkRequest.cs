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
    /// The external link request parameters.
    /// </summary>
    [DataContract(Name = "FileLinkRequest")]
    public partial class FileLinkRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLinkRequest" /> class.
        /// </summary>
        /// <param name="linkId">The external link ID..</param>
        /// <param name="access">access.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="@internal">The link scope, whether it is internal or not..</param>
        /// <param name="primary">Specifies whether the file link is primary or not..</param>
        public FileLinkRequest(Guid linkId = default, FileShare? access = default, ApiDateTime expirationDate = default, bool @internal = default, bool primary = default)
        {
            this.LinkId = linkId;
            this.Access = access;
            this.ExpirationDate = expirationDate;
            this.Internal = @internal;
            this.Primary = primary;
        }

        /// <summary>
        /// The external link ID.
        /// </summary>
        /// <value>The external link ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// The link scope, whether it is internal or not.
        /// </summary>
        /// <value>The link scope, whether it is internal or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; set; }

        /// <summary>
        /// Specifies whether the file link is primary or not.
        /// </summary>
        /// <value>Specifies whether the file link is primary or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "primary", EmitDefaultValue = true)]
        public bool Primary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLinkRequest {\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
