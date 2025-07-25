/*
 * Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The paragraph parameters.
    /// </summary>
    [DataContract(Name = "Paragraph")]
    public partial class Paragraph : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paragraph" /> class.
        /// </summary>
        /// <param name="align">The paragraph align..</param>
        /// <param name="runs">The list of text runs from the paragraph..</param>
        public Paragraph(int align = default(int), List<Run> runs = default(List<Run>))
        {
            this.Align = align;
            this.Runs = runs;
        }

        /// <summary>
        /// The paragraph align.
        /// </summary>
        /// <value>The paragraph align.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "align", EmitDefaultValue = false)]
        public int Align { get; set; }

        /// <summary>
        /// The list of text runs from the paragraph.
        /// </summary>
        /// <value>The list of text runs from the paragraph.</value>
        [DataMember(Name = "runs", EmitDefaultValue = true)]
        public List<Run> Runs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Paragraph {\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
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
