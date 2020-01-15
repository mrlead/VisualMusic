using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace VisualMusic
{
    public partial class mainForm : Form
    {
        public int row, col = 0;
        public string path;

        public mainForm()
        {
            InitializeComponent();
        }

        //Конструктор, принимающий путь к INI-файлу
        public INIManager(string aPath)
        {
            path = aPath;
        }

        //Загрузка параметров таблицы из реестра системы
        private void mainForm_Load(object sender, System.EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey tableSet = currentUserKey.OpenSubKey("VisualMusic");

            row = Convert.ToInt32(tableSet.GetValue("row").ToString());
            col = Convert.ToInt32(tableSet.GetValue("col").ToString());

            tableSet.Close();
        }

        private void butSettings_Click(object sender, EventArgs e)
        {
            settingsForm newForm = new settingsForm();
            newForm.Show();
        }

        //Сохранение параметров таблицы при случайном закрытии программы 
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey tableSet = currentUserKey.CreateSubKey("VisualMusic");

            tableSet.SetValue("row", Convert.ToString(row));
            tableSet.SetValue("col", Convert.ToString(col));

            tableSet.Close();
        }
    }

}