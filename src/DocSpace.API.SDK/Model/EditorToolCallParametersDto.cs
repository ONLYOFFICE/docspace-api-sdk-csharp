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
    /// The editor tool call parameters.
    /// </summary>
    [JsonConverter(typeof(EditorToolCallParametersDtoJsonConverter))]
    [DataContract(Name = "EditorToolCallParametersDto")]
    public partial class EditorToolCallParametersDto : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorToolCallParametersDto" /> class
        /// with the <see cref="GenerateDocxToolCallParametersDto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GenerateDocxToolCallParametersDto.</param>
        public EditorToolCallParametersDto(GenerateDocxToolCallParametersDto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorToolCallParametersDto" /> class
        /// with the <see cref="GenerateFormToolCallParametersDto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GenerateFormToolCallParametersDto.</param>
        public EditorToolCallParametersDto(GenerateFormToolCallParametersDto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorToolCallParametersDto" /> class
        /// with the <see cref="GeneratePresentationToolCallParametersDto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GeneratePresentationToolCallParametersDto.</param>
        public EditorToolCallParametersDto(GeneratePresentationToolCallParametersDto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
                if (value.GetType() == typeof(GenerateDocxToolCallParametersDto) || value is GenerateDocxToolCallParametersDto)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GenerateFormToolCallParametersDto) || value is GenerateFormToolCallParametersDto)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GeneratePresentationToolCallParametersDto) || value is GeneratePresentationToolCallParametersDto)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GenerateDocxToolCallParametersDto, GenerateFormToolCallParametersDto, GeneratePresentationToolCallParametersDto");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GenerateDocxToolCallParametersDto`. If the actual instance is not `GenerateDocxToolCallParametersDto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GenerateDocxToolCallParametersDto</returns>
        public GenerateDocxToolCallParametersDto GetGenerateDocxToolCallParametersDto()
        {
            return (GenerateDocxToolCallParametersDto)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GenerateFormToolCallParametersDto`. If the actual instance is not `GenerateFormToolCallParametersDto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GenerateFormToolCallParametersDto</returns>
        public GenerateFormToolCallParametersDto GetGenerateFormToolCallParametersDto()
        {
            return (GenerateFormToolCallParametersDto)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GeneratePresentationToolCallParametersDto`. If the actual instance is not `GeneratePresentationToolCallParametersDto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GeneratePresentationToolCallParametersDto</returns>
        public GeneratePresentationToolCallParametersDto GetGeneratePresentationToolCallParametersDto()
        {
            return (GeneratePresentationToolCallParametersDto)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditorToolCallParametersDto {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, EditorToolCallParametersDto.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of EditorToolCallParametersDto
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of EditorToolCallParametersDto</returns>
        public static EditorToolCallParametersDto FromJson(string jsonString)
        {
            EditorToolCallParametersDto newEditorToolCallParametersDto = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newEditorToolCallParametersDto;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GenerateDocxToolCallParametersDto).GetProperty("AdditionalProperties") == null)
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GenerateDocxToolCallParametersDto>(jsonString, EditorToolCallParametersDto.SerializerSettings));
                }
                else
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GenerateDocxToolCallParametersDto>(jsonString, EditorToolCallParametersDto.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GenerateDocxToolCallParametersDto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GenerateDocxToolCallParametersDto: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GenerateFormToolCallParametersDto).GetProperty("AdditionalProperties") == null)
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GenerateFormToolCallParametersDto>(jsonString, EditorToolCallParametersDto.SerializerSettings));
                }
                else
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GenerateFormToolCallParametersDto>(jsonString, EditorToolCallParametersDto.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GenerateFormToolCallParametersDto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GenerateFormToolCallParametersDto: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GeneratePresentationToolCallParametersDto).GetProperty("AdditionalProperties") == null)
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GeneratePresentationToolCallParametersDto>(jsonString, EditorToolCallParametersDto.SerializerSettings));
                }
                else
                {
                    newEditorToolCallParametersDto = new EditorToolCallParametersDto(JsonConvert.DeserializeObject<GeneratePresentationToolCallParametersDto>(jsonString, EditorToolCallParametersDto.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GeneratePresentationToolCallParametersDto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GeneratePresentationToolCallParametersDto: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newEditorToolCallParametersDto;
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
    /// Custom JSON converter for EditorToolCallParametersDto
    /// </summary>
    public class EditorToolCallParametersDtoJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(EditorToolCallParametersDto).GetMethod("ToJson").Invoke(value, null)));
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
                case JsonToken.StartObject:
                    return EditorToolCallParametersDto.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return EditorToolCallParametersDto.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
