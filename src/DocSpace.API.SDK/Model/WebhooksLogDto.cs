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
    /// The webhook log parameters.
    /// </summary>
    [DataContract(Name = "WebhooksLogDto")]
    public partial class WebhooksLogDto : IValidatableObject
    {

        /// <summary>
        /// The webhook trigger type.
        /// </summary>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public WebhookTrigger? Trigger { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksLogDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhooksLogDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksLogDto" /> class.
        /// </summary>
        /// <param name="id">The webhook log ID. (required).</param>
        /// <param name="configName">The webhook configuration name..</param>
        /// <param name="trigger">The webhook trigger type..</param>
        /// <param name="creationTime">The webhook creation time..</param>
        /// <param name="method">The webhook method..</param>
        /// <param name="route">The webhook route..</param>
        /// <param name="requestHeaders">The webhook request headers..</param>
        /// <param name="requestPayload">The webhook request payload..</param>
        /// <param name="responseHeaders">The webhook response headers..</param>
        /// <param name="responsePayload">The webhook response payload..</param>
        /// <param name="status">The webhook status..</param>
        /// <param name="delivery">The webhook delivery time..</param>
        public WebhooksLogDto(int id = default, string configName = default, WebhookTrigger? trigger = default, DateTime creationTime = default, string method = default, string route = default, string requestHeaders = default, string requestPayload = default, string responseHeaders = default, string responsePayload = default, int status = default, DateTime? delivery = default)
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
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The webhook configuration name.
        /// </summary>
        /// <example>Example Name</example>
        [DataMember(Name = "configName", EmitDefaultValue = true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// The webhook creation time.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "creationTime", EmitDefaultValue = false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// The webhook method.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// The webhook route.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// The webhook request headers.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "requestHeaders", EmitDefaultValue = true)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// The webhook request payload.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "requestPayload", EmitDefaultValue = true)]
        public string RequestPayload { get; set; }

        /// <summary>
        /// The webhook response headers.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "responseHeaders", EmitDefaultValue = true)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// The webhook response payload.
        /// </summary>
        /// <example>example value</example>
        [DataMember(Name = "responsePayload", EmitDefaultValue = true)]
        public string ResponsePayload { get; set; }

        /// <summary>
        /// The webhook status.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// The webhook delivery time.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "delivery", EmitDefaultValue = true)]
        public DateTime? Delivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
