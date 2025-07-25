/*
 * Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The user activation status.
    /// </summary>
    /// <value>The user activation status.</value>
    public enum EmployeeActivationStatus
    {
        /// <summary>
        /// Enum NotActivated for value: 0
        /// </summary>
        NotActivated = 0,

        /// <summary>
        /// Enum Activated for value: 1
        /// </summary>
        Activated = 1,

        /// <summary>
        /// Enum Pending for value: 2
        /// </summary>
        Pending = 2,

        /// <summary>
        /// Enum AutoGenerated for value: 4
        /// </summary>
        AutoGenerated = 4
    }

}
