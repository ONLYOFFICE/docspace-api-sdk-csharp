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
    /// Defines LoginProvider
    /// </summary>
    public enum LoginProvider
    {
        /// <summary>
        /// Enum Facebook for value: 0
        /// </summary>
        Facebook = 0,

        /// <summary>
        /// Enum Google for value: 1
        /// </summary>
        Google = 1,

        /// <summary>
        /// Enum Dropbox for value: 2
        /// </summary>
        Dropbox = 2,

        /// <summary>
        /// Enum Docusign for value: 3
        /// </summary>
        Docusign = 3,

        /// <summary>
        /// Enum Box for value: 4
        /// </summary>
        Box = 4,

        /// <summary>
        /// Enum OneDrive for value: 5
        /// </summary>
        OneDrive = 5,

        /// <summary>
        /// Enum GosUslugi for value: 6
        /// </summary>
        GosUslugi = 6,

        /// <summary>
        /// Enum LinkedIn for value: 7
        /// </summary>
        LinkedIn = 7,

        /// <summary>
        /// Enum MailRu for value: 8
        /// </summary>
        MailRu = 8,

        /// <summary>
        /// Enum VK for value: 9
        /// </summary>
        VK = 9,

        /// <summary>
        /// Enum Wordpress for value: 10
        /// </summary>
        Wordpress = 10,

        /// <summary>
        /// Enum Yahoo for value: 11
        /// </summary>
        Yahoo = 11,

        /// <summary>
        /// Enum Yandex for value: 12
        /// </summary>
        Yandex = 12
    }

}
