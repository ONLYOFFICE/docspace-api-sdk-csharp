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
    /// Represents the usage statistics of a single DocsCloud user category (editor or viewer).
    /// </summary>
    [DataContract(Name = "DocsCloudUserStats")]
    public partial class DocsCloudUserStats : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudUserStats" /> class.
        /// </summary>
        /// <param name="active">The number of active users..</param>
        /// <param name="internal">The number of internal users..</param>
        /// <param name="external">The number of external users..</param>
        /// <param name="remaining">The number of remaining users before the limit is reached..</param>
        /// <param name="criticalRemaining">Whether the number of remaining users is critically low..</param>
        public DocsCloudUserStats(int active = default, int @internal = default, int external = default, int remaining = default, bool criticalRemaining = default)
        {
            this.Active = active;
            this.Internal = @internal;
            this.External = external;
            this.Remaining = remaining;
            this.CriticalRemaining = criticalRemaining;
        }

        /// <summary>
        /// The number of active users.
        /// </summary>
        /// <value>The number of active users.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public int Active { get; set; }

        /// <summary>
        /// The number of internal users.
        /// </summary>
        /// <value>The number of internal users.</value>
        /*
        <example>8</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = false)]
        public int Internal { get; set; }

        /// <summary>
        /// The number of external users.
        /// </summary>
        /// <value>The number of external users.</value>
        /*
        <example>2</example>
        */
        [DataMember(Name = "external", EmitDefaultValue = false)]
        public int External { get; set; }

        /// <summary>
        /// The number of remaining users before the limit is reached.
        /// </summary>
        /// <value>The number of remaining users before the limit is reached.</value>
        /*
        <example>90</example>
        */
        [DataMember(Name = "remaining", EmitDefaultValue = false)]
        public int Remaining { get; set; }

        /// <summary>
        /// Whether the number of remaining users is critically low.
        /// </summary>
        /// <value>Whether the number of remaining users is critically low.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "criticalRemaining", EmitDefaultValue = true)]
        public bool CriticalRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudUserStats {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  CriticalRemaining: ").Append(CriticalRemaining).Append("\n");
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
