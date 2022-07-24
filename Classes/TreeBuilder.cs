namespace Jobinterview.Classes {
	internal class TreeBuilder {
		public TreeBuilder(string[] text, FolderElement mainFolder) {
			foreach (var item in text) {
				Creator(item, mainFolder);
			}
		}
		private void Creator(string line, FolderElement folder) {
			var indexOfChar = line.IndexOf('\\');
			if (indexOfChar != -1) {
				var element = line.Substring(0, indexOfChar);
				FolderElement newFolder;
				if (!folder.Folders.Exists(x => x.Name == element)) {
					newFolder = new FolderElement(element);
					folder.Folders.Add(newFolder);
				}
				else {
					newFolder = folder.Folders.Find(x => x.Name == element);
				}
				Creator(line.Substring(++indexOfChar), newFolder);
			}
			else {
				var indexOfSpace = line.IndexOf(' ');
				if (indexOfSpace != -1) {
					var element = line.Substring(0, indexOfSpace);
					int.TryParse(line.Substring(indexOfSpace), out var intValue);
					var newFile = new FileElement(element, intValue);
					folder.Files.Add(newFile);
				}
				else {
					if (!folder.Folders.Exists(x => x.Name == line)) {
						var newFolder = new FolderElement(line);
						folder.Folders.Add(newFolder);
					}
				}
			}
		}
	}
}
