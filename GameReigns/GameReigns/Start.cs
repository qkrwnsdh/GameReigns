using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns
{
    public class Start
    {
        int MAP_SIZE_X = 96;
        int MAP_SIZE_Y = 29;

        int RELIGION = 50;
        int SENTIMENT = 50;
        int MILITARY = 50;
        int MONEY = 50;

        int year = default;
        int count = default;
        string playerName = default;

        ConsoleKeyInfo keys;

        public void GameStart()
        {
            Name name = new Name();
            Influence influence = new Influence();

            name.PlayerName(ref playerName);

            Background();
            BackgroundLogo();

            Console.SetCursorPosition(0, 29);

            while (true)
            {
                keys = Console.ReadKey(true);

                if (ConsoleKey.Enter == keys.Key)
                {
                    Background();
                    BackgroundNature();

                    Console.SetCursorPosition(3, 1);
                    Console.Write("{0,3}년 제위", count + 1);

                    Console.SetCursorPosition(88, 1);
                    Console.Write("{0,4}", year + 600);

                    Console.SetCursorPosition(3, 27);
                    Console.Write("{0}", playerName);

                    BackgroundCard();

                    Console.SetCursorPosition(33, 4);
                    Console.Write("{0, 3}", RELIGION);
                    Console.SetCursorPosition(42, 4);
                    Console.Write("{0, 3}", SENTIMENT);
                    Console.SetCursorPosition(51, 4);
                    Console.Write("{0, 3}", MILITARY);
                    Console.SetCursorPosition(60, 4);
                    Console.Write("{0,3}", MONEY);

                    Console.SetCursorPosition(0, 29)

                    keys = Console.ReadKey(true);

                    if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                    {

                    }
                    else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                    { 
                    
                    }
                }
                else if (ConsoleKey.Escape == keys.Key)
                {
                    Background();
                }
                else
                {
                    continue;
                }
            }

        }

        public void GameStop()
        {

        }

        public void Background()
        {
            string[,] map_size = new string[MAP_SIZE_Y, MAP_SIZE_X];

            for (int y = 0; y < MAP_SIZE_Y; y++)
            {
                for (int x = 0; x < MAP_SIZE_X; x++)
                {
                    if (y == 0 && x == 0)
                    {
                        map_size[y, x] = "┌";
                    }
                    else if (y == MAP_SIZE_Y - 1 && x == 0)
                    {
                        map_size[y, x] = "└";
                    }
                    else if (y == MAP_SIZE_Y - 1 && x == MAP_SIZE_X - 1)
                    {
                        map_size[y, x] = "┘";
                    }
                    else if (y == 0 && x == MAP_SIZE_X - 1)
                    {
                        map_size[y, x] = "┐";
                    }
                    else if (y == 0 || y == MAP_SIZE_Y - 1)
                    {
                        map_size[y, x] = "─";
                    }
                    else if (x == 0 || x == MAP_SIZE_X - 1)
                    {
                        map_size[y, x] = "│";
                    }
                    else
                    {
                        map_size[y, x] = " ";
                    }
                }
            }

            for (int y = 0; y < MAP_SIZE_Y; y++)
            {
                for (int x = 0; x < MAP_SIZE_X; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("{0}", map_size[y, x]);
                }
            }
        }

        public void BackgroundLogo()
        {
            Console.SetCursorPosition(1, 1);
            Console.Write("             ┌─────┐                                                       ┌─────┐            ");
            Console.SetCursorPosition(1, 2);
            Console.Write("             │     └─┐                                                   ┌─┘     │            ");
            Console.SetCursorPosition(1, 3);
            Console.Write("             │       └─┐                                               ┌─┘       │            ");
            Console.SetCursorPosition(1, 4);
            Console.Write("┌──────────┐ └─┐┌──────┴─────┐  ┌────────────┐  ┌────────────┐  ┌─────┬┘  ┌──┐ ┌┬┴───────────┐");
            Console.SetCursorPosition(1, 5);
            Console.Write("│          └┐  └┤            │  │            │  │            │  │     │   │  ├─┘│            │");
            Console.SetCursorPosition(1, 6);
            Console.Write("│  ┌─────┐  └┐  │  ┌─────────┤  └────┐  ┌────┘  │  ┌─────────┘  │  ┌┐ └┐  │  │  │  ┌─────────┘");
            Console.SetCursorPosition(1, 7);
            Console.Write("│  │     └┐  │  │  ├─┐       └─┐     │  │       │  │           ┌┤  ││  │ ┌┤  │  │  └─┐        ");
            Console.SetCursorPosition(1, 8);
            Console.Write("│  │     ┌┘  │  │  │ └─┐       └─┐   │  │       │  │         ┌─┘│  ││  ├─┘│  │  │    └─┐      ");
            Console.SetCursorPosition(1, 9);
            Console.Write("│  └─────┘  ┌┘  │  └───┴─────┐   └─┐ │  │       │  │  ┌──────┤  │  │└┐ └┐ │  │  └─┐    └─┐    ");
            Console.SetCursorPosition(1, 10);
            Console.Write("│          ┌┘   │            │     └─┤  │       │  │  │      │  │  ├─┤  │ │  │    └─┐    └─┐  ");
            Console.SetCursorPosition(1, 11);
            Console.Write("│  ┌─┐   ┌─┘    │  ┌─────────┤       │  │       │  │  └┬──┐  │  │  │ └┐ └┐│  │      └─┐    └─┐");
            Console.SetCursorPosition(1, 12);
            Console.Write("│  │ └┐  └┐     │  │         └─┐     │  ├┐      │  │ ┌─┘  │  │ ┌┤  │  │  ││  │        └─┐    │");
            Console.SetCursorPosition(1, 13);
            Console.Write("│  │  └┐  └┐    │  │           └─┐   │  │└─┐    │  ├─┘    │  ├─┘│  │  │  ││  │  ┌──┐    └─┐  │");
            Console.SetCursorPosition(1, 14);
            Console.Write("│  │   └┐  └┐   │  └─────────┐  ┌┴───┘  └──┴─┐  │  └──────┘  │  │  │  └┐ └┘  │  │  └──────┘  │");
            Console.SetCursorPosition(1, 15);
            Console.Write("│  │    └┐  └┐  │            │  │            ├─┬┤            │  │  │   │     │  │            │");
            Console.SetCursorPosition(1, 16);
            Console.Write("└──┘     └───┘  └────────────┘  └──────┬─────┼─┘└──────┬─────┘  └──┘   └─────┘  └────────────┘");
            Console.SetCursorPosition(1, 17);
            Console.Write("                                       └─┐ ┌─┘       ┌─┘                                      ");
            Console.SetCursorPosition(1, 18);
            Console.Write("                                         ├─┘       ┌─┤                                        ");
            Console.SetCursorPosition(1, 19);
            Console.Write("                                ┌─┐    ┌─┘       ┌─┘ └─┐    ┌─┐                               ");
            Console.SetCursorPosition(1, 20);
            Console.Write("                              ┌─┘ └─┐┌─┘       ┌─┘     └─┐┌─┘ └─┐                             ");
            Console.SetCursorPosition(1, 21);
            Console.Write("                              └─┐   └┴┐      ┌─┴─┐      ┌┴┘   ┌─┘                             ");
            Console.SetCursorPosition(1, 22);
            Console.Write("                                └─┐   └─┐  ┌─┘   └─┐  ┌─┘   ┌─┘                               ");
            Console.SetCursorPosition(1, 23);
            Console.Write("                                ┌─┴┐    └─┬┘       └┬─┘    ┌┴─┐                               ");
            Console.SetCursorPosition(1, 24);
            Console.Write("                              ┌─┘  └─┐    └─┐     ┌─┘    ┌─┘  └─┐                             ");
            Console.SetCursorPosition(1, 25);
            Console.Write("                              └─┐    └┬─┐   └─┐ ┌─┘   ┌─┬┘    ┌─┘                             ");
            Console.SetCursorPosition(1, 26);
            Console.Write("                                └─┐ ┌─┘ └─┐ ┌─┘ └─┐ ┌─┘ └─┐ ┌─┘                               ");
            Console.SetCursorPosition(1, 27);
            Console.Write("                                  └─┘     └─┘     └─┘     └─┘                                 ");

        }

        public void BackgroundCard()
        {
            Console.SetCursorPosition(29, 1);
            Console.Write("┌────────────────────────────────────┐");
            Console.SetCursorPosition(29, 2);
            Console.Write("│                                    │");
            Console.SetCursorPosition(29, 3);
            Console.Write("│ ┌─────┐  ┌─────┐  ┌─────┐  ┌─────┐ │");
            Console.SetCursorPosition(29, 4);
            Console.Write("│ │     │  │     │  │     │  │     │ │");
            Console.SetCursorPosition(29, 5);
            Console.Write("│ └─────┘  └─────┘  └─────┘  └─────┘ │");
            Console.SetCursorPosition(29, 6);
            Console.Write("├────────────────────────────────────┤");
            Console.SetCursorPosition(29, 7);
            Console.Write("│                                    │");
            Console.SetCursorPosition(29, 8);
            Console.Write("│                                    │");
            Console.SetCursorPosition(29, 9);
            Console.Write("│ ┌────────────────────────────────┐ │");
            Console.SetCursorPosition(29, 10);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 11);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 12);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 13);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 14);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 15);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 16);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 17);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 18);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 19);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 20);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 21);
            Console.Write("│ └────────────────────────────────┘ │");
            Console.SetCursorPosition(29, 22);
            Console.Write("│                                    │");
            Console.SetCursorPosition(29, 23);
            Console.Write("├────────────────────────────────────┤");
            Console.SetCursorPosition(29, 24);
            Console.Write("│   ┌───┐   ┌───┐    ┌───┐   ┌───┐   │");
            Console.SetCursorPosition(29, 25);
            Console.Write("│   │   │   │   │    │   │   │   │   │");
            Console.SetCursorPosition(29, 26);
            Console.Write("│   └───┘   └───┘    └───┘   └───┘   │");
            Console.SetCursorPosition(29, 27);
            Console.Write("└────────────────────────────────────┘");
            Console.SetCursorPosition(32, 2);
            Console.Write("종 교");
            Console.SetCursorPosition(41, 2);
            Console.Write("민 심");
            Console.SetCursorPosition(50, 2);
            Console.Write("군 사");
            Console.SetCursorPosition(59, 2);
            Console.Write("국 고");
        }

        public void BackgroundNature()
        {
            Console.SetCursorPosition(1, 4);
            Console.Write("                                                                                     ┌────────");
            Console.SetCursorPosition(1, 5);
            Console.Write("                                                                                     │        ");
            Console.SetCursorPosition(1, 6);
            Console.Write("                                                    ┌────────┐                       │        ");
            Console.SetCursorPosition(1, 7);
            Console.Write("                                                   ┌┘        └───┐                  ┌┘        ");
            Console.SetCursorPosition(1, 8);
            Console.Write("                                                   │             └───┐              │         ");
            Console.SetCursorPosition(1, 9);
            Console.Write("                                                   │                 └───┐          │         ");
            Console.SetCursorPosition(1, 10);
            Console.Write("                                                   │                     │          │         ");
            Console.SetCursorPosition(1, 11);
            Console.Write(" ┌──────────┐                               ┌──────┤                     │         ┌┘         ");
            Console.SetCursorPosition(1, 12);
            Console.Write("─┘          │                          ┌────┘     ┌┘                     │         │          ");
            Console.SetCursorPosition(1, 13);
            Console.Write("            └──┐                       │          │                      │         │          ");
            Console.SetCursorPosition(1, 14);
            Console.Write("               └┐   ┌──────────────────┘          │                      └┐        │          ");
            Console.SetCursorPosition(1, 15);
            Console.Write("                └┐  │                             │                       │        │          ");
            Console.SetCursorPosition(1, 16);
            Console.Write("                 └──┴─┐                       ┌───┘                       │        │          ");
            Console.SetCursorPosition(1, 17);
            Console.Write("                      │                   ┌───┘                           │        │          ");
            Console.SetCursorPosition(1, 18);
            Console.Write("                      └┐              ┌───┘                               │       ┌┴───┐      ");
            Console.SetCursorPosition(1, 19);
            Console.Write("                       └┐         ┌───┘                                   └───────┘    └────┐ ");
            Console.SetCursorPosition(1, 20);
            Console.Write("                        └─────────┘                                                         └─");
        }
    }
}
