using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CH_Lab10;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Тесты для класса Trial
        public void PersonTest()
        {

            Trial p = new Trial("Денис", "Мельников", 0);
            //Trial p1 = new Trial();
            //Trial p2 = new Trial("Денис", "Мельников", 1);
            //Trial p3 = new Trial("А", "А", 2);
            //Trial p4 = new Trial("Б", "Б", 3);
            //Trial p_clone = (Trial)p.Clone();

            ////проверка соответствия типам данных
            Assert.IsInstanceOfType(p, typeof(Trial));
            //Assert.IsInstanceOfType(p1, typeof(Trial));
            //Assert.IsInstanceOfType(p.ToString(), typeof(string));
            //Assert.IsInstanceOfType(p.NoVirtualToString(), typeof(string));
            ////проверка правильности глубокого клонирования и сравнения объектов 
            //Assert.AreNotSame(p, p_clone);
            //Assert.AreEqual(p, p_clone);
            //Assert.IsTrue(p.Equals(p2));
            //Assert.IsFalse(p.Equals(p3));
            ////проверка реализации CompareTo
            //Assert.AreEqual(p3.CompareTo(p4), -1);
            //Assert.AreEqual(p4.CompareTo(p3), 1);
            //Assert.AreEqual(p.CompareTo(p2), 0);
        }
        //[TestMethod]
        ////Тесты для класса Employee
        //public void EmployeeTest()
        //{
        //    Employee em = new Employee();
        //    Employee em1 = new Employee("Денис", "Мельников", "Вячеславович", 1500, 15);
        //    Employee em_clone = (Employee)em.Clone();

        //    //проверка соответствия типам данных
        //    Assert.IsInstanceOfType(em, typeof(Person));
        //    Assert.IsInstanceOfType(em1, typeof(Person));
        //    Assert.IsInstanceOfType(em.ToString(), typeof(string));
        //    //проверка правильности глубокого клонирования
        //    Assert.AreNotSame(em, em_clone);
        //    Assert.AreEqual(em, em_clone);
        //}
        //[TestMethod]
        ////Тесты для класса Administrator
        //public void AdministratorTest()
        //{
        //    Administrator ad = new Administrator("Денис", "Мельников", "Вячеславович", 1500, 15, "Отдел продаж");
        //    Administrator ad1 = new Administrator();
        //    Administrator ad_clone = (Administrator)ad.Clone();
        //    //проверка соответствия типам данных
        //    Assert.IsInstanceOfType(ad, typeof(Person));
        //    Assert.IsInstanceOfType(ad1, typeof(Person));
        //    Assert.IsInstanceOfType(ad.ToString(), typeof(string));
        //    //проверка правильности глубокого клонирования
        //    Assert.AreNotSame(ad, ad_clone);
        //    Assert.AreEqual(ad, ad_clone);
        //}
        //[TestMethod]
        ////Тесты для класса Engineer
        //public void EngineerTest()
        //{
        //    Engineer eng = new Engineer("Денис", "Мельников", "Вячеславович", 1500, 15, "Отдел продаж");
        //    Engineer eng1 = new Engineer();
        //    Engineer eng_clone = (Engineer)eng.Clone();
        //    //проверка соответствия типам данных
        //    Assert.IsInstanceOfType(eng, typeof(Person));
        //    Assert.IsInstanceOfType(eng1, typeof(Person));
        //    Assert.IsInstanceOfType(eng.ToString(), typeof(string));
        //    //проверка правильности глубокого клонирования
        //    Assert.AreNotSame(eng, eng_clone);
        //    Assert.AreEqual(eng, eng_clone);
        //}
        //[TestMethod]
        ////Тесты для класса Company
        //public void CompanyTest()
        //{
        //    Company c = new Company();
        //    Company c_deep_clone = (Company)c.Clone();
        //    Company c_memberwise_clone = c.ShallowCopy();
        //    //првоерка соответсвия типам
        //    Assert.IsInstanceOfType(c.getAdminWithDepartment("Отдел продаж"), typeof(List<Person>));
        //    Assert.IsInstanceOfType(c.getEmpWithMoreThanYearsOfExp(5), typeof(List<Person>));
        //    Assert.IsInstanceOfType(c.getEngineerWithSpeciality("Инженер-технолог"), typeof(List<Person>));
        //    Assert.IsInstanceOfType(c.ToString(), typeof(string));
        //    //проверка правильности глубокого и поверхностного копирования
        //    Assert.AreNotSame(c, c_deep_clone);
        //    Assert.AreNotSame(c, c_memberwise_clone);
        //    Assert.AreNotSame(c.persons, c_deep_clone.persons);
        //    Assert.AreSame(c.persons, c_memberwise_clone.persons);
        //}
    }
}