using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIocContainer
{
    public interface IWelcomer
    {
        void SayHelloTo(string name);
    }

    public class Welcomer : IWelcomer
    {
        private IWriter writer;

        public Welcomer(IWriter writer)
        {
            this.writer = writer;
        }

        public void SayHelloTo(string name)
        {
            writer.Write($"Hello {name}!");
        }
    }

    public interface IWriter
    {
        void Write(string s);
    }

    public class ConsoleWriter : IWriter
    {
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
