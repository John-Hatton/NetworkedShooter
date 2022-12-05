// Copyright 2020 Dan Kestranek.

using UnrealBuildTool;
using System.Collections.Generic;

public class GASShooterServerTarget : TargetRules
{
	public GASShooterServerTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GASShooter" } );
	}
}
