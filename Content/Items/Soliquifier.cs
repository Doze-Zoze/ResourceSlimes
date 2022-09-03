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
	class Soliquifier : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Solidifier);
			Item.createTile = ModContent.TileType<Content.Tiles.SoliquifierTile>();

		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Solidifier, 1)
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(), 10)
			    .Register();
            
		}

	}
}