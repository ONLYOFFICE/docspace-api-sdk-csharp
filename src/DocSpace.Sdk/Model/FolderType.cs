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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [0 - Default, 1 - Coomon, 2 - Bunch, 3 - Trash, 5 - User, 6 - Share, 8 - Projects, 10 - Favourites, 11 - Recent, 12 - Templates, 13 - Privacy, 14 - Virtual rooms, 15 - Filling forms room, 16 - Editing room, 19 - Custom room, 20 - Archive, 21 - Thirdparty backup, 22 - Public room, 25 - Ready form folder, 26 - In process form folder, 27 - Form filling folder done, 28 - Form filling folder in progress, 29 - Virtual Data Room, 30 - Room templates folder]
    /// </summary>
    /// <value>[0 - Default, 1 - Coomon, 2 - Bunch, 3 - Trash, 5 - User, 6 - Share, 8 - Projects, 10 - Favourites, 11 - Recent, 12 - Templates, 13 - Privacy, 14 - Virtual rooms, 15 - Filling forms room, 16 - Editing room, 19 - Custom room, 20 - Archive, 21 - Thirdparty backup, 22 - Public room, 25 - Ready form folder, 26 - In process form folder, 27 - Form filling folder done, 28 - Form filling folder in progress, 29 - Virtual Data Room, 30 - Room templates folder]</value>
    public enum FolderType
    {
        /// <summary>
        /// Enum DEFAULT for value: 0
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// Enum COMMON for value: 1
        /// </summary>
        COMMON = 1,

        /// <summary>
        /// Enum BUNCH for value: 2
        /// </summary>
        BUNCH = 2,

        /// <summary>
        /// Enum TRASH for value: 3
        /// </summary>
        TRASH = 3,

        /// <summary>
        /// Enum USER for value: 5
        /// </summary>
        USER = 5,

        /// <summary>
        /// Enum SHARE for value: 6
        /// </summary>
        SHARE = 6,

        /// <summary>
        /// Enum Projects for value: 8
        /// </summary>
        Projects = 8,

        /// <summary>
        /// Enum Favorites for value: 10
        /// </summary>
        Favorites = 10,

        /// <summary>
        /// Enum Recent for value: 11
        /// </summary>
        Recent = 11,

        /// <summary>
        /// Enum Templates for value: 12
        /// </summary>
        Templates = 12,

        /// <summary>
        /// Enum Privacy for value: 13
        /// </summary>
        Privacy = 13,

        /// <summary>
        /// Enum VirtualRooms for value: 14
        /// </summary>
        VirtualRooms = 14,

        /// <summary>
        /// Enum FillingFormsRoom for value: 15
        /// </summary>
        FillingFormsRoom = 15,

        /// <summary>
        /// Enum EditingRoom for value: 16
        /// </summary>
        EditingRoom = 16,

        /// <summary>
        /// Enum CustomRoom for value: 19
        /// </summary>
        CustomRoom = 19,

        /// <summary>
        /// Enum Archive for value: 20
        /// </summary>
        Archive = 20,

        /// <summary>
        /// Enum ThirdpartyBackup for value: 21
        /// </summary>
        ThirdpartyBackup = 21,

        /// <summary>
        /// Enum PublicRoom for value: 22
        /// </summary>
        PublicRoom = 22,

        /// <summary>
        /// Enum ReadyFormFolder for value: 25
        /// </summary>
        ReadyFormFolder = 25,

        /// <summary>
        /// Enum InProcessFormFolder for value: 26
        /// </summary>
        InProcessFormFolder = 26,

        /// <summary>
        /// Enum FormFillingFolderDone for value: 27
        /// </summary>
        FormFillingFolderDone = 27,

        /// <summary>
        /// Enum FormFillingFolderInProgress for value: 28
        /// </summary>
        FormFillingFolderInProgress = 28,

        /// <summary>
        /// Enum VirtualDataRoom for value: 29
        /// </summary>
        VirtualDataRoom = 29,

        /// <summary>
        /// Enum RoomTemplates for value: 30
        /// </summary>
        RoomTemplates = 30
    }

}
