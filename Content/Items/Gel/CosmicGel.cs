using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ResourceSlimes.Content.Items;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using System.Collections.Generic;
using System.Linq;
using Terraria.Localization;

namespace ResourceSlimes.Content.Items.Gel
{
	public class CosmicGel : ModItem
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
			
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if ((calamityMod != null))
            {
			var resultItem = calamityMod.Find<ModItem>("AstralOre");
			resultItem.CreateRecipe(2*2)
			    .AddIngredient(this, 1)
				.AddCondition(NetworkText.FromKey("Defeat Astrum Deus"), r => (bool)calamityMod.Call("GetBossDowned", "astrumdeus"))
				.AddTile<Content.Tiles.SoliquifierTile>()
			    .Register();
			resultItem = calamityMod.Find<ModItem>("ExodiumCluster");
			resultItem.CreateRecipe(5)
			    .AddIngredient(this, 1)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
			    .Register();
            }
			Recipe recipe = Recipe.Create(ItemID.LunarOre, 4*2)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
			    .Register();
			recipe = Recipe.Create(ItemID.FragmentSolar, 5)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Solar Pillar"), r => NPC.downedTowerSolar)
			    .Register();
            recipe = Recipe.Create(ItemID.FragmentStardust, 5)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Stardust Pillar"), r => NPC.downedTowerStardust)
			    .Register();
			recipe = Recipe.Create(ItemID.FragmentNebula, 5)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Nebula Pillar"), r => NPC.downedTowerNebula)
			    .Register();
			recipe = Recipe.Create(ItemID.FragmentVortex, 5)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Vortex Pillar"), r => NPC.downedTowerVortex)
			    .Register();
			recipe = Recipe.Create(ItemID.Meteorite, 3*2)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Eater of Worlds or Brain of Cthulhu"), r => NPC.downedBoss2)
			    .Register();
			recipe = Recipe.Create(ItemID.FallenStar, 3)
			    .AddIngredient(this)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(Recipe.Condition.TimeNight)
			    .Register();

	}
}}