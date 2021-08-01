using System;
using Terraria;
using CalamityMod;
using CalamityMod.Items;
using System.Collections.Generic;
using Terraria.ModLoader;

public class CalamityGlobalItem_FR : GlobalItem
{
	public CalamityGlobalItem_FR()
	{
	}

	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
		//Horrible code, will change later but will do for now
		foreach (TooltipLine line in tooltips)
		{
			if (item.melee)
			{
				line.text = line.text.Replace("true melee damage", "dégâts de vraie mêlée");
			}

			//line.text = line.text.Replace("rogue damage", "dégâts de voleur");
			

			if (item.type >= 3930 && (item.Calamity()?.UsesCharge ?? false))
			{
				line.text = line.text.Replace("Current Charge:", "Batterie Restante:");
			}
			if (item.Calamity().rogue)
			{
				line.text = line.text.Replace("rogue lancer", "dégâts de voleur");
				line.text = line.text.Replace("stealth strike damage", "dégâts d'attaque furtive");

				if (item.prefix > 0 && line.Name == "ItemName") {
					line.text = line.text.Contains("Flawless") ? line.text.Replace("Flawless", "").Trim() + " (Parfait)" : line.text;
					line.text = line.text.Contains("Pointy") ? line.text.Replace("Pointy", "").Trim() + " (Pointu)" : line.text;
					line.text = line.text.Contains("Sharp") ? line.text.Replace("Sharp", "").Trim() + " (Tranchant)" : line.text;
					line.text = line.text.Contains("Feathered") ? line.text.Replace("Feathered", "").Trim() + " (À plumes)" : line.text;
					line.text = line.text.Contains("Sleek") ? line.text.Replace("Sleek", "").Trim() + " (Lisse)" : line.text;
					line.text = line.text.Contains("Hefty") ? line.text.Replace("Hefty", "").Trim() + " (Lourd)" : line.text;
					line.text = line.text.Contains("Mighty") ? line.text.Replace("Mighty", "").Trim() + " (Puissant)" : line.text;
					line.text = line.text.Contains("Glorious") ? line.text.Replace("Glorious", "").Trim() + " (Glorieux)" : line.text;
					line.text = line.text.Contains("Serrated") ? line.text.Replace("Serrated", "").Trim() + " (Denté)" : line.text;
					line.text = line.text.Contains("Vicious") ? line.text.Replace("Vicious", "").Trim() + " (Vicieux)" : line.text;
					line.text = line.text.Contains("Lethal") ? line.text.Replace("Lethal", "").Trim() + " (Fatal)" : line.text;
					line.text = line.text.Contains("Radical") ? line.text.Replace("Radical", "").Trim() + " (Radical)" : line.text;
					line.text = line.text.Contains("Blunt") ? line.text.Replace("Blunt", "").Trim() + " (Emoussé)" : line.text;
					line.text = line.text.Contains("Flimsy") ? line.text.Replace("Flimsy", "").Trim() + " (Fragile)" : line.text;
					line.text = line.text.Contains("Unbalanced") ? line.text.Replace("Unbalanced", "").Trim() + " (Déséquilibré)" : line.text;
					line.text = line.text.Contains("Atrocious") ? line.text.Replace("Atrocious", "").Trim() + " (Atroce)" : line.text;
				}
			}
			if (item.accessory && !item.social && item.prefix > 0)
			{
				line.text = line.text.Contains("Quiet") ? line.text.Replace("Quiet", "").Trim() + " (Discret)" : line.text;
				line.text = line.text.Contains("Cloaked") ? line.text.Replace("Cloaked", "").Trim() + " (Voilé)" : line.text;
				line.text = line.text.Contains("Camouflaged") ? line.text.Replace("Camouflaged", "").Trim() + " (Camouflé)" : line.text;
				line.text = line.text.Contains("Silent") ? line.text.Replace("Silent", "").Trim() + " (Silencieux)" : line.text;
				line.text = line.text.Replace("damage reduction", "réduction des dégâts");
				line.text = line.text.Replace("critical strike chance", "chances de coup critique");
				line.text = line.text.Replace("defense", "défense");
				line.text = line.text.Replace("stealth generation", "génération de furtivité");
				
			}
		}
	}
}
