// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

public class Program
{
    static async Task Main(string[] args)
    {
        var config = new Configuration
        {
            BasePath = "http://localhost:8092"
        };
        var authSettings = new AuthRequestsDto
        {
            UserName = "example@onlyoffice.com",
            Password = "11111111"
        };
        var apiInstance = new AuthenticationApi(config);

        try
        {
            var authMe = await apiInstance.AuthenticateMeAsync(authSettings);

            var token = authMe.Response.Token;
            config.DefaultHeaders["Authorization"] = $"Bearer {token}";

            var folderInstance = new FilesFoldersApi(config);
            var getFolderMy = await folderInstance.GetMyFolderAsync();

            var folderMyId = getFolderMy.Response.Current.Id;
            var folderSettings = new CreateFolder("Folder"){};
            var createFolder = await folderInstance.CreateFolderAsync(folderMyId, folderSettings);
            var createdFolderId = createFolder.Response.Id;
            Console.WriteLine(createFolder.Response.Id);

            var getFolderInfo = await folderInstance.GetFolderByFolderIdAsync(createdFolderId);

            Console.WriteLine(getFolderInfo.StatusCode);
            var updatedFolderSettings = new CreateFolder("UpdatedTitle") { };

            var renameFolder = await folderInstance.RenameFolderAsync(createdFolderId, updatedFolderSettings);
            var titleNew = renameFolder.Response.Title;
            if (updatedFolderSettings.Title == titleNew)
            {
                Console.WriteLine("Success");
            }

            var deleteRequestSettings = new DeleteFolder
            {
                DeleteAfter = true,
                Immediately = true
            };
            var deleteFolder = await folderInstance.DeleteFolderAsync(createdFolderId, deleteRequestSettings);
            Console.WriteLine(deleteFolder.StatusCode);

            var backupInstance = new BackupApi(config);

            var startBackupSettings = new BackupDto
            {
                Dump = false,
                StorageParams = null,
                StorageType = BackupStorageType.DataStore,
            };
            var startBackup = await backupInstance.StartBackupAsync(startBackupSettings);

            await WaitForCompletionAsync(async () => await backupInstance.GetBackupProgressAsync());

        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
    }

    static async Task WaitForCompletionAsync(Func<Task<BackupProgressWrapper>> getProgressFunc, int delayMilliseconds = 1000)
    {
        while (true)
        {
            var progress = await getProgressFunc();
            if (progress.Response.IsCompleted)
            {
                Console.WriteLine("Backup completed");
                break;
            }

            await Task.Delay(delayMilliseconds);
        }
    }
}
