using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Flyweight;

internal class FileFactory
{
    static FileFactory fileFactory;
    public Dictionary<string, FinalProject.Composite.File> Files;
    public static object locker;
    static FileFactory()
    {
        locker = new object();
    }
    private FileFactory()
    {
        Files = new();
    }
   
    public static FileFactory GetInstance()
    {
        if (fileFactory == null)
        {
            lock (locker)
            {
                if (fileFactory == null)
                {
                    fileFactory = new FileFactory();
                }
            }
        }
        return fileFactory;
    }

    public  FinalProject.Composite.File GetFile(string name, int branchId)
    {
        string FileKey = $"{name}_{branchId}";
        if (Files.ContainsKey(FileKey))
            return Files[FileKey];
        FinalProject.Composite.File file = new(name);
        Files.Add(FileKey,file);
        return file;
    }
}
