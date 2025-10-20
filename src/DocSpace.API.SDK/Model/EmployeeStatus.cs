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
    /// [1 - Active, 2 - Terminated, 4 - Pending, 5 - Default, 7 - All]
    /// </summary>
    /// <value>[1 - Active, 2 - Terminated, 4 - Pending, 5 - Default, 7 - All]</value>
    public enum EmployeeStatus
    {
        /// <summary>
        /// Enum Active for value: 1
        /// </summary>
        Active = 1,

        /// <summary>
        /// Enum Terminated for value: 2
        /// </summary>
        Terminated = 2,

        /// <summary>
        /// Enum Pending for value: 4
        /// </summary>
        Pending = 4,

        /// <summary>
        /// Enum Default for value: 5
        /// </summary>
        Default = 5,

        /// <summary>
        /// Enum All for value: 7
        /// </summary>
        All = 7
    }

}
