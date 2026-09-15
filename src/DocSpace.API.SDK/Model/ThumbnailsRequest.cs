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
    /// The crop rectangle to apply to an avatar image.
    /// </summary>
    [DataContract(Name = "ThumbnailsRequest")]
    public partial class ThumbnailsRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailsRequest" /> class.
        /// </summary>
        /// <param name="tmpFile">The temporary image to crop, as returned in the &#x60;data&#x60; of an upload made with &#x60;autosave&#x60; off. Only the file  name part of the value is used. Omit it to re-crop the photo the profile already has..</param>
        /// <param name="x">The distance in pixels from the left edge of the original image to the left edge of the crop rectangle..</param>
        /// <param name="y">The distance in pixels from the top edge of the original image to the top edge of the crop rectangle..</param>
        /// <param name="width">The width of the crop rectangle in pixels. Passing 0 together with &#x60;height&#x60; and &#x60;tmpFile&#x60; keeps the whole  uploaded image instead of cropping it..</param>
        /// <param name="height">The height of the crop rectangle in pixels. Passing 0 together with &#x60;width&#x60; and &#x60;tmpFile&#x60; keeps the whole  uploaded image instead of cropping it..</param>
        public ThumbnailsRequest(string tmpFile = default, int x = default, int y = default, int width = default, int height = default)
        {
            this.TmpFile = tmpFile;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// The temporary image to crop, as returned in the &#x60;data&#x60; of an upload made with &#x60;autosave&#x60; off. Only the file  name part of the value is used. Omit it to re-crop the photo the profile already has.
        /// </summary>
        /// <example>photo_temp_123.jpg</example>
        [DataMember(Name = "tmpFile", EmitDefaultValue = true)]
        public string TmpFile { get; set; }

        /// <summary>
        /// The distance in pixels from the left edge of the original image to the left edge of the crop rectangle.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The distance in pixels from the top edge of the original image to the top edge of the crop rectangle.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// The width of the crop rectangle in pixels. Passing 0 together with &#x60;height&#x60; and &#x60;tmpFile&#x60; keeps the whole  uploaded image instead of cropping it.
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The height of the crop rectangle in pixels. Passing 0 together with &#x60;width&#x60; and &#x60;tmpFile&#x60; keeps the whole  uploaded image instead of cropping it.
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailsRequest {\n");
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
            yield break;
        }

    }


}
