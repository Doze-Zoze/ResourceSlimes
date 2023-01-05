using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Bestiary;
using System.Collections.Generic;

namespace ResourceSlimes.Content
{
    public class SlimeSpawnNPC : GlobalNPC
    {
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {

            if (spawnInfo.Player.HasBuff<Buffs.MineralCandle>() || (spawnInfo.Player.HasBuff<Buffs.MaterialCandle>()))
            {
               pool.Clear();
                if (spawnInfo.Player.HasBuff<Buffs.MineralCandle>())
                {
                    pool.Add(ModContent.NPCType<Content.Enemies.MineralSlime.OreSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MineralSlime.MythicalOreSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MineralSlime.AlloySlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MineralSlime.AuricSlime>(), 1f);
                }
                if (spawnInfo.Player.HasBuff<Buffs.MaterialCandle>())
                {
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.CrystalSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.NettleSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TerracottaSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TundraSlime>(), 1f);
                }
                if (spawnInfo.Player.HasBuff<Buffs.SlimeCandle>()) 
                {
                    pool.Add(ModContent.NPCType<Content.Enemies.MerchantSlime>(), 2f);
                }
            }
            else
            {
                if (spawnInfo.Player.HasBuff<Buffs.SlimeCandle>())
                {
                    pool.Clear();
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.CrystalSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.NettleSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TerracottaSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TundraSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.CrystalSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.NettleSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TerracottaSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MaterialSlime.TundraSlime>(), 1f);
                    pool.Add(ModContent.NPCType<Content.Enemies.MerchantSlime>(), 2f);
                }
            }
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.HasBuff<Buffs.MaterialCandle>() || player.HasBuff<Buffs.MineralCandle>())
            {
                spawnRate = (int)(spawnRate / 4);
                maxSpawns = (int)(maxSpawns * 1.5);
            }
             if (player.HasBuff<Buffs.TyrantCandle>())
            {
                spawnRate = (int)(spawnRate / 20);
                maxSpawns = (int)(maxSpawns * 2);
            }

        }
    }
}
