using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using ResourceSlimes.Content.Items;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;


namespace ResourceSlimes.Content.Items
{
	class MineralCandle : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases Spawn Rates\nOnly Mineral Slimes can spawn near this candle\nWhen also near a Material candle, both types of slimes can spawn.\nWhen also near a Slime candle, Merchant slimes can spawn.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;	
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Candle);
			Item.createTile = ModContent.TileType<Content.Tiles.MineralCandle>();
			
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Candle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>(), 10)
				.AddTile(TileID.Solidifier)
			    .Register();
			CreateRecipe(1)
                .AddIngredient(ItemID.PlatinumCandle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>(), 10)
				.AddTile(TileID.Solidifier)
			    .Register();
            
		}

	}
}