using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class General    //장군
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 10;

            switch (number)
            {
                case 0:
                    conversation[0] = "   병사들의 인금이 너무 낮습니다.   ";
                    conversation[1] = "       적절한 금액으로 인상을       ";
                    conversation[2] = "           부탁드립니다.            ";
                    break;
                case 1:
                    conversation[0] = "     동쪽의 야만인들이 국경으로     ";
                    conversation[1] = "         다가오고 있습니다.         ";
                    conversation[2] = "        방어를 강화하십시오!        ";
                    break;
                case 2:
                    conversation[0] = "     무기를 제작하려면 광산에서     ";
                    conversation[1] = "      채광되는 철광석만으로는       ";
                    conversation[2] = "  역부족입니다. 수입해야만 합니다.  ";
                    break;
                case 3:
                    conversation[0] = "  폐하 예상치 못한 사태에 대비하여  ";
                    conversation[1] = "    추가 징병을 실시해야 합니다.    ";
                    conversation[2] = "                                    ";
                    break;
                case 4:
                    conversation[0] = "      침략군을 괴멸시켰습니다!      ";
                    conversation[1] = "  적군의 자원을 약탈할 기회입니다.  ";
                    conversation[2] = "                                    ";
                    break;
                case 5:                                                 // 결투
                    conversation[0] = "    폐하 펜싱이라도 같이 즐길까요   ";
                    conversation[1] = "   제가 지도해 드릴 테니 어느 쪽이  ";
                    conversation[2] = "       이길지 내기하도록 하죠       ";
                    break;
                case 6:                                                 // 결투 승
                    conversation[0] = "    폐하의 승리입니다. 이게 바로    ";
                    conversation[1] = " '초보자의 행운'이라는 것이로군요! ";
                    conversation[2] = "                                    ";
                    break;
                case 7:                                                 // 결투 패
                    conversation[0] = "    폐하의 패배입니다. 이게 바로    ";
                    conversation[1] = " '초보자의 행운'이라는 것이로군요! ";
                    conversation[2] = "                                    ";
                    break;
                case 8:
                    conversation[0] = " 남쪽 나라에서 서쪽 나라와의 전쟁에 ";
                    conversation[1] = "         도움을 청했습니다.         ";
                    conversation[2] = "      군대를 파견하시겠습니까?      ";
                    break;
                case 9:
                    conversation[0] = "     올해는 아무 일이 일어나지      ";
                    conversation[1] = "     않았습니다. 군대는 따분해      ";
                    conversation[2] = "         죽을 지경입니다.           ";
                    break;
                case 10:
                    conversation[0] = "  북쪽에서 바이킹이 공격해 옵니다!  ";
                    conversation[1] = "      수비를 강화해야 합니다!       ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
