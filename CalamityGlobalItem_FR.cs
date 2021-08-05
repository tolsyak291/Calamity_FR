using System;
using Terraria;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Armor;
using CalamityMod.World;
using System.Collections.Generic;
using Terraria.ModLoader;

public class CalamityGlobalItem_FR : GlobalItem
{
	public CalamityGlobalItem_FR()
	{
	}

	public override void UpdateArmorSet(Player player, string set)
	{
		string hotkey = CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();
		if (set == "AerospecMagic")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique magique\nPrendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\nVous permet de tomber plus rapidement et annule les dégâts de chute\n";
		}
		else if (set == "AerospecRogue")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique de voleur\nPrendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\nVous permet de tomber plus rapidement et annule les dégâts de chute\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "AerospecMelee")
		{
			player.setBonus = "+5% de vitesse de mouvement et melee chances de coup critique\nPrendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\nVous permet de tomber plus rapidement et annule les dégâts de chute\n";
		}
		else if (set == "AerospecSummon")
		{
			player.setBonus = "+16% de dégâts des sbires\nInvoque une valkyrie pour vous protéger\nPrendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\nVous permet de tomber plus rapidement et annule les dégâts de chute\n";
		}
		else if (set == "AerospecRanged")
		{
			player.setBonus = "+5% de vitesse de mouvement et de chances de coup critique à distance\nPrendre plus de 25 dégâts en une seule fois fera tomber des plumes à têtes chercheuses du ciel\nVous permet de tomber plus rapidement et annule les dégâts de chute\n";
		}
		else if (set == "Astral")
		{
			player.setBonus = "+25% de vitesse de mouvement\n+28% de dégâts et +21% de chances de coup critique\nLes coups critiques font pleuvoir des étoiles déchues, sacrées et astrales\nCet effet à un temps de recharge de 1s\n";
		}
		else if (set == "AtaxiaRanged")
		{
			player.setBonus = "+5% de dégâts à distance\nEffet de la potion infernale quand vous êtes à moins de la moitié de votre vie\nVous avez 50% de chances de tirer une déflagration de chaos à tête chercheuse quand vous utilisez une arme à distance\nVous avez 20% de chances d'émettre une explosion flamboyante quand vous êtes touché\n";
		}
		else if (set == "AtaxiaMelee")
		{
			player.setBonus = "+5% de dégâts de mêlée\nEffet de la potion infernale quand vous êtes à moins de la moitié de votre vie\nLes attaques et les projectiles de mêlée créent des éruptions de flammes chaotiques quand ils touchent\nVous avez 20% de chances d'émettre une explosion flamboyante quand vous êtes touché\n";
		}
		else if (set == "AtaxiaSummon")
		{
			player.setBonus = "+40% de dégâts des sbires\nEffet de la potion infernale quand vous êtes à moins de la moitié de votre vie\nSummons a hydrothermic vent to protect you\nVous avez 20% de chances d'émettre une explosion flamboyante quand vous êtes touché\n";
		}
		else if (set == "AtaxiaRogue")
		{
			player.setBonus = "+5% de dégâts de voleur\nEffet de la potion infernale quand vous êtes à moins de la moitié de votre vie\nLes armes de voleur ont 10% de chances de relâcher une volée de flammes chaotiques autour du joueur qui pourchassent les ennemis\nVous avez 20% de chances d'émettre une explosion flamboyante quand vous êtes touché\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 110\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "AtaxiaMagic")
		{
			player.setBonus = "+5% de dégâts magiques\nEffet de la potion infernale quand vous êtes à moins de la moitié de votre vie\nLes attaques magiques créent des orbes de soin et de dégâts quand elles touchent\nVous avez 20% de chances d'émettre une explosion flamboyante quand vous êtes touché\n";
		}
		else if (set == "AuricMelee")
		{
			player.setBonus = "Effets des armures de mêlée d'estragon, de brûlesang, de déicide et Silva\nTous les projectiles font apparaître des orbes auriques quand vous touchez\nVitesse de course et d'accélération augmentée de 10%\nVos dégâts de mêlée sont augmentés en fonction du montant de vos points de vie; l'effet est maximal quand vous avez tous vos points de vie\n";
		}
		else if (set == "AuricRanged")
		{
			player.setBonus = "Effets des armures à distance d'estragon, de brûlesang, de déicide et Silva\nTous les projectiles font apparaître des orbes auriques quand vous touchez\nVitesse de course et d'accélération augmentée de 10%\n";
		}
		else if (set == "AuricRogue")
		{
			player.setBonus = "Effets des armures de voleur d'estragon, de brûlesang, de déicide et Silva\nTous les projectiles font apparaître des orbes auriques quand vous touchez\nVitesse de course et d'accélération augmentée de 10%\nLes coups critiques de voleur font 25% de dégâts en plus quand vous avez plus de 50% de vos points de vie\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 130\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "AuricSummon")
		{
			player.setBonus = "Effets des armures d'invocateur d'estragon, de brûlesang, de déicide et Silva\nTous les projectiles font apparaître des orbes auriques quand vous touchez\nVitesse de course et d'accélération augmentée de 10%\n+1 sbires max et +120% de dégâts des sbires\n";
		}
		else if (set == "AuricMagic")
		{
			player.setBonus = "Effets des armures magiques d'estragon, de brûlesang, de déicide et Silva\nTous les projectiles font apparaître des orbes auriques quand vous touchez\nVitesse de course et d'accélération augmentée de 10%\n";
		}
		else if (set == "BloodflareRogue")
		{
			player.setBonus = "Augmente grandement la régénération de vie\nLes ennemis ayant moins de 50% de leur vie ont une chance de lâcher un coeur quand ils sont frappés\nLes ennemis ayant plus de 50% de leur vie ont une chance de lâcher une étoile de mana quand ils sont frappés\nLes ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\nAvoir plus de 80% de vos points de vie augmente votre défense de 30 et vos chances de coup critique de voleur de 5%\nAvoir moins de 80% de votre vie augmente vos dégâts de voleur de 10%\nLes coups critiques de voleur ont 50% de chances de vous soigner\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 120\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "BloodflareSummon")
		{
			player.setBonus = "+55% de dégâts des sbires\nAugmente grandement la régénération de vie\nLes ennemis ayant moins de 50% de leur vie ont une chance de lâcher un coeur quand ils sont frappés\nLes ennemis ayant plus de 50% de leur vie ont une chance de lâcher une étoile de mana quand ils sont frappés\nLes ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\nInvoque des mines d'épouvantôme qui vous encerclent\nAvoir plus de 90% de votre vie augmente de 10% les dégâts des sbires\nAvoir moins de 50% de votre vie augmente votre défense de 20 et votre régénération de vie de 2\n";
		}
		else if (set == "BloodflareRanged")
		{
			player.setBonus = "Augmente grandement la régénération de vie\nLes ennemis ayant moins de 50% de leur vie ont une chance de lâcher un coeur quand ils sont frappés\nLes ennemis ayant plus de 50% de leur vie ont une chance de lâcher une étoile de mana quand ils sont frappés\nLes ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\nAppuyez sur " + hotkey + " pour libérer les âmes perdues de l'épouvantôme pour détruire vos ennemis\nCet effet a 30s de temps de recharge\nLes armes à distance ont une chance de tirer des orbes d'explosion de sang\n";
		}
		else if (set == "BloodflareMagic")
		{
			player.setBonus = "Augmente grandement la régénération de vie\nLes ennemis ayant moins de 50% de leur vie ont une chance de lâcher un coeur quand ils sont frappés\nLes ennemis ayant plus de 50% de leur vie ont une chance de lâcher une étoile de mana quand ils sont frappés\nLes ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\nLes armes magiques tirerons parfois des décharges fantômatiques\nLes coups critiques magiques provoquent des explosions de flammes toutes les 2 secondes\n";
		}
		else if (set == "BloodflareMelee")
		{
			player.setBonus = "Augmente grandement la régénération de vie\nLes ennemis ont plus de chances de vous cibler\nLes ennemis ayant moins de 50% de leur vie ont une chance de lâcher un coeur quand ils sont frappés\nLes ennemis ayant plus de 50% de leur vie ont une chance de lâcher une étoile de mana quand ils sont frappés\nLes ennemis tués durant une lune de sang ont une bien meilleure chance de lâcher des orbes de sang\nLes attaques de vraie mêlée vous soignent\nAprès 15 attaques de vraie mêlée réussies, vous entrerez en fureur de sang pendant 5 secondes\nLa fureur vous fera gagner 25% de dégâts et de chances de coup critique en mêlée, et les dégâts de contact sont réduit de moitié\nCet effet à 30s de temps de recharge\n";
		}
		else if (set == "Brimflame")
		{
			player.setBonus = "+15% de dégâts et de chances de coup critique magique\nAppuyez sur " + hotkey + " pour déclencher une fureur flammesouffre\nDurant cet effet, vos dégâts sont significativement augmentés\nCependant, votre vie diminue rapidement et votre mana ne se régénère pas durant la fureur\nCet effet peut être interrompu, la fureur flammesouffre a un temps de recharge de 30s\n";
		}
		else if (set == "DaedalusMagic")
		{
			player.setBonus = "+5% de dégâts magiques\nVous avez 10% de cahnce d'absorber les attaques et les projectiles physiques quand vous êtes touché\nSi vous absorbez une attaque, vous êtes soigné pour la moitié des dégâts de cette attaque\n";
		}
		else if (set == "DaedalusSummon")
		{
			player.setBonus = "+20% de dégâts des sbires\nUn cristal de Dédale flotte au-dessus de vous pour vous protéger\n";
		}
		else if (set == "DaedalusMelee")
		{
			player.setBonus = "+5% de dégâts de mêlée\nVous avez 33% de chances de renvoyer les projectiles sur les ennemis\nSi vous renvoyez un projectile, vous êtes également soigné pour 20% des dégâts de ce projectile\n";
		}
		else if (set == "DaedalusRanged")
		{
			player.setBonus = "+5% de dégâts à distance\nÊtre touché vous fait émettre une décharge d'éclats de cristaux\n";
		}
		else if (set == "DaedalusRogue")
		{
			player.setBonus = "+5% de dégâts de voleur\nLes projectiles de voleur émettent des éclats de cristaux sur leur trajectoire\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 105\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "Demonshade")
		{
			player.setBonus = "+100% de dégâts des sbires\nToutes les attaques infligent les flammes démoniaques\nDes rayons d'ombre et des faux démoniaques pleuvront quand vous serez touché\nUne diable rouge amical vous suivra\nAppuyez sur " + hotkey + " pour enrager les ennemis proches avec un sort de magie noire pendant 10s\nIl feront alors 25% de dégâts supplémentaires, mais subiront 125% de dégâts supplémentaires\n";
		}
		else if (set == "DesertProwler")
		{
			player.setBonus = "Les attaques à distance font 1 dégât supplémentaire\nLes coups critiques à distance peuvent rarement conjurer une tempête de sable\n";
		}
		else if (set == "FathomSwarmer")
		{
			player.setBonus = "+10% de dégâts des sbires et +1 sbires max\nPermet de grimper aux murs\n+30% de dégâts des sbires quand vous êtes immergé\nDonne une quantité de modérée de lumière et réduit de façon modérée la perte de respiration dans les abysses\n";
		}
		else if (set == "Fearmonger")
		{
			player.setBonus = "+30% de dégâts des sbires\nLa réduction des dégâts infligés par les sbires est réduite quand vous tenez une arme\nImmunité à toutes les formes de flamme et de givre\nToutes les attaques de sbires augmentent colossalement la régénération de vie\n+15% de réduction de dégâts durant les lunes citrouilles et de givre\nCette réduction de dégâts ignore la limitation normale\nProtège contre le froid en mode Mort\n";
		}
		else if (set == "ForbiddenCalam")
		{
			int stormMana = (int)(60f * player.manaCost);
			player.setBonus = "Appuyez sur " + hotkey + " pour convoquer une tornade ancienne à l'emplacement du curseur\nLa tornade ancienne coûte " + stormMana + " mana et profite à la fois des améliorations d'invocateur et de voleur\nLes attaques furtives créent des dévoreurs à tête chercheuse quand vous touchez\nLes attaques de voleur et d'invocateur utiliserons le bonus de statistiques le plus élevé des deux\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 40\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "GodSlayerMelee")
		{
			player.setBonus = "Vous survivrez à des dégâts mortels et serez soigné de 150 points de vie si une attaque vous serait fatale\nCet effet a un temps de recharge de 45s\nLa régénération de vie est réduite de moitié quand cet effet se recharge\nPrendre plus de 80 dégâts en une fois vous fera relâcher une nuée de fléchettes déicides infligeant des dégâts importants\nLes ennemis subissent beaucoup de dégâts quand ils vous touchent\nUne attaque qui inflige moins de 80 dégâts vera ses dégâts réduits à 1\n";
		}
		else if (set == "GodSlayerRanged")
		{
			player.setBonus = "Vous survivrez à des dégâts mortels et serez soigné de 150 points de vie si une attaque vous serait fatale\nCet effet a un temps de recharge de 45s\nLa régénération de vie est réduite de moitié quand cet effet se recharge\nVos attaques critiques à distance ont une chance de double critique, infligeant 4 fois les dégâts normaux\nVous avez une chance de tirer une cartouche à éclat déicide quand vous tirez avec une arme à distance\n";
		}
		else if (set == "GodSlayerSummon")
		{
			player.setBonus = "+65% de dégâts des sbires\nVous survivrez à des dégâts mortels et serez soigné de 150 points de vie si une attaque vous serait fatale\nCet effet a un temps de recharge de 45s\nLa régénération de vie est réduite de moitié quand cet effet se recharge\nToucher les ennemis invoquera des fantômes déicides\nInvoque un ver mécanique dévoreur de dieux pour combattre à vos côtés\n";
		}
		else if (set == "GodSlayerRogue")
		{
			player.setBonus = "Vous survivrez à des dégâts mortels et serez soigné de 150 points de vie si une attaque vous serait fatale\nCet effet a un temps de recharge de 45s\nLa régénération de vie est réduite de moitié quand cet effet se recharge\nQuand vous êtes à 100% de votre vie, toutes vos statistiques de voleur sont augmentées de 10%\nSi vous prenez plus de 80 dégâts en un coup, vous obtiendrez une période d'invulnérabilité plus longue\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 120\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "GodSlayerMagic")
		{
			player.setBonus = "Vous survivrez à des dégâts mortels et serez soigné de 150 points de vie si une attaque vous serait fatale\nCet effet a un temps de recharge de 45s\nLa régénération de vie est réduite de moitié quand cet effet se recharge\nLes ennemis relâchent des flammes déicides et des flammes de soin quand ils sont touchés par des attaques magiques\nPrendre des dégâts vous fera émettre une explosion magique déicide\n";
		}
		else if (set == "Mollusk")
		{
			player.setBonus = "Deux crustacés vous assisteront au combat\n+10% de dégâts\nVotre mouvement horizontal est réduit\n";
		}
		else if (set == "OmegaBlue")
		{
			player.setBonus = "Augmente la pénétration d'armure de 50\n+10% de dégâts et de chances de coup critique\nDes tentacules à faible portée vous soigneront en aspirant la vie des ennemis\nAppuyez sur " + hotkey + " pour activer la folie abyssale pendant 5 secondes\nLa folie abyssale augmentent les dégâts, les chances de coup critique, et l'aggressivité et la portée des tentacules\nCet effet à 25s de temps de recharge\n";
		}
		else if (set == "PlaguebringerSummon")
		{
			player.setBonus = "Accorde une ruée pestiférée pour charger les ennemis et leur infliger la peste\nInvoque un ptit colporte-peste pour vous protéger et renforcer les sbires proches\n";
		}
		else if (set == "PlaguebringerRanged")
		{
			player.setBonus = "25% de réduction de consommation de munitions et +5% de temps de vol\nLes ennemis subissent 10% de dégâts supplémentaires des projectiles à distance quand ils sont affectés par la peste\nÊtre touché fait pleuvoir des cendres de peste\nAppuyer sur " + hotkey + " pour vous aveugler pendant 5 secondes mais augmenter massivement vos dégâts à distance\nCet effet a 25s de temps de recharge.\n";
		}
		else if (set == "Prismatic")
		{
			player.setBonus = "+40 mana maximum et +15% de réduction du coût en mana\nRégénération de mana augmentée\nAppuyez sur " + hotkey + " pour relâcher un barrage de lasers mortels sur le curseur pendant 5 secondes\nCet effet a 30s de temps de recharge\n";
		}
		else if (set == "ReaverRogue")
		{
			player.setBonus = "5% de dégâts de voleur\nYou emit a cloud of spores when you are hit\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 110\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "ReaverMelee")
		{
			player.setBonus = "+5% de dégâts de mêlée\nLes projectiles de mêlée explosent quand vous touchez\nÉpines de saccageur\nLa rage s'active quand vous subissez des dégâts\n";
		}
		else if (set == "ReaverSummon")
		{
			player.setBonus = "+16% de dégâts des sbires\nInvoque une orbe de saccageur qui émet du gaz sporieux quand les ennemis sont proches\n";
		}
		else if (set == "ReaverMagic")
		{
			player.setBonus = "+5% de dégâts magiques\nVos projectiles magiques émettent une déflagration de gaz sporieux quand vous touchez\n";
		}
		else if (set == "ReaverRanged")
		{
			player.setBonus = "+5% de dégâts à distance\n10% de chances de tirer une puissante roquette quand vous utilisez une arme à distance\n";
		}
		else if (set == "ShroomiteCalam")
		{
			player.setBonus = "Furtivité à distance quand vous restez immobile\n";
		}
		else if (set == "SilvaMelee")
		{
			player.setBonus = "Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\nVitesse de course et d'accélération maximale augmentée de 5%\nSi vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 10s\nSi vous retombez à 1 point de vie pendant que cet effet est actif, vous perdrez 100 points de vie maximum\nCet effet ne s'active qu'une fois par vie et ne fonctionne que si votre vie maximum est supérieure à 400\nVotre vie maximale sera restaurée si vous mourrez\nLes attaques de vrai mêlée ont 25% de chances de faire 5 fois plus de dégâts\nAprès l'invicibilité Silva, les dégâts de contact seront réduits de 20%\nLes projectiles de mêlée ont 25% de chances de stopper brièvement les ennemis\n";
		}
		else if (set == "SilvaSummon")
		{
			player.setBonus = "+75% de dégâts des sbires\nTous vos projectiles créent des orbes feuillues de soin quand elle touchent\nVitesse de course et d'accélération maximale augmentée de 5%\nSi vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 10s\nSi vous retombez à 1 point de vie pendant que cet effet est actif, vous perdrez 100 points de vie maximum\nCet effet ne s'active qu'une fois par vie et ne fonctionne que si votre vie maximum est supérieure à 400\nVotre vie maximale sera restaurée si vous mourrez\nInvoque une ancien prisme feuillu pour anéantir vos ennemis avec de l'énergie vitale\nAprès l'invincibilité Silva, vos sbires infligerons 10% de dégâts supplémentaires\n";
		}
		else if (set == "SilvaRanged")
		{
			player.setBonus = "Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\nVitesse de course et d'accélération maximale augmentée de 5%\nSi vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 10s\nSi vous retombez à 1 point de vie pendant que cet effet est actif, vous perdrez 100 points de vie maximum\nCet effet ne s'active qu'une fois par vie et ne fonctionne que si votre vie maximum est supérieure à 400\nVotre vie maximale sera restaurée si vous mourrez\nAugmente la vitesse de tir de toutes les armes à distance\nAprès l'invincibilité Silva, toutes les armes à distance infligerons 10% de dégâts supplémentaires\n";
		}
		else if (set == "SilvaRogue")
		{
			player.setBonus = "Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\nVitesse de course et d'accélération maximale augmentée de 5%\nSi vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 10s\nSi vous retombez à 1 point de vie pendant que cet effet est actif, vous perdrez 100 points de vie maximum\nCet effet ne s'active qu'une fois par vie et ne fonctionne que si votre vie maximum est supérieure à 400\nVotre vie maximale sera restaurée si vous mourrez\nLes armes de voleur se jettent plus vite quand vous avez plus de la moitié de votre vie\nAprès l'invincibilité Silva, les armes de voleur infligerons 10% de dégâts supplémentaires\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 125\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "SilvaMagic")
		{
			player.setBonus = "Tous vos projectiles créent des orbes feuillues de soin quand elle touchent\nVitesse de course et d'accélération maximale augmentée de 5%\nSi vous tombez à 1 point de vie vous ne mourrez pas si vous subissez d'autres dégâts pendant 10s\nSi vous retombez à 1 point de vie pendant que cet effet est actif, vous perdrez 100 points de vie maximum\nCet effet ne s'active qu'une fois par vie et ne fonctionne que si votre vie maximum est supérieure à 400\nVotre vie maximale sera restaurée si vous mourrez\nLes projectiles magiques ont 10% de chances de créer une explosion massive quand ils touchent\nAprès l'invincibilité Silva, les armes magiques infligeront 10% de dégâts supplémentaires\n";
		}
		else if (set == "SnowRuffian")
		{
			player.setBonus = "+5% de dégâts de voleur\nVous pouvez flotter pour annuler les dégâts de chute\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 50\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "StatigelMagic")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\nAccorde un saut additionnel et une hauteur de saut accrue\n+30% de vitesse de saut\n";
		}
		else if (set == "StatigelRanged")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\nAccorde un saut additionnel et une hauteur de saut accrue\n+30% de vitesse de saut\n";
		}
		else if (set == "StatigelMelee")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\nAccorde un saut additionnel et une hauteur de saut accrue\n+30% de vitesse de saut\n";
		}
		else if (set == "StatigelSummon")
		{
			player.setBonus = "+18% de dégâts des sbires\nInvoque un dieu des gelées miniature pour combattre à vos côtés, en fonction du biome maléfique présent dans votre monde\nSi vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\nAccorde un saut additionnel et une hauteur de saut accrue\n+30% de vitesse de saut\n";
		}
		else if (set == "StatigelRogue")
		{
			player.setBonus = "Si vous prenez 100 dégâts en un seul coup, votre période d'invulnérabilité est prolongée\nAccorde un saut additionnel et une hauteur de saut accrue\n+30% de vitesse de saut\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "Sulfur")
		{
			player.setBonus = "Attaquer et être attaqué par les ennemis inflige l'empoisonnement\nAccorde un saut additionnel qui invoque une bulle sulfurique\nAccorde une meilleure mobilité sous l'eau et réduit la sévérité des eaux sulfuriques\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "TarragonMelee")
		{
			player.setBonus = "Augmente la portée de collecte des coeurs\nLes ennemis ont une chance de lâcher plus de coeurs quand ils meurent\nVous avez 25% de chances de gagner une amélioration de régénération de vie quand vous prenez des dégâts\nAppuyez sur " + hotkey + " pour vous draper dans de l'énergie vitale qui réduit énormément les dégâts de contact ennemis pendant 10s\nCet effet à 30s de temps de recharge\n";
		}
		else if (set == "TarragonRogue")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\nAugmente la portée de collecte des coeurs\nLes ennemis ont une chance de lâcher plus de coeurs quand ils meurent\nTous les 25 coups critiques de voleur, vous gagnerez 5 secondes d'invincibilité\nCet effet à un temps de recharge de 30s\n+10% de dégâts de voleur quand vous êtes sous l'effet d'une altération d'état\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 115\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "TarragonSummon")
		{
			player.setBonus = "+55% de dégâts des sbires\nRéduit le taux d'apparition des ennemis\nAugmente la portée de collecte des coeurs\nLes ennemis ont une chance de lâcher plus de coeurs quand ils meurent\nInvoque une aura vitale autour de vous qui inflige des dégâts aux ennemis proches\n";
		}
		else if (set == "TarragonMagic")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\nAugmente la portée de collecte des coeurs\nLes ennemis ont une chance de lâcher plus de coeurs quand ils meurent\nTous les 5 coups critiques, vous libèrerez une tempête de feuilles\nLes projectiles magiques vous soignent quand vous touchez\nLa quantité de soin dépend des dégâts infligés par le projectile\n";
		}
		else if (set == "TarragonRanged")
		{
			player.setBonus = "Réduit le taux d'apparition des ennemis\nAugmente la portée de collecte des coeurs\nLes ennemis ont une chance de lâcher plus de coeurs quand ils meurent\nLes coups critiques à distance provoqueront une explosion de feuilles\nLes projectiles à distance ont une chance de se diviser en énergie vitale en touchant un ennemi\n";
		}
		else if (set == "TitanHeart")
		{
			player.setBonus = "+20% de dégâts et de recul de voleur\nLes attaques furtives ont deux fois plus de recul et provoquent une explosion astrale\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 100\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "Umbraphile")
		{
			player.setBonus = "Les armes de voleur ont une chance de créer une explosion quand elles touchent\nLes attaques furtives créent toujours une explosion\nLes potions de pénombre augmentent toujours la furtivité avec une efficacité maximale\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 110\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "VictideRogue")
		{
			player.setBonus = "Augmente la régénération de vie et les dégâts de voleur quand vous êtes immergé\nVous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\nLe coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\nAugmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 90\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "VictideMelee")
		{
			player.setBonus = "Augmente la régénération de vie et les dégâts de mêlée quand vous êtes immergé\nVous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\nLe coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\nAugmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n";
		}
		else if (set == "VictideSummon")
		{
			player.setBonus = "Augmente la régénération de vie et les dégâts des sbires quand vous êtes immergé\nInvoque un oursin des mer pour vous protéger\nVous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\nLe coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\nAugmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n";
		}
		else if (set == "VictideMagic")
		{
			player.setBonus = "Augmente la régénération de vie et les dégâts magiques quand vous êtes immergé\nVous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\nLe coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\nAugmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n";
		}
		else if (set == "VictideRanged")
		{
			player.setBonus = "Augmente la régénération de vie et les dégâts à distance quand vous êtes immergé\nVous avez 10% de chances de jeter un boomerang coquillage quand vous attaquez\nLe coquillage fait des dégâts brut et ne bénéficie pas des bonus de classes\nAugmente la mobilité sous l'eau et réduit légèrement la perte de respiration dans les abysses\n";
		}
		else if (set == "WulfrumRanged")
		{
			player.setBonus = "+3 défense\n+5 défense quand vous avez moins de la moitié de vos points de vie\n";
		}
		else if (set == "WulfrumMelee")
		{
			player.setBonus = "+3 défense\n+5 défense quand vous avez moins de la moitié de vos points de vie\n";
		}
		else if (set == "WulfrumSummon")
		{
			player.setBonus = "+3 défense\n+5 défense quand vous avez moins de la moitié de vos points de vie\n";
		}
		else if (set == "WulfrumMagic")
		{
			player.setBonus = "+3 défense\n+5 défense quand vous avez moins de la moitié de vos points de vie\n";
		}
		else if (set == "WulfrumRogue")
		{
			player.setBonus = "+3 défense\n+5 défense quand vous avez moins de la moitié de vos points de vie\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 50\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "Xeroc")
		{
			player.setBonus = "+9% de dégâts et de vitesse des projectiles de voleur\nLes projectiles de voleur ont des effets spéciaux quand ils touchent\nVous êtes imprégné d'îre et de rage cosmique quand vous subissez des dégâts\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 115\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		//TODO -- Retrieve world state for death mode and remove cold and heat protection description accordingly
		else if (set == "Gladiator")
		{
			player.setBonus = "+3 défense\n+5% de dégâts de voleur et +10% de vitesse des projectiles de voleur\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 70\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\n";
		}
		else if (set == "Obsidian")
		{
			player.setBonus = "+2 défense\n+5% de dégâts et de chances de critique de voleur\nImmunise contre les blocs de feu et immunité temporaire à la lave\nLa furtivité s'accumule quand vous n'attaquez pas, plus vite si vous êtes immobile, jusqu'à un maximum de 80\nUne fois la furtivité au maximum, vous pourrez effectuer une attaque furtive\nLa furtivité ne diminue que si vous attaquez, elle ne diminue pas quand vous bougez\nEn s'accumulant, la furtivité augmente votre vitesse de mouvement, ainsi que vos dégâts et vos chances de coup critique de voleur\nProtège de la chaleur en mode Mort\n";
		}
		else if (set == "Eskimo")
		{
			player.setBonus = "+10% de dégâts pour les armes de glace\nLes ennemis du froid infligent moins de dégâts de contact\nImmunise contre le brûlegivre et l'état glacial\nProtège du froid en mode Mort\n";
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
		if (head.type == ModContent.ItemType<AtaxiaHeadgear>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaRanged";
		}
		if (head.type == ModContent.ItemType<AtaxiaHelm>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaMelee";
		}
		if (head.type == ModContent.ItemType<AtaxiaHelmet>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaSummon";
		}
		if (head.type == ModContent.ItemType<AtaxiaHood>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaRogue";
		}
		if (head.type == ModContent.ItemType<AtaxiaMask>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaMagic";
		}
		if (head.type == ModContent.ItemType<AuricTeslaHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
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
		if (head.type == ModContent.ItemType<BloodflareHelm>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRogue";
		}
		if (head.type == ModContent.ItemType<BloodflareHelmet>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareSummon";
		}
		if (head.type == ModContent.ItemType<BloodflareHornedHelm>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRanged";
		}
		if (head.type == ModContent.ItemType<BloodflareHornedMask>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMagic";
		}
		if (head.type == ModContent.ItemType<BloodflareMask>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMelee";
		}
		if (head.type == ModContent.ItemType<BrimflameScowl>() && body.type == ModContent.ItemType<BrimflameRobes>() && legs.type == ModContent.ItemType<BrimflameBoots>())
		{
			return "Brimflame";
		}
		if (head.type == ModContent.ItemType<DaedalusHat>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMagic";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadgear>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusSummon";
		}
		if (head.type == ModContent.ItemType<DaedalusHelm>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMelee";
		}
		if (head.type == ModContent.ItemType<DaedalusHelmet>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusRanged";
		}
		if (head.type == ModContent.ItemType<DaedalusVisor>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
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
		if (head.type == ModContent.ItemType<GodSlayerHelm>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerMelee";
		}
		if (head.type == ModContent.ItemType<GodSlayerHelmet>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRanged";
		}
		if (head.type == ModContent.ItemType<GodSlayerHornedHelm>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerSummon";
		}
		if (head.type == ModContent.ItemType<GodSlayerMask>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRogue";
		}
		if (head.type == ModContent.ItemType<GodSlayerVisage>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerMagic";
		}
		if (head.type == ModContent.ItemType<MolluskShellmet>() && body.type == ModContent.ItemType<MolluskShellplate>() && legs.type == ModContent.ItemType<MolluskShelleggings>())
		{
			return "Mollusk";
		}
		if (head.type == ModContent.ItemType<OmegaBlueHelmet>() && body.type == ModContent.ItemType<OmegaBlueChestplate>() && legs.type == ModContent.ItemType<OmegaBlueLeggings>())
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
		if (head.type == ModContent.ItemType<ReaverCap>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverRogue";
		}
		if (head.type == ModContent.ItemType<ReaverHelm>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverMelee";
		}
		if (head.type == ModContent.ItemType<ReaverHelmet>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverSummon";
		}
		if (head.type == ModContent.ItemType<ReaverMask>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverMagic";
		}
		if (head.type == ModContent.ItemType<ReaverVisage>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverRanged";
		}
		if (head.type == ModContent.ItemType<ShroomiteVisage>() && body.type == 1549 && legs.type == 1550)
		{
			return "ShroomiteCalam";
		}
		if (head.type == ModContent.ItemType<SilvaHelm>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaMelee";
		}
		if (head.type == ModContent.ItemType<SilvaHelmet>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaSummon";
		}
		if (head.type == ModContent.ItemType<SilvaHornedHelm>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaRanged";
		}
		if (head.type == ModContent.ItemType<SilvaMask>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaRogue";
		}
		if (head.type == ModContent.ItemType<SilvaMaskedCap>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaMagic";
		}
		if (head.type == ModContent.ItemType<SnowRuffianMask>() && body.type == ModContent.ItemType<SnowRuffianChestplate>() && legs.type == ModContent.ItemType<SnowRuffianGreaves>())
		{
			return "SnowRuffian";
		}
		if (head.type == ModContent.ItemType<StatigelCap>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMagic";
		}
		if (head.type == ModContent.ItemType<StatigelHeadgear>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRanged";
		}
		if (head.type == ModContent.ItemType<StatigelHelm>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMelee";
		}
		if (head.type == ModContent.ItemType<StatigelHood>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelSummon";
		}
		if (head.type == ModContent.ItemType<StatigelMask>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRogue";
		}
		if (head.type == ModContent.ItemType<SulfurHelmet>() && body.type == ModContent.ItemType<SulfurBreastplate>() && legs.type == ModContent.ItemType<SulfurLeggings>())
		{
			return "Sulfur";
		}
		if (head.type == ModContent.ItemType<TarragonHelm>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMelee";
		}
		if (head.type == ModContent.ItemType<TarragonHelmet>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonRogue";
		}
		if (head.type == ModContent.ItemType<TarragonHornedHelm>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonSummon";
		}
		if (head.type == ModContent.ItemType<TarragonMask>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMagic";
		}
		if (head.type == ModContent.ItemType<TarragonVisage>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
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
		if (head.type == ModContent.ItemType<VictideHeadgear>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideRogue";
		}
		if (head.type == ModContent.ItemType<VictideHelm>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideMelee";
		}
		if (head.type == ModContent.ItemType<VictideHelmet>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideSummon";
		}
		if (head.type == ModContent.ItemType<VictideMask>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideMagic";
		}
		if (head.type == ModContent.ItemType<VictideVisage>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideRanged";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadgear>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRanged";
		}
		if (head.type == ModContent.ItemType<WulfrumHelm>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMelee";
		}
		if (head.type == ModContent.ItemType<WulfrumHelmet>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumSummon";
		}
		if (head.type == ModContent.ItemType<WulfrumHood>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMagic";
		}
		if (head.type == ModContent.ItemType<WulfrumMask>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRogue";
		}
		if (head.type == ModContent.ItemType<XerocMask>() && body.type == ModContent.ItemType<XerocPlateMail>() && legs.type == ModContent.ItemType<XerocCuisses>())
		{
			return "Xeroc";
		}
		//Original Code from Calamity - May be unneccesary
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
		return "";
	}

	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
		//Horrible code, will change later but will do for now
		foreach (TooltipLine line in tooltips)
		{
			//Specific Item Modification
			/* Generic lines for death mode
				line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Protège contre le froid et la chaleur en mode Mort");
				line.text = line.text.Replace("Provides cold protection in Death Mode", "Protège contre le froid en mode Mort");
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Protège contre la chaleur en mode Mort");
			
			if (CalamityWorld.death) { 
			
			}

			*/
			//Global Item Modifications

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
				line.text = line.text.Replace("damage reduction", "de réduction des dégâts");
				line.text = line.text.Replace("critical strike chance", "de chances de coup critique");
				line.text = line.text.Replace("defense", "défense");
				line.text = line.text.Replace("stealth generation", "de génération de furtivité");

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
			if (item.type == 89 || item.type == 80 || item.type == 76)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 15% increased mining speed", "Bonus d'ensemble: +2 défense et +15% de vitesse de minage");
			}
			if (item.type == 123 || item.type == 124 || item.type == 125)
			{
				line.text = line.text.Replace("Set Bonus: Reduces the mana cost of the Space Gun by 50%", "Bonus d'ensemble: réduit le coût en mana du pistolet spatial de 50%");
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
			