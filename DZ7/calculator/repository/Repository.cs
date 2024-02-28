using System;
using DZ7.calculator.repository.impl;

namespace DZ7
{
	class Repository : IRepository
	{ 
		private readonly string path = "/Users/maksimmakarov/Desktop/" +
			"GB/ООП/DZ/DZ7/DZ7/repository.txt";

        public async void Create()
		{
            //FileInfo file = new (path);
            //FileStream fs = file.Create();
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine("Привет");
            //StreamWriter sw = new StreamWriter(path,true);
            //await sw.WriteLineAsync("Привет");
		}

        //public void Read()
        //{
        //    throw new NotImplementedException();
        //}

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}

