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
    /// One delivery attempt of a webhook: what was sent where, and what came back.
    /// </summary>
    [DataContract(Name = "WebhooksLogDto")]
    public partial class WebhooksLogDto : IValidatableObject
    {

        /// <summary>
        /// The event that caused the attempt, as a single bit rather than a mask - a delivery is always for one  event, even though a subscription covers several.
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
        /// <param name="id">The identifier of this attempt, which is what the &#x60;eventId&#x60; filter of  &#x60;GET api/2.0/settings/webhooks/log&#x60; picks one record by and what  &#x60;PUT api/2.0/settings/webhook/{id}/retry&#x60; re-sends. A retry produces a new record with a new identifier  and leaves this one as it is. (required).</param>
        /// <param name="configName">The name of the subscription the attempt belongs to. It is the name as it stands now, so it follows a  later rename of the subscription rather than recording what it was called at the time..</param>
        /// <param name="trigger">The event that caused the attempt, as a single bit rather than a mask - a delivery is always for one  event, even though a subscription covers several..</param>
        /// <param name="creationTime">When the attempt was queued, as a UTC instant - unlike the dates of the subscription itself, which come  in the portal time zone. Records come back newest first by this moment..</param>
        /// <param name="method">The HTTP method the delivery was sent with, which is &#x60;POST&#x60; for every webhook the portal sends..</param>
        /// <param name="route">The address the delivery was sent to, which is the subscription&#39;s URL as it stood at the time - so an  older record can name an address the subscription no longer uses..</param>
        /// <param name="requestHeaders">The headers the portal sent, serialised as one string, including the signature header a receiver verifies  the payload with..</param>
        /// <param name="requestPayload">The body the portal sent, which is the event payload as JSON text. It is stored as it was sent, so it  still describes the entity as it looked at the time of the event..</param>
        /// <param name="responseHeaders">The headers the target answered with, serialised the same way as &#x60;requestHeaders&#x60;. It is empty while the  attempt is still on its way and on an attempt that never reached the target..</param>
        /// <param name="responsePayload">The body the target answered with, truncated for storage. Empty under the same conditions as  &#x60;responseHeaders&#x60;, and also for a target that answers with no body at all..</param>
        /// <param name="status">The HTTP status code the target answered. It is &#x60;0&#x60; while the attempt is still on its way and on one that  never reached the target, so &#x60;0&#x60; is not a failure code - it is the absence of an answer..</param>
        /// <param name="delivery">When the answer came back, as a UTC instant like &#x60;creationTime&#x60;. It is empty while the attempt is still on  its way, which together with &#x60;status&#x60; is how a pending record is told from a finished one..</param>
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
        /// The identifier of this attempt, which is what the &#x60;eventId&#x60; filter of  &#x60;GET api/2.0/settings/webhooks/log&#x60; picks one record by and what  &#x60;PUT api/2.0/settings/webhook/{id}/retry&#x60; re-sends. A retry produces a new record with a new identifier  and leaves this one as it is.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the subscription the attempt belongs to. It is the name as it stands now, so it follows a  later rename of the subscription rather than recording what it was called at the time.
        /// </summary>
        /// <example>Room activity</example>
        [DataMember(Name = "configName", EmitDefaultValue = true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// When the attempt was queued, as a UTC instant - unlike the dates of the subscription itself, which come  in the portal time zone. Records come back newest first by this moment.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "creationTime", EmitDefaultValue = false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// The HTTP method the delivery was sent with, which is &#x60;POST&#x60; for every webhook the portal sends.
        /// </summary>
        /// <example>POST</example>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// The address the delivery was sent to, which is the subscription&#39;s URL as it stood at the time - so an  older record can name an address the subscription no longer uses.
        /// </summary>
        /// <example>https://example.com/hooks/docspace</example>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// The headers the portal sent, serialised as one string, including the signature header a receiver verifies  the payload with.
        /// </summary>
        /// <example>{"x-docspace-signature":"9f86d081884c7d65"}</example>
        [DataMember(Name = "requestHeaders", EmitDefaultValue = true)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// The body the portal sent, which is the event payload as JSON text. It is stored as it was sent, so it  still describes the entity as it looked at the time of the event.
        /// </summary>
        /// <example>{"id":42,"title":"report.docx"}</example>
        [DataMember(Name = "requestPayload", EmitDefaultValue = true)]
        public string RequestPayload { get; set; }

        /// <summary>
        /// The headers the target answered with, serialised the same way as &#x60;requestHeaders&#x60;. It is empty while the  attempt is still on its way and on an attempt that never reached the target.
        /// </summary>
        /// <example>{"content-type":"application/json"}</example>
        [DataMember(Name = "responseHeaders", EmitDefaultValue = true)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// The body the target answered with, truncated for storage. Empty under the same conditions as  &#x60;responseHeaders&#x60;, and also for a target that answers with no body at all.
        /// </summary>
        /// <example>{"ok":true}</example>
        [DataMember(Name = "responsePayload", EmitDefaultValue = true)]
        public string ResponsePayload { get; set; }

        /// <summary>
        /// The HTTP status code the target answered. It is &#x60;0&#x60; while the attempt is still on its way and on one that  never reached the target, so &#x60;0&#x60; is not a failure code - it is the absence of an answer.
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// When the answer came back, as a UTC instant like &#x60;creationTime&#x60;. It is empty while the attempt is still on  its way, which together with &#x60;status&#x60; is how a pending record is told from a finished one.
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
