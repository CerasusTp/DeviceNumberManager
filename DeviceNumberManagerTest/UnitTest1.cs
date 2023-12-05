using DeviceNumberManager.Model;

namespace DeviceNumberManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcDegitTestMethod1()
        {
            int result = DeviceNumber.CalcDegit(20151119);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void CalcDegitTestMethod2()
        {
            int result = DeviceNumber.CalcDegit(20152119);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void DeviceNumberTestMethod()
        {
            int _main_num = 123456;
            DeviceNumber number = new DeviceNumber(_main_num);
            Assert.AreEqual(number.ManageNumber, $"N{_main_num}{DeviceNumber.CalcDegit(_main_num)}");
        }
    }
}