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
    /// [0 - Trial, 1 - Paid, 2 - Delay, 3 - Not paid]
    /// </summary>
    /// <value>[0 - Trial, 1 - Paid, 2 - Delay, 3 - Not paid]</value>
    public enum TariffState
    {
        /// <summary>
        /// Enum Trial for value: 0
        /// </summary>
        Trial = 0,

        /// <summary>
        /// Enum Paid for value: 1
        /// </summary>
        Paid = 1,

        /// <summary>
        /// Enum Delay for value: 2
        /// </summary>
        Delay = 2,

        /// <summary>
        /// Enum NotPaid for value: 3
        /// </summary>
        NotPaid = 3
    }

}
