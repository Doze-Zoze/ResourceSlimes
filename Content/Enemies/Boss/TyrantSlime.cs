using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Bestiary;

namespace ResourceSlimes.Content.Enemies.Boss
{
    [AutoloadBossHead]
    public class TyrantSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tyrant Slime");
            Main.npcFrameCount[Type] = 2;
        }

        public override void SetDefaults()
        {
            var lifeMin = 1000f;
            var lifeMax = 20000f;
            var life = lifeMin;
            var dmgMin = 30f;
            var dmgMax = 600f;
            var dmg = dmgMin;
            var defMin = 10f;
            var defMax = 100f;
            var def = defMin;
            var valueMin = 10000f;
            var valueMax = 25000f;
            var value = valueMin;
            var height = 16f;
            var width = 24f;
            var bossCount = 18;


            if (NPC.downedBoss1) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedBoss2) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedBoss3) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedDeerclops) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedQueenBee) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (Main.hardMode) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedSlimeKing) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedPlantBoss) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedGolemBoss) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedMartians) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedFishron) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedEmpressOfLight) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedAncientCultist) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedMoonlord) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedQueenSlime) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedMechBoss1) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedMechBoss2) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            } if (NPC.downedMechBoss3) {
                life += ((lifeMax-lifeMin)/bossCount);
                dmg += ((dmgMax-dmgMin)/bossCount);
                def += ((defMax-defMin)/bossCount);
                value += ((valueMax-valueMin)/bossCount);
            }
            NPC.width = (int)(width);
            NPC.height = (int)(height);
            NPC.damage = (int)dmg;
            NPC.defense = (int)def;
            NPC.lifeMax = (int)life;
            NPC.value = (int)value;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.boss = true;
            NPC.knockBackResist = 0f;
            NPC.scale = 4;
            NPC.npcSlots = 2f;
            AIType = NPCID.KingSlime;
            AnimationType = NPCID.BlueSlime;
        }


        public override void ModifyNPCLoot(NPCLoot npcLoot) {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.Gel.TyrannyGel>(),1,25,50));
            if (NPC.downedBoss2) {
                if (WorldGen.crimson) {
                    npcLoot.Add(ItemDropRule.Common(ItemID.TissueSample, 1, 10, 25));
                } else {
                npcLoot.Add(ItemDropRule.Common(ItemID.ShadowScale, 1, 10, 25));
            }
            } if (NPC.downedQueenBee) {
                npcLoot.Add(ItemDropRule.Common(ItemID.BeeWax, 1, 10, 25));
            } if (NPC.downedSlimeKing) {
                npcLoot.Add(ItemDropRule.Common(ItemID.Gel,1,25, 75));
            } if (NPC.downedGolemBoss) {
                npcLoot.Add(ItemDropRule.Common(ItemID.BeetleHusk,1,10, 25));
            } if (NPC.downedQueenSlime) {
                npcLoot.Add(ItemDropRule.Common(ItemID.SoulofLight,1,10, 25));
                npcLoot.Add(ItemDropRule.Common(ItemID.SoulofNight,1,10, 25));
            } if (NPC.downedMechBoss1) {
                npcLoot.Add(ItemDropRule.Common(ItemID.SoulofMight,1,10, 25));
            } if (NPC.downedMechBoss2) {
                npcLoot.Add(ItemDropRule.Common(ItemID.SoulofSight,1,10, 25));
            } if (NPC.downedMechBoss3) {
                npcLoot.Add(ItemDropRule.Common(ItemID.SoulofFright,1,10, 25));
            } if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3) {
                 npcLoot.Add(ItemDropRule.Common(ItemID.HallowedBar,1,10, 25));
            }

        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {

				// Sets the description of this NPC that is listed in the bestiary.
				new FlavorTextBestiaryInfoElement("This slime grows more powerful as you progress."),
            });
        }

    }
}