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



namespace DocSpace.Sdk.Model
{
    /// <summary>
    ///  Abstract base class for oneOf, anyOf schemas in the OpenAPI specification
    /// </summary>
    public abstract partial class AbstractOpenAPISchema
    {
        /// <summary>
        ///  Custom JSON serializer
        /// </summary>
        static public readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            // OpenAPI generated types generally hide default constructors.
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

        /// <summary>
        ///  Custom JSON serializer for objects with additional properties
        /// </summary>
        static public readonly JsonSerializerOptions AdditionalPropertiesSerializerOptions = new JsonSerializerOptions
        {
            // OpenAPI generated types generally hide default constructors.
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.Never,
            Converters = {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

        /// <summary>
        /// Gets or Sets the actual instance
        /// </summary>
        public abstract Object ActualInstance { get; set; }

        /// <summary>
        /// Gets or Sets IsNullable to indicate whether the instance is nullable
        /// </summary>
        public bool IsNullable { get; protected set; }

        /// <summary>
        /// Gets or Sets the schema type, which can be either `oneOf` or `anyOf`
        /// </summary>
        public string SchemaType { get; protected set; }

        /// <summary>
        /// Converts the instance into JSON string.
        /// </summary>
        public abstract string ToJson();
    }
}
