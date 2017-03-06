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

            // Perform any additional setup after loading the view, typically from a nib.
           
            var table = new UITableView(View.Bounds); // defaults to Plain style
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            var adapter = new ListNewsTableViewSource();
            adapter.Items = tableItems;
            table.Source = adapter;
            Add(table);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

