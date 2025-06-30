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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// [0 - None, 1 - Create, 2 - Update, 3 - Delete, 4 - Link, 5 - Unlink, 6 - Attach, 7 - Detach, 8 - Send, 9 - Import, 10 - Export, 11 - Update access, 12 - Download, 13 - Upload, 14 - Copy, 15 - Move, 16 - Reassigns, 17 - Follow, 18 - Unfollow, 19 - Logout]
    /// </summary>
    /// <value>[0 - None, 1 - Create, 2 - Update, 3 - Delete, 4 - Link, 5 - Unlink, 6 - Attach, 7 - Detach, 8 - Send, 9 - Import, 10 - Export, 11 - Update access, 12 - Download, 13 - Upload, 14 - Copy, 15 - Move, 16 - Reassigns, 17 - Follow, 18 - Unfollow, 19 - Logout]</value>
    public enum ActionType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Create for value: 1
        /// </summary>
        Create = 1,

        /// <summary>
        /// Enum Update for value: 2
        /// </summary>
        Update = 2,

        /// <summary>
        /// Enum Delete for value: 3
        /// </summary>
        Delete = 3,

        /// <summary>
        /// Enum Link for value: 4
        /// </summary>
        Link = 4,

        /// <summary>
        /// Enum Unlink for value: 5
        /// </summary>
        Unlink = 5,

        /// <summary>
        /// Enum Attach for value: 6
        /// </summary>
        Attach = 6,

        /// <summary>
        /// Enum Detach for value: 7
        /// </summary>
        Detach = 7,

        /// <summary>
        /// Enum Send for value: 8
        /// </summary>
        Send = 8,

        /// <summary>
        /// Enum Import for value: 9
        /// </summary>
        Import = 9,

        /// <summary>
        /// Enum Export for value: 10
        /// </summary>
        Export = 10,

        /// <summary>
        /// Enum UpdateAccess for value: 11
        /// </summary>
        UpdateAccess = 11,

        /// <summary>
        /// Enum Download for value: 12
        /// </summary>
        Download = 12,

        /// <summary>
        /// Enum Upload for value: 13
        /// </summary>
        Upload = 13,

        /// <summary>
        /// Enum Copy for value: 14
        /// </summary>
        Copy = 14,

        /// <summary>
        /// Enum Move for value: 15
        /// </summary>
        Move = 15,

        /// <summary>
        /// Enum Reassigns for value: 16
        /// </summary>
        Reassigns = 16,

        /// <summary>
        /// Enum Follow for value: 17
        /// </summary>
        Follow = 17,

        /// <summary>
        /// Enum Unfollow for value: 18
        /// </summary>
        Unfollow = 18,

        /// <summary>
        /// Enum Logout for value: 19
        /// </summary>
        Logout = 19
    }

}
