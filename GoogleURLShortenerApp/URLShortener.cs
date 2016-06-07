using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;

namespace GoogleURLShortenerDesktopGUI {
  public partial class MainWindow {
    class URLShortener {
      private static UrlshortenerService service;

      // A request needs to be sent to the Google URL Shortener API containing
      // longURL so that the shortened version of it can be returned
      public static string ShortenURL(string longURL) {
        var apiKey = JSON.GetAPIKey("apiKey.json");

        service = new UrlshortenerService(new BaseClientService.Initializer() {
          ApiKey = apiKey
        });

        var req = new Google.Apis.Urlshortener.v1.Data.Url();
        req.LongUrl = longURL;

        return service.Url.Insert(req).Execute().Id;
      }
    }
  }
}