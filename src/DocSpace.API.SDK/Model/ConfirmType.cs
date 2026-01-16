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
    /// [EmpInvite - Emp invite, LinkInvite - Link invite, PortalSuspend - Portal suspend, PortalContinue - Portal continue, PortalRemove - Portal remove, DnsChange - Dns change, PortalOwnerChange - Portal owner change, Activation - Activation, EmailChange - Email change, EmailActivation - Email activation, PasswordChange - Password change, ProfileRemove - Profile remove, PhoneActivation - Phone activation, PhoneAuth - Phone auth, Auth - Auth, TfaActivation - Tfa activation, TfaAuth - Tfa auth, Wizard - Wizard, GuestShareLink - Guest share link]
    /// </summary>
    /// <value>[EmpInvite - Emp invite, LinkInvite - Link invite, PortalSuspend - Portal suspend, PortalContinue - Portal continue, PortalRemove - Portal remove, DnsChange - Dns change, PortalOwnerChange - Portal owner change, Activation - Activation, EmailChange - Email change, EmailActivation - Email activation, PasswordChange - Password change, ProfileRemove - Profile remove, PhoneActivation - Phone activation, PhoneAuth - Phone auth, Auth - Auth, TfaActivation - Tfa activation, TfaAuth - Tfa auth, Wizard - Wizard, GuestShareLink - Guest share link]</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConfirmType
    {
        /// <summary>
        /// Enum EmpInvite for value: EmpInvite
        /// </summary>
        [EnumMember(Value = "EmpInvite")]
        EmpInvite = 0,

        /// <summary>
        /// Enum LinkInvite for value: LinkInvite
        /// </summary>
        [EnumMember(Value = "LinkInvite")]
        LinkInvite = 1,

        /// <summary>
        /// Enum PortalSuspend for value: PortalSuspend
        /// </summary>
        [EnumMember(Value = "PortalSuspend")]
        PortalSuspend = 2,

        /// <summary>
        /// Enum PortalContinue for value: PortalContinue
        /// </summary>
        [EnumMember(Value = "PortalContinue")]
        PortalContinue = 3,

        /// <summary>
        /// Enum PortalRemove for value: PortalRemove
        /// </summary>
        [EnumMember(Value = "PortalRemove")]
        PortalRemove = 4,

        /// <summary>
        /// Enum DnsChange for value: DnsChange
        /// </summary>
        [EnumMember(Value = "DnsChange")]
        DnsChange = 5,

        /// <summary>
        /// Enum PortalOwnerChange for value: PortalOwnerChange
        /// </summary>
        [EnumMember(Value = "PortalOwnerChange")]
        PortalOwnerChange = 6,

        /// <summary>
        /// Enum Activation for value: Activation
        /// </summary>
        [EnumMember(Value = "Activation")]
        Activation = 7,

        /// <summary>
        /// Enum EmailChange for value: EmailChange
        /// </summary>
        [EnumMember(Value = "EmailChange")]
        EmailChange = 8,

        /// <summary>
        /// Enum EmailActivation for value: EmailActivation
        /// </summary>
        [EnumMember(Value = "EmailActivation")]
        EmailActivation = 9,

        /// <summary>
        /// Enum PasswordChange for value: PasswordChange
        /// </summary>
        [EnumMember(Value = "PasswordChange")]
        PasswordChange = 10,

        /// <summary>
        /// Enum ProfileRemove for value: ProfileRemove
        /// </summary>
        [EnumMember(Value = "ProfileRemove")]
        ProfileRemove = 11,

        /// <summary>
        /// Enum PhoneActivation for value: PhoneActivation
        /// </summary>
        [EnumMember(Value = "PhoneActivation")]
        PhoneActivation = 12,

        /// <summary>
        /// Enum PhoneAuth for value: PhoneAuth
        /// </summary>
        [EnumMember(Value = "PhoneAuth")]
        PhoneAuth = 13,

        /// <summary>
        /// Enum Auth for value: Auth
        /// </summary>
        [EnumMember(Value = "Auth")]
        Auth = 14,

        /// <summary>
        /// Enum TfaActivation for value: TfaActivation
        /// </summary>
        [EnumMember(Value = "TfaActivation")]
        TfaActivation = 15,

        /// <summary>
        /// Enum TfaAuth for value: TfaAuth
        /// </summary>
        [EnumMember(Value = "TfaAuth")]
        TfaAuth = 16,

        /// <summary>
        /// Enum Wizard for value: Wizard
        /// </summary>
        [EnumMember(Value = "Wizard")]
        Wizard = 17,

        /// <summary>
        /// Enum GuestShareLink for value: GuestShareLink
        /// </summary>
        [EnumMember(Value = "GuestShareLink")]
        GuestShareLink = 18
    }

}
