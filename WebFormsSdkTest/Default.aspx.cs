using SomeX64Lib;
using System;
using System.Runtime.InteropServices;

namespace WebFormsSdkTest
{
    public partial class DefaultPage : System.Web.UI.Page
    {
        protected TestClass1 tc;
        protected SiteClass sc;
        protected string Architecture => this.GetType().Assembly.GetName().ProcessorArchitecture.ToString();
        protected string Assembly => this.GetType().Assembly.GetName().FullName;

        protected void Page_Load(object sender, EventArgs e)
        {
            tc = new TestClass1();
            sc = new SiteClass();
        }
    }
}
