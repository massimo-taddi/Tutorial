using ReadByFile;


IDAO dao = new DAOCar();

string[] FileLength = File.ReadAllLines("../../../Values.txt");
dao.ReadFromInfo(FileLength);
dao.AddValues();

Console.WriteLine(dao.PrintObject());

