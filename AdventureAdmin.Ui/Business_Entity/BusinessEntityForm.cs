using AdventureAdmin.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventureAdmin.Ui.Business_Entity
{
    public partial class BusinessEntityForm : Form
    {
        private readonly AdventureWorksContext _context;
        public BusinessEntityForm(AdventureWorksContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BusinessEntityList_Load(object sender, EventArgs e)
        {
            Guardar.Text = "Guardar";
            Guardar.Click += Guardar_Click;
        }

        private async void Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                Guardar.Enabled = false;

                var businessEntity = new AdventureAdmin.Data.Models.BusinessEntity
                {
                    ModifiedDate = DateTime.Now
                };

                _context.BusinessEntities.Add(businessEntity);
                await _context.SaveChangesAsync();

                MessageBox.Show("Entidad de Negocio creada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Guardar.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            return true;
        }
    }
}
