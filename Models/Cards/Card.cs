﻿using System;
using System.Text.Json.Serialization;

namespace SemesterProjekt1
{

    public abstract class Card : CardTypes
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public ElementType Element { get; set; }
        public CardType Type { get; set; }
        public Rarity RarityType { get; set; }
        public bool InDeck { get; set; }
        public int UserID { get; set; }


        public Card()
        {
            Name = string.Empty; // Initialisierung der nicht-nullbaren Eigenschaft
            Damage = 0;
            Element = ElementType.Normal;
            Type = CardType.Monster;
            RarityType = Rarity.Common;
            InDeck = false;
            UserID = 0;
        }

        [JsonConstructor]
        public Card(string name, int damage, ElementType element, CardType type, Rarity rarityType, bool inDeck, int userID)
        {
            this.Name = name;
            this.Damage = damage * (int)rarityType;
            this.Element = element;
            this.Type = type;
            this.RarityType = rarityType;
            this.UserID = userID;
            this.InDeck = inDeck;
        }



        public bool IsMonster()
        {
            return Type == CardType.Monster;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Damage: {Damage}, Element: {Element}, Type: {Type}, UserID: {UserID}";
        }
    }

    public class MonsterCard : Card
    {
        MonsterCard() { }

        [JsonConstructor]
        public MonsterCard(string name, int damage, ElementType element, Rarity rarityType, bool inDeck, int userID)
            : base(name, damage, element, CardType.Monster, rarityType, inDeck, userID)
        {
        }
    }

    public class SpellCard : Card
    {
        SpellCard() { }

        [JsonConstructor]
        public SpellCard(string name, int damage, ElementType element, Rarity rarityType, bool inDeck, int userID)
            : base(name, damage, element, CardType.Spell, rarityType, inDeck, userID)
        {
        }
    }

    

}