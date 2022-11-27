using StrringFromatterTests.Classes;

namespace StrringFromatterTests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void FormatTest1()
        {
            var user = new User("��������","����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                "������, {FirstName} {LastName}!", user);

            Assert.AreEqual("������, �������� ����������!", result);
        }

        [TestMethod]
        public void FormatTest2()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "{{FirstName}} ������������� � {FirstName}", user);
           
            Assert.AreEqual("{FirstName} ������������� � ��������", result);
        }

        [TestMethod]
        public void FormatTest3()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "FirstName}} {{LastName", user);

            Assert.AreEqual("FirstName} {LastName", result);
        }

        [TestMethod]
        public void FormatTest4()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "{FirstName} {LastName} _id:{_id}", user);

            Assert.AreEqual("�������� ���������� _id:1", result);
        }

        [TestMethod]
        public void FormatTest5()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "{str1} = '{str2}'", user);

            Assert.AreEqual("str2 = 'str'", result);
        }

        [TestMethod]
        public void FormatTest6()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "{{date}} = '{date}'", user);

            Assert.AreEqual("{date} = '14.08.2022 0:00:00'", result);
        }

        [TestMethod]
        public void FormatTest7()
        {
            var user = new User("��������", "����������");
            string result;

            result = StringFormatter.StringFormatter.Shared.Format(
                  "{{date2}} = {date2}", user);

            Assert.AreEqual("{date2} = {date2}", result);
        }


    }
}