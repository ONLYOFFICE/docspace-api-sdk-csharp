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
    /// The folder the items go to, by id — a number for a folder stored in the portal itself, a string for a folder  on a connected third-party account. Take it from a folder listing such as &#x60;GET api/2.0/files/@root&#x60;; the  caller has to be allowed to create items in it, and the id of a room addresses the root of that room.
    /// </summary>
    [JsonConverter(typeof(CheckMoveOrCopyBatchItemsDestFolderIdParameterJsonConverter))]
    [DataContract(Name = "checkMoveOrCopyBatchItems_destFolderId_parameter")]
    public partial class CheckMoveOrCopyBatchItemsDestFolderIdParameter : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckMoveOrCopyBatchItemsDestFolderIdParameter" /> class
        /// with the <see cref="int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of int.</param>
        public CheckMoveOrCopyBatchItemsDestFolderIdParameter(int actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckMoveOrCopyBatchItemsDestFolderIdParameter" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public CheckMoveOrCopyBatchItemsDestFolderIdParameter(string actualInstance)
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
            sb.Append("class CheckMoveOrCopyBatchItemsDestFolderIdParameter {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CheckMoveOrCopyBatchItemsDestFolderIdParameter.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CheckMoveOrCopyBatchItemsDestFolderIdParameter
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CheckMoveOrCopyBatchItemsDestFolderIdParameter</returns>
        public static CheckMoveOrCopyBatchItemsDestFolderIdParameter FromJson(string jsonString)
        {
            CheckMoveOrCopyBatchItemsDestFolderIdParameter newCheckMoveOrCopyBatchItemsDestFolderIdParameter = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCheckMoveOrCopyBatchItemsDestFolderIdParameter;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(int).GetProperty("AdditionalProperties") == null)
                {
                    newCheckMoveOrCopyBatchItemsDestFolderIdParameter = new CheckMoveOrCopyBatchItemsDestFolderIdParameter(JsonConvert.DeserializeObject<int>(jsonString, CheckMoveOrCopyBatchItemsDestFolderIdParameter.SerializerSettings));
                }
                else
                {
                    newCheckMoveOrCopyBatchItemsDestFolderIdParameter = new CheckMoveOrCopyBatchItemsDestFolderIdParameter(JsonConvert.DeserializeObject<int>(jsonString, CheckMoveOrCopyBatchItemsDestFolderIdParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("int");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into int: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newCheckMoveOrCopyBatchItemsDestFolderIdParameter = new CheckMoveOrCopyBatchItemsDestFolderIdParameter(JsonConvert.DeserializeObject<string>(jsonString, CheckMoveOrCopyBatchItemsDestFolderIdParameter.SerializerSettings));
                }
                else
                {
                    newCheckMoveOrCopyBatchItemsDestFolderIdParameter = new CheckMoveOrCopyBatchItemsDestFolderIdParameter(JsonConvert.DeserializeObject<string>(jsonString, CheckMoveOrCopyBatchItemsDestFolderIdParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
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
            return newCheckMoveOrCopyBatchItemsDestFolderIdParameter;
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
    /// Custom JSON converter for CheckMoveOrCopyBatchItemsDestFolderIdParameter
    /// </summary>
    public class CheckMoveOrCopyBatchItemsDestFolderIdParameterJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CheckMoveOrCopyBatchItemsDestFolderIdParameter).GetMethod("ToJson").Invoke(value, null)));
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
                case JsonToken.Integer: 
                    return new CheckMoveOrCopyBatchItemsDestFolderIdParameter(Convert.ToInt32(reader.Value));
                case JsonToken.String: 
                    return new CheckMoveOrCopyBatchItemsDestFolderIdParameter(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return CheckMoveOrCopyBatchItemsDestFolderIdParameter.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CheckMoveOrCopyBatchItemsDestFolderIdParameter.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
