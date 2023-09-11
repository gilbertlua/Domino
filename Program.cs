using System.ComponentModel;
using Domino;

class Program
{
	
	public static void Main()
	{
		Program program = new Program();
		// program.AddNewTile();
		program.GenerateTile();
	}
	public void AddNewTile()
	{
		Tile tile;
		Side side;
		side = new(4,5);
		tile = new(side);
		
		
		int left = tile.GetSide().GetLeft();
		int right = tile.GetSide().GetRight();
		Console.WriteLine("Tile");
		Console.WriteLine("-------");
		Console.WriteLine($"|{left} | {right}|");
		Console.WriteLine("-------");
	}
	public void GenerateTile()
	{
		Tile[,] tile = new Tile[7,7];
		Side side;
		for(int i=0 ; i<=6 ; i++)
		{
			for(int j=0 ; j<=6 ; j++ )
			{
				side = new Side(i,j);
				tile[i,j] = new(side);
			}
		}
		
		int x = 0;
		foreach (var item in tile)
		{
			x++;
			Console.WriteLine($"Tile {x}");
			Console.WriteLine("=====================");
			Console.WriteLine($"{item.GetSide().GetRight()} | {item.GetSide().GetLeft()}");
			Console.WriteLine("=====================");
			Console.WriteLine();
		}
	}
	
}