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
    /// The customer config parameters.
    /// </summary>
    [DataContract(Name = "CustomerConfigDto")]
    public partial class CustomerConfigDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerConfigDto" /> class.
        /// </summary>
        /// <param name="address">The address of the customer configuration..</param>
        /// <param name="logo">The logo of the customer configuration..</param>
        /// <param name="logoDark">The dark logo of the customer configuration..</param>
        /// <param name="mail">The mail address of the customer configuration..</param>
        /// <param name="name">The name of the customer configuration..</param>
        /// <param name="www">The site web address of the customer configuration..</param>
        public CustomerConfigDto(string address = default(string), string logo = default(string), string logoDark = default(string), string mail = default(string), string name = default(string), string www = default(string))
        {
            this.Address = address;
            this.Logo = logo;
            this.LogoDark = logoDark;
            this.Mail = mail;
            this.Name = name;
            this.Www = www;
        }

        /// <summary>
        /// The address of the customer configuration.
        /// </summary>
        /// <value>The address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The logo of the customer configuration.
        /// </summary>
        /// <value>The logo of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// The dark logo of the customer configuration.
        /// </summary>
        /// <value>The dark logo of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "logoDark", EmitDefaultValue = true)]
        public string LogoDark { get; set; }

        /// <summary>
        /// The mail address of the customer configuration.
        /// </summary>
        /// <value>The mail address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mail", EmitDefaultValue = true)]
        public string Mail { get; set; }

        /// <summary>
        /// The name of the customer configuration.
        /// </summary>
        /// <value>The name of the customer configuration.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The site web address of the customer configuration.
        /// </summary>
        /// <value>The site web address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "www", EmitDefaultValue = true)]
        public string Www { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerConfigDto {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  LogoDark: ").Append(LogoDark).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Www: ").Append(Www).Append("\n");
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
