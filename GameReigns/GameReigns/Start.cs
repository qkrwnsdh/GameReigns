using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameReigns
{
    public class Start
    {
        Name name = new Name();
        Random random = new Random();

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

        int MAP_SIZE_X = 96;
        int MAP_SIZE_Y = 29;

        int RELIGION = 50;
        int SENTIMENT = 50;
        int MILITARY = 50;
        int MONEY = 50;

        int year = default;
        int count = default;
        int endCount = default;
        int quarter = default;
        string playerName = default;

        int prologueCount = 0;
        int prologueNumber = 0;

        int[] point = new int[8];
        string[] conversation = new string[5];

        ConsoleKeyInfo keys;

        public void GameStart()
        {
            while (true)
            {
                name.PlayerName(ref playerName);


                Background();
                BackgroundLogo();

                keys = Console.ReadKey(true); 

                if (ConsoleKey.Enter == keys.Key)
                {

                    while (true)
                    {
                        Background();
                        BackgroundNature();

                        Console.SetCursorPosition(3, 1);
                        Console.Write("{0,3}년 제위", endCount);
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

                        if (endCount == 30)
                        {
                            prologueCount += 1;
                            endCount = 0;

                            WinEnding();

                            Thread.Sleep(1000);

                            continue;
                        }
                        if (RELIGION <= 0)
                        {
                            prologueCount += 1;
                            quarter = 0;
                            endCount = 0;

                            ReligionDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        else if (RELIGION >= 100)
                        {
                            prologueCount += 1;
                            quarter = 1;
                            endCount = 0;

                            ReligionDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        if (SENTIMENT <= 0)
                        {
                            prologueCount += 1;
                            quarter = 0;
                            endCount = 0;

                            SentimentDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        else if (SENTIMENT >= 100)
                        {
                            prologueCount += 1;
                            quarter = 1;
                            endCount = 0;

                            SentimentDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        if (MILITARY <= 0)
                        {
                            prologueCount += 1;
                            quarter = 0;
                            endCount = 0;

                            MilitaryDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        else if (MILITARY >= 100)
                        {
                            prologueCount += 1;
                            quarter = 1;
                            endCount = 0;

                            MilitaryDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        if (MONEY <= 0)
                        {
                            prologueCount += 1;
                            quarter = 0;
                            endCount = 0;

                            MoneyDeath();

                            Thread.Sleep(1000);

                            continue;
                        }
                        else if (MONEY >= 100)
                        {
                            prologueCount += 1;
                            quarter = 1;
                            endCount = 0;

                            MoneyDeath();

                            Thread.Sleep(1000);

                            continue;
                        }

                        int MOVE_POS = 31;

                        while (4 <= prologueNumber && prologueNumber <= 8 && prologueCount == 1)
                        {
                            MOVE_POS = 31;

                            ghost.GhostLogo();
                            ghost.Conversation(ref conversation, ref prologueNumber);

                            Console.SetCursorPosition(30, 7);
                            Console.Write(conversation[0]);
                            Console.SetCursorPosition(30, 8);
                            Console.Write(conversation[1]);
                            Console.SetCursorPosition(30, 9);
                            Console.Write(conversation[2]);

                            while (true)
                            {
                                keys = Console.ReadKey(true);

                                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                                {
                                    if (MOVE_POS == 31 || MOVE_POS == 41)
                                    {
                                        ghost.GhostLogoLeft(ref MOVE_POS);

                                        if (MOVE_POS == 21)
                                        {
                                            Console.SetCursorPosition(22, 11);
                                            Console.Write(conversation[3]);
                                        }
                                    }
                                }

                                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                                {
                                    if (MOVE_POS == 21 || MOVE_POS == 31)
                                    {
                                        ghost.GhostLogoRight(ref MOVE_POS);

                                        if (MOVE_POS == 41)
                                        {
                                            Console.SetCursorPosition(42, 11);
                                            Console.Write(conversation[4]);
                                        }
                                    }
                                }

                                else if (ConsoleKey.Enter == keys.Key)
                                {
                                    if (MOVE_POS == 21)
                                    {
                                        prologueNumber += 1;

                                        break;
                                    }

                                    else if (MOVE_POS == 41)
                                    {
                                        prologueNumber += 1;

                                        break;
                                    }
                                }
                            }

                            Background();
                            BackgroundNature();

                            Console.SetCursorPosition(3, 1);
                            Console.Write("{0,3}년 제위", endCount);
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
                        }

                        while (0 <= prologueNumber && prologueNumber <= 3 && prologueCount == 0)
                        {
                            MOVE_POS = 31;

                            ghost.GhostLogo();
                            ghost.Conversation(ref conversation, ref prologueNumber);

                            Console.SetCursorPosition(30, 7);
                            Console.Write(conversation[0]);
                            Console.SetCursorPosition(30, 8);
                            Console.Write(conversation[1]);
                            Console.SetCursorPosition(30, 9);
                            Console.Write(conversation[2]);

                            while (true)
                            {
                                keys = Console.ReadKey(true);

                                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                                {
                                    if (MOVE_POS == 31 || MOVE_POS == 41)
                                    {
                                        ghost.GhostLogoLeft(ref MOVE_POS);

                                        if (MOVE_POS == 21)
                                        {
                                            Console.SetCursorPosition(22, 11);
                                            Console.Write(conversation[3]);
                                        }
                                    }
                                }

                                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                                {
                                    if (MOVE_POS == 21 || MOVE_POS == 31)
                                    {
                                        ghost.GhostLogoRight(ref MOVE_POS);

                                        if (MOVE_POS == 41)
                                        {
                                            Console.SetCursorPosition(42, 11);
                                            Console.Write(conversation[4]);
                                        }
                                    }
                                }

                                else if (ConsoleKey.Enter == keys.Key)
                                {
                                    if (MOVE_POS == 21)
                                    {
                                        prologueNumber += 1;
                                        
                                        break;
                                    }

                                    else if (MOVE_POS == 41)
                                    {
                                        prologueNumber += 1;

                                        break;
                                    }
                                }
                            }

                            Background();
                            BackgroundNature();

                            Console.SetCursorPosition(3, 1);
                            Console.Write("{0,3}년 제위", endCount);
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
                        }

                        MOVE_POS = 31;

                        count = random.Next(0, 9);

                        switch (count)
                        {
                            case 0:
                                ambassador.AmbassadorLogo();
                                ambassador.Conversation(ref conversation, ref point);
                                break;
                            case 1:
                                doctor.DoctorLogo();
                                doctor.Conversation(ref conversation, ref point);
                                break;
                            case 2:
                                executor.ExecutorLogo();
                                executor.Conversation(ref conversation, ref point);
                                break;
                            case 3:
                                farmer.FarmerLogo();
                                farmer.Conversation(ref conversation, ref point);
                                break;
                            case 4:
                                general.GeneralLogo();
                                general.Conversation(ref conversation, ref point);
                                break;
                            case 5:
                                lover.LoverLogo();
                                lover.Conversation(ref conversation, ref point);
                                break;
                            case 6:
                                permanent.PermanentLogo();
                                permanent.Conversation(ref conversation, ref point);
                                break;
                            case 7:
                                priests.PriestsLogo();
                                priests.Conversation(ref conversation, ref point);
                                break;
                            case 8:
                                witch.WitchLogo();
                                witch.Conversation(ref conversation, ref point);
                                break;
                        }

                        Console.SetCursorPosition(30, 7);
                        Console.Write(conversation[0]);
                        Console.SetCursorPosition(30, 8);
                        Console.Write(conversation[1]);
                        Console.SetCursorPosition(30, 9);
                        Console.Write(conversation[2]);

                        while (true)
                        {
                            keys = Console.ReadKey(true);

                            if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                            {
                                if (MOVE_POS == 31 || MOVE_POS == 41)
                                {
                                    switch (count)
                                    {
                                        case 0:
                                            ambassador.AmbassadorLogoLeft(ref MOVE_POS);
                                            break;
                                        case 1:
                                            doctor.DoctorLogoLeft(ref MOVE_POS);
                                            break;
                                        case 2:
                                            executor.ExecutorLogoLeft(ref MOVE_POS);
                                            break;
                                        case 3:
                                            farmer.FarmerLogoLeft(ref MOVE_POS);
                                            break;
                                        case 4:
                                            general.GeneralLogoLeft(ref MOVE_POS);
                                            break;
                                        case 5:
                                            lover.LoverLogoLeft(ref MOVE_POS);
                                            break;
                                        case 6:
                                            permanent.PermanentLogoLeft(ref MOVE_POS);
                                            break;
                                        case 7:
                                            priests.PriestsLogoLeft(ref MOVE_POS);
                                            break;
                                        case 8:
                                            witch.WitchLogoLeft(ref MOVE_POS);
                                            break;
                                    }

                                    if (MOVE_POS == 21)
                                    {
                                        Console.SetCursorPosition(22, 11);
                                        Console.Write(conversation[3]);
                                    }
                                }
                            }

                            else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                            {
                                if (MOVE_POS == 21 || MOVE_POS == 31)
                                {
                                    switch (count)
                                    {
                                        case 0:
                                            ambassador.AmbassadorLogoRight(ref MOVE_POS);
                                            break;
                                        case 1:
                                            doctor.DoctorLogoRight(ref MOVE_POS);
                                            break;
                                        case 2:
                                            executor.ExecutorLogoRight(ref MOVE_POS);
                                            break;
                                        case 3:
                                            farmer.FarmerLogoRight(ref MOVE_POS);
                                            break;
                                        case 4:
                                            general.GeneralLogoRight(ref MOVE_POS);
                                            break;
                                        case 5:
                                            lover.LoverLogoRight(ref MOVE_POS);
                                            break;
                                        case 6:
                                            permanent.PermanentLogoRight(ref MOVE_POS);
                                            break;
                                        case 7:
                                            priests.PriestsLogoRight(ref MOVE_POS);
                                            break;
                                        case 8:
                                            witch.WitchLogoRight(ref MOVE_POS);
                                            break;
                                    }

                                    if (MOVE_POS == 41)
                                    {
                                        Console.SetCursorPosition(42, 11);
                                        Console.Write(conversation[4]);
                                    }
                                }
                            }

                            else if (ConsoleKey.Enter == keys.Key)
                            {
                                if (MOVE_POS == 21)
                                {
                                    RELIGION += point[0];
                                    SENTIMENT += point[1];
                                    MILITARY += point[2];
                                    MONEY += point[3];

                                    if (RELIGION <= 0)
                                    {
                                        RELIGION = 0;
                                    }
                                    else if (RELIGION >= 100)
                                    {
                                        RELIGION = 100;
                                    }
                                    if (SENTIMENT <= 0)
                                    {
                                        SENTIMENT = 0;
                                    }
                                    else if (SENTIMENT >= 100)
                                    {
                                        SENTIMENT = 100;
                                    }
                                    if (MILITARY <= 0)
                                    {
                                        MILITARY = 0;
                                    }
                                    else if (MILITARY >= 100)
                                    {
                                        MILITARY = 100;
                                    }
                                    if (MONEY <= 0)
                                    {
                                        MONEY = 0;
                                    }
                                    else if (MONEY >= 100)
                                    {
                                        MONEY = 100;
                                    }

                                    year += 1;
                                    endCount += 1;

                                    break;
                                }

                                else if (MOVE_POS == 41)
                                {
                                    RELIGION += point[4];
                                    SENTIMENT += point[5];
                                    MILITARY += point[6];
                                    MONEY += point[7];

                                    if (RELIGION <= 0)
                                    {
                                        RELIGION = 0;
                                    }
                                    else if (RELIGION >= 100)
                                    {
                                        RELIGION = 100;
                                    }
                                    if (SENTIMENT <= 0)
                                    {
                                        SENTIMENT = 0;
                                    }
                                    else if (SENTIMENT >= 100)
                                    {
                                        SENTIMENT = 100;
                                    }
                                    if (MILITARY <= 0)
                                    {
                                        MILITARY = 0;
                                    }
                                    else if (MILITARY >= 100)
                                    {
                                        MILITARY = 100;
                                    }
                                    if (MONEY <= 0)
                                    {
                                        MONEY = 0;
                                    }
                                    else if (MONEY >= 100)
                                    {
                                        MONEY = 100;
                                    }

                                    year += 1;
                                    endCount += 1;

                                    break;
                                }
                            }
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

        public void WinEnding()
        {
            for (int i = 1; i < 28; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("┌──────────┐    ┌────────────┐  ┌────────────┐  ┌────────────┐  ┌─────┐   ┌──┐  ┌────────────┐");
                }
                else if (i == 2)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│          └┐   │            │  │            │  │            │  │     │   │  │  │            │");
                }
                else if (i == 3)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  ┌─────┐  └┐  │  ┌─────────┘  └────┐  ┌────┘  │  ┌─────────┘  │  ┌┐ └┐  │  │  │  ┌─────────┘");
                }
                else if (i == 4)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │     └┐  │  │  │                 │  │       │  │            │  ││  │  │  │  │  └─┐        ");
                }
                else if (i == 5)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │     ┌┘  │  │  │                 │  │       │  │            │  ││  │  │  │  │    └─┐      ");
                }
                else if (i == 6)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  └─────┘  ┌┘  │  └─────────┐       │  │       │  │  ┌──────┐  │  │└┐ └┐ │  │  └─┐    └─┐    ");
                }
                else if (i == 7)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│          ┌┘   │            │       │  │       │  │  │      │  │  │ │  │ │  │    └─┐    └─┐  ");
                }
                else if (i == 8)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  ┌─┐   ┌─┘    │  ┌─────────┘       │  │       │  │  └───┐  │  │  │ └┐ └┐│  │      └─┐    └─┐");
                }
                else if (i == 9)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │ └┐  └┐     │  │                 │  │       │  │      │  │  │  │  │  ││  │        └─┐    │");
                }
                else if (i == 10)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │  └┐  └┐    │  │                 │  │       │  │      │  │  │  │  │  ││  │  ┌──┐    └─┐  │");

                }
                else if (i == 11)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │   └┐  └┐   │  └─────────┐  ┌────┘  └────┐  │  └──────┘  │  │  │  └┐ └┘  │  │  └──────┘  │");
                }
                else if (i == 12)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("│  │    └┐  └┐  │            │  │            │  │            │  │  │   │     │  │            │");
                }
                else if (i == 13)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("└──┘     └───┘  └────────────┘  └────────────┘  └────────────┘  └──┘   └─────┘  └────────────┘");
                }
                else if (i == 14)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                                                                                              ");
                }
                else if (i == 15)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        ┌──┐ ┌──┐ ┌──┐  ┌────────────┐  ┌─────┐   ┌──┐                        ");
                }
                else if (i == 16)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │  │            │  │     │   │  │                        ");
                }
                else if (i == 17)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │  └────┐  ┌────┘  │  ┌┐ └┐  │  │                        ");
                }
                else if (i == 18)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  ││  │  │  │                        ");
                }
                else if (i == 19)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  ││  │  │  │                        ");
                }
                else if (i == 20)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  │└┐ └┐ │  │                        ");
                }
                else if (i == 21)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  │ │  │ │  │                        ");

                }
                else if (i == 22)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  │ └┐ └┐│  │                        ");
                }
                else if (i == 23)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  │  │  ││  │                        ");
                }
                else if (i == 24)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  │ │  │ │  │       │  │       │  │  │  ││  │                        ");
                }
                else if (i == 25)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │  └─┘  └─┘  │  ┌────┘  └────┐  │  │  └┐ └┘  │                        ");
                }
                else if (i == 26)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        │            │  │            │  │  │   │     │                        ");
                }
                else if (i == 27)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("                        └────────────┘  └────────────┘  └──┘   └─────┘                        ");
                }

                Thread.Sleep(10);
            }

            for (int i = 93; i > 15; i--)
            {
                if (i <= 93)
                {
                    Console.SetCursorPosition(i, 20);
                    Console.Write("┌");
                    Console.SetCursorPosition(i + 1, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 1, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i, 22);
                    Console.Write("└");
                    Console.SetCursorPosition(i + 1, 22);
                    Console.Write(" ");
                }
                if (i <= 92)
                {

                    Console.SetCursorPosition(i + 1, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 2, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 1, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 2, 22);
                    Console.Write(" ");

                }
                if (i <= 91)
                {
                    Console.SetCursorPosition(i + 2, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 3, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 2, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 3, 22);
                    Console.Write(" ");
                }
                if (i <= 90)
                {
                    Console.SetCursorPosition(i + 3, 19);
                    Console.Write("┌");
                    Console.SetCursorPosition(i + 4, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 3, 20);
                    Console.Write("┘");
                    Console.SetCursorPosition(i + 4, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 3, 22);
                    Console.Write("┐");
                    Console.SetCursorPosition(i + 4, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 3, 23);
                    Console.Write("└");
                    Console.SetCursorPosition(i + 4, 23);
                    Console.Write(" ");
                }
                if (i <= 89)
                {
                    Console.SetCursorPosition(i + 4, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 5, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 4, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 5, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 4, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 5, 23);
                    Console.Write(" ");
                }
                if (i <= 88)
                {
                    Console.SetCursorPosition(i + 5, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 6, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 5, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 6, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 5, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 6, 23);
                    Console.Write(" ");
                }
                if (i <= 87)
                {
                    Console.SetCursorPosition(i + 6, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 7, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 6, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 7, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 6, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 7, 23);
                    Console.Write(" ");
                }
                if (i <= 86)
                {
                    Console.SetCursorPosition(i + 7, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 8, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 7, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 8, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 7, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 8, 23);
                    Console.Write(" ");
                }
                if (i <= 85)
                {
                    Console.SetCursorPosition(i + 8, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 9, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 8, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 9, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 8, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 9, 23);
                    Console.Write(" ");
                }
                if (i <= 84)
                {
                    Console.SetCursorPosition(i + 9, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 10, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 9, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 10, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 9, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 10, 23);
                    Console.Write(" ");
                }
                if (i <= 83)
                {
                    Console.SetCursorPosition(i + 10, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 11, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 10, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 11, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 10, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 11, 23);
                    Console.Write(" ");
                }
                if (i <= 82)
                {
                    Console.SetCursorPosition(i + 11, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 12, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 11, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 12, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 11, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 12, 23);
                    Console.Write(" ");
                }
                if (i <= 81)
                {
                    Console.SetCursorPosition(i + 12, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 13, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 12, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 13, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 12, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 13, 23);
                    Console.Write(" ");
                }
                if (i <= 80)
                {
                    Console.SetCursorPosition(i + 13, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 14, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 13, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 14, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 13, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 14, 23);
                    Console.Write(" ");
                }
                if (i <= 79)
                {
                    Console.SetCursorPosition(i + 14, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 15, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 14, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 15, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 14, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 15, 23);
                    Console.Write(" ");
                }
                if (i <= 78)
                {
                    Console.SetCursorPosition(i + 15, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 16, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 15, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 16, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 15, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 16, 23);
                    Console.Write(" ");
                }
                if (i <= 77)
                {
                    Console.SetCursorPosition(i + 16, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 17, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 16, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 17, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 16, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 17, 23);
                    Console.Write(" ");
                }
                if (i <= 76)
                {
                    Console.SetCursorPosition(i + 17, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 18, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 17, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 18, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 17, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 18, 23);
                    Console.Write(" ");
                }
                if (i <= 75)
                {
                    Console.SetCursorPosition(i + 18, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 19, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 18, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 19, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 18, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 19, 23);
                    Console.Write(" ");
                }
                if (i <= 74)
                {
                    Console.SetCursorPosition(i + 19, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 20, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 19, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 20, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 19, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 20, 23);
                    Console.Write(" ");
                }
                if (i <= 73)
                {
                    Console.SetCursorPosition(i + 20, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 21, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 20, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 21, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 20, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 21, 23);
                    Console.Write(" ");
                }
                if (i <= 72)
                {
                    Console.SetCursorPosition(i + 21, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 22, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 21, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 22, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 21, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 22, 23);
                    Console.Write(" ");
                }
                if (i <= 71)
                {
                    Console.SetCursorPosition(i + 22, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 23, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 22, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 23, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 22, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 23, 23);
                    Console.Write(" ");
                }
                if (i <= 70)
                {
                    Console.SetCursorPosition(i + 23, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 24, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 23, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 24, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 23, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 24, 23);
                    Console.Write(" ");
                }
                if (i <= 69)
                {
                    Console.SetCursorPosition(i + 24, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 25, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 24, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 25, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 24, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 25, 23);
                    Console.Write(" ");
                }
                if (i <= 68)
                {
                    Console.SetCursorPosition(i + 25, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 26, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 25, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 26, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 25, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 26, 23);
                    Console.Write(" ");
                }
                if (i <= 67)
                {
                    Console.SetCursorPosition(i + 26, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 27, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 26, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 27, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 26, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 27, 23);
                    Console.Write(" ");
                }
                if (i <= 66)
                {
                    Console.SetCursorPosition(i + 27, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 28, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 27, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 28, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 27, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 28, 23);
                    Console.Write(" ");
                }
                if (i <= 65)
                {
                    Console.SetCursorPosition(i + 28, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 29, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 28, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 29, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 28, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 29, 23);
                    Console.Write(" ");
                }
                if (i <= 64)
                {
                    Console.SetCursorPosition(i + 29, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 30, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 29, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 30, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 29, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 30, 23);
                    Console.Write(" ");
                }
                if (i <= 63)
                {
                    Console.SetCursorPosition(i + 30, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 31, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 30, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 31, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 30, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 31, 23);
                    Console.Write(" ");
                }
                if (i <= 62)
                {
                    Console.SetCursorPosition(i + 31, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 32, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 31, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 32, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 31, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 32, 23);
                    Console.Write(" ");
                }
                if (i <= 61)
                {
                    Console.SetCursorPosition(i + 32, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 33, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 32, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 33, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 32, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 33, 23);
                    Console.Write(" ");
                }
                if (i <= 60)
                {
                    Console.SetCursorPosition(i + 33, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 34, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 33, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 34, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 33, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 34, 23);
                    Console.Write(" ");
                }
                if (i <= 59)
                {
                    Console.SetCursorPosition(i + 34, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 35, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 34, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 35, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 34, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 35, 23);
                    Console.Write(" ");
                }
                if (i <= 58)
                {
                    Console.SetCursorPosition(i + 35, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 36, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 35, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 36, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 35, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 36, 23);
                    Console.Write(" ");
                }
                if (i <= 57)
                {
                    Console.SetCursorPosition(i + 36, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 37, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 36, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 37, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 36, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 37, 23);
                    Console.Write(" ");
                }
                if (i <= 56)
                {
                    Console.SetCursorPosition(i + 37, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 38, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 37, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 38, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 37, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 38, 23);
                    Console.Write(" ");
                }
                if (i <= 55)
                {
                    Console.SetCursorPosition(i + 38, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 39, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 38, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 39, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 38, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 39, 23);
                    Console.Write(" ");
                }
                if (i <= 54)
                {
                    Console.SetCursorPosition(i + 39, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 40, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 39, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 40, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 39, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 40, 23);
                    Console.Write(" ");
                }
                if (i <= 53)
                {
                    Console.SetCursorPosition(i + 40, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 41, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 40, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 41, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 40, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 41, 23);
                    Console.Write(" ");
                }
                if (i <= 52)
                {
                    Console.SetCursorPosition(i + 41, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 42, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 41, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 42, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 41, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 42, 23);
                    Console.Write(" ");
                }
                if (i <= 51)
                {
                    Console.SetCursorPosition(i + 42, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 43, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 42, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 43, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 42, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 43, 23);
                    Console.Write(" ");
                }
                if (i <= 50)
                {
                    Console.SetCursorPosition(i + 43, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 44, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 43, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 44, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 43, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 44, 23);
                    Console.Write(" ");
                }
                if (i <= 49)
                {
                    Console.SetCursorPosition(i + 44, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 45, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 44, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 45, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 44, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 45, 23);
                    Console.Write(" ");
                }
                if (i <= 48)
                {
                    Console.SetCursorPosition(i + 45, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 46, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 45, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 46, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 45, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 46, 23);
                    Console.Write(" ");
                }
                if (i <= 47)
                {
                    Console.SetCursorPosition(i + 46, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 47, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 46, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 47, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 46, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 47, 23);
                    Console.Write(" ");
                }
                if (i <= 46)
                {
                    Console.SetCursorPosition(i + 47, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 48, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 47, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 48, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 47, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 48, 23);
                    Console.Write(" ");
                }
                if (i <= 45)
                {
                    Console.SetCursorPosition(i + 48, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 49, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 48, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 49, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 48, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 49, 23);
                    Console.Write(" ");
                }
                if (i <= 44)
                {
                    Console.SetCursorPosition(i + 49, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 50, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 49, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 50, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 49, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 50, 23);
                    Console.Write(" ");
                }
                if (i <= 43)
                {
                    Console.SetCursorPosition(i + 50, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 51, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 50, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 51, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 50, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 51, 23);
                    Console.Write(" ");
                }
                if (i <= 42)
                {
                    Console.SetCursorPosition(i + 51, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 52, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 51, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 52, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 51, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 52, 23);
                    Console.Write(" ");
                }
                if (i <= 41)
                {
                    Console.SetCursorPosition(i + 52, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 53, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 52, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 53, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 52, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 53, 23);
                    Console.Write(" ");
                }
                if (i <= 40)
                {
                    Console.SetCursorPosition(i + 53, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 54, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 53, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 54, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 53, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 54, 23);
                    Console.Write(" ");
                }
                if (i <= 39)
                {
                    Console.SetCursorPosition(i + 54, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 55, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 54, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 55, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 54, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 55, 23);
                    Console.Write(" ");
                }
                if (i <= 38)
                {
                    Console.SetCursorPosition(i + 55, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 56, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 55, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 56, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 55, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 56, 23);
                    Console.Write(" ");
                }
                if (i <= 37)
                {
                    Console.SetCursorPosition(i + 56, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 57, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 56, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 57, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 56, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 57, 23);
                    Console.Write(" ");
                }
                if (i <= 36)
                {
                    Console.SetCursorPosition(i + 57, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 58, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 57, 21);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 58, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 57, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 58, 23);
                    Console.Write(" ");
                }
                if (i <= 35)
                {
                    Console.SetCursorPosition(i + 58, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 59, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 58, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 59, 23);
                    Console.Write(" ");
                }
                if (i <= 34)
                {
                    Console.SetCursorPosition(i + 59, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 60, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 59, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 60, 23);
                    Console.Write(" ");
                }
                if (i <= 33)
                {
                    Console.SetCursorPosition(i + 60, 16);
                    Console.Write("┌");
                    Console.SetCursorPosition(i + 61, 16);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 60, 17);
                    Console.Write("└");
                    Console.SetCursorPosition(i + 61, 17);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 60, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 61, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 60, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 61, 23);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 60, 25);
                    Console.Write("┌");
                    Console.SetCursorPosition(i + 61, 25);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 60, 26);
                    Console.Write("└");
                    Console.SetCursorPosition(i + 61, 26);
                    Console.Write(" ");
                }
                if (i <= 32)
                {
                    Console.SetCursorPosition(i + 61, 16);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 62, 16);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 17);
                    Console.Write("┬");
                    Console.SetCursorPosition(i + 62, 17);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 18);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 62, 18);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 19);
                    Console.Write("┤");
                    Console.SetCursorPosition(i + 62, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 20);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 62, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 62, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 22);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 62, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 23);
                    Console.Write("┤");
                    Console.SetCursorPosition(i + 62, 23);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 24);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 62, 24);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 25);
                    Console.Write("┴");
                    Console.SetCursorPosition(i + 62, 25);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 61, 26);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 62, 26);
                    Console.Write(" ");
                }
                if (i <= 31)
                {
                    Console.SetCursorPosition(i + 62, 16);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 63, 16);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 62, 17);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 63, 17);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 62, 25);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 63, 25);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 62, 26);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 63, 26);
                    Console.Write(" ");
                }
                if (i <= 30)
                {
                    Console.SetCursorPosition(i + 63, 16);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 64, 16);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 17);
                    Console.Write("┬");
                    Console.SetCursorPosition(i + 64, 17);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 18);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 64, 18);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 19);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 64, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 20);
                    Console.Write("├");
                    Console.SetCursorPosition(i + 64, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 64, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 22);
                    Console.Write("├");
                    Console.SetCursorPosition(i + 64, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 23);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 64, 23);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 24);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 64, 24);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 25);
                    Console.Write("┴");
                    Console.SetCursorPosition(i + 64, 25);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 63, 26);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 64, 26);
                    Console.Write(" ");
                }
                if (i <= 29)
                {
                    Console.SetCursorPosition(i + 64, 16);
                    Console.Write("┐");
                    Console.SetCursorPosition(i + 65, 16);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 64, 17);
                    Console.Write("┘");
                    Console.SetCursorPosition(i + 65, 17);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 64, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 65, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 64, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 65, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 64, 25);
                    Console.Write("┐");
                    Console.SetCursorPosition(i + 65, 25);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 64, 26);
                    Console.Write("┘");
                    Console.SetCursorPosition(i + 65, 26);
                    Console.Write(" ");
                }
                if (i <= 28)
                {
                    Console.SetCursorPosition(i + 65, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 66, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 65, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 66, 22);
                    Console.Write(" ");
                }
                if (i <= 27)
                {
                    Console.SetCursorPosition(i + 66, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 67, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 66, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 67, 22);
                    Console.Write(" ");
                }
                if (i <= 26)
                {
                    Console.SetCursorPosition(i + 67, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 68, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 67, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 68, 22);
                    Console.Write(" ");
                }
                if (i <= 25)
                {
                    Console.SetCursorPosition(i + 68, 20);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 69, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 68, 22);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 69, 22);
                    Console.Write(" ");
                }
                if (i <= 24)
                {
                    Console.SetCursorPosition(i + 69, 19);
                    Console.Write("┌");
                    Console.SetCursorPosition(i + 70, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 69, 20);
                    Console.Write("┤");
                    Console.SetCursorPosition(i + 70, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 69, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 70, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 69, 22);
                    Console.Write("┤");
                    Console.SetCursorPosition(i + 70, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 69, 23);
                    Console.Write("└");
                    Console.SetCursorPosition(i + 70, 23);
                    Console.Write(" ");
                }
                if (i <= 23)
                {
                    Console.SetCursorPosition(i + 70, 19);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 71, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 70, 23);
                    Console.Write("─");
                    Console.SetCursorPosition(i + 71, 23);
                    Console.Write(" ");
                }
                if (i <= 22)
                {
                    Console.SetCursorPosition(i + 71, 19);
                    Console.Write("┐");
                    Console.SetCursorPosition(i + 72, 19);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 71, 20);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 72, 20);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 71, 21);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 72, 21);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 71, 22);
                    Console.Write("│");
                    Console.SetCursorPosition(i + 72, 22);
                    Console.Write(" ");
                    Console.SetCursorPosition(i + 71, 23);
                    Console.Write("┘");
                    Console.SetCursorPosition(i + 72, 23);
                    Console.Write(" ");
                }
            }
        }

        public void ReligionDeath()
        {
            int number = random.Next(0, 7);

            switch (number)
            {
                case 0:
                    ambassador.AmbassadorLogo();
                    break;
                case 1:
                    executor.ExecutorLogo();
                    break;
                case 2:
                    farmer.FarmerLogo();
                    break;
                case 3:
                    general.GeneralLogo();
                    break;
                case 4:
                    lover.LoverLogo();
                    break;
                case 5:
                    permanent.PermanentLogo();
                    break;
                case 6:
                    priests.PriestsLogo();
                    break;
            }

            if (quarter == 0)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("   교회의 권위가 약화되어 더 이상   ");
                Console.SetCursorPosition(30, 8);
                Console.Write("   백성의 폭동을 막을 수 없습니다.  ");
                Console.SetCursorPosition(30, 9);
                Console.Write("        폐하도 도망치십시오         ");
            }
            else if (quarter == 1)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("교황군이 우리 거룩한 국가를");
                Console.SetCursorPosition(30, 8);
                Console.Write("통치하고 있다.");
                Console.SetCursorPosition(30, 9);
                Console.Write("바로 지상의 낙원이야!");
            }

            int MOVE_POS = 31;

            while (true)
            {
                keys = Console.ReadKey(true);

                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                {
                    if (MOVE_POS == 31 || MOVE_POS == 41)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoLeft(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoLeft(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoLeft(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoLeft(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoLeft(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoLeft(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoLeft(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 21)
                        {
                            Console.SetCursorPosition(22, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                {
                    if (MOVE_POS == 21 || MOVE_POS == 31)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoRight(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoRight(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoRight(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoRight(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoRight(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoRight(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoRight(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 41)
                        {
                            Console.SetCursorPosition(42, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if (ConsoleKey.Enter == keys.Key)
                {
                    if (MOVE_POS == 21)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }

                    else if (MOVE_POS == 41)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }
                }
            }
        }

        public void SentimentDeath()
        {
            int number = random.Next(0, 7);

            switch (number)
            {
                case 0:
                    ambassador.AmbassadorLogo();
                    break;
                case 1:
                    executor.ExecutorLogo();
                    break;
                case 2:
                    farmer.FarmerLogo();
                    break;
                case 3:
                    general.GeneralLogo();
                    break;
                case 4:
                    lover.LoverLogo();
                    break;
                case 5:
                    permanent.PermanentLogo();
                    break;
                case 6:
                    priests.PriestsLogo();
                    break;
            }

            if (quarter == 0)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("       굶주린 백성들이 폭동을       ");
                Console.SetCursorPosition(30, 8);
                Console.Write("         일으켰습니다. 이제         ");
                Console.SetCursorPosition(30, 9);
                Console.Write("         걷잡을 수 없습니다         ");
            }
            else if (quarter == 1)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("    도시에서 대규모 폭동이 일어나   ");
                Console.SetCursorPosition(30, 8);
                Console.Write("       폭도들이 성문을 부수려       ");
                Console.SetCursorPosition(30, 9);
                Console.Write("           하고있습니다!            ");
            }

            int MOVE_POS = 31;

            while (true)
            {
                keys = Console.ReadKey(true);

                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                {
                    if (MOVE_POS == 31 || MOVE_POS == 41)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoLeft(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoLeft(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoLeft(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoLeft(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoLeft(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoLeft(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoLeft(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 21)
                        {
                            Console.SetCursorPosition(22, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                {
                    if (MOVE_POS == 21 || MOVE_POS == 31)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoRight(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoRight(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoRight(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoRight(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoRight(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoRight(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoRight(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 41)
                        {
                            Console.SetCursorPosition(42, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if (ConsoleKey.Enter == keys.Key)
                {
                    if (MOVE_POS == 21)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }

                    else if (MOVE_POS == 41)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }
                }
            }
        }

        public void MilitaryDeath()
        {
            int number = random.Next(0, 7);

            switch (number)
            {
                case 0:
                    ambassador.AmbassadorLogo();
                    break;
                case 1:
                    executor.ExecutorLogo();
                    break;
                case 2:
                    farmer.FarmerLogo();
                    break;
                case 3:
                    general.GeneralLogo();
                    break;
                case 4:
                    lover.LoverLogo();
                    break;
                case 5:
                    permanent.PermanentLogo();
                    break;
                case 6:
                    priests.PriestsLogo();
                    break;
            }

            if (quarter == 0)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("     침략군이 성문까지 다가오고     ");
                Console.SetCursorPosition(30, 8);
                Console.Write("     있습니다! 우리군은 더 이상     ");
                Console.SetCursorPosition(30, 9);
                Console.Write("       물리칠 힘이 없습니다.        ");
            }
            else if (quarter == 1)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("       쿠데타가 일어났습니다        ");
                Console.SetCursorPosition(30, 8);
                Console.Write("      폐하 어서 도망가시지요!       ");
                Console.SetCursorPosition(30, 9);
                Console.Write("                                    ");
            }

            int MOVE_POS = 31;

            while (true)
            {
                keys = Console.ReadKey(true);

                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                {
                    if (MOVE_POS == 31 || MOVE_POS == 41)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoLeft(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoLeft(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoLeft(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoLeft(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoLeft(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoLeft(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoLeft(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 21)
                        {
                            Console.SetCursorPosition(22, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                {
                    if (MOVE_POS == 21 || MOVE_POS == 31)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoRight(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoRight(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoRight(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoRight(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoRight(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoRight(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoRight(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 41)
                        {
                            Console.SetCursorPosition(42, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if (ConsoleKey.Enter == keys.Key)
                {
                    if (MOVE_POS == 21)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }

                    else if (MOVE_POS == 41)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }
                }
            }
        }

        public void MoneyDeath()
        {
            int number = random.Next(0, 7);

            switch (number)
            {
                case 0:
                    ambassador.AmbassadorLogo();
                    break;
                case 1:
                    executor.ExecutorLogo();
                    break;
                case 2:
                    farmer.FarmerLogo();
                    break;
                case 3:
                    general.GeneralLogo();
                    break;
                case 4:
                    lover.LoverLogo();
                    break;
                case 5:
                    permanent.PermanentLogo();
                    break;
                case 6:
                    priests.PriestsLogo();
                    break;
            }

            if (quarter == 0)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("       나라가 완전히 망했습니다.    ");
                Console.SetCursorPosition(30, 8);
                Console.Write("   상인과 제후가 지배하고 있습니다  ");
                Console.SetCursorPosition(30, 9);
                Console.Write("                                    ");
            }
            else if (quarter == 1)
            {
                Console.SetCursorPosition(30, 7);
                Console.Write("    이 나라는 정말로 부유하군요!    ");
                Console.SetCursorPosition(30, 8);
                Console.Write("       무위도식 잔치를 여는건       ");
                Console.SetCursorPosition(30, 9);
                Console.Write("             어떤지요?              ");
            }

            int MOVE_POS = 31;

            while (true)
            {
                keys = Console.ReadKey(true);

                if ('a' == keys.KeyChar || keys.KeyChar == 'A')
                {
                    if (MOVE_POS == 31 || MOVE_POS == 41)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoLeft(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoLeft(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoLeft(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoLeft(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoLeft(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoLeft(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoLeft(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 21)
                        {
                            Console.SetCursorPosition(22, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if ('d' == keys.KeyChar || keys.KeyChar == 'D')
                {
                    if (MOVE_POS == 21 || MOVE_POS == 31)
                    {
                        switch (number)
                        {
                            case 0:
                                ambassador.AmbassadorLogoRight(ref MOVE_POS);
                                break;
                            case 1:
                                executor.ExecutorLogoRight(ref MOVE_POS);
                                break;
                            case 2:
                                farmer.FarmerLogoRight(ref MOVE_POS);
                                break;
                            case 3:
                                general.GeneralLogoRight(ref MOVE_POS);
                                break;
                            case 4:
                                lover.LoverLogoRight(ref MOVE_POS);
                                break;
                            case 5:
                                permanent.PermanentLogoRight(ref MOVE_POS);
                                break;
                            case 6:
                                priests.PriestsLogoRight(ref MOVE_POS);
                                break;
                        }

                        if (MOVE_POS == 41)
                        {
                            Console.SetCursorPosition(42, 11);
                            Console.Write("뭐라고...!");
                        }
                    }
                }

                else if (ConsoleKey.Enter == keys.Key)
                {
                    if (MOVE_POS == 21)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }

                    else if (MOVE_POS == 41)
                    {
                        Bars();

                        RELIGION = 50;
                        SENTIMENT = 50;
                        MILITARY = 50;
                        MONEY = 50;

                        break;
                    }
                }
            }
        }

        public void Bars()
        {
            for (int i = 1; i < 28; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == i)
                    {
                        Console.SetCursorPosition((j * 5) + 2, i);
                        Console.Write("││");
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}