using BannerKings.Behaviours;
using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Extensions;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Behaviors
{
    public class FeatBehavior : BannerKingsBehavior
    {
        public override void RegisterEvents()
        {
            CampaignEvents.OnSiegeAftermathAppliedEvent.AddNonSerializedListener(this, OnSiegeAftermath);
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnSiegeAftermath(MobileParty attackerParty, Settlement settlement,
          SiegeAftermathAction.SiegeAftermath aftermathType,
          Clan previousSettlementOwner,
          Dictionary<MobileParty, float> partyContributions)
        {
            if (aftermathType == SiegeAftermathAction.SiegeAftermath.ShowMercy) return;

            if (attackerParty.LeaderHero != null && attackerParty.LeaderHero.Culture.HasFeat(BKCEFeats.Instance.Massa1))
            {
                var data = settlement.PopulationData();
                if (data != null)
                {
                    float gold = data.TotalPop;
                    foreach (var pair in partyContributions)
                    {
                        Hero leader = pair.Key.LeaderHero;
                        if (leader != null)
                        {
                            int bonus = (int)(gold * pair.Value);
                            leader.ChangeHeroGold(bonus);

                            if (leader == Hero.MainHero)
                            {
                                InformationManager.DisplayMessage(new InformationMessage(
                                    new TextObject("{=!}{GOLD}{GOLD_ICON} extra from the pillaging of {TOWN} due to the culture of {LEADER}.")
                                    .SetTextVariable("LEADER", attackerParty.LeaderHero.Name)
                                    .SetTextVariable("TOWN", settlement.Name)
                                    .SetTextVariable("GOLD", bonus)
                                    .ToString()));
                            }
                        }
                    }
                }
            }
        }
    }
}
