using System;
using CalamityMod;
using CalamityMod.UI;
using Terraria;
using Terraria.ModLoader;
using CalamityFR.DraedonLogs;
using CalamityMod.Items.DraedonMisc;

namespace CalamityFR.DraedonLogs
{
	public class DraedonPlanetoidLogTranslated : ModItem
	{
		public override string Texture => "CalamityMod/Items/DraedonMisc/DraedonsLogPlanetoid";

		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Journal de Draedon - l'Espace (Traduit)");
			base.Tooltip.SetDefault("Cliquez pour voir son contenu");
		}

		public override void SetDefaults()
		{
			base.item.width = 28;
			base.item.height = 28;
			base.item.rare = 10;
			base.item.Calamity().customRarity = CalamityRarity.DraedonRust;
			base.item.useAnimation = (base.item.useTime = 20);
			base.item.useStyle = 4;
		}

		public override bool UseItem(Player player)
		{
			if (Main.myPlayer == player.whoAmI)
			{
				PopupGUIManager.FlipActivityOfGUIWithType(typeof(PlanetoidGUI));
			}
			return true;
		}

		public override void AddRecipes()
        {
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(ModContent.ItemType<DraedonsLogPlanetoid>());
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();

			ModRecipe reverseModRecipe = new ModRecipe(base.mod);
			reverseModRecipe.AddIngredient(ModContent.ItemType<DraedonPlanetoidLogTranslated>());
			reverseModRecipe.SetResult(ModContent.ItemType<DraedonsLogPlanetoid>());
			reverseModRecipe.AddRecipe();

		}
	}
}