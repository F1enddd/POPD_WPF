using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POPD_WPF.WindowThemes;

namespace POPD_WPF.Models
{
    public class FolderViewModel
    {
        public List<FolderItem> RootFolders { get; set; }

        public FolderViewModel()
        {
            RootFolders = new List<FolderItem>
            {
            LoadFolder(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes")) };
        }

        public FolderItem LoadFolder(string path)
        {
            var folder = new FolderItem { Name = System.IO.Path.GetFileName(path) };

            foreach (var file in Directory.GetFiles(path))
            {
                folder.Files.Add(new FileItem
                {
                    Name = System.IO.Path.GetFileName(file),
                    Content = File.ReadAllText(file)
                });
            }

            foreach (var dir in Directory.GetDirectories(path))
            {
                folder.SubFolders.Add(LoadFolder(dir));
            }

            return folder;
        }

    }

    public class FileItem
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }

    public class FolderItem
    {
        public string Name { get; set; }
        public List<FileItem> Files { get; set; } = new();
        public List<FolderItem> SubFolders { get; set; } = new();
    }
}
