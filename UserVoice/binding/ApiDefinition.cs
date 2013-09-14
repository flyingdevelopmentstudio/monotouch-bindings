using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UserVoice
{
	[BaseType(typeof(NSObject))]
	interface UVConfig
	{
		[Static, Export("configWithSite:")]
		UVConfig ConfigWithSite(string site);

		[Static, Export("configWithSite:andKey:andSecret:")]
		UVConfig ConfigWithSite(string site, string key, string secret);

		[Static, Export("configWithSite:andKey:andSecret:andSSOToken:")]
		UVConfig ConfigWithSite(string site, string key, string secret, string token);

		[Static, Export("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		UVConfig ConfigWithSite(string site, string key, string secret, string email, string displayName, string guid);

		[Export("site", ArgumentSemantic.Retain)]
		string Site { get; set; }

		[Export("key", ArgumentSemantic.Retain)]
		string Key { get; set; }

		[Export("secret", ArgumentSemantic.Retain)]
		string Secret { get; set; }

		[Export("ssoToken", ArgumentSemantic.Retain)]
		string SsoToken { get; set; }

		[Export("displayName", ArgumentSemantic.Retain)]
		string DisplayName { get; set; }

		[Export("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export("guid", ArgumentSemantic.Retain)]
		string Guid { get; set; }

		[Export("customFields", ArgumentSemantic.Retain)]
		NSDictionary CustomFields { get; set; }

		[Export("topicId")]
		int TopicId { get; set; }

		[Export("forumId")]
		int ForumId { get; set; }

		[Export("showForum")]
		bool ShowForum { get; set; }

		[Export("showPostIdea")]
		bool ShowPostIdea { get; set; }

		[Export("showContactUs")]
		bool ShowContactUs { get; set; }

		[Export("showKnowledgeBase")]
		bool ShowKnowledgeBase { get; set; }

		[Export("extraTicketInfo", ArgumentSemantic.Retain)]
		string ExtraTicketInfo { get; set; }

		[Export("identifyUserWithEmail:name:guid:")]
		void IdentifyUserWithEmail(string email, string name, string guid);
	}

	[Model, BaseType(typeof(NSObject))]
	interface UVDelegate
	{
		[Export("userVoiceWasDismissed")]
		void UserVoiceWasDismissed();
	}

	[BaseType(typeof(NSObject))]
	interface UVStyleSheet
	{
		[Static, Export("styleSheet")]
		UVStyleSheet StyleSheet { set; }

		[Static, Export("zebraBgColor:")]
		UIColor CurrentZebraBgColor(bool dark);

		[Static, Export("backgroundColor")]
		UIColor CurrentBackgroundColor { get; }

		[Static, Export("darkZebraBgColor")]
		UIColor CurrentDarkZebraBgColor { get; }

		[Static, Export("lightZebraBgColor")]
		UIColor CurrentLightZebraBgColor { get; }

		[Static, Export("topSeparatorColor")]
		UIColor CurrentTopSeparatorColor { get; }

		[Static, Export("bottomSeparatorColor")]
		UIColor CurrentBottomSeparatorColor { get; }

		[Static, Export("tableViewHeaderColor")]
		UIColor CurrentTableViewHeaderColor { get; }

		[Static, Export("tableViewHeaderShadowColor")]
		UIColor CurrentTableViewHeaderShadowColor { get; }

		[Static, Export("primaryTextColor")]
		UIColor CurrentPrimaryTextColor { get; }

		[Static, Export("secondaryTextColor")]
		UIColor CurrentSecondaryTextColor { get; }

		[Static, Export("signedInUserTextColor")]
		UIColor CurrentSignedInUserTextColor { get; }

		[Static, Export("labelTextColor")]
		UIColor CurrentLabelTextColor { get; }

		[Static, Export("linkTextColor")]
		UIColor CurrentLinkTextColor { get; }

		[Static, Export("alertTextColor")]
		UIColor CurrentAlertTextColor { get; }

		[Static, Export("navigationBarTintColor")]
		UIColor CurrentNavigationBarTintColor { get; }

		[Static, Export("navigationBarBackgroundImage")]
		UIImage CurrentNavigationBarBackgroundImage { get; }

		[Static, Export("navigationBarTextColor")]
		UIColor CurrentNavigationBarTextColor { get; }

		[Static, Export("navigationBarTextShadowColor")]
		UIColor CurrentNavigationBarTextShadowColor { get; }

		[Export("zebraBgColor:")]
		UIColor ZebraBgColor(bool dark);

		[Export("backgroundColor")]
		UIColor BackgroundColor { get; }

		[Export("darkZebraBgColor")]
		UIColor DarkZebraBgColor { get; }

		[Export("lightZebraBgColor")]
		UIColor LightZebraBgColor { get; }

		[Export("topSeparatorColor")]
		UIColor TopSeparatorColor { get; }

		[Export("bottomSeparatorColor")]
		UIColor BottomSeparatorColor { get; }

		[Export("tableViewHeaderColor")]
		UIColor TableViewHeaderColor { get; }

		[Export("tableViewHeaderShadowColor")]
		UIColor TableViewHeaderShadowColor { get; }

		[Export("primaryTextColor")]
		UIColor PrimaryTextColor { get; }

		[Export("secondaryTextColor")]
		UIColor SecondaryTextColor { get; }

		[Export("signedInUserTextColor")]
		UIColor SignedInUserTextColor { get; }

		[Export("labelTextColor")]
		UIColor LabelTextColor { get; }

		[Export("linkTextColor")]
		UIColor LinkTextColor { get; }

		[Export("alertTextColor")]
		UIColor AlertTextColor { get; }

		[Export("navigationBarTintColor")]
		UIColor NavigationBarTintColor { get; }

		[Export("navigationBarBackgroundImage")]
		UIImage NavigationBarBackgroundImage { get; }

		[Export("navigationBarTextColor")]
		UIColor NavigationBarTextColor { get; }

		[Export("navigationBarTextShadowColor")]
		UIColor NavigationBarTextShadowColor { get; }
	}

	[BaseType(typeof(NSObject))]
	interface UserVoice
	{

		[Static, Export("presentUserVoiceInterfaceForParentViewController:andConfig:")]
		void PresentUserVoiceInterfaceForParentViewController(UIViewController parentViewController, UVConfig config);

		[Static, Export("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		void PresentUserVoiceContactUsFormForParentViewController(UIViewController parentViewController, UVConfig config);

		[Static, Export("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		void PresentUserVoiceNewIdeaFormForParentViewController(UIViewController parentViewController, UVConfig config);

		[Static, Export("presentUserVoiceForumForParentViewController:andConfig:")]
		void PresentUserVoiceForumForParentViewController(UIViewController parentViewController, UVConfig config);

		[Static, Export("delegate")]
		UVDelegate Delegate { get; set; }

		[Static, Export("version")]
		string Version { get; }

		[Static, Export("setExternalId:forScope:")]
		void SetExternalId(string identifier, string scope);

		[Static, Export("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		void PresentUserVoiceModalViewControllerForParent(UIViewController viewController, string site, string key, string secret);

		[Static, Export("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		void PresentUserVoiceModalViewControllerForParent(UIViewController viewController, string site, string key, string secret, string token);

		[Static, Export("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		void PresentUserVoiceModalViewControllerForParent(UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid);
	}
}