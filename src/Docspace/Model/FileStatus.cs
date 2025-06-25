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
    /// [0 - None, 1 - Is editing, 2 - Is new, 4 - Is converting, 8 - Is original, 16 - Is editing alone, 32 - Is favorite, 64 - Is template, 128 - Is fill form draft, 256 - Is completed form]
    /// </summary>
    /// <value>[0 - None, 1 - Is editing, 2 - Is new, 4 - Is converting, 8 - Is original, 16 - Is editing alone, 32 - Is favorite, 64 - Is template, 128 - Is fill form draft, 256 - Is completed form]</value>
    public enum FileStatus
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum IsEditing for value: 1
        /// </summary>
        IsEditing = 1,

        /// <summary>
        /// Enum IsNew for value: 2
        /// </summary>
        IsNew = 2,

        /// <summary>
        /// Enum IsConverting for value: 4
        /// </summary>
        IsConverting = 4,

        /// <summary>
        /// Enum IsOriginal for value: 8
        /// </summary>
        IsOriginal = 8,

        /// <summary>
        /// Enum IsEditingAlone for value: 16
        /// </summary>
        IsEditingAlone = 16,

        /// <summary>
        /// Enum IsFavorite for value: 32
        /// </summary>
        IsFavorite = 32,

        /// <summary>
        /// Enum IsTemplate for value: 64
        /// </summary>
        IsTemplate = 64,

        /// <summary>
        /// Enum IsFillFormDraft for value: 128
        /// </summary>
        IsFillFormDraft = 128,

        /// <summary>
        /// Enum IsCompletedForm for value: 256
        /// </summary>
        IsCompletedForm = 256
    }

}
