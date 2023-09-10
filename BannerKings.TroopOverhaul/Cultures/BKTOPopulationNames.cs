﻿using BannerKings.Managers.Cultures;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKTOPopulationNames : DefaultTypeInitializer<BKTOPopulationNames, CulturalPopulationName>
    {
        #region Empire
        public CulturalPopulationName EmpireNobles { get; set; }
        public CulturalPopulationName EmpireCraftsmen { get; set; }
        public CulturalPopulationName EmpireTenants { get; set; }
        public CulturalPopulationName EmpireSerfs { get; set; }
        public CulturalPopulationName EmpireSlaves { get; set; }
        #endregion Empire

        #region Sturgia
        public CulturalPopulationName SturgiaNobles { get; set; }
        public CulturalPopulationName SturgiaCraftsmen { get; set; }
        public CulturalPopulationName SturgiaTenants { get; set; }
        public CulturalPopulationName SturgiaSerfs { get; set; }
        public CulturalPopulationName SturgiaSlaves { get; set; }
        #endregion Sturgia

        #region Vlandia
        public CulturalPopulationName VlandiaNobles { get; set; }
        public CulturalPopulationName VlandiaCraftsmen { get; set; }
        public CulturalPopulationName VlandiaTenants { get; set; }
        public CulturalPopulationName VlandiaSerfs { get; set; }
        public CulturalPopulationName VlandiaSlaves { get; set; }
        #endregion Vlandia

        #region Battania
        public CulturalPopulationName BattaniaNobles { get; set; }
        public CulturalPopulationName BattaniaCraftsmen { get; set; }
        public CulturalPopulationName BattaniaTenants { get; set; }
        public CulturalPopulationName BattaniaSerfs { get; set; }
        public CulturalPopulationName BattaniaSlaves { get; set; }
        #endregion Battania

        #region Aserai
        public CulturalPopulationName AseraiNobles { get; set; }
        public CulturalPopulationName AseraiCraftsmen { get; set; }
        public CulturalPopulationName AseraiTenants { get; set; }
        public CulturalPopulationName AseraiSerfs { get; set; }
        public CulturalPopulationName AseraiSlaves { get; set; }
        #endregion Aserai

        #region Khuzait
        public CulturalPopulationName KhuzaitNobles { get; set; }
        public CulturalPopulationName KhuzaitCraftsmen { get; set; }
        public CulturalPopulationName KhuzaitTenants { get; set; }
        public CulturalPopulationName KhuzaitSerfs { get; set; }
        public CulturalPopulationName KhuzaitSlaves { get; set; }
        #endregion Khuzait

        #region Darshi
        public CulturalPopulationName DarshiNobles { get; set; }
        public CulturalPopulationName DarshiCraftsmen { get; set; }
        public CulturalPopulationName DarshiTenants { get; set; }
        public CulturalPopulationName DarshiSerfs { get; set; }
        public CulturalPopulationName DarshiSlaves { get; set; }
        #endregion Darshi

        public override IEnumerable<CulturalPopulationName> All
        {
            get
            {
                yield return AseraiNobles;
                yield return AseraiCraftsmen;
                yield return AseraiTenants;
                yield return AseraiSerfs;
                yield return AseraiSlaves;

                yield return EmpireNobles;
                yield return EmpireCraftsmen;
                yield return EmpireTenants;
                yield return EmpireSerfs;
                yield return EmpireSlaves;

                yield return KhuzaitNobles;
                yield return KhuzaitCraftsmen;
                yield return KhuzaitTenants;
                yield return KhuzaitSerfs;
                yield return KhuzaitSlaves;

                yield return VlandiaNobles;
                yield return VlandiaCraftsmen;
                yield return VlandiaTenants;
                yield return VlandiaSerfs;
                yield return VlandiaSlaves;

                yield return SturgiaNobles;
                yield return SturgiaCraftsmen;
                yield return SturgiaTenants;
                yield return SturgiaSerfs;
                yield return SturgiaSlaves;

                yield return BattaniaNobles;
                yield return BattaniaCraftsmen;
                yield return BattaniaTenants;
                yield return BattaniaSerfs;
                yield return BattaniaSlaves;
            }
        }

        public override void Initialize()
        {
            var cultures = Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            var empire = cultures.First(x => x.StringId == BannerKingsConfig.EmpireCulture);
            var vlandia = cultures.First(x => x.StringId == BannerKingsConfig.VlandiaCulture);
            var battania = cultures.First(x => x.StringId == BannerKingsConfig.BattaniaCulture);
            var khuzait = cultures.First(x => x.StringId == BannerKingsConfig.KhuzaitCulture);
            var aserai = cultures.First(x => x.StringId == BannerKingsConfig.AseraiCulture);
            var sturgia = cultures.First(x => x.StringId == BannerKingsConfig.SturgiaCulture);
            //var darshi = cultures.First(x => x.StringId == "darshi");
            #region Empire
            EmpireNobles = CulturalPopulationName.CreateNobles("EmpireNobles",
                empire,
                new TextObject("{=Uv29oSQT}Nobiles"));

            EmpireCraftsmen = CulturalPopulationName.CreateCraftsmen("EmpireCraftsmen",
                empire,
               new TextObject("{=6hrBerHd}Cives"));

            EmpireTenants = CulturalPopulationName.CreateTenants("EmpireTenants",
                empire,
                new TextObject("{=GThkJp2s}Coloni"));

            EmpireSerfs = CulturalPopulationName.CreateSerfs("EmpireSerfs",
                empire,
                new TextObject("{=5Ym25L00}Servi"));

            EmpireSlaves = CulturalPopulationName.CreateSlaves("EmpireSlaves",
                empire,
                new TextObject("{=B9hAxxuo}Sclavi"));
            #endregion Empire

            #region Aserai
            AseraiNobles = CulturalPopulationName.CreateNobles("AseraiNobles",
                aserai,
                new TextObject("{=!}Nubala"));

            AseraiCraftsmen = CulturalPopulationName.CreateCraftsmen("AseraiCraftsmen",
                aserai,
               new TextObject("{=!}Hirafiyyuna"));

            AseraiTenants = CulturalPopulationName.CreateTenants("AseraiTenants",
                aserai,
                new TextObject("{=!}Fallahun"));

            AseraiSerfs = CulturalPopulationName.CreateSerfs("AseraiSerfs",
                aserai,
                new TextObject("{=!}Aqnan"));

            AseraiSlaves = CulturalPopulationName.CreateSlaves("AseraiSlaves",
                aserai,
                new TextObject("{=!}Mamalik"));
            #endregion Aserai

            #region Battania
            BattaniaNobles = CulturalPopulationName.CreateNobles("BattaniaNobles",
                battania,
                new TextObject("{=!}Uchelwr"));

            BattaniaCraftsmen = CulturalPopulationName.CreateCraftsmen("BattaniaCraftsmen",
                battania,
               new TextObject("{=!}Crefftwr"));

            BattaniaTenants = CulturalPopulationName.CreateTenants("BattaniaTenants",
                battania,
                new TextObject("{=!}Gwerinwr"));

            BattaniaSerfs = CulturalPopulationName.CreateSerfs("BattaniaSerfs",
                battania,
                new TextObject("{=!}Aillt"));

            BattaniaSlaves = CulturalPopulationName.CreateSlaves("BattaniaSlaves",
                battania,
                new TextObject("{=!}Gweision"));
            #endregion Battania

            #region Vlandia
            VlandiaNobles = CulturalPopulationName.CreateNobles("VlandiaNobles",
                vlandia,
                new TextObject("{=!}Gesithas"));

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Smithas"));

            VlandiaTenants = CulturalPopulationName.CreateTenants("VlandiaTenants",
                vlandia,
                new TextObject("{=!}Ceorlas"));

            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Cottas"));

            VlandiaSlaves = CulturalPopulationName.CreateSlaves("VlandiaSlaves",
                vlandia,
                new TextObject("{=!}Theowe"));
            #endregion Vlandia

            /*
             *   #region Osrickin https://www.anglo-norman.net/entry/artificer

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Artefeceres"));


            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Villeins"));

            #endregion Osrickin
             */

            #region Khuzait
            KhuzaitNobles = CulturalPopulationName.CreateNobles("KhuzaitNobles",
                khuzait,
                new TextObject("{=!}Soyliglar"));

            KhuzaitCraftsmen = CulturalPopulationName.CreateCraftsmen("KhuzaitCraftsmen",
                khuzait,
               new TextObject("{=!}Ustalar"));

            KhuzaitTenants = CulturalPopulationName.CreateTenants("KhuzaitTenants",
                khuzait,
                new TextObject("{=!}Kiracilar"));

            KhuzaitSerfs = CulturalPopulationName.CreateSerfs("KhuzaitSerfs",
                khuzait,
                new TextObject("{=!}Kolelar"));

            KhuzaitSlaves = CulturalPopulationName.CreateSlaves("KhuzaitSlaves",
                khuzait,
                new TextObject("{=!}Kullar"));
            #endregion Khuzait

            /*#region Darshi
            DarshiNobles = CulturalPopulationName.CreateNobles("DarshiNobles",
                darshi,
                new TextObject("{=!}Soylig"));

            DarshiCraftsmen = CulturalPopulationName.CreateCraftsmen("DarshiCraftsmen",
                darshi,
               new TextObject("{=!}Senetkarlar"));

            DarshiTenants = CulturalPopulationName.CreateTenants("DarshiTenants",
                darshi,
                new TextObject("{=GThkJp2s}Coloni"));

            DarshiSerfs = CulturalPopulationName.CreateSerfs("DarshiSerfs",
                darshi,
                new TextObject("{=5Ym25L00}Esir"));

            DarshiSlaves = CulturalPopulationName.CreateSlaves("DarshiSlaves",
                darshi,
                new TextObject("{=!}Koleler"));
            #endregion Darshi*/

            #region Sturgia
            SturgiaNobles = CulturalPopulationName.CreateNobles("SturgiaNobles",
                sturgia,
                new TextObject("{=!}Dvorjáne"));

            SturgiaCraftsmen = CulturalPopulationName.CreateCraftsmen("SturgiaCraftsmen",
                sturgia,
               new TextObject("{=!}Remisnyky"));

            SturgiaTenants = CulturalPopulationName.CreateTenants("SturgiaTenants",
                sturgia,
                new TextObject("{=VviUbJTS}Smerdy"));

            SturgiaSerfs = CulturalPopulationName.CreateSerfs("SturgiaSerfs",
                sturgia,
                new TextObject("{=f9tsDXWf}Kholops"));

            SturgiaSlaves = CulturalPopulationName.CreateSlaves("SturgiaSlaves",
                sturgia,
                new TextObject("{=j6UDXO39}Thralls"));
            #endregion Sturgia

            foreach (CulturalPopulationName name in All)
            {
                DefaultPopulationNames.Instance.AddObject(name);
            }
        }
    }
}
