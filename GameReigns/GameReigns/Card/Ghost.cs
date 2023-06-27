using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Ghost      //망자
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = random.Next(0,9);

            switch (number)
            {
                case 0:
                    conversation[0] = "                                    ";
                    conversation[1] = "        그대가 젊은 왕인가?         ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "  내 왕위를 찬탈하고 이 지하감옥에  ";
                    conversation[1] = "    가두어 영원히 나오지 못하게     ";
                    conversation[2] = "            한 게 너구나?           ";
                    break;
                case 2:
                    conversation[0] = "   어쨌든 그 난리통을 물려받은게    ";
                    conversation[1] = "  너로구만 열심히 힘 내봐. 이놈도   ";
                    conversation[2] = "   저놈도 제정신인 놈이 없으니깐    ";
                    break;
                case 3:
                    conversation[0] = " 그저 4가지 세력의 균형을 맞추려고  ";
                    conversation[1] = "     노력해봐. 그러면 어깨에서      ";
                    conversation[2] = "     목이 날아가지는 않을 거야.     ";
                    break;
                case 4:
                    conversation[0] = "                                    ";
                    conversation[1] = "        그대가 젊은 왕인가?         ";
                    conversation[2] = "                                    ";
                    break;
                case 5:
                    conversation[0] = "   하하하... 농담이야. 알고 있어.   ";
                    conversation[1] = "      전에도 이런 대화를 했지.      ";
                    conversation[2] = "    그게 우리에게 걸린 저주일세.    ";
                    break;
                case 6:
                    conversation[0] = " 우리는 이 왕조의 모든 왕의 기억을  ";
                    conversation[1] = "           계속 지니게 돼.          ";
                    conversation[2] = "                                    ";
                    break;
                case 7:
                    conversation[0] = "    들리는 소문에 의하면 왕들의     ";
                    conversation[1] = "  기억에서 해방되려면 악마의 힘을   ";
                    conversation[2] = "        빌려야 한다던데...          ";
                    break;
                case 8:
                    conversation[0] = "        과연... 나는 언젠가         ";
                    conversation[1] = "      자유의 몸이 되고 싶다네       ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
