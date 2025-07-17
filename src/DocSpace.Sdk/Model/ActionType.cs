/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
