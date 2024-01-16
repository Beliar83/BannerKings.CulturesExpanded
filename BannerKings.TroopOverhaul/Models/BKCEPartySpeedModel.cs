using BannerKings.Models.Vanilla;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using BannerKings.Settings;
using BannerKings.CulturesExpanded.Cultures;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using Helpers;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEPartySpeedModel : BKPartySpeedModel
    {
        public override ExplainedNumber CalculateFinalSpeed(MobileParty mobileParty, ExplainedNumber finalSpeed)
        {
            if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
            {
                bool description = mobileParty.ActualClan == Clan.PlayerClan;
                ExplainedNumber speed = new ExplainedNumber(2f, description);

                if (mobileParty.Army != null) speed.AddFactor(-0.2f, new TextObject("{=!}Sailing army"));
                else if (mobileParty.IsCaravan) speed.AddFactor(0.12f, new TextObject("{=!}Sailing caravan"));

                string culture = mobileParty.ActualClan != null ? mobileParty.ActualClan.Culture.StringId :
                    mobileParty.Owner.Culture.StringId;
                
                Utils.Helpers.ApplyFeat(BKCEFeats.Instance.SailingSpeed, mobileParty.Party, ref speed);

                if (BannerKingsSettings.Instance.SlowerParties > 0f)
                {
                    speed.AddFactor(-BannerKingsSettings.Instance.SlowerParties, new TextObject("{=OohdenyR}Slower Parties setting"));
                }

                return speed;
            }

            ExplainedNumber newFinalSpeed = base.CalculateFinalSpeed(mobileParty, finalSpeed);

            if (PartyBaseHelper.HasFeat(mobileParty.Party, BKCEFeats.Instance.Vakken2))
            {
                MapWeatherModel.WeatherEvent weatherEventInPosition = TaleWorlds.CampaignSystem.Campaign.Current.Models.MapWeatherModel
                               .GetWeatherEventInPosition(mobileParty.Position2D);
                if (weatherEventInPosition == MapWeatherModel.WeatherEvent.Snowy || weatherEventInPosition == MapWeatherModel.WeatherEvent.Blizzard)
                {
                    finalSpeed.AddFactor(0.1f, GameTexts.FindText("str_culture"));
                }
            }

            return newFinalSpeed;
        }
    }
}
