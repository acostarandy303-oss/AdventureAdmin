using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventureAdmin.Ui.Business_Entity
{
    public partial class BusinessEntityList : Form
    {
        public BusinessEntityList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BusinessEntity = Program.ServiceProvider.GetRequiredService<BusinessEntityForm>();
            BusinessEntity.ShowDialog();

        }
    }
}
