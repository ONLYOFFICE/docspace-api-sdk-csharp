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
    /// ChunkedUploadSessionResponseWrapperT
    /// </summary>
    [DataContract(Name = "ChunkedUploadSessionResponseWrapperT")]
    public partial class ChunkedUploadSessionResponseWrapperT : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedUploadSessionResponseWrapperT" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="data">data.</param>
        public ChunkedUploadSessionResponseWrapperT(bool success = default, ChunkedUploadSessionResponseT data = default)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public ChunkedUploadSessionResponseT Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunkedUploadSessionResponseWrapperT {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
