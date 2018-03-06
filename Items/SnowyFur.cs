using Terraria.ModLoader;
using Terraria.ID;
using IcePlus;

namespace IcePlus.Items
{
	public class SnowyFur : ModItem
	{
        Mod thoriumMod = ModLoader.GetMod("ThoriumMod");

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

        public override void AddRecipes()
        {
            if (thoriumMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(thoriumMod.ItemType("IcyShard"), 3);
                recipe.AddIngredient(thoriumMod.ItemType("DangerShard"), 2);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}