using Terraria.ModLoader;

namespace IcePlus.Items
{
	public class SnowyFur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snowy Fur");
			Tooltip.SetDefault("'Warm and fluffy.'");
		}
		public override void SetDefaults()
		{
			item.value = 60;
			item.maxStack = 99;
			item.rare = 0;
		}		
	}
}