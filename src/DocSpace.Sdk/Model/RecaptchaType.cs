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
    /// [0 - Default, 1 - AndroidV2, 2 - iOSV2, 3 - hCaptcha]
    /// </summary>
    /// <value>[0 - Default, 1 - AndroidV2, 2 - iOSV2, 3 - hCaptcha]</value>
    public enum RecaptchaType
    {
        /// <summary>
        /// Enum Default for value: 0
        /// </summary>
        Default = 0,

        /// <summary>
        /// Enum AndroidV2 for value: 1
        /// </summary>
        AndroidV2 = 1,

        /// <summary>
        /// Enum iOSV2 for value: 2
        /// </summary>
        iOSV2 = 2,

        /// <summary>
        /// Enum hCaptcha for value: 3
        /// </summary>
        hCaptcha = 3
    }

}
