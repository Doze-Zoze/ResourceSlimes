using Terraria;
using Terraria.ModLoader;

namespace ResourceSlimes.Content.Buffs
{
	public class MineralCandle : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Mineral Candle");
			Description.SetDefault("Rapidly spawns Mineral slimes.");
            Main.buffNoTimeDisplay[ModContent.BuffType<Content.Buffs.MineralCandle>()] = true;
		}

	}
}