// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The request parameters for creating a new API key.
    /// </summary>
    [DataContract(Name = "CreateApiKeyRequestDto")]
    public partial class CreateApiKeyRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApiKeyRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequestDto" /> class.
        /// </summary>
        /// <param name="name">The API key name. (required).</param>
        /// <param name="permissions">The list of permissions granted to the API key..</param>
        /// <param name="expiresInDays">The number of days until the API key expires (null for no expiration)..</param>
        public CreateApiKeyRequestDto(string name = default, List<string> permissions = default, int? expiresInDays = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateApiKeyRequestDto and cannot be null");
            }
            this.Name = name;
            this.Permissions = permissions;
            this.ExpiresInDays = expiresInDays;
        }

        /// <summary>
        /// The API key name.
        /// </summary>
        /// <value>The API key name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The list of permissions granted to the API key.
        /// </summary>
        /// <value>The list of permissions granted to the API key.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The number of days until the API key expires (null for no expiration).
        /// </summary>
        /// <value>The number of days until the API key expires (null for no expiration).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "expiresInDays", EmitDefaultValue = true)]
        public int? ExpiresInDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateApiKeyRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ExpiresInDays: ").Append(ExpiresInDays).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 30.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // ExpiresInDays (int?) maximum
            if (this.ExpiresInDays > (int?)365)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresInDays, must be a value less than or equal to 365.", new [] { "ExpiresInDays" });
            }

            // ExpiresInDays (int?) minimum
            if (this.ExpiresInDays < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresInDays, must be a value greater than or equal to 1.", new [] { "ExpiresInDays" });
            }

            yield break;
        }
    }


}
