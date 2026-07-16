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
    /// The parameters representing the Two-Factor Authentication (TFA) configuration settings.
    /// </summary>
    [DataContract(Name = "TfaSettingsDto")]
    public partial class TfaSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TfaSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSettingsDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the TFA configuration. (required).</param>
        /// <param name="title">The display name or description of the TFA configuration. (required).</param>
        /// <param name="enabled">Indicates whether the TFA configuration is currently active. (required).</param>
        /// <param name="available">Indicates whether the TFA configuration can be used. (required).</param>
        /// <param name="trustedIps">The list of IP addresses that are exempt from TFA requirements..</param>
        /// <param name="mandatoryUsers">The list of user IDs that are required to use TFA..</param>
        /// <param name="mandatoryGroups">The list of group IDs whose members are required to use TFA..</param>
        public TfaSettingsDto(string id = default, string title = default, bool enabled = default, bool available = default, List<string> trustedIps = default, List<Guid> mandatoryUsers = default, List<Guid> mandatoryGroups = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TfaSettingsDto and cannot be null");
            }
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for TfaSettingsDto and cannot be null");
            }
            this.Title = title;
            this.Enabled = enabled;
            this.Available = available;
            this.TrustedIps = trustedIps;
            this.MandatoryUsers = mandatoryUsers;
            this.MandatoryGroups = mandatoryGroups;
        }

        /// <summary>
        /// The ID of the TFA configuration.
        /// </summary>
        /// <value>The ID of the TFA configuration.</value>
        /*
        <example>tfa-default</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The display name or description of the TFA configuration.
        /// </summary>
        /// <value>The display name or description of the TFA configuration.</value>
        /*
        <example>Default TFA policy</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Indicates whether the TFA configuration is currently active.
        /// </summary>
        /// <value>Indicates whether the TFA configuration is currently active.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether the TFA configuration can be used.
        /// </summary>
        /// <value>Indicates whether the TFA configuration can be used.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// The list of IP addresses that are exempt from TFA requirements.
        /// </summary>
        /// <value>The list of IP addresses that are exempt from TFA requirements.</value>
        /*
        <example>["item1","item2"]</example>
        */
        [DataMember(Name = "trustedIps", EmitDefaultValue = true)]
        public List<string> TrustedIps { get; set; }

        /// <summary>
        /// The list of user IDs that are required to use TFA.
        /// </summary>
        /// <value>The list of user IDs that are required to use TFA.</value>
        /*
        <example>["00000000-0000-0000-0000-000000000000"]</example>
        */
        [DataMember(Name = "mandatoryUsers", EmitDefaultValue = true)]
        public List<Guid> MandatoryUsers { get; set; }

        /// <summary>
        /// The list of group IDs whose members are required to use TFA.
        /// </summary>
        /// <value>The list of group IDs whose members are required to use TFA.</value>
        /*
        <example>["00000000-0000-0000-0000-000000000000"]</example>
        */
        [DataMember(Name = "mandatoryGroups", EmitDefaultValue = true)]
        public List<Guid> MandatoryGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
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
