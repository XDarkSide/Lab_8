using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace lab_8
{
    public partial class Form1 : Form
    {
        karalashEntities DB = new karalashEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var query = from res in DB.Student
                        select new
                        {
                            res.first_name,
                            res.last_name,
                            res.phone_number,
                            res.email,
                            res.age
                        };

            dataGridView1.DataSource = query.ToList();
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Training> trainings = new List<Training>();
            trainings = DB.Training.ToList();

            Select_Training_Box.Items.Clear();

            foreach (Training training in trainings)
            {
                Select_Training_Box.Items.Add(training);
            }

            Select_Training_Box.DisplayMember = "training_topic";

            List<Coach> coaches = new List<Coach>();
            coaches = DB.Coach.ToList();

            Select_Coach_Box.Items.Clear();

            foreach (Coach coach in coaches)
            {
                Select_Coach_Box.Items.Add(coach);
            }

            Select_Coach_Box.DisplayMember = "last_name";
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string Error;

            try
            {
                if (!Validator.Check_Name(First_Name_Box.Text, out Error) || !Validator.Check_Name(Last_Name_Box.Text, out Error)) throw new Exception(Error);

                if (!Validator.Check_Phone_Number(Number_Phone_Box.Text, out Error)) throw new Exception(Error);

                if (!Validator.Check_Email(Email_Box.Text, out Error)) throw new Exception(Error);

                if (!Validator.Check_Age(Age_Box.Text, out Error)) throw new Exception(Error);

                if (!(Select_Training_Box.SelectedIndex > -1)) throw new Exception("Виберіть один з доступних тренінгів.");

                Training training = (Training) Select_Training_Box.SelectedItem;
                Register.ForeColor = Color.Black;

                DB.P_Add_Student(First_Name_Box.Text, Last_Name_Box.Text, Email_Box.Text, Number_Phone_Box.Text, Convert.ToInt32(Age_Box.Text), training.ID);
                Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Register.ForeColor = Color.Red;
            }

            void Clear()
            {
                First_Name_Box.Text = "";
                Last_Name_Box.Text = "";
                Number_Phone_Box.Text = "";
                Email_Box.Text = "";
                Age_Box.Text = "";
                Select_Training_Box.SelectedIndex = -1;
            }
        }

        private void Select_Coach_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Coach)e.ListItem).last_name;
            string firstname = ((Coach)e.ListItem).first_name;
            e.Value = lastname + " " + firstname;
        }

        private void Report1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Select_Coach_Box.SelectedIndex == -1) throw new Exception("Виберіть когось з доступних тренерів. ");

                string first_name = ((Coach)Select_Coach_Box.SelectedItem).first_name;
                string  last_name = ((Coach)Select_Coach_Box.SelectedItem).last_name;

                dataGridView1.DataSource =  DB.P_Select_Moduls_By_Coach(first_name, last_name);
                Register.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Register.ForeColor = Color.Red;
            }
        }
    }
}