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
    /// Represents the response returned from a chunked upload session.
    /// </summary>
    [DataContract(Name = "ChunkedUploadSessionResponseInteger")]
    public partial class ChunkedUploadSessionResponseInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedUploadSessionResponseInteger" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the entity..</param>
        /// <param name="path">Represents the hierarchical path of folders associated with a chunked upload session..</param>
        /// <param name="created">The timestamp indicating when the chunked upload session was created..</param>
        /// <param name="expired">The date and time when the chunked upload session is set to expire..</param>
        /// <param name="location">Represents the URI or path of the chunked upload session&#39;s current location..</param>
        /// <param name="bytesTotal">The total size, in bytes, of the file being uploaded in the chunked upload session..</param>
        public ChunkedUploadSessionResponseInteger(string id = default, List<int> path = default, DateTime created = default, DateTime expired = default, string location = default, long bytesTotal = default)
        {
            this.Id = id;
            this.Path = path;
            this.Created = created;
            this.Expired = expired;
            this.Location = location;
            this.BytesTotal = bytesTotal;
        }

        /// <summary>
        /// The unique identifier for the entity.
        /// </summary>
        /// <value>The unique identifier for the entity.</value>
        /*
        <example>0af4bc0d-9a9d-450c-a72b-f14d9ac55c89</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Represents the hierarchical path of folders associated with a chunked upload session.
        /// </summary>
        /// <value>Represents the hierarchical path of folders associated with a chunked upload session.</value>
        /*
        <example>[&quot;123&quot;,&quot;456&quot;,&quot;789&quot;]</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public List<int> Path { get; set; }

        /// <summary>
        /// The timestamp indicating when the chunked upload session was created.
        /// </summary>
        /// <value>The timestamp indicating when the chunked upload session was created.</value>
        /*
        <example>2024-01-15T10:30Z</example>
        */
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time when the chunked upload session is set to expire.
        /// </summary>
        /// <value>The date and time when the chunked upload session is set to expire.</value>
        /*
        <example>2024-01-15T11:30Z</example>
        */
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public DateTime Expired { get; set; }

        /// <summary>
        /// Represents the URI or path of the chunked upload session&#39;s current location.
        /// </summary>
        /// <value>Represents the URI or path of the chunked upload session&#39;s current location.</value>
        /*
        <example>https://example.com/products/files/httphandlers/filehandler.ashx?action&#x3D;upload</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// The total size, in bytes, of the file being uploaded in the chunked upload session.
        /// </summary>
        /// <value>The total size, in bytes, of the file being uploaded in the chunked upload session.</value>
        /*
        <example>10485760</example>
        */
        [DataMember(Name = "bytes_total", EmitDefaultValue = false)]
        public long BytesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunkedUploadSessionResponseInteger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  BytesTotal: ").Append(BytesTotal).Append("\n");
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
