using Google;
using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;
using System.Linq;
using System.Windows;

namespace GoogleURLShortenerApp {
  public partial class MainWindow {
    class URLShortener {
      private static UrlshortenerService service;
      private static string shortURL;

      // A request needs to be sent to the Google URL Shortener API containing
      // longURL so that the shortened version of it can be returned
      public static string ShortenURL(string longURL) {
        // Parse the Google API Key from apiKey.json
        var apiKey = APIKey.GetAPIKey("apikey");

        // UrlshortenerService with the parse API Key
        service = new UrlshortenerService(new BaseClientService.Initializer() {
          ApiKey = apiKey
        });

        // Request containing the longURL
        var req = new Google.Apis.Urlshortener.v1.Data.Url();
        req.LongUrl = longURL;

        // Insert the request to the API and return the short URL
        try {
          shortURL = service.Url.Insert(req).Execute().Id;
        }
        catch (GoogleApiException e) {
          // Don't show a second APIKeyWindow if one is already open from
          // the System.IO.FileNotFoundException in APIKey.cs
          if (Utils.IsWindowOpen<APIKeyWindow>("Google API Key")) {
            MessageBox.Show("Your Google API Key is incorrect. Please enter " +
              "it again.", e.GetType().ToString());

            new APIKeyWindow().Show();
            Utils.CloseWindow("Google URL Shortener");
          }
        }

        return shortURL;
      }
    }
  }
}