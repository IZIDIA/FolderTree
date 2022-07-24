using Jobinterview.Classes;
using System;

namespace Jobinterview {
	internal class Program {
		const string Path = @"..\..\data.txt";
		static void Main() {
			FolderElement mainFolder = new FolderElement("C:");
			//Чтение из файла
			TxtFileReader txtFileReader = new TxtFileReader();
			txtFileReader.Notify += ConsoleExceptionOutput;
			var mainText = txtFileReader.OpenAndReadFile(Path);
			//Построение дерева
			TreeBuilder treeBuilder = new TreeBuilder(mainText, mainFolder);
			//Сортировка
			FileSystemElementsSort.FolderSort(mainFolder);
			FileSystemElementsSort.FileSort(mainFolder);
			//Вывод на экран
			TreePrinter treePrinter = new TreePrinter(mainFolder);
			treePrinter.ConsolePrint();
		}
		public static void ConsoleExceptionOutput(string message) {
			Console.WriteLine(message);
		}
	}
}
