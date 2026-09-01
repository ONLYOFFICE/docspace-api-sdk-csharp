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
    /// The parameters for updating a comment.
    /// </summary>
    [DataContract(Name = "UpdateComment")]
    public partial class UpdateComment : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateComment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComment" /> class.
        /// </summary>
        /// <param name="version">The comment version. (required).</param>
        /// <param name="comment">The comment text..</param>
        public UpdateComment(int version = default, string comment = default)
        {
            this.@Version = version;
            this.Comment = comment;
        }

        /// <summary>
        /// The comment version.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// The comment text.
        /// </summary>
        /// <example>This is a comment</example>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateComment {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            // @Version (int) maximum
            if (this.@Version > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for @Version, must be a value less than or equal to 2147483647.", new [] { "@Version" });
            }

            // @Version (int) minimum
            if (this.@Version < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for @Version, must be a value greater than or equal to 1.", new [] { "@Version" });
            }

            // Comment (string) maxLength
            if (this.Comment != null && this.Comment.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comment, length must be less than 255.", new [] { "Comment" });
            }

            // Comment (string) minLength
            if (this.Comment != null && this.Comment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comment, length must be greater than 0.", new [] { "Comment" });
            }

            yield break;
        }

    }


}
