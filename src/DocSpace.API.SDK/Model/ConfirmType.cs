// (c) Copyright Ascensio System SIA 2026
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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// [EmpInvite - Emp invite, LinkInvite - Link invite, PortalSuspend - Portal suspend, PortalContinue - Portal continue, PortalRemove - Portal remove, DnsChange - Dns change, PortalOwnerChange - Portal owner change, Activation - Activation, EmailChange - Email change, EmailActivation - Email activation, PasswordChange - Password change, ProfileRemove - Profile remove, PhoneActivation - Phone activation, PhoneAuth - Phone auth, Auth - Auth, TfaActivation - Tfa activation, TfaAuth - Tfa auth, Wizard - Wizard, GuestShareLink - Guest share link]
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfirmType
    {
        /// <summary>
        /// Enum EmpInvite for value: EmpInvite
        /// </summary>
        [EnumMember(Value = "EmpInvite")]
        EmpInvite,

        /// <summary>
        /// Enum LinkInvite for value: LinkInvite
        /// </summary>
        [EnumMember(Value = "LinkInvite")]
        LinkInvite,

        /// <summary>
        /// Enum PortalSuspend for value: PortalSuspend
        /// </summary>
        [EnumMember(Value = "PortalSuspend")]
        PortalSuspend,

        /// <summary>
        /// Enum PortalContinue for value: PortalContinue
        /// </summary>
        [EnumMember(Value = "PortalContinue")]
        PortalContinue,

        /// <summary>
        /// Enum PortalRemove for value: PortalRemove
        /// </summary>
        [EnumMember(Value = "PortalRemove")]
        PortalRemove,

        /// <summary>
        /// Enum DnsChange for value: DnsChange
        /// </summary>
        [EnumMember(Value = "DnsChange")]
        DnsChange,

        /// <summary>
        /// Enum PortalOwnerChange for value: PortalOwnerChange
        /// </summary>
        [EnumMember(Value = "PortalOwnerChange")]
        PortalOwnerChange,

        /// <summary>
        /// Enum Activation for value: Activation
        /// </summary>
        [EnumMember(Value = "Activation")]
        Activation,

        /// <summary>
        /// Enum EmailChange for value: EmailChange
        /// </summary>
        [EnumMember(Value = "EmailChange")]
        EmailChange,

        /// <summary>
        /// Enum EmailActivation for value: EmailActivation
        /// </summary>
        [EnumMember(Value = "EmailActivation")]
        EmailActivation,

        /// <summary>
        /// Enum PasswordChange for value: PasswordChange
        /// </summary>
        [EnumMember(Value = "PasswordChange")]
        PasswordChange,

        /// <summary>
        /// Enum ProfileRemove for value: ProfileRemove
        /// </summary>
        [EnumMember(Value = "ProfileRemove")]
        ProfileRemove,

        /// <summary>
        /// Enum PhoneActivation for value: PhoneActivation
        /// </summary>
        [EnumMember(Value = "PhoneActivation")]
        PhoneActivation,

        /// <summary>
        /// Enum PhoneAuth for value: PhoneAuth
        /// </summary>
        [EnumMember(Value = "PhoneAuth")]
        PhoneAuth,

        /// <summary>
        /// Enum Auth for value: Auth
        /// </summary>
        [EnumMember(Value = "Auth")]
        Auth,

        /// <summary>
        /// Enum TfaActivation for value: TfaActivation
        /// </summary>
        [EnumMember(Value = "TfaActivation")]
        TfaActivation,

        /// <summary>
        /// Enum TfaAuth for value: TfaAuth
        /// </summary>
        [EnumMember(Value = "TfaAuth")]
        TfaAuth,

        /// <summary>
        /// Enum Wizard for value: Wizard
        /// </summary>
        [EnumMember(Value = "Wizard")]
        Wizard,

        /// <summary>
        /// Enum GuestShareLink for value: GuestShareLink
        /// </summary>
        [EnumMember(Value = "GuestShareLink")]
        GuestShareLink
    }

}
