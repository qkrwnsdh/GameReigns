using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Executor   //사형집행인
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 5;

            switch (number)
            {
                case 0:
                    conversation[0] = "  '분'이(가) 마음에 들지 않습니다.  ";
                    conversation[1] = " 녀석은 이간질하는 거짓말쟁이에요.  ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = " 감옥에서 죄수가 많이 탈출했습니다. ";
                    conversation[1] = "     수색대를 보내야만 합니다.      ";
                    conversation[2] = "                                    ";
                    break;
                case 2:
                    conversation[0] = " 대규모의 폭도들이 도시의 매음굴을  ";
                    conversation[1] = " 습격하고 있습니다. 창녀들이 악마에 ";
                    conversation[2] = "  빙의되었다고 주장하고 있습니다.   ";
                    break;
                case 3:                     //의사 카드 발생
                    conversation[0] = " 폐하 솜씨좋은 의사가 조카의 목숨을 ";
                    conversation[1] = "  구해주었습니다. 마술도 좀 아는것  ";
                    conversation[2] = "    같습니다. 만나 보시겠습니까?    ";
                    break;
                case 4:
                    conversation[0] = "   과학 박물관을 설립하여 세상에    ";
                    conversation[1] = "   존재하는 모든 생물을 모읍시다.   ";
                    conversation[2] = "      저도 도움을 드리겠습니다.     ";
                    break;
                case 5:
                    conversation[0] = "  사형수가 너무 많습니다! 병사들도  ";
                    conversation[1] = "      처형을 돕게 해주십시오.       ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
