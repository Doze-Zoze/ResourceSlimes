using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ResourceSlimes.Content.Tiles
{
	public class SoliquifierTile : ModTile
	{
		public override void SetStaticDefaults() {

			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			ItemDrop = ModContent.ItemType<Content.Items.Soliquifier>();
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Soliquifier");
			AddMapEntry(new Color(152, 171, 198), name);
		}
	}}