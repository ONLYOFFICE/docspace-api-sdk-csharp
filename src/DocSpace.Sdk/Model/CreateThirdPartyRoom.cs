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
    /// The parameters for creating a third-party room.
    /// </summary>
    [DataContract(Name = "CreateThirdPartyRoom")]
    public partial class CreateThirdPartyRoom : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RoomType
        /// </summary>
        [DataMember(Name = "roomType", IsRequired = true, EmitDefaultValue = true)]
        public RoomType RoomType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateThirdPartyRoom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        /// <param name="createAsNewFolder">Specifies whether to create a third-party room as a new folder or not..</param>
        /// <param name="title">The third-party room name to be created. (required).</param>
        /// <param name="roomType">roomType (required).</param>
        /// <param name="varPrivate">Specifies whether to create the private third-party room or not..</param>
        /// <param name="indexing">Specifies whether to create the third-party room with indexing..</param>
        /// <param name="denyDownload">Specifies whether to deny downloads from the third-party room..</param>
        /// <param name="color">The color of the third-party room..</param>
        /// <param name="cover">The cover of the third-party room..</param>
        /// <param name="tags">The list of tags of the third-party room..</param>
        /// <param name="logo">logo.</param>
        public CreateThirdPartyRoom(bool createAsNewFolder = default, string title = default, RoomType roomType = default, bool varPrivate = default, bool indexing = default, bool denyDownload = default, string color = default, string cover = default, List<string> tags = default, LogoRequest logo = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateThirdPartyRoom and cannot be null");
            }
            this.Title = title;
            this.RoomType = roomType;
            this.CreateAsNewFolder = createAsNewFolder;
            this.Private = varPrivate;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Color = color;
            this.Cover = cover;
            this.Tags = tags;
            this.Logo = logo;
        }

        /// <summary>
        /// Specifies whether to create a third-party room as a new folder or not.
        /// </summary>
        /// <value>Specifies whether to create a third-party room as a new folder or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createAsNewFolder", EmitDefaultValue = true)]
        public bool CreateAsNewFolder { get; set; }

        /// <summary>
        /// The third-party room name to be created.
        /// </summary>
        /// <value>The third-party room name to be created.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies whether to create the private third-party room or not.
        /// </summary>
        /// <value>Specifies whether to create the private third-party room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Specifies whether to create the third-party room with indexing.
        /// </summary>
        /// <value>Specifies whether to create the third-party room with indexing.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Specifies whether to deny downloads from the third-party room.
        /// </summary>
        /// <value>Specifies whether to deny downloads from the third-party room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The color of the third-party room.
        /// </summary>
        /// <value>The color of the third-party room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The cover of the third-party room.
        /// </summary>
        /// <value>The cover of the third-party room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// The list of tags of the third-party room.
        /// </summary>
        /// <value>The list of tags of the third-party room.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateThirdPartyRoom {\n");
            sb.Append("  CreateAsNewFolder: ").Append(CreateAsNewFolder).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
