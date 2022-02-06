using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace janono.ado.testcase.associate.unittests;
[TestClass]
[janono.ado.testcase.associate.Organization("janono-pub")]
public class UnitTest1
{
    [TestMethod]
    [janono.ado.testcase.associate.TestCase(5)]
    public void CheckIfClassMethodHaveAttribiutes()
    {
        var method = typeof(UnitTest1).GetMethods()
        .FirstOrDefault(x => x.Name == nameof(UnitTest1.CheckIfClassMethodHaveAttribiutes));
        var attribute = method?.GetCustomAttributes(typeof(janono.ado.testcase.associate.TestCaseAttribute), true)
            .FirstOrDefault() as janono.ado.testcase.associate.TestCaseAttribute;


        Assert.IsTrue(attribute?.testCaseId.ToString() == "5");
        Assert.IsTrue(attribute?.testCaseTitle == null);


        var dnAttribute = typeof(UnitTest1).GetCustomAttributes(typeof(janono.ado.testcase.associate.OrganizationAttribute), true)
        .FirstOrDefault() as janono.ado.testcase.associate.OrganizationAttribute;

        Assert.IsTrue(dnAttribute?.OrganizationName == "janono-pub");


    }
}
