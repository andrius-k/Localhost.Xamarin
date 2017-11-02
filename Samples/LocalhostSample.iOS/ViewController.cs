using System;

using UIKit;

namespace LocalhostSample.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ipLabel.Text = Sample.GetIP();
        }
    }
}
