using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class AvionTest

    {
        [TestMethod]
        public void BuscarAsiento_CuandoNoExisteElVuelo_DeberiaRetornarIsFalse()
        {
            //Arrange

            Dictionary<int, Pasajero> pas = new Dictionary<int, Pasajero>();
            Avion avion = new Avion(1,pas, Avion.EDestino.Cordoba);

            //ACT
           bool condition =  Avion.BuscarAsiento(2, 1, avion);

            //Assert

            Assert.IsFalse(condition);

        }

        [TestMethod]
        public void BuscarVuelo_CuandoNoExisteElVuelo_DeberiaRetornarIsFalse()
        {
            //Arrange

            Dictionary<int, Pasajero> dict = new Dictionary<int, Pasajero>
            {
            { 1, new Pasajero("Denis","Roldan",38797877) },
            { 2, new Pasajero("Maxi","Neiner",37797877)}
            };

            Avion avion = new Avion(2, dict, Avion.EDestino.Cordoba);

            //ACT
            bool condition = Avion.BuscarPasajeroEnAvion(38797877, 2, avion, out _);


            //Assert

            Assert.IsTrue(condition);

        }
    }
}
