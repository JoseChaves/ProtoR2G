// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Prototipo1.iOS
{
	[Register ("View2")]
	partial class View2
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView Page2 { get; set; }

		[Action ("UIButton194_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton194_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (Page2 != null) {
				Page2.Dispose ();
				Page2 = null;
			}
		}
	}
}
