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
    /// The request parameters for managing storage encryption operations and notifications.
    /// </summary>
    [DataContract(Name = "StorageEncryptionRequestsDto")]
    public partial class StorageEncryptionRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageEncryptionRequestsDto" /> class.
        /// </summary>
        /// <param name="notifyUsers">Specifies whether the users receive notifications about the storage encryption operations..</param>
        public StorageEncryptionRequestsDto(bool notifyUsers = default(bool))
        {
            this.NotifyUsers = notifyUsers;
        }

        /// <summary>
        /// Specifies whether the users receive notifications about the storage encryption operations.
        /// </summary>
        /// <value>Specifies whether the users receive notifications about the storage encryption operations.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notifyUsers", EmitDefaultValue = true)]
        public bool NotifyUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StorageEncryptionRequestsDto {\n");
            sb.Append("  NotifyUsers: ").Append(NotifyUsers).Append("\n");
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
