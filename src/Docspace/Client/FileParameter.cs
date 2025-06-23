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


using System.IO;

namespace Docspace.Client
{

    /// <summary>
    /// Represents a File passed to the API as a Parameter, allows using different backends for files
    /// </summary>
    public class FileParameter
    {
        /// <summary>
        /// The filename
        /// </summary>
        public string Name { get; set; } = "no_name_provided";

        /// <summary>
        /// The content type of the file
        /// </summary>
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        /// The content of the file
        /// </summary>
        public Stream Content { get; set; }

        /// <summary>
        /// Construct a FileParameter just from the contents, will extract the filename from a filestream
        /// </summary>
        /// <param name="content"> The file content </param>
        public FileParameter(Stream content)
        {
            if (content is FileStream fs)
            {
                Name = fs.Name;
            }
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, Stream content)
        {
            Name = filename;
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="contentType">The content type of the file</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, string contentType, Stream content)
        {
            Name = filename;
            ContentType = contentType;
            Content = content;
        }

        /// <summary>
        /// Implicit conversion of stream to file parameter. Useful for backwards compatibility.
        /// </summary>
        /// <param name="s">Stream to convert</param>
        /// <returns>FileParameter</returns>
        public static implicit operator FileParameter(Stream s) => new FileParameter(s);
    }
}