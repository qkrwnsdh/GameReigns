using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Witch      //마녀
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0,6);

            switch (number)
            {
                case 0:
                    conversation[0] = "    폐하 가게를 열어도 좋을까요?    ";
                    conversation[1] = "   제가 만든 부적을 팔고 싶습니다.  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 1:
                    conversation[0] = "  자연의 법칙과 인간의 한계에 대해  ";
                    conversation[1] = "         흥미가 있으시다면          ";
                    conversation[2] = "           알려드리지요.            ";
                    conversation[3] = "우쭐대지 말게";
                    conversation[4] = "정말 고맙군";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 2:
                    conversation[0] = " 서쪽 마을의 백성이 고블린의 습격을 ";
                    conversation[1] = "       두려워하고 있습니다.         ";
                    conversation[2] = "    이건 누가 처리해야 하지요?      ";
                    conversation[3] = "교회에 일임하지";
                    conversation[4] = "그대가 처리하게";
                    point[0] = -20; pattern[0] = " ○ ";
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 20; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:
                    conversation[0] = "       수도에 콜레라가 맹위를       ";
                    conversation[1] = "          떨치고 있습니다.          ";
                    conversation[2] = "                                    ";
                    conversation[3] = "성문을 폐쇄하게";
                    conversation[4] = "병자들을 치료하게";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = -20; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
                case 4:
                    conversation[0] = "   공작이 신혼을 맞이하는 여성의    ";
                    conversation[1] = "  잠자리에 함께하는 봉건적 제도를   ";
                    conversation[2] = "   다시 시행하려 하고 있습니다.     ";
                    conversation[3] = "용납할 수 없다";
                    conversation[4] = "원하는 대로 하게 두어라";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = -20; pattern[5] = " ○ ";
                    point[6] = 10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 5:
                    conversation[0] = "     저는 진료소를 지어 역병이      ";
                    conversation[1] = "  유행하는 것을 막을 수 있습니다.   ";
                    conversation[2] = "                                    ";
                    conversation[3] = "우리 의사는 안 되는가?";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 0; pattern[5] = default;
                    point[6] = 0; pattern[6] = default;
                    point[7] = -20; pattern[7] = " ○ ";
                    break;
            }
        }

        public void WitchLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│          ┌─────────┐           │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│       ┌──┘         └─┐         │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│      ┌┘              └──┐      │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│      │                  │      │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│     ┌┘    ┌─────────┐   └┐     │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│     │    ┌┘         └┐   │     │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│    ┌┘    │   ┌┐  ┌┐  │   │     │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│    │     │   ││  ││  │   │     │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    │     └┐  └┘  └┘ ┌┘  ┌┘     │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│   ┌┘      └┐       ┌┘  ┌┘      │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│   └┐       └┬─────┬┘   └┐      │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│    └┐       └┐   ┌┘     └┐     │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│    ┌┘       ┌┘   └┐      └┐    │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└────┴────────┴─────┴───────┴────┘");
            Console.SetCursorPosition(30,26);
            Console.Write("           레이디 푸실리아          ");
        }

        public void WitchLogoLeft(ref int movePos)
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
                Console.Write("│          ┌─────────┐           │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│       ┌──┘         └─┐         │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│      ┌┘              └──┐      │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│      │                  │      │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│     ┌┘    ┌─────────┐   └┐     │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│     │    ┌┘         └┐   │     │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│    ┌┘    │   ┌┐  ┌┐  │   │     │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│    │     │   ││  ││  │   │     │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    │     └┐  └┘  └┘ ┌┘  ┌┘     │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│   ┌┘      └┐       ┌┘  ┌┘      │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│   └┐       └┬─────┬┘   └┐      │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│    └┐       └┐   ┌┘     └┐     │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│    ┌┘       ┌┘   └┐      └┐    │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└────┴────────┴─────┴───────┴────┘");

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

        public void WitchLogoRight(ref int movePos)
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
                Console.Write("│          ┌─────────┐           │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│       ┌──┘         └─┐         │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│      ┌┘              └──┐      │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│      │                  │      │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│     ┌┘    ┌─────────┐   └┐     │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│     │    ┌┘         └┐   │     │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│    ┌┘    │   ┌┐  ┌┐  │   │     │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│    │     │   ││  ││  │   │     │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    │     └┐  └┘  └┘ ┌┘  ┌┘     │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│   ┌┘      └┐       ┌┘  ┌┘      │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│   └┐       └┬─────┬┘   └┐      │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│    └┐       └┐   ┌┘     └┐     │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│    ┌┘       ┌┘   └┐      └┐    │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└────┴────────┴─────┴───────┴────┘");

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
