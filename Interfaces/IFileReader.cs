namespace Jobinterview.Interfaces {
	internal interface IFileReader {
		string Path { get; set; }
		string[] OpenAndReadFile(string path, string exceptionMessage);
	}
}
