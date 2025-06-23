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
    /// The configuration parameters for the embedded document type.
    /// </summary>
    [DataContract(Name = "EmbeddedConfig")]
    public partial class EmbeddedConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedConfig" /> class.
        /// </summary>
        /// <param name="shareLinkParam">The shared URL parameter..</param>
        public EmbeddedConfig(string shareLinkParam = default)
        {
            this.ShareLinkParam = shareLinkParam;
        }

        /// <summary>
        /// The absolute URL to the document serving as a source file for the document embedded into the web page.
        /// </summary>
        /// <value>The absolute URL to the document serving as a source file for the document embedded into the web page.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "embedUrl", EmitDefaultValue = true)]
        public string EmbedUrl { get; private set; }

        /// <summary>
        /// Returns false as EmbedUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmbedUrl()
        {
            return false;
        }
        /// <summary>
        /// The absolute URL that will allow the document to be saved onto the user personal computer.
        /// </summary>
        /// <value>The absolute URL that will allow the document to be saved onto the user personal computer.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "saveUrl", EmitDefaultValue = true)]
        public string SaveUrl { get; private set; }

        /// <summary>
        /// Returns false as SaveUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaveUrl()
        {
            return false;
        }
        /// <summary>
        /// The shared URL parameter.
        /// </summary>
        /// <value>The shared URL parameter.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shareLinkParam", EmitDefaultValue = true)]
        public string ShareLinkParam { get; set; }

        /// <summary>
        /// The absolute URL that will allow other users to share this document.
        /// </summary>
        /// <value>The absolute URL that will allow other users to share this document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shareUrl", EmitDefaultValue = true)]
        public string ShareUrl { get; private set; }

        /// <summary>
        /// Returns false as ShareUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShareUrl()
        {
            return false;
        }
        /// <summary>
        /// The place for the embedded viewer toolbar, can be either \&quot;top\&quot; or \&quot;bottom\&quot;.
        /// </summary>
        /// <value>The place for the embedded viewer toolbar, can be either \&quot;top\&quot; or \&quot;bottom\&quot;.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "toolbarDocked", EmitDefaultValue = true)]
        public string ToolbarDocked { get; private set; }

        /// <summary>
        /// Returns false as ToolbarDocked should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToolbarDocked()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedConfig {\n");
            sb.Append("  EmbedUrl: ").Append(EmbedUrl).Append("\n");
            sb.Append("  SaveUrl: ").Append(SaveUrl).Append("\n");
            sb.Append("  ShareLinkParam: ").Append(ShareLinkParam).Append("\n");
            sb.Append("  ShareUrl: ").Append(ShareUrl).Append("\n");
            sb.Append("  ToolbarDocked: ").Append(ToolbarDocked).Append("\n");
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
