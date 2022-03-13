using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingObjects
{
    public partial class Canvas : UserControl
    {

        LivingObjectSpawner spawner;
        public Canvas()
        {
            InitializeComponent();
            spawner = new LivingObjectSpawner(this.Size);
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spawnTimer_Tick(object sender, EventArgs e)
        {
            var onj = spawner.SpawnRandomObject();
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.H)
            {
                healthBar1.Width -= 10;
            }
        }
    }
}
