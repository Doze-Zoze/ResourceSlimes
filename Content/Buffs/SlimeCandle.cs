using Terraria;
using Terraria.ModLoader;

namespace ResourceSlimes.Content.Buffs
{
	public class SlimeCandle : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Slimy Candle");
			Description.SetDefault("Greatly increases Resource Slime spawn rates");
            Main.buffNoTimeDisplay[ModContent.BuffType<Content.Buffs.SlimeCandle>()] = true;
		}

	}
}