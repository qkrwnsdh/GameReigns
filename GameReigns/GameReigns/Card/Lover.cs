using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Lover      //애첩
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 5;

            switch (number)
            {
                case 0:
                    conversation[0] = " 오늘은 폐하의 스무 살 생신입니다!  ";
                    conversation[1] = "        저와 함께 축하해요!         ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "  올해 봄 축제는 저와 함께 가시죠   ";
                    conversation[1] = "     제 예쁜 친구들을 불러다가      ";
                    conversation[2] = "    외국 영빈들을 접대시켜 보죠     ";
                    break;
                case 2:                                         //마녀 덱 추가
                    conversation[0] = "  얼마 전 이상한 여자를 만났습니다  ";
                    conversation[1] = " 고대의 식물과 꿈에관한 지식을 가진 ";
                    conversation[2] = "  여자입니다. 만나 보시겠습니까?    ";
                    break;
                case 3:
                    conversation[0] = "      수녀들이 고양이처럼 울기      ";
                    conversation[1] = "     시작했습니다. 이상한 행동이    ";
                    conversation[2] = "     마을까지 전염된 모양입니다.    ";
                    break;
                case 4:                                         //노예 이벤트 종료
                    conversation[0] = "    노예선을 시찰하고 왔습니다...   ";
                    conversation[1] = "        그렇게 잔인한 사업은        ";
                    conversation[2] = "          할 수 없어요...           ";
                    break;
                case 5:
                    conversation[0] = "      이 케이크를 먹으면 천국에     ";
                    conversation[1] = "     있는 듯한 기분이 들 겁니다.    ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
