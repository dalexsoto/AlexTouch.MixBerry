using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlexTouch.Mixberry
{
	[BaseType (typeof (UIViewController))]
	interface MBAdViewViewController 
	{
		[Export ("type")]
		int Type { get; set; }

		[Export ("image", ArgumentSemantic.Retain)]
		UIImage Image { get; set; }

		[Export ("setImageWithURL:")]
		void SetImageWithURL (string url);
	}

	[BaseType (typeof (MBAdViewViewController))]
	interface MBAd300x250ViewController 
	{
	}

	[BaseType (typeof (MBAd300x250ViewController))]
	interface MBAd300x250DialogViewController 
	{
	}

	[BaseType (typeof (NSObject))]
	interface MBAdBundle 
	{
		[Export ("mbAd300x250DialogViewController", ArgumentSemantic.Retain)]
		MBAd300x250DialogViewController MbAd300x250DialogViewController { get; set; }

		[Export ("getBannerSizeValue")]
		int BannerSizeValue { [Bind("getBannerSizeValue")] get; }
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface SDKDelegate 
	{
		[Abstract]
		[Export ("getApiKey")]
		string GetApiKey ();

		[Abstract]
		[Export ("finishedWithStatus:")]
		void FinishedWithStatus (SDKResultCode status);

		[Export ("adReady:")]
		void AdReady (string theAd);

		[Export ("streamingEnabled")]
		bool StreamingEnabled ();

		[Export ("getAge")]
		int GetAge ();

		[Export ("getGender")]
		string GetGender ();

		[Export ("getEducation")]
		string GetEducation ();

		[Export ("getInterest")]
		string GetInterest ();

		[Export ("getJob")]
		string GetJob ();

		[Export ("getLanguage")]
		string GetLanguage ();
	}

	[BaseType (typeof (NSObject))]
	interface SDKService 
	{
		[Export ("initializeWithDelegate:")] [Static]
		void InitializeWithDelegate (SDKDelegate aDelegate);

		[Export ("getAd")] [Static]
		void GetAd ();

		[Export ("getAdWithLenght:")] [Static]
		void GetAdWithLenght (ADPeriod adLength);

		[Export ("getAdWithBannerAndLenght:")] [Static]
		void GetAdWithBannerAndLenght (ADPeriod adLength);

		[Export ("getAdWithBanner")] [Static]
		void GetAdWithBanner ();

		[Export ("setMusicGenre:")] [Static]
		void SetMusicGenre (MusicGenres genre);

		[Export ("setMusicMood:")] [Static]
		void SetMusicMood (long mood);

		[Export ("setAdType:")] [Static]
		void SetAdType (ADType adType);

		[Export ("infoChanged")] [Static]
		void InfoChanged ();

		[Export ("getEducationLevelValues")] [Static]
		string [] EducationLevelValues { get; }

		[Export ("getJobGroupValues")] [Static]
		string [] JobGroupValues { get; }

		[Export ("getInterestsValues")] [Static]
		string [] InterestsValues { get; }

		[Export ("getGenderValues")] [Static]
		string [] GenderValues { get; }

		[Export ("getCountryValues")] [Static]
		string [] CountryValues { get; }

		[Export ("getLanguagesValues")] [Static]
		string [] LanguagesValues { get; }
	}

}

