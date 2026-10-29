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
    /// One delivery of a webhook event, updated in place by its automatic retries: what was sent where, and what came  back the last time. A manual retry is a delivery record of its own for the same event.
    /// </summary>
    [DataContract(Name = "WebhooksLogDto")]
    public partial class WebhooksLogDto : IValidatableObject
    {

        /// <summary>
        /// The event that caused the delivery, as a single bit rather than a mask - a delivery is always for one  event, even though a subscription covers several.
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
        /// <param name="id">The identifier of this delivery record, which is what &#x60;PUT api/2.0/settings/webhook/{id}/retry&#x60; re-sends.  The automatic retries of the delivery update this same record, while a manual retry gets a record and an  identifier of its own. (required).</param>
        /// <param name="eventId">The identifier of the event the delivery is for, which the receiver sees as &#x60;event.id&#x60; and in the  &#x60;x-docspace-event-id&#x60; header. It is the &#x60;id&#x60; of the event&#39;s first delivery record, so it equals &#x60;id&#x60; there and  stays the same on every manual retry, which makes it the value to group the records of one event by..</param>
        /// <param name="retriedBy">The member who asked for this delivery with a manual retry. It is empty on the first delivery of an event,  which the portal sends by itself..</param>
        /// <param name="configName">The name of the subscription the delivery belongs to. It is the name as it stands now, so it follows a  later rename of the subscription rather than recording what it was called at the time..</param>
        /// <param name="trigger">The event that caused the delivery, as a single bit rather than a mask - a delivery is always for one  event, even though a subscription covers several..</param>
        /// <param name="creationTime">When this delivery record was queued, as a UTC instant ending in &#x60;Z&#x60;. For the first delivery that is when the  event happened; for a manual retry it is the  moment of the retry. Records come back newest first by this moment..</param>
        /// <param name="method">The HTTP method the delivery was sent with, which is &#x60;POST&#x60; for every webhook the portal sends..</param>
        /// <param name="route">The address the delivery is sent to: the subscription&#39;s URL as it stands now. The journal does not keep the  address of each attempt, so after the subscription&#39;s URL changes, an older record names the new one too..</param>
        /// <param name="requestHeaders">The headers the portal sent, serialised as one string, including the signature header a receiver verifies  the payload with..</param>
        /// <param name="requestPayload">The body the portal sent, which is the event payload as JSON text. It is stored as it was sent, so it  still describes the entity as it looked at the time of the event..</param>
        /// <param name="responseHeaders">The headers the target answered with on the latest attempt, serialised the same way as &#x60;requestHeaders&#x60;. It  is empty until an attempt is answered, and when the target was not reached..</param>
        /// <param name="responsePayload">The body the target answered with on the latest attempt, truncated for storage. Empty under the same  conditions as &#x60;responseHeaders&#x60;, and also for a target that answers with no body at all. A record the portal  stopped without sending holds the portal&#39;s own note here instead - a text that starts with &#x60;Not sent:&#x60; and  gives the reason - which is not an answer of the target: on a record that never went out &#x60;status&#x60; is then &#x60;0&#x60;  and &#x60;responseHeaders&#x60; is empty, while on one stopped after failed attempts they still describe the last of them..</param>
        /// <param name="status">The HTTP status code the target answered on the latest attempt. It is &#x60;0&#x60; while the first attempt is still  on its way and on one that never reached the target, so &#x60;0&#x60; is not a failure code - it is the absence of an  answer. While &#x60;nextAttemptOn&#x60; is set it is the status of the failed attempt that caused the retry..</param>
        /// <param name="delivery">When the successful answer came back, as a UTC instant ending in &#x60;Z&#x60; like &#x60;creationTime&#x60;. It stays empty until an  attempt succeeds, and for good once the portal has given up retrying..</param>
        /// <param name="attempts">How many times the portal has tried to deliver this record so far. A failed attempt is retried with  growing pauses - on the default schedule about 1 minute, 5 minutes, 30 minutes, 2, 5 and 10 hours, though  an installation may configure its own - all of them under the same record and the same  &#x60;x-docspace-event-id&#x60; header, so a receiver can drop a delivery it has already processed. The one exception  is a portal moved to another region while retries are pending: the moved records get new IDs, so the attempts  made there carry a new &#x60;x-docspace-event-id&#x60;..</param>
        /// <param name="nextAttemptOn">When the next attempt is due, as a UTC instant ending in &#x60;Z&#x60; like &#x60;creationTime&#x60;. While an attempt is being sent  right now it holds the moment that attempt&#39;s lease expires, a few minutes ahead, rather than a scheduled retry;  it changes again once the attempt ends. Empty means no attempt will follow: the record is delivered, its retries  ran out, a manual retry of the same event took over from it, or the portal stopped it - because the subscription  was disabled or removed or its address rejected, the subscription&#39;s creator may no longer receive the event,  the stored body cannot be read or is in the payload format of a previous version, the portal is removed, the  record waited longer than the retry schedule allows, the portal was restored from a backup taken before the  record was answered, or the portal was moved to another region while the record was being sent. A stopped  record that was never attempted says why in &#x60;responsePayload&#x60;; one that was keeps the target&#39;s last answer there..</param>
        public WebhooksLogDto(int id = default, int eventId = default, EmployeeDto retriedBy = default, string configName = default, WebhookTrigger? trigger = default, DateTime creationTime = default, string method = default, string route = default, string requestHeaders = default, string requestPayload = default, string responseHeaders = default, string responsePayload = default, int status = default, DateTime? delivery = default, int attempts = default, DateTime? nextAttemptOn = default)
        {
            this.Id = id;
            this.EventId = eventId;
            this.RetriedBy = retriedBy;
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
            this.Attempts = attempts;
            this.NextAttemptOn = nextAttemptOn;
        }

        /// <summary>
        /// The identifier of this delivery record, which is what &#x60;PUT api/2.0/settings/webhook/{id}/retry&#x60; re-sends.  The automatic retries of the delivery update this same record, while a manual retry gets a record and an  identifier of its own.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The identifier of the event the delivery is for, which the receiver sees as &#x60;event.id&#x60; and in the  &#x60;x-docspace-event-id&#x60; header. It is the &#x60;id&#x60; of the event&#39;s first delivery record, so it equals &#x60;id&#x60; there and  stays the same on every manual retry, which makes it the value to group the records of one event by.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        public int EventId { get; set; }

        /// <summary>
        /// The member who asked for this delivery with a manual retry. It is empty on the first delivery of an event,  which the portal sends by itself.
        /// </summary>
        [DataMember(Name = "retriedBy", EmitDefaultValue = false)]
        public EmployeeDto RetriedBy { get; set; }

        /// <summary>
        /// The name of the subscription the delivery belongs to. It is the name as it stands now, so it follows a  later rename of the subscription rather than recording what it was called at the time.
        /// </summary>
        /// <example>Room activity</example>
        [DataMember(Name = "configName", EmitDefaultValue = true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// When this delivery record was queued, as a UTC instant ending in &#x60;Z&#x60;. For the first delivery that is when the  event happened; for a manual retry it is the  moment of the retry. Records come back newest first by this moment.
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
        /// The address the delivery is sent to: the subscription&#39;s URL as it stands now. The journal does not keep the  address of each attempt, so after the subscription&#39;s URL changes, an older record names the new one too.
        /// </summary>
        /// <example>https://example.com/hooks/docspace</example>
        [DataMember(Name = "route", EmitDefaultValue = true)]
        public string Route { get; set; }

        /// <summary>
        /// The headers the portal sent, serialised as one string, including the signature header a receiver verifies  the payload with.
        /// </summary>
        /// <example>{"Accept":["*/*"],"x-docspace-event-id":["1"],"x-docspace-event-timestamp":["2024-01-15T10:30:00Z"],"x-docspace-signature-256":["sha256=9F86D081884C7D659A2FEAA0C55AD015A3BF4F1B2B0B822CD15D6C15B0F00A08"]}</example>
        [DataMember(Name = "requestHeaders", EmitDefaultValue = true)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// The body the portal sent, which is the event payload as JSON text. It is stored as it was sent, so it  still describes the entity as it looked at the time of the event.
        /// </summary>
        /// <example>{"event":{"id":1,"createOn":"2024-01-15T10:30:00Z","trigger":"file.created","triggerId":128},"payload":{"id":42,"title":"Report.docx"},"webhook":{"id":7,"name":"Room activity"}}</example>
        [DataMember(Name = "requestPayload", EmitDefaultValue = true)]
        public string RequestPayload { get; set; }

        /// <summary>
        /// The headers the target answered with on the latest attempt, serialised the same way as &#x60;requestHeaders&#x60;. It  is empty until an attempt is answered, and when the target was not reached.
        /// </summary>
        /// <example>{"content-type":"application/json"}</example>
        [DataMember(Name = "responseHeaders", EmitDefaultValue = true)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// The body the target answered with on the latest attempt, truncated for storage. Empty under the same  conditions as &#x60;responseHeaders&#x60;, and also for a target that answers with no body at all. A record the portal  stopped without sending holds the portal&#39;s own note here instead - a text that starts with &#x60;Not sent:&#x60; and  gives the reason - which is not an answer of the target: on a record that never went out &#x60;status&#x60; is then &#x60;0&#x60;  and &#x60;responseHeaders&#x60; is empty, while on one stopped after failed attempts they still describe the last of them.
        /// </summary>
        /// <example>{"ok":true}</example>
        [DataMember(Name = "responsePayload", EmitDefaultValue = true)]
        public string ResponsePayload { get; set; }

        /// <summary>
        /// The HTTP status code the target answered on the latest attempt. It is &#x60;0&#x60; while the first attempt is still  on its way and on one that never reached the target, so &#x60;0&#x60; is not a failure code - it is the absence of an  answer. While &#x60;nextAttemptOn&#x60; is set it is the status of the failed attempt that caused the retry.
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// When the successful answer came back, as a UTC instant ending in &#x60;Z&#x60; like &#x60;creationTime&#x60;. It stays empty until an  attempt succeeds, and for good once the portal has given up retrying.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "delivery", EmitDefaultValue = true)]
        public DateTime? Delivery { get; set; }

        /// <summary>
        /// How many times the portal has tried to deliver this record so far. A failed attempt is retried with  growing pauses - on the default schedule about 1 minute, 5 minutes, 30 minutes, 2, 5 and 10 hours, though  an installation may configure its own - all of them under the same record and the same  &#x60;x-docspace-event-id&#x60; header, so a receiver can drop a delivery it has already processed. The one exception  is a portal moved to another region while retries are pending: the moved records get new IDs, so the attempts  made there carry a new &#x60;x-docspace-event-id&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "attempts", EmitDefaultValue = false)]
        public int Attempts { get; set; }

        /// <summary>
        /// When the next attempt is due, as a UTC instant ending in &#x60;Z&#x60; like &#x60;creationTime&#x60;. While an attempt is being sent  right now it holds the moment that attempt&#39;s lease expires, a few minutes ahead, rather than a scheduled retry;  it changes again once the attempt ends. Empty means no attempt will follow: the record is delivered, its retries  ran out, a manual retry of the same event took over from it, or the portal stopped it - because the subscription  was disabled or removed or its address rejected, the subscription&#39;s creator may no longer receive the event,  the stored body cannot be read or is in the payload format of a previous version, the portal is removed, the  record waited longer than the retry schedule allows, the portal was restored from a backup taken before the  record was answered, or the portal was moved to another region while the record was being sent. A stopped  record that was never attempted says why in &#x60;responsePayload&#x60;; one that was keeps the target&#39;s last answer there.
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [DataMember(Name = "nextAttemptOn", EmitDefaultValue = true)]
        public DateTime? NextAttemptOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhooksLogDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  RetriedBy: ").Append(RetriedBy).Append("\n");
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
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  NextAttemptOn: ").Append(NextAttemptOn).Append("\n");
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
