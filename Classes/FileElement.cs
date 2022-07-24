using Jobinterview.Interfaces;

namespace Jobinterview.Classes {
	internal class FileElement : IFileSystemElement {
		public string Name { get; set; }
		public int SizeByte { get; set; }
		public FileElement(string name) {
			Name = name;
		}
		public FileElement(string name, int sizeByte) {
			Name = name;
			SizeByte = sizeByte;
		}
	}
}
