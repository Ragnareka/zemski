using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    interface IFileService
    {
        List<Model> Open(string filename);
        void Save(string filename, List<Model> ExcelList);
        // https://metanit.com/sharp/wpf/22.6.php
    }
}
