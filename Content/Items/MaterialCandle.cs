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
	class MaterialCandle : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Candle);
			Item.createTile = ModContent.TileType<Content.Tiles.SlimeCandle>();

		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Candle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(), 10)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			CreateRecipe(1)
                .AddIngredient(ItemID.PlatinumCandle, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(), 10)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
            
            
		}

	}
}