using BannerKings.CulturesExpanded.Cultures;
using BannerKings.Managers.Populations;
using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEFoodModel : BKFoodModel
    {
        public override ExplainedNumber GetPopulationFoodConsumption(PopulationData data)
        {
            ExplainedNumber result = base.GetPopulationFoodConsumption(data);
            if (data.Settlement.Culture.HasFeat(BKCEFeats.Instance.FoodConsumption))
            {
                result.AddFactor(BKCEFeats.Instance.FoodConsumption.EffectBonus, GameTexts.FindText("str_culture"));
            }

            return result;
        }
    }
}
