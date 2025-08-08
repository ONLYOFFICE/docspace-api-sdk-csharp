// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The file accessibility.
    /// </summary>
    [DataContract(Name = "FileDtoInteger_allOf_viewAccessibility")]
    public partial class FileDtoIntegerAllOfViewAccessibility : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDtoIntegerAllOfViewAccessibility" /> class.
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
        public FileDtoIntegerAllOfViewAccessibility(bool imageView = default, bool mediaView = default, bool webView = default, bool webEdit = default, bool webReview = default, bool webCustomFilterEditing = default, bool webRestrictedEditing = default, bool webComment = default, bool coAuhtoring = default, bool canConvert = default, bool mustConvert = default)
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
            var sb = new StringBuilder();
            sb.Append("class FileDtoIntegerAllOfViewAccessibility {\n");
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
