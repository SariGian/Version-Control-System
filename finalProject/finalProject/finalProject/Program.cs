// See https://aka.ms/new-console-template for more information
using FinalProject;
using static System.Console;
WriteLine("----------------WELCOME!------------------\n------we are happy to see you here:)------");
WriteLine("------The authors: Gian, Weiss, Meir------");
Repo myRepo = new("myRepo");
WriteLine(myRepo.Main.AddFile(new FinalProject.Composite.File("firstFile.txt", "Hi everybody.")));
WriteLine(myRepo.Main.AddFile(new FinalProject.Composite.File("secondFile.html", "ausome website")));
WriteLine(myRepo.Main.CreateBranch("AI_textBranch"));

// the time is: 2:22 AM
// Hashem, please help us!!!
// good afternoon, now we're full with freshness and vigor:)
