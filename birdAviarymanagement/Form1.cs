using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace birdAviarymanagement
{
    public partial class Form1 : Form
    {
        private List<Bird> birds = new List<Bird>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        //******************** INITIALIZE AND DESIGN ********************

        private void InitializeForm()
        {
            ConfigureForm();
            ConfigureProgressBar();
            ConfigureButtons();
            ConfigureToolTips();

            InitializeComboBoxItems();
            ConfigureComboBoxes();

            ConfigureTextBoxes();
            ConfigureGrid();

            UpdateBirdsCountLabel();
        }

        private void ConfigureForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.SizeGripStyle = SizeGripStyle.Hide;
        }

        private void ConfigureProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private void ConfigureButtons()
        {
            MakeInvisibleButton(randomDataBtn);
            MakeInvisibleButton(addBtn);
            MakeInvisibleButton(createSortedReportBtn);
        }

        private void MakeInvisibleButton(Button btn)
        {
            btn.Visible = true;
            btn.Enabled = true;

            btn.Text = "";
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btn.BackColor = Color.Transparent;
            btn.UseVisualStyleBackColor = false;
            btn.BringToFront();
        }

        private void ConfigureToolTips()
        {
            ToolTip tip = new ToolTip();

            tip.SetToolTip(addBtn, "Add new bird");
            tip.SetToolTip(createSortedReportBtn, "Sort data table");
            tip.SetToolTip(randomDataBtn, "Create random data");
        }

        private void InitializeComboBoxItems()
        {
            InitType();
            InitStatus();
            InitAvail();
        }

        private void InitType()
        {
            typeCbox.Items.Clear();

            typeCbox.Items.Add("Parrot");
            typeCbox.Items.Add("Canary");
            typeCbox.Items.Add("Dove");
            typeCbox.Items.Add("Eagle");
            typeCbox.Items.Add("Flamingo");
        }

        private void InitStatus()
        {
            statusCbox.Items.Clear();

            statusCbox.Items.Add("In Aviary");
            statusCbox.Items.Add("Sold");
            statusCbox.Items.Add("In Quarantine");
        }

        private void InitAvail()
        {
            availCbox.Items.Clear();

            availCbox.Items.Add("True");
            availCbox.Items.Add("False");
        }

        private void ConfigureComboBoxes()
        {
            StyleComboBox(typeCbox);
            StyleComboBox(statusCbox);
            StyleComboBox(availCbox);
        }

        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.FromArgb(245, 242, 235);
            comboBox.ForeColor = Color.Black;
            comboBox.Font = new Font("Segoe UI", 10);

            // יותר בטוח לפרויקט כי המשתמשת בוחרת רק ערכים קיימים
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigureTextBoxes()
        {
            StyleTextBox(idTxtBx);
            StyleTextBox(colorMutTxtBx);
            StyleTextBox(yearTxtBx);
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(245, 242, 235);
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font("Segoe UI", 11);
        }

        private void ConfigureGrid()
        {
            birdsGrid.ReadOnly = true;
            birdsGrid.AllowUserToAddRows = false;
            birdsGrid.AllowUserToDeleteRows = false;
            birdsGrid.AllowUserToResizeRows = false;

            StyleBirdGrid(birdsGrid);
        }

        private void StyleBirdGrid(DataGridView grid)
        {
            Color gridColor = Color.FromArgb(232, 244, 238);

            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = gridColor;
            grid.GridColor = gridColor;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = gridColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = gridColor;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            grid.AlternatingRowsDefaultCellStyle.BackColor = gridColor;

            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 220);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //******************** DATA DISPLAY HELPERS ********************

        private void RefreshBirdsGrid()
        {
            birdsGrid.DataSource = null;
            birdsGrid.DataSource = birds;
            UpdateBirdsCountLabel();
        }

        private void UpdateBirdsCountLabel()
        {
            lblBirdsInSystem.Text = $"Birds in system: {birds.Count}";
        }

        private void ClearInputFields()
        {
            idTxtBx.Clear();
            colorMutTxtBx.Clear();
            yearTxtBx.Clear();

            typeCbox.SelectedIndex = -1;
            statusCbox.SelectedIndex = -1;
            availCbox.SelectedIndex = -1;
        }

        //******************** RANDOM DATA ********************

        private Bird GenerateRandomBird(int index)
        {
            string[] birdTypes =
            {
                "Parrot",
                "Canary",
                "Dove",
                "Eagle",
                "Flamingo"
            };

            string[] colors =
            {
                "Blue",
                "Green",
                "Yellow",
                "White",
                "Albino"
            };

             string[] statuses =
            {
                "In Aviary",
                "Sold",
                "In Quarantine"
            };

            string id = (1000 + index).ToString();
            string type = birdTypes[rnd.Next(birdTypes.Length)];
            string color = colors[rnd.Next(colors.Length)];
            int year = rnd.Next(2000, 2026);
            string status = statuses[rnd.Next(statuses.Length)];
            bool available = rnd.Next(2) == 0;

            return new Bird(id, type, color, year, status, available);
        }

        public List<Bird> GetBirds()
        {
            return birds;
        }

        //******************** VALIDATIONS ********************

        private bool IsOnlyNumbers(string str)
        {
            foreach (char ch in str)
            {
                if (!char.IsNumber(ch))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsOnlyLetters(string str)
        {
            foreach (char ch in str)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckId()
        {
            if (idTxtBx.Text == "" || !IsOnlyNumbers(idTxtBx.Text))
            {
                X_id.Visible = true;
                return false;
            }

            foreach (Bird bird in birds)
            {
                if (bird.RingId == idTxtBx.Text)
                {
                    X_id.Visible = true;
                    MessageBox.Show("Ring ID already exists");
                    return false;
                }
            }

            X_id.Visible = false;
            return true;
        }

        private bool CheckType()
        {
            if (typeCbox.SelectedIndex == -1)
            {
                X_type.Visible = true;
                return false;
            }

            X_type.Visible = false;
            return true;
        }

        private bool CheckColor()
        {
            if (colorMutTxtBx.Text == "" || !IsOnlyLetters(colorMutTxtBx.Text))
            {
                x_color.Visible = true;
                return false;
            }

            x_color.Visible = false;
            return true;
        }

        private bool CheckYear()
        {
            if (yearTxtBx.Text == "" || !IsOnlyNumbers(yearTxtBx.Text))
            {
                X_year.Visible = true;
                return false;
            }

            int year = int.Parse(yearTxtBx.Text);

            if (!(year >= 1900 && year <= 2026))
            {
                X_year.Visible = true;
                return false;
            }

            X_year.Visible = false;
            return true;
        }

        private bool CheckStatus()
        {
            if (statusCbox.SelectedIndex == -1)
            {
                x_status.Visible = true;
                return false;
            }

            x_status.Visible = false;
            return true;
        }

        private bool CheckAvail()
        {
            if (availCbox.SelectedIndex == -1)
            {
                x_avail.Visible = true;
                return false;
            }

            x_avail.Visible = false;
            return true;
        }

        private bool IsFormValid()
        {
            return CheckId()
                && CheckType()
                && CheckColor()
                && CheckYear()
                && CheckStatus()
                && CheckAvail();
        }

        //******************** SORTING ********************

        public static List<Bird> BubbleSortBirdsByYear(List<Bird> birds)
        {
            for (int i = 0; i < birds.Count - 1; i++)
            {
                for (int j = 0; j < birds.Count - i - 1; j++)
                {
                    if (birds[j].HatchYear < birds[j + 1].HatchYear)
                    {
                        Bird temp = birds[j];
                        birds[j] = birds[j + 1];
                        birds[j + 1] = temp;
                    }
                }
            }

            return birds;
        }

        public static List<Bird> QuickSortBirdsByYear(List<Bird> birds)
        {
            if (birds == null || birds.Count <= 1)
            {
                return birds;
            }

            QuickSort(birds, 0, birds.Count - 1);
            return birds;
        }

        private static void QuickSort(List<Bird> birds, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotIndex = Partition(birds, left, right);

            QuickSort(birds, left, pivotIndex - 1);
            QuickSort(birds, pivotIndex + 1, right);
        }

        private static int Partition(List<Bird> birds, int left, int right)
        {
            int pivot = birds[right].HatchYear;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (birds[j].HatchYear >= pivot)
                {
                    i++;

                    Bird temp = birds[i];
                    birds[i] = birds[j];
                    birds[j] = temp;
                }
            }

            Bird temp2 = birds[i + 1];
            birds[i + 1] = birds[right];
            birds[right] = temp2;

            return i + 1;
        }

        //******************** REPORT CALCULATIONS ********************

        public static float AvgCalc(List<Bird> birds)
        {
            if (birds == null || birds.Count == 0)
            {
                return 0;
            }

            int currentYear = DateTime.Now.Year;
            float sum = 0;

            foreach (Bird bird in birds)
            {
                sum += currentYear - bird.HatchYear;
            }

            return sum / birds.Count;
        }

        public static int CountAvailableBirds(List<Bird> birds)
        {
            int count = 0;

            foreach (Bird bird in birds)
            {
                if (bird.AvailableForSale)
                {
                    count++;
                }
            }

            return count;
        }

        public static void UpdateBirdAvailability(Bird bird, IHealthService healthService)
        {
            bird.AvailableForSale = healthService.IsBirdHealthy(bird.RingId);
        }

        //******************** EVENTS ********************

        private void randomDataBtn_Click(object sender, EventArgs e)
        {
            birds.Clear();

            progressBar1.Visible = true;
            progressBar1.Value = 0;

            for (int i = 0; i < 10000; i++)
            {
                birds.Add(GenerateRandomBird(i));
                progressBar1.Value = i + 1;

                if (i % 100 == 0)
                {
                    Application.DoEvents();
                }
            }

            RefreshBirdsGrid();

            progressBar1.Visible = false;

            MessageBox.Show("10000 birds added");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                MessageBox.Show(
                    "Something went wrong :( ",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Bird bird = new Bird(
                idTxtBx.Text,
                typeCbox.Text,
                colorMutTxtBx.Text,
                int.Parse(yearTxtBx.Text),
                statusCbox.Text,
                bool.Parse(availCbox.Text)
            );

            birds.Add(bird);
            RefreshBirdsGrid();
            ClearInputFields();

            MessageBox.Show(
                "Bird added successfully",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void createSortedReportBtn_Click(object sender, EventArgs e)
        {
            if (birds == null || birds.Count == 0)
            {
                MessageBox.Show(
                    "No birds data available",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            birds = QuickSortBirdsByYear(birds);

            sw.Stop();

            RefreshBirdsGrid();

            float avgAge = AvgCalc(birds);
            int availableCount = CountAvailableBirds(birds);
            int totalBirds = birds.Count;

            MessageBox.Show(
                "Birds are displayed sorted by hatch year (descending) in the data table." +
                "\n\nTotal Birds: " + totalBirds +
                "\nAverage Age: " + avgAge +
                "\nAvailable For Sale: " + availableCount +
                "\nQuickSort Time: " + sw.ElapsedMilliseconds + " ms",
                "Inventory Report"
            );
        }

        private void statusCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusCbox.SelectedItem != null &&
                statusCbox.SelectedItem.ToString() == "Sold")
            {
                availCbox.SelectedIndex = 1;
            }
        }

        private void birdsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < birds.Count)
            {
                Bird bird = birds[e.RowIndex];

                MessageBox.Show(
                    "Ring ID: " + bird.RingId +
                    "\nType: " + bird.Type +
                    "\nColor: " + bird.ColorMutation +
                    "\nHatch Year: " + bird.HatchYear +
                    "\nStatus: " + bird.Status,
                    "Bird Details"
                );
            }
        }
    }
}