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
    /// AiProviderDto
    /// </summary>
    [DataContract(Name = "AiProviderDto")]
    public partial class AiProviderDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ProviderType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProviderDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiProviderDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProviderDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title (required).</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        /// <param name="createdOn">createdOn (required).</param>
        /// <param name="modifiedOn">modifiedOn (required).</param>
        /// <param name="needReset">needReset.</param>
        /// <param name="isDefault">isDefault.</param>
        public AiProviderDto(int id = default, string title = default, ProviderType? type = default, string url = default, ApiDateTime createdOn = default, ApiDateTime modifiedOn = default, bool needReset = default, bool isDefault = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiProviderDto and cannot be null");
            }
            this.Title = title;
            // to ensure "createdOn" is required (not null)
            if (createdOn == null)
            {
                throw new ArgumentNullException("createdOn is a required property for AiProviderDto and cannot be null");
            }
            this.CreatedOn = createdOn;
            // to ensure "modifiedOn" is required (not null)
            if (modifiedOn == null)
            {
                throw new ArgumentNullException("modifiedOn is a required property for AiProviderDto and cannot be null");
            }
            this.ModifiedOn = modifiedOn;
            this.Id = id;
            this.Type = type;
            this.Url = url;
            this.NeedReset = needReset;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        /*
        <example>SampleFile</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", IsRequired = true, EmitDefaultValue = true)]
        public ApiDateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedOn
        /// </summary>
        [DataMember(Name = "modifiedOn", IsRequired = true, EmitDefaultValue = true)]
        public ApiDateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or Sets NeedReset
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "needReset", EmitDefaultValue = true)]
        public bool NeedReset { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiProviderDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  NeedReset: ").Append(NeedReset).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
