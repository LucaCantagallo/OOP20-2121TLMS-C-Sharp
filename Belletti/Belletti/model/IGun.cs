using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
    interface IGun
    {
        void Shoot();

        void Reload();

        int GetDamage();

        double GetShotSpeed();

        int GetNAmmo();

        int GetMaxAmmo();

        void SetNAmmo(int nAmmo);

        bool IsSameTypeAs(IGun otherGun);
    }
}
