using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns
{
    public class Influence
    {
        public void Religion(ref int religion, ref int plusPoint, ref int MinusPoint)
        {           // { 종교
            religion += plusPoint;
            religion -= MinusPoint;

            if (religion <= 0)
            {
                religion = 0;
            }
            else if (religion >= 100)
            {
                religion = 100;
            }
        }           // } 종교

        public void Sentiment(ref int sentiment, ref int plusPoint, ref int MinusPoint)
        {           // { 민심
            sentiment += plusPoint;
            sentiment -= MinusPoint;

            if (sentiment <= 0)
            {
                sentiment = 0;
            }
            else if (sentiment >= 100)
            {
                sentiment = 100;
            }
        }           // } 민심

        public void Military(ref int military, ref int plusPoint, ref int MinusPoint)
        {           // { 군사
            military += plusPoint;
            military -= MinusPoint;

            if (military <= 0)
            {
                military = 0;
            }
            else if (military >= 100)
            {
                military = 100;
            }
        }           // } 군사

        public void Money(ref int money, ref int plusPoint, ref int MinusPoint)
        {           // { 국고
            money += plusPoint;
            money -= MinusPoint;

            if (money <= 0)
            {
                money = 0;
            }
            else if (money >= 100)
            {
                money = 100;
            }
        }           // } 국고
    }
}
