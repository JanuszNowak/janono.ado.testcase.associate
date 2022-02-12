using System;

namespace janono.ado.testcase.associate
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TestCaseAttribute : Attribute
    {
        public readonly int testCaseId;
        public readonly string testCaseTitle;

        public TestCaseAttribute(int TestCaseId)
        {
            this.testCaseId = TestCaseId;
        }

        public TestCaseAttribute(string TestCaseTitle)
        {
            this.testCaseTitle = TestCaseTitle;
        }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
    public class OrganizationAttribute : Attribute
    {
        public readonly string OrganizationName;

        public OrganizationAttribute(string name)
        {
            this.OrganizationName = name;
        }

        public virtual string Name
        {
            get { return OrganizationName; }
        }
    }
}