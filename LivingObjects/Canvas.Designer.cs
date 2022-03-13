namespace LivingObjects
{
    partial class Canvas
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spawnTimer = new System.Windows.Forms.Timer(this.components);
            this.healthBar1 = new LivingObjects.HealthBar();
            this.SuspendLayout();
            // 
            // spawnTimer
            // 
            this.spawnTimer.Tick += new System.EventHandler(this.spawnTimer_Tick);
            // 
            // healthBar1
            // 
            this.healthBar1.BackColor = System.Drawing.Color.Green;
            this.healthBar1.Location = new System.Drawing.Point(3, 3);
            this.healthBar1.Name = "healthBar1";
            this.healthBar1.Size = new System.Drawing.Size(894, 69);
            this.healthBar1.TabIndex = 0;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.healthBar1);
            this.DoubleBuffered = true;
            this.Name = "Canvas";
            this.Size = new System.Drawing.Size(900, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Canvas_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer spawnTimer;
        private HealthBar healthBar1;
    }
}
