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
    public class VlandiaEmpireGoal : EmpireGoal
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

        public override string TitleId => "goal_vlandia_empire";

        public override (float Gold, float Influence) GetCosts(Hero hero)
        {
            return
            (
                500000 + BannerKingsConfig.Instance.ClanFinanceModel.CalculateClanIncome(hero.Clan).ResultNumber * CampaignTime.DaysInYear,
                1000 + BannerKingsConfig.Instance.InfluenceModel.CalculateInfluenceChange(hero.Clan).ResultNumber * CampaignTime.DaysInYear * 0.1f
            );
        }

        public VlandiaEmpireGoal() : base("goal_vlandia_empire", GoalCategory.Unique, GoalUpdateType.Settlement)
        {
            var name = new TextObject("{=!}Form Bretwalda Wilundinga");
            var description = new TextObject("{=!}Consolidate the Wilunding claim in the Calradian continent by forming the first Wilunding Bretwalda, the old Wilunding term for a great kingdom. The Bretwalda shall contain all of the land originally conceded to the Wilunding, as well as their own colonies and recent conquests within the western hemisphere.{newline}{newline}");

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
            var cultures = new List<CultureObject>() 
            {
                Utils.Helpers.GetCulture("vlandia"),
                Utils.Helpers.GetCulture("balion"),
                Utils.Helpers.GetCulture("massa")
            };

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

                if (!cultures.Any(x => x.StringId == referenceHero.Culture.StringId))
                {
                    failedReasons.Add(new TextObject("{=!}You are not part of any of the ({CULTURES}) cultures.")
                        .SetTextVariable("CULTURES", string.Join(", ", cultures)));
                }

                if (referenceHero.Clan.Kingdom != null)
                {
                    if (!cultures.Any(x => x.StringId == referenceHero.Clan.Kingdom.Culture.StringId))
                    {
                        failedReasons.Add(new TextObject("{=!}Your kingdom is not part of any of the ({CULTURES}) cultures.")
                            .SetTextVariable("CULTURES", string.Join(", ", cultures)));
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
                if (religion == null || religion.Faith.GetId() != "osfeyd")
                {
                    var osfeyd = BannerKingsConfig.Instance.ReligionsManager.GetReligionById("osfeyd");
                    if (osfeyd != null)
                    {
                        failedReasons.Add(new TextObject("{=NVcg68Lz}You do not adhere to the {RELIGION} faith.")
                                                .SetTextVariable("RELIGION", osfeyd.Faith.GetFaithName()));
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
            Kingdom vlandia = Kingdom.All.ToList().FirstOrDefault(x => x.StringId == "vlandia");

            if (vlandia != null)
            {
                var title = BannerKingsConfig.Instance.TitleManager.GetSovereignTitle(vlandia);
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

            TitleGenerator.FoundEmpire(foundAction, new TextObject("{=!}Bretwalda Wilundinga"),
                TitleId);
        }

        public override void DoAiDecision()
        {
            //TODO: Implement the AI decision for this goal.
            ApplyGoal();
        }
    }
}