using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<string> stringList;
        private ArrayList arrayList;

        public MainForm()
        {
            InitializeComponent();

            // Initialize data structures
            stringList = new List<string>();
            arrayList = new ArrayList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                // Add to List
                stringList.Add(inputText);

                // Add to ArrayList
                arrayList.Add(inputText);

                UpdateListBoxes();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Remove from List
                stringList.RemoveAt(listBox1.SelectedIndex);

                // Remove from ArrayList
                arrayList.RemoveAt(listBox1.SelectedIndex);

                UpdateListBoxes();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear List
            stringList.Clear();

            // Clear ArrayList
            arrayList.Clear();

            UpdateListBoxes();
        }

        private void UpdateListBoxes()
        {
            // Update ListBox controls
            listBox1.DataSource = null;
            listBox1.DataSource = stringList;

            listBox2.DataSource = null;
            listBox2.DataSource = arrayList;
        }
    }
}
