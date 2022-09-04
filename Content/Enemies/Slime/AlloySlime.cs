using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Bestiary;

namespace ResourceSlimes.Content.Enemies.Slime
{
    public class AlloySlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alloy Slime");
            Main.npcFrameCount[Type] = 2;
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 15;
            NPC.damage = 15;
            NPC.defense = 10;
            NPC.lifeMax = 50;
            NPC.value = 500f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = Item.NPCtoBanner(NPCID.RainbowSlime);
            BannerItem = Item.BannerToItem(Banner);
            NPC.knockBackResist = 0f;
            NPC.scale = 1f;
            NPC.npcSlots = 0.5f;
            AIType = NPCID.SandSlime;
            AnimationType = NPCID.QueenSlimeMinionBlue;
        }


        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if ((calamityMod != null))
            {
                if ((bool)calamityMod.Call("GetBossDowned", "cryogen") || (bool)calamityMod.Call("GetBossDowned", "ravager") || NPC.downedGolemBoss || NPC.downedPlantBoss)
                {
                    if (spawnInfo.Player.ZoneRockLayerHeight)
                    {
                        return 0.05f;
                    }
                    else
                    {
                        return 0f;
                    }
                }
                else { return 0f; }
            }
            else return 0f;
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot) {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Items.Gel.AlloyGel>()));
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				// Sets the spawning conditions of this NPC that is listed in the bestiary.
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				// Sets the description of this NPC that is listed in the bestiary.
				new FlavorTextBestiaryInfoElement("This slime is empregnated with crystals and magic ores!."),
            });
        }

    }
}