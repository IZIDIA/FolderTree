using Jobinterview.Interfaces;
using System;
using System.Text;

namespace Jobinterview.Classes {
	internal class TreePrinter {
		public FolderElement MainFolder { get; set; }
		public TreePrinter(FolderElement folderElement) {
			MainFolder = folderElement;
		}
		public void ConsolePrint() {
			var tab = 0;
			foreach (var item in MainFolder.Folders) {
				WalkingTree(item, tab);
			}
		}
		public void WalkingTree(FolderElement folder, int tab) {
			ConsolePrintElement(folder, tab);
			if (folder.Folders.Count != 0) {
				foreach (var item in folder.Folders) {
					WalkingTree(item, tab + 1);
				}
			}
			if (folder.Files.Count != 0) {
				foreach (var item in folder.Files) {
					ConsolePrintElement(item, tab + 1);
				}
			}
		}
		private void ConsolePrintElement(IFileSystemElement element, int tab) {
			Console.WriteLine(new StringBuilder().Insert(0, " ", tab).ToString() + element.Name);
		}
	}
}
