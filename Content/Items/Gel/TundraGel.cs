using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ResourceSlimes.Content.Items;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ResourceSlimes.Content.Items.Gel
{
	public class TundraGel : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Right click to extract contents."); // The (English) text shown below your item's name
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30; // How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.gamepedia.com/Journey_Mode/Research_list for a list of commonly used research amounts depending on item type.
		}

		public override void SetDefaults() {
			Item.width = 20; // The item texture's width
			Item.height = 20; // The item texture's height

			Item.maxStack = 999; // The item's max stack value
			Item.value = Item.sellPrice(copper: 1); // The value of the item in copper coins. Item.buyPrice & Item.sellPrice are helper methods that returns costs in copper coins based on platinum/gold/silver/copper arguments provided to it.
		}

		public override void AddRecipes()
		{
			var amount = 25;
			Recipe recipe = Recipe.Create(ItemID.SnowBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			recipe = Recipe.Create(ItemID.IceBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			recipe = Recipe.Create(ItemID.PurpleIceBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(Recipe.Condition.InCorrupt)
			    .Register();
			recipe = Recipe.Create(ItemID.RedIceBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(Recipe.Condition.InCrimson)
			    .Register();
			recipe = Recipe.Create(ItemID.PinkIceBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(Recipe.Condition.InHallow)
			    .Register();
			recipe = Recipe.Create(ItemID.ThinIce, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			recipe = Recipe.Create(ItemID.SlushBlock, amount)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
	}
}}