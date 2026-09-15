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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.Settings
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper CreateWebhook(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> CreateWebhookWithHttpInfo(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default);
        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper EnableWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> EnableWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);
        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>WebhooksConfigWithStatusArrayWrapper</returns>
        WebhooksConfigWithStatusArrayWrapper GetTenantWebhooks();

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWithStatusArrayWrapper</returns>
        ApiResponse<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksWithHttpInfo();
        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>WebhookTriggerArrayWrapper</returns>
        WebhookTriggerArrayWrapper GetWebhookTriggers();

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>ApiResponse of WebhookTriggerArrayWrapper</returns>
        ApiResponse<WebhookTriggerArrayWrapper> GetWebhookTriggersWithHttpInfo();
        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        WebhooksLogArrayWrapper GetWebhooksLogs(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        ApiResponse<WebhooksLogArrayWrapper> GetWebhooksLogsWithHttpInfo(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper RemoveWebhook(int id);

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> RemoveWebhookWithHttpInfo(int id);
        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>WebhooksLogWrapper</returns>
        WebhooksLogWrapper RetryWebhook(int id);

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogWrapper</returns>
        ApiResponse<WebhooksLogWrapper> RetryWebhookWithHttpInfo(int id);
        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        WebhooksLogArrayWrapper RetryWebhooks(WebhookRetryRequestsDto? webhookRetryRequestsDto = default);

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        ApiResponse<WebhooksLogArrayWrapper> RetryWebhooksWithHttpInfo(WebhookRetryRequestsDto? webhookRetryRequestsDto = default);
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper UpdateWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> UpdateWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> CreateWebhookAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> CreateWebhookWithHttpInfoAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> EnableWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> EnableWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of WebhooksConfigWithStatusArrayWrapper</returns>
        Task<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWithStatusArrayWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWithStatusArrayWrapper>> GetTenantWebhooksWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of WebhookTriggerArrayWrapper</returns>
        Task<WebhookTriggerArrayWrapper> GetWebhookTriggersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of ApiResponse (WebhookTriggerArrayWrapper)</returns>
        Task<ApiResponse<WebhookTriggerArrayWrapper>> GetWebhookTriggersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        Task<WebhooksLogArrayWrapper> GetWebhooksLogsAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        Task<ApiResponse<WebhooksLogArrayWrapper>> GetWebhooksLogsWithHttpInfoAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> RemoveWebhookAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> RemoveWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of WebhooksLogWrapper</returns>
        Task<WebhooksLogWrapper> RetryWebhookAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogWrapper)</returns>
        Task<ApiResponse<WebhooksLogWrapper>> RetryWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        Task<WebhooksLogArrayWrapper> RetryWebhooksAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        Task<ApiResponse<WebhooksLogArrayWrapper>> RetryWebhooksWithHttpInfoAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> UpdateWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> UpdateWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApi : IWebhooksApiSync, IWebhooksApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IDisposable, IWebhooksApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public WebhooksApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public WebhooksApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WebhooksApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WebhooksApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WebhooksApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public WebhooksApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }

        private string? _fields;

        /// <summary>
        /// Specifies which fields should be included in the API response.
        /// </summary>
        /// <param name="fields">A comma-separated list of field paths to include in the response</param>
        /// <returns></returns>

        public WebhooksApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper CreateWebhook(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = CreateWebhookWithHttpInfo(createWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> CreateWebhookWithHttpInfo(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = createWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> CreateWebhookAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateWebhookWithHttpInfoAsync(createWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a webhook subscription for the current portal: a target URL that the portal calls with a signed JSON  payload whenever one of the subscribed events happens. The target is checked before anything is stored, so it  has to be an absolute `http` or `https` address outside the installation's own network, and it has to answer a  HEAD request with a success code, redirects not being followed. `secretKey` is mandatory here, has to satisfy  the portal password rules published by `GET api/2.0/settings/security/password`, and signs the payloads; it  does not appear in any response. `triggers` is a bitmask of the subscribed events with 0 standing for all of  them; a flag the caller's role may not use is rejected, so take the allowed set from  `GET api/2.0/settings/webhook/triggers`. `ssl=true` additionally demands an `https` target with a valid  certificate, while `ssl=false` leaves the certificate unchecked. Set `targetId` to deliver events about a  single entity only. A subscription fires only for events its creator is allowed to see, and only while it is  enabled. Any role except `Guest` may create one, and each call adds another subscription rather than replacing  an existing one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The target a webhook subscription calls, the events it listens for, and the secret it signs with. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> CreateWebhookWithHttpInfoAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = createWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper EnableWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = EnableWebhookWithHttpInfo(updateWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> EnableWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WebhooksConfigWrapper>("/api/2.0/settings/webhook/enable", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> EnableWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await EnableWebhookWithHttpInfoAsync(updateWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch a webhook on or off
        /// </summary>
        /// <remarks>
        /// Switches one webhook subscription on or off, leaving the rest of its parameters as they are. Only `id` and  `enabled` are read from the body: `name`, `uri`, `secretKey`, `ssl`, `triggers` and `targetId` are demanded by  the schema but ignored here, so change any of them with `PUT api/2.0/settings/webhook` instead. Switching a  subscription on re-checks what is already stored, probing the saved URL with a HEAD request and re-validating  the saved secret against the current portal password rules, and the call is refused with 400 when either  fails: a subscription whose target has gone away, or whose secret predates a tightening of the password rules,  cannot be switched on until it is updated. Switching one off is not validated. While a subscription is off its  events are dropped rather than queued, so nothing arrives from that period once it is switched on again. A  `DocSpaceAdmin` may switch any subscription in the portal, anyone else only their own, and a `Guest` is  refused. The response carries the subscription in its new state, and repeating the call changes nothing  further.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> EnableWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook/enable", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>WebhooksConfigWithStatusArrayWrapper</returns>
        public WebhooksConfigWithStatusArrayWrapper GetTenantWebhooks()
        {
            var localVarResponse = GetTenantWebhooksWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWithStatusArrayWrapper</returns>
        public ApiResponse<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<WebhooksConfigWithStatusArrayWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWebhooks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of WebhooksConfigWithStatusArrayWrapper</returns>
        public async Task<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantWebhooksWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal webhooks
        /// </summary>
        /// <remarks>
        /// Returns the webhook subscriptions of the current portal, each together with the outcome of its most recent  delivery. The portal owner and a `DocSpaceAdmin` see every subscription in the portal, while a `RoomAdmin` or  a `User` sees only the ones they created themselves, so the same call answers differently depending on who  asks. A `Guest` may not use webhooks at all and is refused, and so is any non-admin caller while the portal  keeps the developer tools restricted, which `GET api/2.0/settings/devtoolsaccess` reports. Every entry pairs  the stored configuration with `status`, the HTTP status code the target answered on the last attempt, where 0  means nothing has been delivered yet, while the secret key is not part of the response. The list is neither  paginated nor ordered, and an empty list simply means no subscription exists for the caller. Nothing is  written and the call is safe to repeat. Create a subscription with `POST api/2.0/settings/webhook`, and  inspect single deliveries with `GET api/2.0/settings/webhooks/log`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWithStatusArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWithStatusArrayWrapper>> GetTenantWebhooksWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<WebhooksConfigWithStatusArrayWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWebhooks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>WebhookTriggerArrayWrapper</returns>
        public WebhookTriggerArrayWrapper GetWebhookTriggers()
        {
            var localVarResponse = GetWebhookTriggersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>ApiResponse of WebhookTriggerArrayWrapper</returns>
        public ApiResponse<WebhookTriggerArrayWrapper> GetWebhookTriggersWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<WebhookTriggerArrayWrapper>("/api/2.0/settings/webhook/triggers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhookTriggers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of WebhookTriggerArrayWrapper</returns>
        public async Task<WebhookTriggerArrayWrapper> GetWebhookTriggersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWebhookTriggersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns the catalogue of events a webhook subscription can listen to, in the order the portal presents them:  user events, then group, file, folder, room, form and agent ones. Each entry carries the event name as it  appears in a payload, such as `file.created`, the bit value to put into the `triggers` bitmask of a  subscription, and `available`, telling whether the caller's own role may subscribe to that event at all: a  `User` cannot subscribe to the creation of users, groups or rooms, for instance, while a `RoomAdmin` can. Add  the bit values of the wanted events together to build `triggers`; the entry named `*` has the value 0 and  stands for every event, so it is used on its own rather than added. Events unavailable to the caller are  listed all the same, but passing one to `POST api/2.0/settings/webhook` or `PUT api/2.0/settings/webhook` is  rejected as an invalid request. This is fixed reference data: the same for every portal, not paginated,  changing only with the product version, and readable by any authenticated caller, a `Guest` included. Nothing  is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of ApiResponse (WebhookTriggerArrayWrapper)</returns>
        public async Task<ApiResponse<WebhookTriggerArrayWrapper>> GetWebhookTriggersWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<WebhookTriggerArrayWrapper>("/api/2.0/settings/webhook/triggers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhookTriggers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        public WebhooksLogArrayWrapper GetWebhooksLogs(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetWebhooksLogsWithHttpInfo(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        public ApiResponse<WebhooksLogArrayWrapper> GetWebhooksLogsWithHttpInfo(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deliveryFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryFrom", deliveryFrom));
            }
            if (deliveryTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryTo", deliveryTo));
            }
            if (hookUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "hookUri", hookUri));
            }
            if (configId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "configId", configId));
            }
            if (eventId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "eventId", eventId));
            }
            if (groupStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupStatus", groupStatus));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (trigger != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "trigger", trigger));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<WebhooksLogArrayWrapper>("/api/2.0/settings/webhooks/log", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhooksLogs", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        public async Task<WebhooksLogArrayWrapper> GetWebhooksLogsAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWebhooksLogsWithHttpInfoAsync(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the webhook delivery log
        /// </summary>
        /// <remarks>
        /// Returns the delivery records of the portal webhooks, one record per attempt, carrying the trigger, the request  and response headers and bodies, the HTTP `status` the target answered and the `delivery` moment, the last two  staying empty while an attempt is still on its way. Records come newest first and are paged with `startIndex`  and `count`, at most 100 at a time, while the number of records matching the filter is reported as `total`  beside the response. Filters combine with AND: `deliveryFrom` and `deliveryTo` bound the delivery moment,  `hookUri` matches the subscription URL exactly, `configId` picks one subscription, `eventId` one single  record, `groupStatus` keeps only the answered status classes it names with 0 meaning no status filter, and  `trigger` narrows to one event with 0 meaning all of them. `userId` filters by who created the subscription  rather than by who caused the event, and for a caller who is not a `DocSpaceAdmin` it is forced to the caller,  so a non-admin only ever sees deliveries of their own subscriptions. A `Guest` is refused. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The earliest delivery moment a record may carry. Records of attempts still on their way have no delivery  moment yet and fall outside any bound set here. (optional)</param>
        /// <param name="deliveryTo">The latest delivery moment a record may carry. All the filters combine with AND, so it narrows whatever the  other ones already kept. (optional)</param>
        /// <param name="hookUri">The subscription target address, matched in full rather than as a prefix. Filtering by `configId` is the  reliable way to pick one subscription, since several may share an address. (optional)</param>
        /// <param name="configId">The subscription whose deliveries are kept, by the `id` that `GET api/2.0/settings/webhook` reports. (optional)</param>
        /// <param name="eventId">A single delivery record, by its own identifier. It narrows the answer to that one record, which is how a  client follows up a retry it queued earlier. (optional)</param>
        /// <param name="groupStatus">The classes of answered status to keep, as a bitmask; 0 keeps every record whatever the target answered. (optional)</param>
        /// <param name="userId">The member whose subscriptions the records belong to, by portal user ID - who created the subscription, not  who caused the event. For a caller who is not a DocSpace administrator it is overwritten with the caller own  ID, so such a caller never sees another member deliveries whatever is sent here. (optional)</param>
        /// <param name="trigger">The single event kind to keep; 0 keeps every kind. It names one trigger rather than a mask of several, unlike  the `triggers` a subscription is created with. (optional)</param>
        /// <param name="count">How many records one page may hold. The maximum is also the default, so a client that wants shorter pages has  to ask for them; the number of records matching the filter comes back as `total` beside the page. (optional)</param>
        /// <param name="startIndex">How many matching records to skip before the page begins, counting from the newest. Advance it by `count` to  walk back through the log. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogArrayWrapper>> GetWebhooksLogsWithHttpInfoAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deliveryFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryFrom", deliveryFrom));
            }
            if (deliveryTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryTo", deliveryTo));
            }
            if (hookUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "hookUri", hookUri));
            }
            if (configId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "configId", configId));
            }
            if (eventId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "eventId", eventId));
            }
            if (groupStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupStatus", groupStatus));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (trigger != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "trigger", trigger));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<WebhooksLogArrayWrapper>("/api/2.0/settings/webhooks/log", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhooksLogs", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper RemoveWebhook(int id)
        {
            var localVarResponse = RemoveWebhookWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> RemoveWebhookWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<WebhooksConfigWrapper>("/api/2.0/settings/webhook/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> RemoveWebhookAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveWebhookWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes one webhook subscription from the current portal for good, addressed by `id` in the path. Deliveries  stop with it: matching events are no longer queued, and there is no undo, so a subscription dropped by mistake  has to be created again with `POST api/2.0/settings/webhook`, which gives it a new identifier and needs a new  secret key. To pause deliveries without losing the configuration, switch the subscription off with  `PUT api/2.0/settings/webhook/enable` instead. A `DocSpaceAdmin` may remove any subscription in the portal,  anyone else only the ones they created, and a `Guest` may not use webhooks at all. The response repeats the  subscription as it was just before the removal, so the caller can record what disappeared, again without the  secret key. An identifier that no longer exists gives 404, which is what a second removal of the same  subscription answers as well, so a repeated call is harmless but reports the state truthfully rather than  pretending to succeed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> RemoveWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>WebhooksLogWrapper</returns>
        public WebhooksLogWrapper RetryWebhook(int id)
        {
            var localVarResponse = RetryWebhookWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogWrapper</returns>
        public ApiResponse<WebhooksLogWrapper> RetryWebhookWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WebhooksLogWrapper>("/api/2.0/settings/webhook/{id}/retry", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of WebhooksLogWrapper</returns>
        public async Task<WebhooksLogWrapper> RetryWebhookAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RetryWebhookWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry a webhook delivery
        /// </summary>
        /// <remarks>
        /// Sends one past webhook delivery again. The `id` in the path is that of a delivery record from  `GET api/2.0/settings/webhooks/log`, not of a subscription, and the payload kept in that record is sent once  more to the subscription it belongs to. The work is asynchronous: a fresh delivery record is created and  queued at once, and the response describes that new record, with an identifier of its own and with `status`  and `delivery` not filled in yet. To learn the outcome, read `GET api/2.0/settings/webhooks/log` with  `eventId` set to the returned identifier until `delivery` appears. The original record stays as it is, and  every call queues one more attempt, so this is not safe to repeat blindly. A `DocSpaceAdmin` may retry any  delivery in the portal, anyone else only deliveries of the subscriptions they created, and a `Guest` is  refused. An `id` of 0 is rejected as an invalid request and an unknown one gives 404. The operation is rate  limited, so a burst of calls is answered with 429; to retry several records use  `PUT api/2.0/settings/webhook/retry`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the object the operation acts on, as the listing operation of that kind of object reports  it. It has to match the shape the route declares - a GUID where the route is typed as one - since a value of  another shape does not match the route at all and is answered as not found.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogWrapper>> RetryWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksLogWrapper>("/api/2.0/settings/webhook/{id}/retry", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        public WebhooksLogArrayWrapper RetryWebhooks(WebhookRetryRequestsDto? webhookRetryRequestsDto = default)
        {
            var localVarResponse = RetryWebhooksWithHttpInfo(webhookRetryRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        public ApiResponse<WebhooksLogArrayWrapper> RetryWebhooksWithHttpInfo(WebhookRetryRequestsDto? webhookRetryRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (webhookRetryRequestsDto != null) localVarRequestOptions.Data = webhookRetryRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WebhooksLogArrayWrapper>("/api/2.0/settings/webhook/retry", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhooks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        public async Task<WebhooksLogArrayWrapper> RetryWebhooksAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RetryWebhooksWithHttpInfoAsync(webhookRetryRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry webhook deliveries
        /// </summary>
        /// <remarks>
        /// Sends a batch of past webhook deliveries again. `ids` holds the identifiers of delivery records from  `GET api/2.0/settings/webhooks/log`; each of them is sent once more to the subscription it belongs to as a  fresh delivery record, queued for asynchronous delivery, and the response lists those new records with  `status` and `delivery` not filled in yet. Records that do not exist, and records of another member's  subscription when the caller is not a `DocSpaceAdmin`, are skipped in silence instead of failing the call, so  a response shorter than `ids` is the only sign that something was left out: compare the counts rather than  assuming everything was queued. An empty `ids` list is accepted and queues nothing. Read the outcomes from  `GET api/2.0/settings/webhooks/log`, matching the returned identifiers with `eventId`. Every call queues  another round of attempts, and the original records stay as they are. A `Guest` is refused. The operation is  rate limited, so a burst of calls is answered with 429. For a single record  `PUT api/2.0/settings/webhook/{id}/retry` reports a missing or forbidden record instead of skipping it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">Which past webhook deliveries are sent again. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogArrayWrapper>> RetryWebhooksWithHttpInfoAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (webhookRetryRequestsDto != null) localVarRequestOptions.Data = webhookRetryRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksLogArrayWrapper>("/api/2.0/settings/webhook/retry", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhooks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper UpdateWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = UpdateWebhookWithHttpInfo(updateWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> UpdateWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> UpdateWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateWebhookWithHttpInfoAsync(updateWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Replaces the stored parameters of one webhook subscription, which is addressed by `id` in the body rather than  in the path. Every field of the request overwrites the stored one, so a payload that leaves out `enabled`,  `ssl`, `triggers` or `targetId` resets them to off, all events and no target: read the current values with  `GET api/2.0/settings/webhook` first and send back whatever should stay. `secretKey` is the one exception, an  empty value keeping the existing secret and a new one having to satisfy the portal password rules. The new  target is validated exactly as on creation, that is it must sit outside the installation's own network and  answer a HEAD request, and trigger flags the caller's role may not use are rejected. That validation runs  before the subscription is looked up, so an unusable payload is refused with 400 even when no subscription  with this `id` exists. A `DocSpaceAdmin` may update any subscription in the portal, anyone else only their  own, and a `Guest` is refused. Sending the same payload twice leaves the same state. Use  `PUT api/2.0/settings/webhook/enable` to switch a subscription on or off without touching anything else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The webhook subscription being changed, with the parameters it is to have afterwards. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> UpdateWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
