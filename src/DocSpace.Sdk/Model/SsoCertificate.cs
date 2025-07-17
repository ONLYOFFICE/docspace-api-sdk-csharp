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
    /// The SSO certificate parameters.
    /// </summary>
    [DataContract(Name = "SsoCertificate")]
    public partial class SsoCertificate : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoCertificate" /> class.
        /// </summary>
        /// <param name="selfSigned">Specifies if a certificate is self-signed or not..</param>
        /// <param name="crt">The CRT certificate file..</param>
        /// <param name="key">The certificate key..</param>
        /// <param name="action">The certificate action..</param>
        /// <param name="domainName">The certificate domain name..</param>
        /// <param name="startDate">The certificate start date..</param>
        /// <param name="expiredDate">The certificate expiration date..</param>
        public SsoCertificate(bool selfSigned = default, string crt = default, string key = default, string action = default, string domainName = default, DateTime startDate = default, DateTime expiredDate = default)
        {
            this.SelfSigned = selfSigned;
            this.Crt = crt;
            this.Key = key;
            this.Action = action;
            this.DomainName = domainName;
            this.StartDate = startDate;
            this.ExpiredDate = expiredDate;
        }

        /// <summary>
        /// Specifies if a certificate is self-signed or not.
        /// </summary>
        /// <value>Specifies if a certificate is self-signed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "selfSigned", EmitDefaultValue = true)]
        public bool SelfSigned { get; set; }

        /// <summary>
        /// The CRT certificate file.
        /// </summary>
        /// <value>The CRT certificate file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "crt", EmitDefaultValue = true)]
        public string Crt { get; set; }

        /// <summary>
        /// The certificate key.
        /// </summary>
        /// <value>The certificate key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The certificate action.
        /// </summary>
        /// <value>The certificate action.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The certificate domain name.
        /// </summary>
        /// <value>The certificate domain name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "domainName", EmitDefaultValue = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// The certificate start date.
        /// </summary>
        /// <value>The certificate start date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The certificate expiration date.
        /// </summary>
        /// <value>The certificate expiration date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "expiredDate", EmitDefaultValue = false)]
        public DateTime ExpiredDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoCertificate {\n");
            sb.Append("  SelfSigned: ").Append(SelfSigned).Append("\n");
            sb.Append("  Crt: ").Append(Crt).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
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
