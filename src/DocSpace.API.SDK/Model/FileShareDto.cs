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
    /// The file sharing information and access rights.
    /// </summary>
    [DataContract(Name = "FileShareDto")]
    public partial class FileShareDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Gets or Sets SubjectType
        /// </summary>
        [DataMember(Name = "subjectType", EmitDefaultValue = false)]
        public SubjectType? SubjectType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareDto" /> class.
        /// </summary>
        /// <param name="access">access.</param>
        /// <param name="sharedTo">The user who has the access to the specified file..</param>
        /// <param name="isLocked">Specifies if the access right is locked or not..</param>
        /// <param name="isOwner">Specifies if the user is an owner of the specified file or not..</param>
        /// <param name="canEditAccess">Specifies if the user can edit the access to the specified file or not..</param>
        /// <param name="canEditInternal">Indicates whether internal editing permissions are granted..</param>
        /// <param name="canEditDenyDownload">Determines whether the user has permission to modify the deny download setting for the file share..</param>
        /// <param name="canEditExpirationDate">Indicates whether the expiration date of access permissions can be edited..</param>
        /// <param name="subjectType">subjectType.</param>
        public FileShareDto(FileShare? access = default, Object sharedTo = default, bool isLocked = default, bool isOwner = default, bool canEditAccess = default, bool canEditInternal = default, bool canEditDenyDownload = default, bool canEditExpirationDate = default, SubjectType? subjectType = default)
        {
            this.Access = access;
            this.SharedTo = sharedTo;
            this.IsLocked = isLocked;
            this.IsOwner = isOwner;
            this.CanEditAccess = canEditAccess;
            this.CanEditInternal = canEditInternal;
            this.CanEditDenyDownload = canEditDenyDownload;
            this.CanEditExpirationDate = canEditExpirationDate;
            this.SubjectType = subjectType;
        }

        /// <summary>
        /// The user who has the access to the specified file.
        /// </summary>
        /// <value>The user who has the access to the specified file.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "sharedTo", EmitDefaultValue = true)]
        public Object SharedTo { get; set; }

        /// <summary>
        /// Specifies if the access right is locked or not.
        /// </summary>
        /// <value>Specifies if the access right is locked or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isLocked", EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Specifies if the user is an owner of the specified file or not.
        /// </summary>
        /// <value>Specifies if the user is an owner of the specified file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isOwner", EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Specifies if the user can edit the access to the specified file or not.
        /// </summary>
        /// <value>Specifies if the user can edit the access to the specified file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditAccess", EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Indicates whether internal editing permissions are granted.
        /// </summary>
        /// <value>Indicates whether internal editing permissions are granted.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditInternal", EmitDefaultValue = true)]
        public bool CanEditInternal { get; set; }

        /// <summary>
        /// Determines whether the user has permission to modify the deny download setting for the file share.
        /// </summary>
        /// <value>Determines whether the user has permission to modify the deny download setting for the file share.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditDenyDownload", EmitDefaultValue = true)]
        public bool CanEditDenyDownload { get; set; }

        /// <summary>
        /// Indicates whether the expiration date of access permissions can be edited.
        /// </summary>
        /// <value>Indicates whether the expiration date of access permissions can be edited.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditExpirationDate", EmitDefaultValue = true)]
        public bool CanEditExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileShareDto {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SharedTo: ").Append(SharedTo).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  CanEditAccess: ").Append(CanEditAccess).Append("\n");
            sb.Append("  CanEditInternal: ").Append(CanEditInternal).Append("\n");
            sb.Append("  CanEditDenyDownload: ").Append(CanEditDenyDownload).Append("\n");
            sb.Append("  CanEditExpirationDate: ").Append(CanEditExpirationDate).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
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
