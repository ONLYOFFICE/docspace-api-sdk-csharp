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
    /// Everything a client needs to work with documents in this portal: the format tables, the address templates, the  upload limits, the portal-wide switches and the preferences of the calling account.
    /// </summary>
    [DataContract(Name = "FilesSettingsDto")]
    public partial class FilesSettingsDto : IValidatableObject
    {
        /// <summary>
        /// The access rights the sharing dialog offers the caller by default. The portal normalises the set it stores, so  this can be shorter than what was last sent.
        /// </summary>
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
        /// <param name="extsImagePreviewed">Images the portal can show in its own viewer. Anything outside the list has to be downloaded to be seen..</param>
        /// <param name="extsMediaPreviewed">Audio and video the portal can play in its own player..</param>
        /// <param name="extsWebPreviewed">Documents the editor can open read-only. A format that is here but not in the edited list can be viewed and  not changed..</param>
        /// <param name="extsWebEdited">Documents the editor can open for editing. Uploading a format outside this list and outside the convertible  list leaves a file that can only be downloaded..</param>
        /// <param name="extsWebEncrypt">Documents that can be edited inside a private room, where the content is encrypted on the client..</param>
        /// <param name="extsWebReviewed">Documents that support the reviewing mode, so that granting review access to them is meaningful..</param>
        /// <param name="extsWebCustomFilterEditing">Spreadsheets that support the custom filter mode, where a filter applied by one editor does not disturb the  others..</param>
        /// <param name="extsWebRestrictedEditing">Documents that can only be filled in or commented on rather than edited freely, whatever access the caller  holds..</param>
        /// <param name="extsWebCommented">Documents that support comments, so that granting comment access to them is meaningful..</param>
        /// <param name="extsWebTemplate">Documents the portal treats as templates to create new files from..</param>
        /// <param name="extsMustConvert">Formats that cannot be edited as they are and are converted on upload or on first opening. Which target each  one has is in the convertible table below..</param>
        /// <param name="extsConvertible">The conversion map of the portal: for each source extension, the extensions it can be converted into. Use it  to fill the target format of a conversion request instead of guessing one..</param>
        /// <param name="extsUploadable">Formats the portal offers to create and upload as documents. It is not an upload filter: files of other  formats are stored as they are..</param>
        /// <param name="extsArchive">Formats recognised as archives, which is what decides the archive icon and the offer to unpack..</param>
        /// <param name="extsVideo">Formats classified as video. The classification lists drive icons and the media filters of the listing  operations, and are wider than what the built-in player can show..</param>
        /// <param name="extsAudio">Formats classified as audio..</param>
        /// <param name="extsImage">Formats classified as images..</param>
        /// <param name="extsSpreadsheet">Formats classified as spreadsheets..</param>
        /// <param name="extsPresentation">Formats classified as presentations..</param>
        /// <param name="extsDocument">Formats classified as text documents..</param>
        /// <param name="extsDiagram">Formats classified as diagrams..</param>
        /// <param name="internalFormats">internalFormats.</param>
        /// <param name="masterFormExtension">The extension of a fillable form template in this portal. It is configurable, so read it rather than assuming  the product default..</param>
        /// <param name="paramVersion">The name of the query parameter that pins a document address to one version. Append it to the addresses below  instead of composing a version address by hand..</param>
        /// <param name="paramOutType">The name of the query parameter that asks a download address for a converted copy in another format..</param>
        /// <param name="fileDownloadUrlString">The template of the address a file is downloaded from: substitute the file identifier for the &#x60;{0}&#x60;  placeholder. Add the version and output-type parameters named above for a particular version or format..</param>
        /// <param name="fileWebViewerUrlString">The template of the address that opens a file in the viewer inside the portal, with &#x60;{0}&#x60; for the file  identifier. It is a portal-relative address, meant to be opened in a browser rather than called as an API..</param>
        /// <param name="fileWebViewerExternalUrlString">The same viewer address as an absolute one, for a message or a page outside the portal..</param>
        /// <param name="fileWebEditorUrlString">The template of the address that opens a file for editing inside the portal, with &#x60;{0}&#x60; for the file  identifier. Whether the session really becomes editable still depends on the access the caller holds..</param>
        /// <param name="fileWebEditorExternalUrlString">The same editing address as an absolute one, for use outside the portal..</param>
        /// <param name="fileRedirectPreviewUrlString">The template of the address that sends the browser on to whichever viewer or editor suits the file, with &#x60;{0}&#x60;  for the file identifier. Use it when the kind of the file is not known in advance..</param>
        /// <param name="fileThumbnailUrlString">The template of the address a file thumbnail is fetched from, with &#x60;{0}&#x60; for the file identifier. A thumbnail  is built in the background, so the address can answer with nothing for a while after the file appears..</param>
        /// <param name="confirmDelete">Whether the caller asked to be prompted before a deletion. Written by &#x60;PUT api/2.0/files/changedeleteconfrim&#x60;..</param>
        /// <param name="enableThirdParty">Whether this portal allows third-party storages to be connected at all. It is set portal-wide by an  administrator, so a member sees it as read-only..</param>
        /// <param name="externalShare">Whether links that open an entry without a portal account may be created in this portal. Set portal-wide by an  administrator..</param>
        /// <param name="externalShareSocialMedia">Whether the share-to-network buttons are offered next to an external link. It is reported as false whenever  external sharing itself is off..</param>
        /// <param name="storeOriginalFiles">Whether the caller&#39;s uploads keep the original file when the portal converts them. With false the conversion  replaces the uploaded file with a new version of it..</param>
        /// <param name="keepNewFileName">Whether the caller asked for new documents to be created with the default name instead of being prompted for  one..</param>
        /// <param name="displayFileExtension">Whether the caller asked to see extensions in file titles. Stored titles always carry the extension whatever  this says..</param>
        /// <param name="showQuickActions">Specifies whether to display the quick action buttons..</param>
        /// <param name="convertNotify">Whether the caller is told about the result of a conversion. There is no operation in this document that  writes it..</param>
        /// <param name="hideConfirmCancelOperation">Whether the prompt shown before a running operation is abandoned is hidden for the caller..</param>
        /// <param name="hideConfirmConvertSave">Whether the prompt that offers to keep a copy in the original format on conversion is hidden for the caller.  Once true it cannot be turned back through the API..</param>
        /// <param name="hideConfirmConvertOpen">Whether the prompt that offers to open the conversion result is hidden for the caller. Once true it cannot be  turned back through the API..</param>
        /// <param name="hideConfirmRoomLifetime">Whether the warning shown before the lifetime settings of a room are changed is hidden for the caller..</param>
        /// <param name="defaultOrder">The ordering the listing operations fall back to when a request names none. It follows the last order the  caller asked a listing for, so it changes on its own as the account is used..</param>
        /// <param name="forcesave">Whether the editor writes a document back to storage while the session is still open. It is on for every  portal and cannot be switched off..</param>
        /// <param name="storeForcesave">Whether those intermediate saves are kept as separate versions. They are not, in any portal: they update the  current version instead..</param>
        /// <param name="recentSection">Whether the Recent section is offered to the caller among the section roots..</param>
        /// <param name="favoritesSection">Whether the Favorites section is offered to the caller among the section roots..</param>
        /// <param name="templatesSection">Whether the Templates section is offered to the caller among the section roots..</param>
        /// <param name="downloadTarGz">The archive format the caller&#39;s multi-item downloads are packed into: true for &#x60;.tar.gz&#x60;, false for &#x60;.zip&#x60;..</param>
        /// <param name="automaticallyCleanUp">The trash auto-clearing setting of the caller, the same pair &#x60;GET api/2.0/files/settings/autocleanup&#x60; returns..</param>
        /// <param name="canSearchByContent">Whether documents in this portal can be searched by what is inside them and not only by title. It depends on  the full-text search service being configured and having indexed the portal..</param>
        /// <param name="defaultSharingAccessRights">The access rights the sharing dialog offers the caller by default. The portal normalises the set it stores, so  this can be shorter than what was last sent..</param>
        /// <param name="maxUploadThreadCount">How many upload requests the portal accepts from one account at a time. Sending more than this in parallel  gets the extra ones refused rather than queued..</param>
        /// <param name="chunkUploadSize">The size in bytes of one chunk of a chunked upload. Split a large file exactly along this size: a chunk that  does not match is refused by the upload session..</param>
        /// <param name="openEditorInSameTab">Whether the caller asked for documents to open in the current browser tab..</param>
        /// <param name="organizeRoomsGrouping">Whether the caller asked to see rooms arranged by the groups they belong to..</param>
        /// <param name="defaultShareLinkInternal">The kind of external link this portal offers first: true for a link only its own accounts can open, false for  one anyone holding it can open..</param>
        /// <param name="externalShareApplyToDocuments">Whether the external sharing restriction covers personal documents. It matters only while external sharing is  off..</param>
        /// <param name="externalShareApplyToRooms">Whether the external sharing restriction covers rooms, including making a new one public. It matters only  while external sharing is off..</param>
        /// <param name="blockExistingLinksOnRestrict">Whether links created before the restriction stop opening as well, rather than only new ones being refused..</param>
        /// <param name="extsFilesVectorized">Formats whose content can be indexed for the AI features of the portal. A file outside the list is left out of  that index..</param>
        /// <param name="maxVectorizationFileSize">The largest file size in bytes that is indexed for the AI features. A larger file is skipped even when its  format is listed above..</param>
        public FilesSettingsDto(List<string> extsImagePreviewed = default, List<string> extsMediaPreviewed = default, List<string> extsWebPreviewed = default, List<string> extsWebEdited = default, List<string> extsWebEncrypt = default, List<string> extsWebReviewed = default, List<string> extsWebCustomFilterEditing = default, List<string> extsWebRestrictedEditing = default, List<string> extsWebCommented = default, List<string> extsWebTemplate = default, List<string> extsMustConvert = default, Dictionary<string, List<string>> extsConvertible = default, List<string> extsUploadable = default, List<string> extsArchive = default, List<string> extsVideo = default, List<string> extsAudio = default, List<string> extsImage = default, List<string> extsSpreadsheet = default, List<string> extsPresentation = default, List<string> extsDocument = default, List<string> extsDiagram = default, FilesSettingsDtoInternalFormats internalFormats = default, string masterFormExtension = default, string paramVersion = default, string paramOutType = default, string fileDownloadUrlString = default, string fileWebViewerUrlString = default, string fileWebViewerExternalUrlString = default, string fileWebEditorUrlString = default, string fileWebEditorExternalUrlString = default, string fileRedirectPreviewUrlString = default, string fileThumbnailUrlString = default, bool confirmDelete = default, bool enableThirdParty = default, bool externalShare = default, bool externalShareSocialMedia = default, bool storeOriginalFiles = default, bool keepNewFileName = default, bool displayFileExtension = default, bool showQuickActions = default, bool convertNotify = default, bool hideConfirmCancelOperation = default, bool hideConfirmConvertSave = default, bool hideConfirmConvertOpen = default, bool hideConfirmRoomLifetime = default, OrderBy defaultOrder = default, bool forcesave = default, bool storeForcesave = default, bool recentSection = default, bool favoritesSection = default, bool templatesSection = default, bool downloadTarGz = default, AutoCleanUpData automaticallyCleanUp = default, bool canSearchByContent = default, List<FilesSettingsDto.DefaultSharingAccessRightsEnum> defaultSharingAccessRights = default, int maxUploadThreadCount = default, long chunkUploadSize = default, bool openEditorInSameTab = default, bool organizeRoomsGrouping = default, bool defaultShareLinkInternal = default, bool externalShareApplyToDocuments = default, bool externalShareApplyToRooms = default, bool blockExistingLinksOnRestrict = default, List<string> extsFilesVectorized = default, long maxVectorizationFileSize = default)
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
            this.ShowQuickActions = showQuickActions;
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
        /// Images the portal can show in its own viewer. Anything outside the list has to be downloaded to be seen.
        /// </summary>
        /// <example>[".bmp",".gif",".jpeg",".jpg",".png",".svg"]</example>
        [DataMember(Name = "extsImagePreviewed", EmitDefaultValue = true)]
        public List<string> ExtsImagePreviewed { get; set; }

        /// <summary>
        /// Audio and video the portal can play in its own player.
        /// </summary>
        /// <example>[".mp4",".webm",".mp3",".ogg"]</example>
        [DataMember(Name = "extsMediaPreviewed", EmitDefaultValue = true)]
        public List<string> ExtsMediaPreviewed { get; set; }

        /// <summary>
        /// Documents the editor can open read-only. A format that is here but not in the edited list can be viewed and  not changed.
        /// </summary>
        /// <example>[".docx",".xlsx",".pptx",".pdf"]</example>
        [DataMember(Name = "extsWebPreviewed", EmitDefaultValue = true)]
        public List<string> ExtsWebPreviewed { get; set; }

        /// <summary>
        /// Documents the editor can open for editing. Uploading a format outside this list and outside the convertible  list leaves a file that can only be downloaded.
        /// </summary>
        /// <example>[".docx",".xlsx",".pptx"]</example>
        [DataMember(Name = "extsWebEdited", EmitDefaultValue = true)]
        public List<string> ExtsWebEdited { get; set; }

        /// <summary>
        /// Documents that can be edited inside a private room, where the content is encrypted on the client.
        /// </summary>
        /// <example>[".docx",".xlsx",".pptx"]</example>
        [DataMember(Name = "extsWebEncrypt", EmitDefaultValue = true)]
        public List<string> ExtsWebEncrypt { get; set; }

        /// <summary>
        /// Documents that support the reviewing mode, so that granting review access to them is meaningful.
        /// </summary>
        /// <example>[".docx"]</example>
        [DataMember(Name = "extsWebReviewed", EmitDefaultValue = true)]
        public List<string> ExtsWebReviewed { get; set; }

        /// <summary>
        /// Spreadsheets that support the custom filter mode, where a filter applied by one editor does not disturb the  others.
        /// </summary>
        /// <example>[".xlsx"]</example>
        [DataMember(Name = "extsWebCustomFilterEditing", EmitDefaultValue = true)]
        public List<string> ExtsWebCustomFilterEditing { get; set; }

        /// <summary>
        /// Documents that can only be filled in or commented on rather than edited freely, whatever access the caller  holds.
        /// </summary>
        /// <example>[".pdf"]</example>
        [DataMember(Name = "extsWebRestrictedEditing", EmitDefaultValue = true)]
        public List<string> ExtsWebRestrictedEditing { get; set; }

        /// <summary>
        /// Documents that support comments, so that granting comment access to them is meaningful.
        /// </summary>
        /// <example>[".docx"]</example>
        [DataMember(Name = "extsWebCommented", EmitDefaultValue = true)]
        public List<string> ExtsWebCommented { get; set; }

        /// <summary>
        /// Documents the portal treats as templates to create new files from.
        /// </summary>
        /// <example>[".docx",".xlsx",".pptx"]</example>
        [DataMember(Name = "extsWebTemplate", EmitDefaultValue = true)]
        public List<string> ExtsWebTemplate { get; set; }

        /// <summary>
        /// Formats that cannot be edited as they are and are converted on upload or on first opening. Which target each  one has is in the convertible table below.
        /// </summary>
        /// <example>[".doc",".xls",".ppt"]</example>
        [DataMember(Name = "extsMustConvert", EmitDefaultValue = true)]
        public List<string> ExtsMustConvert { get; set; }

        /// <summary>
        /// The conversion map of the portal: for each source extension, the extensions it can be converted into. Use it  to fill the target format of a conversion request instead of guessing one.
        /// </summary>
        /// <example>{".doc":[".docx",".pdf"],".xls":[".xlsx",".pdf"]}</example>
        [DataMember(Name = "extsConvertible", EmitDefaultValue = false)]
        public Dictionary<string, List<string>> ExtsConvertible { get; set; }

        /// <summary>
        /// Formats the portal offers to create and upload as documents. It is not an upload filter: files of other  formats are stored as they are.
        /// </summary>
        /// <example>[".docx",".xlsx",".pdf"]</example>
        [DataMember(Name = "extsUploadable", EmitDefaultValue = true)]
        public List<string> ExtsUploadable { get; set; }

        /// <summary>
        /// Formats recognised as archives, which is what decides the archive icon and the offer to unpack.
        /// </summary>
        /// <example>[".zip",".rar",".7z"]</example>
        [DataMember(Name = "extsArchive", EmitDefaultValue = true)]
        public List<string> ExtsArchive { get; set; }

        /// <summary>
        /// Formats classified as video. The classification lists drive icons and the media filters of the listing  operations, and are wider than what the built-in player can show.
        /// </summary>
        /// <example>[".mp4",".webm",".avi"]</example>
        [DataMember(Name = "extsVideo", EmitDefaultValue = true)]
        public List<string> ExtsVideo { get; set; }

        /// <summary>
        /// Formats classified as audio.
        /// </summary>
        /// <example>[".mp3",".ogg",".wav"]</example>
        [DataMember(Name = "extsAudio", EmitDefaultValue = true)]
        public List<string> ExtsAudio { get; set; }

        /// <summary>
        /// Formats classified as images.
        /// </summary>
        /// <example>[".png",".jpg",".gif"]</example>
        [DataMember(Name = "extsImage", EmitDefaultValue = true)]
        public List<string> ExtsImage { get; set; }

        /// <summary>
        /// Formats classified as spreadsheets.
        /// </summary>
        /// <example>[".xlsx",".xls",".ods"]</example>
        [DataMember(Name = "extsSpreadsheet", EmitDefaultValue = true)]
        public List<string> ExtsSpreadsheet { get; set; }

        /// <summary>
        /// Formats classified as presentations.
        /// </summary>
        /// <example>[".pptx",".ppt",".odp"]</example>
        [DataMember(Name = "extsPresentation", EmitDefaultValue = true)]
        public List<string> ExtsPresentation { get; set; }

        /// <summary>
        /// Formats classified as text documents.
        /// </summary>
        /// <example>[".docx",".doc",".odt"]</example>
        [DataMember(Name = "extsDocument", EmitDefaultValue = true)]
        public List<string> ExtsDocument { get; set; }

        /// <summary>
        /// Formats classified as diagrams.
        /// </summary>
        /// <example>[".vsdx"]</example>
        [DataMember(Name = "extsDiagram", EmitDefaultValue = true)]
        public List<string> ExtsDiagram { get; set; }

        /// <summary>
        /// Gets or Sets InternalFormats
        /// </summary>
        [DataMember(Name = "internalFormats", EmitDefaultValue = true)]
        public FilesSettingsDtoInternalFormats InternalFormats { get; set; }

        /// <summary>
        /// The extension of a fillable form template in this portal. It is configurable, so read it rather than assuming  the product default.
        /// </summary>
        /// <example>.pdf</example>
        [DataMember(Name = "masterFormExtension", EmitDefaultValue = true)]
        public string MasterFormExtension { get; set; }

        /// <summary>
        /// The name of the query parameter that pins a document address to one version. Append it to the addresses below  instead of composing a version address by hand.
        /// </summary>
        /// <example>version</example>
        [DataMember(Name = "paramVersion", EmitDefaultValue = true)]
        public string ParamVersion { get; set; }

        /// <summary>
        /// The name of the query parameter that asks a download address for a converted copy in another format.
        /// </summary>
        /// <example>outputtype</example>
        [DataMember(Name = "paramOutType", EmitDefaultValue = true)]
        public string ParamOutType { get; set; }

        /// <summary>
        /// The template of the address a file is downloaded from: substitute the file identifier for the &#x60;{0}&#x60;  placeholder. Add the version and output-type parameters named above for a particular version or format.
        /// </summary>
        /// <example>https://example.com/filehandler.ashx?action=download&amp;fileid={0}</example>
        [DataMember(Name = "fileDownloadUrlString", EmitDefaultValue = true)]
        public string FileDownloadUrlString { get; set; }

        /// <summary>
        /// The template of the address that opens a file in the viewer inside the portal, with &#x60;{0}&#x60; for the file  identifier. It is a portal-relative address, meant to be opened in a browser rather than called as an API.
        /// </summary>
        /// <example>/products/files/doceditor?fileid={0}&amp;action=view</example>
        [DataMember(Name = "fileWebViewerUrlString", EmitDefaultValue = true)]
        public string FileWebViewerUrlString { get; set; }

        /// <summary>
        /// The same viewer address as an absolute one, for a message or a page outside the portal.
        /// </summary>
        /// <example>https://example.com/products/files/doceditor?fileid={0}&amp;action=view</example>
        [DataMember(Name = "fileWebViewerExternalUrlString", EmitDefaultValue = true)]
        public string FileWebViewerExternalUrlString { get; set; }

        /// <summary>
        /// The template of the address that opens a file for editing inside the portal, with &#x60;{0}&#x60; for the file  identifier. Whether the session really becomes editable still depends on the access the caller holds.
        /// </summary>
        /// <example>/products/files/doceditor?fileid={0}&amp;action=edit</example>
        [DataMember(Name = "fileWebEditorUrlString", EmitDefaultValue = true)]
        public string FileWebEditorUrlString { get; set; }

        /// <summary>
        /// The same editing address as an absolute one, for use outside the portal.
        /// </summary>
        /// <example>https://example.com/products/files/doceditor?fileid={0}&amp;action=edit</example>
        [DataMember(Name = "fileWebEditorExternalUrlString", EmitDefaultValue = true)]
        public string FileWebEditorExternalUrlString { get; set; }

        /// <summary>
        /// The template of the address that sends the browser on to whichever viewer or editor suits the file, with &#x60;{0}&#x60;  for the file identifier. Use it when the kind of the file is not known in advance.
        /// </summary>
        /// <example>https://example.com/products/files/{0}</example>
        [DataMember(Name = "fileRedirectPreviewUrlString", EmitDefaultValue = true)]
        public string FileRedirectPreviewUrlString { get; set; }

        /// <summary>
        /// The template of the address a file thumbnail is fetched from, with &#x60;{0}&#x60; for the file identifier. A thumbnail  is built in the background, so the address can answer with nothing for a while after the file appears.
        /// </summary>
        /// <example>https://example.com/filehandler.ashx?action=thumb&amp;fileid={0}</example>
        [DataMember(Name = "fileThumbnailUrlString", EmitDefaultValue = true)]
        public string FileThumbnailUrlString { get; set; }

        /// <summary>
        /// Whether the caller asked to be prompted before a deletion. Written by &#x60;PUT api/2.0/files/changedeleteconfrim&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "confirmDelete", EmitDefaultValue = true)]
        public bool ConfirmDelete { get; set; }

        /// <summary>
        /// Whether this portal allows third-party storages to be connected at all. It is set portal-wide by an  administrator, so a member sees it as read-only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableThirdParty", EmitDefaultValue = true)]
        public bool EnableThirdParty { get; set; }

        /// <summary>
        /// Whether links that open an entry without a portal account may be created in this portal. Set portal-wide by an  administrator.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShare", EmitDefaultValue = true)]
        public bool ExternalShare { get; set; }

        /// <summary>
        /// Whether the share-to-network buttons are offered next to an external link. It is reported as false whenever  external sharing itself is off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShareSocialMedia", EmitDefaultValue = true)]
        public bool ExternalShareSocialMedia { get; set; }

        /// <summary>
        /// Whether the caller&#39;s uploads keep the original file when the portal converts them. With false the conversion  replaces the uploaded file with a new version of it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "storeOriginalFiles", EmitDefaultValue = true)]
        public bool StoreOriginalFiles { get; set; }

        /// <summary>
        /// Whether the caller asked for new documents to be created with the default name instead of being prompted for  one.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "keepNewFileName", EmitDefaultValue = true)]
        public bool KeepNewFileName { get; set; }

        /// <summary>
        /// Whether the caller asked to see extensions in file titles. Stored titles always carry the extension whatever  this says.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "displayFileExtension", EmitDefaultValue = true)]
        public bool DisplayFileExtension { get; set; }

        /// <summary>
        /// Specifies whether to display the quick action buttons.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "showQuickActions", EmitDefaultValue = true)]
        public bool ShowQuickActions { get; set; }

        /// <summary>
        /// Whether the caller is told about the result of a conversion. There is no operation in this document that  writes it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "convertNotify", EmitDefaultValue = true)]
        public bool ConvertNotify { get; set; }

        /// <summary>
        /// Whether the prompt shown before a running operation is abandoned is hidden for the caller.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideConfirmCancelOperation", EmitDefaultValue = true)]
        public bool HideConfirmCancelOperation { get; set; }

        /// <summary>
        /// Whether the prompt that offers to keep a copy in the original format on conversion is hidden for the caller.  Once true it cannot be turned back through the API.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideConfirmConvertSave", EmitDefaultValue = true)]
        public bool HideConfirmConvertSave { get; set; }

        /// <summary>
        /// Whether the prompt that offers to open the conversion result is hidden for the caller. Once true it cannot be  turned back through the API.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideConfirmConvertOpen", EmitDefaultValue = true)]
        public bool HideConfirmConvertOpen { get; set; }

        /// <summary>
        /// Whether the warning shown before the lifetime settings of a room are changed is hidden for the caller.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideConfirmRoomLifetime", EmitDefaultValue = true)]
        public bool HideConfirmRoomLifetime { get; set; }

        /// <summary>
        /// The ordering the listing operations fall back to when a request names none. It follows the last order the  caller asked a listing for, so it changes on its own as the account is used.
        /// </summary>
        [DataMember(Name = "defaultOrder", EmitDefaultValue = false)]
        public OrderBy DefaultOrder { get; set; }

        /// <summary>
        /// Whether the editor writes a document back to storage while the session is still open. It is on for every  portal and cannot be switched off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "forcesave", EmitDefaultValue = true)]
        public bool Forcesave { get; set; }

        /// <summary>
        /// Whether those intermediate saves are kept as separate versions. They are not, in any portal: they update the  current version instead.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "storeForcesave", EmitDefaultValue = true)]
        public bool StoreForcesave { get; set; }

        /// <summary>
        /// Whether the Recent section is offered to the caller among the section roots.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "recentSection", EmitDefaultValue = true)]
        public bool RecentSection { get; set; }

        /// <summary>
        /// Whether the Favorites section is offered to the caller among the section roots.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "favoritesSection", EmitDefaultValue = true)]
        public bool FavoritesSection { get; set; }

        /// <summary>
        /// Whether the Templates section is offered to the caller among the section roots.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "templatesSection", EmitDefaultValue = true)]
        public bool TemplatesSection { get; set; }

        /// <summary>
        /// The archive format the caller&#39;s multi-item downloads are packed into: true for &#x60;.tar.gz&#x60;, false for &#x60;.zip&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "downloadTarGz", EmitDefaultValue = true)]
        public bool DownloadTarGz { get; set; }

        /// <summary>
        /// The trash auto-clearing setting of the caller, the same pair &#x60;GET api/2.0/files/settings/autocleanup&#x60; returns.
        /// </summary>
        [DataMember(Name = "automaticallyCleanUp", EmitDefaultValue = false)]
        public AutoCleanUpData AutomaticallyCleanUp { get; set; }

        /// <summary>
        /// Whether documents in this portal can be searched by what is inside them and not only by title. It depends on  the full-text search service being configured and having indexed the portal.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canSearchByContent", EmitDefaultValue = true)]
        public bool CanSearchByContent { get; set; }

        /// <summary>
        /// The access rights the sharing dialog offers the caller by default. The portal normalises the set it stores, so  this can be shorter than what was last sent.
        /// </summary>
        /// <example>[1,2]</example>
        [DataMember(Name = "defaultSharingAccessRights", EmitDefaultValue = true)]
        public List<FilesSettingsDto.DefaultSharingAccessRightsEnum> DefaultSharingAccessRights { get; set; }

        /// <summary>
        /// How many upload requests the portal accepts from one account at a time. Sending more than this in parallel  gets the extra ones refused rather than queued.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "maxUploadThreadCount", EmitDefaultValue = false)]
        public int MaxUploadThreadCount { get; set; }

        /// <summary>
        /// The size in bytes of one chunk of a chunked upload. Split a large file exactly along this size: a chunk that  does not match is refused by the upload session.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "chunkUploadSize", EmitDefaultValue = false)]
        public long ChunkUploadSize { get; set; }

        /// <summary>
        /// Whether the caller asked for documents to open in the current browser tab.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "openEditorInSameTab", EmitDefaultValue = true)]
        public bool OpenEditorInSameTab { get; set; }

        /// <summary>
        /// Whether the caller asked to see rooms arranged by the groups they belong to.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "organizeRoomsGrouping", EmitDefaultValue = true)]
        public bool OrganizeRoomsGrouping { get; set; }

        /// <summary>
        /// The kind of external link this portal offers first: true for a link only its own accounts can open, false for  one anyone holding it can open.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "defaultShareLinkInternal", EmitDefaultValue = true)]
        public bool DefaultShareLinkInternal { get; set; }

        /// <summary>
        /// Whether the external sharing restriction covers personal documents. It matters only while external sharing is  off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShareApplyToDocuments", EmitDefaultValue = true)]
        public bool ExternalShareApplyToDocuments { get; set; }

        /// <summary>
        /// Whether the external sharing restriction covers rooms, including making a new one public. It matters only  while external sharing is off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShareApplyToRooms", EmitDefaultValue = true)]
        public bool ExternalShareApplyToRooms { get; set; }

        /// <summary>
        /// Whether links created before the restriction stop opening as well, rather than only new ones being refused.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "blockExistingLinksOnRestrict", EmitDefaultValue = true)]
        public bool BlockExistingLinksOnRestrict { get; set; }

        /// <summary>
        /// Formats whose content can be indexed for the AI features of the portal. A file outside the list is left out of  that index.
        /// </summary>
        /// <example>[".docx",".pdf",".txt"]</example>
        [DataMember(Name = "extsFilesVectorized", EmitDefaultValue = true)]
        public List<string> ExtsFilesVectorized { get; set; }

        /// <summary>
        /// The largest file size in bytes that is indexed for the AI features. A larger file is skipped even when its  format is listed above.
        /// </summary>
        /// <example>5242880</example>
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
            sb.Append("  ShowQuickActions: ").Append(ShowQuickActions).Append("\n");
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
