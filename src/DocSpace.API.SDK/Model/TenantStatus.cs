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
    /// [0 - Active, 1 - Suspended, 2 - Remove pending, 3 - Transfering, 4 - Restoring, 5 - Migrating, 6 - Encryption]
    /// </summary>
    /// <value>[0 - Active, 1 - Suspended, 2 - Remove pending, 3 - Transfering, 4 - Restoring, 5 - Migrating, 6 - Encryption]</value>
    public enum TenantStatus
    {
        /// <summary>
        /// Enum Active for value: 0
        /// </summary>
        Active = 0,

        /// <summary>
        /// Enum Suspended for value: 1
        /// </summary>
        Suspended = 1,

        /// <summary>
        /// Enum RemovePending for value: 2
        /// </summary>
        RemovePending = 2,

        /// <summary>
        /// Enum Transfering for value: 3
        /// </summary>
        Transfering = 3,

        /// <summary>
        /// Enum Restoring for value: 4
        /// </summary>
        Restoring = 4,

        /// <summary>
        /// Enum Migrating for value: 5
        /// </summary>
        Migrating = 5,

        /// <summary>
        /// Enum Encryption for value: 6
        /// </summary>
        Encryption = 6
    }

}
