using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Ambassador //대사
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 8;

            switch (number)
            {
                case 0:
                    conversation[0] = "      물방울 강 하구 부근에서       ";
                    conversation[1] = "   위험한 습지가 펼쳐져 있습니다.   ";
                    conversation[2] = "       그 일대를 소독합시다.        ";
                    break;
                case 1:
                    conversation[0] = "   서쪽 나라의 왕이 아군의 현황을   ";
                    conversation[1] = "    파악한 모양입니다 금방이라도    ";
                    conversation[2] = "          쳐들어 올 겁니다!         ";
                    break;
                case 2:                 //농부 특정 파트 이후 발생
                    conversation[0] = "   댐을 건설하면 바이킹들이 강을    ";
                    conversation[1] = "       이용할 수 없게 됩니다.       ";
                    conversation[2] = "         계속 하시겠습니까?         ";
                    break;
                case 3:
                    conversation[0] = "  남쪽 왕국에는 젊은 공주가 있는데  ";
                    conversation[1] = "   폐하와 공주의 약혼을 원합니다.   ";
                    conversation[2] = " 거부하면 전쟁이 일어날수 있습니다. ";
                    break;
                case 4:
                    conversation[0] = "        적국에서 평화협정을         ";
                    conversation[1] = "          제의해 왔습니다.          ";
                    conversation[2] = "   전쟁을 끝낼 절호의 기회입니다.   ";
                    break;
                case 5:
                    conversation[0] = "   폐하 잠시 귀를 빌려 주시지요...  ";
                    conversation[1] = "  젊은 여자가 자신의 아들이 폐하의  ";
                    conversation[2] = "  사생아라 주장하는데 처리 할까요?  ";
                    break;
                case 6:
                    conversation[0] = "    이웃나라에 대사관을 설치하는    ";
                    conversation[1] = "   건 어떻습니까? 전쟁을 막을 수    ";
                    conversation[2] = "        있을 거라 생각합니다.       ";
                    break;
                case 7:
                    conversation[0] = "      서쪽 나라 왕이 우리나라       ";
                    conversation[1] = "   영토의 일부를 구입하고 싶다는    ";
                    conversation[2] = "       전갈을 보내왔습니다.         ";
                    break;
                case 8:
                    conversation[0] = "   남쪽 나라 여왕님께서 책을 40권   ";
                    conversation[1] = "         헌상해 주셨습니다.         ";
                    conversation[2] = "        도서관을 건립합시다!        ";
                    break;
            }
        }
    }
}
