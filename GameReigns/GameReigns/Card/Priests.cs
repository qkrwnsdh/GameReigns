using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Priests    //사제
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 9;

            switch (number)
            {
                case 0:
                    conversation[0] = "        만수무강하소서, 폐하!       ";
                    conversation[1] = "  폐하의 만수무강을 기도하겠습니다  ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "     타계하신 상왕폐하를 기리는     ";
                    conversation[1] = "         미사를 거행합시다.         ";
                    conversation[2] = "                                    ";
                    break;
                case 2:                                            
                    conversation[0] = "   우리나라는 교회의 권위가 너무    ";
                    conversation[1] = "   약합니다. 백성들이 신을 소홀히   ";
                    conversation[2] = "          여기고 있습니다.          ";
                    break;
                case 3:
                    conversation[0] = "   교회가 백성들에게 신의 심판을    ";
                    conversation[1] = "    내릴 권한을 주십시오. 교황은    ";
                    conversation[2] = " 합당한 대가를 지급하겠다고 합니다. ";
                    break;
                case 4:
                    conversation[0] = "    군사들이 사제들과 신도들에게    ";
                    conversation[1] = "   보호비라는 핑계로 돈을 갈취해    ";
                    conversation[2] = "   괴롭힙니다. 그들을 막아주세요.   ";
                    break;
                case 5:
                    conversation[0] = "         폐하 새로운 교회를         ";
                    conversation[1] = "          설립해야 합니다.          ";
                    conversation[2] = "                                    ";
                    break;
                case 6:
                    conversation[0] = "    성당의 탑이 무너지기 시작하고   ";
                    conversation[1] = "    있습니다. 수리를 도와주십시오   ";
                    conversation[2] = "                                    ";
                    break;
                case 7:
                    conversation[0] = " 무...문제가 있습니다.어떤 수도사가 ";
                    conversation[1] = "    다른 수도사를 물어뜯고...그는   ";
                    conversation[2] = " 또 다른 수도사를 물어뜯고있습니다. ";
                    break;
                case 8:                                        // 노예 이벤트 시작
                    conversation[0] = " 남쪽 나라에서 기적이 일어났습니다. ";
                    conversation[1] = "    동상이 피를 흘렸다고 합니다.    ";
                    conversation[2] = "    사실인지 확인해봐야 합니다.     ";
                    break;
                case 9:
                    conversation[0] = "   백성에게 교회세를 새로 부과하고  ";
                    conversation[1] = "  싶습니다. 물론 세수 일부는 왕실과 ";
                    conversation[2] = "              나누지요              ";
                    break;
            }
        }
    }
}
