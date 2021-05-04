using System;
namespace Di_Zio
{
    public interface IEnemy
    {
        public String GetMovementStrategy();
        public Guid Guid { get; }
        public int Life { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }
        public TypeOfMovement TypeOfMovement { get; }
    }
}
