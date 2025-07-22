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
    /// [0 - Ok, 1 - Invalid, 2 - Expired, 3 - Required password, 4 - Invalid password, 5 - External access denied]
    /// </summary>
    /// <value>[0 - Ok, 1 - Invalid, 2 - Expired, 3 - Required password, 4 - Invalid password, 5 - External access denied]</value>
    public enum Status
    {
        /// <summary>
        /// Enum Ok for value: 0
        /// </summary>
        Ok = 0,

        /// <summary>
        /// Enum Invalid for value: 1
        /// </summary>
        Invalid = 1,

        /// <summary>
        /// Enum Expired for value: 2
        /// </summary>
        Expired = 2,

        /// <summary>
        /// Enum RequiredPassword for value: 3
        /// </summary>
        RequiredPassword = 3,

        /// <summary>
        /// Enum InvalidPassword for value: 4
        /// </summary>
        InvalidPassword = 4,

        /// <summary>
        /// Enum ExternalAccessDenied for value: 5
        /// </summary>
        ExternalAccessDenied = 5
    }

}
