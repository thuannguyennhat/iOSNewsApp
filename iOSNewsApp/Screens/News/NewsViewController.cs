using System;

using UIKit;

namespace iOSNewsApp
{
	public partial class NewsViewController : UIViewController
	{
		public NewsViewController() : base("NewsViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

