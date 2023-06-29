using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Lover      //애첩
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0,6);

            switch (number)
            {
                case 0:
                    conversation[0] = " 오늘은 폐하의 스무 살 생신입니다!  ";
                    conversation[1] = "        저와 함께 축하해요!         ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 1:
                    conversation[0] = "  올해 봄 축제는 저와 함께 가시죠   ";
                    conversation[1] = "     제 예쁜 친구들을 불러다가      ";
                    conversation[2] = "    외국 영빈들을 접대시켜 보죠     ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 2:                                         //마녀 덱 추가
                    conversation[0] = "  얼마 전 이상한 여자를 만났습니다  ";
                    conversation[1] = " 고대의 식물과 꿈에관한 지식을 가진 ";
                    conversation[2] = "  여자입니다. 만나 보시겠습니까?    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 20; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:
                    conversation[0] = "      수녀들이 고양이처럼 울기      ";
                    conversation[1] = "     시작했습니다. 이상한 행동이    ";
                    conversation[2] = "     마을까지 전염된 모양입니다.    ";
                    conversation[3] = "내버려 두게...";
                    conversation[4] = "장군!";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 20; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 4:                                         //노예 이벤트 종료
                    conversation[0] = "    노예선을 시찰하고 왔습니다...   ";
                    conversation[1] = "        그렇게 잔인한 사업은        ";
                    conversation[2] = "          할 수 없어요...           ";
                    conversation[3] = "돈벌이니깐 어쩔 수 없지";
                    conversation[4] = "노예무역에서 손을 떼지";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = "      이 케이크를 먹으면 천국에     ";
                    conversation[1] = "     있는 듯한 기분이 들 겁니다.    ";
                    conversation[2] = "                                    ";
                    conversation[3] = "위장에도 부담이 간다";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
            }
        }

        public void LoverLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│        ┌────────────┐          │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│      ┌─┘            └┐         │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│      │               └┐        │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│      │    ┌────────┐  └┐       │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│     ┌┘   ┌┘        └┐  │       │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│     │    │   ┌┐  ┌┐ │  │       │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│    ┌┘    │   ││  ││ │ ┌┘       │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│    │     │   └┘  └┘ │ │        │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    └┐    └┐        ┌┘ └┐       │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│     │     └┬──────┬┘   │       │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    ┌┤      │      ├─┐  │       │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│    ││      └┐    ┌┘ └──┤       │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│   ┌┴┘       └┐  ┌┘     └─┐     │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└───┴──────────┴──┴────────┴─────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("            레이디 샬롯             ");
        }

        public void LoverLogoLeft(ref int movePos)
        {
            int value = movePos - 10;

            for (; movePos > value; movePos--)
            {
                for (int j = 10; j < 25; j++)
                {
                    Console.SetCursorPosition(movePos + 1, j);
                    Console.Write("                                  ");
                }

                Console.SetCursorPosition(movePos - 1, 10);
                Console.Write("┌────────────────────────────────┐");
                Console.SetCursorPosition(movePos - 1, 11);
                Console.Write("│        ┌────────────┐          │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│      ┌─┘            └┐         │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│      │               └┐        │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│      │    ┌────────┐  └┐       │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│     ┌┘   ┌┘        └┐  │       │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│     │    │   ┌┐  ┌┐ │  │       │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│    ┌┘    │   ││  ││ │ ┌┘       │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│    │     │   └┘  └┘ │ │        │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    └┐    └┐        ┌┘ └┐       │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│     │     └┬──────┬┘   │       │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    ┌┤      │      ├─┐  │       │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│    ││      └┐    ┌┘ └──┤       │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│   ┌┴┘       └┐  ┌┘     └─┐     │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└───┴──────────┴──┴────────┴─────┘");

                Thread.Sleep(10);

                if (movePos == 41)
                {
                    Console.SetCursorPosition(75, 14);
                    Console.Write("┐");
                    Console.SetCursorPosition(75, 15);
                    Console.Write("│");
                    Console.SetCursorPosition(75, 16);
                    Console.Write("│");
                    Console.SetCursorPosition(75, 17);
                    Console.Write("│");
                    Console.SetCursorPosition(75, 18);
                    Console.Write("│");
                    Console.SetCursorPosition(75, 19);
                    Console.Write("└");
                }
                else if (movePos == 40)
                {
                    Console.SetCursorPosition(74, 9);
                    Console.Write("┐");
                    Console.SetCursorPosition(74, 10);
                    Console.Write("│");
                    Console.SetCursorPosition(74, 11);
                    Console.Write("│");
                    Console.SetCursorPosition(74, 12);
                    Console.Write("│");
                    Console.SetCursorPosition(74, 13);
                    Console.Write("│");
                    Console.SetCursorPosition(74, 14);
                    Console.Write("└");
                }
                else if (movePos == 32)
                {
                    Console.SetCursorPosition(66, 10);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 11);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 12);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 13);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 14);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 15);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 16);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 17);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 18);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 19);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 20);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 22);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 23);
                    Console.Write("│");
                    Console.SetCursorPosition(66, 24);
                    Console.Write("│");
                }
            }
        }

        public void LoverLogoRight(ref int movePos)
        {
            int value = movePos + 10;

            for (; movePos < value; movePos++)
            {
                for (int j = 10; j < 25; j++)
                {
                    Console.SetCursorPosition(movePos - 1, j);
                    Console.Write("                                   ");
                }

                Console.SetCursorPosition(movePos + 1, 10);
                Console.Write("┌────────────────────────────────┐");
                Console.SetCursorPosition(movePos + 1, 11);
                Console.Write("│        ┌────────────┐          │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│      ┌─┘            └┐         │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│      │               └┐        │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│      │    ┌────────┐  └┐       │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│     ┌┘   ┌┘        └┐  │       │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│     │    │   ┌┐  ┌┐ │  │       │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│    ┌┘    │   ││  ││ │ ┌┘       │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│    │     │   └┘  └┘ │ │        │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    └┐    └┐        ┌┘ └┐       │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│     │     └┬──────┬┘   │       │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    ┌┤      │      ├─┐  │       │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│    ││      └┐    ┌┘ └──┤       │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│   ┌┴┘       └┐  ┌┘     └─┐     │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└───┴──────────┴──┴────────┴─────┘");

                Thread.Sleep(10);

                if (movePos == 21)
                {
                    Console.SetCursorPosition(20, 16);
                    Console.Write("─");
                }
                else if (movePos == 22)
                {
                    Console.SetCursorPosition(21, 14);
                    Console.Write("┌");
                    Console.SetCursorPosition(21, 15);
                    Console.Write("│");
                    Console.SetCursorPosition(21, 16);
                    Console.Write("┴");
                }
                else if (movePos == 23)
                {
                    Console.SetCursorPosition(22, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(22, 16);
                    Console.Write("─");
                }
                else if (movePos == 24)
                {
                    Console.SetCursorPosition(23, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("┐");
                    Console.SetCursorPosition(23, 17);
                    Console.Write("│");
                    Console.SetCursorPosition(23, 18);
                    Console.Write("└");
                }
                else if (movePos == 25)
                {
                    Console.SetCursorPosition(24, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(24, 18);
                    Console.Write("┐");
                    Console.SetCursorPosition(24, 19);
                    Console.Write("└");
                }
                else if (movePos == 26)
                {
                    Console.SetCursorPosition(25, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(25, 19);
                    Console.Write("┐");
                    Console.SetCursorPosition(25, 20);
                    Console.Write("└");
                }
                else if (movePos == 27)
                {
                    Console.SetCursorPosition(26, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(26, 20);
                    Console.Write("─");
                }
                else if (movePos == 28)
                {
                    Console.SetCursorPosition(27, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(27, 20);
                    Console.Write("─");
                }
                else if (movePos == 29)
                {
                    Console.SetCursorPosition(28, 14);
                    Console.Write("─");
                    Console.SetCursorPosition(28, 20);
                    Console.Write("─");
                }
                else if (movePos == 30)
                {
                    Console.SetCursorPosition(29, 10);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 11);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 12);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 13);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 14);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 15);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 16);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 17);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 18);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 19);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 20);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 22);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 23);
                    Console.Write("│");
                    Console.SetCursorPosition(29, 24);
                    Console.Write("│");
                }
            }
        }
    }
}
