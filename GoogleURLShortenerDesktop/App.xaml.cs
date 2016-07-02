using System.IO;
using System.Windows;

namespace GoogleURLShortenerDesktop {
  public partial class App : Application {
    void AppStartup(object sender, StartupEventArgs e) {
      // The apikey file containing the Google API Key needs to be in the same
      // directory as the app before proceeding
      if (File.Exists("apikey")) {
        new MainWindow().Show();
      }
      else {
        new APIKeyWindow().Show();
      }
    }
  }
}