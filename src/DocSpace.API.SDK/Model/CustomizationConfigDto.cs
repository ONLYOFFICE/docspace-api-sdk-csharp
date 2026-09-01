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
    /// The customization config parameters.
    /// </summary>
    [DataContract(Name = "CustomizationConfigDto")]
    public partial class CustomizationConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomizationConfigDto" /> class.
        /// </summary>
        /// <param name="about">Specifies if the customization is about..</param>
        /// <param name="customer">The customization customer configuration..</param>
        /// <param name="anonymous">The anonymous configuration of the customization..</param>
        /// <param name="feedback">The feedback configuration of the customization..</param>
        /// <param name="forcesave">Specifies if the customization should be force saved..</param>
        /// <param name="goback">The go back configuration of the customization..</param>
        /// <param name="review">The review configuration of the customization..</param>
        /// <param name="logo">The logo of the customization..</param>
        /// <param name="mentionShare">Specifies if the share should be mentioned..</param>
        /// <param name="submitForm">The Complete &amp; Submit button settings..</param>
        /// <param name="startFillingForm">The parameters of the button that starts filling out the form..</param>
        public CustomizationConfigDto(bool about = default, CustomerConfigDto customer = default, AnonymousConfigDto anonymous = default, FeedbackConfig feedback = default, bool? forcesave = default, GobackConfig goback = default, ReviewConfig review = default, LogoConfigDto logo = default, bool mentionShare = default, SubmitForm submitForm = default, StartFillingForm startFillingForm = default)
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
        }

        /// <summary>
        /// Specifies if the customization is about.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "about", EmitDefaultValue = true)]
        public bool About { get; set; }

        /// <summary>
        /// The customization customer configuration.
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CustomerConfigDto Customer { get; set; }

        /// <summary>
        /// The anonymous configuration of the customization.
        /// </summary>
        [DataMember(Name = "anonymous", EmitDefaultValue = false)]
        public AnonymousConfigDto Anonymous { get; set; }

        /// <summary>
        /// The feedback configuration of the customization.
        /// </summary>
        [DataMember(Name = "feedback", EmitDefaultValue = false)]
        public FeedbackConfig Feedback { get; set; }

        /// <summary>
        /// Specifies if the customization should be force saved.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "forcesave", EmitDefaultValue = true)]
        public bool? Forcesave { get; set; }

        /// <summary>
        /// The go back configuration of the customization.
        /// </summary>
        [DataMember(Name = "goback", EmitDefaultValue = false)]
        public GobackConfig Goback { get; set; }

        /// <summary>
        /// The review configuration of the customization.
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        public ReviewConfig Review { get; set; }

        /// <summary>
        /// The logo of the customization.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoConfigDto Logo { get; set; }

        /// <summary>
        /// Specifies if the share should be mentioned.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "mentionShare", EmitDefaultValue = true)]
        public bool MentionShare { get; set; }

        /// <summary>
        /// The Complete &amp; Submit button settings.
        /// </summary>
        [DataMember(Name = "submitForm", EmitDefaultValue = false)]
        public SubmitForm SubmitForm { get; set; }

        /// <summary>
        /// The parameters of the button that starts filling out the form.
        /// </summary>
        [DataMember(Name = "startFillingForm", EmitDefaultValue = false)]
        public StartFillingForm StartFillingForm { get; set; }

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
