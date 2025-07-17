/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The product administrator parameters.
    /// </summary>
    [DataContract(Name = "ProductAdministratorDto")]
    public partial class ProductAdministratorDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAdministratorDto" /> class.
        /// </summary>
        /// <param name="productId">The product ID..</param>
        /// <param name="userId">The user unique identifier..</param>
        /// <param name="administrator">Indicates whether the user has administrator privileges for the product..</param>
        public ProductAdministratorDto(Guid productId = default, Guid userId = default, bool administrator = default)
        {
            this.ProductId = productId;
            this.UserId = userId;
            this.Administrator = administrator;
        }

        /// <summary>
        /// The product ID.
        /// </summary>
        /// <value>The product ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public Guid ProductId { get; set; }

        /// <summary>
        /// The user unique identifier.
        /// </summary>
        /// <value>The user unique identifier.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Indicates whether the user has administrator privileges for the product.
        /// </summary>
        /// <value>Indicates whether the user has administrator privileges for the product.</value>
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
            var sb = new StringBuilder();
            sb.Append("class ProductAdministratorDto {\n");
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
