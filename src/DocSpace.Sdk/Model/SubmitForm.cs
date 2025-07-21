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
    /// The \&quot;Complete &amp; Submit\&quot; button settings.
    /// </summary>
    [DataContract(Name = "SubmitForm")]
    public partial class SubmitForm : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitForm" /> class.
        /// </summary>
        /// <param name="visible">Specifies whether the \&quot;Complete  &amp; Submit\&quot; button will be displayed or hidden on the top toolbar..</param>
        /// <param name="resultMessage">A message displayed after forms are submitted..</param>
        public SubmitForm(bool visible = default, string resultMessage = default)
        {
            this.Visible = visible;
            this.ResultMessage = resultMessage;
        }

        /// <summary>
        /// Specifies whether the \&quot;Complete  &amp; Submit\&quot; button will be displayed or hidden on the top toolbar.
        /// </summary>
        /// <value>Specifies whether the \&quot;Complete  &amp; Submit\&quot; button will be displayed or hidden on the top toolbar.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// A message displayed after forms are submitted.
        /// </summary>
        /// <value>A message displayed after forms are submitted.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "resultMessage", EmitDefaultValue = true)]
        public string ResultMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitForm {\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  ResultMessage: ").Append(ResultMessage).Append("\n");
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
