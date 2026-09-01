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
    /// The external resources settings.
    /// </summary>
    [DataContract(Name = "CultureSpecificExternalResources")]
    public partial class CultureSpecificExternalResources : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CultureSpecificExternalResources" /> class.
        /// </summary>
        /// <param name="api">The link to the product API..</param>
        /// <param name="common">The link to the common product information..</param>
        /// <param name="forum">The link to the forum..</param>
        /// <param name="helpcenter">The link to the Help Center..</param>
        /// <param name="integrations">The link to the product integrations..</param>
        /// <param name="site">The link to the product website..</param>
        /// <param name="socialNetworks">The link to the product social nerworks..</param>
        /// <param name="support">The link to the product support..</param>
        /// <param name="videoguides">The link to the video guides..</param>
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
        /// The link to the product API.
        /// </summary>
        [DataMember(Name = "api", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Api { get; set; }

        /// <summary>
        /// The link to the common product information.
        /// </summary>
        [DataMember(Name = "common", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Common { get; set; }

        /// <summary>
        /// The link to the forum.
        /// </summary>
        [DataMember(Name = "forum", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Forum { get; set; }

        /// <summary>
        /// The link to the Help Center.
        /// </summary>
        [DataMember(Name = "helpcenter", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Helpcenter { get; set; }

        /// <summary>
        /// The link to the product integrations.
        /// </summary>
        [DataMember(Name = "integrations", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Integrations { get; set; }

        /// <summary>
        /// The link to the product website.
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Site { get; set; }

        /// <summary>
        /// The link to the product social nerworks.
        /// </summary>
        [DataMember(Name = "socialNetworks", EmitDefaultValue = false)]
        public CultureSpecificExternalResource SocialNetworks { get; set; }

        /// <summary>
        /// The link to the product support.
        /// </summary>
        [DataMember(Name = "support", EmitDefaultValue = false)]
        public CultureSpecificExternalResource Support { get; set; }

        /// <summary>
        /// The link to the video guides.
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
