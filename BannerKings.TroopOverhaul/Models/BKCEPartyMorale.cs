﻿using BannerKings.CulturesExpanded.Cultures;
using BannerKings.CulturesExpanded.Religions;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyMorale : BKPartyMoraleModel
    {
        public override ExplainedNumber GetEffectivePartyMorale(MobileParty mobileParty, bool includeDescription = false)
        {
            ExplainedNumber result = base.GetEffectivePartyMorale(mobileParty, includeDescription);

            if (mobileParty.LeaderHero != null)
            {
                Hero leader = mobileParty.LeaderHero;
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.Ireos))
                {
                    float proportion = 0f;
                    foreach (var element in mobileParty.MemberRoster.GetTroopRoster())
                    {
                        if (element.Character.Culture.StringId == BannerKingsConfig.EmpireCulture)
                        {
                            proportion += element.Number;
                        }
                    }

                    proportion = proportion / (float)mobileParty.MemberRoster.TotalManCount;
                    result.Add(15f * proportion, BKCEDivinities.Instance.Ireos.Name);
                }

                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, BKCEDivinities.Instance.VineGoddess))
                {
                    result.Add(8f, BKCEDivinities.Instance.VineGoddess.Name);
                }
            }

            if (mobileParty.IsLordParty)
            {
                if (mobileParty.ActualClan.Culture.HasFeat(BKCEFeats.Instance.SailingSpeed) &&
                    TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
                {
                    result.Add(-12f, new TaleWorlds.Localization.TextObject("{=!}Sailing"));
                }
            }

            return result;
        }
    }
}
