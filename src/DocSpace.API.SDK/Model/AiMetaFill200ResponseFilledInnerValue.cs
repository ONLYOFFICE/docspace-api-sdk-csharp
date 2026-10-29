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
    /// AiMetaFill200ResponseFilledInnerValue
    /// </summary>
    [JsonConverter(typeof(AiMetaFill200ResponseFilledInnerValueJsonConverter))]
    [DataContract(Name = "aiMetaFill_200_response_filled_inner_value")]
    public partial class AiMetaFill200ResponseFilledInnerValue : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200ResponseFilledInnerValue" /> class
        /// with the <see cref="AiMetadataValue" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AiMetadataValue.</param>
        public AiMetaFill200ResponseFilledInnerValue(AiMetadataValue actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200ResponseFilledInnerValue" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public AiMetaFill200ResponseFilledInnerValue(string actualInstance)
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
                if (value.GetType() == typeof(AiMetadataValue))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AiMetadataValue, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AiMetadataValue`. If the actual instance is not `AiMetadataValue`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AiMetadataValue</returns>
        public AiMetadataValue GetAiMetadataValue()
        {
            return (AiMetadataValue)ActualInstance;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaFill200ResponseFilledInnerValue {\n");
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
            return JsonConvert.SerializeObject(ActualInstance, AiMetaFill200ResponseFilledInnerValue.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AiMetaFill200ResponseFilledInnerValue
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AiMetaFill200ResponseFilledInnerValue</returns>
        public static AiMetaFill200ResponseFilledInnerValue FromJson(string jsonString)
        {
            AiMetaFill200ResponseFilledInnerValue newAiMetaFill200ResponseFilledInnerValue = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAiMetaFill200ResponseFilledInnerValue;
            }

            try
            {
                newAiMetaFill200ResponseFilledInnerValue = new AiMetaFill200ResponseFilledInnerValue(JsonConvert.DeserializeObject<AiMetadataValue>(jsonString, AiMetaFill200ResponseFilledInnerValue.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAiMetaFill200ResponseFilledInnerValue;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AiMetadataValue: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAiMetaFill200ResponseFilledInnerValue = new AiMetaFill200ResponseFilledInnerValue(JsonConvert.DeserializeObject<string>(jsonString, AiMetaFill200ResponseFilledInnerValue.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAiMetaFill200ResponseFilledInnerValue;
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
    /// Custom JSON converter for AiMetaFill200ResponseFilledInnerValue
    /// </summary>
    public class AiMetaFill200ResponseFilledInnerValueJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AiMetaFill200ResponseFilledInnerValue).GetMethod("ToJson").Invoke(value, null)));
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
                    return new AiMetaFill200ResponseFilledInnerValue(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return AiMetaFill200ResponseFilledInnerValue.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return AiMetaFill200ResponseFilledInnerValue.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
