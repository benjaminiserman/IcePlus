using Terraria.ModLoader;

namespace IcePlus.Items
{
	public class IceTear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Tear");
		}
		public override void SetDefaults()
		{
			item.value = 200;
			item.maxStack = 99;
			item.rare = 0;
		}
	}
}