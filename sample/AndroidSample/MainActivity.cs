using Sample;

namespace AndroidSample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var content_mainLayout = new RelativeLayout(this);
        content_mainLayout.LayoutParameters = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.MatchParent);

        Drastic.Controls.HtmlLabel tView1 = new Drastic.Controls.HtmlLabel(this);
        tView1.SetHtml(TestGenerator.GenerateHtml());
        var tView1LayParams = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.MatchParent);

        tView1.LayoutParameters = tView1LayParams;
        content_mainLayout.AddView(tView1);

        this.SetContentView(content_mainLayout);
    }
}