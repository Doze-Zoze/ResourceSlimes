using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Bestiary;
using System.Collections.Generic;

namespace ResourceSlimes.Content.NPCs
{
    public class SlimeSpawnNPC : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.HasBuff(BuffID.PeaceCandle))
            {
                pool.Add(ModContent.NPCType<Content.Enemies.Boss.TyrantSlime>(), 5f);
            }
            if (spawnInfo.Player.HasBuff<Buffs.MineralCandle>() || (spawnInfo.Player.HasBuff<Buffs.MaterialCandle>()))
            {
               pool.Clear();
                if (spawnInfo.Player.HasBuff<Buffs.MineralCandle>())
                {
                    pool.Add(ModContent.NPCType<Content.Enemies.Slime.OreSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.Slime.CosmicSlime>(), 1f);
                    if (Main.hardMode)
                    {
                        pool.Add(ModContent.NPCType<Content.Enemies.Slime.MythicalOreSlime>(), 1f);
                    }
                    if (NPC.downedBoss2)
                    {
                        pool.Add(ModContent.NPCType<Content.Enemies.Slime.HellfireSlime>(), 1f);
                    }
                    Mod calamityMod = ModLoader.GetMod("CalamityMod");
                    if ((calamityMod != null))
                    {
                        if ((bool)calamityMod.Call("GetBossDowned", "cryogen") || (bool)calamityMod.Call("GetBossDowned", "ravager") || NPC.downedGolemBoss || NPC.downedPlantBoss)
                        {
                            pool.Add(ModContent.NPCType<Content.Enemies.Slime.AlloySlime>(), 1f);
                        }
                                if ((bool)calamityMod.Call("GetBossDowned", "yharon"))
                        {
                            pool.Add(ModContent.NPCType<Content.Enemies.Slime.AuricSlime>(), 1f);
                        }
                    }
                }
                if (spawnInfo.Player.HasBuff<Buffs.MaterialCandle>())
                {
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.ColorfulSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.CrystalSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.FlamingSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.LiquidSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.LivingWoodSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.MerchantSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.NettleSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.TerracottaSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.TundraSlime>(), 1f);
                }
            }
            else
            {
                if (spawnInfo.Player.HasBuff<Buffs.SlimeCandle>())
                {
                    pool.Clear();
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.ColorfulSlime>(), 3f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.CrystalSlime>(), 3f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.FlamingSlime>(), 2f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.LiquidSlime>(), 3f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.LivingWoodSlime>(), 5f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.MerchantSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.NettleSlime>(), 3f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.TerracottaSlime>(), 5f);
                    pool.Add(ModContent.NPCType<Content.Enemies.PeaceSlime.TundraSlime>(), 3f);
                    pool.Add(ModContent.NPCType<Content.Enemies.Slime.OreSlime>(), 5f);
                    if (Main.hardMode)
                    {
                        pool.Add(ModContent.NPCType<Content.Enemies.Slime.MythicalOreSlime>(), 5f);
                    }
                    Mod calamityMod = ModLoader.GetMod("CalamityMod");
                    if ((calamityMod != null))
                    {
                        if ((bool)calamityMod.Call("GetBossDowned", "yharon"))
                        {
                            pool.Add(ModContent.NPCType<Content.Enemies.Slime.AuricSlime>(), 0.5f);
                        }
                    }
                }
            }
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.HasBuff<Buffs.SlimeCandle>() || player.HasBuff<Buffs.MaterialCandle>() || player.HasBuff<Buffs.MineralCandle>())
            {
                spawnRate = (int)(spawnRate / 3);
                maxSpawns = (int)(maxSpawns * 1.5);
            }

        }
    }
}
