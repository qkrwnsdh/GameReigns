using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Executor   //사형집행인
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation,ref int[] point, ref string[] pattern)
        {
            int number = random.Next(0, 6);

            switch (number)
            {
                case 0:
                    conversation[0] = "  '분'이(가) 마음에 들지 않습니다.  ";
                    conversation[1] = " 녀석은 이간질하는 거짓말쟁이에요.  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "하지만 유용한 자라네";
                    conversation[4] = "자네 말이 맞네";
                    point[0] = 0; pattern[0] = default;
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 1:
                    conversation[0] = " 감옥에서 죄수가 많이 탈출했습니다. ";
                    conversation[1] = "     수색대를 보내야만 합니다.      ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = -10; pattern[0] = " ○ ";
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = -10; pattern[2] = " ○ ";
                    point[3] = -10; pattern[3] = " ○ ";

                    point[4] = 0; pattern[4] = default;
                    point[5] = 0; pattern[5] = default;
                    point[6] = -20; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
                case 2:
                    conversation[0] = " 대규모의 폭도들이 도시의 매음굴을  ";
                    conversation[1] = " 습격하고 있습니다. 창녀들이 악마에 ";
                    conversation[2] = "  빙의되었다고 주장하고 있습니다.   ";
                    conversation[3] = "정보가 필요하네";
                    conversation[4] = "폭도를 일소하라!";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 10; pattern[4] = " ○ ";
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 3:                     //의사 카드 발생
                    conversation[0] = " 폐하 솜씨좋은 의사가 조카의 목숨을 ";
                    conversation[1] = "  구해주었습니다. 마술도 좀 아는것  ";
                    conversation[2] = "    같습니다. 만나 보시겠습니까?    ";
                    conversation[3] = "그럴 여유는 없다";
                    conversation[4] = "들여보내게";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = -10; pattern[4] = " ○ ";
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = 0; pattern[7] = default;
                    break;
                case 4:
                    conversation[0] = "   과학 박물관을 설립하여 세상에    ";
                    conversation[1] = "   존재하는 모든 생물을 모읍시다.   ";
                    conversation[2] = "      저도 도움을 드리겠습니다.     ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10; pattern[0] = " ○ ";
                    point[1] = 0; pattern[1] = default;
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = 10; pattern[5] = " ○ ";
                    point[6] = 0; pattern[6] = default;
                    point[7] = -10; pattern[7] = " ○ ";
                    break;
                case 5:
                    conversation[0] = "  사형수가 너무 많습니다! 병사들도  ";
                    conversation[1] = "      처형을 돕게 해주십시오.       ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0; pattern[0] = default;
                    point[1] = -10; pattern[1] = " ○ ";
                    point[2] = 0; pattern[2] = default;
                    point[3] = 0; pattern[3] = default;

                    point[4] = 0; pattern[4] = default;
                    point[5] = -10; pattern[5] = " ○ ";
                    point[6] = -10; pattern[6] = " ○ ";
                    point[7] = 0; pattern[7] = default;
                    break;
            }
        }

        public void ExecutorLogo()
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
            Console.Write("│        ┌┘            └┐        │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│       ┌┘              └┐       │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│       │                │       │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│       │     ┌┐  ┌┐     │       │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│      ┌┤     ││  ││     ├┐      │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│    ┌─┘├┐    └┘  └┘    ┌┤└─┐    │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│   ┌┘  │└┐            ┌┘│  └┐   │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│   │   │ └┐          ┌┘ │   │   │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│   │   │  └┐        ┌┘  │   │   │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│   │   │   └────────┘   │   │   │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└───┴───┴────────────────┴───┴───┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("          아데마르 집행관           ");
        }

        public void ExecutorLogoLeft(ref int movePos)
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
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│       ┌┘              └┐       │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│       │                │       │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│       │     ┌┐  ┌┐     │       │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│      ┌┤     ││  ││     ├┐      │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│    ┌─┘├┐    └┘  └┘    ┌┤└─┐    │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│   ┌┘  │└┐            ┌┘│  └┐   │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│   │   │ └┐          ┌┘ │   │   │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│   │   │  └┐        ┌┘  │   │   │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│   │   │   └────────┘   │   │   │");
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

        public void ExecutorLogoRight(ref int movePos)
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
                Console.Write("│        ┌┘            └┐        │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│       ┌┘              └┐       │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│       │                │       │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│       │     ┌┐  ┌┐     │       │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│      ┌┤     ││  ││     ├┐      │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│    ┌─┘├┐    └┘  └┘    ┌┤└─┐    │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│   ┌┘  │└┐            ┌┘│  └┐   │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│   │   │ └┐          ┌┘ │   │   │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│   │   │  └┐        ┌┘  │   │   │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│   │   │   └────────┘   │   │   │");
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
