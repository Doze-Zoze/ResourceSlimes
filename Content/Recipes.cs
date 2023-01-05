using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ResourceSlimes.Content
{
	public class MaterialRecipes : ModSystem
	{
		public override void AddRecipes()
		{
			var amount = 1.0;
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			Recipe recipe = Recipe.Create(ItemID.RedHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.OrangeBloodroot, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.YellowMarigold, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.LimeKelp, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.TealMushroom, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.CyanHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.SkyBlueFlower, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.BlueBerries, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.PurpleMucos, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.VioletHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.PinkPricklyPear, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.BlackInk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant1, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant2, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant3, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant4, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddTile(TileID.DyeVat)
				.Register();
			recipe = Recipe.Create(ItemID.LivingFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LivingCursedFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LivingDemonFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LivingFrostFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LivingIchorBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LivingFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			if ((calamityMod != null))
			{
				calamityMod.Find<ModItem>("LivingBrimstoneFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile(TileID.Solidifier)
					.AddCondition(Recipe.Condition.InUnderworldHeight)
					.Register();
				calamityMod.Find<ModItem>("LivingHolyFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile(TileID.Solidifier)
					.AddCondition(Recipe.Condition.InUnderworldHeight)
					.Register();
				calamityMod.Find<ModItem>("LivingGodSlayerFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile(TileID.Solidifier)
					.AddCondition(Recipe.Condition.InUnderworldHeight)
					.Register();
			}
			recipe = Recipe.Create(ItemID.BoneTorch, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddIngredient(ItemID.Torch, (int)(amount * 25))
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InDungeon)
				.Register();
			recipe = Recipe.Create(ItemID.Obsidian, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearLava)
				.AddCondition(Recipe.Condition.NearWater)
				.Register();
			recipe = Recipe.Create(ItemID.HoneyBlock, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearHoney)
				.AddCondition(Recipe.Condition.NearWater)
				.Register();
			recipe = Recipe.Create(ItemID.CrispyHoneyBlock, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearHoney)
				.AddCondition(Recipe.Condition.NearLava)
				.Register();
			recipe = Recipe.Create(ItemID.WetBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearWater)
				.Register();
			recipe = Recipe.Create(ItemID.LavaBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearLava)
				.Register();
			recipe = Recipe.Create(ItemID.HoneyBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.NearHoney)
				.Register();
			recipe = Recipe.Create(ItemID.Wood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.PalmWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InBeach)
				.Register();
			recipe = Recipe.Create(ItemID.PalmWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InDesert)
				.Register();
			recipe = Recipe.Create(ItemID.BorealWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.Pearlwood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InHallow)
				.Register();
			recipe = Recipe.Create(ItemID.Shadewood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.Ebonwood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.RichMahogany, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InJungle)
				.Register();
			recipe = Recipe.Create(ItemID.HerbBag, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.Mushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.GlowingMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGlowshroom)
				.Register();
			recipe = Recipe.Create(ItemID.VileMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.ViciousMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.VineRope, (int)(amount * 50))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.Vine, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InJungle)
				.Register();
			recipe = Recipe.Create(ItemID.JungleSpores, (int)(amount * 6))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InJungle)
				.Register();
			recipe = Recipe.Create(ItemID.JungleRose, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InJungle)
				.Register();
			recipe = Recipe.Create(ItemID.GrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.CorruptSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.CrimsonSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.CorruptSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.AddCondition(Recipe.Condition.InGraveyardBiome)
				.Register();
			recipe = Recipe.Create(ItemID.CrimsonSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.AddCondition(Recipe.Condition.InGraveyardBiome)
				.Register();
			recipe = Recipe.Create(ItemID.HallowedSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InHallow)
				.Register();
			recipe = Recipe.Create(ItemID.JungleGrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InJungle)
				.Register();
			recipe = Recipe.Create(ItemID.MushroomGrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGlowshroom)
				.Register();
			recipe = Recipe.Create(ItemID.DirtBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.StoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.EbonstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.CrimstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.PearlstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InHallow)
				.Register();
			recipe = Recipe.Create(ItemID.MudBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.ClayBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.SandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.EbonsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.CrimsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.PearlsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InHallow)
				.Register();
			recipe = Recipe.Create(ItemID.Marble, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.Granite, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.AshBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.SiltBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.DesertFossil, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InUndergroundDesert)
				.Register();
			recipe = Recipe.Create(ItemID.SnowBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.IceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.PurpleIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCorrupt)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.RedIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InCrimson)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.PinkIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InHallow)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.ThinIce, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			recipe = Recipe.Create(ItemID.SlushBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InSnow)
				.Register();
			/* soliquifier */
			amount = 0.5;
			recipe = Recipe.Create(ItemID.RedHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.OrangeBloodroot, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.YellowMarigold, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LimeKelp, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.TealMushroom, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CyanHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SkyBlueFlower, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.BlueBerries, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PurpleMucos, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.VioletHusk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PinkPricklyPear, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.BlackInk, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant1, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant2, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant3, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.StrangePlant4, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingCursedFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingDemonFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingFrostFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingIchorBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LivingFireBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			if ((calamityMod != null))
			{
				calamityMod.Find<ModItem>("LivingBrimstoneFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile<Content.Tiles.SoliquifierTile>()
					.Register();
				calamityMod.Find<ModItem>("LivingHolyFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile<Content.Tiles.SoliquifierTile>()
					.Register();
				calamityMod.Find<ModItem>("LivingGodSlayerFireBlock").CreateRecipe((int)(amount * 25))
					.AddIngredient<Content.Items.Gel.MaterialGel>()
					.AddTile<Content.Tiles.SoliquifierTile>()
					.Register();
			}
			recipe = Recipe.Create(ItemID.BoneTorch, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddIngredient(ItemID.Torch, (int)(amount * 25))
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Obsidian, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.HoneyBlock, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CrispyHoneyBlock, (int)(amount * 10))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.WetBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LavaBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.HoneyBomb, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Wood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PalmWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PalmWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.BorealWood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Pearlwood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.Shadewood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Ebonwood, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.RichMahogany, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.HerbBag, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Mushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.GlowingMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.VileMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.ViciousMushroom, (int)(amount * 15))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.VineRope, (int)(amount * 50))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Vine, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.JungleSpores, (int)(amount * 6))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.JungleRose, (int)(amount * 2))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.GrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CorruptSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CrimsonSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.HallowedSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.JungleGrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.MushroomGrassSeeds, (int)(amount * 20))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.DirtBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.StoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.EbonstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CrimstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PearlstoneBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.MudBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.ClayBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.EbonsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CrimsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PearlsandBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.Marble, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Granite, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.AshBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SiltBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.DesertFossil, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SnowBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.IceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PurpleIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.RedIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PinkIceBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.ThinIce, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SlushBlock, (int)(amount * 25))
				.AddIngredient<Content.Items.Gel.MaterialGel>()
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
		}

	}
	public class MineralRecipes : ModSystem
    {
		public override void AddRecipes()
		{
			var amount = 1.0;
			var BarMult = 2;
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			if ((calamityMod != null))
			{
				calamityMod.Find<ModItem>("CryonicOre").CreateRecipe((int)(5 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat Cryogen"), r => ((bool)calamityMod.Call("GetBossDowned", "cryogen") || (bool)calamityMod.Call("GetBossDowned", "ravager")))
					.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => (NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3)) || (bool)calamityMod.Call("GetBossDowned", "ravager"))
					.AddCondition(Recipe.Condition.InSnow)
					.Register();

				calamityMod.Find<ModItem>("PerennialOre").CreateRecipe((int)(5 * BarMult * amount))
				   .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				   .AddTile(TileID.Solidifier)
				   .AddCondition(NetworkText.FromKey("Defeat Plantera"), r => (NPC.downedPlantBoss || (bool)calamityMod.Call("GetBossDowned", "ravager")))
				   .AddCondition(Recipe.Condition.InRockLayerHeight)
				   .Register();

				calamityMod.Find<ModItem>("ScoriaOre").CreateRecipe((int)(5 * BarMult * amount))
				   .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				   .AddTile(TileID.Solidifier)
				   .AddCondition(NetworkText.FromKey("Defeat Golem"), r => (NPC.downedGolemBoss || (bool)calamityMod.Call("GetBossDowned", "ravager")))
				   .AddCondition(NetworkText.FromKey("In the Abyss"), r => (bool)calamityMod.Call("GetInZone", "abyss"))
				   .Register();
				calamityMod.Find<ModItem>("AuricOre").CreateRecipe((int)(12 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat Yharon"), r => ((bool)calamityMod.Call("GetBossDowned", "yharon")))
					.AddCondition(Recipe.Condition.InRockLayerHeight)
					.Register();
				calamityMod.Find<ModItem>("AstralOre").CreateRecipe((int)(2 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddCondition(NetworkText.FromKey("Defeat Astrum Deus"), r => (bool)calamityMod.Call("GetBossDowned", "astrumdeus"))
					.AddCondition(NetworkText.FromKey("In the Astral Infection"), r => (bool)calamityMod.Call("GetInZone", "astral"))
					.AddTile(TileID.Solidifier)
					.Register();
				calamityMod.Find<ModItem>("ExodiumCluster").CreateRecipe((int)(5 * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
					.AddCondition(Recipe.Condition.InSkyHeight)
					.Register();
				calamityMod.Find<ModItem>("PrismShard").CreateRecipe((int)(10 * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat the Desert Scourge"), r => (bool)calamityMod.Call("GetBossDowned", "desertscourge"))
					.AddCondition(NetworkText.FromKey("In the Sunken Sea"), r => (bool)calamityMod.Call("GetInZone", "sunkensea"))
					.Register();
				calamityMod.Find<ModItem>("CharredOre").CreateRecipe((int)(4 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
					.AddCondition(NetworkText.FromKey("In the Brimstone Crags"), r => (bool)calamityMod.Call("GetInZone", "crags"))
					.Register();
				calamityMod.Find<ModItem>("UelibloomOre").CreateRecipe((int)(5 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile(TileID.Solidifier)
					.AddCondition(NetworkText.FromKey("Defeat Providence"), r => (bool)calamityMod.Call("GetBossDowned", "providence"))
					.AddCondition(Recipe.Condition.InJungle)
					.Register();
			}
			Recipe recipe = Recipe.Create(ItemID.LunarOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
				.AddCondition(Recipe.Condition.InSkyHeight)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentSolar, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat the Solar Pillar"), r => NPC.downedTowerSolar)
				.AddCondition(Recipe.Condition.InSkyHeight)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentStardust, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat the Stardust Pillar"), r => NPC.downedTowerStardust)
				.AddCondition(Recipe.Condition.InSkyHeight)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentNebula, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat the Nebula Pillar"), r => NPC.downedTowerNebula)
				.AddCondition(Recipe.Condition.InSkyHeight)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentVortex, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat the Vortex Pillar"), r => NPC.downedTowerVortex)
				.AddCondition(Recipe.Condition.InSkyHeight)
				.Register();
			recipe = Recipe.Create(ItemID.Meteorite, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InMeteor)
				.Register();
			recipe = Recipe.Create(ItemID.FallenStar, (int)(4 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.TimeNight)
				.Register();
			recipe = Recipe.Create(ItemID.CrystalShard, (int)(25 * amount))
			.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
			.AddTile(TileID.Solidifier)
			.AddCondition(Recipe.Condition.InHallow)
			.Register();
			recipe = Recipe.Create(ItemID.Amethyst, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Topaz, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Sapphire, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Emerald, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Ruby, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Diamond, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.Amber, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InGemCave)
				.Register();
			recipe = Recipe.Create(ItemID.CopperOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.TinOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.IronOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.LeadOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.SilverOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.TungstenOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.GoldOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.PlatinumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.DemoniteOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeated Eye of Cthulhu, Eater of Worlds, or Brain of Cthulhu"), r => (NPC.downedBoss1 || NPC.downedBoss2) || Main.hardMode)
				.AddCondition(Recipe.Condition.InCorrupt)
				.Register();
			recipe = Recipe.Create(ItemID.CrimtaneOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeated Eye of Cthulhu, Eater of Worlds, or Brain of Cthulhu"), r => (NPC.downedBoss1 || NPC.downedBoss2) || Main.hardMode)
				.AddCondition(Recipe.Condition.InCrimson)
				.Register();
			recipe = Recipe.Create(ItemID.Hellstone, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat Eater of Worlds or Brain of Cthulhu"), r => NPC.downedBoss2 || Main.hardMode)
				.AddCondition(Recipe.Condition.InUnderworldHeight)
				.Register();
			recipe = Recipe.Create(ItemID.CobaltOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.PalladiumOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.MythrilOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.Register();
			recipe = Recipe.Create(ItemID.OrichalcumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.AdamantiteOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.TitaniumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddCondition(Recipe.Condition.InRockLayerHeight)
				.AddTile(TileID.Solidifier)
				.Register();
			recipe = Recipe.Create(ItemID.ChlorophyteOre, (int)(5 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat all three Mechanical Bosses"), r => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				.AddCondition(Recipe.Condition.InJungle)
				.AddTile(TileID.Solidifier)
				.Register();
			/*soliquifier*/
			amount = 0.5;
			BarMult = 2;
			if ((calamityMod != null))
			{
				calamityMod.Find<ModItem>("CryonicOre").CreateRecipe((int)(5 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile<Content.Tiles.SoliquifierTile>()
					.AddCondition(NetworkText.FromKey("Defeat Cryogen"), r => ((bool)calamityMod.Call("GetBossDowned", "cryogen") || (bool)calamityMod.Call("GetBossDowned", "ravager")))
					.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => (NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3)) || (bool)calamityMod.Call("GetBossDowned", "ravager"))
					.Register();

				calamityMod.Find<ModItem>("PerennialOre").CreateRecipe((int)(5 * BarMult * amount))
				   .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				   .AddTile<Content.Tiles.SoliquifierTile>()
				   .AddCondition(NetworkText.FromKey("Defeat Plantera"), r => (NPC.downedPlantBoss || (bool)calamityMod.Call("GetBossDowned", "ravager")))
				   .Register();

				calamityMod.Find<ModItem>("ScoriaOre").CreateRecipe((int)(5 * BarMult * amount))
				   .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				   .AddTile<Content.Tiles.SoliquifierTile>()
				   .AddCondition(NetworkText.FromKey("Defeat Golem"), r => (NPC.downedGolemBoss || (bool)calamityMod.Call("GetBossDowned", "ravager")))
				   .Register();
				calamityMod.Find<ModItem>("AuricOre").CreateRecipe((int)(12 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Yharon"), r => ((bool)calamityMod.Call("GetBossDowned", "yharon")))
				.Register();
				calamityMod.Find<ModItem>("AstralOre").CreateRecipe((int)(2 * BarMult * amount))
			    .AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat Astrum Deus"), r => (bool)calamityMod.Call("GetBossDowned", "astrumdeus"))
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
				calamityMod.Find<ModItem>("ExodiumCluster").CreateRecipe((int)(5 * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile<Content.Tiles.SoliquifierTile>()
					.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
					.Register();
				calamityMod.Find<ModItem>("PrismShard").CreateRecipe((int)(10 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Desert Scourge"), r => (bool)calamityMod.Call("GetBossDowned", "desertscourge"))
				.Register();
				calamityMod.Find<ModItem>("CharredOre").CreateRecipe((int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.Register();
				calamityMod.Find<ModItem>("UelibloomOre").CreateRecipe((int)(5 * BarMult * amount))
					.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
					.AddTile<Content.Tiles.SoliquifierTile>()
					.AddCondition(NetworkText.FromKey("Defeat Providence"), r => (bool)calamityMod.Call("GetBossDowned", "providence"))
					.Register();
			}
			recipe = Recipe.Create(ItemID.LunarOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Moon Lord"), r => NPC.downedMoonlord)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentSolar, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Solar Pillar"), r => NPC.downedTowerSolar)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentStardust, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Stardust Pillar"), r => NPC.downedTowerStardust)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentNebula, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Nebula Pillar"), r => NPC.downedTowerNebula)
				.Register();
			recipe = Recipe.Create(ItemID.FragmentVortex, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat the Vortex Pillar"), r => NPC.downedTowerVortex)
				.Register();
			recipe = Recipe.Create(ItemID.Meteorite, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.FallenStar, (int)(4 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CrystalShard, (int)(25 * amount))
			.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
			.AddTile<Content.Tiles.SoliquifierTile>()
			.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
			.Register();
			recipe = Recipe.Create(ItemID.Amethyst, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Topaz, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Sapphire, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Emerald, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Ruby, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Diamond, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.Amber, (int)(5 * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.CopperOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.TinOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.IronOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.LeadOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.SilverOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.TungstenOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.GoldOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.PlatinumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.DemoniteOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeated Eye of Cthulhu, Eater of Worlds, or Brain of Cthulhu"), r => (NPC.downedBoss1 || NPC.downedBoss2) || Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.CrimtaneOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeated Eye of Cthulhu, Eater of Worlds, or Brain of Cthulhu"), r => (NPC.downedBoss1 || NPC.downedBoss2) || Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.Hellstone, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat Eater of Worlds or Brain of Cthulhu"), r => NPC.downedBoss2 || Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.CobaltOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.PalladiumOre, (int)(3 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("In Hardmode"), r => Main.hardMode)
				.Register();
			recipe = Recipe.Create(ItemID.MythrilOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddTile<Content.Tiles.SoliquifierTile>()
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.Register();
			recipe = Recipe.Create(ItemID.OrichalcumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat any Mechanical Boss"), r => NPC.downedMechBossAny)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.AdamantiteOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.TitaniumOre, (int)(4 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat two Mechanical Bosses"), r => NPC.downedMechBoss1 ? (NPC.downedMechBoss2 || NPC.downedMechBoss3) : (NPC.downedMechBoss2 && NPC.downedMechBoss3))
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
			recipe = Recipe.Create(ItemID.ChlorophyteOre, (int)(5 * BarMult * amount))
				.AddIngredient(ModContent.ItemType<Content.Items.Gel.MineralGel>())
				.AddCondition(NetworkText.FromKey("Defeat all three Mechanical Bosses"), r => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				.AddTile<Content.Tiles.SoliquifierTile>()
				.Register();
		}
	}
	public class FishRecipes : ModSystem
    {
		public override void AddRecipes()
        {
			Recipe.Create(ItemID.AmanitaFungifin)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Amanita Fungifin"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.AmanitaFungifin))
				.AddCondition(Recipe.Condition.InGlowshroom)
				.Register();
			Recipe.Create(ItemID.Angelfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Angelfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Angelfish))
				.Register();
			Recipe.Create(ItemID.Batfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Batfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Batfish))
				.Register();
			Recipe.Create(ItemID.BloodyManowar)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Bloody Manowar"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.BloodyManowar))
				.Register();
			Recipe.Create(ItemID.Bonefish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Bonefish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Bonefish))
				.Register();
			Recipe.Create(ItemID.BumblebeeTuna)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Bumblebee Tuna"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.BumblebeeTuna))
				.Register();
			Recipe.Create(ItemID.Bunnyfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Bunnyfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Bunnyfish))
				.Register();
			Recipe.Create(ItemID.CapnTunabeard)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Cap'n Tunabeard"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.CapnTunabeard))
				.Register();
			Recipe.Create(ItemID.Catfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Catfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Catfish))
				.Register();
			Recipe.Create(ItemID.Cloudfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Cloudfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Cloudfish))
				.Register();
			Recipe.Create(ItemID.Clownfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Clownfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Clownfish))
				.Register();
			Recipe.Create(ItemID.Cursedfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Cursedfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Cursedfish))
				.Register();
			Recipe.Create(ItemID.DemonicHellfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Demonic Hellfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.DemonicHellfish))
				.Register();
			Recipe.Create(ItemID.Derpfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Derpfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Derpfish))
				.Register();
			Recipe.Create(ItemID.Dirtfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Dirtfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Dirtfish))
				.Register();
			Recipe.Create(ItemID.DynamiteFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Dynamite Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.DynamiteFish))
				.Register();
			Recipe.Create(ItemID.EaterofPlankton)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Eater of Plankton"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.EaterofPlankton))
				.Register();
			Recipe.Create(ItemID.FallenStarfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Fallen Starfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.FallenStarfish))
				.Register();
			Recipe.Create(ItemID.TheFishofCthulu)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: The Fish of Cthulhu"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.TheFishofCthulu))
				.Register();
			Recipe.Create(ItemID.Fishotron)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Fishotron"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Fishotron))
				.Register();
			Recipe.Create(ItemID.Fishron)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Fishron"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Fishron))
				.Register();
			Recipe.Create(ItemID.GuideVoodooFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Guide Voodoo Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.GuideVoodooFish))
				.Register();
			Recipe.Create(ItemID.Wyverntail)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Wyverntail"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Wyverntail))
				.Register();
			Recipe.Create(ItemID.Harpyfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Harpyfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Harpyfish))
				.Register();
			Recipe.Create(ItemID.Hungerfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Hungerfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Hungerfish))
				.Register();
			Recipe.Create(ItemID.Ichorfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Ichorfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Ichorfish))
				.Register();
			Recipe.Create(ItemID.InfectedScabbardfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Infected Scabbardfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.InfectedScabbardfish))
				.Register();
			Recipe.Create(ItemID.Jewelfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Jewelfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Jewelfish))
				.Register();
			Recipe.Create(ItemID.MirageFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Mirage Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.MirageFish))
				.Register();
			Recipe.Create(ItemID.Mudfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Mudfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Mudfish))
				.Register();
			Recipe.Create(ItemID.MutantFlinxfin)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Mutant Flinxfin"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.MutantFlinxfin))
				.Register();
			Recipe.Create(ItemID.Pengfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Pengfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Pengfish))
				.Register();
			Recipe.Create(ItemID.Pixiefish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Pixiefish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Pixiefish))
				.Register();
			Recipe.Create(ItemID.ScarabFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Scarab Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.ScarabFish))
				.Register();
			Recipe.Create(ItemID.ScorpioFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Scorpio Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.ScorpioFish))
				.Register();
			Recipe.Create(ItemID.Slimefish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Slimefish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Slimefish))
				.Register();
			Recipe.Create(ItemID.Spiderfish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Spiderfish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.Spiderfish))
				.Register();
			Recipe.Create(ItemID.TropicalBarracuda)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Tropical Barracuda"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.TropicalBarracuda))
				.Register();
			Recipe.Create(ItemID.TundraTrout)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Tundra Trout"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.TundraTrout))
				.Register();
			Recipe.Create(ItemID.UnicornFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Unicorn Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.UnicornFish))
				.Register();
			Recipe.Create(ItemID.ZombieFish)
				.AddIngredient<Content.Items.Gel.TyrannyGel>()
				.AddTile(TileID.Solidifier)
				.AddCondition(NetworkText.FromKey("Daily Angler Quest: Zombie Fish"), r => (Main.anglerQuestItemNetIDs[Main.anglerQuest] == ItemID.ZombieFish))
				.Register();

		}
    }
}