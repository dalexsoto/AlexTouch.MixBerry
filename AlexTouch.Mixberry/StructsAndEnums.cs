using System;

namespace AlexTouch.Mixberry
{
	public enum SDKResultCode
	{
		Success = 0,
		NoNetworkConnection = 10,
		DeviceMuted = 11,
		DeviceBusyWithPhoneCall = 12,
		ServerError = 20,
		Timeout = 21,
		InvalidApiKey = 22,
		Busy = 31,
		InvalidParameters = 32,
		InternalServiceError = 35,
		ServiceNotReady = 36,
	}

	public enum ADPeriod
	{
		Short = 1,
		Normal = 2,
		Long = 4
	}

	public enum ADType
	{
		Audio = 1,
		//ADTypeBanner = 2,
		AudioAndBanner = 3
	}

	public enum MusicGenres
	{
		ROCK = 0x00000001,


		COUNTRY = 0x00000002,

		BLUES = 0x00000004,

		FOLK = 0x00000008,

		ELECTRONIC = 0x00000010,

		SOUL_RNB = 0x00000020,

		POP = 0x00000040,

		JAZZ = 0x00000080,

		REGGAE = 0x00000100,

		METAL = 0x00000400,

		NEW_AGE = 0x00000800,

		ENTERTAINMENT = 0x00001000,

		CLASSICAL_EARLY_COMMON_PRACTICE = 0x00002000,

		CLASSICAL_MODERN_CONTEMPORARY = 0x00004000,

		MIDDLE_EAST = 0x00008000,

		OCEANIA = 0x00010000,

		LATIN = 0x00020000,

		EUROPE = 0x00040000,

		AFRICA = 0x00080000
	}
}

