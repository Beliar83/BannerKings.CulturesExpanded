﻿using BannerKings.CulturesExpanded.Behaviors;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Goals;
using BannerKings.CulturesExpanded.Models;
using BannerKings.CulturesExpanded.Religions;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using System.Collections.Generic;
using System.Linq;
using BannerKings.CulturesExpanded.CC;
using HarmonyLib;
using BannerKings.Managers.Recruits;

namespace BannerKings.CulturesExpanded
{
    public class Main : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);
            if (gameStarter is not CampaignGameStarter campaignStarter)
            {
                return;
            }

            campaignStarter.AddBehavior(new CrownGuardBehavior());
            campaignStarter.AddBehavior(new FeatBehavior());
            //campaignStarter.AddBehavior(new DryaticBehavior());

            campaignStarter.AddModel(new BKCEInfluenceModel());
            campaignStarter.AddModel(new BKCELoyaltyModel());
            campaignStarter.AddModel(new BKCEProsperityModel());
            campaignStarter.AddModel(new BKCEVolunteerModel());
            campaignStarter.AddModel(new BKCEPartySpeedModel());
            campaignStarter.AddModel(new BKCEDeathModel());
            campaignStarter.AddModel(new BKCEPartyHealingModel());
            campaignStarter.AddModel(new BKCEPartyMorale());
            campaignStarter.AddModel(new BKCEPriceModel());
            campaignStarter.AddModel(new BKCESecurityModel());
            campaignStarter.AddModel(new BKCETaxModel());
            campaignStarter.AddModel(new BKCETroopUpgradeModel());
            campaignStarter.AddModel(new BKCEVillageProductionModel());
            campaignStarter.AddModel(new BKCEEconomyModel());
            campaignStarter.AddModel(new BKCEMilitiaModel());
            campaignStarter.AddModel(new BKCERaidModel());
            campaignStarter.AddModel(new BKCEPartyWageModel());
            campaignStarter.AddModel(new BKCEBattleSimulationModel());
            campaignStarter.AddModel(new BKCEPartyFoodModel());
            campaignStarter.AddModel(new BKCEEquipmentModel());

            BannerKingsConfig.Instance.AddInitializer(BKCERecruitSpawns.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEPopulationNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCETitleNames.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKTOGoals.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEDivinities.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaithGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEFaiths.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEReligions.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCELanguages.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEMarketGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(BKCEShippingLanes.Instance);

            BannerKingsConfig.Instance.CultureModel = new BKCECultureModel();
            BannerKingsConfig.Instance.ReligionModel = new BKCEReligionModel();
            BannerKingsConfig.Instance.LegitimacyModel = new BKCELegitimacyModel();
            BannerKingsConfig.Instance.GrowthModel = new BKCEGrowthModel();

            BKCEFeats.Instance.Initialize();
            BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BannerKings.CulturesExpanded/ModuleData/titles.xml";
            BannerKingsConfig.Instance.RecruitsXmlPath = BasePath.Name + "Modules/BannerKings.CulturesExpanded/ModuleData/recruits.xml";
        }

        protected override void OnSubModuleLoad()
        {
            new Harmony("BannerKings.CulturesExpanded").PatchAll();
            List<InitialStateOption> _initialStateOptions = (List<InitialStateOption>)Module.CurrentModule.GetType()
                .GetField("_initialStateOptions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(Module.CurrentModule);

            InitialStateOption story = _initialStateOptions.First(x => x.Id == "StoryModeNewGame");
            InitialStateOption sb = _initialStateOptions.First(x => x.Id == "SandBoxNewGame");

            if (story != null) _initialStateOptions.Remove(story);
            if (sb != null) _initialStateOptions.Remove(sb);

            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("BKCE", new TextObject("{=!}Banner Kings", null), 3, delegate ()
            {
                MBGameManager.StartNewGame(new BKCEGameManager());
            }, () => new ValueTuple<bool, TextObject>(Module.CurrentModule.IsOnlyCoreContentEnabled, new TextObject("{=V8BXjyYq}Disabled during installation."))));
        }
    }
}