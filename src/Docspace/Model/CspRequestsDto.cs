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
    /// The request parameters for configuring the Content Security Policy (CSP) settings.
    /// </summary>
    [DataContract(Name = "CspRequestsDto")]
    public partial class CspRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CspRequestsDto" /> class.
        /// </summary>
        /// <param name="domains">The collection of allowed domains in the Content Security Policy (CSP)..</param>
        public CspRequestsDto(List<string> domains = default(List<string>))
        {
            this.Domains = domains;
        }

        /// <summary>
        /// The collection of allowed domains in the Content Security Policy (CSP).
        /// </summary>
        /// <value>The collection of allowed domains in the Content Security Policy (CSP).</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CspRequestsDto {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
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
