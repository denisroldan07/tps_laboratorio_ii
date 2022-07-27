using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    [TestClass]
    public class AvionTest
    {
        [TestMethod]
        public void ChequearPasajeroRepetido_CuandoElPasajeroExiste_DeberiaRetornarTrue()
        {

            //Arrange - preparar el caso de prueba
            List<Avion> lista = HardcodearAviones();
            Pasajero prueba = new Pasajero("prueba", "unitaria", 37089123, 2);
            bool resultadoEsperado = true;

            //Act - Invocar el método a probar
            bool resultado = Avion.ChequearPasajeroRepetido(lista,prueba);

            //Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(resultadoEsperado, resultado);

        }
        [TestMethod]
        public void ChequearPasajeroRepetido_CuandoElPasajeroNoExiste_DeberiaRetornarFalse()
        {
            List<Avion> lista = HardcodearAviones();
            Pasajero prueba = new Pasajero("prueba", "unitaria", 37797877, 2);
            bool resultadoEsperado = false;

            //Act - Invocar el método a probar
            bool resultado = Avion.ChequearPasajeroRepetido(lista, prueba);

            //Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ObtenerPasajeros_CuandoElIdEsDistinto_DeberiaRetornarFalse()
        {
            List<Pasajero> listaP = new List<Pasajero>();
            List<Avion> lista = HardcodearAviones();
            bool resultadoEsperado = false;

            bool resultado = Avion.ObtenerPasajeros(3, lista[1],out _);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ObtenerPasajeros_CuandoElIdEsIgual_DeberiaRetornarTrue()
        {
            List<Pasajero> listaP = new List<Pasajero>();
            List<Avion> lista = HardcodearAviones();
            bool resultadoEsperado = true;

            bool resultado = Avion.ObtenerPasajeros(2, lista[1], out _);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        private List<Avion> HardcodearAviones()
        {
            List<Avion> listaAviones = new List<Avion>();

            //Avion 1:
            Pasajero z1 = new Pasajero(nombre: "Denis", apellido: "Roldan", dni: 38797877, idAsiento: 1);
            Pasajero z2 = new Pasajero(nombre: "Viewsonic", apellido: "Monitor", dni: 38787477, idAsiento: 2);
           
            Dictionary<int, Pasajero> p1 = new Dictionary<int, Pasajero>();
            p1.Add(1, z1);
            p1.Add(2, z2);
            p1.Add(3, null);
            p1.Add(4, null);

            //Avion 2:
            Pasajero z3 = new Pasajero(nombre: "Samsung", apellido: "SyncMaster", dni: 38980765, idAsiento: 3);
            Pasajero z4 = new Pasajero(nombre: "Michel", apellido: "Roldan", dni: 37089123, idAsiento: 4);
            Dictionary<int, Pasajero> p2 = new Dictionary<int, Pasajero>();
            p2.Add(1, z3);
            p2.Add(2, z4);
            p2.Add(3, null);
            p2.Add(4, null);

            Avion a1 = new Avion(1, p1, Avion.EDestino.Cordoba);
            Avion a2 = new Avion(2,p2,Avion.EDestino.Aeroparque);

            listaAviones.Add(a1);
            listaAviones.Add(a2);

            return listaAviones;
        }

    }
}
 