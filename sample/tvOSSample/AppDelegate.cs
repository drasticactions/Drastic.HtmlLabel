namespace tvOSSample;

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
        this.Window = new UIWindow();

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();

        var label = new Drastic.Controls.HtmlLabel(Window!.Frame)
        {
            TextAlignment = UITextAlignment.Center,
            AutoresizingMask = UIViewAutoresizing.All,
        };

        label.SetHtml(Sample.TestGenerator.GenerateHtml());

        vc.View!.AddSubview(label);

        Window.RootViewController = vc;

        this.Window.MakeKeyAndVisible();

        return true;
    }
}
