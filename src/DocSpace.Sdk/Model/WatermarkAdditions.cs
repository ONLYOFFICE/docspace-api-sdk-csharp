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
    /// [1 - User name, 2 - User email, 4 - User ip adress, 8 - Current date, 16 - Room name]
    /// </summary>
    /// <value>[1 - User name, 2 - User email, 4 - User ip adress, 8 - Current date, 16 - Room name]</value>
    public enum WatermarkAdditions
    {
        /// <summary>
        /// Enum UserName for value: 1
        /// </summary>
        UserName = 1,

        /// <summary>
        /// Enum UserEmail for value: 2
        /// </summary>
        UserEmail = 2,

        /// <summary>
        /// Enum UserIpAdress for value: 4
        /// </summary>
        UserIpAdress = 4,

        /// <summary>
        /// Enum CurrentDate for value: 8
        /// </summary>
        CurrentDate = 8,

        /// <summary>
        /// Enum RoomName for value: 16
        /// </summary>
        RoomName = 16
    }

}
