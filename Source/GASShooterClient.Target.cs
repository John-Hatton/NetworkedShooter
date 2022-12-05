// Copyright 2020 Dan Kestranek.

using UnrealBuildTool;
using System.Collections.Generic;

public class GASShooterClientTarget : TargetRules
{
	public GASShooterClientTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GASShooter" } );
	}
}
