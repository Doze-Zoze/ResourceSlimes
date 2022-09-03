using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ResourceSlimes.Content.Items;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using Terraria.Localization;
namespace ResourceSlimes.Content.Items.Gel
{
	public class HellfireGel : ModItem
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
			Recipe recipe = Recipe.Create(ItemID.Hellstone, 3*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Eater of Worlds or Brain of Cthulhu"), r => NPC.downedBoss2)
			    .Register();
			recipe = Recipe.Create(ItemID.Obsidian, 2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if ((calamityMod != null))
            {
			calamityMod.Find<ModItem>("CharredOre").CreateRecipe(4*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
			    .Register();
			calamityMod.Find<ModItem>("UelibloomOre").CreateRecipe(5*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Providence"), r => (bool)calamityMod.Call("GetBossDowned", "providence"))
			    .Register();
            }

	}
}}