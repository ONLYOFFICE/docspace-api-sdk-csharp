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
    /// The reserved chunked upload: where the parts are sent, how much was declared and when the reservation lapses. No  content of the file is described here.
    /// </summary>
    [DataContract(Name = "ChunkedUploadSessionResponse")]
    public partial class ChunkedUploadSessionResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedUploadSessionResponse" /> class.
        /// </summary>
        /// <param name="id">The identifier of the reserved upload, repeated in the path of every call that follows it - the chunk uploads,  the finalize and the abort. It is thirty-two hexadecimal characters without separators, and it is the only  thing the server checks, so anyone holding it can write into this upload..</param>
        /// <param name="path">The chain of folders leading to the destination, outermost first and the destination itself last, with folders  the caller cannot read left out. An answer that reports a stored part carries the destination folder alone  instead of the whole chain..</param>
        /// <param name="created">The moment the upload was reserved, in UTC..</param>
        /// <param name="expired">The moment the reservation lapses and the parts buffered for it are dropped, in UTC. It is a gap rather than a  deadline for the whole transfer: every accepted part pushes it twelve hours past that part, so only a long  silence loses the upload..</param>
        /// <param name="location">The absolute address of the separate chunk handler that also accepts the parts of this upload, kept for  clients written against it. A caller working through this API does not need it and sends the parts to the  session operations instead..</param>
        /// <param name="bytesTotal">The size in bytes that was declared when the upload was reserved, echoed back. It is what the arriving parts  are counted against to decide the file is complete, not the amount received so far..</param>
        public ChunkedUploadSessionResponse(string id = default, List<int> path = default, DateTime created = default, DateTime expired = default, string location = default, long bytesTotal = default)
        {
            this.Id = id;
            this.Path = path;
            this.Created = created;
            this.Expired = expired;
            this.Location = location;
            this.BytesTotal = bytesTotal;
        }

        /// <summary>
        /// The identifier of the reserved upload, repeated in the path of every call that follows it - the chunk uploads,  the finalize and the abort. It is thirty-two hexadecimal characters without separators, and it is the only  thing the server checks, so anyone holding it can write into this upload.
        /// </summary>
        /// <example>1b6a2ee1f2a04c6f9bd2cbf0e0f23a54</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The chain of folders leading to the destination, outermost first and the destination itself last, with folders  the caller cannot read left out. An answer that reports a stored part carries the destination folder alone  instead of the whole chain.
        /// </summary>
        /// <example>[1,5,12]</example>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public List<int> Path { get; set; }

        /// <summary>
        /// The moment the upload was reserved, in UTC.
        /// </summary>
        /// <example>2026-09-11T10:30:00Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The moment the reservation lapses and the parts buffered for it are dropped, in UTC. It is a gap rather than a  deadline for the whole transfer: every accepted part pushes it twelve hours past that part, so only a long  silence loses the upload.
        /// </summary>
        /// <example>2026-09-11T22:30:00Z</example>
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public DateTime Expired { get; set; }

        /// <summary>
        /// The absolute address of the separate chunk handler that also accepts the parts of this upload, kept for  clients written against it. A caller working through this API does not need it and sends the parts to the  session operations instead.
        /// </summary>
        /// <example>https://example.com/ChunkedUploader.ashx?uid=1b6a2ee1f2a04c6f9bd2cbf0e0f23a54</example>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// The size in bytes that was declared when the upload was reserved, echoed back. It is what the arriving parts  are counted against to decide the file is complete, not the amount received so far.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "bytes_total", EmitDefaultValue = false)]
        public long BytesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunkedUploadSessionResponse {\n");
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
