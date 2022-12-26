using System;

namespace CH_Lab10.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // �������� ������ ���������
        public void TestTrial()
        {
            Trial p = new Trial();
            Trial p1 = new Trial("��������","�����",5);
            Trial p2 = new Trial("�", "�", 2);
            Trial p3 = new Trial("�", "�", 3);
            Trial p4 = new Trial("�", "�", 4);
            Trial p5 = new Trial("��������", "�����", 5);
            Trial p_clone = (Trial)p.Clone();

            // �������� ������������ ����� ������
            Assert.IsInstanceOfType(p, typeof(Trial));
            Assert.IsInstanceOfType(p1, typeof(Trial));
            Assert.IsInstanceOfType(p2, typeof(Trial));
            Assert.IsInstanceOfType(p3, typeof(Trial));
            Assert.IsInstanceOfType(p4, typeof(Trial));
            Assert.IsInstanceOfType(p5, typeof(Trial));
            Assert.IsInstanceOfType(p.ToString(), typeof(string));
            Assert.IsInstanceOfType(p.NoVirtualToString(), typeof(string));

            // �������� ������������ ��������� ������������
            Assert.AreNotSame(p, p_clone);
            Assert.AreEqual(p, p_clone);

            // ��������� �������� 
            Assert.IsTrue(p1.Equals(p5));
            Assert.IsFalse(p.Equals(p2));

            // �������� ���������� CompareTo
            Assert.AreEqual(p1.CompareTo(p2), 1);
            Assert.AreEqual(p2.CompareTo(p1), -1);
            Assert.AreEqual(p1.CompareTo(p5), 0); 
        }
        [TestMethod]
        // �������� ������ ����
        public void TestTest()
        {
            Test t = new Test();
            Test t1 = new Test("��������", "�����", 5, "������");
            Test t_clone = (Test)t.Clone();

            // �������� ������������ ����� ������
            Assert.IsInstanceOfType(t, typeof(Trial));
            Assert.IsInstanceOfType(t1, typeof(Trial));
            Assert.IsInstanceOfType(t.ToString(), typeof(string));

            // �������� ������������ ��������� ������������
            Assert.AreNotSame(t, t_clone);
            Assert.AreEqual(t, t_clone);
        }
        [TestMethod]
        // �������� ������ �������
        public void TestExam()
        {
            Exam e = new Exam();
            Exam e1 = new Exam("��������", "�����", 5, "������", 3);
            Exam e_clone = (Exam)e.Clone();

            // �������� ������������ ����� ������
            Assert.IsInstanceOfType(e, typeof(Trial));
            Assert.IsInstanceOfType(e1, typeof(Trial));
            Assert.IsInstanceOfType(e.ToString(), typeof(string));

            // �������� ������������ ��������� ������������
            Assert.AreNotSame(e, e_clone);
            Assert.AreEqual(e, e_clone);
        }
        [TestMethod]
        // �������� ������ ��������������� ����
        public void TestExamOut()
        {
            ExamOut eo = new ExamOut();
            ExamOut eo1 = new ExamOut("��������", "�����", 5, "������", 3 , 2001);
            ExamOut eo_clone = (ExamOut)eo.Clone();

            // �������� ������������ ����� ������
            Assert.IsInstanceOfType(eo, typeof(Trial));
            Assert.IsInstanceOfType(eo1, typeof(Trial));
            Assert.IsInstanceOfType(eo.ToString(), typeof(string));

            // �������� ������������ ��������� ������������
            Assert.AreNotSame(eo, eo_clone);
            Assert.AreEqual(eo, eo_clone);
        }
        [TestMethod]
        // �������� ������ �����
        public void TestSchool()
        {
            School s = new School();
            School s_deep_clone = ((School)s.Clone());
            School s_shallow_clone = (School)s.ShallowCopy();

            // �������� ������������ �����
            Assert.IsInstanceOfType(s.getTeenagersA(), typeof(List<Trial>));
            Assert.IsInstanceOfType(s.getTeenagersBad(), typeof(List<Trial>));
            Assert.IsInstanceOfType(s.getTeenagersAandB("������"), typeof(List<Trial>));
            Assert.IsInstanceOfType(s.ToString(), typeof(string));

            // �������� ������������ ��������� ������������ � �������������� �����������
            Assert.AreNotSame(s, s_deep_clone);
            Assert.AreNotSame(s, s_shallow_clone);
            Assert.AreNotSame(s.trials, s_deep_clone.trials);
            Assert.AreSame(s.trials, s_shallow_clone.trials);
        }
    }
}