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
    /// ContentDisposition
    /// </summary>
    [DataContract(Name = "ContentDisposition")]
    public partial class ContentDisposition : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentDisposition" /> class.
        /// </summary>
        /// <param name="dispositionType">dispositionType.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="modificationDate">modificationDate.</param>
        /// <param name="inline">inline.</param>
        /// <param name="readDate">readDate.</param>
        /// <param name="size">size.</param>
        public ContentDisposition(string dispositionType = default, string fileName = default, DateTime creationDate = default, DateTime modificationDate = default, bool inline = default, DateTime readDate = default, long size = default)
        {
            this.DispositionType = dispositionType;
            this.FileName = fileName;
            this.CreationDate = creationDate;
            this.ModificationDate = modificationDate;
            this.Inline = inline;
            this.ReadDate = readDate;
            this.Size = size;
        }

        /// <summary>
        /// Gets or Sets DispositionType
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "dispositionType", EmitDefaultValue = true)]
        public string DispositionType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public List<Object> Parameters { get; private set; }

        /// <summary>
        /// Returns false as Parameters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParameters()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileName", EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "modificationDate", EmitDefaultValue = false)]
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Gets or Sets Inline
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "inline", EmitDefaultValue = true)]
        public bool Inline { get; set; }

        /// <summary>
        /// Gets or Sets ReadDate
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "readDate", EmitDefaultValue = false)]
        public DateTime ReadDate { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentDisposition {\n");
            sb.Append("  DispositionType: ").Append(DispositionType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  Inline: ").Append(Inline).Append("\n");
            sb.Append("  ReadDate: ").Append(ReadDate).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
