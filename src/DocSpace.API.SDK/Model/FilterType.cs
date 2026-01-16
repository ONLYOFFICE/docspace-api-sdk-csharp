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
    /// [0 - None, 1 - Files  only, 2 - Folders only, 3 - Documents only, 4 - Presentations only, 5 - Spreadsheets only, 7 - Images only, 8 - By user, 9 - By department, 10 - Archive only, 11 - By extension, 12 - Media only, 13 - Filling forms rooms, 14 - Editing rooms, 17 - Custom rooms, 20 - Public rooms, 22 - Pdf, 23 - Pdf form, 24 - Virtual data rooms, 25 - Diagrams only, 26 - Ai rooms]
    /// </summary>
    /// <value>[0 - None, 1 - Files  only, 2 - Folders only, 3 - Documents only, 4 - Presentations only, 5 - Spreadsheets only, 7 - Images only, 8 - By user, 9 - By department, 10 - Archive only, 11 - By extension, 12 - Media only, 13 - Filling forms rooms, 14 - Editing rooms, 17 - Custom rooms, 20 - Public rooms, 22 - Pdf, 23 - Pdf form, 24 - Virtual data rooms, 25 - Diagrams only, 26 - Ai rooms]</value>
    public enum FilterType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum FilesOnly for value: 1
        /// </summary>
        FilesOnly = 1,

        /// <summary>
        /// Enum FoldersOnly for value: 2
        /// </summary>
        FoldersOnly = 2,

        /// <summary>
        /// Enum DocumentsOnly for value: 3
        /// </summary>
        DocumentsOnly = 3,

        /// <summary>
        /// Enum PresentationsOnly for value: 4
        /// </summary>
        PresentationsOnly = 4,

        /// <summary>
        /// Enum SpreadsheetsOnly for value: 5
        /// </summary>
        SpreadsheetsOnly = 5,

        /// <summary>
        /// Enum ImagesOnly for value: 7
        /// </summary>
        ImagesOnly = 7,

        /// <summary>
        /// Enum ByUser for value: 8
        /// </summary>
        ByUser = 8,

        /// <summary>
        /// Enum ByDepartment for value: 9
        /// </summary>
        ByDepartment = 9,

        /// <summary>
        /// Enum ArchiveOnly for value: 10
        /// </summary>
        ArchiveOnly = 10,

        /// <summary>
        /// Enum ByExtension for value: 11
        /// </summary>
        ByExtension = 11,

        /// <summary>
        /// Enum MediaOnly for value: 12
        /// </summary>
        MediaOnly = 12,

        /// <summary>
        /// Enum FillingFormsRooms for value: 13
        /// </summary>
        FillingFormsRooms = 13,

        /// <summary>
        /// Enum EditingRooms for value: 14
        /// </summary>
        EditingRooms = 14,

        /// <summary>
        /// Enum CustomRooms for value: 17
        /// </summary>
        CustomRooms = 17,

        /// <summary>
        /// Enum PublicRooms for value: 20
        /// </summary>
        PublicRooms = 20,

        /// <summary>
        /// Enum Pdf for value: 22
        /// </summary>
        Pdf = 22,

        /// <summary>
        /// Enum PdfForm for value: 23
        /// </summary>
        PdfForm = 23,

        /// <summary>
        /// Enum VirtualDataRooms for value: 24
        /// </summary>
        VirtualDataRooms = 24,

        /// <summary>
        /// Enum DiagramsOnly for value: 25
        /// </summary>
        DiagramsOnly = 25,

        /// <summary>
        /// Enum AiRooms for value: 26
        /// </summary>
        AiRooms = 26
    }

}
