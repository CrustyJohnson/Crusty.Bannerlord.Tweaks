using Crusty.Bannerlord.Tweaks.GameModels;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Crusty.Bannerlord.Tweaks
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);
            if (!(game.GameType is Campaign))
                return;
            CampaignGameStarter campaignGameStarter = (CampaignGameStarter)gameStarter;
            this.AddModels(gameStarter);
            InformationManager.DisplayMessage(new InformationMessage("Crusty.Bannerlord.Story.GameModels - Loaded"));
            this.AddBehaviors(campaignGameStarter);
            InformationManager.DisplayMessage(new InformationMessage("Crusty.Bannerlord.Story.Behaviors - Loaded"));


        }

        private void AddBehaviors(CampaignGameStarter campaignGameStarter)
        {



        }


        private void AddModels(IGameStarter gameStarter)
        {
            gameStarter.AddModel(new CrustyCombatXpModel());
            gameStarter.AddModel(new CrustyGenericXpModel());
        }
    }
}