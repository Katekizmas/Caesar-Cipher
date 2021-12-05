using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;

namespace CaesarUnitTest
{
    [TestClass]
    public class CaesarTest
    {
        [TestMethod]
        public void TestEncrypt_Shift28()
        {
            //Arrange
            int poslinkis = 28;
            string numatytasAtkoduotas = "Testing 28?";
            string numatytasUzkoduotas = "Vguvkpi 28?";
            string gautasUzkoduotas, gautasAtkoduotas;

            //Act
            gautasUzkoduotas = Caesar.Sifravimas(numatytasAtkoduotas, poslinkis, false);

            //Assert
            Assert.AreEqual(gautasUzkoduotas, numatytasUzkoduotas);
        }

        [TestMethod]
        public void TestEncrypt_Shift13()
        {
            //Arrange
            int poslinkis = 13;
            string duotasTekstas = "Testing 13?";
            string numatytasUzkoduotas = "Grfgvat 13?";
            string gautasUzkoduotas;

            //Act
            gautasUzkoduotas = Caesar.Sifravimas(duotasTekstas, poslinkis, false);

            //Assert
            Assert.AreEqual(gautasUzkoduotas, numatytasUzkoduotas);
        }

        [TestMethod]
        public void TestDecrypt_Shift28()
        {
            //Arrange
            int poslinkis = 28;
            string duotasUzkoduotas = "Vguvkpi 28?";
            string numatytasAtkoduotas = "Testing 28?";
            string gautasAtkoduotas;

            //Act
            gautasAtkoduotas = Caesar.Sifravimas(duotasUzkoduotas, poslinkis, true);

            //Assert
            Assert.AreEqual(numatytasAtkoduotas, gautasAtkoduotas);
        }

        [TestMethod]
        public void TestDecrypt_Shift13()
        {
            //Arrange
            int poslinkis = 13;
            string duotasUzkoduotas = "Grfgvat 13?";
            string numatytasAtkoduotas = "Testing 13?";
            string gautasAtkoduotas;

            //Act
            gautasAtkoduotas = Caesar.Sifravimas(duotasUzkoduotas, poslinkis, true);

            //Assert
            Assert.AreEqual(numatytasAtkoduotas, gautasAtkoduotas);
        }
    }
}
