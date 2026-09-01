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
    /// The logo request parameters.
    /// </summary>
    [DataContract(Name = "LogoRequest")]
    public partial class LogoRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogoRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoRequest" /> class.
        /// </summary>
        /// <param name="tmpFile">The path to the temporary image file. (required).</param>
        /// <param name="x">The X coordinate of the rectangle starting point..</param>
        /// <param name="y">The Y coordinate of the rectangle starting point..</param>
        /// <param name="width">The rectangle width..</param>
        /// <param name="height">The rectangle height..</param>
        public LogoRequest(string tmpFile = default, int x = default, int y = default, int width = default, int height = default)
        {
            // to ensure "tmpFile" is required (not null)
            if (tmpFile == null)
            {
                throw new ArgumentNullException("tmpFile is a required property for LogoRequest and cannot be null");
            }
            this.TmpFile = tmpFile;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// The path to the temporary image file.
        /// </summary>
        /// <example>/tmp/logo.png</example>
        [DataMember(Name = "tmpFile", IsRequired = true, EmitDefaultValue = true)]
        public string TmpFile { get; set; }

        /// <summary>
        /// The X coordinate of the rectangle starting point.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The Y coordinate of the rectangle starting point.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// The rectangle width.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The rectangle height.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoRequest {\n");
            sb.Append("  TmpFile: ").Append(TmpFile).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            // TmpFile (string) minLength
            if (this.TmpFile != null && this.TmpFile.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TmpFile, length must be greater than 1.", new [] { "TmpFile" });
            }

            // X (int) maximum
            if (this.X > (int)1280)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for X, must be a value less than or equal to 1280.", new [] { "X" });
            }

            // X (int) minimum
            if (this.X < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for X, must be a value greater than or equal to 0.", new [] { "X" });
            }

            // Y (int) maximum
            if (this.Y > (int)1280)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Y, must be a value less than or equal to 1280.", new [] { "Y" });
            }

            // Y (int) minimum
            if (this.Y < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Y, must be a value greater than or equal to 0.", new [] { "Y" });
            }

            // Width (int) maximum
            if (this.Width > (int)1280)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value less than or equal to 1280.", new [] { "Width" });
            }

            // Width (int) minimum
            if (this.Width < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value greater than or equal to 1.", new [] { "Width" });
            }

            // Height (int) maximum
            if (this.Height > (int)1280)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value less than or equal to 1280.", new [] { "Height" });
            }

            // Height (int) minimum
            if (this.Height < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value greater than or equal to 1.", new [] { "Height" });
            }

            yield break;
        }

    }


}
