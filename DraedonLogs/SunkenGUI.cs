using CalamityMod.UI;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityFR.DraedonLogs
{
	public class SunkenGUI : DraedonsLogGUI
	{
		public override int TotalPages => 3;

		public override string GetTextByPage()
		{
			switch (Page)
			{
				case 0:
					return "Préservée durant des millénaires, un paradis pour les êtres vivants qui ont cherché refuge dans les mers préhistoriques. " +
                        "Ils restent à l'écart de l'évolution, exception faite de leur adaptation aux eaux pauvres en oxygène et aux cristaux, continuant à prospérer. " +
                        "En revanche, un mystère continue à m'échapper. Comment certaines de ces créatures ont pu devenir aussi grosses? " +
                        "Il y a un manque flagrant de nourriture et d'oxygène dans ces cavernes, et pourtant...";
				case 1:
					return "La vie marine dans ces cavernes possèdent des yeux, même s'il sont à peine fonctionnels, affaiblis par leur manque d'utilisation et d'une couleur blanc lait quand on les observe. " +
                        "Sur leurs peaux rugueuses et noueuses, les cristaux trouvent une parfaite niche, et y poussent en grand nombre, protégeant les créatures en contrepartie. " +
                        "Peut-être une autre des adaptations de leur évolution. Le mystère le plus étonnant se trouve au sein de leurs corps. " +
                        "Dans les spécimens que j'ai disséqués, j'ai remarqué que le minerai s'est fiché jusqu'à leurs organes digestifs, et peut-être, via un procédé chimique, procurent des nutriments à leurs hôtes léthargiques. " +
                        "Une intéraction particulière, mais entièrement bénéfique.";
				default:
					return "Un spécimen qui à grandement développé sa taille, et a inexplicablement développé d'impressionnantes capacités psychiques. " +
                        "Ce qui est le plus curieux, c'est sa forte connexion avec ses semblables inférieurs. " +
                        "Sans aucune communication apparente, quand il est menacé, les autres mollusques se rassemblent et attaquent son agresseur. " +
                        "C'est peut-être les tout premiers signes d'une forme de vie supérieure, un chainon de l'évolution caché dans la mer coulée? " +
                        "Où un coup de chance auto-destructeur, qui les mènera vers leur destruction s'ils venaient a habiter n'importe quelle autre zone que ces cavernes pacifiés.";
			}
		}

		public override Texture2D GetTextureByPage()
		{
			switch (Page)
			{
				case 0:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogSunkenSeaBiome").Value;
				case 1:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogEutrophicRayGhostBell").Value;
				default:
					return ModContent.Request<Texture2D>("CalamityMod/ExtraTextures/UI/DraedonsLogGiantClam").Value;
			}
		}
	}
}
