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
		/**
     * A constant represents the ROCK music  
     */
		ROCK = 0x00000001,
		/**
     * A constant represents the COUNTRY music  
     */
		COUNTRY = 0x00000002,
		/**
     * A constant represents the BLUES music  
     */
		BLUES = 0x00000004,
		/**
     * A constant represents the FOLK music  
     */
		FOLK = 0x00000008,
		/**
     * A constant represents the ELECTRONIC music  
     */
		ELECTRONIC = 0x00000010,
		/**
     * A constant represents the SOUL / RnB music  
     */
		SOUL_RNB = 0x00000020,
		/**
     * A constant represents the POP music  
     */
		POP = 0x00000040,
		/**
     * A constant represents the JAZZ music  
     */
		JAZZ = 0x00000080,
		/**
     * A constant represents the REGGAE music  
     */
		REGGAE = 0x00000100,
		/**
     * A constant represents the HIP HOP music  
     */
		HIP_HOP = 0x00000200,
		/**
     * A constant represents the METAL music  
     */
		METAL = 0x00000400,
		/**
     * A constant represents the NEW AGE music  
     */
		NEW_AGE = 0x00000800,
		/**
     * A constant represents the ENTERTAINMENT music  
     */
		ENTERTAINMENT = 0x00001000,
		/**
     * A constant represents the CLASSICAL - Early & Common Practice music  
     */
		CLASSICAL_EARLY_COMMON_PRACTICE = 0x00002000,
		/**
     * A constant represents the CLASSICAL - Modern & Contemporary music  
     */
		CLASSICAL_MODERN_CONTEMPORARY = 0x00004000,
		/**
     * A constant represents the MIDDLE EAST music  
     */
		MIDDLE_EAST = 0x00008000,
		/**
     * A constant represents the OCEANIA music  
     */
		OCEANIA = 0x00010000,
		/**
     * A constant represents the LATIN music  
     */
		LATIN = 0x00020000,
		/**
     * A constant represents the EUROPE music  
     */
		EUROPE = 0x00040000,
		/**
     * A constant represents the AFRICA music  
     */
		AFRICA = 0x00080000
	}
}

