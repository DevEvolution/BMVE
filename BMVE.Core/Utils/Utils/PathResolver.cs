using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class PathResolver
    {
        internal PathUnit ResolvePath(string path)
        {
            int index = path.LastIndexOf('\\');
            if (index == -1)
            {
                return new PathUnit { Filename = path, Path = "." };
            }

            string dir = path.Substring(0, index);
            dir = dir.Length == 0 ? "." : dir;
            string file = path.Length - 1 > index + 1 ? path.Substring(index + 1) : "";

            return new PathUnit { Filename = file, Path = dir };
        }

        //internal StorageFolder ReachPathFolder(string path, StorageFolder current = null)
        //{
        //    int index = path.IndexOf('\\');
        //    if (current == null)
        //        current = _currentFolder;

        //    string folderName;

        //    if (index == -1)
        //        folderName = path;
        //    else
        //        folderName = path.Substring(0, index);

        //    StorageFolder folder;
        //    if (folderName == "..")
        //        folder = current.GetParentAsync().AsTask().Result;
        //    else if (folderName == ".")
        //        folder = current;
        //    else
        //        folder = current.GetFolderAsync(folderName).AsTask().Result;

        //    if (index == -1)
        //        return folder;
        //    else
        //        return ReachPathFolder(path.Substring(index).TrimStart('\\'), folder);
        //}
    }
}
