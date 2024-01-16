using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Models.Vanilla;
using Helpers;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyWageModel : BKPartyWageModel
    {
        public override ExplainedNumber GetTotalWage(MobileParty mobileParty, bool includeDescriptions = false)
        {
            ExplainedNumber wage = base.GetTotalWage(mobileParty, includeDescriptions);

            if (mobileParty.IsLordParty)
            {
                if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
                {
                    wage.AddFactor(0.25f, new TaleWorlds.Localization.TextObject("{=!}Sailing"));
                }
            }

            if (PartyBaseHelper.HasFeat(mobileParty.Party, BKCEFeats.Instance.Kannic1))
            {
                wage.AddFactor(BKCEFeats.Instance.Kannic1.EffectBonus, GameTexts.FindText("str_culture"));
            }

            return wage;
        }

        public override int GetTroopRecruitmentCost(CharacterObject troop, Hero buyerHero, bool withoutItemCost = false)
        {
            float cost = base.GetTroopRecruitmentCost(troop, buyerHero, withoutItemCost);

            if (buyerHero.Culture.HasFeat(BKCEFeats.Instance.Siri1))
            {
                if (!troop.HasMount() && troop.Equipment.HasWeaponOfClass(WeaponClass.Bow))
                {
                    cost *= 1f + BKCEFeats.Instance.Siri1.EffectBonus;
                }
            }

            return (int)cost;
        }
    }
}
