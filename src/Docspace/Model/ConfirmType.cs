// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
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
