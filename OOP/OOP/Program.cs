class Box
{
	// các thuộc tính của lớp box
	public double Length { get; set; }
	public double Breadth { get; set; }
	public double Height { get; set; }

	// hàm tạo mặc định
	public Box()
	{ }

	// hàm tạo với các tham số
	public Box(double length, double breadth, double height)
	{
		Length = length;
		Breadth = breadth;
		Height = height;
	}

	// hành vi hoặc phương thức hoạt động ( method )
	public void Print()
	{
		Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
	}
}

class Animal
{
	public virtual void Speak()
	{
		Console.WriteLine("Animal is speaking");
	}
}
class Dog : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Dog is speaking");
	}
}

class Cat : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Cat is speaking");
	}
}

class Pig : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Pig is speaking");
	}
}


interface IExportData
{
	void Export();
}

class TextExport : IExportData
{
	public void Export()
	{
		Console.WriteLine("Export data to .txt file");
	}
}

class CsvExport : IExportData
{
	public void Export()
	{
		Console.WriteLine("Export data to .csv file");
	}
}
class Application
{
	private readonly IExportData _exportData;

	public Application(IExportData exportData)
	{
		_exportData = exportData;
	}

	public void ExportData()
	{
		_exportData.Export();
	}
}

class RectangleTester
{
	static void Main(string[] args)
	{
		Application app = new Application(new TextExport());
		app.ExportData();
		Console.ReadKey();
	}
}


