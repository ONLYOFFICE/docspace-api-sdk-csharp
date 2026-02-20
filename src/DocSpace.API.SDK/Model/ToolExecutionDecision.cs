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
    /// [0 - Allow, 1 - AlwaysAllow, 2 - Deny]
    /// </summary>
    /// <value>[0 - Allow, 1 - AlwaysAllow, 2 - Deny]</value>
    public enum ToolExecutionDecision
    {
        /// <summary>
        /// Enum Allow for value: 0
        /// </summary>
        Allow = 0,

        /// <summary>
        /// Enum AlwaysAllow for value: 1
        /// </summary>
        AlwaysAllow = 1,

        /// <summary>
        /// Enum Deny for value: 2
        /// </summary>
        Deny = 2
    }

}
