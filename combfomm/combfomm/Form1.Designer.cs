namespace combfomm
{
    partial class Form1
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
            this.btn_setpen = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_pencolor = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_canvas = new System.Windows.Forms.Button();
            this.set_circle = new System.Windows.Forms.Button();
            this.cmb_combo = new System.Windows.Forms.ComboBox();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 327);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_setpen
            // 
            this.btn_setpen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setpen.Location = new System.Drawing.Point(12, 12);
            this.btn_setpen.Name = "btn_setpen";
            this.btn_setpen.Size = new System.Drawing.Size(114, 44);
            this.btn_setpen.TabIndex = 0;
            this.btn_setpen.Text = "Set Pen";
            this.btn_setpen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_setpen.UseVisualStyleBackColor = true;
            this.btn_setpen.Click += new System.EventHandler(this.btn_pencolor_Click);
            // 
            // btn_square
            // 
            this.btn_square.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_square.Location = new System.Drawing.Point(12, 62);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(114, 42);
            this.btn_square.TabIndex = 1;
            this.btn_square.Text = "Square";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_pencolor
            // 
            this.btn_pencolor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pencolor.Location = new System.Drawing.Point(204, 12);
            this.btn_pencolor.Name = "btn_pencolor";
            this.btn_pencolor.Size = new System.Drawing.Size(123, 44);
            this.btn_pencolor.TabIndex = 2;
            this.btn_pencolor.Text = "Pen color";
            this.btn_pencolor.UseVisualStyleBackColor = true;
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rectangle.Location = new System.Drawing.Point(204, 62);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(136, 43);
            this.btn_rectangle.TabIndex = 3;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_canvas
            // 
            this.btn_canvas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canvas.Location = new System.Drawing.Point(402, 12);
            this.btn_canvas.Name = "btn_canvas";
            this.btn_canvas.Size = new System.Drawing.Size(90, 44);
            this.btn_canvas.TabIndex = 4;
            this.btn_canvas.Text = "Canvas";
            this.btn_canvas.UseVisualStyleBackColor = true;
            this.btn_canvas.Click += new System.EventHandler(this.btn_canvas_Click);
            // 
            // set_circle
            // 
            this.set_circle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_circle.Location = new System.Drawing.Point(402, 62);
            this.set_circle.Name = "set_circle";
            this.set_circle.Size = new System.Drawing.Size(90, 43);
            this.set_circle.TabIndex = 5;
            this.set_circle.Text = "Circle";
            this.set_circle.UseVisualStyleBackColor = true;
            this.set_circle.Click += new System.EventHandler(this.set_circle_Click);
            // 
            // cmb_combo
            // 
            this.cmb_combo.FormattingEnabled = true;
            this.cmb_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_combo.Location = new System.Drawing.Point(569, 26);
            this.cmb_combo.Name = "cmb_combo";
            this.cmb_combo.Size = new System.Drawing.Size(146, 24);
            this.cmb_combo.TabIndex = 6;
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(569, 62);
            this.txt_ShapeSize.Multiline = true;
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(146, 42);
            this.txt_ShapeSize.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ShapeSize);
            this.Controls.Add(this.cmb_combo);
            this.Controls.Add(this.set_circle);
            this.Controls.Add(this.btn_canvas);
            this.Controls.Add(this.btn_rectangle);
            this.Controls.Add(this.btn_pencolor);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_setpen);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "ComboPaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_setpen;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_pencolor;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_canvas;
        private System.Windows.Forms.Button set_circle;
        private System.Windows.Forms.ComboBox cmb_combo;
        private System.Windows.Forms.TextBox txt_ShapeSize;
    }
}

