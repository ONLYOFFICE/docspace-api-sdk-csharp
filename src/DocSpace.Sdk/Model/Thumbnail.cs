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
    /// [0 - Waiting, 1 - Created, 2 - Error, 3 - Not required, 4 - Creating]
    /// </summary>
    /// <value>[0 - Waiting, 1 - Created, 2 - Error, 3 - Not required, 4 - Creating]</value>
    public enum Thumbnail
    {
        /// <summary>
        /// Enum Waiting for value: 0
        /// </summary>
        Waiting = 0,

        /// <summary>
        /// Enum Created for value: 1
        /// </summary>
        Created = 1,

        /// <summary>
        /// Enum Error for value: 2
        /// </summary>
        Error = 2,

        /// <summary>
        /// Enum NotRequired for value: 3
        /// </summary>
        NotRequired = 3,

        /// <summary>
        /// Enum Creating for value: 4
        /// </summary>
        Creating = 4
    }

}
