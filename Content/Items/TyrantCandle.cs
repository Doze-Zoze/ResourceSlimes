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
	class TyrantCandle : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This seems dangerous.\nMassively increases enemy spawn rates.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;	
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Candle);
			Item.createTile = ModContent.TileType<Content.Tiles.TyrantCandle>();
			
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Candle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(), 25)
				.AddTile(TileID.Solidifier)
			    .Register();
			CreateRecipe(1)
                .AddIngredient(ItemID.PlatinumCandle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(), 25)
				.AddTile(TileID.Solidifier)
			    .Register();
            
		}

	}
}