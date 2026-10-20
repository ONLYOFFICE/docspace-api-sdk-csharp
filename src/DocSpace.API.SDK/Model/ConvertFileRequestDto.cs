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
    /// What to convert, where to keep the result, and the parameters the document service is handed. Everything below the  first two fields is the contract of the document service itself, named and shaped exactly as it names it, so that  the portal passes the request on rather than translating it. What the portal can read off the file - its format,  its name and the key of its revision - is not asked for and cannot be overridden.
    /// </summary>
    [DataContract(Name = "ConvertFileRequestDto")]
    public partial class ConvertFileRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertFileRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertFileRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertFileRequestDto" /> class.
        /// </summary>
        /// <param name="fileId">The id of the portal file to convert, as reported by a folder listing such as &#x60;GET api/2.0/files/{folderId}&#x60;. (required).</param>
        /// <param name="folderId">The id of the folder to save the converted file in, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;..</param>
        /// <param name="codePage">The encoding of a csv or txt source, as a code page number: 1251 for Cyrillic, 65001 for UTF-8, and so on.  Leaving it out lets the document service guess, which garbles non-latin text..</param>
        /// <param name="delimiter">The character separating the values of a csv source: 0 - none, 1 - tab, 2 - semicolon, 3 - colon, 4 - comma,  5 - space..</param>
        /// <param name="documentLayout">The layout of forms printed as pdf documents or images..</param>
        /// <param name="documentRenderer">How the text of a pdf, xps or oxps source is read back..</param>
        /// <param name="outputtype">The extension of the format to convert to, without the dot. The formats a source can become are listed under  &#x60;extsConvertible&#x60; in &#x60;GET api/2.0/files/settings&#x60;, keyed by the source extension, both with a leading dot there. (required).</param>
        /// <param name="password">The password of the source document, for a document that is protected with one..</param>
        /// <param name="region">The culture code whose currency, date and time formats a spreadsheet converted to PDF is shown in..</param>
        /// <param name="thumbnail">How a thumbnail is fitted, when the target format is an image..</param>
        /// <param name="spreadsheetLayout">How a spreadsheet is laid out on the page, when it is converted to PDF..</param>
        /// <param name="pdf">The PDF settings, used when the target format is PDF..</param>
        public ConvertFileRequestDto(int fileId = default, int? folderId = default, int? codePage = default, int? delimiter = default, ConvertDocumentLayoutRequest documentLayout = default, ConvertDocumentRendererRequest documentRenderer = default, string outputtype = default, string password = default, string region = default, ConvertThumbnailRequest thumbnail = default, ConvertSpreadsheetLayoutRequest spreadsheetLayout = default, ConvertPdfRequest pdf = default)
        {
            this.FileId = fileId;
            // to ensure "outputtype" is required (not null)
            if (outputtype == null)
            {
                throw new ArgumentNullException("outputtype is a required property for ConvertFileRequestDto and cannot be null");
            }
            this.Outputtype = outputtype;
            this.FolderId = folderId;
            this.CodePage = codePage;
            this.Delimiter = delimiter;
            this.DocumentLayout = documentLayout;
            this.DocumentRenderer = documentRenderer;
            this.Password = password;
            this.Region = region;
            this.Thumbnail = thumbnail;
            this.SpreadsheetLayout = spreadsheetLayout;
            this.Pdf = pdf;
        }

        /// <summary>
        /// The id of the portal file to convert, as reported by a folder listing such as &#x60;GET api/2.0/files/{folderId}&#x60;.
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public int FileId { get; set; }

        /// <summary>
        /// The id of the folder to save the converted file in, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;.
        /// </summary>
        /// <example>5678</example>
        [DataMember(Name = "folderId", EmitDefaultValue = true)]
        public int? FolderId { get; set; }

        /// <summary>
        /// The encoding of a csv or txt source, as a code page number: 1251 for Cyrillic, 65001 for UTF-8, and so on.  Leaving it out lets the document service guess, which garbles non-latin text.
        /// </summary>
        /// <example>65001</example>
        [DataMember(Name = "codePage", EmitDefaultValue = true)]
        public int? CodePage { get; set; }

        /// <summary>
        /// The character separating the values of a csv source: 0 - none, 1 - tab, 2 - semicolon, 3 - colon, 4 - comma,  5 - space.
        /// </summary>
        /// <example>4</example>
        [DataMember(Name = "delimiter", EmitDefaultValue = true)]
        public int? Delimiter { get; set; }

        /// <summary>
        /// The layout of forms printed as pdf documents or images.
        /// </summary>
        [DataMember(Name = "documentLayout", EmitDefaultValue = false)]
        public ConvertDocumentLayoutRequest DocumentLayout { get; set; }

        /// <summary>
        /// How the text of a pdf, xps or oxps source is read back.
        /// </summary>
        [DataMember(Name = "documentRenderer", EmitDefaultValue = false)]
        public ConvertDocumentRendererRequest DocumentRenderer { get; set; }

        /// <summary>
        /// The extension of the format to convert to, without the dot. The formats a source can become are listed under  &#x60;extsConvertible&#x60; in &#x60;GET api/2.0/files/settings&#x60;, keyed by the source extension, both with a leading dot there.
        /// </summary>
        /// <example>pdf</example>
        [DataMember(Name = "outputtype", IsRequired = true, EmitDefaultValue = true)]
        public string Outputtype { get; set; }

        /// <summary>
        /// The password of the source document, for a document that is protected with one.
        /// </summary>
        /// <example>qwerty</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The culture code whose currency, date and time formats a spreadsheet converted to PDF is shown in.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// How a thumbnail is fitted, when the target format is an image.
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public ConvertThumbnailRequest Thumbnail { get; set; }

        /// <summary>
        /// How a spreadsheet is laid out on the page, when it is converted to PDF.
        /// </summary>
        [DataMember(Name = "spreadsheetLayout", EmitDefaultValue = false)]
        public ConvertSpreadsheetLayoutRequest SpreadsheetLayout { get; set; }

        /// <summary>
        /// The PDF settings, used when the target format is PDF.
        /// </summary>
        [DataMember(Name = "pdf", EmitDefaultValue = false)]
        public ConvertPdfRequest Pdf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertFileRequestDto {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  CodePage: ").Append(CodePage).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  DocumentLayout: ").Append(DocumentLayout).Append("\n");
            sb.Append("  DocumentRenderer: ").Append(DocumentRenderer).Append("\n");
            sb.Append("  Outputtype: ").Append(Outputtype).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  SpreadsheetLayout: ").Append(SpreadsheetLayout).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

    }


}
