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
    /// How the editor interface is dressed: branding, the buttons that lead back into the portal, and the behaviour of  review, mentions and form submission.
    /// </summary>
    [DataContract(Name = "CustomizationConfigDto")]
    public partial class CustomizationConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomizationConfigDto" /> class.
        /// </summary>
        /// <param name="about">Whether the About entry of the editor menu is shown..</param>
        /// <param name="customer">The branding of the organization running the portal. It is filled in on a server installation only and is  empty in the cloud..</param>
        /// <param name="anonymous">How an anonymous participant is treated in this session..</param>
        /// <param name="feedback">The support link the editor offers behind its feedback button..</param>
        /// <param name="forcesave">Whether the editors write intermediate revisions while the document stays open. It is empty when the portal  leaves the decision to the editors themselves..</param>
        /// <param name="goback">Where the editor returns the user to when they leave the document. It is empty when there is nowhere to go  back to, as in an embedded opening..</param>
        /// <param name="review">How tracked changes are displayed when the document opens; it depends on whether this session may write..</param>
        /// <param name="logo">The logo the editor shows, in the variants the current layout and file type need..</param>
        /// <param name="mentionShare">Whether mentioning a user who cannot yet open the document offers to share it with them, instead of silently  notifying nobody..</param>
        /// <param name="submitForm">The submit button of a form: whether it is shown and what it says..</param>
        /// <param name="startFillingForm">The button that starts filling out the form. It is empty when this opening offers no such button..</param>
        /// <param name="ai">The AI configuration settings..</param>
        public CustomizationConfigDto(bool about = default, CustomerConfigDto customer = default, AnonymousConfigDto anonymous = default, FeedbackConfig feedback = default, bool? forcesave = default, GobackConfig goback = default, ReviewConfig review = default, LogoConfigDto logo = default, bool mentionShare = default, SubmitForm submitForm = default, StartFillingForm startFillingForm = default, AIConfig ai = default)
        {
            this.About = about;
            this.Customer = customer;
            this.Anonymous = anonymous;
            this.Feedback = feedback;
            this.Forcesave = forcesave;
            this.Goback = goback;
            this.Review = review;
            this.Logo = logo;
            this.MentionShare = mentionShare;
            this.SubmitForm = submitForm;
            this.StartFillingForm = startFillingForm;
            this.Ai = ai;
        }

        /// <summary>
        /// Whether the About entry of the editor menu is shown.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "about", EmitDefaultValue = true)]
        public bool About { get; set; }

        /// <summary>
        /// The branding of the organization running the portal. It is filled in on a server installation only and is  empty in the cloud.
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CustomerConfigDto Customer { get; set; }

        /// <summary>
        /// How an anonymous participant is treated in this session.
        /// </summary>
        [DataMember(Name = "anonymous", EmitDefaultValue = false)]
        public AnonymousConfigDto Anonymous { get; set; }

        /// <summary>
        /// The support link the editor offers behind its feedback button.
        /// </summary>
        [DataMember(Name = "feedback", EmitDefaultValue = false)]
        public FeedbackConfig Feedback { get; set; }

        /// <summary>
        /// Whether the editors write intermediate revisions while the document stays open. It is empty when the portal  leaves the decision to the editors themselves.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "forcesave", EmitDefaultValue = true)]
        public bool? Forcesave { get; set; }

        /// <summary>
        /// Where the editor returns the user to when they leave the document. It is empty when there is nowhere to go  back to, as in an embedded opening.
        /// </summary>
        [DataMember(Name = "goback", EmitDefaultValue = false)]
        public GobackConfig Goback { get; set; }

        /// <summary>
        /// How tracked changes are displayed when the document opens; it depends on whether this session may write.
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        public ReviewConfig Review { get; set; }

        /// <summary>
        /// The logo the editor shows, in the variants the current layout and file type need.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoConfigDto Logo { get; set; }

        /// <summary>
        /// Whether mentioning a user who cannot yet open the document offers to share it with them, instead of silently  notifying nobody.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "mentionShare", EmitDefaultValue = true)]
        public bool MentionShare { get; set; }

        /// <summary>
        /// The submit button of a form: whether it is shown and what it says.
        /// </summary>
        [DataMember(Name = "submitForm", EmitDefaultValue = false)]
        public SubmitForm SubmitForm { get; set; }

        /// <summary>
        /// The button that starts filling out the form. It is empty when this opening offers no such button.
        /// </summary>
        [DataMember(Name = "startFillingForm", EmitDefaultValue = false)]
        public StartFillingForm StartFillingForm { get; set; }

        /// <summary>
        /// The AI configuration settings.
        /// </summary>
        [DataMember(Name = "ai", EmitDefaultValue = false)]
        public AIConfig Ai { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomizationConfigDto {\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Anonymous: ").Append(Anonymous).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Forcesave: ").Append(Forcesave).Append("\n");
            sb.Append("  Goback: ").Append(Goback).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  MentionShare: ").Append(MentionShare).Append("\n");
            sb.Append("  SubmitForm: ").Append(SubmitForm).Append("\n");
            sb.Append("  StartFillingForm: ").Append(StartFillingForm).Append("\n");
            sb.Append("  Ai: ").Append(Ai).Append("\n");
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
