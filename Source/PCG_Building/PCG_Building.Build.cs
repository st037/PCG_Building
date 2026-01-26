// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PCG_Building : ModuleRules
{
	public PCG_Building(ReadOnlyTargetRules Target) : base(Target)
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
			"PCG_Building",
			"PCG_Building/Variant_Platforming",
			"PCG_Building/Variant_Platforming/Animation",
			"PCG_Building/Variant_Combat",
			"PCG_Building/Variant_Combat/AI",
			"PCG_Building/Variant_Combat/Animation",
			"PCG_Building/Variant_Combat/Gameplay",
			"PCG_Building/Variant_Combat/Interfaces",
			"PCG_Building/Variant_Combat/UI",
			"PCG_Building/Variant_SideScrolling",
			"PCG_Building/Variant_SideScrolling/AI",
			"PCG_Building/Variant_SideScrolling/Gameplay",
			"PCG_Building/Variant_SideScrolling/Interfaces",
			"PCG_Building/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
