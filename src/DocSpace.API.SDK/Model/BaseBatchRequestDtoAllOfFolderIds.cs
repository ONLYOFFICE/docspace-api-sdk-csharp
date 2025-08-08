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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// BaseBatchRequestDtoAllOfFolderIds
    /// </summary>
    [JsonConverter(typeof(BaseBatchRequestDtoAllOfFolderIdsJsonConverter))]
    [DataContract(Name = "BaseBatchRequestDto_allOf_folderIds")]
    public partial class BaseBatchRequestDtoAllOfFolderIds : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBatchRequestDtoAllOfFolderIds" /> class
        /// with the <see cref="int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of int.</param>
        public BaseBatchRequestDtoAllOfFolderIds(int actualInstance)
        {
            IsNullable = false;
            SchemaType= "anyOf";
            ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBatchRequestDtoAllOfFolderIds" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public BaseBatchRequestDtoAllOfFolderIds(string actualInstance)
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
                if (value.GetType() == typeof(int))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: int, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `int`. If the actual instance is not `int`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of int</returns>
        public int GetInt()
        {
            return (int)ActualInstance;
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
            sb.Append("class BaseBatchRequestDtoAllOfFolderIds {\n");
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
            return JsonSerializer.Serialize(ActualInstance, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });
        }

        /// <summary>
        /// Converts the JSON string into an instance of BaseBatchRequestDtoAllOfFolderIds
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of BaseBatchRequestDtoAllOfFolderIds</returns>
        public static BaseBatchRequestDtoAllOfFolderIds FromJson(string jsonString)
        {
            BaseBatchRequestDtoAllOfFolderIds newBaseBatchRequestDtoAllOfFolderIds = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBaseBatchRequestDtoAllOfFolderIds;
            }

            try
            {
                newBaseBatchRequestDtoAllOfFolderIds = new BaseBatchRequestDtoAllOfFolderIds(JsonSerializer.Deserialize<int>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newBaseBatchRequestDtoAllOfFolderIds;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into int: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newBaseBatchRequestDtoAllOfFolderIds = new BaseBatchRequestDtoAllOfFolderIds(JsonSerializer.Deserialize<string>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newBaseBatchRequestDtoAllOfFolderIds;
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
    /// Custom JSON converter for BaseBatchRequestDtoAllOfFolderIds
    /// </summary>
    public class BaseBatchRequestDtoAllOfFolderIdsJsonConverter : JsonConverter<BaseBatchRequestDtoAllOfFolderIds>
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="options">JSON Serializer options</param>
        public override void Write(Utf8JsonWriter  writer, BaseBatchRequestDtoAllOfFolderIds value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.ToJson());
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="typeToConvert">Object type</param>
        /// <param name="options">JSON Serializer options</param>
        /// <returns>The object converted from the JSON string</returns>
        public override BaseBatchRequestDtoAllOfFolderIds Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument document = JsonDocument.ParseValue(ref reader))
            {
                var jsonString = document.RootElement.GetRawText();
                return BaseBatchRequestDtoAllOfFolderIds.FromJson(jsonString);
            }
        }

    }

}
