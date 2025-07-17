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
    /// [0 - None, 1 - Not sent, 2 - Status2xx, 4 - Status3xx, 8 - Status4xx, 16 - Status5xx]
    /// </summary>
    /// <value>[0 - None, 1 - Not sent, 2 - Status2xx, 4 - Status3xx, 8 - Status4xx, 16 - Status5xx]</value>
    public enum WebhookGroupStatus
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum NotSent for value: 1
        /// </summary>
        NotSent = 1,

        /// <summary>
        /// Enum Status2xx for value: 2
        /// </summary>
        Status2xx = 2,

        /// <summary>
        /// Enum Status3xx for value: 4
        /// </summary>
        Status3xx = 4,

        /// <summary>
        /// Enum Status4xx for value: 8
        /// </summary>
        Status4xx = 8,

        /// <summary>
        /// Enum Status5xx for value: 16
        /// </summary>
        Status5xx = 16
    }

}
