// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOSNewsApp
{
	[Register ("DetailsViewController")]
	partial class DetailsViewController
	{
		[Outlet]
		UIKit.UIWebView myWebView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myWebView != null) {
				myWebView.Dispose ();
				myWebView = null;
			}
		}
	}
}
