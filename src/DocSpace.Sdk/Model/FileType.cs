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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [0 - Unknown, 1 - Archive, 2 - Video, 3 - Audio, 4 - Image, 5 - Spreadsheet, 6 - Presentation, 7 - Document, 10 - Pdf, 11 - Diagram]
    /// </summary>
    /// <value>[0 - Unknown, 1 - Archive, 2 - Video, 3 - Audio, 4 - Image, 5 - Spreadsheet, 6 - Presentation, 7 - Document, 10 - Pdf, 11 - Diagram]</value>
    public enum FileType
    {
        /// <summary>
        /// Enum Unknown for value: 0
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Enum Archive for value: 1
        /// </summary>
        Archive = 1,

        /// <summary>
        /// Enum Video for value: 2
        /// </summary>
        Video = 2,

        /// <summary>
        /// Enum Audio for value: 3
        /// </summary>
        Audio = 3,

        /// <summary>
        /// Enum Image for value: 4
        /// </summary>
        Image = 4,

        /// <summary>
        /// Enum Spreadsheet for value: 5
        /// </summary>
        Spreadsheet = 5,

        /// <summary>
        /// Enum Presentation for value: 6
        /// </summary>
        Presentation = 6,

        /// <summary>
        /// Enum Document for value: 7
        /// </summary>
        Document = 7,

        /// <summary>
        /// Enum Pdf for value: 10
        /// </summary>
        Pdf = 10,

        /// <summary>
        /// Enum Diagram for value: 11
        /// </summary>
        Diagram = 11
    }

}
