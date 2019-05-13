using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class EnumExtention
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name)
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }
    }
    public class BaseAttribute:Attribute
    {
        public int maxHealth;
        public float moveSpeed;
        public byte size;
        public int maxStamina;
        public BaseAttribute(int maxHP, float moveSpeed, byte size, int maxSTA)
        {
            maxHealth = maxHP;
            this.moveSpeed = moveSpeed;
            this.size = size;
            maxStamina = maxSTA;
        }
    }
    public enum UnitType
    {
        [Base(500,5f,6,200)]    Lord,
        [Base(250,6f,5,150)]    Infantry,
        [Base(150,6f,5,150)]    Ranged,
        [Base(400,10f,8,250)]   Cavalry,
        [Base(300,3f,8,150)]    Artillery,
        [Base(750,13f,10,300)]  Dragon,
        [Base(1000,6f,7,300)]   Giant,
    }
    class Unit
    {

    }
}
