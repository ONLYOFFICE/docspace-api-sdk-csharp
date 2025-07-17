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
    /// [0 - None, 1 - Read and write, 2 - Read, 3 - Restrict, 4 - Varies, 5 - Review, 6 - Comment, 7 - Fill forms, 8 - Custom filter, 9 - Room manager, 10 - Editing, 11 - Content creator]
    /// </summary>
    /// <value>[0 - None, 1 - Read and write, 2 - Read, 3 - Restrict, 4 - Varies, 5 - Review, 6 - Comment, 7 - Fill forms, 8 - Custom filter, 9 - Room manager, 10 - Editing, 11 - Content creator]</value>
    public enum FileShare
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum ReadWrite for value: 1
        /// </summary>
        ReadWrite = 1,

        /// <summary>
        /// Enum Read for value: 2
        /// </summary>
        Read = 2,

        /// <summary>
        /// Enum Restrict for value: 3
        /// </summary>
        Restrict = 3,

        /// <summary>
        /// Enum Varies for value: 4
        /// </summary>
        Varies = 4,

        /// <summary>
        /// Enum Review for value: 5
        /// </summary>
        Review = 5,

        /// <summary>
        /// Enum Comment for value: 6
        /// </summary>
        Comment = 6,

        /// <summary>
        /// Enum FillForms for value: 7
        /// </summary>
        FillForms = 7,

        /// <summary>
        /// Enum CustomFilter for value: 8
        /// </summary>
        CustomFilter = 8,

        /// <summary>
        /// Enum RoomManager for value: 9
        /// </summary>
        RoomManager = 9,

        /// <summary>
        /// Enum Editing for value: 10
        /// </summary>
        Editing = 10,

        /// <summary>
        /// Enum ContentCreator for value: 11
        /// </summary>
        ContentCreator = 11
    }

}
