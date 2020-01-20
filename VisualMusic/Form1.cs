using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualMusic
{
    public partial class mainForm : Form
    {
        RegistryKey currentUserKey = Registry.CurrentUser;
        public RegistryKey tableSet;

        IniFiles INI = new IniFiles("data.ini");

        public int row, col = 0;
        Color emptyColor, fullColor = Color.FromArgb(0,0,0,0);
        public string path;

        public mainForm()
        {
            //CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.CreateTable);
            InitializeComponent();
        }

        //Загрузка параметров таблицы из реестра системы
        private void mainForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                tableSet = currentUserKey.OpenSubKey("VisualMusic");
                row = Convert.ToInt32(tableSet.GetValue("row").ToString());
                col = Convert.ToInt32(tableSet.GetValue("col").ToString());

                tableSet.Close();
            }
            catch
            {
                /*row = Convert.ToInt32(INI.ReadINI("row", "table"));
                col = Convert.ToInt32(INI.ReadINI("col", "table"));*/
                tableSet = currentUserKey.CreateSubKey("VisualMusic");
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
                tableSet.SetValue("row", Convert.ToString(row));
                tableSet.SetValue("col", Convert.ToString(col));

                tableSet.Close();
            }
            catch
            {
                /*INI.Write("table", "row", Convert.ToString(row));
                INI.Write("table", "col", Convert.ToString(col));*/

                tableSet = currentUserKey.CreateSubKey("VisualMusic");
                tableSet.SetValue("row", Convert.ToString(row));
                tableSet.SetValue("col", Convert.ToString(col));

                tableSet.Close();
            }
        }

        private void butSettings_Click(object sender, EventArgs e)
        {
            settingsForm newForm = new settingsForm();
            if(newForm.ShowDialog() == DialogResult.OK)
            {
                emptyColor = newForm.GetColorEmpty;
                fullColor = newForm.GetColorFull;
                col = newForm.GetCol;
                row = newForm.GetRow;

                CreateTable(row, col);
            }
        }

        public void CreateTable(int rows, int cols)
        {
            if (blinkGrid.Columns.Count != 0)
            {
                blinkGrid.Columns.Clear();
                blinkGrid.Rows.Clear();

                for (int j = 0; j < cols; j++)
                {
                    blinkGrid.Columns.Add("", "");
                }
                for (int i = 0; i < rows; i++)
                {
                    blinkGrid.Rows.Add();
                }
            }
            else
            {
                for (int j = 0; j < cols; j++)
                {
                    blinkGrid.Columns.Add("", "");
                }
                for (int i = 0; i < rows; i++)
                {
                    blinkGrid.Rows.Add();
                }
            }
            
        }
    }

}