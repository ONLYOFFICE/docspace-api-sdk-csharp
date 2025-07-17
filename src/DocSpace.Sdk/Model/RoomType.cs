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
    /// [1 - Form filling room, 2 - Collaboration room, 5 - Custom room, 6 - Public room, 8 - Virtual data room]
    /// </summary>
    /// <value>[1 - Form filling room, 2 - Collaboration room, 5 - Custom room, 6 - Public room, 8 - Virtual data room]</value>
    public enum RoomType
    {
        /// <summary>
        /// Enum FillingFormsRoom for value: 1
        /// </summary>
        FillingFormsRoom = 1,

        /// <summary>
        /// Enum EditingRoom for value: 2
        /// </summary>
        EditingRoom = 2,

        /// <summary>
        /// Enum CustomRoom for value: 5
        /// </summary>
        CustomRoom = 5,

        /// <summary>
        /// Enum PublicRoom for value: 6
        /// </summary>
        PublicRoom = 6,

        /// <summary>
        /// Enum VirtualDataRoom for value: 8
        /// </summary>
        VirtualDataRoom = 8
    }

}
