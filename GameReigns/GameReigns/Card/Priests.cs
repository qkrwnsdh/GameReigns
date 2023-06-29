using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Priests    //사제
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0, 10);

            switch (number)
            {
                case 0:
                    conversation[0] = "        만수무강하소서, 폐하!       ";
                    conversation[1] = "  폐하의 만수무강을 기도하겠습니다  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 10; pattern[3] = " ○ ";

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 1:
                    conversation[0] = "     타계하신 상왕폐하를 기리는     ";
                    conversation[1] = "         미사를 거행합시다.         ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 2:
                    conversation[0] = "   우리나라는 교회의 권위가 너무    ";
                    conversation[1] = "   약합니다. 백성들이 신을 소홀히   ";
                    conversation[2] = "          여기고 있습니다.          ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:
                    conversation[0] = "   교회가 백성들에게 신의 심판을    ";
                    conversation[1] = "    내릴 권한을 주십시오. 교황은    ";
                    conversation[2] = " 합당한 대가를 지급하겠다고 합니다. ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
                case 4:
                    conversation[0] = "    군사들이 사제들과 신도들에게    ";
                    conversation[1] = "   보호비라는 핑계로 돈을 갈취해    ";
                    conversation[2] = "   괴롭힙니다. 그들을 막아주세요.   ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = "         폐하 새로운 교회를         ";
                    conversation[1] = "          설립해야 합니다.          ";
                    conversation[2] = "                                    ";
                    conversation[3] = "이미 충분하지 않나";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 6:
                    conversation[0] = "    성당의 탑이 무너지기 시작하고   ";
                    conversation[1] = "    있습니다. 수리를 도와주십시오   ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 7:
                    conversation[0] = " 무...문제가 있습니다.어떤 수도사가 ";
                    conversation[1] = "    다른 수도사를 물어뜯고...그는   ";
                    conversation[2] = " 또 다른 수도사를 물어뜯고있습니다. ";
                    conversation[3] = "늑대인간?";
                    conversation[4] = "장군!";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 8:                                        // 노예 이벤트 시작
                    conversation[0] = " 남쪽 나라에서 기적이 일어났습니다. ";
                    conversation[1] = "    동상이 피를 흘렸다고 합니다.    ";
                    conversation[2] = "    사실인지 확인해봐야 합니다.     ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 9:
                    conversation[0] = "   백성에게 교회세를 새로 부과하고  ";
                    conversation[1] = "  싶습니다. 물론 세수 일부는 왕실과 ";
                    conversation[2] = "              나누지요              ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 20; pattern[4] = " ○ ";
                    point[5] = -20; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
            }
        }

        public void PriestsLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌───────────┬────────┬───────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│          ┌┘        └┐          │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│         ┌┘          └┐         │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│        ┌┘            └┐        │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│        └┐    ┌──┐    ┌┘        │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│         └┐┌──┘  └──┐┌┘         │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│          ├┘        └┤          │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│          │  ┌┐  ┌┐  │          │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│     ┌┘   └┐        ┌┘   └┐     │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    ┌┘     └┐      ┌┘     └┐    │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│    │       └┐    ┌┘       │    │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│    │        └────┘        │    │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└────┴──────────────────────┴────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("         릭스부르크 대사제          ");
        }

        public void PriestsLogoLeft(ref int movePos)
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
                Console.Write("┌───────────┬────────┬───────────┐");
                Console.SetCursorPosition(movePos - 1, 11);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│        └┐    ┌──┐    ┌┘        │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│         └┐┌──┘  └──┐┌┘         │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│          ├┘        └┤          │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│     ┌┘   └┐        ┌┘   └┐     │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    ┌┘     └┐      ┌┘     └┐    │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│    │       └┐    ┌┘       │    │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│    │        └────┘        │    │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└────┴──────────────────────┴────┘");

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

        public void PriestsLogoRight(ref int movePos)
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
                Console.Write("┌───────────┬────────┬───────────┐");
                Console.SetCursorPosition(movePos + 1, 11);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│        └┐    ┌──┐    ┌┘        │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│         └┐┌──┘  └──┐┌┘         │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│          ├┘        └┤          │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│     ┌┘   └┐        ┌┘   └┐     │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    ┌┘     └┐      ┌┘     └┐    │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│    │       └┐    ┌┘       │    │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│    │        └────┘        │    │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└────┴──────────────────────┴────┘");

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
