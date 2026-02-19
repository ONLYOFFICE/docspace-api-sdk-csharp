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
    /// ChunkedUploadSessionResponseInteger
    /// </summary>
    [DataContract(Name = "ChunkedUploadSessionResponseInteger")]
    public partial class ChunkedUploadSessionResponseInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedUploadSessionResponseInteger" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="path">path.</param>
        /// <param name="created">created.</param>
        /// <param name="expired">expired.</param>
        /// <param name="location">location.</param>
        /// <param name="bytesTotal">bytesTotal.</param>
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
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public List<int> Path { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        /*
        <example>2008-04-10T06:30:00.0000000+04:00</example>
        */
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        /*
        <example>2008-04-10T06:30:00.0000000+04:00</example>
        */
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public DateTime Expired { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        /*
        <example>001 Schroeder Run, New Tabithaport, Colombia</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets BytesTotal
        /// </summary>
        /*
        <example>1234</example>
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
