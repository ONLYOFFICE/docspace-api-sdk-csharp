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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The request for updating client details.
    /// </summary>
    [DataContract(Name = "UpdateClientRequest")]
    public partial class UpdateClientRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientRequest" /> class.
        /// </summary>
        /// <param name="name">The client name..</param>
        /// <param name="description">The client description.</param>
        /// <param name="logo">The client logo in base64 format..</param>
        /// <param name="allowPkce">Indicates whether PKCE is allowed for the client..</param>
        /// <param name="isPublic">Indicates whether the client is accessible by third-party tenants..</param>
        /// <param name="allowedOrigins">The allowed origins for the client..</param>
        public UpdateClientRequest(string name = default, string description = default, string logo = default, bool allowPkce = default, bool isPublic = default, List<string> allowedOrigins = default)
        {
            this.Name = name;
            this.Description = description;
            this.Logo = logo;
            this.AllowPkce = allowPkce;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// The client name.
        /// </summary>
        /// <value>The client name.</value>
        /*
        <example>Updated Client</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The client description
        /// </summary>
        /// <value>The client description</value>
        /*
        <example>Updated description of the client</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The client logo in base64 format.
        /// </summary>
        /// <value>The client logo in base64 format.</value>
        /*
        <example>data:image/png;base64,...</example>
        */
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Indicates whether PKCE is allowed for the client.
        /// </summary>
        /// <value>Indicates whether PKCE is allowed for the client.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "allow_pkce", EmitDefaultValue = true)]
        public bool AllowPkce { get; set; }

        /// <summary>
        /// Indicates whether the client is accessible by third-party tenants.
        /// </summary>
        /// <value>Indicates whether the client is accessible by third-party tenants.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "is_public", EmitDefaultValue = true)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The allowed origins for the client.
        /// </summary>
        /// <value>The allowed origins for the client.</value>
        /*
        <example>[&quot;http://allowed.origin&quot;]</example>
        */
        [DataMember(Name = "allowed_origins", EmitDefaultValue = false)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateClientRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AllowPkce: ").Append(AllowPkce).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Logo (string) minLength
            if (this.Logo != null && this.Logo.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, length must be greater than 1.", new [] { "Logo" });
            }

            if (this.Logo != null) {
                // Logo (string) pattern
                Regex regexLogo = new Regex(@"^data:image\/(?:png|jpeg|jpg|svg\+xml);base64,.*.{1,}", RegexOptions.CultureInvariant);
                if (!regexLogo.Match(this.Logo).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, must match a pattern of " + regexLogo, new [] { "Logo" });
                }
            }

            yield break;
        }
    }


}
