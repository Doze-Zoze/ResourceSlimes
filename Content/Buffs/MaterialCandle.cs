using Terraria;
using Terraria.ModLoader;

namespace ResourceSlimes.Content.Buffs
{
	public class MaterialCandle : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Material Candle");
			Description.SetDefault("Replaces Mineral slimes with Material slimes.");
            Main.buffNoTimeDisplay[ModContent.BuffType<Content.Buffs.SlimeCandle>()] = true;
		}

	}
}