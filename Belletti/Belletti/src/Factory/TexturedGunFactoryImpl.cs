using Belletti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belletti.src.Factory
{
	/**
	* Implements GunFactory, therefore implementing methods to create instances of game guns,
	* with preset values.
	*/
	class TexturedGunFactoryImpl : ITexturedGunFactory
	{
		//Beretta92 preset specifications
		private const int BRT_DMG = 3;
		private const int BRT_MAXAMMO = 10;
		private const double BRT_SHOT_SPEED = 750;
		private const string BRT_GUN_IMG_PATH = "assets/textures/beretta92Gun.png";
		private const string BRT_SHOT_IMG_PATH = "assets/textures/beretta92Shot.png";
		//Magmagun preset specifications
		private const int MGM_DMG = 100;
		private const int MGM_MAXAMMO = 7;
		private const double MGM_SHOT_SPEED = 650;
		private const string MGM_GUN_IMG_PATH = "assets/textures/magmaGun.png";
		private const string MGM_SHOT_IMG_PATH = "assets/textures/magmaGunShot.png";
		/**
		* MagmGun duration time as a "power up".
		*/
		public readonly double MAGMA_GUN_DURATION = 7;
		//MachineGun preset specifications
		private static readonly int MCH_DMG = 5;
		//MachineGun ammo won't be decremented in the shoot() method: unlimited shots
		private const int MCH_MAXAMMO = 1;
		private const double MCH_SHOT_SPEED = 900;
		private const string MCH_GUN_IMG_PATH = "assets/textures/machineGun.png";
		private const string MCH_SHOT_IMG_PATH = "assets/textures/machineGunShot.png";
		/**
		* MachineGun duration time as a "power up".
		*/
		public readonly double MACHINE_GUN_DURATION = 5;

		/// <summary>
		/// 
		/// </summary>
		/// <returns>a specific gun type: Beretta92</returns>
		private TexturedGunLimited CreateBeretta92()
		{
			var texturePaths = new Dictionary<TLMSType, String>();
			texturePaths.Add(TLMSType.GUN, BRT_GUN_IMG_PATH);
			texturePaths.Add(TLMSType.SHOT, BRT_SHOT_IMG_PATH);
			return new TexturedGunLimited(BRT_DMG, BRT_MAXAMMO, BRT_SHOT_SPEED, texturePaths);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>a specific gun type: MagmaGun</returns>
		private TexturedGunLimited CreateMagmaGun()
		{
			var texturePaths = new Dictionary<TLMSType, String>();
			texturePaths.Add(TLMSType.GUN, MGM_GUN_IMG_PATH);
			texturePaths.Add(TLMSType.SHOT, MGM_SHOT_IMG_PATH);
			return new TexturedGunLimited(MGM_DMG, MGM_MAXAMMO, MGM_SHOT_SPEED, texturePaths);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>a specific gun type: MachineGun</returns>
		private TexturedGunUnlimited CreateMachineGun()
		{
			var texturePaths = new Dictionary<TLMSType, String>();
			texturePaths.Add(TLMSType.GUN, MCH_GUN_IMG_PATH);
			texturePaths.Add(TLMSType.SHOT, MCH_SHOT_IMG_PATH);
			return new TexturedGunUnlimited(MCH_DMG, MCH_MAXAMMO, MCH_SHOT_SPEED, texturePaths);
		}

		public TexturedGun GetTexturedGun(TLMSType type)
		{
			if (type.Equals(TLMSType.MACHINEGUN))
			{
				return CreateMachineGun();
			}
			else if (type.Equals(TLMSType.MAGMAGUN))
			{
				return CreateMagmaGun();
			}
			else if (type.Equals(TLMSType.BERETTA92))
			{
				return CreateBeretta92();
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}