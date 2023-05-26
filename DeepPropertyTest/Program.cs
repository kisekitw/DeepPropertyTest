// See https://aka.ms/new-console-template for more information
using DeepPropertyTest;

var testManagementService = new TestManagementService();
testManagementService.HighResolution = "1";

Console.WriteLine(testManagementService.HighResolution);
Console.ReadKey(); 



