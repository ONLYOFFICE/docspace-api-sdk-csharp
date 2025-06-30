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
    /// [0 - Date and time, 1 - AZ, 2 - Size, 3 - Author, 4 - Type, 5 - New, 6 - Date and time creation, 7 - Room type, 8 - Tags, 9 - Room, 10 - Custom order, 11 - Last opened, 12 - Used space]
    /// </summary>
    /// <value>[0 - Date and time, 1 - AZ, 2 - Size, 3 - Author, 4 - Type, 5 - New, 6 - Date and time creation, 7 - Room type, 8 - Tags, 9 - Room, 10 - Custom order, 11 - Last opened, 12 - Used space]</value>
    public enum SortedByType
    {
        /// <summary>
        /// Enum DateAndTime for value: 0
        /// </summary>
        DateAndTime = 0,

        /// <summary>
        /// Enum AZ for value: 1
        /// </summary>
        AZ = 1,

        /// <summary>
        /// Enum Size for value: 2
        /// </summary>
        Size = 2,

        /// <summary>
        /// Enum Author for value: 3
        /// </summary>
        Author = 3,

        /// <summary>
        /// Enum Type for value: 4
        /// </summary>
        Type = 4,

        /// <summary>
        /// Enum New for value: 5
        /// </summary>
        New = 5,

        /// <summary>
        /// Enum DateAndTimeCreation for value: 6
        /// </summary>
        DateAndTimeCreation = 6,

        /// <summary>
        /// Enum RoomType for value: 7
        /// </summary>
        RoomType = 7,

        /// <summary>
        /// Enum Tags for value: 8
        /// </summary>
        Tags = 8,

        /// <summary>
        /// Enum Room for value: 9
        /// </summary>
        Room = 9,

        /// <summary>
        /// Enum CustomOrder for value: 10
        /// </summary>
        CustomOrder = 10,

        /// <summary>
        /// Enum LastOpened for value: 11
        /// </summary>
        LastOpened = 11,

        /// <summary>
        /// Enum UsedSpace for value: 12
        /// </summary>
        UsedSpace = 12
    }

}
