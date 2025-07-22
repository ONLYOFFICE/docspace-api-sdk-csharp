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
    /// [0 - Created, 1 - Running, 2 - Completed, 3 - Canceled, 4 - Failted]
    /// </summary>
    /// <value>[0 - Created, 1 - Running, 2 - Completed, 3 - Canceled, 4 - Failted]</value>
    public enum DistributedTaskStatus
    {
        /// <summary>
        /// Enum Created for value: 0
        /// </summary>
        Created = 0,

        /// <summary>
        /// Enum Running for value: 1
        /// </summary>
        Running = 1,

        /// <summary>
        /// Enum Completed for value: 2
        /// </summary>
        Completed = 2,

        /// <summary>
        /// Enum Canceled for value: 3
        /// </summary>
        Canceled = 3,

        /// <summary>
        /// Enum Failted for value: 4
        /// </summary>
        Failted = 4
    }

}
