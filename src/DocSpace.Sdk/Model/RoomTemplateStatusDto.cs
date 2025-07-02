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
    /// The room template status.
    /// </summary>
    [DataContract(Name = "RoomTemplateStatusDto")]
    public partial class RoomTemplateStatusDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateStatusDto" /> class.
        /// </summary>
        /// <param name="templateId">The room template ID..</param>
        /// <param name="progress">The progress of the room template creation process..</param>
        /// <param name="error">The error message that is sent when the room template is not created successfully..</param>
        /// <param name="isCompleted">Specifies whether the process of creating the room template is completed..</param>
        public RoomTemplateStatusDto(int templateId = default, double progress = default, string error = default, bool isCompleted = default)
        {
            this.TemplateId = templateId;
            this.Progress = progress;
            this.Error = error;
            this.IsCompleted = isCompleted;
        }

        /// <summary>
        /// The room template ID.
        /// </summary>
        /// <value>The room template ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public int TemplateId { get; set; }

        /// <summary>
        /// The progress of the room template creation process.
        /// </summary>
        /// <value>The progress of the room template creation process.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public double Progress { get; set; }

        /// <summary>
        /// The error message that is sent when the room template is not created successfully.
        /// </summary>
        /// <value>The error message that is sent when the room template is not created successfully.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies whether the process of creating the room template is completed.
        /// </summary>
        /// <value>Specifies whether the process of creating the room template is completed.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoomTemplateStatusDto {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
