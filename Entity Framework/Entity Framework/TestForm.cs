using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }



        private void buttonCreateDb_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //PersonContext context = new PersonContext();
            //var empList = context.Persons.OrderBy(c => c.FirstName).ToList();
            //Console.WriteLine(empList.Count);

            //Person people = new Person()
            //{
            //    Id = 123456,
            //    FirstName = "Hello",
            //    LastName = "World"
            //};
            //context.Persons.Add(people);
            //context.SaveChanges();
            //Console.ReadLine();

            var persons = PersonManager.GetAllItems();
        }
    }
}
