using System.Collections.Generic;
using System.Linq;
using BannerKings.Managers.Goals;
using BannerKings.Managers.Helpers;
using BannerKings.Managers.Titles;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Goals
{
    public class DarshiEmpireGoal : EmpireGoal
    {
        public override List<string> SettlementIds => new List<string> {
                "castle_V1",
                "castle_V2",
                "castle_V3",
                "castle_V4",
                "castle_V6",
                "castle_V7",
                "castle_V8",
                "town_V1",
                "town_V2",
                "town_V3",
                "town_V5",
                "town_V6",
                "town_V7",
                "town_V4",
                "town_V11",
                "town_V8",
                "town_Isles",
                "castle_Isles",
                "town_V10"
            };

        public override string TitleId => "goal_darshi_empire";

        public override (float Gold, float Influence) GetCosts(Hero hero)
        {
            return
            (
                500000 + BannerKingsConfig.Instance.ClanFinanceModel.CalculateClanIncome(hero.Clan).ResultNumber * CampaignTime.DaysInYear,
                1000 + BannerKingsConfig.Instance.InfluenceModel.CalculateInfluenceChange(hero.Clan).ResultNumber * CampaignTime.DaysInYear * 0.1f
            );
        }

        public DarshiEmpireGoal() : base("goal_darshi_empire", GoalCategory.Unique, GoalUpdateType.Settlement)
        {
            var name = new TextObject("{=!}Reunite Darshianshahr");
            var description = new TextObject("{=!}Many of the cities within the Devseg plateau were founded by Darshi settlers, long before any horselords seized them for themselves. Such cities are rightfully property of the Darshi people and the Shahanshah, king of kings. Reuniting them with the core Darshi lands would allow the Darshi to enjoy their former imperial glory.{newline}{newline}");

            Initialize(name, description);
        }

        public override bool IsAvailable()
        {
            return BannerKingsConfig.Instance.TitleManager.GetTitleByStringId(TitleId) == null;
        }

        public override bool IsFulfilled(out List<TextObject> failedReasons)
        {
            failedReasons = new List<TextObject>();

            var referenceHero = Hero.MainHero;
            var (gold, influence) = GetCosts(referenceHero);
            var culture = Utils.Helpers.GetCulture("darshi");

            if (!IsAvailable())
            {
                var title = BannerKingsConfig.Instance.TitleManager.GetTitleByStringId(TitleId);

                var failedReason = new TextObject("{=jHzaifoJ}This title is already founded! de Jure is {DE_JURE.LINK} and de Facto is {DE_FACTO.LINK}.");
                failedReason.SetCharacterProperties("DE_JURE", title.deJure.CharacterObject);
                failedReason.SetCharacterProperties("DE_FACTO", title.DeFacto.CharacterObject);

                failedReasons.Add(failedReason);
            }
            else
            {
                if (referenceHero.Gold < gold)
                {
                    failedReasons.Add(new TextObject("{=3KoOfniE}You need at least {GOLD}{GOLD_ICON}")
                        .SetTextVariable("GOLD", $"{gold:n0}"));
                }

                if (referenceHero.Clan.Influence < influence)
                {
                    failedReasons.Add(new TextObject("{=FWMoFfdT}You need at least {INFLUENCE}{INFLUENCE_ICON}")
                        .SetTextVariable("INFLUENCE", $"{influence:n0}")
                        .SetTextVariable("INFLUENCE_ICON", "<img src=\"General\\Icons\\Influence@2x\" extend=\"7\">"));
                }

                if (referenceHero.Culture != culture)
                {
                    failedReasons.Add(new TextObject("{=18Dv2nt4}You are not part of {CULTURE} culture.")
                        .SetTextVariable("CULTURE", culture.Name));
                }

                if (referenceHero.Clan.Kingdom != null)
                {
                    if (referenceHero.Clan.Kingdom.Culture != culture)
                    {
                        failedReasons.Add(new TextObject("{=4jUw7j4u}Your kingdom is not part of {CULTURE} culture.")
                            .SetTextVariable("CULTURE", culture.Name));
                    }

                    var title = BannerKingsConfig.Instance.TitleManager.GetSovereignTitle(referenceHero.Clan.Kingdom);
                    if (title == null)
                    {
                        failedReasons.Add(new TextObject("{=DnbZbcT7}Your kingdom has no title associated with it. Found a de Jure kingdom title for your faction."));
                    }
                    else if (title.TitleType == TitleType.Empire)
                    {
                        failedReasons.Add(new TextObject("{=!}Your realm, {REALM} is already attached to the Empire-level title {TITLE}.")
                            .SetTextVariable("REALM", referenceHero.Clan.Kingdom.Name)
                            .SetTextVariable("TITLE", title.FullName));
                    }
                } 
                else
                {
                    failedReasons.Add(new TextObject("{=YQhz7MP4}You are not a faction leader."));
                }

                var religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(referenceHero);
                if (religion == null || religion.Faith.GetId() != "atash")
                {
                    var atash = BannerKingsConfig.Instance.ReligionsManager.GetReligionById("atash");
                    if (atash != null)
                    {
                        failedReasons.Add(new TextObject("{=NVcg68Lz}You do not adhere to the {RELIGION} faith.")
                                                .SetTextVariable("RELIGION", atash.Faith.GetFaithName()));
                    }
                }

                if (BannerKingsConfig.Instance.TitleManager != null)
                {
                    var missing = new List<Settlement>(20);
                    foreach (var settlement in Settlements)
                    {
                        var title = BannerKingsConfig.Instance.TitleManager.GetTitle(settlement);
                        if (title != null && (title.deFacto == null || title.deFacto.MapFaction != referenceHero.MapFaction))
                        {
                            missing.Add(settlement);
                        }
                    }

                    failedReasons.Add(new TextObject("{=!}Your kingdom is not de facto ruler of ({SETTLEMENTS})")
                               .SetTextVariable("SETTLEMENTS", string.Join(", ", missing)));
                }
            }

            return failedReasons.IsEmpty();
        }

        public override void ShowInquiry()
        {
            var (gold, influence) = GetCosts(GetFulfiller());
            
            InformationManager.ShowInquiry
            (
                new InquiryData
                (
                    new TextObject("{=!}Establish a new Empire").ToString(),
                    new TextObject("{=qjD2WwBH}Do you want to establish the title {TITLE}?\nThis will cost you {GOLD}{GOLD_ICON} and {INFLUENCE}{INFLUENCE_ICON}.\nAs a reward your clan will earn {RENOWN} renown.")
                        .SetTextVariable("TITLE", name)
                        .SetTextVariable("GOLD", gold)
                        .SetTextVariable("INFLUENCE", influence)
                        .SetTextVariable("INFLUENCE_ICON", "<img src=\"General\\Icons\\Influence@2x\" extend=\"7\">")
                        .SetTextVariable("RENOWN", 100)
                        .ToString(),
                    true, 
                    true, 
                    GameTexts.FindText("str_accept").ToString(), 
                    GameTexts.FindText("str_cancel").ToString(), 
                    ApplyGoal, 
                    null
                ),
                true
            );
        }

        public override void ApplyGoal()
        {
            var founder = Hero.MainHero;
            var (gold, influence) = GetCosts(founder);

            var foundAction = new TitleAction(ActionType.Found, null, founder)
            {
                Gold = gold,
                Influence = influence,
                Renown = 100
            };

            var vassals = new List<FeudalTitle>();
            Kingdom darshi = Kingdom.All.ToList().FirstOrDefault(x => x.StringId == "darshi");
            if (darshi != null)
            {
                var title = BannerKingsConfig.Instance.TitleManager.GetSovereignTitle(darshi);
                if (title != null)
                {
                    vassals.Add(title);
                }
            } 
            else
            {
                var title = BannerKingsConfig.Instance.TitleManager.GetSovereignTitle(founder.Clan.Kingdom);
                if (title != null)
                {
                    vassals.Add(title);
                }
            }

            foundAction.SetVassals(vassals);
            TitleGenerator.FoundEmpire(foundAction, new TextObject("{=!}Darshianshahr"),
                TitleId);
        }

        public override void DoAiDecision()
        {
            //TODO: Implement the AI decision for this goal.
            ApplyGoal();
        }
    }
}