using System.Management.Automation;

namespace ReadXMLToClass
{
    public class ExampleClass
    {
        [Alias("Nome")]
        public string FirstName { get; set; }
        [Alias("Sobrenome")]
        public string LastName { get; set; }
        [Alias("Idade")]
        public int Age { get; set; }
    }
}
