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
    /// [0 - None, 1 - Is editing, 2 - Is new, 4 - Is converting, 8 - Is original, 16 - Is editing alone, 32 - Is favorite, 64 - Is template, 128 - Is fill form draft, 256 - Is completed form]
    /// </summary>
    /// <value>[0 - None, 1 - Is editing, 2 - Is new, 4 - Is converting, 8 - Is original, 16 - Is editing alone, 32 - Is favorite, 64 - Is template, 128 - Is fill form draft, 256 - Is completed form]</value>
    public enum FileStatus
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum IsEditing for value: 1
        /// </summary>
        IsEditing = 1,

        /// <summary>
        /// Enum IsNew for value: 2
        /// </summary>
        IsNew = 2,

        /// <summary>
        /// Enum IsConverting for value: 4
        /// </summary>
        IsConverting = 4,

        /// <summary>
        /// Enum IsOriginal for value: 8
        /// </summary>
        IsOriginal = 8,

        /// <summary>
        /// Enum IsEditingAlone for value: 16
        /// </summary>
        IsEditingAlone = 16,

        /// <summary>
        /// Enum IsFavorite for value: 32
        /// </summary>
        IsFavorite = 32,

        /// <summary>
        /// Enum IsTemplate for value: 64
        /// </summary>
        IsTemplate = 64,

        /// <summary>
        /// Enum IsFillFormDraft for value: 128
        /// </summary>
        IsFillFormDraft = 128,

        /// <summary>
        /// Enum IsCompletedForm for value: 256
        /// </summary>
        IsCompletedForm = 256
    }

}
