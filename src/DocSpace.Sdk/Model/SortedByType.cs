// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [0 - Date and time, 1 - AZ, 2 - Size, 3 - Author, 4 - Type, 5 - New, 6 - Date and time creation, 7 - Room type, 8 - Tags, 9 - Room, 10 - Custom order, 11 - Last opened, 12 - Used space]
    /// </summary>
    /// <value>[0 - Date and time, 1 - AZ, 2 - Size, 3 - Author, 4 - Type, 5 - New, 6 - Date and time creation, 7 - Room type, 8 - Tags, 9 - Room, 10 - Custom order, 11 - Last opened, 12 - Used space]</value>
    public enum SortedByType
    {
        /// <summary>
        /// Enum DateAndTime for value: 0
        /// </summary>
        DateAndTime = 0,

        /// <summary>
        /// Enum AZ for value: 1
        /// </summary>
        AZ = 1,

        /// <summary>
        /// Enum Size for value: 2
        /// </summary>
        Size = 2,

        /// <summary>
        /// Enum Author for value: 3
        /// </summary>
        Author = 3,

        /// <summary>
        /// Enum Type for value: 4
        /// </summary>
        Type = 4,

        /// <summary>
        /// Enum New for value: 5
        /// </summary>
        New = 5,

        /// <summary>
        /// Enum DateAndTimeCreation for value: 6
        /// </summary>
        DateAndTimeCreation = 6,

        /// <summary>
        /// Enum RoomType for value: 7
        /// </summary>
        RoomType = 7,

        /// <summary>
        /// Enum Tags for value: 8
        /// </summary>
        Tags = 8,

        /// <summary>
        /// Enum Room for value: 9
        /// </summary>
        Room = 9,

        /// <summary>
        /// Enum CustomOrder for value: 10
        /// </summary>
        CustomOrder = 10,

        /// <summary>
        /// Enum LastOpened for value: 11
        /// </summary>
        LastOpened = 11,

        /// <summary>
        /// Enum UsedSpace for value: 12
        /// </summary>
        UsedSpace = 12
    }

}
