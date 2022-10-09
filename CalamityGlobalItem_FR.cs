using System;
using Terraria;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Armor.Aerospec;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.DifficultyItems;
using CalamityMod.Items.LoreItems;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Tools;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.World;
using System.Collections.Generic;
using Terraria.ModLoader;
using CalamityMod.Items.Armor.Astral;
using CalamityMod.Items.Armor.Auric;
using CalamityMod.Items.Armor.Bloodflare;
using CalamityMod.Items.Armor.Brimflame;
using CalamityMod.Items.Armor.Daedalus;
using CalamityMod.Items.Armor.Demonshade;
using CalamityMod.Items.Armor.DesertProwler;
using CalamityMod.Items.Armor.FathomSwarmer;
using CalamityMod.Items.Armor.Fearmonger;
using CalamityMod.Items.Armor;
using CalamityMod.Items.Armor.GodSlayer;
using CalamityMod.Items.Armor.Mollusk;
using CalamityMod.Items.Armor.OmegaBlue;
using CalamityMod.Items.Armor.Plaguebringer;
using CalamityMod.Items.Armor.PlagueReaper;
using CalamityMod.Items.Armor.Prismatic;
using CalamityMod.Items.Armor.Reaver;
using CalamityMod.Items.Armor.Hydrothermic;
using CalamityMod.Items.Armor.Silva;
using CalamityMod.Items.Armor.SnowRuffian;
using CalamityMod.Items.Armor.Statigel;
using CalamityMod.Items.Armor.Sulphurous;
using CalamityMod.Items.Armor.Tarragon;
using CalamityMod.Items.Armor.TitanHeart;
using CalamityMod.Items.Armor.Umbraphile;
using CalamityMod.Items.Armor.Victide;
using CalamityMod.Items.Armor.Wulfrum;
using CalamityMod.Items.Armor.Empyrean;
using CalamityMod.Items.Armor.GemTech;
using CalamityMod.Items.Mounts;
using CalamityMod.Balancing;
using System.Reflection;

public class CalamityGlobalItem_FR : GlobalItem
{
	public CalamityGlobalItem_FR()
	{
	}

