using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Ambassador //대사
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0, 9);

            switch (number)
            {
                case 0:
                    conversation[0] = "      물방울 강 하구 부근에서       ";
                    conversation[1] = "   위험한 습지가 펼쳐져 있습니다.   ";
                    conversation[2] = "       그 일대를 소독합시다.        ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 20; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 1:
                    conversation[0] = "   서쪽 나라의 왕이 아군의 현황을   ";
                    conversation[1] = "    파악한 모양입니다 금방이라도    ";
                    conversation[2] = "          쳐들어 올 겁니다!         ";
                    conversation[3] = "퇴각태세를 정비하라!";
                    conversation[4] = "병력을 소집해 공격하라!";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 2:                 //농부 특정 파트 이후 발생
                    conversation[0] = "   댐을 건설하면 바이킹들이 강을    ";
                    conversation[1] = "       이용할 수 없게 됩니다.       ";
                    conversation[2] = "         계속 하시겠습니까?         ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 20; pattern[3] = " ○ ";

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:
                    conversation[0] = "  남쪽 왕국에는 젊은 공주가 있는데  ";
                    conversation[1] = "   폐하와 공주의 약혼을 원합니다.   ";
                    conversation[2] = " 거부하면 전쟁이 일어날수 있습니다. ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 10; pattern[7] = " ○ ";
                    break;
                case 4:
                    conversation[0] = "        적국에서 평화협정을         ";
                    conversation[1] = "          제의해 왔습니다.          ";
                    conversation[2] = "   전쟁을 끝낼 절호의 기회입니다.   ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = -20; pattern[2] = " ○ ";
                    point[3] = -20; pattern[3] = " ○ ";

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 10; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = "   폐하 잠시 귀를 빌려 주시지요...  ";
                    conversation[1] = "  젊은 여자가 자신의 아들이 폐하의  ";
                    conversation[2] = "  사생아라 주장하는데 처리 할까요?  ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 6:
                    conversation[0] = "    이웃나라에 대사관을 설치하는    ";
                    conversation[1] = "   건 어떻습니까? 전쟁을 막을 수    ";
                    conversation[2] = "        있을 거라 생각합니다.       ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 7:
                    conversation[0] = "      서쪽 나라 왕이 우리나라       ";
                    conversation[1] = "   영토의 일부를 구입하고 싶다는    ";
                    conversation[2] = "       전갈을 보내왔습니다.         ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 0; pattern[4] = default;
                    point[5] = -20; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 20; pattern[7] = " ○ ";
                    break;
                case 8:
                    conversation[0] = "   남쪽 나라 여왕님께서 책을 40권   ";
                    conversation[1] = "         헌상해 주셨습니다.         ";
                    conversation[2] = "        도서관을 건립합시다!        ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 20; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
            }
        }

        public void AmbassadorLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│           ┌─────────┐          │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│          ┌┘         └┐         │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│          │ ┌───────┐ │         │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│          │┌┘       └┐│         │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│          ││         ││         │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│       ┌─┐├┘ ┌┐   ┌┐ └┤┌─┐      │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│     ┌─┘ └┤  ││   ││  ├┘ └┐     │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│    ┌┘    │  └┘   └┘  │   └┐    │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    └┐    │           │   ┌┘    │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│    ┌┴─┐  └─┐       ┌─┘ ┌─┴┐    │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│   ┌┘  └─┐  └─┐   ┌─┘ ┌─┘  └┐   │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│   │     └─┐  └─┬─┘ ┌─┘     │   │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│   │       └─┐  │ ┌─┘       │   │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└───┴─────────┴──┴─┴─────────┴───┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("             토마스 웨어            ");
        }

        public void AmbassadorLogoLeft(ref int movePos)
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
                Console.Write("│           ┌─────────┐          │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│          ┌┘         └┐         │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│          │ ┌───────┐ │         │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│          │┌┘       └┐│         │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│          ││         ││         │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│       ┌─┐├┘ ┌┐   ┌┐ └┤┌─┐      │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│     ┌─┘ └┤  ││   ││  ├┘ └┐     │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│    ┌┘    │  └┘   └┘  │   └┐    │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    └┐    │           │   ┌┘    │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│    ┌┴─┐  └─┐       ┌─┘ ┌─┴┐    │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│   ┌┘  └─┐  └─┐   ┌─┘ ┌─┘  └┐   │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│   │     └─┐  └─┬─┘ ┌─┘     │   │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│   │       └─┐  │ ┌─┘       │   │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└───┴─────────┴──┴─┴─────────┴───┘");

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

        public void AmbassadorLogoRight(ref int movePos)
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
                Console.Write("│           ┌─────────┐          │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│          ┌┘         └┐         │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│          │ ┌───────┐ │         │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│          │┌┘       └┐│         │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│          ││         ││         │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│       ┌─┐├┘ ┌┐   ┌┐ └┤┌─┐      │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│     ┌─┘ └┤  ││   ││  ├┘ └┐     │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│    ┌┘    │  └┘   └┘  │   └┐    │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    └┐    │           │   ┌┘    │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│    ┌┴─┐  └─┐       ┌─┘ ┌─┴┐    │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│   ┌┘  └─┐  └─┐   ┌─┘ ┌─┘  └┐   │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│   │     └─┐  └─┬─┘ ┌─┘     │   │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│   │       └─┐  │ ┌─┘       │   │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└───┴─────────┴──┴─┴─────────┴───┘");

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
