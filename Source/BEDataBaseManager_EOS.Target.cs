// Copyright (C) 2024 owoDra

using UnrealBuildTool;
using System.Collections.Generic;

public class BEDataBaseManager_EOSTarget : BEDataBaseManagerTarget
{
	public BEDataBaseManager_EOSTarget(TargetInfo Target) : base(Target)
	{
		// Add override directory for EOS config files
		// We have to recompile the engine to add the custom config preprocessor definition, but that is currently not possible for installed builds
		
		CustomConfig = "EOS";
	}
}
