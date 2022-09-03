using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ResourceSlimes.Content.Tiles
{
	public class SlimeCandle : ModTile
	{
		public override void SetStaticDefaults() {

			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			ItemDrop = ModContent.ItemType<Content.Items.SlimeCandle>();
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);
			
		}
		public override void NearbyEffects(int i, int j, bool closer)
		{if (closer) {
			Main.LocalPlayer.AddBuff(ModContent.BuffType<Content.Buffs.SlimeCandle>(), 10);
			Main.LocalPlayer.AddBuff(13, 10);
		}
		}
	}}