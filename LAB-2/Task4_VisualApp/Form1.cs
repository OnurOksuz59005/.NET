using System;
using System.Windows.Forms;

namespace Task4_VisualApp
{
    public partial class Form1 : Form
    {
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button buttonGreet;
        private Label labelGreeting;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            textBoxName = new TextBox();
            textBoxName.Location = new System.Drawing.Point(150, 50);
            textBoxName.Size = new System.Drawing.Size(200, 23);
            textBoxName.Name = "textBoxName";

            textBoxSurname = new TextBox();
            textBoxSurname.Location = new System.Drawing.Point(150, 90);
            textBoxSurname.Size = new System.Drawing.Size(200, 23);
            textBoxSurname.Name = "textBoxSurname";

            buttonGreet = new Button();
            buttonGreet.Location = new System.Drawing.Point(150, 130);
            buttonGreet.Size = new System.Drawing.Size(75, 23);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Text = "Greet";
            buttonGreet.Click += new EventHandler(buttonGreet_Click);

            labelGreeting = new Label();
            labelGreeting.Location = new System.Drawing.Point(150, 170);
            labelGreeting.Size = new System.Drawing.Size(300, 23);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Text = "Greeting will appear here";

            Label labelName = new Label();
            labelName.Location = new System.Drawing.Point(50, 50);
            labelName.Size = new System.Drawing.Size(100, 23);
            labelName.Text = "First Name:";

            Label labelSurname = new Label();
            labelSurname.Location = new System.Drawing.Point(50, 90);
            labelSurname.Size = new System.Drawing.Size(100, 23);
            labelSurname.Text = "Surname:";

            this.Controls.Add(labelName);
            this.Controls.Add(textBoxName);
            this.Controls.Add(labelSurname);
            this.Controls.Add(textBoxSurname);
            this.Controls.Add(buttonGreet);
            this.Controls.Add(labelGreeting);

            this.Text = "Task 4 - Visual Application";
            this.Size = new System.Drawing.Size(500, 300);
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            string firstName = textBoxName.Text;
            string surname = textBoxSurname.Text;
            labelGreeting.Text = $"Hello, {firstName} {surname}!";
        }
    }
}
