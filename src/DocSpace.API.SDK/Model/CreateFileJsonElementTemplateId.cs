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
    /// The template file ID for creation.
    /// </summary>
    [JsonConverter(typeof(CreateFileJsonElementTemplateIdJsonConverter))]
    [DataContract(Name = "CreateFileJsonElement_templateId")]
    public partial class CreateFileJsonElementTemplateId : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileJsonElementTemplateId" /> class
        /// with the <see cref="int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of int.</param>
        public CreateFileJsonElementTemplateId(int actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileJsonElementTemplateId" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public CreateFileJsonElementTemplateId(string actualInstance)
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
                if (value.GetType() == typeof(int) || value is int)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string) || value is string)
                {
                    this._actualInstance = value;
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
            return (int)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileJsonElementTemplateId {\n");
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
            return JsonSerializer.Serialize(this.ActualInstance, CreateFileJsonElementTemplateId.SerializerOptions);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateFileJsonElementTemplateId
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateFileJsonElementTemplateId</returns>
        public static CreateFileJsonElementTemplateId FromJson(string jsonString)
        {
            CreateFileJsonElementTemplateId newCreateFileJsonElementTemplateId = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateFileJsonElementTemplateId;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // System.Text.Json doesn't have a direct equivalent to AdditionalProperties handling
                // We'll use the default options for all types
                newCreateFileJsonElementTemplateId = new CreateFileJsonElementTemplateId(JsonSerializer.Deserialize<int>(jsonString, CreateFileJsonElementTemplateId.SerializerOptions));
                matchedTypes.Add("int");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine($"Failed to deserialize '{jsonString}' into int: {exception}");
            }

            try
            {
                // System.Text.Json doesn't have a direct equivalent to AdditionalProperties handling
                // We'll use the default options for all types
                newCreateFileJsonElementTemplateId = new CreateFileJsonElementTemplateId(JsonSerializer.Deserialize<string>(jsonString, CreateFileJsonElementTemplateId.SerializerOptions));
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine($"Failed to deserialize '{jsonString}' into string: {exception}");
            }

            if (match == 0)
            {
                throw new InvalidDataException($"The JSON string '{jsonString}' cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException($"The JSON string '{jsonString}' incorrectly matches more than one schema (should be exactly one match): {string.Join(",", matchedTypes)}");
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCreateFileJsonElementTemplateId;
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
    /// Custom JSON converter for CreateFileJsonElementTemplateId
    /// </summary>
    public class CreateFileJsonElementTemplateIdJsonConverter : JsonConverter<CreateFileJsonElementTemplateId>
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="options">JSON Serializer Options</param>
        public override void Write(Utf8JsonWriter writer, CreateFileJsonElementTemplateId value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.ToJson());
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="typeToConvert">Object type</param>
        /// <param name="options">JSON Serializer Options</param>
        /// <returns>The object converted from the JSON string</returns>
        public override CreateFileJsonElementTemplateId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument document = JsonDocument.ParseValue(ref reader))
            {
                var root = document.RootElement;
                
                // Handle primitive types
                switch (root.ValueKind)
                {
                    case JsonValueKind.Number when root.TryGetInt32(out int intValue):
                        return new CreateFileJsonElementTemplateId(intValue);
                    case JsonValueKind.String:
                        return new CreateFileJsonElementTemplateId(root.GetString());
                    case JsonValueKind.Object:
                    case JsonValueKind.Array:
                        return CreateFileJsonElementTemplateId.FromJson(root.GetRawText());
                    default:
                        throw new JsonException($"Unexpected token type {root.ValueKind}");
                }
            }
        }
    }

}
