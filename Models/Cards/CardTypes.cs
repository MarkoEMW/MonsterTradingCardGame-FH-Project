﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt1
{
    public abstract class CardTypes
    {

        public enum ElementType
        {
            Water,
            Fire,
            Normal
        }

        public enum CardType
        {
            Monster,
            Spell
        }

        public enum Rarity
        {
            Common = 1,
            Rare = 2,
            Epic = 3,
            Legendary = 4,
            God = 5
        }

        public static string[] MonsterNames = { "Goblin", "Orc", "Dragon", "Knight", "Elf", "Dwarf", "Giant", "Kraken", "Wizard", "FireElf" };
        public static string[] SpellNames = { "Fireball", "Heal", "Lightning", "WaterBall" };


    }


    public enum ElementType
    {
        Water,
        Fire,
        Normal
    }

    public enum CardType
    {
        Monster,
        Spell
    }

    public enum Rarity
    {
        Common = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,
        God = 5
    }
}










