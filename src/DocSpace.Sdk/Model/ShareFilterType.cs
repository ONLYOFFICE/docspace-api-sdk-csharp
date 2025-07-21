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
    /// [0 - User or group, 1 - Invitation link, 2 - External link, 4 - Additional external link, 8 - Primary external link, 16 - User, 32 - Group]
    /// </summary>
    /// <value>[0 - User or group, 1 - Invitation link, 2 - External link, 4 - Additional external link, 8 - Primary external link, 16 - User, 32 - Group]</value>
    public enum ShareFilterType
    {
        /// <summary>
        /// Enum UserOrGroup for value: 0
        /// </summary>
        UserOrGroup = 0,

        /// <summary>
        /// Enum InvitationLink for value: 1
        /// </summary>
        InvitationLink = 1,

        /// <summary>
        /// Enum ExternalLink for value: 2
        /// </summary>
        ExternalLink = 2,

        /// <summary>
        /// Enum AdditionalExternalLink for value: 4
        /// </summary>
        AdditionalExternalLink = 4,

        /// <summary>
        /// Enum PrimaryExternalLink for value: 8
        /// </summary>
        PrimaryExternalLink = 8,

        /// <summary>
        /// Enum User for value: 16
        /// </summary>
        User = 16,

        /// <summary>
        /// Enum Group for value: 32
        /// </summary>
        Group = 32
    }

}
