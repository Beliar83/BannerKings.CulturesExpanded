using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace BannerKings.CulturesExpanded.Models
{
    public class BKCEEquipmentModel : DefaultEquipmentSelectionModel
    {
        public override MBList<MBEquipmentRoster> GetEquipmentRostersForHeroComeOfAge(Hero hero, bool isCivilian)
        {
            MBList<MBEquipmentRoster> result = base.GetEquipmentRostersForHeroComeOfAge(hero, isCivilian);
            if (result.IsEmpty())
            {
                foreach (MBEquipmentRoster mbequipmentRoster in MBEquipmentRosterExtensions.All)
                {
                    if (mbequipmentRoster.EquipmentCulture == hero.Culture)
                    {
                        if (!isCivilian && mbequipmentRoster.HasEquipmentFlags(EquipmentFlags.IsCombatantTemplate))
                            result.Add(mbequipmentRoster);
                        else if (isCivilian && mbequipmentRoster.HasEquipmentFlags(EquipmentFlags.IsCivilianTemplate))
                            result.Add(mbequipmentRoster);
                    }
                }
            }

            return result;
        }
    }
}
