using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarExercises
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExerciseObject upNext = xmlMethods.GetRandom();
            TempoBox.Text = upNext.Tempo;
            DescBox.Text = upNext.Description;
            NameBox.Text = upNext.NameOfExercise;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TempoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExerciseObject updated = new ExerciseObject();
            updated.NameOfExercise = NameBox.Text;
            updated.Tempo = TempoBox.Text;
            updated.Description = DescBox.Text;

            xmlMethods.UpdateExisting(updated);

        }

        private void SNEButton_Click(object sender, EventArgs e)
        {
            ExerciseObject newExercise = new ExerciseObject();
            newExercise.NameOfExercise = NameBox.Text;
            newExercise.Description = DescBox.Text;
            newExercise.Tempo = TempoBox.Text;
            
            xmlMethods.InsertObject(newExercise);

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
       {

       }
    }
}
