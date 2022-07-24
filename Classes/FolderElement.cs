using Jobinterview.Interfaces;
using System.Collections.Generic;

namespace Jobinterview.Classes {
	internal class FolderElement : IFileSystemElement {
		public string Name { get; set; }
		public int SizeByte { get; set; }
		public List<FolderElement> Folders { get; set; }
		public List<FileElement> Files { get; set; }
		public FolderElement(string name) {
			Name = name;
			Folders = new List<FolderElement>();
			Files = new List<FileElement>();
		}
		public FolderElement(string name, int sizeByte) {
			Name = name;
			SizeByte = sizeByte;
			Folders = new List<FolderElement>();
			Files = new List<FileElement>();
		}
	}
}
