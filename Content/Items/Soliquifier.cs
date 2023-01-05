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
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Can perform all Resource Gel conversions regardless of location, but outputs half as many resources per Gel.\nDoes not function as a Solidifier.");
        }
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Solidifier);
            Item.createTile = ModContent.TileType<Content.Tiles.SoliquifierTile>();

        }

        public override void AddRecipes()
		{
			CreateRecipe(1)
                .AddIngredient(ItemID.Gel)
				.AddIngredient(ItemID.PinkGel)
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MaterialGel>())
				.AddIngredient(ItemID.DirtBlock)
				.AddIngredient(ItemID.StoneBlock)
				.AddIngredient(ItemID.SnowBlock)
				.AddIngredient(ItemID.SandBlock)
				.AddIngredient(ItemID.JungleSpores)
				.AddIngredient(ItemID.SoulofLight)
				.AddIngredient(ItemID.SoulofNight)
				.AddTile(TileID.WorkBenches)
				.AddCondition(Recipe.Condition.NearHoney)
				.AddCondition(Recipe.Condition.NearWater)
				.AddCondition(Recipe.Condition.NearLava)
				.Register();
            
		}

	}
}