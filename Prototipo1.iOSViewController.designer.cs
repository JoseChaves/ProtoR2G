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
	[Register ("Prototipo1_iOSViewController")]
	partial class Prototipo1_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField Password { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton register { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UserName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}
			if (register != null) {
				register.Dispose ();
				register = null;
			}
			if (UserName != null) {
				UserName.Dispose ();
				UserName = null;
			}
		}
	}
}
