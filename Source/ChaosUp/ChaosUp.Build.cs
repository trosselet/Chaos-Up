// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ChaosUp : ModuleRules
{
	public ChaosUp(ReadOnlyTargetRules Target) : base(Target)
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
			"ChaosUp",
			"ChaosUp/Variant_Platforming",
			"ChaosUp/Variant_Platforming/Animation",
			"ChaosUp/Variant_Combat",
			"ChaosUp/Variant_Combat/AI",
			"ChaosUp/Variant_Combat/Animation",
			"ChaosUp/Variant_Combat/Gameplay",
			"ChaosUp/Variant_Combat/Interfaces",
			"ChaosUp/Variant_Combat/UI",
			"ChaosUp/Variant_SideScrolling",
			"ChaosUp/Variant_SideScrolling/AI",
			"ChaosUp/Variant_SideScrolling/Gameplay",
			"ChaosUp/Variant_SideScrolling/Interfaces",
			"ChaosUp/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
