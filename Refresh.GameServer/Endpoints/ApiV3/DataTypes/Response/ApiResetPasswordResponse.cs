#nullable disable
namespace Refresh.GameServer.Endpoints.ApiV3.DataTypes.Response;

[JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
public class ApiResetPasswordResponse : IApiAuthenticationResponse
{
    public string Reason { get; set; }
    public string ResetToken { get; set; }
}