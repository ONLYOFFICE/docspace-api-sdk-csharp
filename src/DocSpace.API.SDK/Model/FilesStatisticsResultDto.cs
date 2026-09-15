// (c) Copyright Ascensio System SIA 2026
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
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The space that stored documents take in each section of the portal, in bytes. The figures cover every account of  the portal rather than the caller alone, and a section the portal does not have comes back as null instead of a  zero figure.
    /// </summary>
    [DataContract(Name = "FilesStatisticsResultDto")]
    public partial class FilesStatisticsResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatisticsResultDto" /> class.
        /// </summary>
        /// <param name="myDocumentsUsedSpace">The space taken by the personal Files sections of all accounts of the portal added together. An item deleted  to the trash keeps taking space and is counted in &#x60;trashUsedSpace&#x60; until the trash is emptied..</param>
        /// <param name="trashUsedSpace">The space held by the items deleted to the trash from any section, which is given back only when the trash is  emptied or the items are erased for good..</param>
        /// <param name="archiveUsedSpace">The space taken by the content of the archived rooms, the archived form filling rooms included. Restoring a  room moves its space back to &#x60;roomsUsedSpace&#x60; or &#x60;formsUsedSpace&#x60;..</param>
        /// <param name="roomsUsedSpace">The space taken by the content of the active rooms, except the form filling rooms, whose content is reported  in &#x60;formsUsedSpace&#x60;. Archiving a room moves its space to &#x60;archiveUsedSpace&#x60;..</param>
        /// <param name="aiAgentsUsedSpace">The space taken by the content of the AI agents section, which exists only in a portal where the AI agents  feature is active; creating an AI room is not enough to bring the section into being..</param>
        /// <param name="formsUsedSpace">The space taken by the content of the active form filling rooms, which is kept apart from &#x60;roomsUsedSpace&#x60;  even though those rooms are listed among the rooms..</param>
        public FilesStatisticsResultDto(FilesStatisticsFolder myDocumentsUsedSpace = default, FilesStatisticsFolder trashUsedSpace = default, FilesStatisticsFolder archiveUsedSpace = default, FilesStatisticsFolder roomsUsedSpace = default, FilesStatisticsFolder aiAgentsUsedSpace = default, FilesStatisticsFolder formsUsedSpace = default)
        {
            this.MyDocumentsUsedSpace = myDocumentsUsedSpace;
            this.TrashUsedSpace = trashUsedSpace;
            this.ArchiveUsedSpace = archiveUsedSpace;
            this.RoomsUsedSpace = roomsUsedSpace;
            this.AiAgentsUsedSpace = aiAgentsUsedSpace;
            this.FormsUsedSpace = formsUsedSpace;
        }

        /// <summary>
        /// The space taken by the personal Files sections of all accounts of the portal added together. An item deleted  to the trash keeps taking space and is counted in &#x60;trashUsedSpace&#x60; until the trash is emptied.
        /// </summary>
        [DataMember(Name = "myDocumentsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder MyDocumentsUsedSpace { get; set; }

        /// <summary>
        /// The space held by the items deleted to the trash from any section, which is given back only when the trash is  emptied or the items are erased for good.
        /// </summary>
        [DataMember(Name = "trashUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder TrashUsedSpace { get; set; }

        /// <summary>
        /// The space taken by the content of the archived rooms, the archived form filling rooms included. Restoring a  room moves its space back to &#x60;roomsUsedSpace&#x60; or &#x60;formsUsedSpace&#x60;.
        /// </summary>
        [DataMember(Name = "archiveUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder ArchiveUsedSpace { get; set; }

        /// <summary>
        /// The space taken by the content of the active rooms, except the form filling rooms, whose content is reported  in &#x60;formsUsedSpace&#x60;. Archiving a room moves its space to &#x60;archiveUsedSpace&#x60;.
        /// </summary>
        [DataMember(Name = "roomsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder RoomsUsedSpace { get; set; }

        /// <summary>
        /// The space taken by the content of the AI agents section, which exists only in a portal where the AI agents  feature is active; creating an AI room is not enough to bring the section into being.
        /// </summary>
        [DataMember(Name = "aiAgentsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder AiAgentsUsedSpace { get; set; }

        /// <summary>
        /// The space taken by the content of the active form filling rooms, which is kept apart from &#x60;roomsUsedSpace&#x60;  even though those rooms are listed among the rooms.
        /// </summary>
        [DataMember(Name = "formsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder FormsUsedSpace { get; set; }

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
            sb.Append("  AiAgentsUsedSpace: ").Append(AiAgentsUsedSpace).Append("\n");
            sb.Append("  FormsUsedSpace: ").Append(FormsUsedSpace).Append("\n");
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
