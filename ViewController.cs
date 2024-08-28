using System;

using AppKit;
using Foundation;

namespace FindMail
{
	public partial class ViewController : NSViewController
	{

        internal static String Url;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			ResultView.Editable = false;

            // Do any additional setup after loading the view.
        }

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
        partial void StartExtraction(NSObject sender)
        {
			//Check if URL is valid
			SourceUrl.StringValue = Grabber.CheckUrl(SourceUrl.StringValue);
			//Url = SourceUrl.StringValue;

			//is URL valid?
			if (SourceUrl.StringValue.Equals("invalid"))
			{
				ResultView.Value = "Invalid URL provided. Please try another URL.";
			}else
			{
                //Extract Emails
                //ResultBox.StringValue = Grabber.ExtractEmails(Url);
                ResultView.Value = Grabber.ExtractEmails(Url);
            }
        }
    }
}
