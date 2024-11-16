namespace Netinteractive_Reft_issue;
using Refit;

public interface IMyRefitClient
{
    [Get("/openapi")]
    Task<ApiResponse<string>> GetOpenapi();
}

public class ClientMaker
{
    public static IMyRefitClient MakeMyRefitClient() => RestService.For<IMyRefitClient>("https://cad.onshape.com/api/v9");
}