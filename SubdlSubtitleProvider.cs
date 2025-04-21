using MediaBrowser.Controller.Subtitles;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Plugins;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class SubdlSubtitleProvider : IRemoteSubtitleProvider
{
    private readonly IHttpClient _httpClient;
    private readonly PluginConfiguration _config;

    public SubdlSubtitleProvider(IHttpClient httpClient, PluginConfiguration config)
    {
        _httpClient = httpClient;
        _config = config;
    }

    public async Task<IEnumerable<RemoteSubtitleInfo>> GetSubtitles(SubtitleSearchRequest request, CancellationToken cancellationToken)
    {
        var url = $"https://api.subdl.com/api/v1/subtitles?api_key={_config.ApiKey}&imdb_id={request.ImdbId}&type=movie&languages={_config.Languages}";
        var response = await _httpClient.Get(new HttpRequestOptions { Url = url }, cancellationToken);
        var result = await response.GetContent().FromJsonAsync<SubdlResponse>();
        // تحويل النتيجة إلى RemoteSubtitleInfo...
    }
}
