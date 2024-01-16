using System.Collections.Generic;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCEFeats : DefaultTypeInitializer<BKCEFeats, FeatObject>
    {
        public FeatObject SailingSpeed { get; set; }
        public FeatObject SailingBattle { get; set; }
        public FeatObject VillageMilitia { get; set; }
        public FeatObject Vakken1 { get; set; }
        public FeatObject Vakken2 { get; set; }
        public FeatObject Vakken3 { get; set; }
        public FeatObject SouthernAgriculture { get; set; }
        public FeatObject Demobilization { get; set; }
        public FeatObject Bragantia1 { get; set; }
        public FeatObject Empire1 { get; set; }
        public FeatObject Siri1 { get; set; }
        public FeatObject Megalopolis { get; set; }
        public FeatObject Kannic1 { get; set; }
        public FeatObject Darshi1 { get; set; }
        public FeatObject Massa1 { get; set; }
        public FeatObject Massa2 { get; set; }
        public FeatObject Geroia1 { get; set; }
        public FeatObject Geroia2 { get; set; }

        public override IEnumerable<FeatObject> All => throw new System.NotImplementedException();

        public override void Initialize()
        {
            Geroia1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_geroia_trade"));
            Geroia1.Initialize("BKCE_geroia_trade",
                "{=!}Perassic Tradition: Fiefs have increased trade power (20%).",
                0.2f,
                true,
                FeatObject.AdditionType.AddFactor);

            Geroia2 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_geroia_slaves"));
            Geroia2.Initialize("BKCE_geroia_slaves",
                "{=!}Slave Trade: Slaves generate more taxes, but other population classes generate less (50%).",
                -0.5f,
                false,
                FeatObject.AdditionType.AddFactor);

            Massa1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_massa_pillage"));
            Massa1.Initialize("BKCE_massa_pillage",
                "{=!}Gatairan Tradition: Increased raid speed and money from town pillaging.",
                0.15f,
                true,
                FeatObject.AdditionType.Add);

            Massa2 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_massa_unruly"));
            Massa2.Initialize("BKCE_massa_unruly",
                "{=!}Unruly Massa: Fiefs have -0.5 security and prosperity.",
                -0.5f,
                false,
                FeatObject.AdditionType.Add);

            Darshi1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_darshi_infantry"));
            Darshi1.Initialize("BKCE_darshi_infantry",
                "{=!}Paighanan: Darshi infantry take 30% more experience to upgrade.",
                0.3f,
                false,
                FeatObject.AdditionType.AddFactor);

            Kannic1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_kannic_troops"));
            Kannic1.Initialize("BKCE_kannic_troops",
                "{=!}Mercenary Reliance: Volunteers cost more upkeep and replenish slower (10%).",
                0.1f,
                false,
                FeatObject.AdditionType.AddFactor);

            Megalopolis = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_megalopolis"));
            Megalopolis.Initialize("BKCE_megalopolis",
                "{=!}Megalopolis Tradition: Cities have 30% more population capacity.",
                0.3f,
                true,
                FeatObject.AdditionType.AddFactor);

            SailingSpeed = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_sailing_speed"));
            SailingSpeed.Initialize("BKCE_sailing_speed",
                "{=!}Naval Tradition: Parties are 15% faster while sailing. No morale penalty while sailing.",
                0.15f,
                true,
                FeatObject.AdditionType.AddFactor);

            SailingBattle = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_sailing_battle"));
            SailingBattle.Initialize("BKCE_sailing_battle",
                "{=!}Naval Tradition: Parties are 10% more effective in autoresolve battles while sailing.",
                0.1f,
                true,
                FeatObject.AdditionType.Add);

            VillageMilitia = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_village_militia"));
            VillageMilitia.Initialize("BKCE_village_militia",
                "{=!}Village Militia Tradition: Villages produce +2 militia.",
                2f,
                true,
                FeatObject.AdditionType.Add);

            Demobilization = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_demobilization"));
            Demobilization.Initialize("BKCE_demobilization",
                "{=!}Demobilization: Volunteers take 25% longer to replenish.",
                -0.25f,
                false,
                FeatObject.AdditionType.AddFactor);

            Bragantia1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_bragantia_production"));
            Bragantia1.Initialize("BKCE_bragantia_production",
                "{=!}Biscanian Tradition: cattle, grape and olive villages are 30% more productive.",
                0.3f,
                true,
                FeatObject.AdditionType.AddFactor);

            Empire1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_empire_production"));
            Empire1.Initialize("BKCE_empire_production",
                "{=!}Calradoi Tradition: livestock and olive villages are 20% more productive.",
                0.2f,
                true,
                FeatObject.AdditionType.AddFactor);

            Vakken1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_vakken_production"));
            Vakken1.Initialize("BKCE_vakken_production",
                "{=!}Meccastaaja Tradition: villages produce 20% more furs, wood and honey.",
                0.2f,
                true,
                FeatObject.AdditionType.AddFactor);

            Vakken2 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_vakken_snow"));
            Vakken2.Initialize("BKCE_vakken_snow",
                "{=!}Lumi Tradition: Party speed unaffected by snow and blizzards.",
                0.2f,
                true,
                FeatObject.AdditionType.Add);

            Vakken3 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_vakken_swidden"));
            Vakken3.Initialize("BKCE_vakken_swidden",
                "{=!}Swidden Agriculture: Agriculture and livestock villages are 30% less productive.",
                -0.3f,
                true,
                FeatObject.AdditionType.AddFactor);

            SouthernAgriculture = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_south_production"));
            SouthernAgriculture.Initialize("BKCE_south_production",
                "{=!}Agriculture Tradition: 25% production bonus to grains, papyrus and dates.",
                0.25f,
                true,
                FeatObject.AdditionType.AddFactor);

            Siri1 = Game.Current.ObjectManager.RegisterPresumedObject(new FeatObject("BKCE_siri_archers"));
            Siri1.Initialize("BKCE_siri_archers",
                "{=!}Bow Tradition: bow infantry is 30% cheaper to recruit.",
                -0.3f,
                true,
                FeatObject.AdditionType.AddFactor);
        }

        public void UpdateVanilla()
        {
            DefaultCulturalFeats.KhuzaitAnimalProductionFeat.Initialize("{=!}khuzait_increased_animal_production", 
                "{=!}Pastoral Tradition: 25% production bonus to horse, mule, cow and sheep in villages.", 
                0.25f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.EmpireVillageHearthFeat.Initialize("{=!}empire_slower_hearth_production", 
                "{=1}Depopulation: Village hearths increase 20% less.", 
                -0.2f, 
                false, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.AseraiTraderFeat.Initialize("{=!}aserai_cheaper_caravans", 
                "{=!}Mercantile Tradition: Caravans are 30% cheaper to build. 10% less trade penalty.", 
                0.7f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.SturgianRecruitUpgradeFeat.Initialize("{=!}sturgian_cheaper_recruits_infantry", 
                "{=!}Infantry Tradition: Recruiting and upgrading infantry troops are 25% cheaper.", 
                -0.25f, 
                true, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.BattanianForestSpeedFeat.Initialize("{=!}battanian_forest_speed",
                "{=!}Woodland Tradition: 50% less speed penalty and 15% sight range bonus in forests.",
                0.5f,
                true,
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.BattanianConstructionFeat.Initialize("{=!}battanian_slower_construction", 
                "{=!}Undeveloped Masonry: 10% slower build rate for town projects in settlements.",
                -0.1f, 
                false, 
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.BattanianMilitiaFeat.Initialize("{=!}battanian_militia_production",
                "{=!}Citizen Militia Tradition: towns have +1 militia production.",
                1f,
                true,
                FeatObject.AdditionType.Add);

            DefaultCulturalFeats.VlandianCastleVillageProductionFeat.Initialize("{=!}vlandian_villages_production_bonus",
                "{=!}Buhr Tradition: villages bound to castles (burhs) are 10% more productive.",
                0.1f,
                true,
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.VlandianRenownMercenaryFeat.Initialize("{=!}vlandian_renown_mercenary_income",
                "{=!}Mercenary Tradition: 5% more renown from the battles, 15% more income while serving as a mercenary.",
                0.05f,
                true,
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.VlandianArmyInfluenceFeat.Initialize("{=!}vlandian_increased_army_influence_cost",
                "{=!}Autonomous Lords: recruiting lords to armies costs 20% more influence.",
                0.2f,
                false,
                FeatObject.AdditionType.AddFactor);

            DefaultCulturalFeats.SturgianArmyCohesionFeat.Initialize("{=!}sturgian_decreased_cohesion_rate",
                "{=!}Cohesive Leadership: armies lose 20% less daily cohesion.",
                -0.2f,
                true,
                FeatObject.AdditionType.AddFactor);
        }
    }
}
