using System;
using System.Collections.Generic;
using System.Text;

namespace Belletti
{
    interface IGun
    {
        /// <summary>
        /// defines guns behavior when asked to shoot.
        /// </summary>
        void Shoot();
        /// <summary>
        /// refills ammo, setting them back to the max capacity.
        /// </summary>
        void Reload();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>shot damage value.</returns>
        int GetDamage();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>shot speed value.</returns>
        double GetShotSpeed();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>current ammunition number</returns>
        int GetNAmmo();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>max ammunition capacity</returns>
        int GetMaxAmmo();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nAmmo">sets current ammunition number</param>
        void SetNAmmo(int nAmmo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="otherGun"></param>
        /// <returns>true if the guns are of the same type</returns>
        bool IsSameTypeAs(IGun otherGun);
    }
}
