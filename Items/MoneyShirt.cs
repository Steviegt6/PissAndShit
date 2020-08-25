﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace PissAndShit.Items
{
    public class MoneyShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Money Shirt");
            Tooltip.SetDefault("Mmm yes shiny on shirt");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Pink;
            item.width = 18;
            item.height = 16;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.AddIngredient(ItemType<MoneyBar>(), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

