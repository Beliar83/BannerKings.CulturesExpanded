﻿using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.CulturesExpanded.Religions
{
    public class ImmortalFlame : MonotheisticFaith
    {
        public override Settlement FaithSeat => Settlement.All.First(x => x.StringId == "");
        public override Banner GetBanner() => new Banner("11.149.40.1836.1836.768.774.1.0.0.321.128.149.184.186.764.884.1.1.0.218.85.149.270.250.804.664.1.1.338.218.85.149.270.250.724.664.1.1.22.218.71.149.280.282.764.664.1.1.0");

        public override TextObject GetBlessingAction()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingActionName()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingQuestion()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetBlessingQuickInformation()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyInduction(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetCultsDescription()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetDescriptionHint()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetFaithDescription()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetFaithName() => new TextObject("{=!}Atash Amesha");

        public override string GetId() => "immortalFlame";

        public override int GetIdealRank(Settlement settlement)
        {
            throw new NotImplementedException();
        }

        public override (bool, TextObject) GetInductionAllowed(Hero hero, int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetInductionExplanationText()
        {
            throw new NotImplementedException();
        }

        public override int GetMaxClergyRank()
        {
            throw new NotImplementedException();
        }

        public override TextObject GetRankTitle(int rank)
        {
            throw new NotImplementedException();
        }

        public override TextObject GetZealotsGroupName()
        {
            throw new NotImplementedException();
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            throw new NotImplementedException();
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
