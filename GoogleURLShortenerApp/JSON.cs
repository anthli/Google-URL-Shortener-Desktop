using System.IO;

using Newtonsoft.Json;

namespace GoogleURLShortenerDesktopGUI {
  public partial class MainWindow {
    class JSON {
      public static string GetAPIKey(string file) {
        // The Google API Key needs to be parsed from a local JSON file
        using (StreamReader r = new StreamReader(file)) {
          dynamic json = JsonConvert.DeserializeObject(r.ReadToEnd());

          return json.apikey;
        }
      }
    }
  }
}