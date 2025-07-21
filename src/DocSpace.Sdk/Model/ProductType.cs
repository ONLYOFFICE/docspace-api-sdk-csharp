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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [0 - None, 2 - Documents, 3 - Login, 4 - Others, 5 - People, 7 - Settings]
    /// </summary>
    /// <value>[0 - None, 2 - Documents, 3 - Login, 4 - Others, 5 - People, 7 - Settings]</value>
    public enum ProductType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Documents for value: 2
        /// </summary>
        Documents = 2,

        /// <summary>
        /// Enum Login for value: 3
        /// </summary>
        Login = 3,

        /// <summary>
        /// Enum Others for value: 4
        /// </summary>
        Others = 4,

        /// <summary>
        /// Enum People for value: 5
        /// </summary>
        People = 5,

        /// <summary>
        /// Enum Settings for value: 7
        /// </summary>
        Settings = 7
    }

}
