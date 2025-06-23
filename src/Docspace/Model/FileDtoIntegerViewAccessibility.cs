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
    /// The file accessibility.
    /// </summary>
    [DataContract(Name = "FileDtoInteger_viewAccessibility")]
    public partial class FileDtoIntegerViewAccessibility : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDtoIntegerViewAccessibility" /> class.
        /// </summary>
        /// <param name="imageView">imageView.</param>
        /// <param name="mediaView">mediaView.</param>
        /// <param name="webView">webView.</param>
        /// <param name="webEdit">webEdit.</param>
        /// <param name="webReview">webReview.</param>
        /// <param name="webCustomFilterEditing">webCustomFilterEditing.</param>
        /// <param name="webRestrictedEditing">webRestrictedEditing.</param>
        /// <param name="webComment">webComment.</param>
        /// <param name="coAuhtoring">coAuhtoring.</param>
        /// <param name="canConvert">canConvert.</param>
        /// <param name="mustConvert">mustConvert.</param>
        public FileDtoIntegerViewAccessibility(bool imageView = default, bool mediaView = default, bool webView = default, bool webEdit = default, bool webReview = default, bool webCustomFilterEditing = default, bool webRestrictedEditing = default, bool webComment = default, bool coAuhtoring = default, bool canConvert = default, bool mustConvert = default)
        {
            this.ImageView = imageView;
            this.MediaView = mediaView;
            this.WebView = webView;
            this.WebEdit = webEdit;
            this.WebReview = webReview;
            this.WebCustomFilterEditing = webCustomFilterEditing;
            this.WebRestrictedEditing = webRestrictedEditing;
            this.WebComment = webComment;
            this.CoAuhtoring = coAuhtoring;
            this.CanConvert = canConvert;
            this.MustConvert = mustConvert;
        }

        /// <summary>
        /// Gets or Sets ImageView
        /// </summary>
        [DataMember(Name = "ImageView", EmitDefaultValue = true)]
        public bool ImageView { get; set; }

        /// <summary>
        /// Gets or Sets MediaView
        /// </summary>
        [DataMember(Name = "MediaView", EmitDefaultValue = true)]
        public bool MediaView { get; set; }

        /// <summary>
        /// Gets or Sets WebView
        /// </summary>
        [DataMember(Name = "WebView", EmitDefaultValue = true)]
        public bool WebView { get; set; }

        /// <summary>
        /// Gets or Sets WebEdit
        /// </summary>
        [DataMember(Name = "WebEdit", EmitDefaultValue = true)]
        public bool WebEdit { get; set; }

        /// <summary>
        /// Gets or Sets WebReview
        /// </summary>
        [DataMember(Name = "WebReview", EmitDefaultValue = true)]
        public bool WebReview { get; set; }

        /// <summary>
        /// Gets or Sets WebCustomFilterEditing
        /// </summary>
        [DataMember(Name = "WebCustomFilterEditing", EmitDefaultValue = true)]
        public bool WebCustomFilterEditing { get; set; }

        /// <summary>
        /// Gets or Sets WebRestrictedEditing
        /// </summary>
        [DataMember(Name = "WebRestrictedEditing", EmitDefaultValue = true)]
        public bool WebRestrictedEditing { get; set; }

        /// <summary>
        /// Gets or Sets WebComment
        /// </summary>
        [DataMember(Name = "WebComment", EmitDefaultValue = true)]
        public bool WebComment { get; set; }

        /// <summary>
        /// Gets or Sets CoAuhtoring
        /// </summary>
        [DataMember(Name = "CoAuhtoring", EmitDefaultValue = true)]
        public bool CoAuhtoring { get; set; }

        /// <summary>
        /// Gets or Sets CanConvert
        /// </summary>
        [DataMember(Name = "CanConvert", EmitDefaultValue = true)]
        public bool CanConvert { get; set; }

        /// <summary>
        /// Gets or Sets MustConvert
        /// </summary>
        [DataMember(Name = "MustConvert", EmitDefaultValue = true)]
        public bool MustConvert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileDtoIntegerViewAccessibility {\n");
            sb.Append("  ImageView: ").Append(ImageView).Append("\n");
            sb.Append("  MediaView: ").Append(MediaView).Append("\n");
            sb.Append("  WebView: ").Append(WebView).Append("\n");
            sb.Append("  WebEdit: ").Append(WebEdit).Append("\n");
            sb.Append("  WebReview: ").Append(WebReview).Append("\n");
            sb.Append("  WebCustomFilterEditing: ").Append(WebCustomFilterEditing).Append("\n");
            sb.Append("  WebRestrictedEditing: ").Append(WebRestrictedEditing).Append("\n");
            sb.Append("  WebComment: ").Append(WebComment).Append("\n");
            sb.Append("  CoAuhtoring: ").Append(CoAuhtoring).Append("\n");
            sb.Append("  CanConvert: ").Append(CanConvert).Append("\n");
            sb.Append("  MustConvert: ").Append(MustConvert).Append("\n");
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
