using System.IO;
using Tyuiu.GalimovaAS.Sprint7.Project.V12.Lib;
namespace Tyuiu.GalimovaAS.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonInfo_GAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonShopInfo_GAS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint7\Tyuiu.GalimovaAS.Sprint7.Project.V12\shopsinputfile.csv";
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                    {
                        sr.ReadLine();

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            textBoxShopInfo_GAS.Text += line + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonShow_GAS_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxBrand_GAS.Text);
            try
            {
                string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint7\Tyuiu.GalimovaAS.Sprint7.Project.V12\laptopsinputfile.csv";
                if (File.Exists(path))
                {
                    string fileData = File.ReadAllText(path);
                    fileData = fileData.Replace('\n', '\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int rows = lines.Length;
                    int columns = lines[0].Split(',').Length;

                    for (int i = 1; i < rows; i++)
                    {
                        string[] values = lines[i].Split(',');
                        if (values[0].Contains(name))
                        {
                            textBoxShowModels_GAS.Text += values[0] + Environment.NewLine;
                        }
                    }
                    textBoxShowModels_GAS.Text += "--------------------" + Environment.NewLine;
                    buttonDone_GAS.Enabled = true;
                    textBoxModel_GAS.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_GAS_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxBrand_GAS.Text);
            try
            {
                string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint7\Tyuiu.GalimovaAS.Sprint7.Project.V12\laptopsinputfile.csv";
                if (File.Exists(path))
                {
                    string fileData = File.ReadAllText(path);
                    fileData = fileData.Replace('\n', '\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int rows = lines.Length;
                    int columns = lines[0].Split(',').Length;

                    for (int i = 1; i < rows; i++)
                    {
                        string[] values = lines[i].Split(',');
                        if (values[0].Contains(textBoxModel_GAS.Text))
                        {
                            if (radioButtonProcessor_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[1];
                            }
                            else if (radioButtonFrequency_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[2];
                            }
                            else if (radioButtonScreen_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[3];
                            }
                            else if (radioButtonBattery_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[4];
                            }
                            else if (radioButtonSSD_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[5];
                            }
                            else if (radioButtonDate_GAS.Checked)
                            {
                                textBoxResult_GAS.Text = values[6];
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    