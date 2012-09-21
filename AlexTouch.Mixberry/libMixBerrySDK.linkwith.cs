using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMixBerrySDK.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "AudioToolbox SystemConfiguration CFNetwork QuartzCore CoreFoundation CoreGraphics")]