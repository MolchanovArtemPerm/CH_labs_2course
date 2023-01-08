namespace CH_Lab9.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TypeTest()
        {
            Time t = new Time();
            Time t1 = new Time(20, 30);
            TimeArray t2 = new TimeArray();
            Assert.IsInstanceOfType(t, typeof(Time));
            Assert.IsInstanceOfType(t1, typeof(Time));
            Assert.IsInstanceOfType(t2, typeof(TimeArray));
        }
        [TestMethod]
        // Тест явного преобразования к типу Bool
        public void ExplBoolTest()
        {
            Time t = new Time(0,0);
            Time t1 = new Time(20, 30);
            bool f = (bool)t;
            Assert.IsFalse(f);
            f = (bool)t1; 
            Assert.IsTrue(f);
        }
        [TestMethod]
        // Тест не явного преобразования к типу int
        public void ExplIntTest()
        {
            Time t = new Time(20, 30);
            int all = t;
            Assert.IsInstanceOfType(all, typeof(int));
        }
        // Тест операций сравнения
        [TestMethod]
        public void ComparsionTest()
        {
            Time t1 = new Time(20, 30);
            Time t2 = new Time(20, 31);
            Time t3 = new Time(20, 30);
            Assert.IsTrue(t2 > t1);
            Assert.IsFalse(t1 > t2);
            Assert.IsFalse(t2 < t1);
            Assert.IsTrue(t1 < t2);

            Assert.IsFalse(t3 > t1);
            Assert.IsFalse(t3 < t1);
        }
        //тест свойства
        [TestMethod]
        public void SubscrationTest()
        {
            Time t = new Time();
            Time t1 = new Time();
            t.Add(21, 00);
            t1.Add(19, 59);
            t.Subtraction(t1);
            Assert.AreEqual(t.Hours, 1);
            Assert.AreEqual(t.Minutes, 1);
        }
        [TestMethod]
        // Тест инкремента и декремента
        public void IncrementTest()
        {
            Time t1 = new Time(20, 59);

            t1++;

            Assert.AreEqual(t1.Hours, 21);
            Assert.AreEqual(t1.Minutes, 0);

            t1--;

            Assert.AreEqual(t1.Hours, 20);
            Assert.AreEqual(t1.Minutes, 59);
        }
        /*[TestMethod]
        public void ArrTest()
        {
            TimeArray t = new TimeArray(2);
            TimeArray t1 = new TimeArray(2);
            TimeArray t2 = t;

            Assert.AreEqual(t2.Lenght, t1.Lenght);
        }*/
    }
}
