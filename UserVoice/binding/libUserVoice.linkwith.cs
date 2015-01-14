using System;
using ObjCRuntime;

[assembly: LinkWith ("libUserVoice.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks="QuartzCore SystemConfiguration")]
