using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace Calamity_FR
{
    [Label("Traduction de Calamity")]
    [BackgroundColor(49, 32, 36, 216)]
    public class TranslationConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Ajustements")]
        [Label("Noms des objets en français")]
        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(false)]
        [Tooltip("Affiche les noms des objets en français")]
        [ReloadRequired]
        public bool nameInFrench
        {
            get;
            set;
        }

        [Label("Noms des objets en anglais en plus du français")]
        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(false)]
        [Tooltip("Affiche le nom des objets en français, puis le nom en anglais entre parenthèses (Utile pour le wiki)")]
        [ReloadRequired]
        public bool nameInEnglishWithFrench
        {
            get;
            set;
        }

        /*public override void OnChanged()
        {
            base.OnChanged();
        }*/
    }
}
