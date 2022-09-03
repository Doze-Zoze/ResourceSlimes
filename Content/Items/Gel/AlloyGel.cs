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
	public class AlloyGel : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Right click to extract contents.");
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
			
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if ((calamityMod != null))
            {
			calamityMod.Find<ModItem>("CryonicOre").CreateRecipe(5*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Cryogen"), r => (bool)calamityMod.Call("GetBossDowned", "cryogen"))
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2||NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
			    .Register();

			 calamityMod.Find<ModItem>("PerennialOre").CreateRecipe(5*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Plantera"), r => NPC.downedPlantBoss)
			    .Register();

			 calamityMod.Find<ModItem>("ScoriaOre").CreateRecipe(5*2)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Golem"), r => NPC.downedGolemBoss)
			    .Register();
            }

	}
}}