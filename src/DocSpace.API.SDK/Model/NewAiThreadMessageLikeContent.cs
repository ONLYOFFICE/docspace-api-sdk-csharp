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
using System.Reflection;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// Message content: either plain text or a list of typed content parts (text, image, tool-call, …). Parts are open-ended by content type.
    /// </summary>
    [JsonConverter(typeof(NewAiThreadMessageLikeContentJsonConverter))]
    [DataContract(Name = "NewAiThreadMessageLike_content")]
    public partial class NewAiThreadMessageLikeContent : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiThreadMessageLikeContent" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public NewAiThreadMessageLikeContent(string actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiThreadMessageLikeContent" /> class
        /// with the <see cref="List{NewAiThreadMessageLikeContentAnyOfInner}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;NewAiThreadMessageLikeContentAnyOfInner&gt;.</param>
        public NewAiThreadMessageLikeContent(List<NewAiThreadMessageLikeContentAnyOfInner> actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(List<NewAiThreadMessageLikeContentAnyOfInner>))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: List<NewAiThreadMessageLikeContentAnyOfInner>, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;NewAiThreadMessageLikeContentAnyOfInner&gt;`. If the actual instance is not `List&lt;NewAiThreadMessageLikeContentAnyOfInner&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;NewAiThreadMessageLikeContentAnyOfInner&gt;</returns>
        public List<NewAiThreadMessageLikeContentAnyOfInner> GetList()
        {
            return (List<NewAiThreadMessageLikeContentAnyOfInner>)ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiThreadMessageLikeContent {\n");
            sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(ActualInstance, NewAiThreadMessageLikeContent.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NewAiThreadMessageLikeContent
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NewAiThreadMessageLikeContent</returns>
        public static NewAiThreadMessageLikeContent FromJson(string jsonString)
        {
            NewAiThreadMessageLikeContent newNewAiThreadMessageLikeContent = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNewAiThreadMessageLikeContent;
            }

            try
            {
                newNewAiThreadMessageLikeContent = new NewAiThreadMessageLikeContent(JsonConvert.DeserializeObject<List<NewAiThreadMessageLikeContentAnyOfInner>>(jsonString, NewAiThreadMessageLikeContent.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newNewAiThreadMessageLikeContent;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<NewAiThreadMessageLikeContentAnyOfInner>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newNewAiThreadMessageLikeContent = new NewAiThreadMessageLikeContent(JsonConvert.DeserializeObject<string>(jsonString, NewAiThreadMessageLikeContent.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newNewAiThreadMessageLikeContent;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
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

    /// <summary>
    /// Custom JSON converter for NewAiThreadMessageLikeContent
    /// </summary>
    public class NewAiThreadMessageLikeContentJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NewAiThreadMessageLikeContent).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.String: 
                    return new NewAiThreadMessageLikeContent(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return NewAiThreadMessageLikeContent.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return NewAiThreadMessageLikeContent.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
