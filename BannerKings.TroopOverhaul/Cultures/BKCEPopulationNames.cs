﻿using BannerKings.Managers.Cultures;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCEPopulationNames : DefaultTypeInitializer<BKCEPopulationNames, CulturalPopulationName>
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

        #region Rhodok
        public CulturalPopulationName RhodokNobles { get; set; }
        public CulturalPopulationName RhodokCraftsmen { get; set; }
        public CulturalPopulationName RhodokTenants { get; set; }
        public CulturalPopulationName RhodokSerfs { get; set; }
        public CulturalPopulationName RhodokSlaves { get; set; }
        #endregion Rhodok

        #region Swadia
        public CulturalPopulationName SwadiaNobles { get; set; }
        public CulturalPopulationName SwadiaCraftsmen { get; set; }
        public CulturalPopulationName SwadiaTenants { get; set; }
        public CulturalPopulationName SwadiaSerfs { get; set; }
        public CulturalPopulationName SwadiaSlaves { get; set; }
        #endregion Swadia

        #region Kannic
        public CulturalPopulationName KannicNobles { get; set; }
        public CulturalPopulationName KannicCraftsmen { get; set; }
        public CulturalPopulationName KannicTenants { get; set; }
        public CulturalPopulationName KannicSerfs { get; set; }
        public CulturalPopulationName KannicSlaves { get; set; }
        #endregion Kannic

        #region Vakken
        public CulturalPopulationName VakkenNobles { get; set; }
        public CulturalPopulationName VakkenCraftsmen { get; set; }
        public CulturalPopulationName VakkenTenants { get; set; }
        public CulturalPopulationName VakkenSerfs { get; set; }
        public CulturalPopulationName VakkenSlaves { get; set; }
        #endregion Vakken

        #region Jumne
        public CulturalPopulationName JumneNobles { get; set; }
        public CulturalPopulationName JumneCraftsmen { get; set; }
        public CulturalPopulationName JumneTenants { get; set; }
        public CulturalPopulationName JumneSerfs { get; set; }
        public CulturalPopulationName JumneSlaves { get; set; }
        #endregion Jumne

        #region Massa
        public CulturalPopulationName MassaNobles { get; set; }
        public CulturalPopulationName MassaCraftsmen { get; set; }
        public CulturalPopulationName MassaTenants { get; set; }
        public CulturalPopulationName MassaSerfs { get; set; }
        public CulturalPopulationName MassaSlaves { get; set; }
        #endregion Massa

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

        #region Bragantia
        public CulturalPopulationName BragantiaNobles { get; set; }
        public CulturalPopulationName BragantiaCraftsmen { get; set; }
        public CulturalPopulationName BragantiaTenants { get; set; }
        public CulturalPopulationName BragantiaSerfs { get; set; }
        public CulturalPopulationName BragantiaSlaves { get; set; }
        #endregion Bragantia

        #region Balion
        public CulturalPopulationName BalionNobles { get; set; }
        public CulturalPopulationName BalionCraftsmen { get; set; }
        public CulturalPopulationName BalionTenants { get; set; }
        public CulturalPopulationName BalionSerfs { get; set; }
        public CulturalPopulationName BalionSlaves { get; set; }
        #endregion Balion

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

                yield return RhodokNobles;
                yield return RhodokCraftsmen;
                yield return RhodokTenants;
                yield return RhodokSerfs;
                yield return RhodokSlaves;

                yield return SwadiaNobles;
                yield return SwadiaCraftsmen;
                yield return SwadiaTenants;
                yield return SwadiaSerfs;
                yield return SwadiaSlaves;

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

                yield return DarshiNobles;
                yield return DarshiCraftsmen;
                yield return DarshiTenants;
                yield return DarshiSerfs;
                yield return DarshiSlaves;

                yield return BragantiaNobles;
                yield return BragantiaCraftsmen;
                yield return BragantiaTenants;
                yield return BragantiaSerfs;
                yield return BragantiaSlaves;

                yield return MassaNobles;
                yield return MassaCraftsmen;
                yield return MassaTenants;
                yield return MassaSerfs;
                yield return MassaSlaves;

                yield return JumneNobles;
                yield return JumneCraftsmen;
                yield return JumneTenants;
                yield return JumneSerfs;
                yield return JumneSlaves;

                yield return BalionNobles;
                yield return BalionCraftsmen;
                yield return BalionTenants;
                yield return BalionSerfs;
                yield return BalionSlaves;
            }
        }

        public override void Initialize()
        {
            var cultures = TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            var empire = cultures.First(x => x.StringId == BannerKingsConfig.EmpireCulture);
            var vlandia = cultures.First(x => x.StringId == BannerKingsConfig.VlandiaCulture);
            var battania = cultures.First(x => x.StringId == BannerKingsConfig.BattaniaCulture);
            var khuzait = cultures.First(x => x.StringId == BannerKingsConfig.KhuzaitCulture);
            var aserai = cultures.First(x => x.StringId == BannerKingsConfig.AseraiCulture);
            var sturgia = cultures.First(x => x.StringId == BannerKingsConfig.SturgiaCulture);
            var darshi = cultures.First(x => x.StringId == "darshi");
            var massa = cultures.First(x => x.StringId == "massa");
            var nord = cultures.First(x => x.StringId == "nord");
            var vakken = cultures.First(x => x.StringId == "vakken");
            var bragantia = cultures.First(x => x.StringId == "bragantia");
            var balion = cultures.First(x => x.StringId == "balion");
            var swadia = cultures.First(x => x.StringId == "swadia");
            var rhodok = cultures.First(x => x.StringId == "rhodok");

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
                new TextObject("{=!}Gentilez"));

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Artefeceres"));

            VlandiaTenants = CulturalPopulationName.CreateTenants("VlandiaTenants",
                vlandia,
                new TextObject("{=!}Husbondmen"));

            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Villeins"));

            VlandiaSlaves = CulturalPopulationName.CreateSlaves("VlandiaSlaves",
                vlandia,
                new TextObject("{=!}Esclaves"));
            #endregion Vlandia

            #region Rhodok
            RhodokNobles = CulturalPopulationName.CreateNobles("RhodokNobles",
                rhodok,
                new TextObject("{=prince_rhodok}Edelincen"));

            RhodokCraftsmen = CulturalPopulationName.CreateCraftsmen("RhodokCraftsmen",
                rhodok,
               new TextObject("{=!}Smitten"));

            RhodokTenants = CulturalPopulationName.CreateTenants("RhodokTenants",
                rhodok,
                new TextObject("{=!}Kerlen"));

            RhodokSerfs = CulturalPopulationName.CreateSerfs("RhodokSerfs",
                rhodok,
                new TextObject("{=!}Bantmànnen")); 

            RhodokSlaves = CulturalPopulationName.CreateSlaves("RhodokSlaves",
                rhodok,
                new TextObject("{=!}Diolinken"));
            #endregion Rhodok

            #region Swadia
            SwadiaNobles = CulturalPopulationName.CreateNobles("SwadiaNobles",
                swadia,
                new TextObject("{=prince_swadia}Edelincen"));

            SwadiaCraftsmen = CulturalPopulationName.CreateCraftsmen("SwadiaCraftsmen",
                swadia,
               new TextObject("{=!}Schmiden"));

            SwadiaTenants = CulturalPopulationName.CreateTenants("SwadiaTenants",
                swadia,
                new TextObject("{=!}Kerlen"));

            SwadiaSerfs = CulturalPopulationName.CreateSerfs("SwadiaSerfs",
                swadia,
                new TextObject("{=!}Bantmaen"));

            SwadiaSlaves = CulturalPopulationName.CreateSlaves("SwadiaSlaves",
                swadia,
                new TextObject("{=!}Diolinken")); //https://www.koeblergerhard.de/ahd/5A/ahd_d.html
            #endregion Swadia

            #region Jumne
            JumneNobles = CulturalPopulationName.CreateNobles("JumneNobles",
                nord,
                new TextObject("{=!}Athalborin"));

            JumneCraftsmen = CulturalPopulationName.CreateCraftsmen("JumneCraftsmen",
                nord,
               new TextObject("{=!}Smithar"));

            JumneTenants = CulturalPopulationName.CreateTenants("JumneTenants",
                nord,
                new TextObject("{=!}Karlar"));

            JumneSerfs = CulturalPopulationName.CreateSerfs("JumneSerfs",
                nord,
                new TextObject("{=!}Leysingjar"));

            JumneSlaves = CulturalPopulationName.CreateSlaves("JumneSlaves",
                nord,
                new TextObject("{=!}Thraelar"));
            #endregion Jumne

            #region Balion
            BalionNobles = CulturalPopulationName.CreateNobles("BalionNobles",
                balion,
                new TextObject("{=!}Aethele"));

            BalionCraftsmen = CulturalPopulationName.CreateCraftsmen("BalionCraftsmen",
                balion,
               new TextObject("{=!}Smithas"));

            BalionTenants = CulturalPopulationName.CreateTenants("BalionTenants",
                balion,
                new TextObject("{=!}Ceorlas"));

            BalionSerfs = CulturalPopulationName.CreateSerfs("BalionSerfs",
                balion,
                new TextObject("{=!}Cottas"));

            BalionSlaves = CulturalPopulationName.CreateSlaves("BalionSlaves",
                balion,
                new TextObject("{=!}Theowe"));
            #endregion Balion

            #region Massa
            MassaNobles = CulturalPopulationName.CreateNobles("MassaNobles",
                massa,
                new TextObject("{=!}Gasinthjans"));

            MassaCraftsmen = CulturalPopulationName.CreateCraftsmen("MassaCraftsmen",
                massa,
               new TextObject("{=!}Smithans"));

            MassaTenants = CulturalPopulationName.CreateTenants("MassaTenants",
                massa,
                new TextObject("{=!}Wairos"));

            MassaSerfs = CulturalPopulationName.CreateSerfs("MassaSerfs",
                massa,
                new TextObject("{=!}Thios"));

            MassaSlaves = CulturalPopulationName.CreateSlaves("MassaSlaves",
                massa,
                new TextObject("{=!}Skalkans"));
            #endregion Massa

            #region Vakken
            VakkenNobles = CulturalPopulationName.CreateNobles("VakkenNobles",
                massa,
                new TextObject("{=!}Aatelicet"));

            VakkenCraftsmen = CulturalPopulationName.CreateCraftsmen("VakkenCraftsmen",
                massa,
               new TextObject("{=!}Kacitoolaicet"));

            VakkenTenants = CulturalPopulationName.CreateTenants("VakkenTenants",
                massa,
                new TextObject("{=!}Vookratlaicet"));

            VakkenSerfs = CulturalPopulationName.CreateSerfs("VakkenSerfs",
                massa,
                new TextObject("{=!}Viljelijat"));

            VakkenSlaves = CulturalPopulationName.CreateSlaves("VakkenSlaves",
                massa,
                new TextObject("{=!}Orjat"));
            #endregion Vakken

            /*
             *   #region Osrickin https://www.anglo-norman.net/entry/artificer

            VlandiaCraftsmen = CulturalPopulationName.CreateCraftsmen("VlandiaCraftsmen",
                vlandia,
               new TextObject("{=!}Artefeceres"));


            VlandiaSerfs = CulturalPopulationName.CreateSerfs("VlandiaSerfs",
                vlandia,
                new TextObject("{=!}Villeins"));

            Kannic
            Craftsmen - baalit
            Tenants - mish

            #endregion Osrickin


            Siri slave: medjun
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

            #region Darshi
            DarshiNobles = CulturalPopulationName.CreateNobles("DarshiNobles",
                darshi,
                new TextObject("{=!}Azadan"));

            DarshiCraftsmen = CulturalPopulationName.CreateCraftsmen("DarshiCraftsmen",
                darshi,
               new TextObject("{=!}Senetkarlar"));

            DarshiTenants = CulturalPopulationName.CreateTenants("DarshiTenants",
                darshi,
                new TextObject("{=!}Dahigan"));

            DarshiSerfs = CulturalPopulationName.CreateSerfs("DarshiSerfs",
                darshi,
                new TextObject("{=!}Badakan"));

            DarshiSlaves = CulturalPopulationName.CreateSlaves("DarshiSlaves",
                darshi,
                new TextObject("{=!}Parastaran"));
            #endregion Darshi

            #region Bragantia
            BragantiaNobles = CulturalPopulationName.CreateNobles("BragantiaNobles",
                bragantia,
                new TextObject("{=!}Nobres"));

            BragantiaCraftsmen = CulturalPopulationName.CreateCraftsmen("BragantiaCraftsmen",
                bragantia,
               new TextObject("{=!}Artesãos"));

            BragantiaTenants = CulturalPopulationName.CreateTenants("BragantiaTenants",
                bragantia,
                new TextObject("{=!}Colonos"));

            BragantiaSerfs = CulturalPopulationName.CreateSerfs("BragantiaSerfs",
                bragantia,
                new TextObject("{=!}Servos"));

            BragantiaSlaves = CulturalPopulationName.CreateSlaves("BragantiaSlaves",
                bragantia,
                new TextObject("{=!}Escravos"));
            #endregion Bragantia

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
