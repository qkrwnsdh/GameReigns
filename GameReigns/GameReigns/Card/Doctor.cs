using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Doctor     //의사
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0, 10);

            switch (number)
            {
                case 0:
                    conversation[0] = "    저는 의술에 능통하며 연금술과   ";
                    conversation[1] = "       독약 지식도 있습니다.        ";
                    conversation[2] = "                                    ";
                    conversation[3] = "생병을 구하는 쪽에 전념하게";
                    conversation[4] = "환영하지";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 1:
                    conversation[0] = "  무기와 전술에 대한 새로운 실험에  ";
                    conversation[1] = "         착수하고자 합니다.         ";
                    conversation[2] = "        지원해 주시겠습니까?        ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = -20; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 20; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 2:
                    conversation[0] = "    폐하는 통풍을 앓고 계십니다.    ";
                    conversation[1] = "   앞으로는 고기를 줄이고 야채를    ";
                    conversation[2] = " 많이 드시고 난봉질은 그만두십시오. ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:         //예 누를시 50%죽음
                    conversation[0] = " 처녀의 피를빤 거머리로 만든 비장의 ";
                    conversation[1] = "      약입니다. 드시면 단번에       ";
                    conversation[2] = "         통풍이 낫습니다.           ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 20; pattern[0] = " ○ ";
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = 10; pattern[3] = " ○ ";

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 4:
                    conversation[0] = " 설탕을 너무 많이 드셨습니다. 폐하! ";
                    conversation[1] = "       섭취량을 줄이지 않으면       ";
                    conversation[2] = "       생명에 지장이 있습니다.      ";
                    conversation[3] = "그렇게 죽을 수 있다면 좋지";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 0; pattern[4] = default;
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 10; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = "    납을 황금으로 바꾸는 실험에     ";
                    conversation[1] = "        착수하고자 합니다.          ";
                    conversation[2] = "       지원해 주시겠습니까?         ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 6:
                    conversation[0] = "    실험 중 알코올을 효율적으로     ";
                    conversation[1] = "   증류하는 방법을 발견했습니다.    ";
                    conversation[2] = "  수익의 일부는 폐하에게도 드리지요 ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
                case 7:
                    conversation[0] = "     비축해둔 호밀에 식중독균을     ";
                    conversation[1] = "    발견했습니다. 비축해둔 식량을   ";
                    conversation[2] = "         소각하시겠습니까?          ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 8:
                    conversation[0] = " 경하드립니다! 오늘은 폐하의 50번째 ";
                    conversation[1] = "           생신이십니다.            ";
                    conversation[2] = "                                    ";
                    conversation[3] = "별로 안 기쁘네만...";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 10; pattern[7] = " ○ ";
                    break;
                case 9:
                    conversation[0] = "   이 성에서 서쪽의 과학자 동료를   ";
                    conversation[1] = "    모아 교류회를 열고 싶습니다.    ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 20; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
            }
        }

        public void DoctorLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌──────────┬──────────┬──────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│         ┌┘          └┐         │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│        ┌┘            └┐        │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│        │   ┌──┐┌──┐   │        │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│        │   │  └┘  │   │        │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│        └┐ ┌┘      └┐ ┌┘        │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│         └┬┘ ┌┐  ┌┐ └┬┘         │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│       ┌──┤  └┘  └┘  ├──┐       │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│     ┌─┘  ├┐        ┌┤  └─┐     │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    ┌┘   ┌┤└┐ ┌──┐ ┌┘├┐   └┐    │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│    │    │└┐└┬┘  └┬┘┌┘│    │    │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    │    │ └┐└────┘┌┘ │    │    │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│    │    └┐ └┐    ┌┘ ┌┘    │    │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│    │     │  └────┘  │     │    │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└────┴─────┴──────────┴─────┴────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("     요하네스 악트리아우스 의사     ");
        }

        public void DoctorLogoLeft(ref int movePos)
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
                Console.Write("┌──────────┬──────────┬──────────┐");
                Console.SetCursorPosition(movePos - 1, 11);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│        │   ┌──┐┌──┐   │        │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│        │   │  └┘  │   │        │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│        └┐ ┌┘      └┐ ┌┘        │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│         └┬┘ ┌┐  ┌┐ └┬┘         │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│       ┌──┤  └┘  └┘  ├──┐       │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│     ┌─┘  ├┐        ┌┤  └─┐     │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    ┌┘   ┌┤└┐ ┌──┐ ┌┘├┐   └┐    │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│    │    │└┐└┬┘  └┬┘┌┘│    │    │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    │    │ └┐└────┘┌┘ │    │    │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│    │    └┐ └┐    ┌┘ ┌┘    │    │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│    │     │  └────┘  │     │    │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└────┴─────┴──────────┴─────┴────┘");

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

        public void DoctorLogoRight(ref int movePos)
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
                Console.Write("┌──────────┬──────────┬──────────┐");
                Console.SetCursorPosition(movePos + 1, 11);
                Console.Write("│         ┌┘          └┐         │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│        │   ┌──┐┌──┐   │        │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│        │   │  └┘  │   │        │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│        └┐ ┌┘      └┐ ┌┘        │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│         └┬┘ ┌┐  ┌┐ └┬┘         │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│       ┌──┤  └┘  └┘  ├──┐       │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│     ┌─┘  ├┐        ┌┤  └─┐     │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    ┌┘   ┌┤└┐ ┌──┐ ┌┘├┐   └┐    │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│    │    │└┐└┬┘  └┬┘┌┘│    │    │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    │    │ └┐└────┘┌┘ │    │    │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│    │    └┐ └┐    ┌┘ ┌┘    │    │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│    │     │  └────┘  │     │    │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└────┴─────┴──────────┴─────┴────┘");

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
