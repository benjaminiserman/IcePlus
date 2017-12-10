using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcePlus.Items.Weapons
{
    public class Glacier : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 10;
            item.value = 8000;
            item.rare = 2;

            item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 44; // Determines how long the animation lasts. 
            item.useTime = 44; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 7;
            item.damage = 20;
            item.scale = 1.1F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("GlacierBall");
            item.shootSpeed = 13.25f;
			item.UseSound = SoundID.Item1;
            item.melee = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }

        // Just a recipe with one dirt (for debugging purposes).
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceSpike", 20);
			recipe.AddIngredient(null, "IceTear", 3);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}