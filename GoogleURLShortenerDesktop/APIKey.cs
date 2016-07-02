using System.IO;
using System.Windows;

namespace GoogleURLShortenerDesktop {
  public partial class MainWindow {
    class APIKey {
      private static string apiKey;

      public static string GetAPIKey(string file) {
        // The Google API Key needs to be parsed from the apikey file
        try {
          using (StreamReader r = new StreamReader(file)) {
            apiKey = File.ReadAllText(file);
          }
        }
        catch (System.IO.FileNotFoundException e) {
          MessageBox.Show("The file containing your Google API Key is " +
            "missing. Please enter it again.", e.GetType().ToString());

          new APIKeyWindow().Show();
          Utils.CloseWindow("Google URL Shortener");
        }

        return apiKey;
      }
    }
  }
}