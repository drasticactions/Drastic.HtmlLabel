namespace iOSSample;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window
    {
        get;
        set;
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        var label = new Drastic.Controls.HtmlLabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            AutoresizingMask = UIViewAutoresizing.All,
        };

        label.SetHtml(Sample.TestGenerator.GenerateHtml());

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        vc.View!.AddSubview(label);
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}
