using System;
using System.Collections.Generic;
using TaleWorlds.MountAndBlade;
using System.Linq;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace TownArmorerOrderMod
{
    public class TownArmorerOrderModSubModule : MBSubModuleBase
    {
        public override void OnGameInitializationFinished(Game game)
        {
            base.OnGameInitializationFinished(game);
            Campaign.Current.CampaignBehaviorManager.AddBehavior(new TownArmorerCampaignBehavior());
        }
    }
}
