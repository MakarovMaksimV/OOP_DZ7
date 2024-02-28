using System;
using DZ7.calculator.repository.impl;

namespace DZ7
{
	class Repository : IRepository
	{
        private readonly string path;

        public Repository(string path)
        {
            this.path = path;
        }

        public void Write(string txt)
        {
            StreamWriter sw = new(path, true);
            sw.WriteLine(txt);
        }
    }
}

