using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ResourceSlimes.Content.Tiles
{
	public class TyrantCandle : ModTile
	{
		public override void SetStaticDefaults() {

			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileWaterDeath[Type] = true;
			Main.tileLavaDeath[Type] = true;
			ItemDrop = ModContent.ItemType<Content.Items.TyrantCandle>();
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
			TileObjectData.addTile(Type);
			
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			Tile tile = Main.tile[i, j];
			if (tile.TileFrameX == 0) {
				// We can support different light colors for different styles here: switch (tile.frameY / 54)
				r = 1f;
				g = 1f;
				b = 1f;
			}
		}
		public override void NearbyEffects(int i, int j, bool closer)
		{if (closer) {
			Main.LocalPlayer.AddBuff(ModContent.BuffType<Content.Buffs.TyrantCandle>(), 10);
		}
		}
	}}