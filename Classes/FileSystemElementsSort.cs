using System.Linq;

namespace Jobinterview.Classes {
	internal static class FileSystemElementsSort {
		public static void FolderSort(FolderElement folderElement) {
			folderElement.Folders.Sort((left, right) => left.Name.CompareTo(right.Name));
			if (folderElement.Folders.Count > 0) {
				foreach (var item in folderElement.Folders) {
					FolderSort(item);
				}
			}
		}
		public static void FileSort(FolderElement folderElement) {
			folderElement.Files = folderElement.Files.OrderByDescending(x => x.SizeByte).ThenBy(x => x.Name).ToList();
			if (folderElement.Folders.Count > 0) {
				foreach (var item in folderElement.Folders) {
					FileSort(item);
				}
			}
		}
	}
}
