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
    /// The customization config parameters.
    /// </summary>
    [DataContract(Name = "CustomizationConfigDto")]
    public partial class CustomizationConfigDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomizationConfigDto" /> class.
        /// </summary>
        /// <param name="about">Specifies if the customization is about..</param>
        /// <param name="customer">customer.</param>
        /// <param name="anonymous">anonymous.</param>
        /// <param name="feedback">feedback.</param>
        /// <param name="forcesave">Specifies if the customization should be force saved..</param>
        /// <param name="goback">goback.</param>
        /// <param name="logo">logo.</param>
        /// <param name="mentionShare">Specifies if the share should be mentioned..</param>
        /// <param name="reviewDisplay">The review display of the customization..</param>
        /// <param name="submitForm">submitForm.</param>
        /// <param name="startFillingForm">startFillingForm.</param>
        public CustomizationConfigDto(bool about = default, CustomerConfigDto customer = default, AnonymousConfigDto anonymous = default, FeedbackConfig feedback = default, bool? forcesave = default, GobackConfig goback = default, LogoConfigDto logo = default, bool mentionShare = default, string reviewDisplay = default, SubmitForm submitForm = default, StartFillingForm startFillingForm = default)
        {
            this.About = about;
            this.Customer = customer;
            this.Anonymous = anonymous;
            this.Feedback = feedback;
            this.Forcesave = forcesave;
            this.Goback = goback;
            this.Logo = logo;
            this.MentionShare = mentionShare;
            this.ReviewDisplay = reviewDisplay;
            this.SubmitForm = submitForm;
            this.StartFillingForm = startFillingForm;
        }

        /// <summary>
        /// Specifies if the customization is about.
        /// </summary>
        /// <value>Specifies if the customization is about.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "about", EmitDefaultValue = true)]
        public bool About { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CustomerConfigDto Customer { get; set; }

        /// <summary>
        /// Gets or Sets Anonymous
        /// </summary>
        [DataMember(Name = "anonymous", EmitDefaultValue = false)]
        public AnonymousConfigDto Anonymous { get; set; }

        /// <summary>
        /// Gets or Sets Feedback
        /// </summary>
        [DataMember(Name = "feedback", EmitDefaultValue = false)]
        public FeedbackConfig Feedback { get; set; }

        /// <summary>
        /// Specifies if the customization should be force saved.
        /// </summary>
        /// <value>Specifies if the customization should be force saved.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "forcesave", EmitDefaultValue = true)]
        public bool? Forcesave { get; set; }

        /// <summary>
        /// Gets or Sets Goback
        /// </summary>
        [DataMember(Name = "goback", EmitDefaultValue = false)]
        public GobackConfig Goback { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoConfigDto Logo { get; set; }

        /// <summary>
        /// Specifies if the share should be mentioned.
        /// </summary>
        /// <value>Specifies if the share should be mentioned.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "mentionShare", EmitDefaultValue = true)]
        public bool MentionShare { get; set; }

        /// <summary>
        /// The review display of the customization.
        /// </summary>
        /// <value>The review display of the customization.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "reviewDisplay", EmitDefaultValue = true)]
        public string ReviewDisplay { get; set; }

        /// <summary>
        /// Gets or Sets SubmitForm
        /// </summary>
        [DataMember(Name = "submitForm", EmitDefaultValue = false)]
        public SubmitForm SubmitForm { get; set; }

        /// <summary>
        /// Gets or Sets StartFillingForm
        /// </summary>
        [DataMember(Name = "startFillingForm", EmitDefaultValue = false)]
        public StartFillingForm StartFillingForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomizationConfigDto {\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Anonymous: ").Append(Anonymous).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Forcesave: ").Append(Forcesave).Append("\n");
            sb.Append("  Goback: ").Append(Goback).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  MentionShare: ").Append(MentionShare).Append("\n");
            sb.Append("  ReviewDisplay: ").Append(ReviewDisplay).Append("\n");
            sb.Append("  SubmitForm: ").Append(SubmitForm).Append("\n");
            sb.Append("  StartFillingForm: ").Append(StartFillingForm).Append("\n");
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
