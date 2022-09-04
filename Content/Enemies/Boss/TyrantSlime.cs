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
            var lifeMax = 2000f;
            var scale = 4f;
            var damage = 40f;
            var defense = 10f;
            var value = 10000f;
            var height = 16f;
            var width = 24f;

            var lifeMultiplier = 1.20f;
            var scaleMultiplier = 1.1f;
            var damageMultiplier = 1.15f;
            var defenseMultiplier = 1.125f;
            var valueMultiplier = 1.1f;

            if (NPC.downedBoss1) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedBoss2) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedBoss3) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedDeerclops) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedQueenBee) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (Main.hardMode) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedSlimeKing) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedPlantBoss) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedGolemBoss) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedMartians) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedFishron) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedEmpressOfLight) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedAncientCultist) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedMoonlord) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedQueenSlime) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedMechBoss1) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedMechBoss2) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            } if (NPC.downedMechBoss3) {
                lifeMax = lifeMax * lifeMultiplier;
                scale = scale * scaleMultiplier;
                defense = defense * defenseMultiplier;
                value = value * valueMultiplier;
            }
            NPC.width = (int)(width);
            NPC.height = (int)(height);
            NPC.damage = (int)damage;
            NPC.defense = (int)defense;
            NPC.lifeMax = (int)lifeMax;
            NPC.value = (int)value;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.boss = true;
            NPC.knockBackResist = 0f;
            NPC.scale = scale;
            NPC.npcSlots = 0.5f;
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