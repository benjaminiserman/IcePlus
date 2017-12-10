using Terraria.ModLoader;

namespace IcePlus.Items
{
	public class IceSpike : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Spike");
		}
		public override void SetDefaults()
		{
			item.value = 30;
			item.maxStack = 99;
			item.rare = 0;
		}
		
	}
}