	public override void UpdateArmorSet(Player player, string set)
	{
		string hotkey = CalamityMod.CalamityKeybinds.SetBonusHotKey.ToString();
		if (set == "AerospecMagic")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique magique\n" +
				"Prendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\n" +
				"Vous permet de tomber plus rapidement et annule les dégâts de chute";
		}
		else if (set == "AerospecRogue")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique de voleur\n" +
				"Prendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\n" +
				"Vous permet de tomber plus rapidement et annule les dégâts de chute\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "AerospecMelee")
		{
			player.setBonus = "+5% de vitesse de mouvement et chances de coup critique en mêlée\n" +
				"Prendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\n" +
				"Vous permet de tomber plus rapidement et annule les dégâts de chute";
		}
		else if (set == "AerospecSummon")
		{
			player.setBonus = "+11% de dégâts des sbires et +1 sbire max\n" +
				"Invoque une valkyrie pour vous protéger\n" +
				"Prendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\n" +
				"Vous permet de tomber plus rapidement et annule les dégâts de chute";
		}
		else if (set == "AerospecRanged")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique à distance\n" +
				"Prendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\n" +
				"Vous permet de tomber plus rapidement et annule les dégâts de chute";
		}
		else if (set == "Astral")
		{
			player.setBonus = "+5% de vitesse de mouvement et +3 sbires max\n" +
				"+35% de dégâts et +25% de chances de coup critique\n" +
				"Les coups critiques font pleuvoir des étoiles déchues, sacrées et astrales\n" +
				"Cet effet à un temps de recharge de 1s";
		}
		else if (set == "HydrothermicRanged")
		{
			player.setBonus = "+5% de dégâts à distance\n" +
				"Effet de la potion infernale quand vous êtes à moins de la moitié de votre vie\n" +
				"Vous tirez une déflagration de chaos à tête chercheuse toutes les 0.33 secondes quand vous utilisez une arme à distance\n" +
				"Vous emettez une explosion flamboyante quand vous êtes touché";
		}
		else if (set == "HydrothermicMelee")
		{
			player.setBonus = "+5% de dégâts de mêlée\n" +
				"Les ennemis ont plus de chance de vous cibler\n" +
				"Effet de la potion infernale quand vous êtes à moins de la moitié de votre vie\n" +
				"Les attaques et les projectiles de mêlée créent des éruptions de flammes chaotiques quand ils touchent\n" +
				"Vous emettez une explosion flamboyante quand vous êtes touché";
		}
		else if (set == "HydrothermicSummon")
		{
			player.setBonus = "+40% de dégâts des sbires et +2 sbires max\n" +
				"Effet de la potion infernale quand vous êtes à moins de la moitié de votre vie\n" +
				"Invoque une Aération hydrothermique pour vous protéger\n" +
				"Vous emettez une explosion flamboyante quand vous êtes touché";
		}
		else if (set == "HydrothermicRogue")
		{
			player.setBonus = "+5% de dégâts de voleur\n" +
				"Effet de la potion infernale quand vous êtes à moins de la moitié de votre vie\n" +
				"Les armes de voleur relâchent une volée de flammes chaotiques autour du joueur toutes les 2.5 secondes qui pourchassent les ennemis\n" +
				"Vous emettez une explosion flamboyante quand vous êtes touché\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 110\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "HydrothermicMagic")
		{
			player.setBonus = "+5% de dégâts magiques et -15% de coût en mana\n" +
				"Effet de la potion infernale quand vous êtes à moins de la moitié de votre vie\n" +
				"Les attaques magiques créent des orbes de soin et de dégâts quand elles touchent\n" +
				"Vous emettez une explosion flamboyante quand vous êtes touché";
		}
		else if (set == "AuricMelee")
		{
			player.setBonus = "Effets des armures de mêlée d'estragon, de brûlesang, et de déicide\n" +
				"Les ennemis ont plus de chances de vous cibler\n" +
				"Tous les projectiles font apparaître des orbes de soins auriques quand vous touchez";
		}
		else if (set == "AuricRanged")
		{
			player.setBonus = "Effets des armures à distance d'estragon, de brûlesang, et de déicide\n" +
				"Tous les projectiles font apparaître des orbes de soins auriques quand vous touchez";
		}
		else if (set == "AuricRogue")
		{
			player.setBonus = "Effets des armures de voleur d'estragon, de brûlesang, et de déicide\n" +
				"Tous les projectiles font apparaître des orbes de soins auriques quand vous touchez\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 130\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "AuricSummon")
		{
			player.setBonus = "Effets des armures d'invocateur d'estragon, de brûlesang et Silva\n" +
				"Tous les projectiles font apparaître des orbes de soins auriques quand vous touchez\n" +
				"Vitesse de course et d'accélération augmentée de 5%\n" +
				"+6 sbires max et +75% de dégâts des sbires";
		}
		else if (set == "AuricMagic")
		{
			player.setBonus = "Effets des armures magiques d'estragon, de brûlesang et Silva\n" +
				"Tous les projectiles font apparaître des orbes auriques de soins quand vous touchez\n" +
				"Vitesse de course et d'accélération augmentée de 5%";
		}
		else if (set == "BloodflareRogue")
		{
			player.setBonus = "Augmente grandement la régénération de vie\n" +
				"Les ennemis ayant moins de 50% de leur vie lâchent un coeur quand ils sont frappés\n" +
				"Cet effet à un temps de recharge de 5 secondes\n" +
				"Les ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\n" +
				"Avoir plus de 80% de vos points de vie augmente votre défense de 30 et vos chances de coup critique de voleur de 5%\n" +
				"Avoir moins de 80% de votre vie augmente vos dégâts de voleur de 10%\n" +
				"Les coups critiques de voleur ont 50% de chances de vous soigner\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 120\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "BloodflareSummon")
		{
			player.setBonus = "+50% de dégâts des sbires et +3 sbires max\n" +
				"Augmente grandement la régénération de vie\n" +
				"Les ennemis ayant moins de 50% de leur vie lâchent un coeur quand ils sont frappés\n" +
				"Cet effet à un temps de recharge de 5 secondes\n" +
				"Les ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\n" +
				"Invoque des mines d'épouvantôme qui vous encerclent\n" +
				"Avoir plus de 90% de votre vie augmente de 10% les dégâts des sbires\n" +
				"Avoir moins de 50% de votre vie augmente votre défense de 20 et votre régénération de vie de 2";
		}
		else if (set == "BloodflareRanged")
		{
			player.setBonus = "Augmente grandement la régénération de vie\n" +
				"Les ennemis ayant moins de 50% de leur vie lâchent un coeur quand ils sont frappés\n" +
				"Cet effet à un temps de recharge de 5 secondes\n" +
				"Les ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\n" +
				"Appuyez sur " + hotkey + " pour libérer les âmes perdues de l'épouvantôme pour détruire vos ennemis\n" +
				"Cet effet a 30s de temps de recharge\n" +
				"Les armes à distance tirent des orbes d'explosion de sang toutes les 2.5 secondes";
		}
		else if (set == "BloodflareMagic")
		{
			player.setBonus = "Augmente grandement la régénération de vie\n" +
				"Les ennemis ayant moins de 50% de leur vie lâchent un coeur quand ils sont frappés\n" +
				"Cet effet à un temps de recharge de 5 secondes\n" +
				"Les ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\n" +
				"Les armes magiques tirent des décharges fantômatiques toutes les 1.67 secondes\n" +
				"Les coups critiques magiques provoquent des explosions de flammes toutes les 2 secondes";
		}
		else if (set == "BloodflareMelee")
		{
			player.setBonus = "Augmente grandement la régénération de vie\n" +
				"Les ennemis ont plus de chances de vous cibler\n" +
				"Les ennemis ayant moins de 50% de leur vie lâchent un coeur quand ils sont frappés\n" +
				"Cet effet à un temps de recharge de 5 secondes\n" +
				"Les ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\n" +
				"Les attaques de vraie mêlée vous soignent\n" +
				"Après 15 attaques de vraie mêlée réussies, vous entrerez en fureur de sang pendant 5 secondes\n" +
				"La fureur vous fera gagner 25% de dégâts et de chances de coup critique en mêlée, et les dégâts de contact sont réduit de moitié\n" +
				"Cet effet à 30s de temps de recharge";
		}
		else if (set == "Brimflame")
		{
			player.setBonus = "+15% de dégâts et de chances de coup critique magique\n" +
				"Appuyez sur " + hotkey + " pour déclencher une fureur flammesoufre\n" +
				"Durant cet effet, vos dégâts sont significativement augmentés\n" +
				"Cependant, votre vie diminue rapidement et votre mana ne se régénère pas durant la fureur\n" +
				"Cependant, cet effet peut être interrompu, la fureur flammesoufre a un temps de recharge de 30s";
		}
		else if (set == "DaedalusMagic")
		{
			player.setBonus = "+5% de dégâts magiques\n" +
				"Vous avez 10% de cahnce d'absorber les attaques et les projectiles physiques quand vous êtes touché\n" +
				"Si vous absorbez une attaque, vous êtes soigné pour la moitié des dégâts de cette attaque";
		}
		else if (set == "DaedalusSummon")
		{
			player.setBonus = "+20% de dégâts des sbires et +2 sbires max\n" +
				"Un cristal de Dédale flotte au-dessus de vous pour vous protéger";
		}
		else if (set == "DaedalusMelee")
		{
			player.setBonus = "+5% de dégâts de mêlée\n" +
				"Les ennemis ont plus de chances de vous cibler\n" +
				"Vous renvoyez les projectiles sur les ennemis\n" +
				"Si vous renvoyez un projectile, il ne vous inflige que la moitié de ses dégâts\n" +
				"Cet effet à un temps de recharge de 90s partagé avec les autres effets d'esquive et de renvoi";
		}
		else if (set == "DaedalusRanged")
		{
			player.setBonus = "+5% de dégâts à distance\n" +
				"Être touché vous fait émettre une décharge d'éclats de cristaux";
		}
		else if (set == "DaedalusRogue")
		{
			player.setBonus = "+5% de dégâts de voleur\n" +
				"Les projectiles de voleur émettent des éclats de cristaux sur leur trajectoire\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 105\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Demonshade")
		{
			player.setBonus = "+100% de dégâts des sbires et +10 sbires max\n" +
				"Toutes les attaques infligent les flammes démoniaques\n" +
				"Des rayons d'ombre et des faux démoniaques pleuvront quand vous serez touché\n" +
				"Une diable rouge amical vous suivra\n" +
				"Appuyez sur " + hotkey + " pour enrager les ennemis proches avec un sort de magie noire pendant 10s\n" +
				"Il feront alors 25% de dégâts supplémentaires, mais subiront 125% de dégâts supplémentaires";
		}
		else if (set == "DesertProwler")
		{
			player.setBonus = "Les attaques à distance font 1 dégât supplémentaire\n" +
				"Les coups critiques à distance peuvent rarement conjurer une tempête de sable";
		}
		else if (set == "FathomSwarmer")
		{
			player.setBonus = "+10% de dégâts des sbires et +2 sbires max\n" +
				"Permet de grimper aux murs\n" +
				"+30% de dégâts des sbires quand vous êtes immergé\n" +
				"Donne une quantité de modérée de lumière et réduit de façon modérée la perte de respiration dans les abysses";
		}
		else if (set == "Fearmonger")
		{
			player.setBonus = "+20% de dégâts des sbires et +2 sbires max\n" +
				"La réduction des dégâts infligés par les sbires est réduite quand vous tenez une arme\n" +
				"Immunité à toutes les formes de flamme et de givre\n" +
				"Toutes les attaques de sbires augmentent colossalement la régénération de vie\n" +
				"+15% de réduction de dégâts durant les lunes citrouilles et de givre\n" +
				"Cette réduction de dégâts ignore la limitation normale\n";
		}
		else if (set == "ForbiddenCalam")
		{
			int stormMana = (int)(60f * player.manaCost);
			player.setBonus = "Appuyez sur " + hotkey + " pour convoquer une tornade ancienne à l'emplacement du curseur\n" +
				"La tornade ancienne coûte " + stormMana + " mana et profite à la fois des améliorations d'invocateur et de voleur\n" +
				"Les attaques furtives créent des dévoreurs à tête chercheuse quand vous touchez\n" +
				"Les attaques de voleur et d'invocateur utiliserons le bonus de statistiques le plus élevé des deux\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 40\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "GodSlayerMelee")
		{
			player.setBonus = "Vous permet de foncer sur une immense distance dans toutes les directions\n" +
				"Appuyez sur " + hotkey + "tout en maintenant les touches directionnelles correspondant à la direction que vous souhaitez prendre\n" +
				"Les ennemis que vous traversez en fonçant prennent des dégâts massifs\n" +
                "Durant cette ruée, vous êtes immunisé a la plupart des altérations d'état\n" +
				"Cet effet a un temps de recharge de 35s\n" +
                "Les ennemis ont plus de chances de vous cibler\n" +
				"Prendre plus de 80 dégâts en une fois vous fera relâcher une nuée de fléchettes déicides infligeant des dégâts importants\n" +
				"Les ennemis subissent beaucoup de dégâts quand ils vous touchent\n" +
				"Une attaque qui inflige moins de 80 dégâts verra ses dégâts réduits à 1";
		}
		else if (set == "GodSlayerRanged")
		{
			player.setBonus = "Vous permet de foncer sur une immense distance dans toutes les directions\n" +
				"Appuyez sur " + hotkey + "tout en maintenant les touches directionnelles correspondant à la direction que vous souhaitez prendre\n" +
				"Les ennemis que vous traversez en fonçant prennent des dégâts massifs\n" +
				"Durant cette ruée, vous êtes immunisé a la plupart des altérations d'état\n" +
				"Cet effet a un temps de recharge de 35s\n" +
				"Vous tirez une cartouche à éclat déicide toutes les 2.5s quand vous tirez avec une arme à distance";
		}
		else if (set == "GodSlayerRogue")
		{
			player.setBonus = "Vous permet de foncer sur une immense distance dans toutes les directions\n" +
				"Appuyez sur " + hotkey + "tout en maintenant les touches directionnelles correspondant à la direction que vous souhaitez prendre\n" +
				"Les ennemis que vous traversez en fonçant prennent des dégâts massifs\n" +
				"Durant cette ruée, vous êtes immunisé a la plupart des altérations d'état\n" +
				"Cet effet a un temps de recharge de 35s\n" +
				"Quand vous êtes à 100% de votre vie, toutes vos statistiques de voleur sont augmentées de 10%\n" +
				"Si vous prenez plus de 80 dégâts en un coup, vous obtiendrez une période d'invulnérabilité plus longue\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 120\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Mollusk")
		{
			player.setBonus = "Deux crustacés vous assisteront au combat\n" +
				"+10% de dégâts\n" +
				"Votre mouvement horizontal est réduit";
		}
		else if (set == "OmegaBlue")
		{
			player.setBonus = "Augmente la pénétration d'armure de 15\n" +
				"+10% de dégâts, de chances de coup critique et +2 sbires max\n" +
				"Des tentacules à faible portée vous soigneront en aspirant la vie des ennemis\n" +
				"Appuyez sur " + hotkey + " pour activer la folie abyssale pendant 5 secondes\n" +
				"La folie abyssale augmentent les dégâts, les chances de coup critique, et l'aggressivité et la portée des tentacules\n" +
				"Cet effet a 25s de temps de recharge";
		}
		else if (set == "PlaguebringerSummon")
		{
			player.setBonus = "Accorde une ruée pestiférée pour charger les ennemis et leur infliger la peste\n" +
				"Invoque un ptit colporte-peste pour vous protéger et renforcer les sbires proches\n" +
				"+3 sbires max";
		}
		else if (set == "PlaguebringerRanged")
		{
			player.setBonus = "25% de réduction de consommation de munitions et +5% de temps de vol\n" +
				"Les ennemis subissent 10% de dégâts supplémentaires des projectiles à distance quand ils sont affectés par la peste\n" +
				"Être touché fait pleuvoir des cendres de peste\n" +
				"Appuyer sur " + hotkey + " pour vous aveugler pendant 5 secondes mais augmenter massivement vos dégâts à distance\n" +
				"Cet effet a 25s de temps de recharge.";
		}
		else if (set == "Prismatic")
		{
			player.setBonus = "+40 mana maximum et +15% de réduction du coût en mana\n" +
				"Régénération de mana augmentée\n" +
				"Appuyez sur " + hotkey + " pour relâcher un barrage de lasers mortels sur le curseur pendant 5 secondes\n" +
				"Cet effet a 30s de temps de recharge";
		}
		else if (set == "ReaverExplore")
		{
			player.setBonus = "Fait briller les trésors proches\n" +
				"Portée de ramassage et de placement des blocs auugmentée\n" +
				"Miner des tuiles sous l'eau restaure la respiration\n" +
				"Invoque une orbe massacreuse pour éclairer les environs\n" +
				"Réduit l'agressivité des ennemis, même dans les abysses\n" +
				"Accorde une petite quantité de lumière dans les abysses";
		}
		else if (set == "ReaverMobility")
		{
			player.setBonus = "Immunise contre les dégâts de chute et permet le saut automatique\n" +
				"+10% de temps de vol et de vitesse de vol horizontal\n" +
				"Les grappins se lancent et se rétractent 10% plus vite\n" +
				"Réduit le temps de recharge des actions permettant de foncer";
		}
		else if (set == "ReaverTank")
		{
			player.setBonus = "+10 défense et +3 régénération de vie\n" +
                "Les ennemis ont plus de chances de vous cibler\n" +
                "Réduit la perte de régénération de vie a cause des altérations infligeant des dégâts de 20%\n" +
                "Toutes les attaques ont une petite chance de volez de la vie et d'accélérer la vitesse de régénération de vie\n" +
                "Réduction de la vitesse de déplacement et du temps de vol de 20%\n" +
                "Les dégâts subis sont renvoyés et invoquent une épine\n" +
                "La Rage du Saccageur à 25% de chances de s'activer lorsque vous subissez des dégâts";

		}
		else if (set == "ShroomiteCalam")
		{
			player.setBonus = "Furtivité à distance quand vous restez immobile";
		}
		else if (set == "SilvaSummon")
		{
			player.setBonus = "+65% de dégâts des sbires et +5 sbires max\n" +
				"Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\n" +
				"Vitesse de course et d'accélération maximale augmentée de 5%\n" +
				"Si vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 8s\n" +
				"Cet effet ne s'active qu'une fois par vie\n" +
				"Invoque une ancien prisme feuillu pour anéantir vos ennemis avec de l'énergie vitale";
		}
		else if (set == "SilvaMagic")
		{
			player.setBonus = "Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\n" +
				"Vitesse de course et d'accélération maximale augmentée de 8%\n" +
				"Si vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 8s\n" +
				"Cet effet ne s'active qu'une fois par vie\n" +
				"Les projectiles magiques qui ne transpercent pas causeront occasionnellement de puissantes explosions d'énergie naturelle";
		}
		else if (set == "SnowRuffian")
		{
			player.setBonus = "+5% de dégâts de voleur\n" +
				"Vous pouvez flotter pour annuler les dégâts de chute\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 50\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "StatigelMagic")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\n" +
				"Accorde un saut additionnel et une hauteur de saut accrue\n" +
				"+12% de vitesse de saut";
		}
		else if (set == "StatigelRanged")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\n" +
				"Accorde un saut additionnel et une hauteur de saut accrue\n" +
				"+12% de vitesse de saut";
		}
		else if (set == "StatigelMelee")
		{
			player.setBonus = "Les ennemis ont plus de chance de vous cibler\n" +
				"Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\n" +
				"Accorde un saut additionnel et une hauteur de saut accrue\n" +
				"+12% de vitesse de saut";
		}
		else if (set == "StatigelSummon")
		{
			player.setBonus = "+18% de dégâts des sbires et +1 sbires max\n" +
				"Invoque un dieu des gelées miniature pour combattre à vos côtés, en fonction du biome maléfique présent dans votre monde\n" +
				"Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\n" +
				"Accorde un saut additionnel et une hauteur de saut accrue\n" +
				"+12% de vitesse de saut";
		}
		else if (set == "StatigelRogue")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\n" +
				"Accorde un saut additionnel et une hauteur de saut accrue\n" +
				"+12% de vitesse de saut\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Sulfur")
		{
			player.setBonus = "Attaquer et être attaqué par les ennemis inflige l'empoisonnement\n" +
				"Accorde un saut additionnel qui invoque une bulle sulfurique\n" +
				"Accorde une meilleure mobilité sous l'eau et réduit la sévérité des eaux sulfuriques\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "TarragonMelee")
		{
			player.setBonus = "Augmente la portée de collecte des coeurs\n" +
				"Les ennemis ont une chance de lâcher plus de coeurs quand ils meurent\n" +
                "Les ennemis ont plus de chances de vous cibler\n" +
				"Vous avez 25% de chances de gagner une amélioration de régénération de vie quand vous prenez des dégâts\n" +
				"Appuyez sur " + hotkey + " pour vous draper dans de l'énergie vitale qui réduit énormément les dégâts de contact ennemis pendant 10s\n" +
				"Cet effet à 30s de temps de recharge";
		}
		else if (set == "TarragonRogue")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\n" +
				"Augmente la portée de collecte des coeurs\n" +
				"Les ennemis ont une chance de lâcher plus de coeurs quand ils meurent\n" +
				"Tous les 25 coups critiques de voleur, vous gagnerez 3 secondes d'invincibilité\n" +
				"Cet effet à un temps de recharge de 30s\n" +
                "Quand vous êtes sous l'effet d'une altération d'état, vous gagnez 10% de dégâts de voleur\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 115\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "TarragonSummon")
		{
			player.setBonus = "+50% de dégâts des sbires et +3 sbires max\n" +
				"Réduit le taux d'apparition des ennemis\n" +
				"Augmente la portée de collecte des coeurs\n" +
				"Les ennemis ont une chance de lâcher plus de coeurs quand ils meurent\n" +
				"Invoque une aura vitale autour de vous qui inflige des dégâts aux ennemis proches";
		}
		else if (set == "TarragonMagic")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\n" +
				"Augmente la portée de collecte des coeurs\n" +
				"Les ennemis ont une chance de lâcher plus de coeurs quand ils meurent\n" +
				"Tous les 5 coups critiques, vous libèrerez une tempête de feuilles\n" +
				"Les projectiles magiques vous soignent quand vous touchez\n" +
				"La quantité de soin dépend des dégâts infligés par le projectile";
		}
		else if (set == "TarragonRanged")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\n" +
				"Augmente la portée de collecte des coeurs\n" +
				"Les ennemis ont une chance de lâcher plus de coeurs quand ils meurent\n" +
				"Les projectiles à distance se divisent en énergie vitale à tête chercheuse et en feuilles à l'impact";
		}
		else if (set == "TitanHeart")
		{
			player.setBonus = "+15% de dégâts et de recul de voleur\n" +
				"Les attaques furtives ont deux fois plus de recul et provoquent une explosion astrale\n" +
				"Immunise contre le recul\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Umbraphile")
		{
			player.setBonus = "Les armes de voleur ont une chance de créer une explosion quand elles touchent\n" +
				"Les attaques furtives créent toujours une explosion\n" +
				"Les potions de pénombre augmentent toujours la furtivité avec une efficacité maximale\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 110\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "VictideRogue")
		{
			player.setBonus = "+3 régénération de vie et +10% aux dégâts de voleur quand vous êtes immergé\n" +
				"Vous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\n" +
				"Le coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\n" +
				"Augmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 90\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "VictideMelee")
		{
			player.setBonus = "Les ennemis ont plus de chance de vous cibler\n" +
				"+3 régénération de vie et +10% aux dégâts de mêlée quand vous êtes immergé\n" +
				"Vous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\n" +
				"Le coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\n" +
				"Augmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses";
		}
		else if (set == "VictideSummon")
		{
			player.setBonus = "+3 régénération de vie et +10% aux dégâts des sbires quand vous êtes immergé\n" +
				"Invoque un oursin des mer pour vous protéger\n" +
				"Vous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\n" +
				"Le coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\n" +
				"Augmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n" +
				"+1 sbires max";
		}
		else if (set == "VictideMagic")
		{
			player.setBonus = "+3 régénération de vie et +10% aux dégâts magiques quand vous êtes immergé\n" +
				"Vous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\n" +
				"Le coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\n" +
				"Augmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses";
		}
		else if (set == "VictideRanged")
		{
			player.setBonus = "+3 régénération de vie et +10% aux dégâts à distance quand vous êtes immergé\n" +
				"Vous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\n" +
				"Le coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\n" +
				"Augmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses";
		}
		else if (set == "WulfrumRanged")
		{
			player.setBonus = "+3 défense\n" +
				"+5 défense quand vous avez moins de la moitié de vos points de vie";
		}
		else if (set == "WulfrumMelee")
		{
			player.setBonus = "+3 défense\n" +
				"+5 défense quand vous avez moins de la moitié de vos points de vie";
		}
		else if (set == "WulfrumSummon")
		{
			player.setBonus = "+3 défense et +1 sbire max\n" +
				"+5 défense quand vous avez moins de la moitié de vos points de vie";
		}
		else if (set == "WulfrumMagic")
		{
			player.setBonus = "+3 défense\n" +
				"+5 défense quand vous avez moins de la moitié de vos points de vie";
		}
		else if (set == "WulfrumRogue")
		{
			player.setBonus = "+3 défense\n" +
				"+5 défense quand vous avez moins de la moitié de vos points de vie\n" +
                "La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 50\n" +
                "Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
                "La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
                "En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Xeroc")
		{
			player.setBonus = "+9% de dégâts et de vitesse des projectiles de voleur\n" +
				"Les projectiles de voleur ont des effets spéciaux quand ils touchent\n" +
				"Vous êtes imprégné d'îre et de rage cosmique quand vous subissez des dégâts\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 115\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Gemtech") {
			player.setBonus = "Six fragments de gemmes sont en orbite autour de vous; une pour chaque classe, et une gemme de base\n" +
                "Une gemme est perdue si vous prenez plus de 100 dégâts en un seul coup. Le type de gemme perdue correspond a la classe utilisée\n" +
                "Si cette gemme à déja été perdue, la gemme de base est perdue à la place\n" +
                "Quand une gemme est perdue, elle se brise et se rue vers l'ennemi le plus proche, et lui inflige une base de 40000 dégâts\n" +
                "Les gemmes mettent 30 secondes pour réapparaître\n" +
                "La gemme rouge accorde 130 furtivité maximum, des statistiques de voleur augmentées et rends la furtivité consommable uniquement via les armes de voleur\n" +
                "La gemme bleue accorde 4 sbires supplémentaires, des dégâts de sbires augmentés et réduit la pénalité des invocations quand vous tenez une arme d'une autre classe\n" +
                "La gemme violette accorde 100 mana maximum, des statistiques magiques augmentées, et régénére rapidement le mana quand vous tenez une arme non-magique\n" +
                "La gemme rose accorde 75 défense, une réduction des dégâts, une vitesse de mouvement et de saut augmentée, et +2 régénération de vie\n" +
                "Quand toutes les gemmes existent simultanément, toucher une cible avec une arme vous donnera +2 régénération de vie pendant 8 secondes\n" +
                "Cet effet est porté a +3 durant 2.5 secondes si vous touchez une cible avec une arme d'une classe différente de celle qui a déclenché l'effet précédent";
		}
		else if (set == "Gladiator")
		{
			player.setBonus = "+3 défense\n" +
				"+5% de dégâts de voleur et +10% de vitesse des projectiles de voleur\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 70\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur";
		}
		else if (set == "Obsidian")
		{
			player.setBonus = "+2 défense\n" +
				"+5% de dégâts et de chances de critique de voleur\n" +
				"Immunise contre les blocs de feu et immunité temporaire à la lave\n" +
				"La furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 80\n" +
				"Une fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\n" +
				"La furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\n" +
				"En s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur" +
				(CalamityWorld.death ? "\nProtège de la chaleur en mode Mort" : "");
		}
		else if (set == "Eskimo")
		{
			player.setBonus = "+10% de dégâts pour les armes de glace\n" +
				"Les ennemis du froid infligent moins de dégâts de contact\n" +
				"Immunise contre le brûlegivre et l'état glacial" + (CalamityWorld.death ? "\nProtège du froid en mode Mort" : "");
		}
		else if (set == "CrystalAssasin")
		{
			player.setBonus = "Permet de foncer";
		}
		else if (set == "SquireTier2")
		{
			player.setBonus = player.setBonus.Replace("Increases your life regeneration\n" +
				"15% increased minion damage and 10% increased melee critical strike chance", "Augmente votre régénération de vie\n" +
				"+15% de dégâts des sbires et +10% de chances de coup critique en mêlée");
		}
		else if (set == "HuntressTier2")
		{
			player.setBonus = player.setBonus.Replace("10% increased minion and ranged damage", "+10% de dégâts des sbires et à distance");
		}
		else if (set == "ApprenticeTier2")
		{
			player.setBonus = player.setBonus.Replace("5% increased minion damage and 15% increased magic critical strike chance", "+5% de dégâts des sbires et +15% de chances de critique magique");
		}
		else if (set == "MonkTier3")
		{
			player.setBonus = player.setBonus.Replace("10% increased melee damage, melee critical strike chance and melee speed\n" +
				"30% increased minion damage", "+10% aux dégâts, chances de coup critique et vitesse de mêlée\n" +
				"+30% de dégâts des sbires");
		}
		else if (set == "SquireTier3")
		{
			player.setBonus = player.setBonus.Replace("Massively increased life regeneration\n" +
				"10% increased minion damage and melee critical strike chance", "Augmentation massive de la régénération de vie\n" +
				"+10% aux dégâts des sbires et aux chances de coup critique en mêlée");
		}
		else if (set == "HuntressTier3")
		{
			player.setBonus = player.setBonus.Replace("10% increased minion and ranged damage", "+10% de dégâts pour les dégâts des sbires et à distance");
		}
		else if (set == "ApprenticeTier3")
		{
			player.setBonus = player.setBonus.Replace("10% increased minion damage and 15% increased magic critical strike chance", "+10% aux dégâts des sbires et +15% aux chances de coup critique magique");
		}
		else if (set == "SpectreHealing")
		{
			player.setBonus = "Réduit les dégâts magiques de 20% et le convertit en force de soin\n" +
				"Les dégâts magiques infligés aux ennemis soignent le joueur avec le moins de vie restante";
		}
	}

	public override string IsArmorSet(Item head, Item body, Item legs) {
		if (head.type == ModContent.ItemType<AerospecHat>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecMagic";
		}
		if (head.type == ModContent.ItemType<AerospecHeadgear>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecRogue";
		}
		if (head.type == ModContent.ItemType<AerospecHelm>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecMelee";
		}
		if (head.type == ModContent.ItemType<AerospecHelmet>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecSummon";
		}
		if (head.type == ModContent.ItemType<AerospecHood>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecRanged";
		}
		if (head.type == ModContent.ItemType<AstralHelm>() && body.type == ModContent.ItemType<AstralBreastplate>() && legs.type == ModContent.ItemType<AstralLeggings>())
		{
			return "Astral";
		}
		if (head.type == ModContent.ItemType<HydrothermicHeadRanged>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
		{
			return "HydrothermicRanged";
		}
		if (head.type == ModContent.ItemType<HydrothermicHeadMelee>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
		{
			return "HydrothermicMelee";
		}
		if (head.type == ModContent.ItemType<HydrothermicHeadSummon>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
		{
			return "HydrothermicSummon";
		}
		if (head.type == ModContent.ItemType<HydrothermicHeadRogue>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
		{
			return "HydrothermicRogue";
		}
		if (head.type == ModContent.ItemType<HydrothermicHeadMagic>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
		{
			return "HydrothermicMagic";
		}
		if (head.type == ModContent.ItemType<AuricTeslaRoyalHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricMelee";
		}
		if (head.type == ModContent.ItemType<AuricTeslaHoodedFacemask>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricRanged";
		}
		if (head.type == ModContent.ItemType<AuricTeslaPlumedHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricRogue";
		}
		if (head.type == ModContent.ItemType<AuricTeslaSpaceHelmet>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricSummon";
		}
		if (head.type == ModContent.ItemType<AuricTeslaWireHemmedVisage>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricMagic";
		}
		if (head.type == ModContent.ItemType<BloodflareHeadRogue>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRogue";
		}
		if (head.type == ModContent.ItemType<BloodflareHeadSummon>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareSummon";
		}
		if (head.type == ModContent.ItemType<BloodflareHeadRanged>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRanged";
		}
		if (head.type == ModContent.ItemType<BloodflareHeadMagic>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMagic";
		}
		if (head.type == ModContent.ItemType<BloodflareHeadMelee>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMelee";
		}
		if (head.type == ModContent.ItemType<BrimflameScowl>() && body.type == ModContent.ItemType<BrimflameRobes>() && legs.type == ModContent.ItemType<BrimflameBoots>())
		{
			return "Brimflame";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadMagic>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMagic";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadSummon>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusSummon";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadMelee>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMelee";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadRanged>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusRanged";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadRogue>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusRogue";
		}
		if (head.type == ModContent.ItemType<DemonshadeHelm>() && body.type == ModContent.ItemType<DemonshadeBreastplate>() && legs.type == ModContent.ItemType<DemonshadeGreaves>())
		{
			return "Demonshade";
		}
		if (head.type == ModContent.ItemType<DesertProwlerHat>() && body.type == ModContent.ItemType<DesertProwlerShirt>() && legs.type == ModContent.ItemType<DesertProwlerPants>())
		{
			return "DesertProwler";
		}
		if (head.type == ModContent.ItemType<FathomSwarmerVisage>() && body.type == ModContent.ItemType<FathomSwarmerBreastplate>() && legs.type == ModContent.ItemType<FathomSwarmerBoots>())
		{
			return "FathomSwarmer";
		}
		if (head.type == ModContent.ItemType<FearmongerGreathelm>() && body.type == ModContent.ItemType<FearmongerPlateMail>() && legs.type == ModContent.ItemType<FearmongerGreaves>())
		{
			return "Fearmonger";
		}
		if (head.type == ModContent.ItemType<ForbiddenCirclet>() && body.type == 3777 && legs.type == 3778)
		{
			return "ForbiddenCalam";
		}
		if (head.type == ModContent.ItemType<GodSlayerHeadMelee>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerMelee";
		}
		if (head.type == ModContent.ItemType<GodSlayerHeadRanged>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRanged";
		}
		if (head.type == ModContent.ItemType<GodSlayerHeadRogue>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRogue";
		}
		if (head.type == ModContent.ItemType<MolluskShellmet>() && body.type == ModContent.ItemType<MolluskShellplate>() && legs.type == ModContent.ItemType<MolluskShelleggings>())
		{
			return "Mollusk";
		}
		if (head.type == ModContent.ItemType<OmegaBlueHelmet>() && body.type == ModContent.ItemType<OmegaBlueChestplate>() && legs.type == ModContent.ItemType<OmegaBlueTentacles>())
		{
			return "OmegaBlue";
		}
		if (head.type == ModContent.ItemType<PlaguebringerVisor>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
		{
			return "PlaguebringerSummon";
		}
		if (head.type == ModContent.ItemType<PlagueReaperMask>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
		{
			return "PlaguebringerRanged";
		}
		if (head.type == ModContent.ItemType<PrismaticHelmet>() && body.type == ModContent.ItemType<PrismaticRegalia>() && legs.type == ModContent.ItemType<PrismaticGreaves>())
		{
			return "Prismatic";
		}
		if (head.type == ModContent.ItemType<ReaverHeadExplore>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverExplore";
		}
		if (head.type == ModContent.ItemType<ReaverHeadMobility>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverMobility";
		}
		if (head.type == ModContent.ItemType<ReaverHeadTank>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverTank";
		}
		if (head.type == ModContent.ItemType<ShroomiteVisage>() && body.type == 1549 && legs.type == 1550)
		{
			return "ShroomiteCalam";
		}
		if (head.type == ModContent.ItemType<SilvaHeadSummon>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaSummon";
		}
		if (head.type == ModContent.ItemType<SilvaHeadMagic>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaMagic";
		}
		if (head.type == ModContent.ItemType<SnowRuffianMask>() && body.type == ModContent.ItemType<SnowRuffianChestplate>() && legs.type == ModContent.ItemType<SnowRuffianGreaves>())
		{
			return "SnowRuffian";
		}
		if (head.type == ModContent.ItemType<StatigelHeadMagic>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMagic";
		}
		if (head.type == ModContent.ItemType<StatigelHeadRanged>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRanged";
		}
		if (head.type == ModContent.ItemType<StatigelHeadMelee>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMelee";
		}
		if (head.type == ModContent.ItemType<StatigelHeadSummon>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelSummon";
		}
		if (head.type == ModContent.ItemType<StatigelHeadRogue>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRogue";
		}
		if (head.type == ModContent.ItemType<SulphurousHelmet>() && body.type == ModContent.ItemType<SulphurousBreastplate>() && legs.type == ModContent.ItemType<SulphurousLeggings>())
		{
			return "Sulfur";
		}
		if (head.type == ModContent.ItemType<TarragonHeadMelee>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMelee";
		}
		if (head.type == ModContent.ItemType<TarragonHeadRogue>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonRogue";
		}
		if (head.type == ModContent.ItemType<TarragonHeadSummon>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonSummon";
		}
		if (head.type == ModContent.ItemType<TarragonHeadMagic>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMagic";
		}
		if (head.type == ModContent.ItemType<TarragonHeadRanged>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonRanged";
		}
		if (head.type == ModContent.ItemType<TitanHeartMask>() && body.type == ModContent.ItemType<TitanHeartMantle>() && legs.type == ModContent.ItemType<TitanHeartBoots>())
		{
			return "TitanHeart";
		}
		if (head.type == ModContent.ItemType<UmbraphileHood>() && body.type == ModContent.ItemType<UmbraphileRegalia>() && legs.type == ModContent.ItemType<UmbraphileBoots>())
		{
			return "Umbraphile";
		}
		if (head.type == ModContent.ItemType<VictideHeadRogue>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
		{
			return "VictideRogue";
		}
		if (head.type == ModContent.ItemType<VictideHeadMelee>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
		{
			return "VictideMelee";
		}
		if (head.type == ModContent.ItemType<VictideHeadSummon>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
		{
			return "VictideSummon";
		}
		if (head.type == ModContent.ItemType<VictideHeadMagic>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
		{
			return "VictideMagic";
		}
		if (head.type == ModContent.ItemType<VictideHeadRanged>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
		{
			return "VictideRanged";
		}
		
		if (head.type == ModContent.ItemType<WulfrumHat>() && body.type == ModContent.ItemType<WulfrumJacket>() && legs.type == ModContent.ItemType<WulfrumOveralls>())
		{
			return "WulfrumSummon";
		}
		if (head.type == ModContent.ItemType<EmpyreanMask>() && body.type == ModContent.ItemType<EmpyreanCloak>() && legs.type == ModContent.ItemType<EmpyreanCuisses>())
		{
			return "Xeroc";
		}
		if (head.type == ModContent.ItemType<GemTechHeadgear>() && body.type == ModContent.ItemType<GemTechBodyArmor>() && legs.type == ModContent.ItemType<GemTechSchynbaulds>())
		{
			return "Gemtech";
		}
		//Original Code from Calamity - May be unneccesary
		/*
		if (head.type == 89 && body.type == 80 && legs.type == 76)
		{
			return "Copper";
		}
		if (head.type == 687 && body.type == 688 && legs.type == 689)
		{
			return "Tin";
		}
		if ((head.type == 90 || head.type == 954) && body.type == 81 && legs.type == 77)
		{
			return "Iron";
		}
		if (head.type == 690 && body.type == 691 && legs.type == 692)
		{
			return "Lead";
		}
		if (head.type == 91 && body.type == 82 && legs.type == 78)
		{
			return "Silver";
		}
		if (head.type == 693 && body.type == 694 && legs.type == 695)
		{
			return "Tungsten";
		}
		if ((head.type == 92 || head.type == 955) && body.type == 83 && legs.type == 79)
		{
			return "Gold";
		}
		if (head.type == 696 && body.type == 697 && legs.type == 698)
		{
			return "Platinum";
		}
		if (head.type == 3187 && body.type == 3188 && legs.type == 3189)
		{
			return "Gladiator";
		}
		if (head.type == 3266 && body.type == 3267 && legs.type == 3268)
		{
			return "Obsidian";
		}
		if (head.type == 231 && body.type == 232 && legs.type == 233)
		{
			return "Molten";
		}
		if ((head.type == 803 || head.type == 978) && (body.type == 804 || body.type == 979) && (legs.type == 805 || legs.type == 980))
		{
			return "Eskimo";
		}
		if (head.type == 123 && body.type == 124 && legs.type == 125)
		{
			return "Meteor";
		}
		if (head.type == 736 && body.type == 737 && legs.type == 738)
		{
			return "Pearlwood";
		}
		*/
		return "";
	}
	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
		
		//Attunement replace for biome blade line -- Datastructures Attunement 1.5

		//Ark line replacement
		if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Clic droit pour brandir l'arche en face de vous. Toucher un ennemi avec effectuera une parade, vous donnant une courte période d'invincibilité");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 160 less damage", "Vous pouvez aussi parer les projectiles pour réduire temporairement leurs dégâts de 160");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw stronger projectiles", "Parer charge l'épée et améliore les 10 prochains coups de l'arme, augmentant ses dégâts et la puissance de ses projectiles");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will release all the charges in a powerful burst of energy", "Clic droit en maintenant haut quand l'arche est chargée relachera toutes les charges dans une puissante explosion d'énergie");
			}
		}

		if (item.type == ModContent.ItemType<FracturedArk>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Clic droit pour brandir l'arche en face de vous. Toucher un ennemi avec effectuera une parade, vous donnant une courte période d'invincibilité");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 100 less damage", "Vous pouvez aussi parer les projectiles pour réduire temporairement leurs dégâts de 100");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw projectiles out", "Parer charge l'épée et améliore les 10 prochains coups de l'arme, ce qui augmente ses dégâts et lui permet de lancer des projectiles");
			}
		}

		if (item.type == ModContent.ItemType<ArkoftheCosmos>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Performs a combo of swings, alternating between narrow and wide swings and throwing the blade out every 5 swings", "Effectue un enchainement de coups, en alternant avec des coups larges et serrés, et en lancant la lame tous les 5 coups");
				line.Text = line.Text.Replace("The thrown blade is held in place by constellations and will follow your cursor", "La lame lancée est maintenue par les constellations et suivra votre curseur");
				line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap and explode into stars", "Relâcher la souris quand la lame est lancée lancera la seconde lame, faisant claquer les ciseaux et provoquant une explosion stellaire");
				line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you.", "Clic droit pour faire claquer les lames en ciseaux en face de vous");
				line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Toucher un ennemi avec effectuera une parade, vous donnant une courte période d'invincibilité");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "Vous pouvez aussi parer les projectiles pour réduire temporairement leurs dégâts de 200");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "Parer charge l'épée et améliore les 10 prochains coups de l'arme, vous permettant d'utiliser les deux lames en même temps");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "Clic droit en maintenant haut quand l'arche est chargée pour déchirer l'espace-temps en consommant vos charges");
				line.Text = line.Text.Replace("If more than half the charges were used up, you can dash across the rip by keeping the up key pressed down", "Si vous avez utilisé plus de la moitié de vos charges, vous pouvez foncer le long de la déchirure en maintenant bas");
			}
		}

		if (item.type == ModContent.ItemType<ArkoftheElements>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Performs a combo of swings, throwing the blade out every 5 swings", "Effectue un enchainement de coups et lance la lame tous les 5 coups");
				line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap", "Relâcher la souris quand la lame est lancée lancera la seconde lame, faisant claquer les ciseaux");
				line.Text = line.Text.Replace("Snapping the scissors together increase their damage and empower your next two swings", "Claquer les ciseaux augmente leurs dégâts et charge vos deux prochains coups");
				line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you", "Clic droit pour faire claquer les lames en ciseaux en face de vous");
				line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Toucher un ennemi avec effectuera une parade, vous donnant une courte période d'invincibilité");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "Vous pouvez aussi parer les projectiles pour réduire temporairement leurs dégâts de 200");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "Parer charge l'épée et améliore les 10 prochains coups de l'arme, vous permettant d'utiliser les deux lames en même temps");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "");
			}
		}

		if (item.type == ModContent.ItemType<ExoThrone>()) {
			foreach (TooltipLine line in tooltips)
			{
				string hotkey3 = CalamityKeybinds.ExoChairSpeedupHotkey.TooltipHotkeyString();
				string hotkey2 = CalamityKeybinds.ExoChairSlowdownHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Hold " + hotkey3 + " while sitting in the throne to move much faster", "Restez appuyé sur " + hotkey3 + " en étant assis sur le trône pour aller bien plus vite");
				line.Text = line.Text.Replace("And hold " + hotkey2 + " to move much slower", "Et restez appuyé sur "+ hotkey2 +" pour aller bien plus lentement");
			}
		}

		if (item.type == ModContent.ItemType<DraedonsHeart>())
		{
			string fullAdrenDRString = (100f * (float)typeof(BalancingConstants).GetField("FullAdrenalineDR", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null)).ToString("n0");
			int lineNumber = 0;
			int lineAmount = tooltips.Count;
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("15% reduced contact damage from enemies", "15% de réduction des dégâts de contact");
				line.Text = line.Text.Replace("Reduces defense damage taken by 50%", "Réduit les dégâts d'armure de 50%");
				line.Text = line.Text.Replace("Replaces Adrenaline with the Nanomachines meter", "Remplace l'adrénaline avec les nanomachines");
				line.Text = line.Text.Replace("Unlike Adrenaline, you lose no Nanomachines when you take damage, but they stop accumulating for", "Contrairement à l'adrénaline, vous ne perdez pas de nanomachines quand vous prenez des dégâts, mais elles cessent de s'accumuler durant");
				line.Text = line.Text.Replace("With full Nanomachines, press", "Une fois les nanomachines pleines, appuyez sur");
				line.Text = line.Text.Replace("to heal", "pour récupérer");
				line.Text = line.Text.Replace("health over", "points de vie en");
				line.Text = line.Text.Replace("While healing, you take", "Durant le soin, vous prenez");
				line.Text = line.Text.Replace("less damage", "de dégâts en moins");
				line.Text = line.Text.Replace("Nanomachines, son.", "Les nanomachines, fiston");
				line.Text = line.Text.Replace("Adds the Nanomachines meter", "Ajoute la jauge de Nanomachines");
				line.Text = line.Text.Replace("Taking damage stops the accumulation for", "Prendre des dégâts stoppe l'accumulation durant");
				line.Text = line.Text.Replace("seconds", "secondes");
				line.Text = line.Text.Replace("second", "seconde");
				line.Text = line.Text.Replace("Nanomachines accumulate over time while fighting bosses", "Les nanomachines s'accumulent au fur et à mesure quand vous combattez des boss");
				//Fix because calamity is broken, fml
				if (lineNumber == lineAmount - 2) {
					line.Text = "Durant le soin, vous prenez " + fullAdrenDRString + "% de dégâts en moins";
				}
				lineNumber++;
			}
		}
		/*
		//Specific Item Modification
		if (CalamityWorld.death)
		{
			if (item.type == ModContent.ItemType<XerocMask>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava", "Immunité temporaire à la lave");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TarragonHelm>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("10% increased melee damage and critical strike chance", "+10% de dégâts et de chances de coup critique de mêlée");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TarragonHornedHelm>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("5% increased damage reduction and +3 max minions", "+5% de réduction de dégâts et +3 sbires max");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TarragonMask>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("5% increased damage reduction, +100 max mana, and 15% reduced mana usage", "+5% de réduction de dégâts, +100 mana maximum et 15% de réduction du coût en mana");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TarragonVisage>() || item.type == ModContent.ItemType<TarragonHelmet>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("5% increased damage reduction", "+5% de réduction des dégâts");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BloodflareHelm>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("10% increased rogue damage and critical strike chance, 15% increased movement speed", "+10% de dégâts et de chances de coup critique de voleur et +15% de vitesse de mouvement");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BloodflareHelmet>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("+3 max minions", "+3 sbires max");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BloodflareHornedHelm>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("10% increased ranged damage and critical strike chance", "+10% de dégâts et de chances de coup critique à distance");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BloodflareHornedMask>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("10% increased magic damage and critical strike chance, +100 max mana, and 17% reduced mana usage", "+10% de dégâts et de chances de coup critique magique, +100 mana maximum, et 17% de réduction du coût de mana");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BloodflareMask>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("10% increased melee damage and critical strike chance", "+10% de dégâts et de chances de coup critique de mêlée");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<AuricTeslaBodyArmor>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("You will freeze enemies near you when you are struck", "Vous gelez les ennemis proches quand vous êtes touché");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<AtaxiaMask>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava and immunity to fire damage", "+100 mana maximum, immunité temporaire à la lave, et immunité aux dégâts de feu");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<AtaxiaHeadgear>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage", "Réduit la consommation de munitions de 25%, immunité temporaire à la lave, et immunité aux dégâts de feu");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<AtaxiaHood>() || item.type == ModContent.ItemType<AtaxiaHelmet>() || item.type == ModContent.ItemType<AtaxiaHelm>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava and immunity to fire damage", "Immunité temporaire à la lave et immunité aux dégâts de feu");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<SoulofCryogen>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Icicles rain down as you fly", "Des stalagtites pleuvent lorsque vous volez");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<ElysianWings>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava and 40% increased movement speed", "Immunité temporaire à la lave et +40% de vitesse de mouvement");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<ElysianTracers>() || item.type == ModContent.ItemType<InfinityBoots>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava", "Immunité temporaire à la lave");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<CelestialTracers>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Being hit for over 200 damage will make you immune for an extended period of time", "Subir plus de 200 dégâts prolongera grandement votre période d'invincibilité");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<Popo>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Transforms the holder into a snowman", "Vous transforme en bonhomme de neige");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<YharimsInsignia>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Increased melee knockback", "Augmente le recul des attaques de corps à corps");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<VoidofExtinction>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava, greatly reduces lava burn damage, and 25% increased damage while in lava", "Immunité temporaire à la lave, réduit grandement les dégâts de la brûlure de lave et augmente les dégâts de 25% quand vous êtes dans la lave");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TheCamper>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Provides a small amount of light in the Abyss", "Émet une petite quantité de lumière dans les abysses");
					line.Text = line.Text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<TheAmalgam>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("You have a damaging aura that envenoms nearby enemies and increased movement in liquids", "Vous émettez une aura nocive qui envenime les ennemis et votre mouvement est augmenté quand vous êtes immergé");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<Sponge>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Enemy attacks will have part of their damage absorbed and used to heal you", "Une partie des dégâts infligés par les ennemis sera absorbée et rendue sous forme de points de vie");
					line.Text = line.Text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<PermafrostsConcoction>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("You are encased in an ice barrier for 3 seconds when revived", "Vous êtes prisonnier d'une barrière de glace pendant 3 secondes lorsque cet effet s'active");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<FrostFlare>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
					line.Text = line.Text.Replace("Revengeance drop", "Revengeance");
				}
			}
			if (item.type == ModContent.ItemType<FrostBarrier>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("You are immune to the chilled debuff", "Immunité au refroidissement");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<FrigidBulwark>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("The shell becomes more powerful when below 15% life and reduces damage even further", "La carapace se renforce en dessous de 15% de vie et réduit encore plus les dégâts");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<ElementalGauntlet>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Recul des attaques de corps à corps augmenté", "Recul des attaques de corps à corps augmenté\nProtège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<BlazingCore>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Provides a moderate amount of light in the Abyss", "Émet une quantité modérée de lumière dans les abysses");
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<AngelTreads>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Temporary immunity to lava", "Immunité temporaire à la lave");
					line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
				}
			}

			if (item.type == ModContent.ItemType<AmbrosialAmpoule>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Most bee/hornet enemies and projectiles do 75% damage to you", "La plupart des abeilles/frelons ne vous infligent plus que 75% de dégâts");
					line.Text = line.Text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
				}
			}
			if (item.type == ModContent.ItemType<PurifiedJam>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Makes you immune to all damage and most debuffs for 5 seconds", "Vous immunise contre tous les dégâts et la plupart des altérations d'état pendant 5 secondes");
				}
			}
			if (item.type == ModContent.ItemType<ColdDivinity>())
			{
				foreach (TooltipLine line in tooltips)
				{
					line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode when is use", "Protège contre le froid et la chaleur en mode Mort quand vous l'utilisez");
					line.Text = line.Text.Replace("Revengeance Drop", "Revengeance");
				}
			}
		}
		*/

		if (item.type == ModContent.ItemType<AbandonedSlimeStaff>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Holding this weapon grants", "Tenir cette arme augmente votre vitesse de saut de");
				line.Text = line.Text.Replace(" increased jump speed", " d'augmentation de vitesse de saut");
			}
		}
		if (item.type == ModContent.ItemType<Eternity>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("There's pictures of ponies in the book", "Il y a des images de poneys dans le livre");
			}
		}
		if (item.type == ModContent.ItemType<CosmicWorm>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "ATTENTION! Certaines sentinelles n'ont pas encore été vaincues et apparaîtront à pleine puissance durant ce combat!");
			}
		}
		if (item.type == ModContent.ItemType<HadalStew>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Only gives 37 seconds of Potion Sickness", "Provoque seulement 37s de potion affaiblie");
			}
		}
		if (item.type == ModContent.ItemType<KnowledgeKingSlime>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Favorite this item to gain 5% increased movement speed and 2% increased jump speed.", "Favorisez cet objet pour gagner 5% de vitesse de mouvement et 2% de vitesse de saut.");
				line.Text = line.Text.Replace("Favorite this item to gain 5% increased movement speed.", "Favorisez cet objet pour gagner 5% de vitesse de mouvement.");
			}
		}
		/*if (item.type == ModContent.ItemType<RevengeanceModeItem>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Enables the Rage mechanic. When Rage is maxed press", "Active la mécanique de rage. Quand la jauge de rage est remplie, appuyez sur");
				line.Text = line.Text.Replace("to activate Rage Mode.", " pour activer le mode rage.");
				line.Text = line.Text.Replace("Enables the Adrenaline mechanic. When Adrenaline is maxed press", "Active la mécanique d'adrénaline. Quand la jauge d'adrénaline est remplie, appuyez sur");
				line.Text = line.Text.Replace("to activate Adrenaline Mode.", "pour activer le mode adrénaline.");
			}
		}*/
		if (item.type == ModContent.ItemType<VitalJelly>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string jumpAmtVJelly = Main.player[Main.myPlayer].autoJump ? "6" : "24";
				line.Text = line.Text.Replace(jumpAmtVJelly + "% increased jump speed", "+" + jumpAmtVJelly + "% de vitesse de saut");
			}
		}
		if (item.type == ModContent.ItemType<SpectralVeil>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeySpecVeil = CalamityMod.CalamityKeybinds.SpectralVeilHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeySpecVeil + " to consume 25% of your maximum stealth to perform a short range teleport and render you momentarily invulnerable", "Appuyez sur " + hotkeySpecVeil + " pour consommer 25% de votre furtivité maximum pour vous téléporter à courte portée et vous rendre momentanément invulnérable");
			}
		}
		if (item.type == ModContent.ItemType<SandCloak>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeySand = CalamityMod.CalamityKeybinds.SandCloakHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeySand + " to consume 25% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", "Appuyez sur " + hotkeySand + " pour consommer 25% de votre furtivité maximum pour créer un voile de poussière qui donne +6 défense et +2 régénération de vie");
			}
		}
		if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "L'âme à l'intérieur de ce cristal a été corrompu par la puissante magie d'une sorcière suprême");
				line.Text = line.Text.Replace("Merchants will reject a defiled soul such as this.", "Les marchants rejeteront une âme corrompue comme celle-ci");
				line.Text = line.Text.Replace("Transforms Magic attacks into a powerful splitting fireball for", "Transforme les attaques magiques en une puissante boule de feu qui se divise pour");
				line.Text = line.Text.Replace("mana per cast", "mana");
			}
		}
		if (item.type == ModContent.ItemType<PlaguedFuelPack>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string plagueHotkey = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + plagueHotkey + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", "Appuyez sur " + plagueHotkey + " pour consommer 25% de votre furtivité maximum pour effectuer une rapide ruée ascendante/diagonale qui laisse une trainée de nuages pestiférés");
			}
		}
		if (item.type == ModContent.ItemType<Nanotech>() || item.type == ModContent.ItemType<RaidersTalisman>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Rogue Crit Level:", "Cumuls actuels:");
			}
		}
		if (item.type == ModContent.ItemType<GrandGelatin>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string jumpAmtGelatin = Main.player[Main.myPlayer].autoJump ? "10" : "40";
				line.Text = line.Text.Replace(jumpAmtGelatin + "% increased jump speed", "+" + jumpAmtGelatin + "% de vitesse de saut");
			}
		}
		if (item.type == ModContent.ItemType<CelestialJewel>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeyCelestial = CalamityMod.CalamityKeybinds.AstralTeleportHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyCelestial + " to teleport to a random location", "Appuyez sur " + hotkeyCelestial + " pour vous téléporter à un endroit aléatoire");
			}
		}

		if (item.type == ModContent.ItemType<BlunderBooster>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeyBlunder = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyBlunder + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", "Appuyez sur " + hotkeyBlunder + " pour consommer 25% de votre furtivité maximum pour effectuer une rapide ruée ascendante/diagonale qui laisse une trainée de décharges électriques");
			}
		}

		if (item.type == ModContent.ItemType<AstralArcanum>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeyArcanum = CalamityMod.CalamityKeybinds.AstralArcanumUIHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyArcanum + " to toggle teleportation UI", "Appuyez sur " + hotkeyArcanum + " pour afficher/cacher l'interface de téléportation");
			}
		}

		if (item.type == ModContent.ItemType<AsgardianAegis>() || item.type == ModContent.ItemType<ElysianAegis>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeyAsgard = CalamityMod.CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyAsgard + " to activate buffs to all damage, crit chance, and defense", "Appuyez sur " + hotkeyAsgard + " pour améliorer tous vos dégâts, vos chances de coup critique et votre défense");
			}
		}

		if (item.type == ModContent.ItemType<AeroStone>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string jumpAmt = Main.player[Main.myPlayer].autoJump ? "5" : "20";
				line.Text = line.Text.Replace("Increases movement speed by 10%, jump speed by " + jumpAmt + "%, and all damage by 3%", "Augmente la vitesse de mouvement de 10%, la vitesse de saut de " + jumpAmt + "% et tous les dégâts de 3%");
			}
		}

		if (item.type == ModContent.ItemType<NormalityRelocator>())
		{
			foreach (TooltipLine line in tooltips)
			{
				string hotkeyReloc = CalamityMod.CalamityKeybinds.NormalityRelocatorHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyReloc + " to teleport to the position of the mouse", "Appuyez sur " + hotkeyReloc + " pour vous téléporter à l'emplacement du curseur");
			}
		}
		/* Stat meters have been merged into generic Stat Meter
		if (item.type == ModContent.ItemType<MagicLevelMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Tells you how high your magic proficiency is", "Vous donne votre niveau de compétence magique");
				line.Text = line.Text.Replace("While equipped you will gain magic proficiency faster", "Votre niveau de compétence magique augmentera plus vite si vous équippez cet accessoire");
				line.Text = line.Text.Replace("The higher your magic level the higher your magic damage, critical strike chance, and the lower your mana cost", "Au plus votre compétence est élevée, au plus vos dégâts magiques, vos chances de coup critique magique augmentent et vos coûts en mana diminuent");
				line.Text = line.Text.Replace("Magic proficiency (max of 12500):", "Compétence maximum (12500 max):");
				line.Text = line.Text.Replace("Magic level (max of 15):", "Niveau de compétence (15 max):");
				line.Text = line.Text.Replace("Magic damage increase:", "Augmentation des dégâts magiques:");
				line.Text = line.Text.Replace("Mana usage decrease:", "Diminution du coût en mana:");
				line.Text = line.Text.Replace("Magic crit increase:", "Augmentation des chances de coup critique magique:");
			}
		}
		if (item.type == ModContent.ItemType<MeleeLevelMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Tells you how high your melee proficiency is", "Vous donne votre niveau de compétence de mêlée");
				line.Text = line.Text.Replace("While equipped you will gain melee proficiency faster", "Votre niveau de compétence de mêlée augmentera plus vite si vous équippez cet accessoire");
				line.Text = line.Text.Replace("The higher your melee level the higher your melee damage, speed, and critical strike chance", "Au plus votre compétence est élevée, au plus vos dégâts, vos chances de coup critique et votre vitesse de mêlée augmentent");
				line.Text = line.Text.Replace("Melee proficiency (max of 12500):", "Compétence maximum (12500 max):");
				line.Text = line.Text.Replace("Melee level (max of 15):", "Niveau de compétence (15 max):");
				line.Text = line.Text.Replace("Melee damage increase:", "Augmentation des dégâts de mêlée:");
				line.Text = line.Text.Replace("Melee speed increase:", "Augmentation de la vitesse de mêlée:");
				line.Text = line.Text.Replace("Melee crit increase:", "Augmentation des chances de coup critique de mêlée:");
			}
		}
		if (item.type == ModContent.ItemType<RangedLevelMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Tells you how high your ranged proficiency is", "Vous donne votre niveau de compétence à distance");
				line.Text = line.Text.Replace("While equipped you will gain ranged proficiency faster", "Votre niveau de compétence à distance augmentera plus vite si vous équippez cet accessoire");
				line.Text = line.Text.Replace("The higher your ranged level the higher your ranged damage, critical strike chance, and movement speed", "Au plus votre compétence est élevée, au plus vos dégâts à distance, vos chances de coup critique à distance et votre vitesse de mouvement augmentent");
				line.Text = line.Text.Replace("Ranged proficiency (max of 12500):", "Compétence maximum (12500 max):");
				line.Text = line.Text.Replace("Ranged level (max of 15):", "Niveau de compétence (15 max):");
				line.Text = line.Text.Replace("Ranged damage increase:", "Augmentation des dégâts à distance:");
				line.Text = line.Text.Replace("Movement speed increase:", "Augmentation de la vitesse de mouvement:");
				line.Text = line.Text.Replace("Ranged crit increase:", "Augmentation des chances de coup critique à distance:");
			}
		}
		if (item.type == ModContent.ItemType<RogueLevelMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Tells you how high your rogue proficiency is", "Vous donne votre niveau de compétence de voleur");
				line.Text = line.Text.Replace("While equipped you will gain rogue proficiency faster", "Votre niveau de compétence de voleur augmentera plus vite si vous équippez cet accessoire");
				line.Text = line.Text.Replace("The higher your rogue level the higher your rogue damage, critical strike chance, and velocity", "Au plus votre compétence est élevée, au plus vos dégâts, vos chances de coup critique et la vitesse des projectiles de voleur augmentent");
				line.Text = line.Text.Replace("Rogue proficiency (max of 12500):", "Compétence maximum (12500 max):");
				line.Text = line.Text.Replace("Rogue level (max of 15):", "Niveau de compétence (15 max):");
				line.Text = line.Text.Replace("Rogue damage increase:", "Augmentation des dégâts de voleur:");
				line.Text = line.Text.Replace("Rogue velocity increase:", "Augmentation de la vitesse des projectiles de voleur:");
				line.Text = line.Text.Replace("Rogue crit increase:", "Augmentation des chances de coup critique de voleur:");
			}
		}
		if (item.type == ModContent.ItemType<SummonLevelMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Tells you how high your summon proficiency is", "Vous donne votre niveau de compétence d'invocation");
				line.Text = line.Text.Replace("While equipped you will gain summon proficiency faster", "Votre niveau de compétence d'invocation augmentera plus vite si vous équippez cet accessoire");
				line.Text = line.Text.Replace("The higher your summon level the higher your minion damage, knockback, and slots", "Au plus votre compétence est élevée, au plus vos dégâts de sbires, le recul des sbires et les emplacements de sbires augmentent");
				line.Text = line.Text.Replace("Summon proficiency (max of 12500):", "Compétence maximum (12500 max):");
				line.Text = line.Text.Replace("Summon level (max of 15):", "Niveau de compétence (15 max):");
				line.Text = line.Text.Replace("Minion damage increase:", "Augmentation des dégâts de sbires:");
				line.Text = line.Text.Replace("Minion knockback increase:", "Augmentation du recul des sbires:");
				line.Text = line.Text.Replace("Minion slot increase:", "Augmentation du nombre d'emplacements de sbires:");
			}
		}*/
		if (item.type == ModContent.ItemType<StatMeter>())
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Displays almost all player stats", "Affiche presque toutes les statistiques");
				line.Text = line.Text.Replace("Offensive stats displayed vary with held item", "Les statistiques offensives dépendent de l'arme tenue");
				line.Text = line.Text.Replace("Adrenaline Damage Boost:", "Dégâts du mode Adrénaline:");
				line.Text = line.Text.Replace("Adrenaline DR Boost:", "Réduction de dégâts du mode Adrénaline:");
				line.Text = line.Text.Replace("Rage Damage Boost:", "Dégâts du mode Rage");
				line.Text = line.Text.Replace("Melee Damage:", "Dégâts de mêlée:");
				line.Text = line.Text.Replace("True Melee Damage:", "Dégâts de vraie mêlée:");
				line.Text = line.Text.Replace("True Dégâts de mêlée:", "Dégâts de vraie mêlée:");
				line.Text = line.Text.Replace("Melee Crit Chance:", "Chances de coup critique en mêlée:");
				line.Text = line.Text.Replace("Melee Speed Boost:", "Vitesse en mêlée:");
				line.Text = line.Text.Replace("Ranged Damage:", "Dégâts à distance:");
				line.Text = line.Text.Replace("Ranged Crit Chance:", "Chances de critique à distance:");
				line.Text = line.Text.Replace("Ammo Consumption Chance:", "Chances de consommer des munitions");
				line.Text = line.Text.Replace("Magic Damage:", "Dégâts magiques:");
				line.Text = line.Text.Replace("Magic Crit Chance:", "Chances de coup critique magique:");
				line.Text = line.Text.Replace("Mana Usage:", "Coût en mana:");
				line.Text = line.Text.Replace("Mana Regen:", "Régénération du mana:");
				line.Text = line.Text.Replace("Minion Damage:", "Dégâts des sbires:");
				line.Text = line.Text.Replace("Minion Slots:", "Emplacements de sbires:");
				line.Text = line.Text.Replace("Rogue Damage:", "Dégâts de voleur:");
				line.Text = line.Text.Replace("Rogue Crit Chance:", "Chances de critique de voleur:");
				line.Text = line.Text.Replace("Rogue Velocity Boost:", "Vitesse des projectiles de voleur:");
				line.Text = line.Text.Replace("Rogue Weapon Consumption Chance:", "Chances de consommer une arme de voleur:");
				line.Text = line.Text.Replace("Max Stealth:", "Furtivité max:");
				line.Text = line.Text.Replace("Standing Regen:", "Régénération immobile de furtivité:");
				line.Text = line.Text.Replace("Moving Regen:", "Régénération de furtivité en mouvement:");
				line.Text = line.Text.Replace("Defense:", "Défense");
				line.Text = line.Text.Replace("DR:", "Réduction des dégâts:");
				line.Text = line.Text.Replace("Life Regen:", "Régénération de vie:");
				line.Text = line.Text.Replace("Armor Penetration:", "Pénétration d'armure:");
				line.Text = line.Text.Replace("Wing Flight Time:", "Temps de vol:");
				line.Text = line.Text.Replace("seconds", "secondes");
				line.Text = line.Text.Replace("Jump Speed Boost:", "Vitesse de saut:");
				line.Text = line.Text.Replace("Movement Speed Boost:", "Vitesse de mouvement:");
				line.Text = line.Text.Replace("Abyss/Cave Light Strength:", "Lumière émise dans les souterrains/abysses:");
				line.Text = line.Text.Replace("Abyss Light Strength:", "Lumière émise dans les abysses:");
				line.Text = line.Text.Replace("Other Abyss stats are only displayed while in the Abyss", "Les autres statistiques en rapport avec les abysses s'affichent quand vous êtes dans les abysses");
				line.Text = line.Text.Replace("Other Abyss Stats:", "Autres stats des abysses:");
				line.Text = line.Text.Replace("Breath Lost Per Tick:", "Perte de respiration par tic:");
				line.Text = line.Text.Replace("Breath Loss Rate:", "Taux de perte de respiration:");
				line.Text = line.Text.Replace("Life Lost Per Tick at Zero Breath:", "Vie perdue par tic à 0 respiration:");
				line.Text = line.Text.Replace("Defense Lost:", "Défense perdue:");

                // DIRTY DIRTY Fix
                line.Text = line.Text.Replace("Tells you how high your magic proficiency is", "Vous donne votre niveau de compétence magique");
                line.Text = line.Text.Replace("While equipped you will gain magic proficiency faster", "Votre niveau de compétence magique augmentera plus vite si vous équippez cet accessoire");
                line.Text = line.Text.Replace("The higher your magic level the higher your magic damage, critical strike chance, and the lower your mana cost", "Au plus votre compétence est élevée, au plus vos dégâts magiques, vos chances de coup critique magique augmentent et vos coûts en mana diminuent");
                line.Text = line.Text.Replace("Magic proficiency (max of 12500):", "Compétence maximum (12500 max):");
                line.Text = line.Text.Replace("Magic level (max of 15):", "Niveau de compétence (15 max):");
                line.Text = line.Text.Replace("Magic damage increase:", "Augmentation des dégâts magiques:");
                line.Text = line.Text.Replace("Mana usage decrease:", "Diminution du coût en mana:");
                line.Text = line.Text.Replace("Magic crit increase:", "Augmentation des chances de coup critique magique:");
                line.Text = line.Text.Replace("Tells you how high your melee proficiency is", "Vous donne votre niveau de compétence de mêlée");
                line.Text = line.Text.Replace("While equipped you will gain melee proficiency faster", "Votre niveau de compétence de mêlée augmentera plus vite si vous équippez cet accessoire");
                line.Text = line.Text.Replace("The higher your melee level the higher your melee damage, speed, and critical strike chance", "Au plus votre compétence est élevée, au plus vos dégâts, vos chances de coup critique et votre vitesse de mêlée augmentent");
                line.Text = line.Text.Replace("Melee proficiency (max of 12500):", "Compétence maximum (12500 max):");
                line.Text = line.Text.Replace("Melee level (max of 15):", "Niveau de compétence (15 max):");
                line.Text = line.Text.Replace("Melee damage increase:", "Augmentation des dégâts de mêlée:");
                line.Text = line.Text.Replace("Melee speed increase:", "Augmentation de la vitesse de mêlée:");
                line.Text = line.Text.Replace("Melee crit increase:", "Augmentation des chances de coup critique de mêlée:");
                line.Text = line.Text.Replace("Tells you how high your ranged proficiency is", "Vous donne votre niveau de compétence à distance");
                line.Text = line.Text.Replace("While equipped you will gain ranged proficiency faster", "Votre niveau de compétence à distance augmentera plus vite si vous équippez cet accessoire");
                line.Text = line.Text.Replace("The higher your ranged level the higher your ranged damage, critical strike chance, and movement speed", "Au plus votre compétence est élevée, au plus vos dégâts à distance, vos chances de coup critique à distance et votre vitesse de mouvement augmentent");
                line.Text = line.Text.Replace("Ranged proficiency (max of 12500):", "Compétence maximum (12500 max):");
                line.Text = line.Text.Replace("Ranged level (max of 15):", "Niveau de compétence (15 max):");
                line.Text = line.Text.Replace("Ranged damage increase:", "Augmentation des dégâts à distance:");
                line.Text = line.Text.Replace("Movement speed increase:", "Augmentation de la vitesse de mouvement:");
                line.Text = line.Text.Replace("Ranged crit increase:", "Augmentation des chances de coup critique à distance:");
                line.Text = line.Text.Replace("Tells you how high your rogue proficiency is", "Vous donne votre niveau de compétence de voleur");
                line.Text = line.Text.Replace("While equipped you will gain rogue proficiency faster", "Votre niveau de compétence de voleur augmentera plus vite si vous équippez cet accessoire");
                line.Text = line.Text.Replace("The higher your rogue level the higher your rogue damage, critical strike chance, and velocity", "Au plus votre compétence est élevée, au plus vos dégâts, vos chances de coup critique et la vitesse des projectiles de voleur augmentent");
                line.Text = line.Text.Replace("Rogue proficiency (max of 12500):", "Compétence maximum (12500 max):");
                line.Text = line.Text.Replace("Rogue level (max of 15):", "Niveau de compétence (15 max):");
                line.Text = line.Text.Replace("Rogue damage increase:", "Augmentation des dégâts de voleur:");
                line.Text = line.Text.Replace("Rogue velocity increase:", "Augmentation de la vitesse des projectiles de voleur:");
                line.Text = line.Text.Replace("Rogue crit increase:", "Augmentation des chances de coup critique de voleur:");
                line.Text = line.Text.Replace("Tells you how high your summon proficiency is", "Vous donne votre niveau de compétence d'invocation");
                line.Text = line.Text.Replace("While equipped you will gain summon proficiency faster", "Votre niveau de compétence d'invocation augmentera plus vite si vous équippez cet accessoire");
                line.Text = line.Text.Replace("The higher your summon level the higher your minion damage, knockback, and slots", "Au plus votre compétence est élevée, au plus vos dégâts de sbires, le recul des sbires et les emplacements de sbires augmentent");
                line.Text = line.Text.Replace("Summon proficiency (max of 12500):", "Compétence maximum (12500 max):");
                line.Text = line.Text.Replace("Summon level (max of 15):", "Niveau de compétence (15 max):");
                line.Text = line.Text.Replace("Minion damage increase:", "Augmentation des dégâts de sbires:");
                line.Text = line.Text.Replace("Minion knockback increase:", "Augmentation du recul des sbires:");
                line.Text = line.Text.Replace("Minion slot increase:", "Augmentation du nombre d'emplacements de sbires:");
            }
		}
		
		
		//Pêut-être plus nécessaire, a voir
		if (item.DamageType == DamageClass.Melee)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("true melee damage", "dégâts de vraie mêlée");
			}
		}
		//Global Item Modifications

		if (item.type >= 3930 && (item.Calamity()?.UsesCharge ?? false))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Current Charge:", "Batterie Restante:");
			}
		}
		//Ignoble, mais fonctionne, a remplacer plus tard
		if (DamageClass.Equals(item.DamageType, ModLoader.GetMod("CalamityMod").Find<ModItem>("ThrowingBrick").Item.DamageType))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("rogue damage", "dégâts de voleur");
				line.Text = line.Text.Replace("stealth strike damage", "dégâts d'attaque furtive");

				if (item.prefix > 0 && line.Name == "ItemName")
				{
					line.Text = line.Text.Contains("Flawless") ? line.Text.Replace("Flawless", "").Trim() + " (Parfait)" : line.Text;
					line.Text = line.Text.Contains("Pointy") ? line.Text.Replace("Pointy", "").Trim() + " (Pointu)" : line.Text;
					line.Text = line.Text.Contains("Sharp") ? line.Text.Replace("Sharp", "").Trim() + " (Tranchant)" : line.Text;
					line.Text = line.Text.Contains("Feathered") ? line.Text.Replace("Feathered", "").Trim() + " (À plumes)" : line.Text;
					line.Text = line.Text.Contains("Sleek") ? line.Text.Replace("Sleek", "").Trim() + " (Lisse)" : line.Text;
					line.Text = line.Text.Contains("Hefty") ? line.Text.Replace("Hefty", "").Trim() + " (Lourd)" : line.Text;
					line.Text = line.Text.Contains("Mighty") ? line.Text.Replace("Mighty", "").Trim() + " (Puissant)" : line.Text;
					line.Text = line.Text.Contains("Glorious") ? line.Text.Replace("Glorious", "").Trim() + " (Glorieux)" : line.Text;
					line.Text = line.Text.Contains("Serrated") ? line.Text.Replace("Serrated", "").Trim() + " (Denté)" : line.Text;
					line.Text = line.Text.Contains("Vicious") ? line.Text.Replace("Vicious", "").Trim() + " (Vicieux)" : line.Text;
					line.Text = line.Text.Contains("Lethal") ? line.Text.Replace("Lethal", "").Trim() + " (Fatal)" : line.Text;
					line.Text = line.Text.Contains("Radical") ? line.Text.Replace("Radical", "").Trim() + " (Radical)" : line.Text;
					line.Text = line.Text.Contains("Blunt") ? line.Text.Replace("Blunt", "").Trim() + " (Emoussé)" : line.Text;
					line.Text = line.Text.Contains("Flimsy") ? line.Text.Replace("Flimsy", "").Trim() + " (Fragile)" : line.Text;
					line.Text = line.Text.Contains("Unbalanced") ? line.Text.Replace("Unbalanced", "").Trim() + " (Déséquilibré)" : line.Text;
					line.Text = line.Text.Contains("Atrocious") ? line.Text.Replace("Atrocious", "").Trim() + " (Atroce)" : line.Text;
				}
			}
		}
		if (item.accessory && !item.social && item.prefix > 0)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Contains("Quiet") ? line.Text.Replace("Quiet", "").Trim() + " (Discret)" : line.Text;
				line.Text = line.Text.Contains("Cloaked") ? line.Text.Replace("Cloaked", "").Trim() + " (Voilé)" : line.Text;
				line.Text = line.Text.Contains("Camouflaged") ? line.Text.Replace("Camouflaged", "").Trim() + " (Camouflé)" : line.Text;
				line.Text = line.Text.Contains("Silent") ? line.Text.Replace("Silent", "").Trim() + " (Silencieux)" : line.Text;
				line.Text = line.Text.Replace("damage reduction", "de réduction des dégâts");
				line.Text = line.Text.Replace("critical strike chance", "de chances de coup critique");
				line.Text = line.Text.Replace("defense", "défense");
				line.Text = line.Text.Replace("stealth generation", "de génération de furtivité");

			}
		}

		if (item.type == 1134)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Grants the Honey buff for 2 minutes", "Accorde l'amélioration de Miel pendant 2 minutes");
			}
		}
		if (item.type == 1326)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Teleportation is disabled while Chaos State is active", "La téléportation est impossible que l'état Chaos est actif");
			}
		}
		if (item.type == 3032 || item.type == 205)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Cannot be used in the Abyss", "Inutilisable dans les abysses");
			}
		}
		if (item.type == 1183 || item.type == 3577)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides a large amount of light in the abyss", "Émet une grande quantité de lumière dans les abysses");
			}
		}
		List<int> litlleLightInAbyss = new List<int>() { 3062, 115, 3043, 1861, 1303, 1860, 88 };
		List<int> moderateLightInAbyss = new List<int>() { 425, 3856, 298 };
		List<int> moderateBreathLossInAbyss = new List<int>() { 1861, 268 };
		List<int> greatBreathLossInAbyss = new List<int>() { 291, 497, 861, 3110 };
		if (litlleLightInAbyss.Contains(item.type))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides a small amount of light in the abyss", "Émet une petite quantité de lumière dans les abysses");
			}
		}
		if (moderateLightInAbyss.Contains(item.type))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides a moderate amount of light in the abyss", "Émet une quantité modérée de lumière dans les abysses");
			}
		}
		if (moderateBreathLossInAbyss.Contains(item.type))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Moderately reduces breath loss in the abyss", "Réduit modérément la perte de respiration dans les abysses");
			}
		}
		if (greatBreathLossInAbyss.Contains(item.type))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Greatly reduces breath loss in the abyss", "Réduit grandement la perte de respiration dans les abysses");
			}
		}
		if (item.type == 2359)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Makes you immune to the Chilled, Frozen, and Glacial State debuffs", "Immunité au refroidissement et au gel");
				line.Text = line.Text.Replace("Provides cold protection in Death Mode", "Protège du froid en mode Mort");
			}
		}
		if (item.type == 1340)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks inflict Venom on enemies", "Les attaques de mêlée et de voleur infligent le venin sur les ennemis");
			}
		}
		if (item.type == 1353)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks inflict enemies with cursed flames", "Les attaques de mêlée et de voleur infligent les flammes maudites sur les ennemis");
			}
		}
		if (item.type == 1354)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks set enemies on fire", "Les attaques de mêlée et de voleur enflamment les ennemis");
			}
		}
		if (item.type == 1355)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks make enemies drop more gold", "Les attaques de mêlée et de voleur font tomber plus d'argent aux ennemis");
			}
		}
		if (item.type == 1356)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks decrease enemy defense", "Les attaques de mêlée et de voleur réduisent la défense des ennemis");
			}
		}
		if (item.type == 1357)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks confuse enemies", "Les attaques de mêlée et de voleur rendent les ennemis confus");
			}
		}
		if (item.type == 1358)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("All attacks cause confetti to appear", "Toutes les attaques font apparaître des confettis");
			}
		}
		if (item.type == 1359)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Melee and rogue attacks poison enemies", "Les attaques de mêlée et de voleur empoisonnent les ennemis");
			}
		}
		if (item.type == 3224)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Reduces damage taken by 10%", "Réduit les dégâts subis de 10%");
			}
		}
		if (item.type == 536 || item.type == 897 || item.type == 936)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("10% increased true melee damage", "Augmente les dégâts de vraie mêlée de 10%");
			}
		}
		if (item.type == 1343)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("14% increased melee damage and speed", "+14% de dégâts et de vitesse de mêlée");
				line.Text = line.Text.Replace("10% increased true melee damage", "+10% de dégâts de vraie mêlée");
				line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
		}
		if (item.type == 1503)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("20% decreased magic damage", "-20% de dégâts magiques");
			}
		}
		if (item.type == 288)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides immunity to direct damage from touching lava", "Immunité aux dégâts directs quand vous touchez la lave");
				line.Text = line.Text.Replace("Provides temporary immunity to lava burn damage", "Donne une immunité temporarire aux brûlures de lave");
				line.Text = line.Text.Replace("Greatly increases lava immunity time regeneration", "Augmente grandement la régénération de l'immunité temporaire à la lave");
				line.Text = line.Text.Replace("Reduces lava burn damage", "Réduit les dégats des brûlures de lave");
				line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
		}
		if (item.type == 1323)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Reduced direct damage from touching lava", "Réduit les dégâts direct quand vous touchez la lave");
				line.Text = line.Text.Replace("Greatly reduces lava burn damage", "Réduit grandement les dégats des brûlures de lave");
				line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
		}
		if (item.type == 1322)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
		}
		if (item.type == 906 || item.type == 908)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			}
		}
		if (item.type == 297)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Boosts certain stats when holding certain types of rogue weapons", "Augmente certaines statistiques quand vous portez certains types d'armes de voleur");
			}
		}
		if (item.type == 2294)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Requires bait to catch fish", "Nécessite un appât");
				line.Text = line.Text.Replace("The line will never break", "La ligne ne cassera jamais");
			}
		}
		if (item.type == 1294)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Capable of mining Lihzahrd Bricks and Scoria Ore", "Capable d'extraire des briques de Lizhard et du minerai de scorie");
			}
		}
		if (item.type == 2786 || item.type == 2776 || item.type == 2781 || item.type == 3466)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Material", "Matériau");
				line.Text = line.Text.Replace("Can mine Uelibloom Ore", "Peut extraire du minerai d'ueliclosion");
			}
		}
		if (item.type == 89 || item.type == 80 || item.type == 76)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +2 defense and 15% increased mining speed", "Bonus d'ensemble: +2 défense et +15% de vitesse de minage");
			}
		}
		if (item.type == 123 || item.type == 124 || item.type == 125)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: Reduces the mana cost of the Space Gun by 50%", "Bonus d'ensemble: réduit le coût en mana du pistolet spatial de 50%");
			}
		}
		if (item.type == 687 || item.type == 688 || item.type == 689)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +2 defense and 10% increased mining speed", "Bonus d'ensemble: +2 défense et +10% de vitesse de minage");
			}
		}
		if (item.type == 954 || item.type == 90 || item.type == 81 || item.type == 77)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +2 defense and 25% increased mining speed", "Bonus d'ensemble: +2 défense et +25% de vitesse de minage");
			}
		}
		if (item.type == 690 || item.type == 691 || item.type == 692)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +3 defense and 20% increased mining speed", "Bonus d'ensemble: +3 défense et +20% de vitesse de minage");
			}
		}
		if (item.type == 91 || item.type == 82 || item.type == 78)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +3 defense and 35% increased mining speed", "Bonus d'ensemble: +3 défense et +35% de vitesse de minage");
			}
		}
		if (item.type == 693 || item.type == 694 || item.type == 695)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +3 defense and 30% increased mining speed", "Bonus d'ensemble: +3 défense et +30% de vitesse de minage");
			}
		}
		if (item.type == 955 || item.type == 92 || item.type == 83 || item.type == 79)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +3 defense and 45% increased mining speed", "Bonus d'ensemble: +3 défense et +45% de vitesse de minage");
			}
		}
		if (item.type == 696 || item.type == 697 || item.type == 698)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Set Bonus: +4 defense and 40% increased mining speed", "Bonus d'ensemble: +4 défense et +40% de vitesse de minage");
			}
		}
		if ((item.type == 3776 || item.type == 3777 || item.type == 3778))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("The minion damage nerf is reduced while wielding magic weapons", "La réduction des dégâts des sbires est réduite quand vous portez une arme magique");
			}
		}
		if (item.type == 3187)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("3 defense", "+3 défense");
				line.Text = line.Text.Replace("3% increased rogue damage", "+3% de dégâts de voleur");
			}
		}
		if (item.type == 3188)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("5 defense", "+5 défense");
				line.Text = line.Text.Replace("3% increased rogue critical strike chance", "+3% de chances de critique de voleur");
			}
		}
		if (item.type == 3189)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("4 defense", "+4 défense");
				line.Text = line.Text.Replace("3% increased rogue velocity", "+3% de vitesse des projectiles de voleur");
			}
		}
		if (item.type == 3266)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("4 defense", "+3 défense");
				line.Text = line.Text.Replace("3% increased rogue damage", "+3% de dégâts de voleur");
			}
		}
		if (item.type == 3267)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("5 defense", "+5 défense");
				line.Text = line.Text.Replace("3% increased rogue critical strike chance", "+3% de chances de critique de voleur");
			}
		}
		if (item.type == 3268)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("4 defense", "+4 défense");
				line.Text = line.Text.Replace("3% increased rogue velocity", "+3% de vitesse des projectiles de voleur");
			}
		}
		if (item.type == 231 || item.type == 232 || item.type == 233)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text.Replace("Set Bonus: 17% extra melee damage", "Bonus d'ensemble: +17% de dégâts de mêlée");
				line.Text.Replace("20% extra true melee damage", "+20% de dégâts de vrai mêlée");
				line.Text.Replace("Grants immunity to fire blocks, and temporary immunity to lava", "Immunise au bloc de feu et immunité temporaire à la lave");
				line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
		}
		if ((item.type == 684 || item.type == 685 || item.type == 686))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
			}
		}
		if (item.type == 1321)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Increases arrow damage by 10% and greatly increases arrow speed", "Augmente les dégâts des flèches de 10% et augmente grandement la vitesse des flèches");
			}
		}
		if (item.type == 88)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides light when worn", "Émet de la lumière");
			}
		}
		if (item.type == 1921)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Provides immunity to chilling and freezing effects", "Immunité au refroidissement et au gel");
				line.Text = line.Text.Replace("Provides a regeneration boost while wearing the Eskimo armor", "Donne un bonus de régénération quand vous portez l'armure d'Eskimo");
				line.Text = line.Text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
			}
		}
		//Ailes
		if (item.type == 3580 || item.type == 3582 || item.type == 3588 || item.type == 3592 || item.type == 3924 || item.type == 3928 || item.type == 3228 || item.type == 665 || item.type == 1583 || item.type == 1584 || item.type == 1585 || item.type == 1586)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Great for impersonating devs!", "Parfait pour se faire passer pour les développeurs!");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
			}
		}
		if (item.type == 748)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
			}
		}
		if (item.type == 2609)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
			}
		}
		if (item.type == 493)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+20 max life, +15 defense and +3 life regen", "+20 vie max, +15 défense et +3 régénération de vie");
			}
		}
		if (item.type == 492)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("10% increased damage and critical strike chance", "+10% de dégâts et de chances de critique");
			}
		}
		if (item.type == 749)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+50 max mana, 5% decreased mana usage,", "+50 mana max, 5% de réduction du coût en mana,");
				line.Text = line.Text.Replace("10% increased magic damage and 5% increased magic critical strike chance", "+10% de dégats magiques et +5% de chances de critique magique");
			}
		}
		if (item.type == 761)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+80 max life", "+80 vie max");
			}
		}
		if (item.type == 1515)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("Honey buff at all times", "Amélioration du Miel permanente");
			}
		}
		if (item.type == 785)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("30% increased movement speed", "+30% de vitesse de mouvement");
				line.Text = line.Text.Replace("Most attacks have a chance to fire a feather on swing if Harpy Ring or Angel Treads are equipped", "La plupart des attaques ont une chance de tirer une plume si l'anneau de harpie ou les semelles d'ange sont équipés");
			}
		}
		if (item.type == 786)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("15% increased movement speed, 12% increased ranged damage,", "+15% de vitesse de mouvement, +12% de dégâts à distance,");
				line.Text = line.Text.Replace("16% increased ranged critical strike chance", "+16% de chances de critique à distance");
				line.Text = line.Text.Replace("and +30 defense while wearing the Necro Armor", "et +30 défense quand vous portez l'armure Necro");
			}
		}
		if (item.type == 821)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("10% increased melee damage", "+10% de dégâts de mêlée");
				line.Text = line.Text.Replace("and 5% increased melee critical strike chance", "et +5% de chances de critique de mêlée");
			}
		}
		if (item.type == 822)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("2% increased melee and ranged damage", "+2% de dégâts de mêlée et à distance");
				line.Text = line.Text.Replace("and 1% increased melee and ranged critical strike chance", "et +1% de chances de critique à distance et de mêlée");
				line.Text = line.Text.Replace("while wearing the Frost Armor", "quand vous portez l'armure de givre");
			}
		}
		if (item.type == 823)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+10 defense and 5% increased damage reduction while wearing the Spectre Armor and Hood", "+10 défense et +5% de réduction des dégâts quand vous portez l'armure de spectre avec la capuche");
				line.Text = line.Text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana max; +5% de dégâts et de chances de critique magique");
				line.Text = line.Text.Replace("and 5% decreased mana usage while wearing the Spectre Armor and Mask", "et 5% de réduction de coût en mana quand vous portez l'armure spectre avec le masque");
			}
		}
		if (item.type == 2280)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+15 defense and 10% increased damage reduction while wearing the Beetle Armor and Shell", "+15 défense et +10% de réduction de dégâts quand vous portez l'armure de scarabée avec la carapace");
				line.Text = line.Text.Replace("10% increased melee damage and critical strike chance while wearing the Beetle Armor and Scale Mail", "+10% de dégâts et de chances de critique de mêlée quand vous portez l'armure de scarabée avec la cotte de mailles");
			}
		}
		if (item.type == 2494)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("Gills effect and you can move freely through liquids", "Effet de la potion de branchies et vous pouvez vous déplacer librement dans les liquides");
				line.Text = line.Text.Replace("You fall faster while submerged in liquid", "Vous tombez plus vite quand vous êtes immergé");
				line.Text = line.Text.Replace("20% increased movement speed and 36% increased jump speed", "+20% de vitesse de mouvement et +36% de vitesse de saut");
			}
		}
		if (item.type == 948)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+8 defense, 10% increased movement speed,", "+8 défense, +10% de vitesse de mouvement,");
				line.Text = line.Text.Replace("4% increased damage, and 2% increased critical strike chance", "+4% de dégâts et +2% de chances de critique");
			}
		}
		if (item.type == 1162)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+10 defense, 10% increased damage reduction,", "+10 défense, +10% de réduction de dégâts,");
				line.Text = line.Text.Replace("and the Dryad's permanent blessing while wearing the Tiki Armor", "et bénédiction de la Dryade permanente quand vous portez l'armure Tiki");
				//Solving weird bug with Jungle Wings
				line.Text = line.Text.Replace(" increased ", " ");
			}
		}
		if (item.type == 1165)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("At night or during an eclipse, you will gain the following boosts:", "La nuit ou durant une éclipse, vous gagnez les améliorations suivantes:");
				line.Text = line.Text.Replace("10% increased movement speed, 20% increased jump speed,", "+10% de vitesse de mouvement, +20% de vitesse de saut,");
				line.Text = line.Text.Replace("+15 defense, 10% increased damage, and 5% increased critical strike chance", "+15 défense, +10% de dégâts et +5% de chances de critique");
			}
		}
		if (item.type == 1797)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("5% increased damage and critical strike chance", "+5% de dégâts et de chances de critique");
			}
		}
		if (item.type == 1830)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "Recul des sbires augmentés et +5% de dégâts des sbires quand vous portez l'armure sinistre");
			}
		}
		if (item.type == 1866)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("10% increased damage to bows, guns, rocket launchers, and flamethrowers while wearing the Shroomite Armor", "+10% de dégâts aux arcs, armes à feu, lance-roquettes et les lances-flammes quand vous portez l'armure de champignite");
				line.Text = line.Text.Replace("Boosted weapon type depends on the Shroomite Helmet worn", "Les armes augmentées dépendent du casque en champignite équipé");
			}
		}
		if (item.type == 1871)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+50 max life", "+50 vie maximum");
				line.Text = line.Text.Replace("Ornaments rain down as you fly", "Des ornements pleuvent quand vous volez");
			}
		}
		if (item.type == 2770)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Average vertical speed", "Vitesse verticale moyenne");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+5 defense, 5% increased damage,", "+5 défense, +5% de dégâts,");
				line.Text = line.Text.Replace("10% increased movement speed and 24% increased jump speed", "+10% de vitesse de mouvement et +24% de vitesse de saut");
			}
		}
		if (item.type == 3468)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Great vertical speed", "Excellente vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("7% increased melee damage and 3% increased melee critical strike chance", "+7% des dégâts de mêlée et +3% de chances de critique en mêlée");
				line.Text = line.Text.Replace("while wearing the Solar Flare Armor", "quand vous portez l'armure de lueur solaire");
			}
		}
		if (item.type == 3471)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Great vertical speed", "Excellente vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+1 max minion and 5% increased minion damage while wearing the Stardust Armor", "+1 sbire max et +5% de dégâts de sbires quand vous portez l'armure astrale");
			}
		}
		if (item.type == 3469)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("3% increased ranged damage and 7% increased ranged critical strike chance", "+3% de dégâts à distance et +7% de chances de critique à distance");
				line.Text = line.Text.Replace("while wearing the Vortex Armor", "quand vous portez l'armure du vortex");
			}
		}
		if (item.type == 3470)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
				line.Text = line.Text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana max, +5% de dégâts et de chances de critique magique,");
				line.Text = line.Text.Replace("and 5% decreased mana usage while wearing the Nebula Armor", "et 5% de réduction de coût en mana quand vous portez l'armure nébuleuse");
			}
		}
		if (item.type == 3883)
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Equipable", "Peut s'équiper");
				line.Text = line.Text.Replace("Allows flight and slow fall", "Permet de voler et de planer");
				line.Text = line.Text.Replace("Hold DOWN and JUMP to hover", "Appuyez sur BAS et SAUT pour léviter");
				line.Text = line.Text.Replace("Horizontal speed", "Vitesse horizontale");
				line.Text = line.Text.Replace("Acceleration multiplier", "Multiplicateur d'accéleration");
				line.Text = line.Text.Replace("Good vertical speed", "Bonne vitesse verticale");
				line.Text = line.Text.Replace("Flight time", "Temps de vol");
			}
		}
		List<int> grappins = new List<int>() { 84, 1236, 1237, 1238, 1239, 1240, 1241, 939, 1273, 2585, 2360, 185, 1800, 1915, 437, 3021, 3023, 3020, 3022, 2800, 1829, 1916, 3572, 3623 };
		if (grappins.Contains(item.type))
		{
			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Equipable", "Peut s'équiper");
				line.Text = line.Text.Replace("Reach", "Portée");
				line.Text = line.Text.Replace("Launch Velocity", "Vitesse de Lancer");
				line.Text = line.Text.Replace("Pull Velocity", "Vitesse de Traction");
			}
		}
	}
}
			