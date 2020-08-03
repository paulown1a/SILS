using Microsoft.VisualStudio.TestTools.UnitTesting;
using SILS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data.Tests
{
    [TestClass()]
    public class CodeDataTests
    {
        [TestMethod()]
        public void GetByNameAndUpperTest()
        {
            Code code1 = DataRepository.Code.GetByNameAndUpper("서울");
            Assert.AreEqual(code1.CodeId,"L100");

            Code code2 = DataRepository.Code.GetByNameAndUpper("강남구", code1.CodeId);
            Assert.AreEqual(code2.CodeId,"L101");
        }
    }
}