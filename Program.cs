using KiotaPosts.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using KiotaPosts.Client.Models.ASC.Web.Api.ApiModel.RequestsDto;
using KiotaPosts.Client.Models.ASC.Files.Core.ApiModels.RequestDto;
using Microsoft.Kiota.Abstractions;
using static KiotaPosts.Client.Api.TwoZero.Files.My.MyRequestBuilder;

class Program
{
    static async Task Main(string[] args)
    {
        var authProvider = new AnonymousAuthenticationProvider();
        var adapter = new HttpClientRequestAdapter(authProvider);
        var client = new PostsClient(adapter);
        try
        {
            var authDto = new AuthRequestsDto
            {
                Password = "12345678",
                UserName = "test@onlyoffice.com"
            };
            var auth = await client.Auth.PostAsync(authDto);
            var token = auth?.Response?.Token ?? throw new InvalidOperationException("Response is null");

            var requestConfigGen = CreateRequestConfiguration<MyRequestBuilderGetQueryParameters>(token);
            var getFolderMy = await client.FolderMy.GetAsync(requestConfigGen);
            var folderMyId = getFolderMy?.Response?.Current?.Id ?? throw new InvalidOperationException("Response is null");
            var title = new CreateFolder
            {
                Title = "Test"
            };

            var requestConfig = CreateRequestConfiguration(token);
            var createFolder = await client.CreateFolderInFolderMy[folderMyId].PostAsync(title, requestConfig);
            var folderId = createFolder?.Response?.Id ?? throw new InvalidOperationException("Response is null");
            if (folderMyId == folderId)
            {
                Console.WriteLine("Success");
            }

            var get = await client.CreateFolderInFolderMy[folderId].GetAsync(requestConfig);
            Console.WriteLine($"{get?.StatusCode}");

            var newTitle = new CreateFolder
            {
                Title = "NewTitle"
            };
            var put = await client.CreateFolderInFolderMy[folderId].PutAsync(newTitle, requestConfig);
            var titleNew = put?.Response?.Title ?? throw new InvalidOperationException("Response is null");
            if (newTitle.Title == titleNew)
            {
                Console.WriteLine("Success");
            }

            var delete = await client.CreateFolderInFolderMy[folderId].PutAsync(newTitle, requestConfig);
            Console.WriteLine($"{delete?.StatusCode}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
    private static Action<RequestConfiguration<T>> CreateRequestConfiguration<T>(string token) where T : class, new()
    {
        return config =>
        {
            config.Headers.Add("Authorization", $"Bearer {token}");
        };
    }
    private static Action<RequestConfiguration<DefaultQueryParameters>> CreateRequestConfiguration(string token)
    {
        return config =>
        {
            config.Headers.Add("Authorization", $"Bearer {token}");
        };
    }
}

      