using CalamityMod.UI;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityFR.DraedonLogs
{
	public class JungleGUI : CalamityMod.UI.DraedonLogs.DraedonsLogGUI
    {
		public override int TotalPages => 3;

		public override string GetTextByPage()
		{
			switch (Page)
			{
				case 0:
					return "Au moment où j'enregistre ceci, ça ne serait pas une exaggération d'appeler la jungle la plaque tournante de cette planète. " +
                        "Tout tourne autour d'elle, et personne ne l'ignore. " +
                        "Voir tous ces être vivants aux formes brutes et inconfortables qui y passent durant leur voyage me rend mal à l'aise. " +
                        "Heureusement, ces laboratoires me fournissent tout ce dont j'ai besoin pour mes recherches et même plus. " +
                        "Je n'ai donc jamais besoin de me rendre à la surface, exception faite des convocations sur ordre du Seigneur.";
				case 1:
					return "Un virus, capable de presque tout dévorer et convertir. " +
                        "Et de la nanotechnologie, minutieusement élaboré pour le contrôler. " +
                        "Le développement fut rapide, et chaque pièce du puzzle à trouvé sa place de manière presque effrayante, formant une existence abominable. " +
                        "J'ai du mal à penser à une utilité qui ne serait pas nocive pour les formes de vie communes. " +
                        "Cependant, ce n'est pas un problème majeur. " +
                        "Beaucoup ont hésité de continuer sa création, mais je les ai autorisés à partir s'ils le souhaitaient. " +
                        "Je n'ai pas besoin de ceux qui ne sont pas aussi dévoués que mes machines.";
				default:
					return "Améliorée mécaniquement, la reine des abeilles sur laquelle j'avais expérimenté était théoriquement un hôte parfait pour la peste. " +
                        "C'est quand les premiers signes de liaison entre la créature et la technologie que les problèmes ont immédiatement commencés. " +
                        "L'esprit de l'insecte à combattu le contrôle de la nanotechnologie, sans comparaison possible avec les créatures plus primitives où je l'avais testée auparavant. " +
                        "Elle est devenue de plus en plus violente, et ne peut recevoir que des ordres simples maintenant qu'elle est matée. " +
                        "Cependant, si on venait à l'utiliser, on ne peut rien faire à part complètement la laisser en liberté. " +
                        "Je vais y réfléchir plus en détails.";
			}
		}

		public override Texture2D GetTextureByPage()
		{
			switch (Page)
			{
				case 0:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogJungleBiome").Value;
				case 1:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogPlagueCell").Value;
				default:
					return ModContent.Request<Texture2D>("CalamityMod/UI/DraedonLogs/DraedonsLogPlaguebringerGoliath").Value;
			}
		}
	}
}
