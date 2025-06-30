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
    /// [0 - *, 1 - user.created, 2 - user.invited, 4 - user.updated, 8 - user.deleted, 16 - group.created, 32 - group.updated, 64 - group.deleted, 128 - file.created, 256 - file.uploaded, 512 - file.updated, 1024 - file.trashed, 2048 - file.deleted, 4096 - file.restored, 8192 - file.copied, 16384 - file.moved, 32768 - folder.created, 65536 - folder.updated, 131072 - folder.trashed, 262144 - folder.deleted, 524288 - folder.restored, 1048576 - folder.copied, 2097152 - folder.moved, 4194304 - room.created, 8388608 - room.updated, 16777216 - room.archived, 33554432 - room.deleted, 67108864 - room.restored, 134217728 - room.copied]
    /// </summary>
    /// <value>[0 - *, 1 - user.created, 2 - user.invited, 4 - user.updated, 8 - user.deleted, 16 - group.created, 32 - group.updated, 64 - group.deleted, 128 - file.created, 256 - file.uploaded, 512 - file.updated, 1024 - file.trashed, 2048 - file.deleted, 4096 - file.restored, 8192 - file.copied, 16384 - file.moved, 32768 - folder.created, 65536 - folder.updated, 131072 - folder.trashed, 262144 - folder.deleted, 524288 - folder.restored, 1048576 - folder.copied, 2097152 - folder.moved, 4194304 - room.created, 8388608 - room.updated, 16777216 - room.archived, 33554432 - room.deleted, 67108864 - room.restored, 134217728 - room.copied]</value>
    public enum WebhookTrigger
    {
        /// <summary>
        /// Enum All for value: 0
        /// </summary>
        All = 0,

        /// <summary>
        /// Enum UserCreated for value: 1
        /// </summary>
        UserCreated = 1,

        /// <summary>
        /// Enum UserInvited for value: 2
        /// </summary>
        UserInvited = 2,

        /// <summary>
        /// Enum UserUpdated for value: 4
        /// </summary>
        UserUpdated = 4,

        /// <summary>
        /// Enum UserDeleted for value: 8
        /// </summary>
        UserDeleted = 8,

        /// <summary>
        /// Enum GroupCreated for value: 16
        /// </summary>
        GroupCreated = 16,

        /// <summary>
        /// Enum GroupUpdated for value: 32
        /// </summary>
        GroupUpdated = 32,

        /// <summary>
        /// Enum GroupDeleted for value: 64
        /// </summary>
        GroupDeleted = 64,

        /// <summary>
        /// Enum FileCreated for value: 128
        /// </summary>
        FileCreated = 128,

        /// <summary>
        /// Enum FileUploaded for value: 256
        /// </summary>
        FileUploaded = 256,

        /// <summary>
        /// Enum FileUpdated for value: 512
        /// </summary>
        FileUpdated = 512,

        /// <summary>
        /// Enum FileTrashed for value: 1024
        /// </summary>
        FileTrashed = 1024,

        /// <summary>
        /// Enum FileDeleted for value: 2048
        /// </summary>
        FileDeleted = 2048,

        /// <summary>
        /// Enum FileRestored for value: 4096
        /// </summary>
        FileRestored = 4096,

        /// <summary>
        /// Enum FileCopied for value: 8192
        /// </summary>
        FileCopied = 8192,

        /// <summary>
        /// Enum FileMoved for value: 16384
        /// </summary>
        FileMoved = 16384,

        /// <summary>
        /// Enum FolderCreated for value: 32768
        /// </summary>
        FolderCreated = 32768,

        /// <summary>
        /// Enum FolderUpdated for value: 65536
        /// </summary>
        FolderUpdated = 65536,

        /// <summary>
        /// Enum FolderTrashed for value: 131072
        /// </summary>
        FolderTrashed = 131072,

        /// <summary>
        /// Enum FolderDeleted for value: 262144
        /// </summary>
        FolderDeleted = 262144,

        /// <summary>
        /// Enum FolderRestored for value: 524288
        /// </summary>
        FolderRestored = 524288,

        /// <summary>
        /// Enum FolderCopied for value: 1048576
        /// </summary>
        FolderCopied = 1048576,

        /// <summary>
        /// Enum FolderMoved for value: 2097152
        /// </summary>
        FolderMoved = 2097152,

        /// <summary>
        /// Enum RoomCreated for value: 4194304
        /// </summary>
        RoomCreated = 4194304,

        /// <summary>
        /// Enum RoomUpdated for value: 8388608
        /// </summary>
        RoomUpdated = 8388608,

        /// <summary>
        /// Enum RoomArchived for value: 16777216
        /// </summary>
        RoomArchived = 16777216,

        /// <summary>
        /// Enum RoomDeleted for value: 33554432
        /// </summary>
        RoomDeleted = 33554432,

        /// <summary>
        /// Enum RoomRestored for value: 67108864
        /// </summary>
        RoomRestored = 67108864,

        /// <summary>
        /// Enum RoomCopied for value: 134217728
        /// </summary>
        RoomCopied = 134217728
    }

}
