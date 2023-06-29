using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Permanent  //제후
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation,ref int[] point)
        {
            int number = random.Next(0, 10);

            switch (number)
            {
                case 0:
                    conversation[0] = "      강도가 들었습니다! 대담한     ";
                    conversation[1] = "     갱단이 보물을 훔쳐갔습니다.    ";
                    conversation[2] = "                                    ";
                    conversation[3] = "혹시 자네의 친구인가?";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = 0;
                    point[2] = 0;
                    point[3] = -10;

                    point[4] = 0;
                    point[5] = 0;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 1:
                    conversation[0] = "    국가는 30년만의 한파를 겪고     ";
                    conversation[1] = "   있습니다. 흉작에 대비한 비축도   ";
                    conversation[2] = "  없어 백성들이 굶주리고 있습니다.  ";
                    conversation[3] = "짐에게 어쩌라는 건가!";
                    conversation[4] = "비축분을 나누어주게";
                    point[0] = 0;
                    point[1] = -20;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 10;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 2:                         //제후 파트 +                     
                    conversation[0] = "                                    ";
                    conversation[1] = "  멧돼지 사냥이라도 가시겠습니까?   ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = 0;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 0;
                    point[6] = 0;
                    point[7] = 0;
                    break;
                case 3:
                    conversation[0] = "  멋지게 사냥감을 잡으셨군요! 오늘  ";
                    conversation[1] = "   성대하게 잔치를 열어 봅시다!     ";
                    conversation[2] = "                                    ";
                    conversation[3] = "식량을 백성어게 나눠주어라";
                    conversation[4] = "예";
                    point[0] = -10;
                    point[1] = 20;
                    point[2] = -10;
                    point[3] = -10;

                    point[4] = 10;
                    point[5] = 0;
                    point[6] = 10;
                    point[7] = -10;
                    break;
                case 4:                                       
                    conversation[0] = "                                    ";
                    conversation[1] = "  화마가 성에도 다가오고 있습니다!  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "국고를 지켜라!";
                    conversation[4] = "요새를 지켜라!";
                    point[0] = -10;
                    point[1] = -10;
                    point[2] = -20;
                    point[3] = 0;

                    point[4] = -10;
                    point[5] = -10;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 5:
                    conversation[0] = "  봄부터 여름에 걸쳐 수도의 악취가  ";
                    conversation[1] = "  심해집니다. 하수도를 정비합시다.  ";
                    conversation[2] = "                                    ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = -10;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = 0;
                    point[5] = 20;
                    point[6] = 0;
                    point[7] = -20;
                    break;
                case 6:
                    conversation[0] = " 폐하! 가난한 사람들이 폭도가 되어  ";
                    conversation[1] = "     도시를 습격하고 있습니다!      ";
                    conversation[2] = "                                    ";
                    conversation[3] = "좋을 대로 하게 두게";
                    conversation[4] = "몰아내게";
                    point[0] = -10;
                    point[1] = 10;
                    point[2] = -10;
                    point[3] = 0;

                    point[4] = 10;
                    point[5] = -10;
                    point[6] = 10;
                    point[7] = 0;
                    break;
                case 7:
                    conversation[0] = "  상인들이 새로운 길드를 결성하여   ";
                    conversation[1] = "       대표를 성에 파견하고         ";
                    conversation[2] = "          싶다고 합니다.            ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = 0;
                    point[2] = 0;
                    point[3] = -20;

                    point[4] = -10;
                    point[5] = -10;
                    point[6] = -10;
                    point[7] = 20;
                    break;
                case 8:                                        // 노예 이벤트 시작
                    conversation[0] = " 폐하...저희끼리 하는 이야기인데... ";
                    conversation[1] = "     '사업'에 투자하시겠습니까?     ";
                    conversation[2] = "         잘 되면 대박입니다.        ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 10;
                    point[1] = 10;
                    point[2] = 0;
                    point[3] = 0;

                    point[4] = -10;
                    point[5] = -20;
                    point[6] = 0;
                    point[7] = 10;
                    break;
                case 9:
                    conversation[0] = " 다른나라상인이 처음 보는 농기구를  ";
                    conversation[1] = " 팔고 있습니다. 똑같이 따라 만들어  ";
                    conversation[2] = "      보는 것은 어떻습니까?         ";
                    conversation[3] = "아니요";
                    conversation[4] = "예";
                    point[0] = 0;
                    point[1] = 0;
                    point[2] = 0;
                    point[3] = 10;

                    point[4] = 0;
                    point[5] = 0;
                    point[6] = 0;
                    point[7] = -20;
                    break;
            }
        }

        public void PermanentLogo()
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
            Console.Write("│          │          │          │");
            Console.SetCursorPosition(31, 16);
            Console.Write("│          │          │          │");
            Console.SetCursorPosition(31, 17);
            Console.Write("│          │  ┌┐  ┌┐  │          │");
            Console.SetCursorPosition(31, 18);
            Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
            Console.SetCursorPosition(31, 19);
            Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
            Console.SetCursorPosition(31, 20);
            Console.Write("│     ┌┘   └┬─┐    ┌─┬┘   └┐     │");
            Console.SetCursorPosition(31, 21);
            Console.Write("│    ┌┘     └┐└────┘┌┘     └┐    │");
            Console.SetCursorPosition(31, 22);
            Console.Write("│    │       └┐    ┌┘       │    │");
            Console.SetCursorPosition(31, 23);
            Console.Write("│    │        └────┘        │    │");
            Console.SetCursorPosition(31, 24);
            Console.Write("└────┴──────────────────────┴────┘");
            Console.SetCursorPosition(30, 26);
            Console.Write("              헨리 공               ");
        }

        public void PermanentLogoLeft(ref int movePos)
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
                Console.Write("│          │          │          │");
                Console.SetCursorPosition(movePos - 1, 16);
                Console.Write("│          │          │          │");
                Console.SetCursorPosition(movePos - 1, 17);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos - 1, 18);
                Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
                Console.SetCursorPosition(movePos - 1, 19);
                Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
                Console.SetCursorPosition(movePos - 1, 20);
                Console.Write("│     ┌┘   └┬─┐    ┌─┬┘   └┐     │");
                Console.SetCursorPosition(movePos - 1, 21);
                Console.Write("│    ┌┘     └┐└────┘┌┘     └┐    │");
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

        public void PermanentLogoRight(ref int movePos)
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
                Console.Write("│          │          │          │");
                Console.SetCursorPosition(movePos + 1, 16);
                Console.Write("│          │          │          │");
                Console.SetCursorPosition(movePos + 1, 17);
                Console.Write("│          │  ┌┐  ┌┐  │          │");
                Console.SetCursorPosition(movePos + 1, 18);
                Console.Write("│       ┌──┤  ││  ││  ├──┐       │");
                Console.SetCursorPosition(movePos + 1, 19);
                Console.Write("│      ┌┘  │  └┘  └┘  │  └┐      │");
                Console.SetCursorPosition(movePos + 1, 20);
                Console.Write("│     ┌┘   └┬─┐    ┌─┬┘   └┐     │");
                Console.SetCursorPosition(movePos + 1, 21);
                Console.Write("│    ┌┘     └┐└────┘┌┘     └┐    │");
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
