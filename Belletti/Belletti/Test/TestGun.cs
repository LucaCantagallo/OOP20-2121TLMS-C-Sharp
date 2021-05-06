using Belletti;
using Belletti.src.Factory;
using System;
using Xunit;
namespace test
{
    public class TestGun
    {
        private static TexturedGunFactoryImpl texturedGunFactory = new TexturedGunFactoryImpl();
        private TexturedGun beretta92 = texturedGunFactory.GetTexturedGun(TLMSType.BERETTA92);
	    private TexturedGun machineGun = texturedGunFactory.GetTexturedGun(TLMSType.MACHINEGUN);
	    private TexturedGun magmaGun = texturedGunFactory.GetTexturedGun(TLMSType.MAGMAGUN);

		/// <summary>
		/// tests Gun types, initially created from factory
		/// </summary>
		[Fact]
		public void gunTypesTest()
		{

			Assert.Equal(10, beretta92.GetMaxAmmo());
			Assert.Equal(7, magmaGun.GetNAmmo());
			for (int i = 0; i < 80; i++)
			{
				machineGun.Shoot();
				Assert.True(machineGun.GetNAmmo() > 0);
			}

			try
			{
				for (int i = 1; i <= beretta92.GetMaxAmmo(); i++)
				{
					beretta92.Shoot();
					Assert.Equal(beretta92.GetMaxAmmo() - i, beretta92.GetNAmmo());
				}
			}
			catch (ArgumentException exception) {
				Console.WriteLine(exception.Message);
			}

			try
			{
				for (int i = 1; i <= magmaGun.GetMaxAmmo(); i++)
				{
					magmaGun.Shoot();
					Assert.Equal(magmaGun.GetMaxAmmo() - i, magmaGun.GetNAmmo());
				}
			}
			catch (ArgumentException exception){
				Console.WriteLine(exception.Message);
			}

			Assert.False(beretta92.IsSameTypeAs(machineGun));
			Assert.False(beretta92.IsSameTypeAs(magmaGun));
			Assert.False(magmaGun.IsSameTypeAs(machineGun));
		}

		/// <summary>
		/// tests reloading method
		/// </summary>
		[Fact]
		public void reloadTest()
        {
			magmaGun.Reload();
			Assert.Equal(magmaGun.GetNAmmo(), magmaGun.GetMaxAmmo());

			beretta92.Reload();
			Assert.Equal(beretta92.GetNAmmo(), beretta92.GetMaxAmmo());

			machineGun.Reload();
			Assert.Equal(machineGun.GetNAmmo(), machineGun.GetMaxAmmo());
		}
	}
}
