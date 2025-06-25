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
    /// [0 - None, 1 - Files  only, 2 - Folders only, 3 - Documents only, 4 - Presentations only, 5 - Spreadsheets only, 7 - Images only, 8 - By user, 9 - By department, 10 - Archive only, 11 - By extension, 12 - Media only, 13 - Filling forms rooms, 14 - Editing rooms, 17 - Custom rooms, 20 - Public rooms, 22 - Pdf, 23 - Pdf form]
    /// </summary>
    /// <value>[0 - None, 1 - Files  only, 2 - Folders only, 3 - Documents only, 4 - Presentations only, 5 - Spreadsheets only, 7 - Images only, 8 - By user, 9 - By department, 10 - Archive only, 11 - By extension, 12 - Media only, 13 - Filling forms rooms, 14 - Editing rooms, 17 - Custom rooms, 20 - Public rooms, 22 - Pdf, 23 - Pdf form]</value>
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
        PdfForm = 23
    }

}
