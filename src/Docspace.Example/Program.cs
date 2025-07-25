﻿using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

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
            UserName = "example@onluoffice.com",
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
