using System;
using DZ7.calculator.repository.impl;

namespace DZ7
{
	class Repository : IRepository
	{
        private readonly string path = "/Users/maksimmakarov/Desktop/GB/ООП/DZ/DZ7/DZ7/memory.txt";

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
        }
    }
}

