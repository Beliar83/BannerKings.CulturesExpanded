using BannerKings.Managers.Skills;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.CC
{
    internal class BKCECreationContent : SandboxCharacterCreationContent
    {
        protected override void OnInitialized(CharacterCreation characterCreation)
        {
            AddParentsMenu(characterCreation);
            AddChildhoodMenu(characterCreation);
            AddEducationMenu(characterCreation);
            AddYouthMenu(characterCreation);
            AddAdulthoodMenu(characterCreation);
            AddAgeSelectionMenu(characterCreation);

            _startingPoints.Add("siri", new Vec2(385.5405f, 53.993f));
            _startingPoints.Add("darshi", new Vec2(765.1729f, 150.5149f));
            _startingPoints.Add("geroia", new Vec2(478.6044f, 217.9456f));
            _startingPoints.Add("nord", new Vec2(170.9158f, 587.5662f));
            _startingPoints.Add("massa", new Vec2(191.1839f, 181.5139f));
            _startingPoints.Add("vakken", new Vec2(642.2234f, 624.5721f));
            _startingPoints.Add("kannic", new Vec2(262.9534f, 263.2021f));
            _startingPoints.Add("balion", new Vec2(61.83505f, 334.9693f));
            _startingPoints.Add("bragantia", new Vec2(61.83505f, 334.9693f));
            _startingPoints.Add("lokti", new Vec2(800.6518f, 717.6616f));
            _startingPoints.Add("iltanlar", new Vec2(730.2615f, 536.8068f));
            _startingPoints.Add("zendar", new Vec2(319.775f, 521.8525f));

            _startingPoints.Add("rhodok", new Vec2(207.04f, 389.04f));
            _startingPoints.Add("swadia", new Vec2(207.04f, 389.04f));
        }

        protected new void AddParentsMenu(CharacterCreation characterCreation) 
        {
            base.AddParentsMenu(characterCreation);
            CharacterCreationMenu menu = characterCreation.GetCurrentMenu(0);
            CharacterCreationCategory massaCategory = menu
                .AddMenuCategory(new CharacterCreationOnCondition(MassaCondition));

            MBList<SkillObject> effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.OneHanded
            };
            CharacterAttribute effectedAttribute = DefaultCharacterAttributes.Vigor;
            massaCategory.AddCategoryOption(new TextObject("{=!}Gahlaiba", null),
                effectedSkills, 
                effectedAttribute, 
                FocusToAdd, 
                SkillLevelToAdd, 
                AttributeLevelToAdd, 
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation, 
                1, 
                OccupationTypes.Retainer, 
                "", 
                "", 
                true,
                true), 
                (CharacterCreation characterCreation) => FinalizeParents(), 
                new TextObject("{=!}Your father served as a Gahlaiba to one of the Massa chiefs, teaching you the basics of fencing and riding.", null), 
                null, 
                0, 
                0, 
                0, 
                0, 
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Polearm,
                DefaultSkills.Athletics
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            massaCategory.AddCategoryOption(new TextObject("{=!}Migration Herders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents migrated south to Niuja Landa in the Great Migration, when the Massa forged their own realm.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            massaCategory.AddCategoryOption(new TextObject("{=!}Woodland Foresters", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father works as a forester and explorer, going deep into the woods. At times with the Widugauja, the woodspeople, at times against them. The woods are thick and filled with both beasts and disease...", null),
                null,
                0,
                0,
                0,
                0,
                0);


            CharacterCreationCategory darshiCategory = menu
               .AddMenuCategory(new CharacterCreationOnCondition(DarshiCondition));

            effectedSkills = new MBList<SkillObject>
            {
                BKSkills.Instance.Scholarship,
                BKSkills.Instance.Theology
            };
            effectedAttribute = BKAttributes.Instance.Wisdom;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Herbad", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Healer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as a Herbad to the Atashyasna - the faith of the Darshi. He taught you writting and literature, specially by means of the holy poetry of the Atash.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Bow,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Aswar", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Aswaran, teaching your in both the way of the lance and bow.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            darshiCategory.AddCategoryOption(new TextObject("{=!}Date Farmers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents farmed the Teyagh riverbanks, ripe for grains and dates.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory siriCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(SiriCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Medicine,
                BKSkills.Instance.Theology
            };
            effectedAttribute = BKAttributes.Instance.Wisdom;
            siriCategory.AddCategoryOption(new TextObject("{=!}Tillik-Itt", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Healer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your mother served as a Tillik-Itt - a wisewoman, responsible for upholding the faith of the Siri. She taught you herb medicine and religious practices.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Bow
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            siriCategory.AddCategoryOption(new TextObject("{=!}Kandi", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your mother served as a Kandi - one of the expert woman archers of the Siri. They are known for their trueshot and ability to pursue their prey unrelentlessly.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            siriCategory.AddCategoryOption(new TextObject("{=!}Date Farmers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents the Aman riverbanks, ripe for grains, dates and papyrus.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory geroiaCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(GeroiaCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Privateer", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Geroian privateers, renowned for their fencing skills and their firebombs, both deadly in battles on ship decks.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Steward
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Sea Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father travelled around the Perassic and Jade seas making a living out of the rich sea trade. Your mother stayed on land, managing their assets.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Roguery,
                DefaultSkills.Trade
            };
            effectedAttribute = DefaultCharacterAttributes.Cunning;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Slavers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Mercenary,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father traded slaves across the seas, both 'legally' and otherwise.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            geroiaCategory.AddCategoryOption(new TextObject("{=!}Sheep Herders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents raised sheep in the rocky slops of the Geroian islands. Since young, you pursed sheep and scared predators away.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory nordCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(NordCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            nordCategory.AddCategoryOption(new TextObject("{=!}Settlers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents came from Jumne to settle in Calradia. They have lived their lives as agricultural workers by one of the Jumne colonies such as Tihr and Rovalt.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            nordCategory.AddCategoryOption(new TextObject("{=!}Shipbilders", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father built longships, very demanded by the Jumne expeditioners. He taught you crafting and woodworking since a young age.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.Trade
            };
            effectedAttribute = DefaultCharacterAttributes.Control;
            nordCategory.AddCategoryOption(new TextObject("{=!}Whalers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father sailed the deep sea for whaling. Since a young age, he taught you both how to hunt the beasts with true javelin strikes, and how to bargain it for maximum profit.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory vakkenCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(VakkenCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Throwing,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Seuralainen", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Seuralainen: companions to a Vakken chief. He taught in the art of sword and javelin, but unlike most Vakken youngs, your targets were to be human foes rather than beasts....", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Bow,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Foresters", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Hunter,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical Vakken foresters: they hunted and skinned game, a long tradition of the Vakken tribes.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Scouting
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            vakkenCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were itinerary merchants: they went town to town, haggling prices. Most of all they traded northern furs and timber.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory balionCategory = menu
              .AddMenuCategory(new CharacterCreationOnCondition(BalionCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.TwoHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            balionCategory.AddCategoryOption(new TextObject("{=!}Huscarl", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Huscarls, the companions of Balion aristocrats. He taught you athleticism and the way of long ax.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            balionCategory.AddCategoryOption(new TextObject("{=!}Tenants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical Balion tenant farms. On your youth, you tended to the farm and farm animals, scaring off predators with your father's spear.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.OneHanded
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            balionCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were sea traders. Their trips often took them between Balion and Calradia, bringing wine, silks and olives to your homeland. Due to Jumne raiders spread out across the trade routes, your father taught you how to defend yourself.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory bragantiaCategory = menu
             .AddMenuCategory(new CharacterCreationOnCondition(BiscaniaCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Throwing
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Mesnadeiro", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father served as one of the Mesnadeiros, companions to the isle lords. He taught you in the way of fighting, specially ship deck fighting.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Endurance;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Cattle Raisers", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Farmer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were typical cattle raises of the Biscanian islands. The lush grassy hills and mild weather have long sustained this tradition.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Crafting
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            bragantiaCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were sea traders and artisans. They traded often at the port city of Bragantja, where trade routes from all directions converge.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory kannicCategory = menu
             .AddMenuCategory(new CharacterCreationOnCondition(KannicCondition));

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.OneHanded,
                DefaultSkills.Polearm
            };
            effectedAttribute = DefaultCharacterAttributes.Vigor;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Citizen Militia", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                1,
                OccupationTypes.Retainer,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your father was part of the citizen class, a high class within Kannic society. He served with the citizen militia as a hoplite, and taught you the basics of Kannic warfare.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.Steward
            };
            effectedAttribute = DefaultCharacterAttributes.Intelligence;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Urban Artisans", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                2,
                OccupationTypes.Artisan,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were part of the lively manufacting economy within Lys. They taught you craftsmanship and how to take care of your assets.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            effectedSkills = new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Athletics
            };
            effectedAttribute = DefaultCharacterAttributes.Social;
            kannicCategory.AddCategoryOption(new TextObject("{=!}Merchants", null),
                effectedSkills,
                effectedAttribute,
                FocusToAdd,
                SkillLevelToAdd,
                AttributeLevelToAdd,
                null,
                (CharacterCreation characterCreation) => SetParentAndOccupationType(characterCreation,
                3,
                OccupationTypes.Merchant,
                "",
                "",
                true,
                true),
                (CharacterCreation characterCreation) => FinalizeParents(),
                new TextObject("{=!}Your parents were itinerary traders, travelling much of Calradia in search of profit. You accompanied them and learned how to endure the trips and make the best profit.", null),
                null,
                0,
                0,
                0,
                0,
                0);

            CharacterCreationCategory wilundingCategory = menu.AddMenuCategory(WilundingCondition);
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.Polearm
            }, effectedAttribute: DefaultCharacterAttributes.Social, text: new TextObject("{=2TptWc4m}A baron's retainers"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaBaronsRetainerOnConsequence, onApply: VlandiaBaronsRetainerOnApply, descriptionText: new TextObject("{=0Suu1Q9q}Your father was a bailiff for a local feudal magnate. He looked after his liege's estates, resolved disputes in the village, and helped train the village levy. He rode with the lord's cavalry, fighting as an armored knight."));
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Charm
            }, effectedAttribute: DefaultCharacterAttributes.Intelligence, text: new TextObject("{=651FhzdR}Urban merchants"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaMerchantOnConsequence, onApply: VlandiaMerchantOnApply, descriptionText: new TextObject("{=qNZFkxJb}Your family were merchants in one of the main cities of the kingdom. They organized caravans to nearby towns and were active in the local merchant's guild."));
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Polearm,
                DefaultSkills.Crossbow
            }, effectedAttribute: DefaultCharacterAttributes.Endurance, text: new TextObject("{=RDfXuVxT}Yeomen"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaYeomanOnConsequence, onApply: VlandiaYeomanOnApply, descriptionText: new TextObject("{=BLZ4mdhb}Your family were small farmers with just enough land to feed themselves and make a small profit. People like them were the pillars of the kingdom's economy, as well as the backbone of the levy."));
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.TwoHanded
            }, effectedAttribute: DefaultCharacterAttributes.Vigor, text: new TextObject("{=p2KIhGbE}Urban blacksmith"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaBlacksmithOnConsequence, onApply: VlandiaBlacksmithOnApply, descriptionText: new TextObject("{=btsMpRcA}Your family owned a smithy in a city. Your father played an active if minor role in the town council, and also served in the militia."));
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Scouting,
                DefaultSkills.Crossbow
            }, effectedAttribute: DefaultCharacterAttributes.Control, text: new TextObject("{=YcnK0Thk}Hunters"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaHunterOnConsequence, onApply: VlandiaHunterOnApply, descriptionText: new TextObject("{=yRFSzSDZ}Your family lived in a village, but did not own their own land. Instead, your father supplemented paid jobs with long trips in the woods, hunting and trapping, always keeping a wary eye for the lord's game wardens."));
            wilundingCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Roguery,
                DefaultSkills.Crossbow
            }, effectedAttribute: DefaultCharacterAttributes.Cunning, text: new TextObject("{=ipQP6aVi}Mercenaries"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: VlandiaMercenaryOnConsequence, onApply: VlandiaMercenaryOnApply, descriptionText: new TextObject("{=yYhX6JQC}Your father joined one of Vlandia's many mercenary companies, composed of men who got such a taste for war in their lord's service that they never took well to peace. Their crossbowmen were much valued across Calradia. Your mother was a camp follower, taking you along in the wake of bloody campaigns."));

            CharacterCreationCategory iltanlarCategory = menu.AddMenuCategory(IltanlarCondition);
            iltanlarCategory.AddCategoryOption(new TextObject("{=FVaRDe2a}A noyan's kinsfolk"), new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.Polearm
            }, DefaultCharacterAttributes.Endurance, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitNoyansKinsmanOnConsequence, KhuzaitNoyansKinsmanOnApply, new TextObject("{=jAs3kDXh}Your family were the trusted kinsfolk of a Khuzait noyan, and shared his meals in the chieftain's yurt. Your father assisted his chief in running the affairs of the clan and fought in the core of armored lancers in the center of the Khuzait battle line."));
            iltanlarCategory.AddCategoryOption(new TextObject("{=TkgLEDRM}Merchants"), new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Charm
            }, DefaultCharacterAttributes.Social, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitMerchantOnConsequence, KhuzaitMerchantOnApply, new TextObject("{=qPg3IDiq}Your family came from one of the merchant clans that dominated the cities in eastern Calradia before the Khuzait conquest. They adjusted quickly to their new masters, keeping the caravan routes running and ensuring that the tariff revenues that once went into imperial coffers now flowed to the khanate."));
            iltanlarCategory.AddCategoryOption(new TextObject("{=tGEStbxb}Tribespeople"), new MBList<SkillObject>
            {
                DefaultSkills.Bow,
                DefaultSkills.Riding
            }, DefaultCharacterAttributes.Control, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitTribesmanOnConsequence, KhuzaitTribesmanOnApply, new TextObject("{=URgZ4ai4}Your family were middle-ranking members of one of the Khuzait clans. He had some  herds of his own, but was not rich. When the Khuzait horde was summoned to battle, he fought with the horse archers, shooting and wheeling and wearing down the enemy before the lancers delivered the final punch."));
            iltanlarCategory.AddCategoryOption(new TextObject("{=gQ2tAvCz}Farmers"), new MBList<SkillObject>
            {
                DefaultSkills.Polearm,
                DefaultSkills.Throwing
            }, DefaultCharacterAttributes.Vigor, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitFarmerOnConsequence, KhuzaitFarmerOnApply, new TextObject("{=5QSGoRFj}Your family tilled one of the small patches of arable land in the steppes for generations. When the Khuzaits came, they ceased paying taxes to the emperor and providing conscripts for his army, and served the khan instead."));
            iltanlarCategory.AddCategoryOption(new TextObject("{=vfhVveLW}Shamans"), new MBList<SkillObject>
            {
                DefaultSkills.Medicine,
                DefaultSkills.Charm
            }, DefaultCharacterAttributes.Intelligence, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitShamanOnConsequence, KhuzaitShamanOnApply, new TextObject("{=WOKNhaG2}Your family were guardians of the sacred traditions of the Khuzaits, channelling the spirits of the wilderness and of the ancestors. They tended the sick and dispensed wisdom, resolving disputes and providing practical advice."));
            iltanlarCategory.AddCategoryOption(new TextObject("{=Xqba1Obq}Nomads"), new MBList<SkillObject>
            {
                DefaultSkills.Scouting,
                DefaultSkills.Riding
            }, DefaultCharacterAttributes.Cunning, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, KhuzaitNomadOnConsequence, KhuzaitNomadOnApply, new TextObject("{=9aoQYpZs}Your family's clan never pledged its loyalty to the khan and never settled down, preferring to live out in the deep steppe away from his authority. They remain some of the finest trackers and scouts in the grasslands, as the ability to spot an enemy coming and move quickly is often all that protects their herds from their neighbors' predations."));

            CharacterCreationCategory loktiCategory = menu.AddMenuCategory(LoktiCondition);
            loktiCategory.AddCategoryOption(new TextObject("{=mc78FEbA}A boyar's companions"), new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.TwoHanded
            }, DefaultCharacterAttributes.Social, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaBoyarsCompanionOnConsequence, SturgiaBoyarsCompanionOnApply, new TextObject("{=hob3WVkU}Your father was a member of a boyar's druzhina, the 'companions' that make up his retinue. He sat at his lord's table in the great hall, oversaw the boyar's estates, and stood by his side in the center of the shield wall in battle."));
            loktiCategory.AddCategoryOption(new TextObject("{=HqzVBfpl}Urban traders"), new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Tactics
            }, DefaultCharacterAttributes.Cunning, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaTraderOnConsequence, SturgiaTraderOnApply, new TextObject("{=bjVMtW3W}Your family were merchants who lived in one of Sturgia's great river ports, organizing the shipment of the north's bounty of furs, honey and other goods to faraway lands."));
            loktiCategory.AddCategoryOption(new TextObject("{=zrpqSWSh}Free farmers"), new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            }, DefaultCharacterAttributes.Endurance, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaFreemanOnConsequence, SturgiaFreemanOnApply, new TextObject("{=Mcd3ZyKq}Your family had just enough land to feed themselves and make a small profit. People like them were the pillars of the kingdom's economy, as well as the backbone of the levy."));
            loktiCategory.AddCategoryOption(new TextObject("{=v48N6h1t}Urban artisans"), new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.OneHanded
            }, DefaultCharacterAttributes.Intelligence, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaArtisanOnConsequence, SturgiaArtisanOnApply, new TextObject("{=ueCm5y1C}Your family owned their own workshop in a city, making goods from raw materials brought in from the countryside. Your father played an active if minor role in the town council, and also served in the militia."));
            loktiCategory.AddCategoryOption(new TextObject("{=YcnK0Thk}Hunters"), new MBList<SkillObject>
            {
                DefaultSkills.Scouting,
                DefaultSkills.Bow
            }, DefaultCharacterAttributes.Vigor, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaHunterOnConsequence, SturgiaHunterOnApply, new TextObject("{=WyZ2UtFF}Your family had no taste for the authority of the boyars. They made their living deep in the woods, slashing and burning fields which they tended for a year or two before moving on. They hunted and trapped fox, hare, ermine, and other fur-bearing animals."));
            loktiCategory.AddCategoryOption(new TextObject("{=TPoK3GSj}Vagabonds"), new MBList<SkillObject>
            {
                DefaultSkills.Roguery,
                DefaultSkills.Throwing
            }, DefaultCharacterAttributes.Control, FocusToAdd, SkillLevelToAdd, AttributeLevelToAdd, null, SturgiaVagabondOnConsequence, SturgiaVagabondOnApply, new TextObject("{=2SDWhGmQ}Your family numbered among the poor migrants living in the slums that grow up outside the walls of the river cities, making whatever money they could from a variety of odd jobs. Sometimes they did services for one of the region's many criminal gangs."));

            CharacterCreationCategory zendarCategory = menu.AddMenuCategory(ZendarCondition);
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Riding,
                DefaultSkills.Polearm
            }, effectedAttribute: DefaultCharacterAttributes.Vigor, text: new TextObject("{=InN5ZZt3}A landlord's retainers"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireLandlordsRetainerOnConsequence, onApply: EmpireLandlordsRetainerOnApply, descriptionText: new TextObject("{=ivKl4mV2}Your father was a trusted lieutenant of the local landowning aristocrat. He rode with the lord's cavalry, fighting as an armored lancer."));
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Trade,
                DefaultSkills.Charm
            }, effectedAttribute: DefaultCharacterAttributes.Social, text: new TextObject("{=651FhzdR}Urban merchants"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireMerchantOnConsequence, onApply: EmpireMerchantOnApply, descriptionText: new TextObject("{=FQntPChs}Your family were merchants in one of the main cities of the Empire. They sometimes organized caravans to nearby towns, and discussed issues in the town council."));
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Athletics,
                DefaultSkills.Polearm
            }, effectedAttribute: DefaultCharacterAttributes.Endurance, text: new TextObject("{=sb4gg8Ak}Freeholders"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireFreeholderOnConsequence, onApply: EmpireFreeholderOnApply, descriptionText: new TextObject("{=09z8Q08f}Your family were small farmers with just enough land to feed themselves and make a small profit. People like them were the pillars of the imperial rural economy, as well as the backbone of the levy."));
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Crafting,
                DefaultSkills.Crossbow
            }, effectedAttribute: DefaultCharacterAttributes.Intelligence, text: new TextObject("{=v48N6h1t}Urban artisans"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireArtisanOnConsequence, onApply: EmpireArtisanOnApply, descriptionText: new TextObject("{=ueCm5y1C}Your family owned their own workshop in a city, making goods from raw materials brought in from the countryside. Your father played an active if minor role in the town council, and also served in the militia."));
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Scouting,
                DefaultSkills.Bow
            }, effectedAttribute: DefaultCharacterAttributes.Control, text: new TextObject("{=7eWmU2mF}Foresters"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireWoodsmanOnConsequence, onApply: EmpireWoodsmanOnApply, descriptionText: new TextObject("{=yRFSzSDZ}Your family lived in a village, but did not own their own land. Instead, your father supplemented paid jobs with long trips in the woods, hunting and trapping, always keeping a wary eye for the lord's game wardens."));
            zendarCategory.AddCategoryOption(effectedSkills: new MBList<SkillObject>
            {
                DefaultSkills.Roguery,
                DefaultSkills.Throwing
            }, effectedAttribute: DefaultCharacterAttributes.Cunning, text: new TextObject("{=aEke8dSb}Urban vagabonds"), focusToAdd: FocusToAdd, skillLevelToAdd: SkillLevelToAdd, attributeLevelToAdd: AttributeLevelToAdd, optionCondition: null, onSelect: EmpireVagabondOnConsequence, onApply: EmpireVagabondOnApply, descriptionText: new TextObject("{=Jvf6K7TZ}Your family numbered among the many poor migrants living in the slums that grow up outside the walls of imperial cities, making whatever money they could from a variety of odd jobs. Sometimes they did service for one of the Empire's many criminal gangs, and you had an early look at the dark side of life."));
        }

        protected bool WilundingCondition() => GetSelectedCulture().StringId == "rhodok" || GetSelectedCulture().StringId == "swadia";
        protected bool MassaCondition() => GetSelectedCulture().StringId == "massa";
        protected bool ZendarCondition() => GetSelectedCulture().StringId == "zendar";
        protected bool LoktiCondition() => GetSelectedCulture().StringId == "lokti";
        protected bool IltanlarCondition() => GetSelectedCulture().StringId == "iltanlar";
        protected bool DarshiCondition() => GetSelectedCulture().StringId == "darshi";
        protected bool SiriCondition() => GetSelectedCulture().StringId == "siri";
        protected bool GeroiaCondition() => GetSelectedCulture().StringId == "geroia";
        protected bool NordCondition() => GetSelectedCulture().StringId == "nord";
        protected bool VakkenCondition() => GetSelectedCulture().StringId == "vakken";
        protected bool BiscaniaCondition() => GetSelectedCulture().StringId == "bragantia";
        protected bool BalionCondition() => GetSelectedCulture().StringId == "balion";
        protected bool KannicCondition() => GetSelectedCulture().StringId == "kannic";
    }
}
