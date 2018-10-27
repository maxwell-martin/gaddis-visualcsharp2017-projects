using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal("Regular Animal");
            ShowAnimalInfo(animal);
        }

        private void createDogButton_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("Johnny");
            MessageBox.Show("Dog name: " + dog.Name);
            ShowAnimalInfo(dog);
        }

        private void createCatButton_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("Sally");
            MessageBox.Show("Cat name: " + cat.Name);
            ShowAnimalInfo(cat);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
