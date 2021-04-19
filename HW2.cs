using System;
using System.Collections.Generic;


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
                        
            CheckOrder check = new CheckOrder("1124554211");
            System.Console.WriteLine(check.check());
        }

         class CheckOrder {
            private string value;
            public CheckOrder(string val)
            {
                this.value = val;
            }
            public bool check()
            {
                if(this.value.Length % 2 == 0){
                Stack<string> myStack = new Stack<string>();
                string str = "";
                foreach (var item in this.value)
                {
                    if(myStack.Count != 0){
                    if(myStack.Peek() == item.ToString()){
                        myStack.Pop();
                    }else{
                        myStack.Push(item.ToString());
                        str = item.ToString();
                    }
                    }else{
                        if(str == item.ToString()){
                        myStack.Pop();
                    }else{
                        myStack.Push(item.ToString());
                        str = item.ToString();
                    }
                    }
                }
                if(myStack.Count == 0){
                    return true;
                }
                }
                return false;
            }
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
