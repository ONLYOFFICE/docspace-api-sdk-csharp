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
    /// [0 - *, 1 - user.created, 2 - user.invited, 4 - user.updated, 8 - user.deleted, 16 - group.created, 32 - group.updated, 64 - group.deleted, 128 - file.created, 256 - file.uploaded, 512 - file.updated, 1024 - file.trashed, 2048 - file.deleted, 4096 - file.restored, 8192 - file.copied, 16384 - file.moved, 32768 - folder.created, 65536 - folder.updated, 131072 - folder.trashed, 262144 - folder.deleted, 524288 - folder.restored, 1048576 - folder.copied, 2097152 - folder.moved, 4194304 - room.created, 8388608 - room.updated, 16777216 - room.archived, 33554432 - room.deleted, 67108864 - room.restored, 134217728 - room.copied, 268435456 - form.submit, 536870912 - form.filled.out, 1073741824 - form.stopped]
    /// </summary>
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
        RoomCopied = 134217728,

        /// <summary>
        /// Enum FormSubmit for value: 268435456
        /// </summary>
        FormSubmit = 268435456,

        /// <summary>
        /// Enum FormFilledOut for value: 536870912
        /// </summary>
        FormFilledOut = 536870912,

        /// <summary>
        /// Enum FormStopped for value: 1073741824
        /// </summary>
        FormStopped = 1073741824
    }

}
