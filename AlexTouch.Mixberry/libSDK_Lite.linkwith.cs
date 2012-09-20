using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSDK_Lite.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "AudioToolbox SystemConfiguration CFNetwork QuartzCore CoreFoundation")]
