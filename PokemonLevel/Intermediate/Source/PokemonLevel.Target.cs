using UnrealBuildTool;

public class PokemonLevelTarget : TargetRules
{
	public PokemonLevelTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PokemonLevel");
	}
}
