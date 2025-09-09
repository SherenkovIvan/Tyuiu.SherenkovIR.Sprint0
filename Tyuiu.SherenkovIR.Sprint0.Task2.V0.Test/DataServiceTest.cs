
using Tyuiu.SherenkoIR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SherenkovIR.Sprint0.Task2.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Иван";
            var res = DataService.GetMessege(name);
            Assert.AreEqual("Привет..., Иван", res);
        }
    }
}
