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


using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

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

            var roomInstance = new RoomsApi(config);

            var sort = SortedByType.DateAndTime;

            var getRoom = await roomInstance.GetRoomsFolderAsync(null, null, 0, null, null, null, null, null, null, null, 100, null, sort.ToString(), SortOrder.Descending, null, "current.security,folders.id");

            Console.WriteLine(getRoom.Response);

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
