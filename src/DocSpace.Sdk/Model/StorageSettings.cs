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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// StorageSettings
    /// </summary>
    [DataContract(Name = "StorageSettings")]
    public partial class StorageSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSettings" /> class.
        /// </summary>
        /// <param name="module">module.</param>
        /// <param name="props">props.</param>
        /// <param name="lastModified">lastModified.</param>
        public StorageSettings(string module = default, Dictionary<string, string> props = default, DateTime lastModified = default)
        {
            this.Module = module;
            this.Props = props;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "module", EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// Gets or Sets Props
        /// </summary>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:&quot;some text&quot;}]</example>
        */
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageSettings {\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
