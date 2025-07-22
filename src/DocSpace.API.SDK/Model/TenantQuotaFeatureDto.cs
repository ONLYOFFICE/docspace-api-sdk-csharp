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
    /// The tenant quota feature parameters.
    /// </summary>
    [DataContract(Name = "TenantQuotaFeatureDto")]
    public partial class TenantQuotaFeatureDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaFeatureDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the tenant quota feature..</param>
        /// <param name="title">The title of the tenant quota feature..</param>
        /// <param name="image">The image URL of the tenant quota feature..</param>
        /// <param name="value">The value of the tenant quota feature..</param>
        /// <param name="type">The type of the tenant quota feature..</param>
        /// <param name="used">used.</param>
        /// <param name="priceTitle">The price title of the tenant quota feature..</param>
        public TenantQuotaFeatureDto(string id = default, string title = default, string image = default, Object value = default, string type = default, FeatureUsedDto used = default, string priceTitle = default)
        {
            this.Id = id;
            this.Title = title;
            this.Image = image;
            this.Value = value;
            this.Type = type;
            this.Used = used;
            this.PriceTitle = priceTitle;
        }

        /// <summary>
        /// The ID of the tenant quota feature.
        /// </summary>
        /// <value>The ID of the tenant quota feature.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the tenant quota feature.
        /// </summary>
        /// <value>The title of the tenant quota feature.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The image URL of the tenant quota feature.
        /// </summary>
        /// <value>The image URL of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The value of the tenant quota feature.
        /// </summary>
        /// <value>The value of the tenant quota feature.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// The type of the tenant quota feature.
        /// </summary>
        /// <value>The type of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", EmitDefaultValue = false)]
        public FeatureUsedDto Used { get; set; }

        /// <summary>
        /// The price title of the tenant quota feature.
        /// </summary>
        /// <value>The price title of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "priceTitle", EmitDefaultValue = true)]
        public string PriceTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantQuotaFeatureDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  PriceTitle: ").Append(PriceTitle).Append("\n");
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
