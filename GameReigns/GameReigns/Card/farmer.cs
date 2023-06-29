using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Farmer     //농부
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation, ref int[] point)
        {
            int number = random.Next(0,12);

            switch (number)
            {
                case 0:
                    conversation[0] = "  물방울 강이 범람하여 전국에 홍수  ";
                    conversation[1] = "   피해가 생겼습니다! 교회와 군대   ";
                    conversation[2] = "     모두 구호활동을 도와주세요!    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -20;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = -10;
                    point[5] = 10;
                    point[6] = -10;
                    point[7] = -20;
                    break;
                case 1:
                    conversation[0] = "    광산에서 금이 발견되었습니다.   ";
                    conversation[1] = "         더 깊이 파볼까요?          ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 0;
                    point[3] = 10;

                    point[4] = 0;
                    point[5] = -20;
                    point[6] = 0;
                    point[7] = 10;
                    break;
                case 2:
                    conversation[0] = "  소들이 전염병으로 매일 죽어가고   ";
                    conversation[1] = "    있습니다. 농부들의 생계를       ";
                    conversation[2] = " 유지할 수 있도록 부디 도와주세요!  ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 0;
                    point[3] = 10;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 0;
                    point[7] = -10;
                    break;
                case 3:                     //대사 특정 카드 발생
                    conversation[0] = "    물방울 강이 말라 버렸습니다.    ";
                    conversation[1] = "       댐을 건설해야 합니다.        ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 4:
                    conversation[0] = "   광산 폭발사고로 적어도 100명이   ";
                    conversation[1] = "  목숨을 잃었습니다. 그래도 채금을  ";
                    conversation[2] = "         계속하시겠습니까?          ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = 0;
                    point[2] = 0;
                    point[3] = -10;

                    point[4] = 0;
                    point[5] = -20;
                    point[6] = 0;
                    point[7] = 10;
                    break;
                case 5:
                    conversation[0] = "     광산 노동자들이 임금인상을     ";
                    conversation[1] = "       요구하며 파업중입니다.       ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 6:
                    conversation[0] = "   월리엄 집행관이(가) 마음에 들지  ";
                    conversation[1] = "       않습니다. 녀석은 게으른      ";
                    conversation[2] = "           사기꾼이에요.            ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 10;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 0;
                    point[6] = -10;
                    point[7] = 0;
                    break;
                case 7:
                    conversation[0] = "    올해는 심한 흉년으로 백성들이   ";
                    conversation[1] = "         굶주리고 있습니다.         ";
                    conversation[2] = "         세금을 낮추십시오.         ";
                    conversation[3] = "뻔뻔하군";
                    conversation[4] = "예";
                    point[0] = 10;
                    point[1] = -20;
                    point[2] = 10;
                    point[3] = 0;

                    point[4] = -10;
                    point[5] = 20;
                    point[6] = -10;
                    point[7] = -10;
                    break;
                case 8:
                    conversation[0] = "      밤의 수도는 위험합니다.       ";
                    conversation[1] = "    야간 외출을 금지해야 합니다.    ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = -10;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 10;
                    point[7] = -10;
                    break;
                case 9:
                    conversation[0] = "       폐하께서 이를 하셨다니       ";
                    conversation[1] = "         믿을 수 없습니다.          ";
                    conversation[2] = "                                    ";
                    conversation[3] = "농담이었네";
                    conversation[4] = "협상한다";
                    point[0] = 0;
                    point[1] = 10;
                    point[2] = -10;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = -10;
                    point[6] = 10;
                    point[7] = 0;
                    break;
                case 10:
                    conversation[0] = "   농민 반란이 일어났습니다! 많은   ";
                    conversation[1] = "    군중이 수도에서 약탈 행위에     ";
                    conversation[2] = " 가담하고 군인도 제어할 수 없습니다 ";
                    conversation[3] = "성문을 폐쇄하게";
                    conversation[4] = "군대를 증원하게";
                    point[0] = -20;
                    point[1] = -20;
                    point[2] = 20;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = -10;
                    point[6] = 20;
                    point[7] = -20;
                    break;
                case 11:                  //비축식량 : 민심0일 경우 민심 50
                    conversation[0] = "      기근을 대비해 식량창고를      ";
                    conversation[1] = "      만드시는 것이 어떻습니까      ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -20;
                    point[2] = -10;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 10;
                    point[7] = -20;
                    break;
            }
        }

        public void FarmerLogo()
        {
            Console.SetCursorPosition(31, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(31, 11);
            Console.Write("│                                │");
            Console.SetCursorPosition(31, 12);
            Console.Write("│            ┌──────┐            │");
            Console.SetCursorPosition(31, 13);
            Console.Write("│           ┌┘      └┐           │");
            Console.SetCursorPosition(31, 14);
            Console.Write("│          ┌┘        └┐          │");
            Console.SetCursorPosition(31, 15);
            Console.Write("│          │  ──  ──  │          │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│          │  ┌┐  ┌┐  │          │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│        ┌─┤  └┘  └┘  ├─┐        │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│       ┌┘ │          │ └┐       │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│      ┌┤  │          │  ├┐      │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│     ┌┘│  └┐        ┌┘  │└┐     │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    ┌┘ │   └┐      ┌┘   │ └┐    │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│   ┌┘  │    └┐    ┌┘    │  └┐   │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│   └┐  │     └────┘     │  ┌┘   │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└────┴──┴────────────────┴──┴────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("                 분                 ");
        }

        public void FarmerLogoLeft(ref int movePos)
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
                Console.Write("│                                │");
                Console.SetCursorPosition(movePos - 1, 12);
                Console.Write("│            ┌──────┐            │");
                Console.SetCursorPosition(movePos - 1, 13);
                Console.Write("│           ┌┘      └┐           │");
                Console.SetCursorPosition(movePos - 1, 14);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos - 1, 15);
                Console.Write("│          │  ──  ──  │          │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│        ┌─┤  └┘  └┘  ├─┐        │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│       ┌┘ │          │ └┐       │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│      ┌┤  │          │  ├┐      │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│     ┌┘│  └┐        ┌┘  │└┐     │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    ┌┘ │   └┐      ┌┘   │ └┐    │");
                Console.SetCursorPosition(movePos - 1, 22);
                Console.Write("│   ┌┘  │    └┐    ┌┘    │  └┐   │");
                Console.SetCursorPosition(movePos - 1, 23);
                Console.Write("│   └┐  │     └────┘     │  ┌┘   │");
                Console.SetCursorPosition(movePos - 1, 24);
                Console.Write("└────┴──┴────────────────┴──┴────┘");

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

        public void FarmerLogoRight(ref int movePos)
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
                Console.Write("│                                │");
                Console.SetCursorPosition(movePos + 1, 12);
                Console.Write("│            ┌──────┐            │");
                Console.SetCursorPosition(movePos + 1, 13);
                Console.Write("│           ┌┘      └┐           │");
                Console.SetCursorPosition(movePos + 1, 14);
                Console.Write("│          ┌┘        └┐          │");
                Console.SetCursorPosition(movePos + 1, 15);
                Console.Write("│          │  ──  ──  │          │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│        ┌─┤  └┘  └┘  ├─┐        │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│       ┌┘ │          │ └┐       │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│      ┌┤  │          │  ├┐      │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│     ┌┘│  └┐        ┌┘  │└┐     │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    ┌┘ │   └┐      ┌┘   │ └┐    │");
                Console.SetCursorPosition(movePos + 1, 22);
                Console.Write("│   ┌┘  │    └┐    ┌┘    │  └┐   │");
                Console.SetCursorPosition(movePos + 1, 23);
                Console.Write("│   └┐  │     └────┘     │  ┌┘   │");
                Console.SetCursorPosition(movePos + 1, 24);
                Console.Write("└────┴──┴────────────────┴──┴────┘");

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
