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
    /// [0 - SSO, 1 - LDAP, 2 - Standart]
    /// </summary>
    /// <value>[0 - SSO, 1 - LDAP, 2 - Standart]</value>
    public enum AccountLoginType
    {
        /// <summary>
        /// Enum SSO for value: 0
        /// </summary>
        SSO = 0,

        /// <summary>
        /// Enum LDAP for value: 1
        /// </summary>
        LDAP = 1,

        /// <summary>
        /// Enum Standart for value: 2
        /// </summary>
        Standart = 2
    }

}
