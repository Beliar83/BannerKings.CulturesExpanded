using TaleWorlds.Localization;
using MCM.Abstractions.Attributes.v1;
using MCM.Abstractions.Base.Global;

namespace BannerKings.Settings
{
    public class BKCESettings : AttributeGlobalSettings<BKCESettings>
    {
        public override string Id => "BannerKings.CulturesExpanded";
        public override string DisplayName => new TextObject("{=!}Banner Kings: Cultures Expanded").ToString();
        public override string FolderName => "BannerKings.CulturesExpanded"; 
        public override string FormatType => "json2";

        [SettingProperty("{=!}Imperial Latin Titles", RequireRestart = true, HintText = "{=!}For Empire titles, switch the use of Hellenic titles to Latin titles. Default: False.")]
        public bool LatinTitles { get; set; } = false;

        [SettingProperty("{=!}Battanian Goidelic Titles", RequireRestart = true, HintText = "{=!}For Battanian titles, switch the use of Brythonic titles to Goedelic titles. Default: False.")]
        public bool GoidelicTitles { get; set; } = false;
    }
}
