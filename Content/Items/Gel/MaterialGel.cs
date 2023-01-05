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
	public class MaterialGel : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Highly condensed matter, somehow made gelatinous\nCan be converted into various materials at a Solidifier or Soliquifier, depending on your surroundings");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 30;
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 20;

			Item.maxStack = 999;
			Item.value = Item.sellPrice(copper: 1); 
		}
	}
}