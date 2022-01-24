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
    public partial class Kanban : Form
    {
        public Kanban()
        {
            InitializeComponent();
        }

        private void addFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote AddForm = new AddNote();
            string Name = Microsoft.VisualBasic.Interaction.InputBox("Please Enter Your Task Name Like TODO,DOING OR DONE");

            AddForm.Text = Name;
            if (Name=="TODO" || Name=="DOING"||Name=="DONE")
            {
                if (Name == "TODO")
                {
                    AddForm.BackColor = Color.MistyRose;
                }
                else if (Name == "DOING")
                {
                    AddForm.BackColor = Color.PowderBlue;
                }
                else if (Name == "DONE")
                {
                    AddForm.BackColor = Color.LightGreen;
                }
                AddForm.MdiParent = this;
                AddForm.Show();
            }
            else
            {
                MessageBox.Show("Your Task Name is False, Please Add Form Again");
            }
        }

        private void editFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
