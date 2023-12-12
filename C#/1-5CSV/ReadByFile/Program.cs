using ReadByFile;

//we create a variable of type IDAO and we are telling it that his methods will be implemented by 
//the concrete class DAOCar();
IDAO dao = new DAOCar();
//we are initializing the Array with all the value inside  the CSV program
string[] FileLength = File.ReadAllLines("../../../Values.txt");
//we are passing it to the ReadFromArray in this way we can split the valuesi nside the arrays in BE
dao.ReadFromArray(FileLength);
dao.AddValues();
Console.WriteLine(dao.PrintObject());

