using System;
using DZ7.calculator.repository.impl;

namespace DZ7
{
	class Repository : IRepository
	{
        private readonly string path = "memory.txt" ;

        public Repository()
        {
            this.path = path;
        }

        public Repository(string path)
        {
            this.path = path;
        }

        public void Write(string txt)
        {
            File.AppendAllText(path, txt);
            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine("Привет!");
            //    sw.WriteLine(txt);
            //}
               
        }
    }
}

