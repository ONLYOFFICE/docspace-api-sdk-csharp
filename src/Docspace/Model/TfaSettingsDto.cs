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
    /// The parameters representing the Two-Factor Authentication (TFA) configuration settings.
    /// </summary>
    [DataContract(Name = "TfaSettingsDto")]
    public partial class TfaSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSettingsDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the TFA configuration..</param>
        /// <param name="title">The display name or description of the TFA configuration..</param>
        /// <param name="enabled">Indicates whether the TFA configuration is currently active..</param>
        /// <param name="avaliable">Indicates whether the TFA configuration can be used..</param>
        /// <param name="trustedIps">The list of IP addresses that are exempt from TFA requirements..</param>
        /// <param name="mandatoryUsers">The list of user IDs that are required to use TFA..</param>
        /// <param name="mandatoryGroups">The list of group IDs whose members are required to use TFA..</param>
        public TfaSettingsDto(string id = default, string title = default, bool enabled = default, bool avaliable = default, List<string> trustedIps = default, List<Guid> mandatoryUsers = default, List<Guid> mandatoryGroups = default)
        {
            this.Id = id;
            this.Title = title;
            this.Enabled = enabled;
            this.Avaliable = avaliable;
            this.TrustedIps = trustedIps;
            this.MandatoryUsers = mandatoryUsers;
            this.MandatoryGroups = mandatoryGroups;
        }

        /// <summary>
        /// The ID of the TFA configuration.
        /// </summary>
        /// <value>The ID of the TFA configuration.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The display name or description of the TFA configuration.
        /// </summary>
        /// <value>The display name or description of the TFA configuration.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Indicates whether the TFA configuration is currently active.
        /// </summary>
        /// <value>Indicates whether the TFA configuration is currently active.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether the TFA configuration can be used.
        /// </summary>
        /// <value>Indicates whether the TFA configuration can be used.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "avaliable", EmitDefaultValue = true)]
        public bool Avaliable { get; set; }

        /// <summary>
        /// The list of IP addresses that are exempt from TFA requirements.
        /// </summary>
        /// <value>The list of IP addresses that are exempt from TFA requirements.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "trustedIps", EmitDefaultValue = true)]
        public List<string> TrustedIps { get; set; }

        /// <summary>
        /// The list of user IDs that are required to use TFA.
        /// </summary>
        /// <value>The list of user IDs that are required to use TFA.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "mandatoryUsers", EmitDefaultValue = true)]
        public List<Guid> MandatoryUsers { get; set; }

        /// <summary>
        /// The list of group IDs whose members are required to use TFA.
        /// </summary>
        /// <value>The list of group IDs whose members are required to use TFA.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "mandatoryGroups", EmitDefaultValue = true)]
        public List<Guid> MandatoryGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TfaSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Avaliable: ").Append(Avaliable).Append("\n");
            sb.Append("  TrustedIps: ").Append(TrustedIps).Append("\n");
            sb.Append("  MandatoryUsers: ").Append(MandatoryUsers).Append("\n");
            sb.Append("  MandatoryGroups: ").Append(MandatoryGroups).Append("\n");
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
