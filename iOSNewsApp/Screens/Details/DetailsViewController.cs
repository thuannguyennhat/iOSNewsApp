using System;
using Foundation;
using UIKit;
using WebKit;

namespace iOSNewsApp
{
	public partial class DetailsViewController : UIViewController
	{
		public DetailsViewController() : base("DetailsViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var url = new NSUrl("http://vnexpress.net/");
			var request = new NSUrlRequest(url);
			myWebView.LoadRequest(request);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

