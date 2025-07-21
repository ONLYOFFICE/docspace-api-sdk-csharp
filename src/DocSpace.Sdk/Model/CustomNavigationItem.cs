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
    /// The custom navigation item parameters.
    /// </summary>
    [DataContract(Name = "CustomNavigationItem")]
    public partial class CustomNavigationItem : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNavigationItem" /> class.
        /// </summary>
        /// <param name="id">The ID of the custom navigation item..</param>
        /// <param name="label">The label of the custom navigation item..</param>
        /// <param name="url">The URL of the custom navigation item..</param>
        /// <param name="bigImg">The big image of the custom navigation item..</param>
        /// <param name="smallImg">The small image of the custom navigation item..</param>
        /// <param name="showInMenu">Specifies whether to show the custom navigation item in menu or not..</param>
        /// <param name="showOnHomePage">Specifies whether to show the custom navigation item on home page or not..</param>
        public CustomNavigationItem(Guid id = default, string label = default, string url = default, string bigImg = default, string smallImg = default, bool showInMenu = default, bool showOnHomePage = default)
        {
            this.Id = id;
            this.Label = label;
            this.Url = url;
            this.BigImg = bigImg;
            this.SmallImg = smallImg;
            this.ShowInMenu = showInMenu;
            this.ShowOnHomePage = showOnHomePage;
        }

        /// <summary>
        /// The ID of the custom navigation item.
        /// </summary>
        /// <value>The ID of the custom navigation item.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The label of the custom navigation item.
        /// </summary>
        /// <value>The label of the custom navigation item.</value>
        /*
        <example>Label</example>
        */
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// The URL of the custom navigation item.
        /// </summary>
        /// <value>The URL of the custom navigation item.</value>
        /*
        <example>Url</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The big image of the custom navigation item.
        /// </summary>
        /// <value>The big image of the custom navigation item.</value>
        /*
        <example>data:image\/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAABkAgMAAAANjH3HAAAADFBMVEUAAADJycnJycnJycmiuNtHAAAAA3RSTlMAf4C\/aSLHAAAAyElEQVR4Xu3NsQ3CMBSE4YubFB4ilHQegdGSjWACvEpGoEyBYiL05AdnXUGHolx10lf82MmOpfLeo5UoJUhBlpKkRCnhUy7b9XCWkqQMUkYlXVHSf8kTvkHKqKQrSnopg5SRxTMklLmS1MwaSWpmCSQ1MyOzWGZCYrEMEFksA4QqlAFuJJYBcCKxjM3FMySeIfEMC2dMOONCGZZgmdr1ly3TSrJMK9EyJBaaGrHQikYstAiJZRYSyiQEdyg5S8Evckih\/YPscsdej0H6dc0TYw4AAAAASUVORK5CYII&#x3D;</example>
        */
        [DataMember(Name = "bigImg", EmitDefaultValue = true)]
        public string BigImg { get; set; }

        /// <summary>
        /// The small image of the custom navigation item.
        /// </summary>
        /// <value>The small image of the custom navigation item.</value>
        /*
        <example>data:image\/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8\/9hAAAAUUlEQVR4AWMY\/KC5o\/cAEP9HxxgKcSpCGELYADyu2E6mAQjNxBlAWPNxkHdwGkBIM3KYYDUAr2ZCAE+oH8eujrAXDsA0k2EAAtDXAGLx4MpsADUgvkRKUlqfAAAAAElFTkSuQmCC</example>
        */
        [DataMember(Name = "smallImg", EmitDefaultValue = true)]
        public string SmallImg { get; set; }

        /// <summary>
        /// Specifies whether to show the custom navigation item in menu or not.
        /// </summary>
        /// <value>Specifies whether to show the custom navigation item in menu or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "showInMenu", EmitDefaultValue = true)]
        public bool ShowInMenu { get; set; }

        /// <summary>
        /// Specifies whether to show the custom navigation item on home page or not.
        /// </summary>
        /// <value>Specifies whether to show the custom navigation item on home page or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "showOnHomePage", EmitDefaultValue = true)]
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomNavigationItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  BigImg: ").Append(BigImg).Append("\n");
            sb.Append("  SmallImg: ").Append(SmallImg).Append("\n");
            sb.Append("  ShowInMenu: ").Append(ShowInMenu).Append("\n");
            sb.Append("  ShowOnHomePage: ").Append(ShowOnHomePage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
