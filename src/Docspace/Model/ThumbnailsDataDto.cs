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
    /// The thumbnails data parameters.
    /// </summary>
    [DataContract(Name = "ThumbnailsDataDto")]
    public partial class ThumbnailsDataDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailsDataDto" /> class.
        /// </summary>
        /// <param name="original">The thumbnail original photo..</param>
        /// <param name="retina">The thumbnail retina..</param>
        /// <param name="max">The thumbnail maximum size photo..</param>
        /// <param name="big">The thumbnail big size photo..</param>
        /// <param name="medium">The thumbnail medium size photo..</param>
        /// <param name="small">The thumbnail small size photo..</param>
        public ThumbnailsDataDto(string original = default, string retina = default, string max = default, string big = default, string medium = default, string small = default)
        {
            this.Original = original;
            this.Retina = retina;
            this.Max = max;
            this.Big = big;
            this.Medium = medium;
            this.Small = small;
        }

        /// <summary>
        /// The thumbnail original photo.
        /// </summary>
        /// <value>The thumbnail original photo.</value>
        /*
        <example>default_user_photo_size_1280-1280.png</example>
        */
        [DataMember(Name = "original", EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// The thumbnail retina.
        /// </summary>
        /// <value>The thumbnail retina.</value>
        /*
        <example>default_user_photo_size_360-360.png</example>
        */
        [DataMember(Name = "retina", EmitDefaultValue = true)]
        public string Retina { get; set; }

        /// <summary>
        /// The thumbnail maximum size photo.
        /// </summary>
        /// <value>The thumbnail maximum size photo.</value>
        /*
        <example>default_user_photo_size_200-200.png</example>
        */
        [DataMember(Name = "max", EmitDefaultValue = true)]
        public string Max { get; set; }

        /// <summary>
        /// The thumbnail big size photo.
        /// </summary>
        /// <value>The thumbnail big size photo.</value>
        /*
        <example>default_user_photo_size_82-82.png</example>
        */
        [DataMember(Name = "big", EmitDefaultValue = true)]
        public string Big { get; set; }

        /// <summary>
        /// The thumbnail medium size photo.
        /// </summary>
        /// <value>The thumbnail medium size photo.</value>
        /*
        <example>default_user_photo_size_48-48.png</example>
        */
        [DataMember(Name = "medium", EmitDefaultValue = true)]
        public string Medium { get; set; }

        /// <summary>
        /// The thumbnail small size photo.
        /// </summary>
        /// <value>The thumbnail small size photo.</value>
        /*
        <example>default_user_photo_size_32-32.png</example>
        */
        [DataMember(Name = "small", EmitDefaultValue = true)]
        public string Small { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThumbnailsDataDto {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Retina: ").Append(Retina).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Big: ").Append(Big).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
