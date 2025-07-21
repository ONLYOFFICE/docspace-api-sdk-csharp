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
    /// [0 - None, 1 - Draft, 2 - You turn, 3 - In progress, 4 - Complete, 5 - Stoped]
    /// </summary>
    /// <value>[0 - None, 1 - Draft, 2 - You turn, 3 - In progress, 4 - Complete, 5 - Stoped]</value>
    public enum FormFillingStatus
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Draft for value: 1
        /// </summary>
        Draft = 1,

        /// <summary>
        /// Enum YouTurn for value: 2
        /// </summary>
        YouTurn = 2,

        /// <summary>
        /// Enum InProgress for value: 3
        /// </summary>
        InProgress = 3,

        /// <summary>
        /// Enum Complete for value: 4
        /// </summary>
        Complete = 4,

        /// <summary>
        /// Enum Stoped for value: 5
        /// </summary>
        Stoped = 5
    }

}
