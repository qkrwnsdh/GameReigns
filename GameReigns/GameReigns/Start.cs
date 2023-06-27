﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns
{
    public class Start
    {
        int MOVE_POS = 3;

        int MAP_SIZE_X = 96;
        int MAP_SIZE_Y = 29;

        int RELIGION = 50;
        int SENTIMENT = 50;
        int MILITARY = 50;
        int MONEY = 50;

        int year = default;
        int count = default;
        string playerName = default;
        string[] conversation = new string[3];

        ConsoleKeyInfo keys;

        public void GameStart()
        {
            Name name = new Name();
            Influence influence = new Influence();
            Card.Witch witch = new Card.Witch();
            Card.Doctor doctor = new Card.Doctor();
            Card.Ghost ghost = new Card.Ghost();
            Card.Ambassador ambassador = new Card.Ambassador();
            Card.Executor executor = new Card.Executor();
            Card.Farmer farmer = new Card.Farmer();
            Card.General general = new Card.General();
            Card.Lover lover = new Card.Lover();
            Card.Permanent permanent = new Card.Permanent();
            Card.Priests priests = new Card.Priests();

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

                    priests.Conversation(ref conversation);

                    Console.SetCursorPosition(30, 7);
                    Console.Write(conversation[0]);
                    Console.SetCursorPosition(30, 8);
                    Console.Write(conversation[1]);
                    Console.SetCursorPosition(30, 9);
                    Console.Write(conversation[2]);

                    Console.SetCursorPosition(0, 29);

                    keys = Console.ReadKey(true);

                    while (true)
                    {
                        if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                        {

                        }
                        else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                        {

                        }
                    }
                }

                else if (ConsoleKey.Escape == keys.Key)
                {
                    Background();
                    Escape();

                    keys = Console.ReadKey(true);

                    if (ConsoleKey.Enter == keys.Key)
                    {
                        Console.Clear();

                        break;
                    }

                    else if (ConsoleKey.Escape == keys.Key)
                    {
                        Background();
                        BackgroundLogo();

                        Console.SetCursorPosition(0, 29);

                        continue;
                    }
                }

                else
                {
                    continue;
                }
            }
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
            Console.Write("│                                    │");
            Console.SetCursorPosition(29, 10);
            Console.Write("│ ┌────────────────────────────────┐ │");
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
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 22);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 23);
            Console.Write("│ │                                │ │");
            Console.SetCursorPosition(29, 24);
            Console.Write("│ └────────────────────────────────┘ │");
            Console.SetCursorPosition(29, 25);
            Console.Write("├────────────────────────────────────┤");
            Console.SetCursorPosition(29, 26);
            Console.Write("│                                    │");
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

        public void Escape()
        {
            Console.SetCursorPosition(24, 1);
            Console.Write("                  ┌──────────┐                  ");
            Console.SetCursorPosition(24, 2);
            Console.Write("                 ┌┘          └┐                 ");
            Console.SetCursorPosition(24, 3);
            Console.Write("                ┌┘            └┐                ");
            Console.SetCursorPosition(24, 4);
            Console.Write("                │   ┌┐    ┌┐   │                ");
            Console.SetCursorPosition(24, 5);
            Console.Write("                │   ││    ││   │                ");
            Console.SetCursorPosition(24, 6);
            Console.Write("                │   ││    ││   │                ");
            Console.SetCursorPosition(24, 7);
            Console.Write("                │   └┘    └┘   │                ");
            Console.SetCursorPosition(24, 8);
            Console.Write("                │              │                ");
            Console.SetCursorPosition(24, 9);
            Console.Write("                └─┐          ┌─┘                ");
            Console.SetCursorPosition(24, 10);
            Console.Write("                  │┌┐      ┌┐│                  ");
            Console.SetCursorPosition(24, 11);
            Console.Write("                  └┘│┌┐  ┌┐│└┘                  ");
            Console.SetCursorPosition(24, 12);
            Console.Write("          ┌──┐      └┘│┌┐│└┘      ┌──┐          ");
            Console.SetCursorPosition(24, 13);
            Console.Write("         ┌┘  └──┐     └┘└┘     ┌──┘  └┐         ");
            Console.SetCursorPosition(24, 14);
            Console.Write("        ┌┘      └──┐  ┌──┐  ┌──┘      └┐        ");
            Console.SetCursorPosition(24, 15);
            Console.Write("       ┌┘          │  └──┘  │          └┐       ");
            Console.SetCursorPosition(24, 16);
            Console.Write("      ┌┘          ┌┘  ┌──┐  └┐          └┐      ");
            Console.SetCursorPosition(24, 17);
            Console.Write("     ┌┘           │   └──┘   │           └┐     ");
            Console.SetCursorPosition(24, 18);
            Console.Write("┌────┴────────────┴──────────┴────────────┴────┐");
            Console.SetCursorPosition(24, 19);
            Console.Write("│                                              │");
            Console.SetCursorPosition(24, 20);
            Console.Write("│                                              │");
            Console.SetCursorPosition(24, 21);
            Console.Write("│                                              │");
            Console.SetCursorPosition(24, 22);
            Console.Write("│                                              │");
            Console.SetCursorPosition(24, 23);
            Console.Write("│                                              │");
            Console.SetCursorPosition(24, 24);
            Console.Write("│ ┌──────────────────────────────────────────┐ │");
            Console.SetCursorPosition(24, 25);
            Console.Write("│ │                                          │ │");
            Console.SetCursorPosition(24, 26);
            Console.Write("│ └──────────────────────────────────────────┘ │");
            Console.SetCursorPosition(24, 27);
            Console.Write("└──────────────────────────────────────────────┘");
            Console.SetCursorPosition(36, 21);
            Console.Write("게임을 종료하시겠습니까?");
            Console.SetCursorPosition(46, 25);
            Console.Write("종료");
            Console.SetCursorPosition(0, 29);
        }

        public void Witch()
        {
            Console.SetCursorPosition(29, 10);
            Console.Write("┌────────────────────────────────┐");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("│                                │");
            Console.Write("└────┴──────────────────────┴────┘");
        }

        public void Priests()
        { 
        
        }

        public void Permanent()
        { 
        
        }

        public void Lover()
        { 
        
        }

        public void Ghost()
        { 
        
        }

        public void General()
        { 
        
        }

        public void Farmer()
        { 
        
        }

        public void Executor()
        { 
        
        }

        public void Doctor()
        { 
        
        }

        public void Ambassador()
        { 
        
        }
    }
}
