using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Farmer     //농부
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 10;

            switch (number)
            {
                case 0:
                    conversation[0] = "  물방울 강이 범람하여 전국에 홍수  ";
                    conversation[1] = "   피해가 생겼습니다! 교회와 군대   ";
                    conversation[2] = "     모두 구호활동을 도와주세요!    ";
                    break;
                case 1:
                    conversation[0] = "    광산에서 금이 발견되었습니다.   ";
                    conversation[1] = "         더 깊이 파볼까요?          ";
                    conversation[2] = "                                    ";
                    break;
                case 2:
                    conversation[0] = "  소들이 전염병으로 매일 죽어가고   ";
                    conversation[1] = "    있습니다. 농부들의 생계를       ";
                    conversation[2] = " 유지할 수 있도록 부디 도와주세요!  ";
                    break;
                case 3:                     //대사 특정 카드 발생
                    conversation[0] = "    물방울 강이 말라 버렸습니다.    ";
                    conversation[1] = "       댐을 건설해야 합니다.        ";
                    conversation[2] = "                                    ";
                    break;
                case 4:
                    conversation[0] = "   광산 폭발사고로 적어도 100명이   ";
                    conversation[1] = "  목숨을 잃었습니다. 그래도 채금을  ";
                    conversation[2] = "         계속하시겠습니까?          ";
                    break;
                case 5:
                    conversation[0] = "     광산 노동자들이 임금인상을     ";
                    conversation[1] = "       요구하며 파업중입니다.       ";
                    conversation[2] = "                                    ";
                    break;
                case 6:
                    conversation[0] = "   월리엄 집행관이(가) 마음에 들지  ";
                    conversation[1] = "       않습니다. 녀석은 게으른      ";
                    conversation[2] = "           사기꾼이에요.            ";
                    break;
                case 7:
                    conversation[0] = "    올해는 심한 흉년으로 백성들이   ";
                    conversation[1] = "         굶주리고 있습니다.         ";
                    conversation[2] = "         세금을 낮추십시오.         ";
                    break;
                case 8:
                    conversation[0] = "      밤의 수도는 위험합니다.       ";
                    conversation[1] = "    야간 외출을 금지해야 합니다.    ";
                    conversation[2] = "                                    ";
                    break;
                case 9:
                    conversation[0] = "       폐하께서 이를 하셨다니       ";
                    conversation[1] = "         믿을 수 없습니다.          ";
                    conversation[2] = "                                    ";
                    break;
                case 10:
                    conversation[0] = "   농민 반란이 일어났습니다! 많은   ";
                    conversation[1] = "    군중이 수도에서 약탈 행위에     ";
                    conversation[2] = " 가담하고 군인도 제어할 수 없습니다 ";
                    break;
                //case 11:                  //비축식량 : 민심0일 경우 민심 50
                //    conversation[0] = " 기근을 대비해 식량창고를 만드시는 것이";
                //    conversation[1] = " 어떻습니까?";
                //    conversation[2] = "                                    ";
                //    break;
            }
        }
    }
}
