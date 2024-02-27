using System;
namespace DZ7
{
	public class Repository
	{ 

		string path = "/Users/maksimmakarov/Desktop/GB/ООП/DZ/DZ7/DZ7/repository.txt";

        public void create()
		{
			FileInfo file = new FileInfo(path);
			FileStream fs = file.Create();
		}

	}
}

