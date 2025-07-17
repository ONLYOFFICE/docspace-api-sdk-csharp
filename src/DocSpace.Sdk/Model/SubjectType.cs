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
    /// [0 - User, 1 - External link, 2 - Group, 3 - Invitation link, 4 - Primary external link]
    /// </summary>
    /// <value>[0 - User, 1 - External link, 2 - Group, 3 - Invitation link, 4 - Primary external link]</value>
    public enum SubjectType
    {
        /// <summary>
        /// Enum User for value: 0
        /// </summary>
        User = 0,

        /// <summary>
        /// Enum ExternalLink for value: 1
        /// </summary>
        ExternalLink = 1,

        /// <summary>
        /// Enum Group for value: 2
        /// </summary>
        Group = 2,

        /// <summary>
        /// Enum InvitationLink for value: 3
        /// </summary>
        InvitationLink = 3,

        /// <summary>
        /// Enum PrimaryExternalLink for value: 4
        /// </summary>
        PrimaryExternalLink = 4
    }

}
