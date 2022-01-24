using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lstNote.AllowDrop = true;
        }
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            lstNote.Items.Add(txtNote.Text);
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            int characterLimit = txtNote.TextLength;
            label1.Text = "Remaining Characters : " + (txtNote.MaxLength - txtNote.TextLength).ToString();
            if (characterLimit == 140)
            {
                MessageBox.Show("Max karakter sayısına ulaştınız");
            }
        }
       
        private void lstNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstNote.SelectedItems.Count>0)
            {
                lstNote.DoDragDrop(lstNote.SelectedItem.ToString(), DragDropEffects.Move);
                lstNote.Items.Remove(lstNote.SelectedItem);
            }
        }
        private void lstNote_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void lstNote_DragDrop(object sender, DragEventArgs e)
        {
            lstNote.Items.Add(e.Data.GetData(DataFormats.Text));
        }

       
    }
}
