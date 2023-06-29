using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Ghost      //망자
    {
        public void Conversation(ref string[] conversation, ref int number)
        {
            switch (number)
            {
                case 0:
                    conversation[0] = "                                    ";
                    conversation[1] = "        그대가 젊은 왕인가?         ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    break;
                case 1:
                    conversation[0] = "  내 왕위를 찬탈하고 이 지하감옥에  ";
                    conversation[1] = "    가두어 영원히 나오지 못하게     ";
                    conversation[2] = "            한 게 너구나?           ";
                    conversation[3] = "아냐...";
                    conversation[4] = "그렇다...";
                    break;
                case 2:
                    conversation[0] = "   어쨌든 그 난리통을 물려받은게    ";
                    conversation[1] = "  너로구만 열심히 힘 내봐. 이놈도   ";
                    conversation[2] = "   저놈도 제정신인 놈이 없으니깐    ";
                    conversation[3] = "무슨 소린가?";
                    conversation[4] = "누구 이야기인가?";
                    break;
                case 3:
                    conversation[0] = " 그저 4가지 세력의 균형을 맞추려고  ";
                    conversation[1] = "     노력해봐. 그러면 어깨에서      ";
                    conversation[2] = "     목이 날아가지는 않을 거야.     ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    break;
                case 4:
                    conversation[0] = "                                    ";
                    conversation[1] = "        그대가 젊은 왕인가?         ";
                    conversation[2] = "                                    ";
                    conversation[3] = "적당히 하게...";
                    conversation[4] = "예";
                    break;
                case 5:
                    conversation[0] = "   하하하... 농담이야. 알고 있어.   ";
                    conversation[1] = "      전에도 이런 대화를 했지.      ";
                    conversation[2] = "    그게 우리에게 걸린 저주일세.    ";
                    conversation[3] = "무슨 말인가...";
                    conversation[4] = "잘 모르겠군...";
                    break;
                case 6:
                    conversation[0] = " 우리는 이 왕조의 모든 왕의 기억을  ";
                    conversation[1] = "           계속 지니게 돼.          ";
                    conversation[2] = "                                    ";
                    conversation[3] = "말도 안돼...";
                    conversation[4] = "말도 안돼...";
                    break;
                case 7:
                    conversation[0] = "    들리는 소문에 의하면 왕들의     ";
                    conversation[1] = "  기억에서 해방되려면 악마의 힘을   ";
                    conversation[2] = "        빌려야 한다던데...          ";
                    conversation[3] = "그런 건 없네";
                    conversation[4] = "존재한다";
                    break;
                case 8:
                    conversation[0] = "        과연... 나는 언젠가         ";
                    conversation[1] = "      자유의 몸이 되고 싶다네       ";
                    conversation[2] = "                                    ";
                    conversation[3] = "짐은 그리 생각하지 않네";
                    conversation[4] = "나도 그러길 바란다";
                    break;
            }
        }

        public void GhostLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│          ┌┐ ┌┐  ┌┐ ┌┐          │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│          ││ ││  ││ ││          │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│         ┌┤└─┘└──┘└─┘├┐         │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│        ┌┘│          │└┐        │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│       ┌┘ ├──────────┤ └┐       │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│      ┌┤  │          │  ├┐      │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│     ┌┘│  │  ┌┐  ┌┐  │  │└┐     │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│    ┌┘ │  │  ││  ││  │  │ └┐    │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│   ┌┘  │  │  └┘  └┘  │  │  └┐   │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│   └┐  │  └┐        ┌┘  │  ┌┘   │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    └┐ │   └┐      ┌┘   │ ┌┘    │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│     └┐│    └┐    ┌┘    │┌┘     │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│      └┤     └────┘     ├┘      │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└───────┴────────────────┴───────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("               망자                 ");
        }

        public void GhostLogoLeft(ref int movePos)
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
                Console.Write("│          ┌┐ ┌┐  ┌┐ ┌┐          │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│          ││ ││  ││ ││          │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│         ┌┤└─┘└──┘└─┘├┐         │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│        ┌┘│          │└┐        │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│       ┌┘ ├──────────┤ └┐       │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│      ┌┤  │          │  ├┐      │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│     ┌┘│  │  ┌┐  ┌┐  │  │└┐     │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│    ┌┘ │  │  ││  ││  │  │ └┐    │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│   ┌┘  │  │  └┘  └┘  │  │  └┐   │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│   └┐  │  └┐        ┌┘  │  ┌┘   │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    └┐ │   └┐      ┌┘   │ ┌┘    │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│     └┐│    └┐    ┌┘    │┌┘     │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│      └┤     └────┘     ├┘      │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└───────┴────────────────┴───────┘");

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

        public void GhostLogoRight(ref int movePos)
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
                Console.Write("│          ┌┐ ┌┐  ┌┐ ┌┐          │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│          ││ ││  ││ ││          │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│         ┌┤└─┘└──┘└─┘├┐         │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│        ┌┘│          │└┐        │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│       ┌┘ ├──────────┤ └┐       │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│      ┌┤  │          │  ├┐      │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│     ┌┘│  │  ┌┐  ┌┐  │  │└┐     │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│    ┌┘ │  │  ││  ││  │  │ └┐    │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│   ┌┘  │  │  └┘  └┘  │  │  └┐   │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│   └┐  │  └┐        ┌┘  │  ┌┘   │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    └┐ │   └┐      ┌┘   │ ┌┘    │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│     └┐│    └┐    ┌┘    │┌┘     │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│      └┤     └────┘     ├┘      │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└───────┴────────────────┴───────┘");

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
