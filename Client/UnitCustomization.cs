using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public enum ArmorType
    {
        [Defence(75, 15, 3)] Heavy,
        [Defence(60, 25, 2)] Medium,
        [Defence(30, 60, 1)] Light
    }

    public enum Weapons
    {
        #region MeleeWeapons
        [MeleeWeapon(75,75,2f,5,3,10,5,2,1.15f,1)] Sword=0,
        [MeleeWeapon(65,75,1.8f,7,2,5,10,1.5f,1,1.25f)] Spear,
        [MeleeWeapon(85,100,3f,5,4,0,2,3,1,1)] Mace,
        #endregion
        #region RangedWeapons
        [RangedWeapon(45,75,3,120,3,70)] Shortbow=10,
        [RangedWeapon(55,75,4,150,4,80)] Longbow,
        [RangedWeapon(65,100,4,80,3,80)] Crossbow,
        #endregion
    }
    public enum Artillery
    {
        [Artillery(150, 4, 250, 15)] Catapult,
        [Artillery(180, 6, 300, 20)] Trebuchet,
        [Artillery(250, 2, 400, 15)] Cannon
    }




    public class ArtilleryAttribute: Attribute
    {
        public byte damage;
        public byte spread;
        public int range;
        public float attackSpeed;
        public ArtilleryAttribute(byte Damage,byte Spread, int Range, float AttackSpeed)
        {
            damage = Damage;
            spread = Spread;
            range = Range;
            attackSpeed = AttackSpeed;
        }

    }

    public class DefenceAttribute : Attribute
    {
        public byte armor;
        public byte dodgeChance;
        public byte staminaCost;
        public DefenceAttribute(byte ArmorRating, byte DodgeChance, byte StaminaCost)
        {
            armor = ArmorRating;
            dodgeChance = DodgeChance;
            staminaCost = StaminaCost;
        }
    }
    public class RangedWeaponAttribute: WeaponAttribute
    {
        public byte accuracy; //chance of hitting a shot
        public RangedWeaponAttribute(byte Damage, byte ArmorEffectivness, float AttackSpeed, int Range, byte StaminaCost,byte Accuracy) : base(Damage, ArmorEffectivness, AttackSpeed, Range, StaminaCost)
        {
            accuracy = Accuracy;
        }
    }

    public class MeleeWeaponAttribute : WeaponAttribute
    {
        public byte dexterity;  //counter to dodge chance
        public byte criticalChance; 
        public float criticalMultiplier;
        public float infantryMultiplier;
        public float largeMultiplyer;
        public MeleeWeaponAttribute(byte Damage,  byte ArmorEffectivness, float AttackSpeed, int Range, byte StaminaCost, byte Dexterity, byte CriticalChance,float CriticalMultiplyer,float InfantryMultiplyer, float LargeMultiplier) :base(Damage,ArmorEffectivness,AttackSpeed,Range,StaminaCost)
        {
            dexterity = Dexterity;

            criticalChance = CriticalChance;
            criticalMultiplier = CriticalMultiplyer;
            infantryMultiplier = InfantryMultiplyer;
            largeMultiplyer = LargeMultiplier;
        }
    }
    public class WeaponAttribute : Attribute
    {
        public byte damage;
        public byte armorEffectivness;
        public float attackSpeed;
        public int range;
        public byte staminaCost;

        public WeaponAttribute(byte Damage,byte ArmorEffectivness,float AttackSpeed,int Range, byte StaminaCost)
        {
            damage = Damage;
            armorEffectivness = ArmorEffectivness;
            attackSpeed = AttackSpeed;
            range = Range;
            staminaCost = StaminaCost;
        }
    }
}
