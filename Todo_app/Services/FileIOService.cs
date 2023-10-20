using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Todo_app.Models;

namespace Todo_app.Services
{
    class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path)
        {
            PATH = path;
        }

        public BindingList<TodoModels> LoadData()
        {
            return null;
        }

        public void SaveData(BindingList<TodoModels> todoData)
        {

        }
    }
}
