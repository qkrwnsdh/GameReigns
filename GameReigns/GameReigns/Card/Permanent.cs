using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Permanent  //제후
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 9;

            switch (number)
            {
                case 0:
                    conversation[0] = "      강도가 들었습니다! 대담한     ";
                    conversation[1] = "     갱단이 보물을 훔쳐갔습니다.    ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "    국가는 30년만의 한파를 겪고     ";
                    conversation[1] = "   있습니다. 흉작에 대비한 비축도   ";
                    conversation[2] = "  없어 백성들이 굶주리고 있습니다.  ";
                    break;
                case 2:                         //제후 파트 +                     
                    conversation[0] = "                                    ";
                    conversation[1] = "  멧돼지 사냥이라도 가시겠습니까?   ";
                    conversation[2] = "                                    ";
                    break;
                case 3:
                    conversation[0] = "  멋지게 사냥감을 잡으셨군요! 오늘  ";
                    conversation[1] = "   성대하게 잔치를 열어 봅시다!     ";
                    conversation[2] = "                                    ";
                    break;
                case 4:                                       
                    conversation[0] = "                                    ";
                    conversation[1] = "  화마가 성에도 다가오고 있습니다!  ";
                    conversation[2] = "                                    ";
                    break;
                case 5:
                    conversation[0] = "  봄부터 여름에 걸쳐 수도의 악취가  ";
                    conversation[1] = "  심해집니다. 하수도를 정비합시다.  ";
                    conversation[2] = "                                    ";
                    break;
                case 6:
                    conversation[0] = " 폐하! 가난한 사람들이 폭도가 되어  ";
                    conversation[1] = "     도시를 습격하고 있습니다!      ";
                    conversation[2] = "                                    ";
                    break;
                case 7:
                    conversation[0] = "  상인들이 새로운 길드를 결성하여   ";
                    conversation[1] = "       대표를 성에 파견하고         ";
                    conversation[2] = "          싶다고 합니다.            ";
                    break;
                case 8:                                        // 노예 이벤트 시작
                    conversation[0] = " 폐하...저희끼리 하는 이야기인데... ";
                    conversation[1] = "     '사업'에 투자하시겠습니까?     ";
                    conversation[2] = "         잘 되면 대박입니다.        ";
                    break;
                case 9:
                    conversation[0] = " 다른나라상인이 처음 보는 농기구를  ";
                    conversation[1] = " 팔고 있습니다. 똑같이 따라 만들어  ";
                    conversation[2] = "      보는 것은 어떻습니까?         ";
                    break;
            }
        }
    }
}
