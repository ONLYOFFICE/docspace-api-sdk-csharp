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
    /// The external resources settings.
    /// </summary>
    [DataContract(Name = "CultureSpecificExternalResources")]
    public partial class CultureSpecificExternalResources : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CultureSpecificExternalResources" /> class.
        /// </summary>
        /// <param name="api">api.</param>
        /// <param name="common">common.</param>
        /// <param name="forum">forum.</param>
        /// <param name="helpcenter">helpcenter.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="site">site.</param>
        /// <param name="socialNetworks">socialNetworks.</param>
        /// <param name="support">support.</param>
        /// <param name="videoguides">videoguides.</param>
        public CultureSpecificExternalResources(CultureSpecificExternalResource api = default, CultureSpecificExternalResource common = default, CultureSpecificExternalResource forum = default, CultureSpecificExternalResource helpcenter = default, CultureSpecificExternalResource integrations = default, CultureSpecificExternalResource site = default, CultureSpecificExternalResource socialNetworks = default, CultureSpecificExternalResource support = default, CultureSpecificExternalResource videoguides = default)
        {
            this.Api = api;
            this.Common = common;
            this.Forum = forum;
            this.Helpcenter = helpcenter;
            this.Integrations = integrations;
            this.Site = site;
            this.SocialNetworks = socialNetworks;
            this.Support = support;
            this.Videoguides = videoguides;
        }

        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name = "api", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Api { get; set; }

        /// <summary>
        /// Gets or Sets Common
        /// </summary>
        [DataMember(Name = "common", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Common { get; set; }

        /// <summary>
        /// Gets or Sets Forum
        /// </summary>
        [DataMember(Name = "forum", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Forum { get; set; }

        /// <summary>
        /// Gets or Sets Helpcenter
        /// </summary>
        [DataMember(Name = "helpcenter", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Helpcenter { get; set; }

        /// <summary>
        /// Gets or Sets Integrations
        /// </summary>
        [DataMember(Name = "integrations", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Integrations { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Site { get; set; }

        /// <summary>
        /// Gets or Sets SocialNetworks
        /// </summary>
        [DataMember(Name = "socialNetworks", EmitDefaultValue = false)]
        public CultureSpecificExternalResource SocialNetworks { get; set; }

        /// <summary>
        /// Gets or Sets Support
        /// </summary>
        [DataMember(Name = "support", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Support { get; set; }

        /// <summary>
        /// Gets or Sets Videoguides
        /// </summary>
        [DataMember(Name = "videoguides", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Videoguides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CultureSpecificExternalResources {\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  Common: ").Append(Common).Append("\n");
            sb.Append("  Forum: ").Append(Forum).Append("\n");
            sb.Append("  Helpcenter: ").Append(Helpcenter).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  SocialNetworks: ").Append(SocialNetworks).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  Videoguides: ").Append(Videoguides).Append("\n");
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
