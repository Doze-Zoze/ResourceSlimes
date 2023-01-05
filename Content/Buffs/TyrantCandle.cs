using Terraria;
using Terraria.ModLoader;

namespace ResourceSlimes.Content.Buffs
{
	public class TyrantCandle : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Tyrant Candle");
			Description.SetDefault("Alerts the hordes to your location.");
            Main.buffNoTimeDisplay[ModContent.BuffType<Content.Buffs.TyrantCandle>()] = true;
		}
	}
}