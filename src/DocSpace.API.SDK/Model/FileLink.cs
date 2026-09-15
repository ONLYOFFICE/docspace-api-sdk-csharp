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
    /// The address the content of a file is fetched from, together with the signature that authorises the fetch, as  the document service is handed it.
    /// </summary>
    [DataContract(Name = "FileLink")]
    public partial class FileLink : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLink" /> class.
        /// </summary>
        /// <param name="filetype">The format the stored content is in, lower-cased and with the leading dot, which is how the document  service learns how to read the bytes behind the address. It stays empty when the file title carries no  extension at all. (required).</param>
        /// <param name="token">Signs the address and the format above so that the document service can trust them. It stays empty on a  portal that has no signature secret configured for the document service, and the address is then meant  to be fetched unsigned..</param>
        /// <param name="url">Where the content is fetched from: the portal download handler, pinned to the revision the file was at  when the address was issued and carrying an authorisation key of limited validity. It is addressed to  the host the document service can reach, which on a deployment with a private editor network is not the  address a browser should follow. (required).</param>
        public FileLink(string filetype = default, string token = default, string url = default)
        {
            // to ensure "filetype" is required (not null)
            if (filetype == null)
            {
                throw new ArgumentNullException("filetype is a required property for FileLink and cannot be null");
            }
            this.Filetype = filetype;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for FileLink and cannot be null");
            }
            this.Url = url;
            this.Token = token;
        }

        /// <summary>
        /// The format the stored content is in, lower-cased and with the leading dot, which is how the document  service learns how to read the bytes behind the address. It stays empty when the file title carries no  extension at all.
        /// </summary>
        /// <example>.docx</example>
        [DataMember(Name = "filetype", IsRequired = true, EmitDefaultValue = true)]
        public string Filetype { get; set; }

        /// <summary>
        /// Signs the address and the format above so that the document service can trust them. It stays empty on a  portal that has no signature secret configured for the document service, and the address is then meant  to be fetched unsigned.
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Where the content is fetched from: the portal download handler, pinned to the revision the file was at  when the address was issued and carrying an authorisation key of limited validity. It is addressed to  the host the document service can reach, which on a deployment with a private editor network is not the  address a browser should follow.
        /// </summary>
        /// <example>https://portal.example.com/filehandler.ashx?action=stream&amp;fileid=512&amp;version=3</example>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLink {\n");
            sb.Append("  Filetype: ").Append(Filetype).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
