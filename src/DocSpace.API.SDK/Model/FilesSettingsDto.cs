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

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The file settings parameters.
    /// </summary>
    [DataContract(Name = "FilesSettingsDto")]
    public partial class FilesSettingsDto : IValidatableObject
    {
        /// <summary>
        /// The default access rights in sharing settings.
        /// </summary>
        /// <value>The default access rights in sharing settings.</value>
        public enum DefaultSharingAccessRightsEnum
        {
            /// <summary>
            /// Enum None for value: 0
            /// </summary>
            None = 0,

            /// <summary>
            /// Enum ReadWrite for value: 1
            /// </summary>
            ReadWrite = 1,

            /// <summary>
            /// Enum Read for value: 2
            /// </summary>
            Read = 2,

            /// <summary>
            /// Enum Restrict for value: 3
            /// </summary>
            Restrict = 3,

            /// <summary>
            /// Enum Varies for value: 4
            /// </summary>
            Varies = 4,

            /// <summary>
            /// Enum Review for value: 5
            /// </summary>
            Review = 5,

            /// <summary>
            /// Enum Comment for value: 6
            /// </summary>
            Comment = 6,

            /// <summary>
            /// Enum FillForms for value: 7
            /// </summary>
            FillForms = 7,

            /// <summary>
            /// Enum CustomFilter for value: 8
            /// </summary>
            CustomFilter = 8,

            /// <summary>
            /// Enum RoomManager for value: 9
            /// </summary>
            RoomManager = 9,

            /// <summary>
            /// Enum Editing for value: 10
            /// </summary>
            Editing = 10,

            /// <summary>
            /// Enum ContentCreator for value: 11
            /// </summary>
            ContentCreator = 11
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsDto" /> class.
        /// </summary>
        /// <param name="extsImagePreviewed">The list of extensions of the viewed images..</param>
        /// <param name="extsMediaPreviewed">The list of extensions of the viewed media files..</param>
        /// <param name="extsWebPreviewed">The list of extensions of the viewed files..</param>
        /// <param name="extsWebEdited">The list of extensions of the edited files..</param>
        /// <param name="extsWebEncrypt">The list of extensions of the encrypted files..</param>
        /// <param name="extsWebReviewed">The list of extensions of the reviewed files..</param>
        /// <param name="extsWebCustomFilterEditing">The list of extensions of the custom filter files..</param>
        /// <param name="extsWebRestrictedEditing">The list of extensions of the files that are restricted for editing..</param>
        /// <param name="extsWebCommented">The list of extensions of the commented files..</param>
        /// <param name="extsWebTemplate">The list of extensions of the template files..</param>
        /// <param name="extsMustConvert">The list of extensions of the files that must be converted..</param>
        /// <param name="extsConvertible">The list of the convertible extensions..</param>
        /// <param name="extsUploadable">The list of the uploadable extensions..</param>
        /// <param name="extsArchive">The list of extensions of the archive files..</param>
        /// <param name="extsVideo">The list of the video extensions..</param>
        /// <param name="extsAudio">The list of the audio extensions..</param>
        /// <param name="extsImage">The list of the image extensions..</param>
        /// <param name="extsSpreadsheet">The list of the spreadsheet extensions..</param>
        /// <param name="extsPresentation">The list of the presentation extensions..</param>
        /// <param name="extsDocument">The list of the text document extensions..</param>
        /// <param name="extsDiagram">The list of the diagram extensions..</param>
        /// <param name="internalFormats">internalFormats.</param>
        /// <param name="masterFormExtension">The master form extension..</param>
        /// <param name="paramVersion">The URL parameter which specifies the file version..</param>
        /// <param name="paramOutType">The URL parameter which specifies the output type of the converted file..</param>
        /// <param name="fileDownloadUrlString">The URL to download a file..</param>
        /// <param name="fileWebViewerUrlString">The URL to the file web viewer..</param>
        /// <param name="fileWebViewerExternalUrlString">The external URL to the file web viewer..</param>
        /// <param name="fileWebEditorUrlString">The URL to the file web editor..</param>
        /// <param name="fileWebEditorExternalUrlString">The external URL to the file web editor..</param>
        /// <param name="fileRedirectPreviewUrlString">The redirect URL to the file viewer..</param>
        /// <param name="fileThumbnailUrlString">The URL to the file thumbnail..</param>
        /// <param name="confirmDelete">Specifies whether to confirm the file deletion or not..</param>
        /// <param name="enableThirdParty">Specifies whether to allow users to connect the third-party storages..</param>
        /// <param name="externalShare">Specifies whether to enable sharing external links to the files..</param>
        /// <param name="externalShareSocialMedia">Specifies whether to enable sharing files on social media..</param>
        /// <param name="storeOriginalFiles">Specifies whether to enable storing original files..</param>
        /// <param name="keepNewFileName">Specifies whether to keep the new file name..</param>
        /// <param name="displayFileExtension">Specifies whether to display the file extension..</param>
        /// <param name="convertNotify">Specifies whether to display the conversion notification..</param>
        /// <param name="hideConfirmCancelOperation">Specifies whether to hide the confirmation dialog for the cancel operation..</param>
        /// <param name="hideConfirmConvertSave">Specifies whether to hide the confirmation dialog  for saving the file copy in the original format when converting a file..</param>
        /// <param name="hideConfirmConvertOpen">Specifies whether to hide the confirmation dialog  for opening the conversion result..</param>
        /// <param name="hideConfirmRoomLifetime">Specifies whether to hide the confirmation dialog about the file lifetime in the room..</param>
        /// <param name="defaultOrder">defaultOrder.</param>
        /// <param name="forcesave">Specifies whether to forcesave the files or not..</param>
        /// <param name="storeForcesave">Specifies whether to store the forcesaved file versions or not..</param>
        /// <param name="recentSection">Specifies if the Recent section is displayed or not..</param>
        /// <param name="favoritesSection">Specifies if the Favorites section is displayed or not..</param>
        /// <param name="templatesSection">Specifies if the Templates section is displayed or not..</param>
        /// <param name="downloadTarGz">Specifies whether to download the .tar.gz files or not..</param>
        /// <param name="automaticallyCleanUp">automaticallyCleanUp.</param>
        /// <param name="canSearchByContent">Specifies whether the file can be searched by its content or not..</param>
        /// <param name="defaultSharingAccessRights">The default access rights in sharing settings..</param>
        /// <param name="maxUploadThreadCount">The maximum number of upload threads..</param>
        /// <param name="chunkUploadSize">The size of a large file that is uploaded in chunks..</param>
        /// <param name="openEditorInSameTab">Specifies whether to open the editor in the same tab or not..</param>
        /// <param name="organizeRoomsGrouping">Specifies whether the grouping of rooms is enabled or not..</param>
        /// <param name="defaultShareLinkInternal">Specifies the default sharing link type: true = DocSpace users only (internal), false = Anyone with the link..</param>
        /// <param name="externalShareApplyToDocuments">When external sharing is restricted, specifies whether the restriction applies to the My Documents section..</param>
        /// <param name="externalShareApplyToRooms">When external sharing is restricted, specifies whether the restriction applies to the Rooms section..</param>
        /// <param name="blockExistingLinksOnRestrict">When external sharing is restricted, specifies whether existing public links are blocked immediately..</param>
        /// <param name="extsFilesVectorized">List of extensions available for vectorization.</param>
        /// <param name="maxVectorizationFileSize">The maximum file size for vectorization.</param>
        public FilesSettingsDto(List<string> extsImagePreviewed = default, List<string> extsMediaPreviewed = default, List<string> extsWebPreviewed = default, List<string> extsWebEdited = default, List<string> extsWebEncrypt = default, List<string> extsWebReviewed = default, List<string> extsWebCustomFilterEditing = default, List<string> extsWebRestrictedEditing = default, List<string> extsWebCommented = default, List<string> extsWebTemplate = default, List<string> extsMustConvert = default, Dictionary<string, List<string>> extsConvertible = default, List<string> extsUploadable = default, List<string> extsArchive = default, List<string> extsVideo = default, List<string> extsAudio = default, List<string> extsImage = default, List<string> extsSpreadsheet = default, List<string> extsPresentation = default, List<string> extsDocument = default, List<string> extsDiagram = default, FilesSettingsDtoInternalFormats internalFormats = default, string masterFormExtension = default, string paramVersion = default, string paramOutType = default, string fileDownloadUrlString = default, string fileWebViewerUrlString = default, string fileWebViewerExternalUrlString = default, string fileWebEditorUrlString = default, string fileWebEditorExternalUrlString = default, string fileRedirectPreviewUrlString = default, string fileThumbnailUrlString = default, bool confirmDelete = default, bool enableThirdParty = default, bool externalShare = default, bool externalShareSocialMedia = default, bool storeOriginalFiles = default, bool keepNewFileName = default, bool displayFileExtension = default, bool convertNotify = default, bool hideConfirmCancelOperation = default, bool hideConfirmConvertSave = default, bool hideConfirmConvertOpen = default, bool hideConfirmRoomLifetime = default, OrderBy defaultOrder = default, bool forcesave = default, bool storeForcesave = default, bool recentSection = default, bool favoritesSection = default, bool templatesSection = default, bool downloadTarGz = default, AutoCleanUpData automaticallyCleanUp = default, bool canSearchByContent = default, List<FilesSettingsDto.DefaultSharingAccessRightsEnum> defaultSharingAccessRights = default, int maxUploadThreadCount = default, long chunkUploadSize = default, bool openEditorInSameTab = default, bool organizeRoomsGrouping = default, bool defaultShareLinkInternal = default, bool externalShareApplyToDocuments = default, bool externalShareApplyToRooms = default, bool blockExistingLinksOnRestrict = default, List<string> extsFilesVectorized = default, long maxVectorizationFileSize = default)
        {
            this.ExtsImagePreviewed = extsImagePreviewed;
            this.ExtsMediaPreviewed = extsMediaPreviewed;
            this.ExtsWebPreviewed = extsWebPreviewed;
            this.ExtsWebEdited = extsWebEdited;
            this.ExtsWebEncrypt = extsWebEncrypt;
            this.ExtsWebReviewed = extsWebReviewed;
            this.ExtsWebCustomFilterEditing = extsWebCustomFilterEditing;
            this.ExtsWebRestrictedEditing = extsWebRestrictedEditing;
            this.ExtsWebCommented = extsWebCommented;
            this.ExtsWebTemplate = extsWebTemplate;
            this.ExtsMustConvert = extsMustConvert;
            this.ExtsConvertible = extsConvertible;
            this.ExtsUploadable = extsUploadable;
            this.ExtsArchive = extsArchive;
            this.ExtsVideo = extsVideo;
            this.ExtsAudio = extsAudio;
            this.ExtsImage = extsImage;
            this.ExtsSpreadsheet = extsSpreadsheet;
            this.ExtsPresentation = extsPresentation;
            this.ExtsDocument = extsDocument;
            this.ExtsDiagram = extsDiagram;
            this.InternalFormats = internalFormats;
            this.MasterFormExtension = masterFormExtension;
            this.ParamVersion = paramVersion;
            this.ParamOutType = paramOutType;
            this.FileDownloadUrlString = fileDownloadUrlString;
            this.FileWebViewerUrlString = fileWebViewerUrlString;
            this.FileWebViewerExternalUrlString = fileWebViewerExternalUrlString;
            this.FileWebEditorUrlString = fileWebEditorUrlString;
            this.FileWebEditorExternalUrlString = fileWebEditorExternalUrlString;
            this.FileRedirectPreviewUrlString = fileRedirectPreviewUrlString;
            this.FileThumbnailUrlString = fileThumbnailUrlString;
            this.ConfirmDelete = confirmDelete;
            this.EnableThirdParty = enableThirdParty;
            this.ExternalShare = externalShare;
            this.ExternalShareSocialMedia = externalShareSocialMedia;
            this.StoreOriginalFiles = storeOriginalFiles;
            this.KeepNewFileName = keepNewFileName;
            this.DisplayFileExtension = displayFileExtension;
            this.ConvertNotify = convertNotify;
            this.HideConfirmCancelOperation = hideConfirmCancelOperation;
            this.HideConfirmConvertSave = hideConfirmConvertSave;
            this.HideConfirmConvertOpen = hideConfirmConvertOpen;
            this.HideConfirmRoomLifetime = hideConfirmRoomLifetime;
            this.DefaultOrder = defaultOrder;
            this.Forcesave = forcesave;
            this.StoreForcesave = storeForcesave;
            this.RecentSection = recentSection;
            this.FavoritesSection = favoritesSection;
            this.TemplatesSection = templatesSection;
            this.DownloadTarGz = downloadTarGz;
            this.AutomaticallyCleanUp = automaticallyCleanUp;
            this.CanSearchByContent = canSearchByContent;
            this.DefaultSharingAccessRights = defaultSharingAccessRights;
            this.MaxUploadThreadCount = maxUploadThreadCount;
            this.ChunkUploadSize = chunkUploadSize;
            this.OpenEditorInSameTab = openEditorInSameTab;
            this.OrganizeRoomsGrouping = organizeRoomsGrouping;
            this.DefaultShareLinkInternal = defaultShareLinkInternal;
            this.ExternalShareApplyToDocuments = externalShareApplyToDocuments;
            this.ExternalShareApplyToRooms = externalShareApplyToRooms;
            this.BlockExistingLinksOnRestrict = blockExistingLinksOnRestrict;
            this.ExtsFilesVectorized = extsFilesVectorized;
            this.MaxVectorizationFileSize = maxVectorizationFileSize;
        }

        /// <summary>
        /// The list of extensions of the viewed images.
        /// </summary>
        /// <value>The list of extensions of the viewed images.</value>
        /*
        <example>[".bmp",".gif",".jpeg",".jpg",".png",".svg"]</example>
        */
        [DataMember(Name = "extsImagePreviewed", EmitDefaultValue = true)]
        public List<string> ExtsImagePreviewed { get; set; }

        /// <summary>
        /// The list of extensions of the viewed media files.
        /// </summary>
        /// <value>The list of extensions of the viewed media files.</value>
        /*
        <example>[".mp4",".webm",".mp3",".ogg"]</example>
        */
        [DataMember(Name = "extsMediaPreviewed", EmitDefaultValue = true)]
        public List<string> ExtsMediaPreviewed { get; set; }

        /// <summary>
        /// The list of extensions of the viewed files.
        /// </summary>
        /// <value>The list of extensions of the viewed files.</value>
        /*
        <example>[".docx",".xlsx",".pptx",".pdf"]</example>
        */
        [DataMember(Name = "extsWebPreviewed", EmitDefaultValue = true)]
        public List<string> ExtsWebPreviewed { get; set; }

        /// <summary>
        /// The list of extensions of the edited files.
        /// </summary>
        /// <value>The list of extensions of the edited files.</value>
        /*
        <example>[".docx",".xlsx",".pptx"]</example>
        */
        [DataMember(Name = "extsWebEdited", EmitDefaultValue = true)]
        public List<string> ExtsWebEdited { get; set; }

        /// <summary>
        /// The list of extensions of the encrypted files.
        /// </summary>
        /// <value>The list of extensions of the encrypted files.</value>
        /*
        <example>[".docx",".xlsx",".pptx"]</example>
        */
        [DataMember(Name = "extsWebEncrypt", EmitDefaultValue = true)]
        public List<string> ExtsWebEncrypt { get; set; }

        /// <summary>
        /// The list of extensions of the reviewed files.
        /// </summary>
        /// <value>The list of extensions of the reviewed files.</value>
        /*
        <example>[".docx"]</example>
        */
        [DataMember(Name = "extsWebReviewed", EmitDefaultValue = true)]
        public List<string> ExtsWebReviewed { get; set; }

        /// <summary>
        /// The list of extensions of the custom filter files.
        /// </summary>
        /// <value>The list of extensions of the custom filter files.</value>
        /*
        <example>[".xlsx"]</example>
        */
        [DataMember(Name = "extsWebCustomFilterEditing", EmitDefaultValue = true)]
        public List<string> ExtsWebCustomFilterEditing { get; set; }

        /// <summary>
        /// The list of extensions of the files that are restricted for editing.
        /// </summary>
        /// <value>The list of extensions of the files that are restricted for editing.</value>
        /*
        <example>[".pdf"]</example>
        */
        [DataMember(Name = "extsWebRestrictedEditing", EmitDefaultValue = true)]
        public List<string> ExtsWebRestrictedEditing { get; set; }

        /// <summary>
        /// The list of extensions of the commented files.
        /// </summary>
        /// <value>The list of extensions of the commented files.</value>
        /*
        <example>[".docx"]</example>
        */
        [DataMember(Name = "extsWebCommented", EmitDefaultValue = true)]
        public List<string> ExtsWebCommented { get; set; }

        /// <summary>
        /// The list of extensions of the template files.
        /// </summary>
        /// <value>The list of extensions of the template files.</value>
        /*
        <example>[".docx",".xlsx",".pptx"]</example>
        */
        [DataMember(Name = "extsWebTemplate", EmitDefaultValue = true)]
        public List<string> ExtsWebTemplate { get; set; }

        /// <summary>
        /// The list of extensions of the files that must be converted.
        /// </summary>
        /// <value>The list of extensions of the files that must be converted.</value>
        /*
        <example>[".doc",".xls",".ppt"]</example>
        */
        [DataMember(Name = "extsMustConvert", EmitDefaultValue = true)]
        public List<string> ExtsMustConvert { get; set; }

        /// <summary>
        /// The list of the convertible extensions.
        /// </summary>
        /// <value>The list of the convertible extensions.</value>
        /*
        <example>{".doc":[".docx",".pdf"],".xls":[".xlsx",".pdf"]}</example>
        */
        [DataMember(Name = "extsConvertible", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> ExtsConvertible { get; set; }

        /// <summary>
        /// The list of the uploadable extensions.
        /// </summary>
        /// <value>The list of the uploadable extensions.</value>
        /*
        <example>[".docx",".xlsx",".pdf"]</example>
        */
        [DataMember(Name = "extsUploadable", EmitDefaultValue = true)]
        public List<string> ExtsUploadable { get; set; }

        /// <summary>
        /// The list of extensions of the archive files.
        /// </summary>
        /// <value>The list of extensions of the archive files.</value>
        /*
        <example>[".zip",".rar",".7z"]</example>
        */
        [DataMember(Name = "extsArchive", EmitDefaultValue = true)]
        public List<string> ExtsArchive { get; set; }

        /// <summary>
        /// The list of the video extensions.
        /// </summary>
        /// <value>The list of the video extensions.</value>
        /*
        <example>[".mp4",".webm",".avi"]</example>
        */
        [DataMember(Name = "extsVideo", EmitDefaultValue = true)]
        public List<string> ExtsVideo { get; set; }

        /// <summary>
        /// The list of the audio extensions.
        /// </summary>
        /// <value>The list of the audio extensions.</value>
        /*
        <example>[".mp3",".ogg",".wav"]</example>
        */
        [DataMember(Name = "extsAudio", EmitDefaultValue = true)]
        public List<string> ExtsAudio { get; set; }

        /// <summary>
        /// The list of the image extensions.
        /// </summary>
        /// <value>The list of the image extensions.</value>
        /*
        <example>[".png",".jpg",".gif"]</example>
        */
        [DataMember(Name = "extsImage", EmitDefaultValue = true)]
        public List<string> ExtsImage { get; set; }

        /// <summary>
        /// The list of the spreadsheet extensions.
        /// </summary>
        /// <value>The list of the spreadsheet extensions.</value>
        /*
        <example>[".xlsx",".xls",".ods"]</example>
        */
        [DataMember(Name = "extsSpreadsheet", EmitDefaultValue = true)]
        public List<string> ExtsSpreadsheet { get; set; }

        /// <summary>
        /// The list of the presentation extensions.
        /// </summary>
        /// <value>The list of the presentation extensions.</value>
        /*
        <example>[".pptx",".ppt",".odp"]</example>
        */
        [DataMember(Name = "extsPresentation", EmitDefaultValue = true)]
        public List<string> ExtsPresentation { get; set; }

        /// <summary>
        /// The list of the text document extensions.
        /// </summary>
        /// <value>The list of the text document extensions.</value>
        /*
        <example>[".docx",".doc",".odt"]</example>
        */
        [DataMember(Name = "extsDocument", EmitDefaultValue = true)]
        public List<string> ExtsDocument { get; set; }

        /// <summary>
        /// The list of the diagram extensions.
        /// </summary>
        /// <value>The list of the diagram extensions.</value>
        /*
        <example>[".vsdx"]</example>
        */
        [DataMember(Name = "extsDiagram", EmitDefaultValue = true)]
        public List<string> ExtsDiagram { get; set; }

        /// <summary>
        /// Gets or Sets InternalFormats
        /// </summary>
        [DataMember(Name = "internalFormats", EmitDefaultValue = true)]
        public FilesSettingsDtoInternalFormats InternalFormats { get; set; }

        /// <summary>
        /// The master form extension.
        /// </summary>
        /// <value>The master form extension.</value>
        /*
        <example>.docxf</example>
        */
        [DataMember(Name = "masterFormExtension", EmitDefaultValue = true)]
        public string MasterFormExtension { get; set; }

        /// <summary>
        /// The URL parameter which specifies the file version.
        /// </summary>
        /// <value>The URL parameter which specifies the file version.</value>
        /*
        <example>ver</example>
        */
        [DataMember(Name = "paramVersion", EmitDefaultValue = true)]
        public string ParamVersion { get; set; }

        /// <summary>
        /// The URL parameter which specifies the output type of the converted file.
        /// </summary>
        /// <value>The URL parameter which specifies the output type of the converted file.</value>
        /*
        <example>otype</example>
        */
        [DataMember(Name = "paramOutType", EmitDefaultValue = true)]
        public string ParamOutType { get; set; }

        /// <summary>
        /// The URL to download a file.
        /// </summary>
        /// <value>The URL to download a file.</value>
        /*
        <example>https://example.com/products/files/httphandlers/filehandler.ashx?action=download&fileid={0}</example>
        */
        [DataMember(Name = "fileDownloadUrlString", EmitDefaultValue = true)]
        public string FileDownloadUrlString { get; set; }

        /// <summary>
        /// The URL to the file web viewer.
        /// </summary>
        /// <value>The URL to the file web viewer.</value>
        /*
        <example>/products/files/doceditor?fileid={0}&action=view</example>
        */
        [DataMember(Name = "fileWebViewerUrlString", EmitDefaultValue = true)]
        public string FileWebViewerUrlString { get; set; }

        /// <summary>
        /// The external URL to the file web viewer.
        /// </summary>
        /// <value>The external URL to the file web viewer.</value>
        /*
        <example>https://example.com/products/files/doceditor?fileid={0}&action=view</example>
        */
        [DataMember(Name = "fileWebViewerExternalUrlString", EmitDefaultValue = true)]
        public string FileWebViewerExternalUrlString { get; set; }

        /// <summary>
        /// The URL to the file web editor.
        /// </summary>
        /// <value>The URL to the file web editor.</value>
        /*
        <example>/products/files/doceditor?fileid={0}&action=edit</example>
        */
        [DataMember(Name = "fileWebEditorUrlString", EmitDefaultValue = true)]
        public string FileWebEditorUrlString { get; set; }

        /// <summary>
        /// The external URL to the file web editor.
        /// </summary>
        /// <value>The external URL to the file web editor.</value>
        /*
        <example>https://example.com/products/files/doceditor?fileid={0}&action=edit</example>
        */
        [DataMember(Name = "fileWebEditorExternalUrlString", EmitDefaultValue = true)]
        public string FileWebEditorExternalUrlString { get; set; }

        /// <summary>
        /// The redirect URL to the file viewer.
        /// </summary>
        /// <value>The redirect URL to the file viewer.</value>
        /*
        <example>https://example.com/products/files/{0}</example>
        */
        [DataMember(Name = "fileRedirectPreviewUrlString", EmitDefaultValue = true)]
        public string FileRedirectPreviewUrlString { get; set; }

        /// <summary>
        /// The URL to the file thumbnail.
        /// </summary>
        /// <value>The URL to the file thumbnail.</value>
        /*
        <example>https://example.com/products/files/httphandlers/filehandler.ashx?action=thumb&fileid={0}</example>
        */
        [DataMember(Name = "fileThumbnailUrlString", EmitDefaultValue = true)]
        public string FileThumbnailUrlString { get; set; }

        /// <summary>
        /// Specifies whether to confirm the file deletion or not.
        /// </summary>
        /// <value>Specifies whether to confirm the file deletion or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "confirmDelete", EmitDefaultValue = true)]
        public bool ConfirmDelete { get; set; }

        /// <summary>
        /// Specifies whether to allow users to connect the third-party storages.
        /// </summary>
        /// <value>Specifies whether to allow users to connect the third-party storages.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableThirdParty", EmitDefaultValue = true)]
        public bool EnableThirdParty { get; set; }

        /// <summary>
        /// Specifies whether to enable sharing external links to the files.
        /// </summary>
        /// <value>Specifies whether to enable sharing external links to the files.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShare", EmitDefaultValue = true)]
        public bool ExternalShare { get; set; }

        /// <summary>
        /// Specifies whether to enable sharing files on social media.
        /// </summary>
        /// <value>Specifies whether to enable sharing files on social media.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShareSocialMedia", EmitDefaultValue = true)]
        public bool ExternalShareSocialMedia { get; set; }

        /// <summary>
        /// Specifies whether to enable storing original files.
        /// </summary>
        /// <value>Specifies whether to enable storing original files.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "storeOriginalFiles", EmitDefaultValue = true)]
        public bool StoreOriginalFiles { get; set; }

        /// <summary>
        /// Specifies whether to keep the new file name.
        /// </summary>
        /// <value>Specifies whether to keep the new file name.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "keepNewFileName", EmitDefaultValue = true)]
        public bool KeepNewFileName { get; set; }

        /// <summary>
        /// Specifies whether to display the file extension.
        /// </summary>
        /// <value>Specifies whether to display the file extension.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "displayFileExtension", EmitDefaultValue = true)]
        public bool DisplayFileExtension { get; set; }

        /// <summary>
        /// Specifies whether to display the conversion notification.
        /// </summary>
        /// <value>Specifies whether to display the conversion notification.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "convertNotify", EmitDefaultValue = true)]
        public bool ConvertNotify { get; set; }

        /// <summary>
        /// Specifies whether to hide the confirmation dialog for the cancel operation.
        /// </summary>
        /// <value>Specifies whether to hide the confirmation dialog for the cancel operation.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "hideConfirmCancelOperation", EmitDefaultValue = true)]
        public bool HideConfirmCancelOperation { get; set; }

        /// <summary>
        /// Specifies whether to hide the confirmation dialog  for saving the file copy in the original format when converting a file.
        /// </summary>
        /// <value>Specifies whether to hide the confirmation dialog  for saving the file copy in the original format when converting a file.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "hideConfirmConvertSave", EmitDefaultValue = true)]
        public bool HideConfirmConvertSave { get; set; }

        /// <summary>
        /// Specifies whether to hide the confirmation dialog  for opening the conversion result.
        /// </summary>
        /// <value>Specifies whether to hide the confirmation dialog  for opening the conversion result.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "hideConfirmConvertOpen", EmitDefaultValue = true)]
        public bool HideConfirmConvertOpen { get; set; }

        /// <summary>
        /// Specifies whether to hide the confirmation dialog about the file lifetime in the room.
        /// </summary>
        /// <value>Specifies whether to hide the confirmation dialog about the file lifetime in the room.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "hideConfirmRoomLifetime", EmitDefaultValue = true)]
        public bool HideConfirmRoomLifetime { get; set; }

        /// <summary>
        /// Gets or Sets DefaultOrder
        /// </summary>
        [DataMember(Name = "defaultOrder", EmitDefaultValue = false)]
        public OrderBy DefaultOrder { get; set; }

        /// <summary>
        /// Specifies whether to forcesave the files or not.
        /// </summary>
        /// <value>Specifies whether to forcesave the files or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "forcesave", EmitDefaultValue = true)]
        public bool Forcesave { get; set; }

        /// <summary>
        /// Specifies whether to store the forcesaved file versions or not.
        /// </summary>
        /// <value>Specifies whether to store the forcesaved file versions or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "storeForcesave", EmitDefaultValue = true)]
        public bool StoreForcesave { get; set; }

        /// <summary>
        /// Specifies if the Recent section is displayed or not.
        /// </summary>
        /// <value>Specifies if the Recent section is displayed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "recentSection", EmitDefaultValue = true)]
        public bool RecentSection { get; set; }

        /// <summary>
        /// Specifies if the Favorites section is displayed or not.
        /// </summary>
        /// <value>Specifies if the Favorites section is displayed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "favoritesSection", EmitDefaultValue = true)]
        public bool FavoritesSection { get; set; }

        /// <summary>
        /// Specifies if the Templates section is displayed or not.
        /// </summary>
        /// <value>Specifies if the Templates section is displayed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "templatesSection", EmitDefaultValue = true)]
        public bool TemplatesSection { get; set; }

        /// <summary>
        /// Specifies whether to download the .tar.gz files or not.
        /// </summary>
        /// <value>Specifies whether to download the .tar.gz files or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "downloadTarGz", EmitDefaultValue = true)]
        public bool DownloadTarGz { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticallyCleanUp
        /// </summary>
        [DataMember(Name = "automaticallyCleanUp", EmitDefaultValue = false)]
        public AutoCleanUpData AutomaticallyCleanUp { get; set; }

        /// <summary>
        /// Specifies whether the file can be searched by its content or not.
        /// </summary>
        /// <value>Specifies whether the file can be searched by its content or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canSearchByContent", EmitDefaultValue = true)]
        public bool CanSearchByContent { get; set; }

        /// <summary>
        /// The default access rights in sharing settings.
        /// </summary>
        /// <value>The default access rights in sharing settings.</value>
        /*
        <example>[1,2]</example>
        */
        [DataMember(Name = "defaultSharingAccessRights", EmitDefaultValue = true)]
        public List<FilesSettingsDto.DefaultSharingAccessRightsEnum> DefaultSharingAccessRights { get; set; }

        /// <summary>
        /// The maximum number of upload threads.
        /// </summary>
        /// <value>The maximum number of upload threads.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "maxUploadThreadCount", EmitDefaultValue = false)]
        public int MaxUploadThreadCount { get; set; }

        /// <summary>
        /// The size of a large file that is uploaded in chunks.
        /// </summary>
        /// <value>The size of a large file that is uploaded in chunks.</value>
        /*
        <example>10485760</example>
        */
        [DataMember(Name = "chunkUploadSize", EmitDefaultValue = false)]
        public long ChunkUploadSize { get; set; }

        /// <summary>
        /// Specifies whether to open the editor in the same tab or not.
        /// </summary>
        /// <value>Specifies whether to open the editor in the same tab or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "openEditorInSameTab", EmitDefaultValue = true)]
        public bool OpenEditorInSameTab { get; set; }

        /// <summary>
        /// Specifies whether the grouping of rooms is enabled or not.
        /// </summary>
        /// <value>Specifies whether the grouping of rooms is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "organizeRoomsGrouping", EmitDefaultValue = true)]
        public bool OrganizeRoomsGrouping { get; set; }

        /// <summary>
        /// Specifies the default sharing link type: true = DocSpace users only (internal), false = Anyone with the link.
        /// </summary>
        /// <value>Specifies the default sharing link type: true = DocSpace users only (internal), false = Anyone with the link.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "defaultShareLinkInternal", EmitDefaultValue = true)]
        public bool DefaultShareLinkInternal { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether the restriction applies to the My Documents section.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether the restriction applies to the My Documents section.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShareApplyToDocuments", EmitDefaultValue = true)]
        public bool ExternalShareApplyToDocuments { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether the restriction applies to the Rooms section.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether the restriction applies to the Rooms section.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShareApplyToRooms", EmitDefaultValue = true)]
        public bool ExternalShareApplyToRooms { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether existing public links are blocked immediately.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether existing public links are blocked immediately.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "blockExistingLinksOnRestrict", EmitDefaultValue = true)]
        public bool BlockExistingLinksOnRestrict { get; set; }

        /// <summary>
        /// List of extensions available for vectorization
        /// </summary>
        /// <value>List of extensions available for vectorization</value>
        /*
        <example>[".docx",".pdf",".txt"]</example>
        */
        [DataMember(Name = "extsFilesVectorized", EmitDefaultValue = true)]
        public List<string> ExtsFilesVectorized { get; set; }

        /// <summary>
        /// The maximum file size for vectorization
        /// </summary>
        /// <value>The maximum file size for vectorization</value>
        /*
        <example>5242880</example>
        */
        [DataMember(Name = "maxVectorizationFileSize", EmitDefaultValue = false)]
        public long MaxVectorizationFileSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesSettingsDto {\n");
            sb.Append("  ExtsImagePreviewed: ").Append(ExtsImagePreviewed).Append("\n");
            sb.Append("  ExtsMediaPreviewed: ").Append(ExtsMediaPreviewed).Append("\n");
            sb.Append("  ExtsWebPreviewed: ").Append(ExtsWebPreviewed).Append("\n");
            sb.Append("  ExtsWebEdited: ").Append(ExtsWebEdited).Append("\n");
            sb.Append("  ExtsWebEncrypt: ").Append(ExtsWebEncrypt).Append("\n");
            sb.Append("  ExtsWebReviewed: ").Append(ExtsWebReviewed).Append("\n");
            sb.Append("  ExtsWebCustomFilterEditing: ").Append(ExtsWebCustomFilterEditing).Append("\n");
            sb.Append("  ExtsWebRestrictedEditing: ").Append(ExtsWebRestrictedEditing).Append("\n");
            sb.Append("  ExtsWebCommented: ").Append(ExtsWebCommented).Append("\n");
            sb.Append("  ExtsWebTemplate: ").Append(ExtsWebTemplate).Append("\n");
            sb.Append("  ExtsMustConvert: ").Append(ExtsMustConvert).Append("\n");
            sb.Append("  ExtsConvertible: ").Append(ExtsConvertible).Append("\n");
            sb.Append("  ExtsUploadable: ").Append(ExtsUploadable).Append("\n");
            sb.Append("  ExtsArchive: ").Append(ExtsArchive).Append("\n");
            sb.Append("  ExtsVideo: ").Append(ExtsVideo).Append("\n");
            sb.Append("  ExtsAudio: ").Append(ExtsAudio).Append("\n");
            sb.Append("  ExtsImage: ").Append(ExtsImage).Append("\n");
            sb.Append("  ExtsSpreadsheet: ").Append(ExtsSpreadsheet).Append("\n");
            sb.Append("  ExtsPresentation: ").Append(ExtsPresentation).Append("\n");
            sb.Append("  ExtsDocument: ").Append(ExtsDocument).Append("\n");
            sb.Append("  ExtsDiagram: ").Append(ExtsDiagram).Append("\n");
            sb.Append("  InternalFormats: ").Append(InternalFormats).Append("\n");
            sb.Append("  MasterFormExtension: ").Append(MasterFormExtension).Append("\n");
            sb.Append("  ParamVersion: ").Append(ParamVersion).Append("\n");
            sb.Append("  ParamOutType: ").Append(ParamOutType).Append("\n");
            sb.Append("  FileDownloadUrlString: ").Append(FileDownloadUrlString).Append("\n");
            sb.Append("  FileWebViewerUrlString: ").Append(FileWebViewerUrlString).Append("\n");
            sb.Append("  FileWebViewerExternalUrlString: ").Append(FileWebViewerExternalUrlString).Append("\n");
            sb.Append("  FileWebEditorUrlString: ").Append(FileWebEditorUrlString).Append("\n");
            sb.Append("  FileWebEditorExternalUrlString: ").Append(FileWebEditorExternalUrlString).Append("\n");
            sb.Append("  FileRedirectPreviewUrlString: ").Append(FileRedirectPreviewUrlString).Append("\n");
            sb.Append("  FileThumbnailUrlString: ").Append(FileThumbnailUrlString).Append("\n");
            sb.Append("  ConfirmDelete: ").Append(ConfirmDelete).Append("\n");
            sb.Append("  EnableThirdParty: ").Append(EnableThirdParty).Append("\n");
            sb.Append("  ExternalShare: ").Append(ExternalShare).Append("\n");
            sb.Append("  ExternalShareSocialMedia: ").Append(ExternalShareSocialMedia).Append("\n");
            sb.Append("  StoreOriginalFiles: ").Append(StoreOriginalFiles).Append("\n");
            sb.Append("  KeepNewFileName: ").Append(KeepNewFileName).Append("\n");
            sb.Append("  DisplayFileExtension: ").Append(DisplayFileExtension).Append("\n");
            sb.Append("  ConvertNotify: ").Append(ConvertNotify).Append("\n");
            sb.Append("  HideConfirmCancelOperation: ").Append(HideConfirmCancelOperation).Append("\n");
            sb.Append("  HideConfirmConvertSave: ").Append(HideConfirmConvertSave).Append("\n");
            sb.Append("  HideConfirmConvertOpen: ").Append(HideConfirmConvertOpen).Append("\n");
            sb.Append("  HideConfirmRoomLifetime: ").Append(HideConfirmRoomLifetime).Append("\n");
            sb.Append("  DefaultOrder: ").Append(DefaultOrder).Append("\n");
            sb.Append("  Forcesave: ").Append(Forcesave).Append("\n");
            sb.Append("  StoreForcesave: ").Append(StoreForcesave).Append("\n");
            sb.Append("  RecentSection: ").Append(RecentSection).Append("\n");
            sb.Append("  FavoritesSection: ").Append(FavoritesSection).Append("\n");
            sb.Append("  TemplatesSection: ").Append(TemplatesSection).Append("\n");
            sb.Append("  DownloadTarGz: ").Append(DownloadTarGz).Append("\n");
            sb.Append("  AutomaticallyCleanUp: ").Append(AutomaticallyCleanUp).Append("\n");
            sb.Append("  CanSearchByContent: ").Append(CanSearchByContent).Append("\n");
            sb.Append("  DefaultSharingAccessRights: ").Append(DefaultSharingAccessRights).Append("\n");
            sb.Append("  MaxUploadThreadCount: ").Append(MaxUploadThreadCount).Append("\n");
            sb.Append("  ChunkUploadSize: ").Append(ChunkUploadSize).Append("\n");
            sb.Append("  OpenEditorInSameTab: ").Append(OpenEditorInSameTab).Append("\n");
            sb.Append("  OrganizeRoomsGrouping: ").Append(OrganizeRoomsGrouping).Append("\n");
            sb.Append("  DefaultShareLinkInternal: ").Append(DefaultShareLinkInternal).Append("\n");
            sb.Append("  ExternalShareApplyToDocuments: ").Append(ExternalShareApplyToDocuments).Append("\n");
            sb.Append("  ExternalShareApplyToRooms: ").Append(ExternalShareApplyToRooms).Append("\n");
            sb.Append("  BlockExistingLinksOnRestrict: ").Append(BlockExistingLinksOnRestrict).Append("\n");
            sb.Append("  ExtsFilesVectorized: ").Append(ExtsFilesVectorized).Append("\n");
            sb.Append("  MaxVectorizationFileSize: ").Append(MaxVectorizationFileSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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


}
