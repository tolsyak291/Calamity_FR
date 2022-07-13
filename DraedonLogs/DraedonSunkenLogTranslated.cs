using System;
using CalamityMod;
using CalamityMod.UI;
using Terraria;
using Terraria.ModLoader;
using CalamityFR.DraedonLogs;
using CalamityMod.Items.DraedonMisc;

namespace CalamityFR.DraedonLogs
{
	public class DraedonSunkenLogTranslated : ModItem
	{
		public override string Texture => "CalamityMod/Items/DraedonMisc/DraedonsLogSunkenSea";

		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Journal de Draedon - Étude sur la Vie Aquatique Souterraine (Traduit)");
			base.Tooltip.SetDefault("Cliquez pour voir son contenu");
		}

		public override void SetDefaults()
		{
			base.Item.width = 28;
			base.Item.height = 28;
			base.Item.rare = 10;
			base.Item.Calamity().customRarity = CalamityRarity.DraedonRust;
			base.Item.useAnimation = (base.Item.useTime = 20);
			base.Item.useStyle = 4;
		}

		public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
		{
			if (Main.myPlayer == player.whoAmI)
			{
				PopupGUIManager.FlipActivityOfGUIWithType(typeof(SunkenGUI));
			}
			return true;
		}

		public override void AddRecipes()
        {
			Recipe modRecipe = Recipe.Create(this.Type);
			modRecipe.AddIngredient(ModContent.ItemType<DraedonsLogSunkenSea>());
			modRecipe.Register();

			Recipe reverseModRecipe = Recipe.Create(ModContent.ItemType<DraedonsLogSunkenSea>());
			reverseModRecipe.AddIngredient(ModContent.ItemType<DraedonSunkenLogTranslated>());
			reverseModRecipe.Register();

		}
	}
}