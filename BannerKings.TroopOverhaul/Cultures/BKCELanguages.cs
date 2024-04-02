using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Cultures
{
    public class BKCELanguages : DefaultTypeInitializer<BKCELanguages, Language>
    {
        public Language Darshi { get; } = new Language("language_darshi");
        public Language Jumne { get; } = new Language("language_nord");
        public Language Kannic { get; } = new Language("language_kannic");
        public Language Geroia { get; } = new Language("language_geroian");
        public Language Bragantian { get; } = new Language("language_bragantian");
        public Language Massa { get; } = new Language("language_massa");
        public Language Siri { get; } = new Language("language_siri");
        public Language Lokti { get; } = new Language("language_lokti");
        public Language Rhodok { get; } = new Language("language_rhodok");
        public Language Swadian { get; } = new Language("language_swadian");
        public Language Balion { get; } = new Language("language_balion");
        public Language Iltanlar { get; } = new Language("language_iltanlar");

        public override IEnumerable<Language> All { 
            get 
            {
                yield return Darshi;
                yield return Jumne;
                yield return Kannic;
                yield return Geroia;
                yield return Siri;
                yield return Massa;
                yield return Bragantian;
                yield return Lokti;
            }
        }

        public override void Initialize()
        {
            var cultures = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();

            DefaultLanguages.Instance.Vlandic.Initialize(new TextObject("{=!}Osrickin Wilunding"),
                new TextObject("{=!}"),
                new List<CultureObject>(1)
                {
                    cultures.First(x => x.StringId == "vlandia")
                },
                new Dictionary<Language, float> 
                { 
                    { DefaultLanguages.Instance.Calradian, 0.3f },
                    { Massa, 0.1f },
                    { Balion, 0.3f },
                    { Swadian, 0.2f },
                    { Rhodok, 0.2f }
                });

            Balion.Initialize(new TextObject("{=!}Balionian"),
              new TextObject("{=!}"),
              new List<CultureObject>(1)
              {
                    cultures.First(x => x.StringId == "balion")
              },
              new Dictionary<Language, float>()
              {
                   { Jumne, 0.2f },
                   { DefaultLanguages.Instance.Vlandic, 0.3f },
                   { Swadian, 0.6f },
                   { Rhodok, 0.6f },
                   { Massa, 0.6f }
              });

            Rhodok.Initialize(new TextObject("{=!}Rhodok Wilunding"),
              new TextObject("{=!}The language of the Rhodok tribe, one of the most conservative variants of the Wilunding languages, when compared to its source, Balionian. Above all Rhodok  is similar to Swadisch, their closest kin."),
              new List<CultureObject>(1)
              {
                    cultures.First(x => x.StringId == "rhodok")
              },
              new Dictionary<Language, float>()
              {
                   { DefaultLanguages.Instance.Vlandic, 0.2f },
                   { Swadian, 0.8f },
                   { Massa, 0.4f }
              });

            Swadian.Initialize(new TextObject("{=!}Swadisch Wilunding"),
              new TextObject("{=!}The language of the Swadisch tribe, one of the most conservative variants of the Wilunding languages, when compared to its source, Balionian. Above all Swadisch is similar to Rhodok, their closest kin."),
              new List<CultureObject>(1)
              {
                    cultures.First(x => x.StringId == "swadia")
              },
              new Dictionary<Language, float>()
              {
                   { DefaultLanguages.Instance.Vlandic, 0.2f },
                   { Rhodok, 0.8f },
                   { Massa, 0.4f }
              });

            Massa.Initialize(new TextObject("{=!}Massa Wilunding"),
               new TextObject("{=!}Spoken by the Massa tribe, their language is much similar to Vlandic. Most of their vocabulary still revolves around agricultural and warfare themes, lacking in deep philosophical concepts."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "massa")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Vlandic, 0.2f },
                   { Swadian, 0.4f },
                   { Rhodok, 0.4f },
                   { Balion, 0.6f }
               });

            DefaultLanguages.Instance.Calradian.Initialize(new TextObject("{=NWqkTdMt}Calradian"),
                new TextObject("{=GmqBFSgN}The Imperial language of the Calradian empire. Though scholars have made efforts into keeping the language pure, centuries of contact with local cultures have made Calradian adopt small quantities of local vocabularies. Being a language of prestige, Calradian vocabulary are also often adopted by foreign languages, due to it's usefulness in the continent as a Lingua Franca, often used by traders, nobles during their education or peasants looking for a better life within the Empire."),
                new List<CultureObject>(1)
                {
                    cultures.First(x => x.StringId == "empire"),
                    cultures.First(x => x.StringId == "zendar")
                },
                new Dictionary<Language, float> { { DefaultLanguages.Instance.Vlandic, 0.1f }, { DefaultLanguages.Instance.Battanian, 0.1f } });

            DefaultLanguages.Instance.Khuzait.Initialize(new TextObject("{=!}Devseg"),
                new TextObject("{=rYVgj513}The langauge of the steppe is often described by foreigners as curt, but effective. Due to the near absence of scholarly research in the Khuzait culture, it often lacks terms for technical, or more abstract concepts, and as such it is certain those will be adopted from the Imperial language."),
                new List<CultureObject>(1)
                {
                    cultures.First(x => x.StringId == "khuzait"),
                    cultures.First(x => x.StringId == "iltanlar")
                },
                new Dictionary<Language, float>());

            Lokti.Initialize(new TextObject("{=!}Lokti"),
               new TextObject("{=!}Spoken in the Biscan Isles, Biscanjan is the amalgamation of the existing Calradoi dialect, itslef already diverging from the main imperial language, with the Massa settlers of the isles."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "lokti")
               },
               new Dictionary<Language, float>()
               {
                   {  DefaultLanguages.Instance.Vakken, 0.2f }
               });

            Bragantian.Initialize(new TextObject("{=!}Biscanjan"),
               new TextObject("{=!}Spoken in the Biscan Isles, Biscanjan is the amalgamation of the existing Calradoi dialect, itslef already diverging from the main imperial language, with the Massa settlers of the isles."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "bragantia")
               },
               new Dictionary<Language, float>()
               {
                   {  Massa, 0.2f },
                   {  DefaultLanguages.Instance.Calradian, 0.4f }
               });

            Siri.Initialize(new TextObject("{=!}Siri"),
               new TextObject("{=!}The ancient language of the Siri people."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "siri")
               },
               new Dictionary<Language, float>());

            Darshi.Initialize(new TextObject("{=IHhWB1aa}Darshi"),
               new TextObject("{=!}A very ancient language, with echoes from a civilized past before the existance of the Calradoi. The Darshi language is natural to the southeast of Calradia, and previously the east, before the Khuzaits conquered their kingdom, mostly composed of cities founded by the Darshi. The language is elaborate, poetic and for the ears of a foreigner, complex. Yet, it has nevertheless gained space in the courts of the Aserai, who have long took aspects of Darshi culture to their own uses."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "darshi")
               },
               new Dictionary<Language, float>());

            Jumne.Initialize(new TextObject("{=!}Jumne"),
               new TextObject("{=!}Spoken by the northern sailors, raiders and traders alike, Jumne is also the namesake of their distant land. The language of Jumne is foreign to all of those in Calradia, except to the Wilunding. Both share still echoes of a distant kinship."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "nord")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Vlandic, 0.4f },
                   { Massa, 0.2f }
               });

            Kannic.Initialize(new TextObject("{=!}Kannic"),
               new TextObject("{=!}Although now mostly faded away, the Kannic language remains strong in the remaining Kannic strongholds. The language is notoriously curt, favoring small words and little vowels. Nevertheless, it shares vocabulary with the Nahawasi language, and serves the Kannic well on their maritime trades."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "kannic")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Aseran, 0.15f }
               });

            Geroia.Initialize(new TextObject("{=!}Geroiako"),
               new TextObject("{=!}Originally a variation of the Calradian language, Geroiako has become its own language over the centuries. Isolated from the mainland, the islanders have developed linguistical shifts that make mutual understanding difficult with their distant Calradian kin. The Geroians however, take pride in their language and culture, which they spread through their slave-oared ships."),
               new List<CultureObject>(1)
               {
                    cultures.First(x => x.StringId == "geroia")
               },
               new Dictionary<Language, float>()
               {
                   { DefaultLanguages.Instance.Calradian, 0.3f }
               });

            foreach (var language in All)
            {
                DefaultLanguages.Instance.AddObject(language);
            }
        }
    }
}
