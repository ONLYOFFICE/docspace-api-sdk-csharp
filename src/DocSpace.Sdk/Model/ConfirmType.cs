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
    /// [0 - Emp invite, 1 - Link invite, 2 - Portal suspend, 3 - Portal continue, 4 - Portal remove, 5 - Dns change, 6 - Portal owner change, 7 - Activation, 8 - Email change, 9 - Email activation, 10 - Password change, 11 - Profile remove, 12 - Phone activation, 13 - Phone auth, 14 - Auth, 15 - Tfa activation, 16 - Tfa auth, 17 - Wizard, 18 - Guest share link]
    /// </summary>
    /// <value>[0 - Emp invite, 1 - Link invite, 2 - Portal suspend, 3 - Portal continue, 4 - Portal remove, 5 - Dns change, 6 - Portal owner change, 7 - Activation, 8 - Email change, 9 - Email activation, 10 - Password change, 11 - Profile remove, 12 - Phone activation, 13 - Phone auth, 14 - Auth, 15 - Tfa activation, 16 - Tfa auth, 17 - Wizard, 18 - Guest share link]</value>
    public enum ConfirmType
    {
        /// <summary>
        /// Enum EmpInvite for value: 0
        /// </summary>
        EmpInvite = 0,

        /// <summary>
        /// Enum LinkInvite for value: 1
        /// </summary>
        LinkInvite = 1,

        /// <summary>
        /// Enum PortalSuspend for value: 2
        /// </summary>
        PortalSuspend = 2,

        /// <summary>
        /// Enum PortalContinue for value: 3
        /// </summary>
        PortalContinue = 3,

        /// <summary>
        /// Enum PortalRemove for value: 4
        /// </summary>
        PortalRemove = 4,

        /// <summary>
        /// Enum DnsChange for value: 5
        /// </summary>
        DnsChange = 5,

        /// <summary>
        /// Enum PortalOwnerChange for value: 6
        /// </summary>
        PortalOwnerChange = 6,

        /// <summary>
        /// Enum Activation for value: 7
        /// </summary>
        Activation = 7,

        /// <summary>
        /// Enum EmailChange for value: 8
        /// </summary>
        EmailChange = 8,

        /// <summary>
        /// Enum EmailActivation for value: 9
        /// </summary>
        EmailActivation = 9,

        /// <summary>
        /// Enum PasswordChange for value: 10
        /// </summary>
        PasswordChange = 10,

        /// <summary>
        /// Enum ProfileRemove for value: 11
        /// </summary>
        ProfileRemove = 11,

        /// <summary>
        /// Enum PhoneActivation for value: 12
        /// </summary>
        PhoneActivation = 12,

        /// <summary>
        /// Enum PhoneAuth for value: 13
        /// </summary>
        PhoneAuth = 13,

        /// <summary>
        /// Enum Auth for value: 14
        /// </summary>
        Auth = 14,

        /// <summary>
        /// Enum TfaActivation for value: 15
        /// </summary>
        TfaActivation = 15,

        /// <summary>
        /// Enum TfaAuth for value: 16
        /// </summary>
        TfaAuth = 16,

        /// <summary>
        /// Enum Wizard for value: 17
        /// </summary>
        Wizard = 17,

        /// <summary>
        /// Enum GuestShareLink for value: 18
        /// </summary>
        GuestShareLink = 18
    }

}
