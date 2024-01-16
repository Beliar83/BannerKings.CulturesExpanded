using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartyFoodModel : DefaultMobilePartyFoodConsumptionModel
    {
        public override ExplainedNumber CalculateDailyFoodConsumptionf(MobileParty party, ExplainedNumber baseConsumption)
        {
            ExplainedNumber result = base.CalculateDailyFoodConsumptionf(party, baseConsumption);
            if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(party.CurrentNavigationFace) == TerrainType.Swamp)
            {
                float mounts = party.ItemRoster.NumberOfMounts + party.ItemRoster.NumberOfLivestockAnimals +
                    party.ItemRoster.NumberOfPackAnimals;
                foreach (var troop in party.MemberRoster.GetTroopRoster())
                {
                    if (troop.Character.IsMounted) mounts++;
                }

                foreach (var troop in party.PrisonRoster.GetTroopRoster())
                {
                    if (troop.Character.IsMounted) mounts++;
                }

                result.Add(mounts / 2f, new TaleWorlds.Localization.TextObject("{=!}Carrying {COUNT} animals while sailing (inventory, party and prisoners)")
                    .SetTextVariable("COUNT", mounts.ToString("0")));
            }
            
            return result;
        }
    }
}
