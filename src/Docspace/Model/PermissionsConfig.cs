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
    /// The permissions configuration parameters.
    /// </summary>
    [DataContract(Name = "PermissionsConfig")]
    public partial class PermissionsConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsConfig" /> class.
        /// </summary>
        /// <param name="changeHistory">Specifies whether to display the \&quot;Restore\&quot; button when using the \&quot;onRequestRestore\&quot; event..</param>
        /// <param name="comment">Defines if the document can be commented or not..</param>
        /// <param name="chat">Defines if the chat functionality is enabled in the document or not..</param>
        /// <param name="download">Defines if the document can be downloaded or only viewed or edited online..</param>
        /// <param name="edit">Defines if the document can be edited or only viewed..</param>
        /// <param name="fillForms">Defines if the forms can be filled..</param>
        /// <param name="modifyFilter">Defines if the filter can be applied globally (true) affecting all the other users,  or locally (false), i.e. for the current user only..</param>
        /// <param name="protect">Defines if the \&quot;Protection\&quot; tab on the toolbar and the \&quot;Protect\&quot; button in the left menu are displayedor hidden..</param>
        /// <param name="print">Defines if the document can be printed or not..</param>
        /// <param name="rename">Specifies whether to display the \&quot;Rename...\&quot; button when using the \&quot;onRequestRename\&quot; event..</param>
        /// <param name="review">Defines if the document can be reviewed or not..</param>
        /// <param name="copy">Defines if the content can be copied to the clipboard or not..</param>
        public PermissionsConfig(bool changeHistory = default, bool comment = default, bool chat = default, bool download = default, bool edit = default, bool fillForms = default, bool modifyFilter = default, bool protect = default, bool print = default, bool rename = default, bool review = default, bool copy = default)
        {
            this.ChangeHistory = changeHistory;
            this.Comment = comment;
            this.Chat = chat;
            this.Download = download;
            this.Edit = edit;
            this.FillForms = fillForms;
            this.ModifyFilter = modifyFilter;
            this.Protect = protect;
            this.Print = print;
            this.Rename = rename;
            this.Review = review;
            this.Copy = copy;
        }

        /// <summary>
        /// Specifies whether to display the \&quot;Restore\&quot; button when using the \&quot;onRequestRestore\&quot; event.
        /// </summary>
        /// <value>Specifies whether to display the \&quot;Restore\&quot; button when using the \&quot;onRequestRestore\&quot; event.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "changeHistory", EmitDefaultValue = true)]
        public bool ChangeHistory { get; set; }

        /// <summary>
        /// Defines if the document can be commented or not.
        /// </summary>
        /// <value>Defines if the document can be commented or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public bool Comment { get; set; }

        /// <summary>
        /// Defines if the chat functionality is enabled in the document or not.
        /// </summary>
        /// <value>Defines if the chat functionality is enabled in the document or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "chat", EmitDefaultValue = true)]
        public bool Chat { get; set; }

        /// <summary>
        /// Defines if the document can be downloaded or only viewed or edited online.
        /// </summary>
        /// <value>Defines if the document can be downloaded or only viewed or edited online.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "download", EmitDefaultValue = true)]
        public bool Download { get; set; }

        /// <summary>
        /// Defines if the document can be edited or only viewed.
        /// </summary>
        /// <value>Defines if the document can be edited or only viewed.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "edit", EmitDefaultValue = true)]
        public bool Edit { get; set; }

        /// <summary>
        /// Defines if the forms can be filled.
        /// </summary>
        /// <value>Defines if the forms can be filled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "fillForms", EmitDefaultValue = true)]
        public bool FillForms { get; set; }

        /// <summary>
        /// Defines if the filter can be applied globally (true) affecting all the other users,  or locally (false), i.e. for the current user only.
        /// </summary>
        /// <value>Defines if the filter can be applied globally (true) affecting all the other users,  or locally (false), i.e. for the current user only.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "modifyFilter", EmitDefaultValue = true)]
        public bool ModifyFilter { get; set; }

        /// <summary>
        /// Defines if the \&quot;Protection\&quot; tab on the toolbar and the \&quot;Protect\&quot; button in the left menu are displayedor hidden.
        /// </summary>
        /// <value>Defines if the \&quot;Protection\&quot; tab on the toolbar and the \&quot;Protect\&quot; button in the left menu are displayedor hidden.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "protect", EmitDefaultValue = true)]
        public bool Protect { get; set; }

        /// <summary>
        /// Defines if the document can be printed or not.
        /// </summary>
        /// <value>Defines if the document can be printed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "print", EmitDefaultValue = true)]
        public bool Print { get; set; }

        /// <summary>
        /// Specifies whether to display the \&quot;Rename...\&quot; button when using the \&quot;onRequestRename\&quot; event.
        /// </summary>
        /// <value>Specifies whether to display the \&quot;Rename...\&quot; button when using the \&quot;onRequestRename\&quot; event.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "rename", EmitDefaultValue = true)]
        public bool Rename { get; set; }

        /// <summary>
        /// Defines if the document can be reviewed or not.
        /// </summary>
        /// <value>Defines if the document can be reviewed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "review", EmitDefaultValue = true)]
        public bool Review { get; set; }

        /// <summary>
        /// Defines if the content can be copied to the clipboard or not.
        /// </summary>
        /// <value>Defines if the content can be copied to the clipboard or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "copy", EmitDefaultValue = true)]
        public bool Copy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermissionsConfig {\n");
            sb.Append("  ChangeHistory: ").Append(ChangeHistory).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  FillForms: ").Append(FillForms).Append("\n");
            sb.Append("  ModifyFilter: ").Append(ModifyFilter).Append("\n");
            sb.Append("  Protect: ").Append(Protect).Append("\n");
            sb.Append("  Print: ").Append(Print).Append("\n");
            sb.Append("  Rename: ").Append(Rename).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  Copy: ").Append(Copy).Append("\n");
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
