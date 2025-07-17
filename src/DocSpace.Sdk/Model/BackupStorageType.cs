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
    /// [0 - Documents, 1 - Thridparty documents, 2 - Custom cloud, 3 - Local, 4 - Data store, 5 - Thirdparty consumer]
    /// </summary>
    /// <value>[0 - Documents, 1 - Thridparty documents, 2 - Custom cloud, 3 - Local, 4 - Data store, 5 - Thirdparty consumer]</value>
    public enum BackupStorageType
    {
        /// <summary>
        /// Enum Documents for value: 0
        /// </summary>
        Documents = 0,

        /// <summary>
        /// Enum ThridpartyDocuments for value: 1
        /// </summary>
        ThridpartyDocuments = 1,

        /// <summary>
        /// Enum CustomCloud for value: 2
        /// </summary>
        CustomCloud = 2,

        /// <summary>
        /// Enum Local for value: 3
        /// </summary>
        Local = 3,

        /// <summary>
        /// Enum DataStore for value: 4
        /// </summary>
        DataStore = 4,

        /// <summary>
        /// Enum ThirdPartyConsumer for value: 5
        /// </summary>
        ThirdPartyConsumer = 5
    }

}
