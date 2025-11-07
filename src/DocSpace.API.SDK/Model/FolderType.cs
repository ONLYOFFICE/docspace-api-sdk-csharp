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
    /// [0 - Default, 1 - Coomon, 2 - Bunch, 3 - Trash, 5 - User, 6 - Share, 8 - Projects, 10 - Favourites, 11 - Recent, 12 - Templates, 13 - Privacy, 14 - Virtual rooms, 15 - Filling forms room, 16 - Editing room, 19 - Custom room, 20 - Archive, 21 - Thirdparty backup, 22 - Public room, 25 - Ready form folder, 26 - In process form folder, 27 - Form filling folder done, 28 - Form filling folder in progress, 29 - Virtual Data Room, 30 - Room templates folder, 31 - AI Room, 32 - Knowledge, 33 - Result storage, 34 - AI Agents]
    /// </summary>
    /// <value>[0 - Default, 1 - Coomon, 2 - Bunch, 3 - Trash, 5 - User, 6 - Share, 8 - Projects, 10 - Favourites, 11 - Recent, 12 - Templates, 13 - Privacy, 14 - Virtual rooms, 15 - Filling forms room, 16 - Editing room, 19 - Custom room, 20 - Archive, 21 - Thirdparty backup, 22 - Public room, 25 - Ready form folder, 26 - In process form folder, 27 - Form filling folder done, 28 - Form filling folder in progress, 29 - Virtual Data Room, 30 - Room templates folder, 31 - AI Room, 32 - Knowledge, 33 - Result storage, 34 - AI Agents]</value>
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
        RoomTemplates = 30,

        /// <summary>
        /// Enum AiRoom for value: 31
        /// </summary>
        AiRoom = 31,

        /// <summary>
        /// Enum Knowledge for value: 32
        /// </summary>
        Knowledge = 32,

        /// <summary>
        /// Enum ResultStorage for value: 33
        /// </summary>
        ResultStorage = 33,

        /// <summary>
        /// Enum AiAgents for value: 34
        /// </summary>
        AiAgents = 34
    }

}
