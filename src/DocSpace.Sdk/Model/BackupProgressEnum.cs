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
    /// [0 - Backup, 1 - Restore, 2 - Transfer]
    /// </summary>
    /// <value>[0 - Backup, 1 - Restore, 2 - Transfer]</value>
    public enum BackupProgressEnum
    {
        /// <summary>
        /// Enum Backup for value: 0
        /// </summary>
        Backup = 0,

        /// <summary>
        /// Enum Restore for value: 1
        /// </summary>
        Restore = 1,

        /// <summary>
        /// Enum Transfer for value: 2
        /// </summary>
        Transfer = 2
    }

}
