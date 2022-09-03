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
	public class MythicalOreGel : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Contains ores of myth and legends.\nUse a Soliquifier to extract resources."); // The (English) text shown below your item's name
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
			
			Recipe recipe = Recipe.Create(ItemID.CobaltOre, 24)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			recipe = Recipe.Create(ItemID.PalladiumOre, 24)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
            
			recipe = Recipe.Create(ItemID.MythrilOre, 24)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
			    .Register();
            recipe = Recipe.Create(ItemID.OrichalcumOre, 24)
			    .AddIngredient(this)
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
            recipe = Recipe.Create(ItemID.AdamantiteOre, 24)
			    .AddIngredient(this)
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2||NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
            recipe = Recipe.Create(ItemID.TitaniumOre, 24)
			    .AddIngredient(this)
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2||NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
            recipe = Recipe.Create(ItemID.ChlorophyteOre, 24)
			    .AddIngredient(this)
				.AddCondition(NetworkText.FromKey("Defeat all three Mechanical Bosses"), r => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
        }

	}
}