// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FindMail
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ResultBox { get; set; }

		[Outlet]
		AppKit.NSTextView ResultView { get; set; }

		[Outlet]
		AppKit.NSButton SaveToFile { get; set; }

		[Outlet]
		AppKit.NSTextField SourceUrl { get; set; }

		[Action ("StartExtraction:")]
		partial void StartExtraction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ResultBox != null) {
				ResultBox.Dispose ();
				ResultBox = null;
			}

			if (SaveToFile != null) {
				SaveToFile.Dispose ();
				SaveToFile = null;
			}

			if (SourceUrl != null) {
				SourceUrl.Dispose ();
				SourceUrl = null;
			}

			if (ResultView != null) {
				ResultView.Dispose ();
				ResultView = null;
			}
		}
	}
}
