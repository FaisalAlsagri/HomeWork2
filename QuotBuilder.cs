using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuotBuilder obj = new QuotBuilder();
            System.Console.WriteLine(obj.beginQuot()
                .setContent("Hello World!")
                    .endQuot()
                        .getQuot());
        }
        class QuotBuilder {
            private string quot;
            public QuotBuilder()
            {
                this.quot = "";
            }
            public QuotBuilder beginQuot()
            {
                this.quot += "\"";
                return this;
            }
            public QuotBuilder setContent(string value)
            {
                this.quot += value;
                return this;
            }
            public QuotBuilder endQuot()
            {
                this.quot += "\"";
                return this;
            }
            public string getQuot()
            {
                return this.quot;
            }
        } 
    }
}
