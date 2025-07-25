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
    /// The request parameters for managing user security and access permissions.
    /// </summary>
    [DataContract(Name = "SecurityRequestsDto")]
    public partial class SecurityRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRequestsDto" /> class.
        /// </summary>
        /// <param name="productId">The product ID for which permissions are being set. (required).</param>
        /// <param name="userId">The ID of the user whose permissions are being configured. (required).</param>
        /// <param name="administrator">Specifies whether the user has administrative privileges..</param>
        public SecurityRequestsDto(Guid productId = default(Guid), Guid userId = default(Guid), bool administrator = default(bool))
        {
            this.ProductId = productId;
            this.UserId = userId;
            this.Administrator = administrator;
        }

        /// <summary>
        /// The product ID for which permissions are being set.
        /// </summary>
        /// <value>The product ID for which permissions are being set.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProductId { get; set; }

        /// <summary>
        /// The ID of the user whose permissions are being configured.
        /// </summary>
        /// <value>The ID of the user whose permissions are being configured.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Specifies whether the user has administrative privileges.
        /// </summary>
        /// <value>Specifies whether the user has administrative privileges.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "administrator", EmitDefaultValue = true)]
        public bool Administrator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityRequestsDto {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Administrator: ").Append(Administrator).Append("\n");
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
