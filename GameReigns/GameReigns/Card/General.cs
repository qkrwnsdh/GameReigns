using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class General    //장군
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0, 8);

            switch (number)
            {
                case 0:
                    conversation[0] = "   병사들의 인금이 너무 낮습니다.   ";
                    conversation[1] = "       적절한 금액으로 인상을       ";
                    conversation[2] = "           부탁드립니다.            ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 0; pattern[5] = default;
                    point[6] = 20; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 1:
                    conversation[0] = "     동쪽의 야만인들이 국경으로     ";
                    conversation[1] = "         다가오고 있습니다.         ";
                    conversation[2] = "        방어를 강화하십시오!        ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 0; pattern[5] = default;
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 2:
                    conversation[0] = "     무기를 제작하려면 광산에서     ";
                    conversation[1] = "      채광되는 철광석만으로는       ";
                    conversation[2] = "  역부족입니다. 수입해야만 합니다.  ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -20; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 0; pattern[5] = default;
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 3:
                    conversation[0] = "  폐하 예상치 못한 사태에 대비하여  ";
                    conversation[1] = "    추가 징병을 실시해야 합니다.    ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -20; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 20; pattern[6] = " ○ ";
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 4:
                    conversation[0] = "      침략군을 괴멸시켰습니다!      ";
                    conversation[1] = "  적군의 자원을 약탈할 기회입니다.  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "약탈은 불허하네";
                    conversation[4] = "브라보!";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 20; pattern[6] = " ○ ";
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = " 남쪽 나라에서 서쪽 나라와의 전쟁에 ";
                    conversation[1] = "         도움을 청했습니다.         ";
                    conversation[2] = "      군대를 파견하시겠습니까?      ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 0; pattern[4] = default;
                    point[5] = 0; pattern[5] = default;
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
                case 6:
                    conversation[0] = "     올해는 아무 일이 일어나지      ";
                    conversation[1] = "     않았습니다. 군대는 따분해      ";
                    conversation[2] = "         죽을 지경입니다.           ";
                    conversation[3] = "훈련이나 하도록";
                    conversation[4] = "와인을 주도록";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 20; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 7:
                    conversation[0] = "  북쪽에서 바이킹이 공격해 옵니다!  ";
                    conversation[1] = "      수비를 강화해야 합니다!       ";
                    conversation[2] = "                                    ";
                    conversation[3] = "방어를 강화하라!";
                    conversation[4] = "공격을 진행하라!";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
            }
        }

        public void GeneralLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────┬──────┬────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│           ┌┘      └┐           │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│          ┌┘        └┐          │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│         ┌┘          └┐         │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│        ┌┘    ┌┐┌┐    └┐        │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│       ┌┘   ┌┐││││┌┐   └┐       │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│       │    ││││││││    │       │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│       │    └┘└┘└┘└┘    │       │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│      ┌┤   ┌─┐    ┌─┐   ├┐      │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    ┌─┘│   │ └────┘ │   │└─┐    │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│   ┌┘  │   └┐      ┌┘   │  └┐   │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│   │   │    └──────┘    │   │   │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│   │   │                │   │   │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│   │   │                │   │   │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└───┴───┴────────────────┴───┴───┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("           블루밍튼 장군            ");
        }

        public void GeneralLogoLeft(ref int movePos)
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
                Console.Write("┌────────────┬──────┬────────────┐");
                Console.SetCursorPosition(movePos - 1, 11);
                Console.Write("│           ┌┘      └┐           │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│        ┌┘    ┌┐┌┐    └┐        │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│       ┌┘   ┌┐││││┌┐   └┐       │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│       │    ││││││││    │       │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│       │    └┘└┘└┘└┘    │       │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│      ┌┤   ┌─┐    ┌─┐   ├┐      │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    ┌─┘│   │ └────┘ │   │└─┐    │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│   ┌┘  │   └┐      ┌┘   │  └┐   │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│   │   │    └──────┘    │   │   │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│   │   │                │   │   │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│   │   │                │   │   │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└───┴───┴────────────────┴───┴───┘");

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

        public void GeneralLogoRight(ref int movePos)
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
                Console.Write("┌────────────┬──────┬────────────┐");
                Console.SetCursorPosition(movePos + 1, 11);
                Console.Write("│           ┌┘      └┐           │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│        ┌┘    ┌┐┌┐    └┐        │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│       ┌┘   ┌┐││││┌┐   └┐       │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│       │    ││││││││    │       │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│       │    └┘└┘└┘└┘    │       │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│      ┌┤   ┌─┐    ┌─┐   ├┐      │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    ┌─┘│   │ └────┘ │   │└─┐    │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│   ┌┘  │   └┐      ┌┘   │  └┐   │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│   │   │    └──────┘    │   │   │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│   │   │                │   │   │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│   │   │                │   │   │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└───┴───┴────────────────┴───┴───┘");

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
