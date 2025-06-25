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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// [0 - None, 1 - Files, 2 - Folders, 3 - Documents settings, 4 - Companies, 5 - Persons, 6 - Contacts, 7 - Crm tasks, 8 - Opportunities, 9 - Invoices, 10 - Cases, 11 - Common crm settings, 12 - Contacts settings, 13 - Contact types, 14 - Invoice settings, 15 - Other crm settings, 16 - Users, 17 - Groups, 18 - Projects, 19 - Milestones, 20 - Tasks, 21 - Discussions, 22 - Time tracking, 23 - Reports, 24 - Projects settings, 25 - General, 26 - Products, 27 - Rooms, 28 - OAuth]
    /// </summary>
    /// <value>[0 - None, 1 - Files, 2 - Folders, 3 - Documents settings, 4 - Companies, 5 - Persons, 6 - Contacts, 7 - Crm tasks, 8 - Opportunities, 9 - Invoices, 10 - Cases, 11 - Common crm settings, 12 - Contacts settings, 13 - Contact types, 14 - Invoice settings, 15 - Other crm settings, 16 - Users, 17 - Groups, 18 - Projects, 19 - Milestones, 20 - Tasks, 21 - Discussions, 22 - Time tracking, 23 - Reports, 24 - Projects settings, 25 - General, 26 - Products, 27 - Rooms, 28 - OAuth]</value>
    public enum ModuleType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Files for value: 1
        /// </summary>
        Files = 1,

        /// <summary>
        /// Enum Folders for value: 2
        /// </summary>
        Folders = 2,

        /// <summary>
        /// Enum DocumentsSettings for value: 3
        /// </summary>
        DocumentsSettings = 3,

        /// <summary>
        /// Enum Companies for value: 4
        /// </summary>
        Companies = 4,

        /// <summary>
        /// Enum Persons for value: 5
        /// </summary>
        Persons = 5,

        /// <summary>
        /// Enum Contacts for value: 6
        /// </summary>
        Contacts = 6,

        /// <summary>
        /// Enum CrmTasks for value: 7
        /// </summary>
        CrmTasks = 7,

        /// <summary>
        /// Enum Opportunities for value: 8
        /// </summary>
        Opportunities = 8,

        /// <summary>
        /// Enum Invoices for value: 9
        /// </summary>
        Invoices = 9,

        /// <summary>
        /// Enum Cases for value: 10
        /// </summary>
        Cases = 10,

        /// <summary>
        /// Enum CommonCrmSettings for value: 11
        /// </summary>
        CommonCrmSettings = 11,

        /// <summary>
        /// Enum ContactsSettings for value: 12
        /// </summary>
        ContactsSettings = 12,

        /// <summary>
        /// Enum ContactTypes for value: 13
        /// </summary>
        ContactTypes = 13,

        /// <summary>
        /// Enum InvoiceSettings for value: 14
        /// </summary>
        InvoiceSettings = 14,

        /// <summary>
        /// Enum OtherCrmSettings for value: 15
        /// </summary>
        OtherCrmSettings = 15,

        /// <summary>
        /// Enum Users for value: 16
        /// </summary>
        Users = 16,

        /// <summary>
        /// Enum Groups for value: 17
        /// </summary>
        Groups = 17,

        /// <summary>
        /// Enum Projects for value: 18
        /// </summary>
        Projects = 18,

        /// <summary>
        /// Enum Milestones for value: 19
        /// </summary>
        Milestones = 19,

        /// <summary>
        /// Enum Tasks for value: 20
        /// </summary>
        Tasks = 20,

        /// <summary>
        /// Enum Discussions for value: 21
        /// </summary>
        Discussions = 21,

        /// <summary>
        /// Enum TimeTracking for value: 22
        /// </summary>
        TimeTracking = 22,

        /// <summary>
        /// Enum Reports for value: 23
        /// </summary>
        Reports = 23,

        /// <summary>
        /// Enum ProjectsSettings for value: 24
        /// </summary>
        ProjectsSettings = 24,

        /// <summary>
        /// Enum General for value: 25
        /// </summary>
        General = 25,

        /// <summary>
        /// Enum Products for value: 26
        /// </summary>
        Products = 26,

        /// <summary>
        /// Enum Rooms for value: 27
        /// </summary>
        Rooms = 27,

        /// <summary>
        /// Enum OAuth for value: 28
        /// </summary>
        OAuth = 28
    }

}
