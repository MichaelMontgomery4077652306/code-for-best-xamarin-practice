using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TruliteMobile.Converters;
using TruliteMobile.Enums;
using TruliteMobile.Services;

namespace TrueliteMobileUnitTests
{
    /// <summary>
    /// Summary description for ConvertersUnitTest
    /// </summary>
    [TestClass]
    public class ConvertersUnitTest
    {
        public ConvertersUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InvoiceNumberListToStringConverterConversion()
        {
            var invoiceNumberListToStringConverter =  InvoiceNumberListToStringConverter.Instance;
            var input1 = ", 100, 101, 102, 103,";
            var output =
                invoiceNumberListToStringConverter.Convert(input1, typeof(string), null, CultureInfo.CurrentCulture);
            Assert.AreEqual("100, 101, 102, 103", output);

            var input2 = ", 100,";
            var output2 =
                invoiceNumberListToStringConverter.Convert(input2, typeof(string), null, CultureInfo.CurrentCulture);
            Assert.AreEqual("100", output2);
        }


        [TestMethod]
        public void IsEqualToBoolConverterConversion()
        {
            var equalToBoolConverter = IsEqualToBoolConverter.Instance;
            var input1 = "TestString";
            var output =
                equalToBoolConverter.Convert(input1, typeof(bool), input1, CultureInfo.CurrentCulture);
            Assert.IsTrue((bool) output);

            var output2 =
                equalToBoolConverter.Convert(input1, typeof(bool), null, CultureInfo.CurrentCulture);
            Assert.IsFalse((bool)output2);

            var output3 =
                equalToBoolConverter.Convert( LanguagesEnum.French, typeof(bool), LanguagesEnum.French, CultureInfo.CurrentCulture);
            Assert.IsTrue((bool)output);
        }

        [TestMethod]
        public void EnumToStringConverterConversion()
        {
            var enumToStringConverter = EnumToStringConverter.Instance;
            var output = enumToStringConverter.Convert(CountriesEnum.UK, null, "U.S.A;United Kingdom;Canada;Brazil",
                CultureInfo.CurrentCulture);
            Assert.AreEqual("United Kingdom", output);
        }

        public enum CountriesEnum
        {
            US,
            UK,
            CN,
            BR
        }

        [TestMethod]
        public void RowCountToStringConversion()
        {
            var enumToStringConverter = RowCountToStringConverter.Instance;
            var list1= new List<int>{ 1,2,3,4,5};
            var output = enumToStringConverter.Convert(list1, null,null, CultureInfo.CurrentCulture);
            Assert.AreEqual("5", output);

            var emptyList = new List<int> ();
            var emptyListOutput = enumToStringConverter.Convert(emptyList, null, null, CultureInfo.CurrentCulture);
            Assert.AreEqual("0", emptyListOutput);

            var nullOutput = enumToStringConverter.Convert(null, null, null, CultureInfo.CurrentCulture);
            Assert.AreEqual("", nullOutput);
        }

        [TestMethod]
        public void IsDocumentOfTypeConverterTest()
        {
            var documentOfTypeConverter = IsDocumentOfTypeConverter.Instance;
            var inputPdf = new DocumentUploadView
            {
                OriginalName = "file.pdf"
            };

            var output = documentOfTypeConverter.Convert(inputPdf, null, DocumentTypeEnum.PDF, CultureInfo.CurrentCulture);
            Assert.IsTrue((bool)output);
            var inputNotPdf = new DocumentUploadView
            {
                OriginalName = "file.doc"
            };

            var output2 = documentOfTypeConverter.Convert(inputNotPdf, null, DocumentTypeEnum.PDF, CultureInfo.CurrentCulture);
            Assert.IsFalse((bool)output2);
        }

        //[TestMethod]
        //public void SalesOrderStatusToStringConversionTest()
        //{
        //    var documentOfTypeConverter = SalesOrderStatusToString.Instance;
            
        //    var output = documentOfTypeConverter.Convert(SalesOrderStatus.BackOrder, null, null, CultureInfo.CurrentCulture);
        //    Assert.AreEqual("Back Order", output);
        //}
        ////SalesOrderStatusToString
    }
}
