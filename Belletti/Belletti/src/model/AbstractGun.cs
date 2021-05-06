using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
    abstract class AbstractGun : IGun
    {
        private readonly int shotDMG;
        private readonly int maxAmmo;
        private readonly double shotSpeed;
        private int nAmmo;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shotDMG"></param>
        /// <param name="maxAmmo"></param>
        /// <param name="shotSpeed"></param>
        public AbstractGun(int shotDMG, int maxAmmo, double shotSpeed)
        {
            this.shotDMG = shotDMG;
            this.maxAmmo = maxAmmo;
            this.nAmmo = maxAmmo;
            this.shotSpeed = shotSpeed;
        }

        public abstract void Shoot();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetDamage()
        {
            return shotDMG;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetNAmmo()
        {
            return nAmmo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetShotSpeed() => shotSpeed;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="otherGun"></param>
        /// <returns></returns>
        public bool IsSameTypeAs(IGun otherGun) => shotDMG == otherGun.GetDamage()
        && shotSpeed == otherGun.GetShotSpeed()
        && maxAmmo == otherGun.GetMaxAmmo();
        /// <summary>
        /// 
        /// </summary>
        public void Reload() => nAmmo = maxAmmo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nAmmo"></param>
        public void SetNAmmo(int nAmmo)
        {
            this.nAmmo = nAmmo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetMaxAmmo()
        {
            return maxAmmo;
        }

    }
}
