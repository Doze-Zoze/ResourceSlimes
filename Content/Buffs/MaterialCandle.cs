using Terraria;
using Terraria.ModLoader;

namespace ResourceSlimes.Content.Buffs
{
	public class MaterialCandle : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Material Candle");
			Description.SetDefault("Rapidly spawns Material slimes.");
            Main.buffNoTimeDisplay[ModContent.BuffType<Content.Buffs.MaterialCandle>()] = true;
		}

	}
}