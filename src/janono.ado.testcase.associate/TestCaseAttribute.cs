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
        public readonly string AreaPath;

        public OrganizationAttribute(string name)
        {
            this.OrganizationName = name;
        }

        public OrganizationAttribute(string name, string areaPath)
        {
            this.OrganizationName = name;
            this.AreaPath = areaPath;
        }

        public virtual string Name
        {
            get { return OrganizationName; }
        }

        public virtual string Path
        {
            get { return AreaPath; }
        }
    }
}