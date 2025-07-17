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
    /// [0 - None, 1 - Box, 2 - DropBox, 3 - GoogleDrive, 4 - kDrive, 5 - OneDrive, 6 - SharePoint, 7 - WebDav, 8 - Yandex, 9 - Storage]
    /// </summary>
    /// <value>[0 - None, 1 - Box, 2 - DropBox, 3 - GoogleDrive, 4 - kDrive, 5 - OneDrive, 6 - SharePoint, 7 - WebDav, 8 - Yandex, 9 - Storage]</value>
    public enum ProviderFilter
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Box for value: 1
        /// </summary>
        Box = 1,

        /// <summary>
        /// Enum DropBox for value: 2
        /// </summary>
        DropBox = 2,

        /// <summary>
        /// Enum GoogleDrive for value: 3
        /// </summary>
        GoogleDrive = 3,

        /// <summary>
        /// Enum kDrive for value: 4
        /// </summary>
        kDrive = 4,

        /// <summary>
        /// Enum OneDrive for value: 5
        /// </summary>
        OneDrive = 5,

        /// <summary>
        /// Enum SharePoint for value: 6
        /// </summary>
        SharePoint = 6,

        /// <summary>
        /// Enum WebDav for value: 7
        /// </summary>
        WebDav = 7,

        /// <summary>
        /// Enum Yandex for value: 8
        /// </summary>
        Yandex = 8,

        /// <summary>
        /// Enum Storage for value: 9
        /// </summary>
        Storage = 9
    }

}
