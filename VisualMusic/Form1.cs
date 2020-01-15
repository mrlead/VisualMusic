using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace VisualMusic
{
    public partial class mainForm : Form
    {
        RegistryKey currentUserKey = Registry.CurrentUser;
        public RegistryKey tableSet;

        IniFiles INI = new IniFiles("data.ini");

        public int row, col = 0;
        public string path;

        public mainForm()
        {
            InitializeComponent();
        }

        //Загрузка параметров таблицы из реестра системы
        private void mainForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                tableSet = currentUserKey.OpenSubKey("VisualMusic");
            }
            catch
            {
                row = Convert.ToInt32(INI.ReadINI("table", "row"));
                col = Convert.ToInt32(INI.ReadINI("table", "col"));

                tableSet = currentUserKey.CreateSubKey("VisualMusic");
                row = Convert.ToInt32(tableSet.GetValue("row").ToString());
                col = Convert.ToInt32(tableSet.GetValue("col").ToString());

                tableSet.Close();
            }
            finally
            {
                row = Convert.ToInt32(tableSet.GetValue("row").ToString());
                col = Convert.ToInt32(tableSet.GetValue("col").ToString());

                tableSet.Close();
            }
        }

        //Сохранение параметров таблицы при случайном закрытии программы 
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tableSet = currentUserKey.CreateSubKey("VisualMusic");
            }
            catch
            {
                INI.Write("table", "row", Convert.ToString(row));
                INI.Write("table", "col", Convert.ToString(col));

                tableSet = currentUserKey.CreateSubKey("VisualMusic");
                tableSet.SetValue("row", Convert.ToString(row));
                tableSet.SetValue("col", Convert.ToString(col));

                tableSet.Close();
            }
            finally
            {
                tableSet.SetValue("row", Convert.ToString(row));
                tableSet.SetValue("col", Convert.ToString(col));

                tableSet.Close();
            }
        }

        private void butSettings_Click(object sender, EventArgs e)
        {
            settingsForm newForm = new settingsForm();
            newForm.Show();
        }
    }

}