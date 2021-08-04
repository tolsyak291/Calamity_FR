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

				if (item.prefix > 0 && line.Name == "ItemName")
				{
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

			if (item.type == 1134)
			{
				line.text = line.text.Replace("Grants the Honey buff for 2 minutes", "Accorde l'amélioration de Miel pendant 2 minutes");
			}
			if (item.type == 1326)
			{
				line.text = line.text.Replace("Teleportation is disabled while Chaos State is active", "La téléportation est impossible que l'état Chaos est actif");
			}
			if (item.type == 3032 || item.type == 205)
			{
				line.text = line.text.Replace("Cannot be used in the Abyss", "Inutilisable dans les abysses");
			}
			if (item.type == 1183 || item.type == 3577)
			{
				line.text = line.text.Replace("Provides a large amount of light in the abyss", "Émet une grande quantité de lumière dans les abysses");
			}
			List<int> litlleLightInAbyss = new List<int>() { 3062, 115, 3043, 1861, 1303, 1860, 88 };
			List<int> moderateLightInAbyss = new List<int>() { 425, 3856, 298 };
			List<int> moderateBreathLossInAbyss = new List<int>() { 1861, 268 };
			List<int> greatBreathLossInAbyss = new List<int>() { 291, 497, 861, 3110 };
			if (litlleLightInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Provides a small amount of light in the abyss", "Émet une petite quantité de lumière dans les abysses");
			}
			if (moderateLightInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Provides a moderate amount of light in the abyss", "Émet une quantité modérée de lumière dans les abysses");
			}
			if (moderateBreathLossInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Moderately reduces breath loss in the abyss", "Réduit modérément la perte de respiration dans les abysses");
			}
			if (greatBreathLossInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Greatly reduces breath loss in the abyss", "Réduit grandement la perte de respiration dans les abysses");
			}
			if (item.type == 2359)
			{
				line.text = line.text.Replace("Makes you immune to the Chilled, Frozen, and Glacial State debuffs", "Immunité au refroidissement et au gel");
				line.text = line.text.Replace("Provides cold protection in Death Mode", "Protège du froid en mode Mort");
			}
			if (item.type == 1340)
			{
				line.text = line.text.Replace("Melee and rogue attacks inflict Venom on enemies", "Les attaques de mêlée et de voleur infligent le venin sur les ennemis");
			}
			if (item.type == 1353)
			{
				line.text = line.text.Replace("Melee and rogue attacks inflict enemies with cursed flames", "Les attaques de mêlée et de voleur infligent les flammes maudites sur les ennemis");
			}
			if (item.type == 1354)
			{
				line.text = line.text.Replace("Melee and rogue attacks set enemies on fire", "Les attaques de mêlée et de voleur enflamment les ennemis");
			}
			if (item.type == 1355)
			{
				line.text = line.text.Replace("Melee and rogue attacks make enemies drop more gold", "Les attaques de mêlée et de voleur font tomber plus d'argent aux ennemis");
			}
			if (item.type == 1356)
			{
				line.text = line.text.Replace("Melee and rogue attacks decrease enemy defense", "Les attaques de mêlée et de voleur réduisent la défense des ennemis");
			}
			if (item.type == 1357)
			{
				line.text = line.text.Replace("Melee and rogue attacks confuse enemies", "Les attaques de mêlée et de voleur rendent les ennemis confus");
			}
			if (item.type == 1358)
			{
				line.text = line.text.Replace("All attacks cause confetti to appear", "Toutes les attaques font apparaître des confettis");
			}
			if (item.type == 1359)
			{
				line.text = line.text.Replace("Melee and rogue attacks poison enemies", "Les attaques de mêlée et de voleur empoisonnent les ennemis");
			}
			if (item.type == 3224)
			{
				line.text = line.text.Replace("Reduces damage taken by 10%", "Réduit les dégâts subis de 10%");
			}
			if (item.type == 536 || item.type == 897 || item.type == 936)
			{
				line.text = line.text.Replace("10% increased true melee damage", "Augmente les dégâts de vraie mêlée de 10%");
			}
			if (item.type == 1343)
			{
				line.text = line.text.Replace("14% increased melee damage and speed", "+14% de dégâts et de vitesse de mêlée");
				line.text = line.text.Replace("10% increased true melee damage", "+10% de dégâts de vraie mêlée");
				line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
			if (item.type == 1503)
			{
				line.text = line.text.Replace("20% decreased magic damage", "-20% de dégâts magiques");
			}
			if (item.type == 288)
			{
				line.text = line.text.Replace("Provides immunity to direct damage from touching lava", "Immunité aux dégâts directs quand vous touchez la lave");
				line.text = line.text.Replace("Provides temporary immunity to lava burn damage", "Donne une immunité temporarire aux brûlures de lave");
				line.text = line.text.Replace("Greatly increases lava immunity time regeneration", "Augmente grandement la régénération de l'immunité temporaire à la lave");
				line.text = line.text.Replace("Reduces lava burn damage", "Réduit les dégats des brûlures de lave");
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
			if (item.type == 1323)
			{
				line.text = line.text.Replace("Reduced direct damage from touching lava", "Réduit les dégâts direct quand vous touchez la lave");
				line.text = line.text.Replace("Greatly reduces lava burn damage", "Réduit grandement les dégats des brûlures de lave");
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
			if (item.type == 1322)
			{
				line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
			if (item.type == 906 || item.type == 908)
			{
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
			if (item.type == 297)
			{
				line.text = line.text.Replace("Boosts certain stats when holding certain types of rogue weapons", "Augmente certaines statistiques quand vous portez certains types d'armes de voleur");
			}
			if (item.type == 2294)
			{
				line.text = line.text.Replace("Requires bait to catch fish", "Nécessite un appât");
				line.text = line.text.Replace("The line will never break", "La ligne ne cassera jamais");
			}
			if (item.type == 1294)
			{
				line.text = line.text.Replace("Capable of mining Lihzahrd Bricks and Scoria Ore", "Capable d'extraire des briques de Lizhard et du minerai de scorie");
			}
			if (item.type == 2786 || item.type == 2776 || item.type == 2781 || item.type == 3466)
			{
				line.text = line.text.Replace("Material", "Matériau");
				line.text = line.text.Replace("Can mine Uelibloom Ore", "Peut extraire du minerai d'ueliclosion");
			}
			if (item.type == 123 || item.type == 124 || item.type == 125)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 15% increased mining speed", "Bonus d'ensemble: +2 défense et +15% de vitesse de minage");
			}
			if (item.type == 687 || item.type == 688 || item.type == 689)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 10% increased mining speed", "Bonus d'ensemble: +2 défense et +10% de vitesse de minage");
			}
			if (item.type == 954 || item.type == 90 || item.type == 81 || item.type == 77)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 25% increased mining speed", "Bonus d'ensemble: +2 défense et +25% de vitesse de minage");
			}
			if (item.type == 690 || item.type == 691 || item.type == 692)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 20% increased mining speed", "Bonus d'ensemble: +3 défense et +20% de vitesse de minage");
			}
			if (item.type == 91 || item.type == 82 || item.type == 78)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 35% increased mining speed", "Bonus d'ensemble: +3 défense et +35% de vitesse de minage");
			}
			if (item.type == 693 || item.type == 694 || item.type == 695)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 30% increased mining speed", "Bonus d'ensemble: +3 défense et +30% de vitesse de minage");
			}
			if (item.type == 955 || item.type == 92 || item.type == 83 || item.type == 79)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 45% increased mining speed", "Bonus d'ensemble: +3 défense et +45% de vitesse de minage");
			}
			if (item.type == 696 || item.type == 697 || item.type == 698)
			{
				line.text = line.text.Replace("Set Bonus: +4 defense and 40% increased mining speed", "Bonus d'ensemble: +4 défense et +40% de vitesse de minage");
			}
			if ((item.type == 3776 || item.type == 3777 || item.type == 3778))
			{
				line.text = line.text.Replace("The minion damage nerf is reduced while wielding magic weapons", "La réduction des dégâts des sbires est réduite quand vous portez une arme magique");
			}
			if (item.type == 3187)
			{
				line.text = line.text.Replace("3 defense", "+3 défense");
				line.text = line.text.Replace("3% increased rogue damage", "+3% de dégâts de voleur");
			}
			if (item.type == 3188)
			{
				line.text = line.text.Replace("5 defense", "+5 défense");
				line.text = line.text.Replace("3% increased rogue critical strike chance", "+3% de chances de critique de voleur");
			}
			if (item.type == 3189)
			{
				line.text = line.text.Replace("4 defense", "+4 défense");
				line.text = line.text.Replace("3% increased rogue velocity", "+3% de vitesse des projectiles de voleur");
			}
			if (item.type == 3266)
			{
				line.text = line.text.Replace("4 defense", "+3 défense");
				line.text = line.text.Replace("3% increased rogue damage", "+3% de dégâts de voleur");
			}
			if (item.type == 3267)
			{
				line.text = line.text.Replace("5 defense", "+5 défense");
				line.text = line.text.Replace("3% increased rogue critical strike chance", "+3% de chances de critique de voleur");
			}
			if (item.type == 3268)
			{
				line.text = line.text.Replace("4 defense", "+4 défense");
				line.text = line.text.Replace("3% increased rogue velocity", "+3% de vitesse des projectiles de voleur");
			}
			if (item.type == 231 || item.type == 232 || item.type == 233)
			{
				line.text.Replace("Set Bonus: 17% extra melee damage", "Bonus d'ensemble: +17% de dégâts de mêlée");
				line.text.Replace("20% extra true melee damage", "+20% de dégâts de vrai mêlée");
				line.text.Replace("Grants immunity to fire blocks, and temporary immunity to lava", "Immunise au bloc de feu et immunité temporaire à la lave");
				line.text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
			if ((item.type == 684 || item.type == 685 || item.type == 686))
			{
				line.text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
			if (item.type == 1321)
			{
				line.text = line.text.Replace("Increases arrow damage by 10% and greatly increases arrow speed", "Augmente les dégâts des flèches de 10% et augmente grandement la vitesse des flèches");
			}
			if (item.type == 88)
			{
				line.text = line.text.Replace("Provides light when worn", "Émet de la lumière");
			}
			if (item.type == 1921)
			{
				line.text = line.text.Replace("Provides immunity to chilling and freezing effects", "Immunité au refroidissement et au gel");
				line.text = line.text.Replace("Provides a regeneration boost while wearing the Eskimo armor", "Donne un bonus de régénération quand vous portez l'armure d'Eskimo");
				line.text = line.text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
			}
			//Ailes
			if (item.type == 3580 || item.type == 3582 || item.type == 3588 || item.type == 3592 || item.type == 3924 || item.type == 3928 || item.type == 3228 || item.type == 665 || item.type == 1583 || item.type == 1584 || item.type == 1585 || item.type == 1586)
			{
				line.text = line.text.Replace("Great for impersonating devs!", "Parfait pour se faire passer pour les développeurs!");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
			}
			if (item.type == 748)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
			}
			if (item.type == 2609)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
			}
			if (item.type == 493)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+20 max life, +15 defense and +3 life regen", "+20 vie max, +15 défense et +3 régénération de vie");
			}
			if (item.type == 492)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("10% increased damage and critical strike chance", "+10 de dégâts et de chances de critique");
			}
			if (item.type == 749)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+50 max mana, 5% decreased mana usage,", "+50 mana max, 5% de réduction du coût en mana,");
				line.text = line.text.Replace("10% increased magic damage and 5% increased magic critical strike chance", "+10% de dégats magiques et +5% de chances de critique magique");
			}
			if (item.type == 761)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+80 max life", "+80 vie max");
			}
			if (item.type == 1515)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("Honey buff at all times", "Amélioration du Miel permanente");
			}
			if (item.type == 785)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("30% increased movement speed", "+30% de vitesse de mouvement");
				line.text = line.text.Replace("Most attacks have a chance to fire a feather on swing if Harpy Ring or Angel Treads are equipped", "La plupart des attaques ont une chance de tirer une plume si l'anneau de harpie ou les semelles d'ange sont équipés");
			}
			if (item.type == 786)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("15% increased movement speed, 12% increased ranged damage,", "+15% de vitesse de mouvement, +12% de dégâts à distance,");
				line.text = line.text.Replace("16% increased ranged critical strike chance", "+16% de chances de critique à distance");
				line.text = line.text.Replace("and +30 defense while wearing the Necro Armor", "et +30 défense quand vous portez l'armure Necro");
			}
			if (item.type == 821)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("10% increased melee damage", "+10% de dégâts de mêlée");
				line.text = line.text.Replace("and 5% increased melee critical strike chance", "et +5% de chances de critique de mêlée");
			}
			if (item.type == 822)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("2% increased melee and ranged damage", "+2% de dégâts de mêlée et à distance");
				line.text = line.text.Replace("and 1% increased melee and ranged critical strike chance", "et +1% de chances de critique à distance et de mêlée");
				line.text = line.text.Replace("while wearing the Frost Armor", "quand vous portez l'armure de givre");
			}
			if (item.type == 823)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+10 defense and 5% increased damage reduction while wearing the Spectre Armor and Hood", "+10 défense et +5% de réduction des dégâts quand vous portez l'armure de spectre avec la capuche");
				line.text = line.text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana max; +5% de dégâts et de chances de critique magique");
				line.text = line.text.Replace("and 5% decreased mana usage while wearing the Spectre Armor and Mask", "et 5% de réduction de coût en mana quand vous portez l'armure spectre avec le masque");
			}
			if (item.type == 2280)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+15 defense and 10% increased damage reduction while wearing the Beetle Armor and Shell", "+15 défense et +10% de réduction de dégâts quand vous portez l'armure de scarabée avec la carapace");
				line.text = line.text.Replace("10% increased melee damage and critical strike chance while wearing the Beetle Armor and Scale Mail", "+10% de dégâts et de chances de critique de mêlée quand vous portez l'armure de scarabée avec la cotte de mailles");
			}
			if (item.type == 2494)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("Gills effect and you can move freely through liquids", "Effet de la potion de branchies et vous pouvez vous déplacer librement dans les liquides");
				line.text = line.text.Replace("You fall faster while submerged in liquid", "Vous tombez plus vite quand vous êtes immergé");
				line.text = line.text.Replace("20% increased movement speed and 36% increased jump speed", "+20% de vitesse de mouvement et +36% de vitesse de saut");
			}
			if (item.type == 948)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+8 defense, 10% increased movement speed,", "+8 défense, +10% de vitesse de mouvement,");
				line.text = line.text.Replace("4% increased damage, and 2% increased critical strike chance", "+4% de dégâts et +2% de chances de critique");
			}
			if (item.type == 1162)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+10 defense, 10% increased damage reduction,", "+10 défense, +10% de réduction de dégâts,");
				line.text = line.text.Replace("and the Dryad's permanent blessing while wearing the Tiki Armor", "et bénédiction de la Dryade permanente quand vous portez l'armure Tiki");
			}
			if (item.type == 1165)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("At night or during an eclipse, you will gain the following boosts:", "La nuit ou durant une éclipse, vous gagnez les améliorations suivantes:");
				line.text = line.text.Replace("10% increased movement speed, 20% increased jump speed,", "+10% de vitesse de mouvement, +20% de vitesse de saut,");
				line.text = line.text.Replace("+15 defense, 10% increased damage, and 5% increased critical strike chance", "+15 défense, +10% de dégâts et +5% de chances de critique");
			}
			if (item.type == 1797)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("5% increased damage and critical strike chance", "+5% de dégâts et de chances de critique");
			}
			if (item.type == 1830)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "Recul des sbires augmentés et +5% de dégâts des sbires quand vous portez l'armure sinistre");
			}
			if (item.type == 1866)
			{
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("10% increased damage to bows, guns, rocket launchers, and flamethrowers while wearing the Shroomite Armor", "+10% de dégâts aux arcs, armes à feu, lance-roquettes et les lances-flammes quand vous portez l'armure de champignite");
				line.text = line.text.Replace("Boosted weapon type depends on the Shroomite Helmet worn", "Les armes augmentées dépendent du casque en champignite équipé");
			}
			if (item.type == 1871)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+50 max life", "+50 vie maximum");
				line.text = line.text.Replace("Ornaments rain down as you fly", "Des ornements pleuvent quand vous volez");
			}
			if (item.type == 2770)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+5 defense, 5% increased damage,", "+5 défense, +5% de dégâts,");
				line.text = line.text.Replace("10% increased movement speed and 24% increased jump speed", "+10% de vitesse de mouvement et +24% de vitesse de saut");
			}
			if (item.type == 3468)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Great vertical speed", "Excellente vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("7% increased melee damage and 3% increased melee critical strike chance", "+7% des dégâts de mêlée et +3% de chances de critique en mêlée");
				line.text = line.text.Replace("while wearing the Solar Flare Armor", "quand vous portez l'armure de lueur solaire");
			}
			if (item.type == 3471)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Great vertical speed", "Excellente vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+1 max minion and 5% increased minion damage while wearing the Stardust Armor", "+1 sbire max et +5% de dégâts de sbires quand vous portez l'armure astrale");
			}
			if (item.type == 3469)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("3% increased ranged damage and 7% increased ranged critical strike chance", "+3% de dégâts à distance et +7% de chances de critique à distance");
				line.text = line.text.Replace("while wearing the Vortex Armor", "quand vous portez l'armure du vortex");
			}
			if (item.type == 3470)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
				line.text = line.text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana max, +5% de dégâts et de chances de critique magique,");
				line.text = line.text.Replace("and 5% decreased mana usage while wearing the Nebula Armor", "et 5% de réduction de coût en mana quand vous portez l'armure nébuleuse");
			}
			if (item.type == 3883)
			{
				line.text = line.text.Replace("Equipable", "Peut s'équiper");
				line.text = line.text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.text = line.text.Replace("Horizontal speed", "Vitesse horizontale");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.text = line.text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.text = line.text.Replace("Flight time", "Temps de vol");
			}
			//line.text = line.text.Replace("", "");
			List<int> grappins = new List<int>() { 84, 1236, 1237, 1238, 1239, 1240, 1241, 939, 1273, 2585, 2360, 185, 1800, 1915, 437, 3021, 3023, 3020, 3022, 2800, 1829, 1916, 3572, 3623 };
			if (grappins.Contains(item.type))
			{
				line.text = line.text.Replace("Equipable", "Peut s'équiper");
				line.text = line.text.Replace("Reach", "Portée");
				line.text = line.text.Replace("Launch Velocity", "Vitesse de Lancer");
				line.text = line.text.Replace("Pull Velocity", "Vitesse de Traction");
			}
		}
	}
}
			