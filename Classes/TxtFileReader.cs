using Jobinterview.Interfaces;
using System.IO;

namespace Jobinterview.Classes {
	internal class TxtFileReader : IFileReader {
		public string Path { get; set; }
		public delegate void ExceptionMessage(string message);
		public event ExceptionMessage Notify;
		public string[] OpenAndReadFile(string path, string exceptionMessage = "Текст из файла не был прочитан.") {
			string[] textFromTxtFile = new string[] { };
			try {
				textFromTxtFile = File.ReadAllLines(path);
			}
			catch { ShowExceptionMessage(exceptionMessage); }
			return textFromTxtFile;
		}
		private void ShowExceptionMessage(string exceptionMessage) {
			Notify?.Invoke(exceptionMessage);
		}
	}
}
