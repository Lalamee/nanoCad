using System;
using System.Windows.Forms;
using Multicad.Runtime;

namespace nanoCad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateHex2D_Click(object sender, EventArgs e)
        {
            try
            {
                double radius2D = double.Parse(txtHexRadius2D.Text);
                Detal.hexRadius2d = radius2D;
                Hexagon2D.Hexagon2d();
                MessageBox.Show("Гексагон 2D успешно создан.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании гексагона 2D: {ex.Message}");
            }
        }

        private void btnCreateHex3D_Click(object sender, EventArgs e)
        {
            try
            {
                double radius3D = double.Parse(txtHexRadius3D.Text);
                double height3D = double.Parse(txtHexHeight3D.Text);
                Detal.hexRadius3d = radius3D;
                Detal.hexHeight3d = height3D;
                Hexagon3D.Hexagon3d();
                MessageBox.Show("Гексагон 3D успешно создан.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании гексагона 3D: {ex.Message}");
            }
        }

        private void btnImportAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    openFileDialog.Title = "Выберите файл для импорта атрибутов";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        AttributeManager.ImportAttributes(filePath);
                        txtHexRadius2D.Text = Detal.hexRadius2d.ToString();
                        txtHexRadius3D.Text = Detal.hexRadius3d.ToString();
                        txtHexHeight3D.Text = Detal.hexHeight3d.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при импорте атрибутов: {ex.Message}");
            }
        }

        private void btnExportAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    saveFileDialog.Title = "Выберите место для сохранения атрибутов";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        AttributeManager.ExportAttributes(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте атрибутов: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [CommandMethod("showMainForm", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void ShowMainForm()
        {
            Application.Run(new MainForm());
        }
    }
}
