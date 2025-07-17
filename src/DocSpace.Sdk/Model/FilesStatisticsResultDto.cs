/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The file statistics result parameters.
    /// </summary>
    [DataContract(Name = "FilesStatisticsResultDto")]
    public partial class FilesStatisticsResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatisticsResultDto" /> class.
        /// </summary>
        /// <param name="myDocumentsUsedSpace">myDocumentsUsedSpace.</param>
        /// <param name="trashUsedSpace">trashUsedSpace.</param>
        /// <param name="archiveUsedSpace">archiveUsedSpace.</param>
        /// <param name="roomsUsedSpace">roomsUsedSpace.</param>
        public FilesStatisticsResultDto(FilesStatisticsFolder myDocumentsUsedSpace = default, FilesStatisticsFolder trashUsedSpace = default, FilesStatisticsFolder archiveUsedSpace = default, FilesStatisticsFolder roomsUsedSpace = default)
        {
            this.MyDocumentsUsedSpace = myDocumentsUsedSpace;
            this.TrashUsedSpace = trashUsedSpace;
            this.ArchiveUsedSpace = archiveUsedSpace;
            this.RoomsUsedSpace = roomsUsedSpace;
        }

        /// <summary>
        /// Gets or Sets MyDocumentsUsedSpace
        /// </summary>
        [DataMember(Name = "myDocumentsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder MyDocumentsUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets TrashUsedSpace
        /// </summary>
        [DataMember(Name = "trashUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder TrashUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveUsedSpace
        /// </summary>
        [DataMember(Name = "archiveUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder ArchiveUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets RoomsUsedSpace
        /// </summary>
        [DataMember(Name = "roomsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder RoomsUsedSpace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesStatisticsResultDto {\n");
            sb.Append("  MyDocumentsUsedSpace: ").Append(MyDocumentsUsedSpace).Append("\n");
            sb.Append("  TrashUsedSpace: ").Append(TrashUsedSpace).Append("\n");
            sb.Append("  ArchiveUsedSpace: ").Append(ArchiveUsedSpace).Append("\n");
            sb.Append("  RoomsUsedSpace: ").Append(RoomsUsedSpace).Append("\n");
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
