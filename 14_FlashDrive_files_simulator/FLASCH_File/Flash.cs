using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLASCH_File
{
    public class Flash
    {
        public string Name { get; set; }
        public int MaxSize { get; set; }
        public File[] Files { get; set; }
        public int FileCount { get; private set; }
        public Flash(string name, int maxSize)
        {
            Name = name;
            MaxSize = maxSize;
            Files = new File[5];
            FileCount = 0;
        }
        public void AddFile(File file)
        {
            if (GetCurrentSize() + file.Size <= MaxSize && FileCount < Files.Length)
            {
                Files[FileCount] = file;
                FileCount++;
            }
            else
                MessageBox.Show("Flash drive is full");
        }
        public void RemoveFile(string fileName)
        {
            for (int i = 0; i < FileCount; i++)
            {
                if (Files[i].Name == fileName)
                {
                    Files[i] = Files[FileCount - 1];
                    Files[FileCount - 1] = null;
                    FileCount--;
                    return;
                }
            }
        }
        public int GetCurrentSize()
        {
            int totalSize = 0;
            foreach (var file in Files)
            {
                if (file != null)
                    totalSize += file.Size;
            }
            return totalSize;
        }
    }
}
