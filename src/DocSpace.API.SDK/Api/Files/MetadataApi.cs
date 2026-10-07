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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.Files
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns></returns>
        void AssignFileTemplates(int fileId, AssignMetadataTemplates assignMetadataTemplates);

        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AssignFileTemplatesWithHttpInfo(int fileId, AssignMetadataTemplates assignMetadataTemplates);
        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>MetadataOperationWrapper</returns>
        MetadataOperationWrapper AssignFolderTemplates(int folderId, AssignMetadataTemplates assignMetadataTemplates);

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>ApiResponse of MetadataOperationWrapper</returns>
        ApiResponse<MetadataOperationWrapper> AssignFolderTemplatesWithHttpInfo(int folderId, AssignMetadataTemplates assignMetadataTemplates);
        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>MetadataFieldWrapper</returns>
        MetadataFieldWrapper CreateField(int templateId, MetadataFieldRequest metadataFieldRequest);

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>ApiResponse of MetadataFieldWrapper</returns>
        ApiResponse<MetadataFieldWrapper> CreateFieldWithHttpInfo(int templateId, MetadataFieldRequest metadataFieldRequest);
        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        MetadataTemplateWrapper CreateTemplate(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default);

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        ApiResponse<MetadataTemplateWrapper> CreateTemplateWithHttpInfo(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default);
        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns></returns>
        void DeleteField(int templateId, int fieldId);

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFieldWithHttpInfo(int templateId, int fieldId);
        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns></returns>
        void DeleteTemplate(int templateId);

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTemplateWithHttpInfo(int templateId);
        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>MetadataOperationWrapper</returns>
        MetadataOperationWrapper GetCascadeProgress(int folderId);

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>ApiResponse of MetadataOperationWrapper</returns>
        ApiResponse<MetadataOperationWrapper> GetCascadeProgressWithHttpInfo(int folderId);
        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        EntryMetadataWrapper GetFileMetadata(int fileId);

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        ApiResponse<EntryMetadataWrapper> GetFileMetadataWithHttpInfo(int fileId);
        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        EntryMetadataWrapper GetFolderMetadata(int folderId);

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        ApiResponse<EntryMetadataWrapper> GetFolderMetadataWithHttpInfo(int folderId);
        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        MetadataTemplateWrapper GetTemplate(int templateId);

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        ApiResponse<MetadataTemplateWrapper> GetTemplateWithHttpInfo(int templateId);
        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>MetadataTemplateArrayWrapper</returns>
        MetadataTemplateArrayWrapper GetTemplates(bool? visible = default);

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateArrayWrapper</returns>
        ApiResponse<MetadataTemplateArrayWrapper> GetTemplatesWithHttpInfo(bool? visible = default);
        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>CustomFieldValueArrayWrapper</returns>
        CustomFieldValueArrayWrapper SetFileCustomFields(int fileId, SetCustomFields setCustomFields);

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>ApiResponse of CustomFieldValueArrayWrapper</returns>
        ApiResponse<CustomFieldValueArrayWrapper> SetFileCustomFieldsWithHttpInfo(int fileId, SetCustomFields setCustomFields);
        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        EntryMetadataWrapper SetFileValues(int fileId, SetMetadataValues setMetadataValues);

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        ApiResponse<EntryMetadataWrapper> SetFileValuesWithHttpInfo(int fileId, SetMetadataValues setMetadataValues);
        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>CustomFieldValueArrayWrapper</returns>
        CustomFieldValueArrayWrapper SetFolderCustomFields(int folderId, SetCustomFields setCustomFields);

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>ApiResponse of CustomFieldValueArrayWrapper</returns>
        ApiResponse<CustomFieldValueArrayWrapper> SetFolderCustomFieldsWithHttpInfo(int folderId, SetCustomFields setCustomFields);
        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        EntryMetadataWrapper SetFolderValues(int folderId, SetMetadataValues setMetadataValues);

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        ApiResponse<EntryMetadataWrapper> SetFolderValuesWithHttpInfo(int folderId, SetMetadataValues setMetadataValues);
        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns></returns>
        void UnassignFileTemplate(int fileId, int templateId);

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnassignFileTemplateWithHttpInfo(int fileId, int templateId);
        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns></returns>
        void UnassignFolderTemplate(int folderId, int templateId);

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnassignFolderTemplateWithHttpInfo(int folderId, int templateId);
        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>MetadataFieldWrapper</returns>
        MetadataFieldWrapper UpdateField(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest);

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>ApiResponse of MetadataFieldWrapper</returns>
        ApiResponse<MetadataFieldWrapper> UpdateFieldWithHttpInfo(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest);
        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        MetadataTemplateWrapper UpdateTemplate(int templateId, UpdateMetadataTemplate updateMetadataTemplate);

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        ApiResponse<MetadataTemplateWrapper> UpdateTemplateWithHttpInfo(int templateId, UpdateMetadataTemplate updateMetadataTemplate);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>Task of void</returns>
        Task AssignFileTemplatesAsync(int fileId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> AssignFileTemplatesWithHttpInfoAsync(int fileId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>Task of MetadataOperationWrapper</returns>
        Task<MetadataOperationWrapper> AssignFolderTemplatesAsync(int folderId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataOperationWrapper)</returns>
        Task<ApiResponse<MetadataOperationWrapper>> AssignFolderTemplatesWithHttpInfoAsync(int folderId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>Task of MetadataFieldWrapper</returns>
        Task<MetadataFieldWrapper> CreateFieldAsync(int templateId, MetadataFieldRequest metadataFieldRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataFieldWrapper)</returns>
        Task<ApiResponse<MetadataFieldWrapper>> CreateFieldWithHttpInfoAsync(int templateId, MetadataFieldRequest metadataFieldRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        Task<MetadataTemplateWrapper> CreateTemplateAsync(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        Task<ApiResponse<MetadataTemplateWrapper>> CreateTemplateWithHttpInfoAsync(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteFieldAsync(int templateId, int fieldId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteFieldWithHttpInfoAsync(int templateId, int fieldId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteTemplateAsync(int templateId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteTemplateWithHttpInfoAsync(int templateId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>Task of MetadataOperationWrapper</returns>
        Task<MetadataOperationWrapper> GetCascadeProgressAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataOperationWrapper)</returns>
        Task<ApiResponse<MetadataOperationWrapper>> GetCascadeProgressWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        Task<EntryMetadataWrapper> GetFileMetadataAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        Task<ApiResponse<EntryMetadataWrapper>> GetFileMetadataWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        Task<EntryMetadataWrapper> GetFolderMetadataAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        Task<ApiResponse<EntryMetadataWrapper>> GetFolderMetadataWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        Task<MetadataTemplateWrapper> GetTemplateAsync(int templateId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        Task<ApiResponse<MetadataTemplateWrapper>> GetTemplateWithHttpInfoAsync(int templateId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>Task of MetadataTemplateArrayWrapper</returns>
        Task<MetadataTemplateArrayWrapper> GetTemplatesAsync(bool? visible = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateArrayWrapper)</returns>
        Task<ApiResponse<MetadataTemplateArrayWrapper>> GetTemplatesWithHttpInfoAsync(bool? visible = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>Task of CustomFieldValueArrayWrapper</returns>
        Task<CustomFieldValueArrayWrapper> SetFileCustomFieldsAsync(int fileId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>Task of ApiResponse (CustomFieldValueArrayWrapper)</returns>
        Task<ApiResponse<CustomFieldValueArrayWrapper>> SetFileCustomFieldsWithHttpInfoAsync(int fileId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        Task<EntryMetadataWrapper> SetFileValuesAsync(int fileId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        Task<ApiResponse<EntryMetadataWrapper>> SetFileValuesWithHttpInfoAsync(int fileId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>Task of CustomFieldValueArrayWrapper</returns>
        Task<CustomFieldValueArrayWrapper> SetFolderCustomFieldsAsync(int folderId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>Task of ApiResponse (CustomFieldValueArrayWrapper)</returns>
        Task<ApiResponse<CustomFieldValueArrayWrapper>> SetFolderCustomFieldsWithHttpInfoAsync(int folderId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        Task<EntryMetadataWrapper> SetFolderValuesAsync(int folderId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        Task<ApiResponse<EntryMetadataWrapper>> SetFolderValuesWithHttpInfoAsync(int folderId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        Task UnassignFileTemplateAsync(int fileId, int templateId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> UnassignFileTemplateWithHttpInfoAsync(int fileId, int templateId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        Task UnassignFolderTemplateAsync(int folderId, int templateId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> UnassignFolderTemplateWithHttpInfoAsync(int folderId, int templateId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>Task of MetadataFieldWrapper</returns>
        Task<MetadataFieldWrapper> UpdateFieldAsync(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataFieldWrapper)</returns>
        Task<ApiResponse<MetadataFieldWrapper>> UpdateFieldWithHttpInfoAsync(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        Task<MetadataTemplateWrapper> UpdateTemplateAsync(int templateId, UpdateMetadataTemplate updateMetadataTemplate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        Task<ApiResponse<MetadataTemplateWrapper>> UpdateTemplateWithHttpInfoAsync(int templateId, UpdateMetadataTemplate updateMetadataTemplate, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MetadataApi : IDisposable, IMetadataApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public MetadataApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public MetadataApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MetadataApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MetadataApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MetadataApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MetadataApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }


        
        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns></returns>
        public void AssignFileTemplates(int fileId, AssignMetadataTemplates assignMetadataTemplates)
        {
            AssignFileTemplatesWithHttpInfo(fileId, assignMetadataTemplates);
        }

        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AssignFileTemplatesWithHttpInfo(int fileId, AssignMetadataTemplates assignMetadataTemplates)
        {
            // verify the required parameter 'assignMetadataTemplates' is set
            if (assignMetadataTemplates == null)
                throw new ApiException(400, "Missing required parameter 'assignMetadataTemplates' when calling MetadataApi->AssignFileTemplates");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (assignMetadataTemplates != null) localVarRequestOptions.Data = assignMetadataTemplates;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<Object>("/api/2.0/files/metadata/file/{fileId}/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AssignFileTemplates", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task AssignFileTemplatesAsync(int fileId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default)
        {
            await AssignFileTemplatesWithHttpInfoAsync(fileId, assignMetadataTemplates, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Assign templates to a file
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a file, so its fields can be filled with  `PUT api/2.0/files/metadata/file/{fileId}/values`. The caller needs the right to edit the file. The assignment writes  no values and is idempotent: a template the file already carries is skipped, the others are added, an empty list  changes nothing. The call finishes in the request, nothing runs in the background. A template a cascading folder above  the file already provides stays inherited. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404. To take a template off the file use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-file-templates/">REST API Reference for AssignFileTemplates Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> AssignFileTemplatesWithHttpInfoAsync(int fileId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'assignMetadataTemplates' is set
            if (assignMetadataTemplates == null)
                throw new ApiException(400, "Missing required parameter 'assignMetadataTemplates' when calling MetadataApi->AssignFileTemplates");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (assignMetadataTemplates != null) localVarRequestOptions.Data = assignMetadataTemplates;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/files/metadata/file/{fileId}/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AssignFileTemplates", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>MetadataOperationWrapper</returns>
        public MetadataOperationWrapper AssignFolderTemplates(int folderId, AssignMetadataTemplates assignMetadataTemplates)
        {
            var localVarResponse = AssignFolderTemplatesWithHttpInfo(folderId, assignMetadataTemplates);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>ApiResponse of MetadataOperationWrapper</returns>
        public ApiResponse<MetadataOperationWrapper> AssignFolderTemplatesWithHttpInfo(int folderId, AssignMetadataTemplates assignMetadataTemplates)
        {
            // verify the required parameter 'assignMetadataTemplates' is set
            if (assignMetadataTemplates == null)
                throw new ApiException(400, "Missing required parameter 'assignMetadataTemplates' when calling MetadataApi->AssignFolderTemplates");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (assignMetadataTemplates != null) localVarRequestOptions.Data = assignMetadataTemplates;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<MetadataOperationWrapper>("/api/2.0/files/metadata/folder/{folderId}/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AssignFolderTemplates", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>Task of MetadataOperationWrapper</returns>
        public async Task<MetadataOperationWrapper> AssignFolderTemplatesAsync(int folderId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AssignFolderTemplatesWithHttpInfoAsync(folderId, assignMetadataTemplates, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign templates to a folder
        /// </summary>
        /// <remarks>
        /// Assigns one or more metadata templates to a folder or a room and, with `cascade` set, propagates them to every  folder and file below it. The caller needs the right to edit the folder; for a room that is its manager. The  assignment of the folder itself finishes in the request and writes no values. The cascade is asynchronous: a pass is  queued that assigns the templates to the whole subtree and copies the values the folder holds for their fields, and  the answer is the status of that pass. Poll `GET api/2.0/files/metadata/folder/{folderId}/templates/progress`  until `isCompleted` is true; a failed pass reports its `error` there. The `conflictResolveType` decides what happens  to a value an entry already holds: `Skip` keeps it, `Overwrite` replaces it with the folder's value. A folder inside  the subtree that cascades the same template keeps its own values for its content. Entries created in or moved into  the folder later inherit the templates and the values on their own. Without a cascade the answer is a completed  operation without an identifier. A folder the caller cannot edit is answered with 403; a folder, or a template, that  does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="assignMetadataTemplates">The parameters for assigning templates.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/assign-folder-templates/">REST API Reference for AssignFolderTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataOperationWrapper)</returns>
        public async Task<ApiResponse<MetadataOperationWrapper>> AssignFolderTemplatesWithHttpInfoAsync(int folderId, AssignMetadataTemplates assignMetadataTemplates, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'assignMetadataTemplates' is set
            if (assignMetadataTemplates == null)
                throw new ApiException(400, "Missing required parameter 'assignMetadataTemplates' when calling MetadataApi->AssignFolderTemplates");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (assignMetadataTemplates != null) localVarRequestOptions.Data = assignMetadataTemplates;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<MetadataOperationWrapper>("/api/2.0/files/metadata/folder/{folderId}/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AssignFolderTemplates", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>MetadataFieldWrapper</returns>
        public MetadataFieldWrapper CreateField(int templateId, MetadataFieldRequest metadataFieldRequest)
        {
            var localVarResponse = CreateFieldWithHttpInfo(templateId, metadataFieldRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>ApiResponse of MetadataFieldWrapper</returns>
        public ApiResponse<MetadataFieldWrapper> CreateFieldWithHttpInfo(int templateId, MetadataFieldRequest metadataFieldRequest)
        {
            // verify the required parameter 'metadataFieldRequest' is set
            if (metadataFieldRequest == null)
                throw new ApiException(400, "Missing required parameter 'metadataFieldRequest' when calling MetadataApi->CreateField");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            if (metadataFieldRequest != null) localVarRequestOptions.Data = metadataFieldRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<MetadataFieldWrapper>("/api/2.0/files/metadata/templates/{templateId}/fields", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateField", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>Task of MetadataFieldWrapper</returns>
        public async Task<MetadataFieldWrapper> CreateFieldAsync(int templateId, MetadataFieldRequest metadataFieldRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateFieldWithHttpInfoAsync(templateId, metadataFieldRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a metadata field
        /// </summary>
        /// <remarks>
        /// Adds a field to an existing metadata template. Only a DocSpace admin can change templates. The field name must be  unique within the template regardless of case and at most 255 characters, the type must be one of the published ones,  a choice field needs at least one option and unique option values, a field of another type takes no options. A  field without `order` is placed after the last field of the template. The entries the template is already  assigned to get the field without a value: nothing is written on them and no cascade runs. The answer is the  created field with its generated option identifiers. A template that does not exist is answered with 404, an  invalid field with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="metadataFieldRequest">The parameters of the field.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-field/">REST API Reference for CreateField Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataFieldWrapper)</returns>
        public async Task<ApiResponse<MetadataFieldWrapper>> CreateFieldWithHttpInfoAsync(int templateId, MetadataFieldRequest metadataFieldRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'metadataFieldRequest' is set
            if (metadataFieldRequest == null)
                throw new ApiException(400, "Missing required parameter 'metadataFieldRequest' when calling MetadataApi->CreateField");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            if (metadataFieldRequest != null) localVarRequestOptions.Data = metadataFieldRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<MetadataFieldWrapper>("/api/2.0/files/metadata/templates/{templateId}/fields", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateField", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        public MetadataTemplateWrapper CreateTemplate(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default)
        {
            var localVarResponse = CreateTemplateWithHttpInfo(createMetadataTemplateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        public ApiResponse<MetadataTemplateWrapper> CreateTemplateWithHttpInfo(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createMetadataTemplateRequestDto != null) localVarRequestOptions.Data = createMetadataTemplateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        public async Task<MetadataTemplateWrapper> CreateTemplateAsync(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateTemplateWithHttpInfoAsync(createMetadataTemplateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a metadata template
        /// </summary>
        /// <remarks>
        /// Creates a metadata template for the whole portal, optionally with its fields in one call. Only a DocSpace admin can  create templates. The template name must be unique on the portal regardless of case, at most 255 characters, and the  name `System` is reserved. Every field needs a name unique within the template and a type from the published set; a  choice field requires at least one option and the options must be unique, a field of another type takes no options.  A field without `order` is placed after the fields that have one, in the order of the request. The template and  its fields are stored together: an invalid field rejects the whole request and nothing is created.  The answer is the created template with its fields and the generated option identifiers, which the values written  with `PUT api/2.0/files/metadata/file/{fileId}/values` refer to. A name already in use or an invalid field is  answered with 400; the request of a member who is not a DocSpace admin with 403.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMetadataTemplateRequestDto">The request parameters for creating a metadata template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-template/">REST API Reference for CreateTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        public async Task<ApiResponse<MetadataTemplateWrapper>> CreateTemplateWithHttpInfoAsync(CreateMetadataTemplateRequestDto? createMetadataTemplateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createMetadataTemplateRequestDto != null) localVarRequestOptions.Data = createMetadataTemplateRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns></returns>
        public void DeleteField(int templateId, int fieldId)
        {
            DeleteFieldWithHttpInfo(templateId, fieldId);
        }

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFieldWithHttpInfo(int templateId, int fieldId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            localVarRequestOptions.PathParameters.Add("fieldId", ClientUtils.ParameterToString(fieldId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteField", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteFieldAsync(int templateId, int fieldId, CancellationToken cancellationToken = default)
        {
            await DeleteFieldWithHttpInfoAsync(templateId, fieldId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a metadata field
        /// </summary>
        /// <remarks>
        /// Deletes a metadata field from its template together with every value written for it on any file, folder or room of  the portal. Only a DocSpace admin can change templates. The deletion is irreversible: the affected entries lose the  value at once, their search documents are rebuilt and the clients viewing them are told to refresh. The template and  its other fields stay as they are. A field that does not exist, or that belongs to another template than the one in  the route, is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-field/">REST API Reference for DeleteField Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteFieldWithHttpInfoAsync(int templateId, int fieldId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            localVarRequestOptions.PathParameters.Add("fieldId", ClientUtils.ParameterToString(fieldId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteField", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns></returns>
        public void DeleteTemplate(int templateId)
        {
            DeleteTemplateWithHttpInfo(templateId);
        }

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTemplateWithHttpInfo(int templateId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteTemplateAsync(int templateId, CancellationToken cancellationToken = default)
        {
            await DeleteTemplateWithHttpInfoAsync(templateId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a metadata template
        /// </summary>
        /// <remarks>
        /// Deletes a metadata template together with its fields, its assignments and every value written for its fields on any  file, folder or room of the portal. Only a DocSpace admin can delete templates. The deletion is irreversible and there  is no confirmation: the affected entries lose the template at once, their search documents are rebuilt and the clients  viewing them are told to refresh. A template that does not exist, or was already deleted, is answered with 404.  To take the template off a single entry and keep it for the others use  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-template/">REST API Reference for DeleteTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteTemplateWithHttpInfoAsync(int templateId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>MetadataOperationWrapper</returns>
        public MetadataOperationWrapper GetCascadeProgress(int folderId)
        {
            var localVarResponse = GetCascadeProgressWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>ApiResponse of MetadataOperationWrapper</returns>
        public ApiResponse<MetadataOperationWrapper> GetCascadeProgressWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<MetadataOperationWrapper>("/api/2.0/files/metadata/folder/{folderId}/templates/progress", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCascadeProgress", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>Task of MetadataOperationWrapper</returns>
        public async Task<MetadataOperationWrapper> GetCascadeProgressAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCascadeProgressWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get cascade progress
        /// </summary>
        /// <remarks>
        /// Reports the cascade pass of a folder started by `PUT api/2.0/files/metadata/folder/{folderId}/templates`: the  running one, otherwise the most recent one. The caller needs read access to the folder, the call is read-only.  `progress` is the share of the subtree processed, `isCompleted` tells the pass is over and `error` carries the reason  of a failed one; a completed pass without an error has written every template and value it was asked for. A folder  that never cascaded, or whose passes were already dropped, is answered with a completed operation without an  identifier rather than with an error. A folder that does not exist is answered with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cascade-progress/">REST API Reference for GetCascadeProgress Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataOperationWrapper)</returns>
        public async Task<ApiResponse<MetadataOperationWrapper>> GetCascadeProgressWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<MetadataOperationWrapper>("/api/2.0/files/metadata/folder/{folderId}/templates/progress", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCascadeProgress", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        public EntryMetadataWrapper GetFileMetadata(int fileId)
        {
            var localVarResponse = GetFileMetadataWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        public ApiResponse<EntryMetadataWrapper> GetFileMetadataWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<EntryMetadataWrapper>("/api/2.0/files/metadata/file/{fileId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileMetadata", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        public async Task<EntryMetadataWrapper> GetFileMetadataAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileMetadataWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a file: the templates assigned to it, directly or inherited from a cascading folder above  it, each with its fields, and the custom text fields set on the file. The caller needs read access to the file: a  member of the portal, or an anonymous caller through an external link that grants access to the file or to a  folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The call is  read-only. A field carries its value inside it; a field the file holds no value for comes without a `value`.  The custom fields are name and value pairs and are not part of any template. A file without metadata is answered with  empty lists, not with an error. The same shape is returned by `PUT api/2.0/files/metadata/file/{fileId}/values`  after a write. A request with neither a session nor a link key is answered with 401; a file the caller cannot read  with 403, a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file the operation addresses. Take the identifier from a listing such as `GET api/2.0/files/{folderId}`: a  file stored on the portal is numbered, while a file in a connected third-party account is named by an opaque  string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-metadata/">REST API Reference for GetFileMetadata Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        public async Task<ApiResponse<EntryMetadataWrapper>> GetFileMetadataWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<EntryMetadataWrapper>("/api/2.0/files/metadata/file/{fileId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileMetadata", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        public EntryMetadataWrapper GetFolderMetadata(int folderId)
        {
            var localVarResponse = GetFolderMetadataWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        public ApiResponse<EntryMetadataWrapper> GetFolderMetadataWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<EntryMetadataWrapper>("/api/2.0/files/metadata/folder/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderMetadata", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        public async Task<EntryMetadataWrapper> GetFolderMetadataAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderMetadataWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder metadata
        /// </summary>
        /// <remarks>
        /// Returns the metadata of a folder or a room: the templates assigned to it, directly or inherited from a cascading  folder above it, each with its fields, and the custom text fields set on it. The caller needs read access to the  folder: a member of the portal, or an anonymous caller through an external link that grants access to the folder  or to a folder above it, with the link key in the `Request-Token` header or in the `share` query parameter. The  call is read-only. A field carries its value inside it; a field the folder holds no value for comes without a  `value`. The custom fields are name and value pairs and are not part of any template. A folder without metadata is  answered with empty lists, not with an error. Whether a template cascades from this folder to its content is not  reported here. A request with neither a session nor a link key is answered with 401; a folder the caller cannot  read with 403, a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-metadata/">REST API Reference for GetFolderMetadata Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        public async Task<ApiResponse<EntryMetadataWrapper>> GetFolderMetadataWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<EntryMetadataWrapper>("/api/2.0/files/metadata/folder/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderMetadata", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        public MetadataTemplateWrapper GetTemplate(int templateId)
        {
            var localVarResponse = GetTemplateWithHttpInfo(templateId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        public ApiResponse<MetadataTemplateWrapper> GetTemplateWithHttpInfo(int templateId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        public async Task<MetadataTemplateWrapper> GetTemplateAsync(int templateId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTemplateWithHttpInfoAsync(templateId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a metadata template
        /// </summary>
        /// <remarks>
        /// Returns one metadata template with its fields, in their display order, and the options of its choice fields. Any  member of the portal can read a template, the call is read-only. Use it to resolve the template identifiers a file or  a folder reports in `assignedMetadataTemplates` into names and fields. A template that does not exist is answered  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-template/">REST API Reference for GetTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        public async Task<ApiResponse<MetadataTemplateWrapper>> GetTemplateWithHttpInfoAsync(int templateId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>MetadataTemplateArrayWrapper</returns>
        public MetadataTemplateArrayWrapper GetTemplates(bool? visible = default)
        {
            var localVarResponse = GetTemplatesWithHttpInfo(visible);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateArrayWrapper</returns>
        public ApiResponse<MetadataTemplateArrayWrapper> GetTemplatesWithHttpInfo(bool? visible = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (visible != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "visible", visible));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<MetadataTemplateArrayWrapper>("/api/2.0/files/metadata/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTemplates", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>Task of MetadataTemplateArrayWrapper</returns>
        public async Task<MetadataTemplateArrayWrapper> GetTemplatesAsync(bool? visible = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTemplatesWithHttpInfoAsync(visible, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get metadata templates
        /// </summary>
        /// <remarks>
        /// Lists the metadata templates of the portal with their fields, the dictionary a file, a folder or a room is described  with. Any member of the portal can read it, the list is the same for everyone. The call is read-only. The templates  come back ordered by their creation, each with its fields in their display order and the choice options of the choice  fields; the `visible` parameter narrows the list to the templates shown in the pickers or to the hidden ones, without  it both are returned. An empty list means the portal has no templates yet. The custom text fields set on the entries  are not templates and are not listed here: read them on the entry with `GET api/2.0/files/metadata/file/{fileId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visible">Filters the templates by their visibility. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-templates/">REST API Reference for GetTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateArrayWrapper)</returns>
        public async Task<ApiResponse<MetadataTemplateArrayWrapper>> GetTemplatesWithHttpInfoAsync(bool? visible = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (visible != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "visible", visible));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<MetadataTemplateArrayWrapper>("/api/2.0/files/metadata/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTemplates", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>CustomFieldValueArrayWrapper</returns>
        public CustomFieldValueArrayWrapper SetFileCustomFields(int fileId, SetCustomFields setCustomFields)
        {
            var localVarResponse = SetFileCustomFieldsWithHttpInfo(fileId, setCustomFields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>ApiResponse of CustomFieldValueArrayWrapper</returns>
        public ApiResponse<CustomFieldValueArrayWrapper> SetFileCustomFieldsWithHttpInfo(int fileId, SetCustomFields setCustomFields)
        {
            // verify the required parameter 'setCustomFields' is set
            if (setCustomFields == null)
                throw new ApiException(400, "Missing required parameter 'setCustomFields' when calling MetadataApi->SetFileCustomFields");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (setCustomFields != null) localVarRequestOptions.Data = setCustomFields;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<CustomFieldValueArrayWrapper>("/api/2.0/files/metadata/file/{fileId}/customfields", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileCustomFields", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>Task of CustomFieldValueArrayWrapper</returns>
        public async Task<CustomFieldValueArrayWrapper> SetFileCustomFieldsAsync(int fileId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFileCustomFieldsWithHttpInfoAsync(fileId, setCustomFields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a file: free-form name and value pairs that need no template. The caller needs the  right to edit the file. A field is addressed by its name regardless of case: a listed name gets the value, a null or  empty value removes the field from the file, the names not listed are left alone, so a partial request is safe. A name  the portal has not seen yet creates the field for the whole portal, and a name no entry holds a value for any more is  dropped, so the set of names follows the values. A name is at most 255 characters, a value at most 8000, a name may  be listed once and a file holds at most 50 custom fields. The write finishes in the request; the values take part in  the free text search and in the `metadataFilters` of the listings. The answer is the custom fields of the file  after the write. An empty list, a blank, repeated or over-long name, an over-long value or more than 50 fields is  answered with 400; a file the caller cannot edit with 403; a file that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-custom-fields/">REST API Reference for SetFileCustomFields Operation</seealso>
        /// <returns>Task of ApiResponse (CustomFieldValueArrayWrapper)</returns>
        public async Task<ApiResponse<CustomFieldValueArrayWrapper>> SetFileCustomFieldsWithHttpInfoAsync(int fileId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setCustomFields' is set
            if (setCustomFields == null)
                throw new ApiException(400, "Missing required parameter 'setCustomFields' when calling MetadataApi->SetFileCustomFields");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (setCustomFields != null) localVarRequestOptions.Data = setCustomFields;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<CustomFieldValueArrayWrapper>("/api/2.0/files/metadata/file/{fileId}/customfields", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileCustomFields", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        public EntryMetadataWrapper SetFileValues(int fileId, SetMetadataValues setMetadataValues)
        {
            var localVarResponse = SetFileValuesWithHttpInfo(fileId, setMetadataValues);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        public ApiResponse<EntryMetadataWrapper> SetFileValuesWithHttpInfo(int fileId, SetMetadataValues setMetadataValues)
        {
            // verify the required parameter 'setMetadataValues' is set
            if (setMetadataValues == null)
                throw new ApiException(400, "Missing required parameter 'setMetadataValues' when calling MetadataApi->SetFileValues");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (setMetadataValues != null) localVarRequestOptions.Data = setMetadataValues;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<EntryMetadataWrapper>("/api/2.0/files/metadata/file/{fileId}/values", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileValues", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        public async Task<EntryMetadataWrapper> SetFileValuesAsync(int fileId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFileValuesWithHttpInfoAsync(fileId, setMetadataValues, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a file. The caller needs the right to edit the file: a member with editing  access, or an anonymous caller through an external link that grants editing, with the link key in the  `Request-Token` header or in the `share` query parameter; a link that grants viewing, commenting, reviewing or  form filling only is refused. Every field must belong to a template the file carries, assigned with  `PUT api/2.0/files/metadata/file/{fileId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field, a single option  for a single choice; an empty value clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request, the file is re-indexed for the metadata filters at once. The custom text fields are not  written here: use `PUT api/2.0/files/metadata/file/{fileId}/customFields`. The answer is the whole metadata of the  file after the write, the same shape `GET api/2.0/files/metadata/file/{fileId}` returns. A value of the wrong type,  a field of a template the file does not carry, a field listed twice or a custom field is answered with 400; a  request with neither a session nor a link key with 401; a file the caller cannot edit with 403; a file or a field  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-values/">REST API Reference for SetFileValues Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        public async Task<ApiResponse<EntryMetadataWrapper>> SetFileValuesWithHttpInfoAsync(int fileId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setMetadataValues' is set
            if (setMetadataValues == null)
                throw new ApiException(400, "Missing required parameter 'setMetadataValues' when calling MetadataApi->SetFileValues");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (setMetadataValues != null) localVarRequestOptions.Data = setMetadataValues;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<EntryMetadataWrapper>("/api/2.0/files/metadata/file/{fileId}/values", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileValues", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>CustomFieldValueArrayWrapper</returns>
        public CustomFieldValueArrayWrapper SetFolderCustomFields(int folderId, SetCustomFields setCustomFields)
        {
            var localVarResponse = SetFolderCustomFieldsWithHttpInfo(folderId, setCustomFields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>ApiResponse of CustomFieldValueArrayWrapper</returns>
        public ApiResponse<CustomFieldValueArrayWrapper> SetFolderCustomFieldsWithHttpInfo(int folderId, SetCustomFields setCustomFields)
        {
            // verify the required parameter 'setCustomFields' is set
            if (setCustomFields == null)
                throw new ApiException(400, "Missing required parameter 'setCustomFields' when calling MetadataApi->SetFolderCustomFields");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (setCustomFields != null) localVarRequestOptions.Data = setCustomFields;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<CustomFieldValueArrayWrapper>("/api/2.0/files/metadata/folder/{folderId}/customfields", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderCustomFields", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>Task of CustomFieldValueArrayWrapper</returns>
        public async Task<CustomFieldValueArrayWrapper> SetFolderCustomFieldsAsync(int folderId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFolderCustomFieldsWithHttpInfoAsync(folderId, setCustomFields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder custom fields
        /// </summary>
        /// <remarks>
        /// Sets the custom text fields of a folder or a room: free-form name and value pairs that need no template. The  caller needs the right to edit the folder; for a room that is its manager. A field is addressed by its name  regardless of case: a listed name gets the value, a null or empty value removes the field, the names not listed  are left alone. A name the portal has not seen yet creates the field for the whole portal, and a name no entry  holds a value for any more is dropped. A name is at most 255 characters, a value at most  8000, a name may be listed once and a folder holds at most 50 custom fields. The custom fields never cascade to the  content of the folder. The write finishes in the request; the values take part in the free text search and in the  `metadataFilters` of the listings. The answer is the custom fields of the folder after the write. An empty list, a  blank, repeated or over-long name, an over-long value or more than 50 fields is answered with 400; a folder the  caller cannot edit with 403; a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setCustomFields">The custom fields to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-custom-fields/">REST API Reference for SetFolderCustomFields Operation</seealso>
        /// <returns>Task of ApiResponse (CustomFieldValueArrayWrapper)</returns>
        public async Task<ApiResponse<CustomFieldValueArrayWrapper>> SetFolderCustomFieldsWithHttpInfoAsync(int folderId, SetCustomFields setCustomFields, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setCustomFields' is set
            if (setCustomFields == null)
                throw new ApiException(400, "Missing required parameter 'setCustomFields' when calling MetadataApi->SetFolderCustomFields");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (setCustomFields != null) localVarRequestOptions.Data = setCustomFields;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<CustomFieldValueArrayWrapper>("/api/2.0/files/metadata/folder/{folderId}/customfields", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderCustomFields", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>EntryMetadataWrapper</returns>
        public EntryMetadataWrapper SetFolderValues(int folderId, SetMetadataValues setMetadataValues)
        {
            var localVarResponse = SetFolderValuesWithHttpInfo(folderId, setMetadataValues);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>ApiResponse of EntryMetadataWrapper</returns>
        public ApiResponse<EntryMetadataWrapper> SetFolderValuesWithHttpInfo(int folderId, SetMetadataValues setMetadataValues)
        {
            // verify the required parameter 'setMetadataValues' is set
            if (setMetadataValues == null)
                throw new ApiException(400, "Missing required parameter 'setMetadataValues' when calling MetadataApi->SetFolderValues");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (setMetadataValues != null) localVarRequestOptions.Data = setMetadataValues;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<EntryMetadataWrapper>("/api/2.0/files/metadata/folder/{folderId}/values", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderValues", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>Task of EntryMetadataWrapper</returns>
        public async Task<EntryMetadataWrapper> SetFolderValuesAsync(int folderId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFolderValuesWithHttpInfoAsync(folderId, setMetadataValues, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder metadata values
        /// </summary>
        /// <remarks>
        /// Writes the values of metadata fields on a folder or a room. The caller needs the right to edit the folder; for a  room that is its manager. Every field must belong to a template the folder carries, assigned with  `PUT api/2.0/files/metadata/folder/{folderId}/templates` or inherited from a cascading folder, and a field may be  listed once. A value carries exactly the member of its type: `stringValue` for a text field of at most 8000  characters, `numberValue` for a number, `dateValue` for a date, `optionIds` for a choice field; an empty value  clears the field. A date without a time zone offset is read as UTC. The write  finishes in the request and touches the folder only: to push the new values down a cascading folder run the  cascade again with `Overwrite`, while entries created or moved in later take them on their own. The custom text  fields are written with `PUT api/2.0/files/metadata/folder/{folderId}/customFields` instead. The answer is the  whole metadata of the folder after the write. A value of the wrong type, a field listed twice, a custom field or a  field of a template the folder does not carry is answered with 400; a folder the caller cannot edit with 403; a  folder or a field that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="setMetadataValues">The parameters for setting values.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-values/">REST API Reference for SetFolderValues Operation</seealso>
        /// <returns>Task of ApiResponse (EntryMetadataWrapper)</returns>
        public async Task<ApiResponse<EntryMetadataWrapper>> SetFolderValuesWithHttpInfoAsync(int folderId, SetMetadataValues setMetadataValues, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setMetadataValues' is set
            if (setMetadataValues == null)
                throw new ApiException(400, "Missing required parameter 'setMetadataValues' when calling MetadataApi->SetFolderValues");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (setMetadataValues != null) localVarRequestOptions.Data = setMetadataValues;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<EntryMetadataWrapper>("/api/2.0/files/metadata/folder/{folderId}/values", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderValues", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns></returns>
        public void UnassignFileTemplate(int fileId, int templateId)
        {
            UnassignFileTemplateWithHttpInfo(fileId, templateId);
        }

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnassignFileTemplateWithHttpInfo(int fileId, int templateId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/metadata/file/{fileId}/templates/{templateId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnassignFileTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task UnassignFileTemplateAsync(int fileId, int templateId, CancellationToken cancellationToken = default)
        {
            await UnassignFileTemplateWithHttpInfoAsync(fileId, templateId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unassign a template from a file
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a file together with the values of its fields. The caller needs the right to edit  the file. The removal is irreversible for the values, the template itself stays on the portal and on the other  entries. It applies to a directly assigned template and to one inherited from a cascading folder alike; a later  cascade from that folder assigns it again. A file the caller cannot edit is answered with 403; a file, or a template,  that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-file-template/">REST API Reference for UnassignFileTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> UnassignFileTemplateWithHttpInfoAsync(int fileId, int templateId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/metadata/file/{fileId}/templates/{templateId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnassignFileTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns></returns>
        public void UnassignFolderTemplate(int folderId, int templateId)
        {
            UnassignFolderTemplateWithHttpInfo(folderId, templateId);
        }

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnassignFolderTemplateWithHttpInfo(int folderId, int templateId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/metadata/folder/{folderId}/templates/{templateId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnassignFolderTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task UnassignFolderTemplateAsync(int folderId, int templateId, CancellationToken cancellationToken = default)
        {
            await UnassignFolderTemplateWithHttpInfoAsync(folderId, templateId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unassign a template from a folder
        /// </summary>
        /// <remarks>
        /// Removes a metadata template from a folder or a room together with the values of its fields. The caller needs the  right to edit the folder; for a room that is its manager. When the template was cascaded from this folder, the  cascade stops here: the folders and files below keep the template and their values as a direct assignment of their  own, and there is no bulk rollback. To take the template off them as well, remove it entry by entry with  `DELETE api/2.0/files/metadata/file/{fileId}/templates/{templateId}`. A pass of the cascade still running is stopped  for this template. A folder the caller cannot edit is answered with 403; a folder, or a template, that does not exist  with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="templateId">The template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unassign-folder-template/">REST API Reference for UnassignFolderTemplate Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> UnassignFolderTemplateWithHttpInfoAsync(int folderId, int templateId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/metadata/folder/{folderId}/templates/{templateId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnassignFolderTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>MetadataFieldWrapper</returns>
        public MetadataFieldWrapper UpdateField(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest)
        {
            var localVarResponse = UpdateFieldWithHttpInfo(templateId, fieldId, updateMetadataFieldRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>ApiResponse of MetadataFieldWrapper</returns>
        public ApiResponse<MetadataFieldWrapper> UpdateFieldWithHttpInfo(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest)
        {
            // verify the required parameter 'updateMetadataFieldRequest' is set
            if (updateMetadataFieldRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateMetadataFieldRequest' when calling MetadataApi->UpdateField");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            localVarRequestOptions.PathParameters.Add("fieldId", ClientUtils.ParameterToString(fieldId)); // path parameter
            if (updateMetadataFieldRequest != null) localVarRequestOptions.Data = updateMetadataFieldRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<MetadataFieldWrapper>("/api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateField", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>Task of MetadataFieldWrapper</returns>
        public async Task<MetadataFieldWrapper> UpdateFieldAsync(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateFieldWithHttpInfoAsync(templateId, fieldId, updateMetadataFieldRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a metadata field
        /// </summary>
        /// <remarks>
        /// Changes the name, the type, the options or the display order of a metadata field. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value. The type can be changed only while no entry  holds a value for the field, and an option can be removed only while no entry has selected it; a new option is sent  without an identifier and gets one in the answer. A new name must be unique within the template regardless of case.  The values already written are left as they are. The field is addressed through its own template: a field reached  through another template's route is answered with 404, the same as a field that does not exist. A conflicting name,  a type change on a field with values or the removal of an option in use is answered with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="fieldId">The field ID.</param>
        /// <param name="updateMetadataFieldRequest">The parameters of the field update.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-field/">REST API Reference for UpdateField Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataFieldWrapper)</returns>
        public async Task<ApiResponse<MetadataFieldWrapper>> UpdateFieldWithHttpInfoAsync(int templateId, int fieldId, UpdateMetadataFieldRequest updateMetadataFieldRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateMetadataFieldRequest' is set
            if (updateMetadataFieldRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateMetadataFieldRequest' when calling MetadataApi->UpdateField");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            localVarRequestOptions.PathParameters.Add("fieldId", ClientUtils.ParameterToString(fieldId)); // path parameter
            if (updateMetadataFieldRequest != null) localVarRequestOptions.Data = updateMetadataFieldRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<MetadataFieldWrapper>("/api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateField", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>MetadataTemplateWrapper</returns>
        public MetadataTemplateWrapper UpdateTemplate(int templateId, UpdateMetadataTemplate updateMetadataTemplate)
        {
            var localVarResponse = UpdateTemplateWithHttpInfo(templateId, updateMetadataTemplate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>ApiResponse of MetadataTemplateWrapper</returns>
        public ApiResponse<MetadataTemplateWrapper> UpdateTemplateWithHttpInfo(int templateId, UpdateMetadataTemplate updateMetadataTemplate)
        {
            // verify the required parameter 'updateMetadataTemplate' is set
            if (updateMetadataTemplate == null)
                throw new ApiException(400, "Missing required parameter 'updateMetadataTemplate' when calling MetadataApi->UpdateTemplate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            if (updateMetadataTemplate != null) localVarRequestOptions.Data = updateMetadataTemplate;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>Task of MetadataTemplateWrapper</returns>
        public async Task<MetadataTemplateWrapper> UpdateTemplateAsync(int templateId, UpdateMetadataTemplate updateMetadataTemplate, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateTemplateWithHttpInfoAsync(templateId, updateMetadataTemplate, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a metadata template
        /// </summary>
        /// <remarks>
        /// Renames a metadata template or changes whether it is shown in the pickers. Only a DocSpace admin can change  templates. The request is partial: a property left out keeps its value, the fields are not touched here and are  changed with `PUT api/2.0/files/metadata/templates/{templateId}/fields/{fieldId}`. The new name follows the rules  of the creation: unique on the portal regardless of case and at most 255 characters. The answer is the whole template  with its fields. A template that does not exist is answered with 404, a name already in use or too long with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template ID.</param>
        /// <param name="updateMetadataTemplate">The parameters for updating the template.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-template/">REST API Reference for UpdateTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (MetadataTemplateWrapper)</returns>
        public async Task<ApiResponse<MetadataTemplateWrapper>> UpdateTemplateWithHttpInfoAsync(int templateId, UpdateMetadataTemplate updateMetadataTemplate, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateMetadataTemplate' is set
            if (updateMetadataTemplate == null)
                throw new ApiException(400, "Missing required parameter 'updateMetadataTemplate' when calling MetadataApi->UpdateTemplate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("templateId", ClientUtils.ParameterToString(templateId)); // path parameter
            if (updateMetadataTemplate != null) localVarRequestOptions.Data = updateMetadataTemplate;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<MetadataTemplateWrapper>("/api/2.0/files/metadata/templates/{templateId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
