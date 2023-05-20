namespace C__Project
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.addRoom = new System.Windows.Forms.Button();
            this.editRoom = new System.Windows.Forms.Button();
            this.deletRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(578, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.textBox1.Location = new System.Drawing.Point(640, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.Print.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Location = new System.Drawing.Point(420, 70);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 3;
            this.Print.Text = "print";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // addRoom
            // 
            this.addRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.addRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoom.Location = new System.Drawing.Point(40, 70);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(75, 23);
            this.addRoom.TabIndex = 4;
            this.addRoom.Text = "Add Room";
            this.addRoom.UseVisualStyleBackColor = false;
            this.addRoom.Click += new System.EventHandler(this.button2_Click);
            // 
            // editRoom
            // 
            this.editRoom.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.editRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoom.Location = new System.Drawing.Point(135, 70);
            this.editRoom.Name = "editRoom";
            this.editRoom.Size = new System.Drawing.Size(75, 23);
            this.editRoom.TabIndex = 5;
            this.editRoom.Text = "Edit Room";
            this.editRoom.UseVisualStyleBackColor = true;
            // 
            // deletRoom
            // 
            this.deletRoom.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deletRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletRoom.Location = new System.Drawing.Point(245, 70);
            this.deletRoom.Name = "deletRoom";
            this.deletRoom.Size = new System.Drawing.Size(89, 23);
            this.deletRoom.TabIndex = 6;
            this.deletRoom.Text = "Delete Room";
            this.deletRoom.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 320);
            this.panel2.TabIndex = 7;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deletRoom);
            this.Controls.Add(this.editRoom);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.Button editRoom;
        private System.Windows.Forms.Button deletRoom;
        private System.Windows.Forms.Panel panel2;
    }
}