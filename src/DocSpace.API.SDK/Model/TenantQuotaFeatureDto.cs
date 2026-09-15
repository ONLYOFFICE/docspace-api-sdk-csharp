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
    /// One feature a quota switches on, with the limit it grants and how much of that limit is used.
    /// </summary>
    [DataContract(Name = "TenantQuotaFeatureDto")]
    public partial class TenantQuotaFeatureDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaFeatureDto" /> class.
        /// </summary>
        /// <param name="id">The stable key of the feature - &#x60;total_size&#x60;, &#x60;manager&#x60;, &#x60;room&#x60;, &#x60;backup&#x60; and so on. It is the value to  branch on, since &#x60;title&#x60; is prose in the portal language..</param>
        /// <param name="title">The feature described in the portal language, with its limit already substituted into the sentence, so it  can be printed as it is. It is empty when this build ships no wording for the feature..</param>
        /// <param name="image">The feature&#39;s icon as SVG markup to render inline - not a URL to fetch. It is filled in only when the  quota comes from the catalogue, and left empty on the quota the portal is actually on, on a feature that  this quota switches off, and on a feature that ships no icon..</param>
        /// <param name="value">value.</param>
        /// <param name="type">How to read &#x60;value&#x60; and &#x60;used&#x60;: &#x60;size&#x60; for bytes, &#x60;count&#x60; for a number of things, &#x60;flag&#x60; for a feature  that is merely on or off..</param>
        /// <param name="used">How much of the limit is already used. It is present only on the quota the portal is actually on, and  only for a feature whose consumption is counted; a guest is shown none of these figures and a plain member  only the one for total size, so an absent value can mean the caller may not see it rather than that  nothing is used..</param>
        /// <param name="priceTitle">What the feature is charged as, in the portal language - for instance the per-unit price of an add-on. It  is filled in only for a feature that costs money on top of the plan..</param>
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
        /// The stable key of the feature - &#x60;total_size&#x60;, &#x60;manager&#x60;, &#x60;room&#x60;, &#x60;backup&#x60; and so on. It is the value to  branch on, since &#x60;title&#x60; is prose in the portal language.
        /// </summary>
        /// <example>total_size</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The feature described in the portal language, with its limit already substituted into the sentence, so it  can be printed as it is. It is empty when this build ships no wording for the feature.
        /// </summary>
        /// <example>Premium Storage</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The feature&#39;s icon as SVG markup to render inline - not a URL to fetch. It is filled in only when the  quota comes from the catalogue, and left empty on the quota the portal is actually on, on a feature that  this quota switches off, and on a feature that ships no icon.
        /// </summary>
        /// <example>&lt;svg viewBox="0 0 24 24"&gt;&lt;path d="..."/&gt;&lt;/svg&gt;</example>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// How to read &#x60;value&#x60; and &#x60;used&#x60;: &#x60;size&#x60; for bytes, &#x60;count&#x60; for a number of things, &#x60;flag&#x60; for a feature  that is merely on or off.
        /// </summary>
        /// <example>size</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// How much of the limit is already used. It is present only on the quota the portal is actually on, and  only for a feature whose consumption is counted; a guest is shown none of these figures and a plain member  only the one for total size, so an absent value can mean the caller may not see it rather than that  nothing is used.
        /// </summary>
        [DataMember(Name = "used", EmitDefaultValue = false)]
        public FeatureUsedDto Used { get; set; }

        /// <summary>
        /// What the feature is charged as, in the portal language - for instance the per-unit price of an add-on. It  is filled in only for a feature that costs money on top of the plan.
        /// </summary>
        /// <example>$9.99/month</example>
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
