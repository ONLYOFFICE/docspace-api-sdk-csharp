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
    /// Provider type identifier. Accepts all 17 built-in types with autocomplete, plus any custom &#x60;string&#x60; for dynamically registered providers.
    /// </summary>
    [JsonConverter(typeof(NewAiProviderTypeJsonConverter))]
    [DataContract(Name = "NewAiProviderType")]
    public partial class NewAiProviderType : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiProviderType" /> class
        /// with the <see cref="NewAiBuiltinProviderType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NewAiBuiltinProviderType.</param>
        public NewAiProviderType(NewAiBuiltinProviderType actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiProviderType" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public NewAiProviderType(string actualInstance)
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
                if (value.GetType() == typeof(NewAiBuiltinProviderType))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: NewAiBuiltinProviderType, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `NewAiBuiltinProviderType`. If the actual instance is not `NewAiBuiltinProviderType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NewAiBuiltinProviderType</returns>
        public NewAiBuiltinProviderType GetNewAiBuiltinProviderType()
        {
            return (NewAiBuiltinProviderType)ActualInstance;
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
            sb.Append("class NewAiProviderType {\n");
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
            return JsonConvert.SerializeObject(ActualInstance, NewAiProviderType.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NewAiProviderType
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NewAiProviderType</returns>
        public static NewAiProviderType FromJson(string jsonString)
        {
            NewAiProviderType newNewAiProviderType = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNewAiProviderType;
            }

            try
            {
                newNewAiProviderType = new NewAiProviderType(JsonConvert.DeserializeObject<NewAiBuiltinProviderType>(jsonString, NewAiProviderType.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newNewAiProviderType;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NewAiBuiltinProviderType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newNewAiProviderType = new NewAiProviderType(JsonConvert.DeserializeObject<string>(jsonString, NewAiProviderType.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newNewAiProviderType;
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
    /// Custom JSON converter for NewAiProviderType
    /// </summary>
    public class NewAiProviderTypeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NewAiProviderType).GetMethod("ToJson").Invoke(value, null)));
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
                    return new NewAiProviderType(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return NewAiProviderType.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return NewAiProviderType.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
