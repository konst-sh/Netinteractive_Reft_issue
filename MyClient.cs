namespace Netinteractive_Reft_issue;
using Refit;
using System.Text.Json;

public interface IMyRefitClient
{
    [Get("/openapi")]
    Task<ApiResponse<string>> GetOpenapi();
}

public class ClientMaker
{
    private static JsonSerializerOptions opt = new() { AllowOutOfOrderMetadataProperties = true };
    private static RefitSettings refitSettings = new() { ContentSerializer = new SystemTextJsonContentSerializer(opt) };
    public static IMyRefitClient MakeMyRefitClient() => RestService.For<IMyRefitClient>("https://cad.onshape.com/api/v9", refitSettings);
}