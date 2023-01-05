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
	class SlimeCandle : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("When placed, only allows Material, Mineral, or Merchant Slimes to spawn.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;	
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Candle);
			Item.createTile = ModContent.TileType<Content.Tiles.SlimeCandle>();
			
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Candle, 1)
			    .AddIngredient(ItemID.Gel, 25)
				.AddTile(TileID.Solidifier)
			    .Register();
			CreateRecipe(1)
                .AddIngredient(ItemID.PlatinumCandle, 1)
			    .AddIngredient(ItemID.Gel, 25)
				.AddTile(TileID.Solidifier)
			    .Register();
            
		}

	}
}