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
    /// The parameters of a metadata field update. Every property is optional: a property that is omitted keeps its current value.
    /// </summary>
    [DataContract(Name = "UpdateMetadataFieldRequest")]
    public partial class UpdateMetadataFieldRequest : IValidatableObject
    {

        /// <summary>
        /// The new field type. The type can be changed only while the field has no values.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MetadataFieldType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMetadataFieldRequest" /> class.
        /// </summary>
        /// <param name="name">The new field name..</param>
        /// <param name="type">The new field type. The type can be changed only while the field has no values..</param>
        /// <param name="options">The new choice options of the field. The options in use cannot be removed..</param>
        /// <param name="order">The new display position of the field inside the template: the fields are shown by it ascending..</param>
        public UpdateMetadataFieldRequest(string name = default, MetadataFieldType? type = default, List<MetadataFieldOptionRequest> options = default, int? order = default)
        {
            this.Name = name;
            this.Type = type;
            this.Options = options;
            this.Order = order;
        }

        /// <summary>
        /// The new field name.
        /// </summary>
        /// <example>Contract number</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The new choice options of the field. The options in use cannot be removed.
        /// </summary>
        /// <example>[{"id":"4f1e2d3c-5b6a-4788-99aa-0c1d2e3f4a55","value":"Red"},{"value":"Green"}]</example>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<MetadataFieldOptionRequest> Options { get; set; }

        /// <summary>
        /// The new display position of the field inside the template: the fields are shown by it ascending.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMetadataFieldRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
