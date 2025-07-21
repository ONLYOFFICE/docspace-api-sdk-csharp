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
    /// [0 - Badges, 1 - Rooms activity, 2 - Daily feed, 3 - Usefull tips]
    /// </summary>
    /// <value>[0 - Badges, 1 - Rooms activity, 2 - Daily feed, 3 - Usefull tips]</value>
    public enum NotificationType
    {
        /// <summary>
        /// Enum Badges for value: 0
        /// </summary>
        Badges = 0,

        /// <summary>
        /// Enum RoomsActivity for value: 1
        /// </summary>
        RoomsActivity = 1,

        /// <summary>
        /// Enum DailyFeed for value: 2
        /// </summary>
        DailyFeed = 2,

        /// <summary>
        /// Enum UsefullTips for value: 3
        /// </summary>
        UsefullTips = 3
    }

}
