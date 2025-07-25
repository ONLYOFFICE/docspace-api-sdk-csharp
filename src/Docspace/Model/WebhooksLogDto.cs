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
    /// The webhook log parameters.
    /// </summary>
    [DataContract(Name = "WebhooksLogDto")]
    public partial class WebhooksLogDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public WebhookTrigger? Trigger { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksLogDto" /> class.
        /// </summary>
        /// <param name="id">The webhook log ID..</param>
        /// <param name="configName">The webhook configuration name..</param>
        /// <param name="trigger">trigger.</param>
        /// <param name="creationTime">The webhook creation time..</param>
        /// <param name="method">The webhook method..</param>
        /// <param name="route">The webhook route..</param>
        /// <param name="requestHeaders">The webhook request headers..</param>
        /// <param name="requestPayload">The webhook request payload..</param>
        /// <param name="responseHeaders">The webhook response headers..</param>
        /// <param name="responsePayload">The webhook response payload..</param>
        /// <param name="status">The webhook status..</param>
        /// <param name="delivery">The webhook delivery time..</param>
        public WebhooksLogDto(int id = default(int), string configName = default(string), WebhookTrigger? trigger = default(WebhookTrigger?), DateTime creationTime = default(DateTime), string method = default(string), string route = default(string), string requestHeaders = default(string), string requestPayload = default(string), string responseHeaders = default(string), string responsePayload = default(string), int status = default(int), DateTime? delivery = default(DateTime?))
        {
            this.Id = id;
            this.ConfigName = configName;
            this.Trigger = trigger;
            this.CreationTime = creationTime;
            this.Method = method;
            this.Route = route;
            this.RequestHeaders = requestHeaders;
            this.RequestPayload = requestPayload;
            this.ResponseHeaders = responseHeaders;
            this.ResponsePayload = responsePayload;
            this.Status = status;
            this.Delivery = delivery;
        }

        /// <summary>
        /// The webhook log ID.
        /// </summary>
        /// <value>The webhook log ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The webhook configuration name.
        /// </summary>
        /// <value>The webhook configuration name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "configName", EmitDefaultValue = true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// The webhook creation time.
        /// </summary>
        /// <value>The webhook creation time.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "creationTime", EmitDefaultValue = false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// The webhook method.
        /// </summary>
        /// <value>The webhook method.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// The webhook route.
        /// </summary>
        /// <value>The webhook route.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// The webhook request headers.
        /// </summary>
        /// <value>The webhook request headers.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "requestHeaders", EmitDefaultValue = true)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// The webhook request payload.
        /// </summary>
        /// <value>The webhook request payload.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "requestPayload", EmitDefaultValue = true)]
        public string RequestPayload { get; set; }

        /// <summary>
        /// The webhook response headers.
        /// </summary>
        /// <value>The webhook response headers.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "responseHeaders", EmitDefaultValue = true)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// The webhook response payload.
        /// </summary>
        /// <value>The webhook response payload.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "responsePayload", EmitDefaultValue = true)]
        public string ResponsePayload { get; set; }

        /// <summary>
        /// The webhook status.
        /// </summary>
        /// <value>The webhook status.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// The webhook delivery time.
        /// </summary>
        /// <value>The webhook delivery time.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "delivery", EmitDefaultValue = true)]
        public DateTime? Delivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksLogDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfigName: ").Append(ConfigName).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestPayload: ").Append(RequestPayload).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  ResponsePayload: ").Append(ResponsePayload).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
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
