using SomeX64Lib;
using System;

namespace WebFormsSdkTest
{
    public partial class DefaultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = new TestClass1();
        }
    }
}
