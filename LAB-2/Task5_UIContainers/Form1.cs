using System;
using System.Windows.Forms;

namespace Task5_UIContainers
{
    public partial class Form1 : Form
    {
        private GroupBox groupBoxUser;
        private TextBox textBoxInput;
        private Button buttonDisplay;
        private Label labelOutput;

        private GroupBox groupBoxCounter;
        private TextBox textBoxCounter;
        private Button buttonCount;
        private Label labelCounter;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            groupBoxUser = new GroupBox();
            groupBoxUser.Text = "User Input";
            groupBoxUser.Location = new System.Drawing.Point(50, 30);
            groupBoxUser.Size = new System.Drawing.Size(400, 150);

            textBoxInput = new TextBox();
            textBoxInput.Location = new System.Drawing.Point(20, 30);
            textBoxInput.Size = new System.Drawing.Size(250, 23);
            textBoxInput.Name = "textBoxInput";

            buttonDisplay = new Button();
            buttonDisplay.Location = new System.Drawing.Point(290, 30);
            buttonDisplay.Size = new System.Drawing.Size(75, 23);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Text = "Show";
            buttonDisplay.Click += new EventHandler(buttonDisplay_Click);

            labelOutput = new Label();
            labelOutput.Location = new System.Drawing.Point(20, 70);
            labelOutput.Size = new System.Drawing.Size(350, 23);
            labelOutput.Name = "labelOutput";
            labelOutput.Text = "Output will appear here";

            groupBoxUser.Controls.Add(textBoxInput);
            groupBoxUser.Controls.Add(buttonDisplay);
            groupBoxUser.Controls.Add(labelOutput);

            groupBoxCounter = new GroupBox();
            groupBoxCounter.Text = "Character Counter";
            groupBoxCounter.Location = new System.Drawing.Point(50, 200);
            groupBoxCounter.Size = new System.Drawing.Size(400, 150);

            textBoxCounter = new TextBox();
            textBoxCounter.Location = new System.Drawing.Point(20, 30);
            textBoxCounter.Size = new System.Drawing.Size(250, 23);
            textBoxCounter.Name = "textBoxCounter";

            buttonCount = new Button();
            buttonCount.Location = new System.Drawing.Point(290, 30);
            buttonCount.Size = new System.Drawing.Size(75, 23);
            buttonCount.Name = "buttonCount";
            buttonCount.Text = "Count";
            buttonCount.Click += new EventHandler(buttonCount_Click);

            labelCounter = new Label();
            labelCounter.Location = new System.Drawing.Point(20, 70);
            labelCounter.Size = new System.Drawing.Size(350, 23);
            labelCounter.Name = "labelCounter";
            labelCounter.Text = "Character count will appear here";

            groupBoxCounter.Controls.Add(textBoxCounter);
            groupBoxCounter.Controls.Add(buttonCount);
            groupBoxCounter.Controls.Add(labelCounter);

            this.Controls.Add(groupBoxUser);
            this.Controls.Add(groupBoxCounter);

            this.Text = "Task 5 - UI Containers";
            this.Size = new System.Drawing.Size(500, 400);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            labelOutput.Text = "You entered: " + input;
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string text = textBoxCounter.Text;
            labelCounter.Text = $"Character count: {text.Length}";
        }
    }
}
