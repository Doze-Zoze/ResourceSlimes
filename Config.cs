using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace ResourceSlimes
{
	public class ResouceSlimesServerConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Soliquifier Gel Conversion Rate")]
        [Tooltip("Changes the amount of resources gained from soliquifier crafting, based on amount of bars you'd get from the ore")]
		[DefaultValue(2)]
        [Range(1,10)]
		public static int SoliquifierOreRate;
        
        [Label("Extractinator Gel Conversion Rate")]
        [Tooltip("Changes the amount of resources gained from extracinating gels, based on amount of bars you'd get from the ore")]
		[DefaultValue(2)]
        [Range(1,10)]
		public static int ExtractinatorOreRate;

        [Label("Slime Spawn Rate")]
        [Tooltip("Changes the spawn rate of resource slimes")]
		[DefaultValue(1)]
        [Range(0,10)]
		public static int SlimeSpawnRate;
}}