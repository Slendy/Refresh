using System.Net.Http.Json;
using Refresh.GameServer.Authentication;
using Refresh.GameServer.Endpoints.ApiV3.DataTypes.Request;
using Refresh.GameServer.Types.Levels;
using Refresh.GameServer.Types.UserData;

namespace RefreshTests.GameServer.Tests.ApiV3;

public class EditApiTests : GameServerTest
{
    [Test]
    public void CanUpdateLevel()
    {
        using TestContext context = this.GetServer();
        GameUser user = context.CreateUser();
        GameLevel level = context.CreateLevel(user, "Not updated");

        ApiEditLevelRequest payload = new()
        {
            Title = "Updated",
        };

        using HttpClient client = context.GetAuthenticatedClient(TokenType.Api, user);

        HttpResponseMessage response = client.PatchAsync($"/api/v3/levels/id/{level.LevelId}", JsonContent.Create(payload)).Result;
        Assert.That(response.StatusCode, Is.EqualTo(OK));
        
        context.Database.Refresh();
        Assert.That(level.Title, Is.EqualTo("Updated"));
    }
}