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
    /// The storage information.
    /// </summary>
    [DataContract(Name = "StorageDto")]
    public partial class StorageDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDto" /> class.
        /// </summary>
        /// <param name="id">The storage ID..</param>
        /// <param name="title">The storage title..</param>
        /// <param name="properties">The list of storage authentication keys..</param>
        /// <param name="current">Specifies if this is the current portal storage or not..</param>
        /// <param name="isSet">Specifies if this storage can be set or not..</param>
        public StorageDto(string id = default(string), string title = default(string), List<AuthKey> properties = default(List<AuthKey>), bool current = default(bool), bool isSet = default(bool))
        {
            this.Id = id;
            this.Title = title;
            this.Properties = properties;
            this.Current = current;
            this.IsSet = isSet;
        }

        /// <summary>
        /// The storage ID.
        /// </summary>
        /// <value>The storage ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The storage title.
        /// </summary>
        /// <value>The storage title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The list of storage authentication keys.
        /// </summary>
        /// <value>The list of storage authentication keys.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<AuthKey> Properties { get; set; }

        /// <summary>
        /// Specifies if this is the current portal storage or not.
        /// </summary>
        /// <value>Specifies if this is the current portal storage or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "current", EmitDefaultValue = true)]
        public bool Current { get; set; }

        /// <summary>
        /// Specifies if this storage can be set or not.
        /// </summary>
        /// <value>Specifies if this storage can be set or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isSet", EmitDefaultValue = true)]
        public bool IsSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StorageDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  IsSet: ").Append(IsSet).Append("\n");
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
