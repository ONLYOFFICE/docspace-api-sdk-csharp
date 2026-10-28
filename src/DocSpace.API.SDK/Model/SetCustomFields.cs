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
    /// The parameters for setting custom fields.
    /// </summary>
    [DataContract(Name = "SetCustomFields")]
    public partial class SetCustomFields : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetCustomFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetCustomFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetCustomFields" /> class.
        /// </summary>
        /// <param name="fields">The custom fields to set on the entry. A listed field gets the value, a null or empty value removes the field  from the entry, the fields not listed are left alone. A name the portal has not seen yet creates the field. (required).</param>
        public SetCustomFields(List<CustomFieldRequest> fields = default)
        {
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for SetCustomFields and cannot be null");
            }
            this.Fields = fields;
        }

        /// <summary>
        /// The custom fields to set on the entry. A listed field gets the value, a null or empty value removes the field  from the entry, the fields not listed are left alone. A name the portal has not seen yet creates the field.
        /// </summary>
        /// <example>[{"name":"Project code","value":"A-42"},{"name":"Client"}]</example>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomFieldRequest> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetCustomFields {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
