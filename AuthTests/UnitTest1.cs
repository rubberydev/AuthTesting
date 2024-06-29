using AuthTesting;
namespace AuthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSuma()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double sumaResult = program.MakeOperation(AuthTesting.MathOperation.Suma, 5, 5);
            Assert.AreEqual(10, sumaResult);
            
        }
        [TestMethod]
        public void PruebaResta()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double restaResult = program.MakeOperation(AuthTesting.MathOperation.Resta, 5, 5);
            Assert.AreEqual(0, restaResult);

        }

        [TestMethod]
        public void PruebaMultiplicacion()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double multiplicacionResult = program.MakeOperation(AuthTesting.MathOperation.Multiplicacion, 4, 5);
            Assert.AreEqual(20, multiplicacionResult);

        }

        [TestMethod]
        public void PruebaDivisionExitosa()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double restaResult = program.MakeOperation(AuthTesting.MathOperation.Division, 12, 3);
            Assert.AreEqual(4, restaResult);

        }

        [TestMethod]
        public void PruebaDivisionfalla()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double result = program.MakeOperation(AuthTesting.MathOperation.Division, 5, 0);
            var any = result;

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PruebaDivisionCusaExcepcion()
        {
            AuthTesting.Program program = new AuthTesting.Program();
            double result = program.MakeOperation(AuthTesting.MathOperation.Division, 5, 0);
            var any = result;

        }
    }
}