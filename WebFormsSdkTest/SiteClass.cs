namespace WebFormsSdkTest
{
    public class SiteClass
    {
        public string Architecture => this.GetType().Assembly.GetName().ProcessorArchitecture.ToString();
        public string Assembly => this.GetType().Assembly.GetName().FullName;
    }
}
