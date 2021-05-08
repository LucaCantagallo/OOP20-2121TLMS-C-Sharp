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

        public AbstractGun(int shotDMG, int maxAmmo, double shotSpeed)
        {
            this.shotDMG = shotDMG;
            this.maxAmmo = maxAmmo;
            this.nAmmo = maxAmmo;
            this.shotSpeed = shotSpeed;
        }

        public abstract void Shoot();

        public int GetDamage()
        {
            return shotDMG;
        }

        public int GetNAmmo()
        {
            return nAmmo;
        }

        public double GetShotSpeed() => shotSpeed;

        public bool IsSameTypeAs(IGun otherGun) => shotDMG == otherGun.GetDamage()
        && shotSpeed == otherGun.GetShotSpeed()
        && maxAmmo == otherGun.GetMaxAmmo();

        public void Reload() => nAmmo = maxAmmo;

        public void SetNAmmo(int nAmmo)
        {
            this.nAmmo = nAmmo;
        }

        public int GetMaxAmmo()
        {
            return maxAmmo;
        }

    }
}
