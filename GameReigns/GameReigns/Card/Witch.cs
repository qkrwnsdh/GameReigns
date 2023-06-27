using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Witch      //마녀
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = random.Next(0,6);

            switch (number)
            {
                case 0:
                    conversation[0] = "    폐하 가게를 열어도 좋을까요?    ";
                    conversation[1] = "   제가 만든 부적을 팔고 싶습니다.  ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "  자연의 법칙과 인간의 한계에 대해  ";
                    conversation[1] = "         흥미가 있으시다면          ";
                    conversation[2] = "           알려드리지요.            ";
                    break;
                case 2:
                    conversation[0] = " 서쪽 마을의 백성이 고블린의 습격을 ";
                    conversation[1] = "       두려워하고 있습니다.         ";
                    conversation[2] = "    이건 누가 처리해야 하지요?      ";
                    break;
                case 3:
                    conversation[0] = "       수도에 콜레라가 맹위를       ";
                    conversation[1] = "          떨치고 있습니다.          ";
                    conversation[2] = "                                    ";
                    break;
                case 4:
                    conversation[0] = "   공작이 신혼을 맞이하는 여성의    ";
                    conversation[1] = "  잠자리에 함께하는 봉건적 제도를   ";
                    conversation[2] = "   다시 시행하려 하고 있습니다.     ";
                    break;
                case 5:
                    conversation[0] = "     저는 진료소를 지어 역병이      ";
                    conversation[1] = "  유행하는 것을 막을 수 있습니다.   ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
