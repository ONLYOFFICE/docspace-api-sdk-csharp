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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The webhook configuration parameters.
    /// </summary>
    [DataContract(Name = "WebhooksConfigDto")]
    public partial class WebhooksConfigDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Triggers
        /// </summary>
        [DataMember(Name = "triggers", EmitDefaultValue = false)]
        public WebhookTrigger? Triggers { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksConfigDto" /> class.
        /// </summary>
        /// <param name="id">The webhook ID..</param>
        /// <param name="name">The webhook name..</param>
        /// <param name="uri">The webhook URI..</param>
        /// <param name="enabled">Specifies if the webhooks are enabled or not..</param>
        /// <param name="ssl">The webhook SSL verification (enabled or not)..</param>
        /// <param name="triggers">triggers.</param>
        /// <param name="targetId">The webhook target ID..</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">The date and time when the webhook was created..</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="modifiedOn">The date and time when the webhook was modified..</param>
        /// <param name="lastFailureOn">The date and time of the webhook last failure..</param>
        /// <param name="lastFailureContent">The webhook last failure content..</param>
        /// <param name="lastSuccessOn">The date and time of the webhook last success..</param>
        public WebhooksConfigDto(int id = default, string name = default, string uri = default, bool enabled = default, bool ssl = default, WebhookTrigger? triggers = default, string targetId = default, EmployeeDto createdBy = default, DateTime? createdOn = default, EmployeeDto modifiedBy = default, DateTime? modifiedOn = default, DateTime? lastFailureOn = default, string lastFailureContent = default, DateTime? lastSuccessOn = default)
        {
            this.Id = id;
            this.Name = name;
            this.Uri = uri;
            this.Enabled = enabled;
            this.Ssl = ssl;
            this.Triggers = triggers;
            this.TargetId = targetId;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.ModifiedBy = modifiedBy;
            this.ModifiedOn = modifiedOn;
            this.LastFailureOn = lastFailureOn;
            this.LastFailureContent = lastFailureContent;
            this.LastSuccessOn = lastSuccessOn;
        }

        /// <summary>
        /// The webhook ID.
        /// </summary>
        /// <value>The webhook ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The webhook name.
        /// </summary>
        /// <value>The webhook name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The webhook URI.
        /// </summary>
        /// <value>The webhook URI.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Specifies if the webhooks are enabled or not.
        /// </summary>
        /// <value>Specifies if the webhooks are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The webhook SSL verification (enabled or not).
        /// </summary>
        /// <value>The webhook SSL verification (enabled or not).</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// The webhook target ID.
        /// </summary>
        /// <value>The webhook target ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "targetId", EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// The date and time when the webhook was created.
        /// </summary>
        /// <value>The date and time when the webhook was created.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "createdOn", EmitDefaultValue = true)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public EmployeeDto ModifiedBy { get; set; }

        /// <summary>
        /// The date and time when the webhook was modified.
        /// </summary>
        /// <value>The date and time when the webhook was modified.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "modifiedOn", EmitDefaultValue = true)]
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// The date and time of the webhook last failure.
        /// </summary>
        /// <value>The date and time of the webhook last failure.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastFailureOn", EmitDefaultValue = true)]
        public DateTime? LastFailureOn { get; set; }

        /// <summary>
        /// The webhook last failure content.
        /// </summary>
        /// <value>The webhook last failure content.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "lastFailureContent", EmitDefaultValue = true)]
        public string LastFailureContent { get; set; }

        /// <summary>
        /// The date and time of the webhook last success.
        /// </summary>
        /// <value>The date and time of the webhook last success.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastSuccessOn", EmitDefaultValue = true)]
        public DateTime? LastSuccessOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksConfigDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  LastFailureOn: ").Append(LastFailureOn).Append("\n");
            sb.Append("  LastFailureContent: ").Append(LastFailureContent).Append("\n");
            sb.Append("  LastSuccessOn: ").Append(LastSuccessOn).Append("\n");
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
