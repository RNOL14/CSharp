using Microsoft.Maui.Handlers;

namespace MauiApp13.Controls;

public class BorderlessEntry : Entry
{
  public BorderlessEntry()
  {
    ModifyEntry();
  }

  private void ModifyEntry()
  {
    EntryHandler.Mapper.AppendToMapping("RemoveBorder", (handler, view) =>
    {
      if (view is not BorderlessEntry)
        return;

#if ANDROID
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif IOS || MACCATALYST
      handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
      handler.PlatformView.Layer.BorderWidth = 0;
      handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
            handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            handler.PlatformView.Background = null;
            handler.PlatformView.FocusVisualMargin = new Microsoft.UI.Xaml.Thickness(0);
#endif
    });
  }
}
