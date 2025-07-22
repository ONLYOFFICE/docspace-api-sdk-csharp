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
    /// [0 - None, 1 - Share to fill out, 2 - Start filling]
    /// </summary>
    /// <value>[0 - None, 1 - Share to fill out, 2 - Start filling]</value>
    public enum StartFillingMode
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum ShareToFillOut for value: 1
        /// </summary>
        ShareToFillOut = 1,

        /// <summary>
        /// Enum StartFilling for value: 2
        /// </summary>
        StartFilling = 2
    }

}
