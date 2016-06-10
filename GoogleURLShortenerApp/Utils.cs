using System.Linq;
using System.Windows;

namespace GoogleURLShortenerApp {
  public class Utils {
    // Source: http://goo.gl/xD3OnW
    // Check if a specific window is open
    public static bool IsWindowOpen<APIKeyWindow>(string name = "")
      where APIKeyWindow : Window {
      return string.IsNullOrEmpty(name) ?
        Application.Current.Windows.OfType<APIKeyWindow>().Any() :
        Application.Current.Windows.OfType<APIKeyWindow>().Any(w =>
          w.Name.Equals(name)
        );
    }

    // Close a window given its title
    public static void CloseWindow(string title) {
      foreach (Window window in Application.Current.Windows) {
        if (window.Title == title) {
          window.Close();
        }
      }
    }
  }
}