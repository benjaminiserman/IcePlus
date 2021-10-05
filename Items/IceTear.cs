using Terraria.ModLoader;
using Terraria.ID;

namespace IcePlus.Items
{
	public class IceTear : ModItem
	{
        Mod thoriumMod = ModLoader.GetMod("ThoriumMod");

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

        public override void AddRecipes()
        {
            if (thoriumMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(thoriumMod.ItemType("IcyShard"), 5);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}