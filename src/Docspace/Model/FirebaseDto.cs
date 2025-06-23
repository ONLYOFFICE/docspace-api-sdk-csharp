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
    /// The Firebase parameters.
    /// </summary>
    [DataContract(Name = "FirebaseDto")]
    public partial class FirebaseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseDto" /> class.
        /// </summary>
        /// <param name="apiKey">The Firebase API key..</param>
        /// <param name="authDomain">The Firebase authentication domain..</param>
        /// <param name="projectId">The Firebase project ID..</param>
        /// <param name="storageBucket">The Firebase storage bucket..</param>
        /// <param name="messagingSenderId">The Firebase messaging sender ID..</param>
        /// <param name="appId">The Firebase application ID..</param>
        /// <param name="measurementId">The Firebase measurement ID..</param>
        /// <param name="databaseURL">The Firebase database URL..</param>
        public FirebaseDto(string apiKey = default, string authDomain = default, string projectId = default, string storageBucket = default, string messagingSenderId = default, string appId = default, string measurementId = default, string databaseURL = default)
        {
            this.ApiKey = apiKey;
            this.AuthDomain = authDomain;
            this.ProjectId = projectId;
            this.StorageBucket = storageBucket;
            this.MessagingSenderId = messagingSenderId;
            this.AppId = appId;
            this.MeasurementId = measurementId;
            this.DatabaseURL = databaseURL;
        }

        /// <summary>
        /// The Firebase API key.
        /// </summary>
        /// <value>The Firebase API key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "apiKey", EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// The Firebase authentication domain.
        /// </summary>
        /// <value>The Firebase authentication domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "authDomain", EmitDefaultValue = true)]
        public string AuthDomain { get; set; }

        /// <summary>
        /// The Firebase project ID.
        /// </summary>
        /// <value>The Firebase project ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "projectId", EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The Firebase storage bucket.
        /// </summary>
        /// <value>The Firebase storage bucket.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "storageBucket", EmitDefaultValue = true)]
        public string StorageBucket { get; set; }

        /// <summary>
        /// The Firebase messaging sender ID.
        /// </summary>
        /// <value>The Firebase messaging sender ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "messagingSenderId", EmitDefaultValue = true)]
        public string MessagingSenderId { get; set; }

        /// <summary>
        /// The Firebase application ID.
        /// </summary>
        /// <value>The Firebase application ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "appId", EmitDefaultValue = true)]
        public string AppId { get; set; }

        /// <summary>
        /// The Firebase measurement ID.
        /// </summary>
        /// <value>The Firebase measurement ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "measurementId", EmitDefaultValue = true)]
        public string MeasurementId { get; set; }

        /// <summary>
        /// The Firebase database URL.
        /// </summary>
        /// <value>The Firebase database URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "databaseURL", EmitDefaultValue = true)]
        public string DatabaseURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirebaseDto {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  AuthDomain: ").Append(AuthDomain).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  StorageBucket: ").Append(StorageBucket).Append("\n");
            sb.Append("  MessagingSenderId: ").Append(MessagingSenderId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  MeasurementId: ").Append(MeasurementId).Append("\n");
            sb.Append("  DatabaseURL: ").Append(DatabaseURL).Append("\n");
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
