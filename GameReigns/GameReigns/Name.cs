using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns
{
    public class Name
    {
        Random random = new Random();

        public void PlayerName(ref string name)
        {
            int nameNumber = random.Next(0, 20);

            switch (nameNumber)
            {
                case 0:
                    name = "왈라키아 블라드 왕";
                    break;
                case 1:
                    name = "스벤 왕";
                    break;
                case 2:
                    name = "필리프 왕";
                    break;
                case 3:
                    name = "조지아 다비트 왕";
                    break;
                case 4:
                    name = "루도비코스 왕";
                    break;
                case 5:
                    name = "에드워드 왕";
                    break;
                case 6:
                    name = "로베르 왕";
                    break;
                case 7:
                    name = "카를로스 왕";
                    break;
                case 8:
                    name = "샤를 왕";
                    break;
                case 9:
                    name = "셀림 왕";
                    break;
                case 10:
                    name = "피피누스 왕";
                    break;
                case 11:
                    name = "셀레우코스 왕";
                    break;
                case 12:
                    name = "데메트리오스 왕";
                    break;
                case 13:
                    name = "다리우스 왕";
                    break;
                case 14:
                    name = "크세르크세스 왕";
                    break;
                case 15:
                    name = "알렉산드로스 왕";
                    break;
                case 16:
                    name = "유스티니아누스 왕";
                    break;
                case 17:
                    name = "클로타르 왕";
                    break;
                case 18:
                    name = "프리드리히 왕";
                    break;
                case 19:
                    name = "발데마르 왕";
                    break;
            }
        }
    }
}
