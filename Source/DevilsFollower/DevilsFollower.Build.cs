// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DevilsFollower : ModuleRules
{
	public DevilsFollower(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DevilsFollower",
			"DevilsFollower/Variant_Horror",
			"DevilsFollower/Variant_Horror/UI",
			"DevilsFollower/Variant_Shooter",
			"DevilsFollower/Variant_Shooter/AI",
			"DevilsFollower/Variant_Shooter/UI",
			"DevilsFollower/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
