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
    /// The permissions configuration parameters.
    /// </summary>
    [DataContract(Name = "PermissionsConfig")]
    public partial class PermissionsConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsConfig" /> class.
        /// </summary>
        /// <param name="comment">Defines if the document can be commented or not..</param>
        /// <param name="chat">Defines if the chat functionality is enabled in the document or not..</param>
        /// <param name="download">Defines if the document can be downloaded or only viewed or edited online..</param>
        /// <param name="edit">Defines if the document can be edited or only viewed..</param>
        /// <param name="fillForms">Defines if the forms can be filled..</param>
        /// <param name="modifyFilter">Defines if the filter can be applied globally (true) affecting all the other users,  or locally (false), i.e. for the current user only..</param>
        /// <param name="protect">Defines if the Protection tab on the toolbar and the Protect button in the left menu are displayedor hidden..</param>
        /// <param name="print">Defines if the document can be printed or not..</param>
        /// <param name="review">Defines if the document can be reviewed or not..</param>
        /// <param name="copy">Defines if the content can be copied to the clipboard or not..</param>
        public PermissionsConfig(bool comment = default, bool chat = default, bool download = default, bool edit = default, bool fillForms = default, bool modifyFilter = default, bool protect = default, bool print = default, bool review = default, bool copy = default)
        {
            this.Comment = comment;
            this.Chat = chat;
            this.Download = download;
            this.Edit = edit;
            this.FillForms = fillForms;
            this.ModifyFilter = modifyFilter;
            this.Protect = protect;
            this.Print = print;
            this.Review = review;
            this.Copy = copy;
        }

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
        /// Defines if the Protection tab on the toolbar and the Protect button in the left menu are displayedor hidden.
        /// </summary>
        /// <value>Defines if the Protection tab on the toolbar and the Protect button in the left menu are displayedor hidden.</value>
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
            var sb = new StringBuilder();
            sb.Append("class PermissionsConfig {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  FillForms: ").Append(FillForms).Append("\n");
            sb.Append("  ModifyFilter: ").Append(ModifyFilter).Append("\n");
            sb.Append("  Protect: ").Append(Protect).Append("\n");
            sb.Append("  Print: ").Append(Print).Append("\n");
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
