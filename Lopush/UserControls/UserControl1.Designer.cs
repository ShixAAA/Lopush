namespace Lopush.UserControls
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label minCostForAgentLabel1;
            System.Windows.Forms.Label titleLabel1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDLabel2 = new System.Windows.Forms.Label();
            this.minCostForAgentLabel2 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel1 = new System.Windows.Forms.Label();
            minCostForAgentLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel1.Location = new System.Drawing.Point(201, 13);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(32, 35);
            iDLabel1.TabIndex = 7;
            iDLabel1.Text = "ID:";
            // 
            // minCostForAgentLabel1
            // 
            minCostForAgentLabel1.AutoSize = true;
            minCostForAgentLabel1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel1.Location = new System.Drawing.Point(201, 71);
            minCostForAgentLabel1.Name = "minCostForAgentLabel1";
            minCostForAgentLabel1.Size = new System.Drawing.Size(132, 35);
            minCostForAgentLabel1.TabIndex = 9;
            minCostForAgentLabel1.Text = "Min Cost For Agent:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel1.Location = new System.Drawing.Point(201, 129);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(45, 35);
            titleLabel1.TabIndex = 11;
            titleLabel1.Text = "Title:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lopush.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // iDLabel2
            // 
            this.iDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDLabel2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDLabel2.Location = new System.Drawing.Point(373, 13);
            this.iDLabel2.Name = "iDLabel2";
            this.iDLabel2.Size = new System.Drawing.Size(144, 35);
            this.iDLabel2.TabIndex = 8;
            this.iDLabel2.Text = "label1";
            // 
            // minCostForAgentLabel2
            // 
            this.minCostForAgentLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentLabel2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostForAgentLabel2.Location = new System.Drawing.Point(373, 71);
            this.minCostForAgentLabel2.Name = "minCostForAgentLabel2";
            this.minCostForAgentLabel2.Size = new System.Drawing.Size(144, 35);
            this.minCostForAgentLabel2.TabIndex = 10;
            this.minCostForAgentLabel2.Text = "label1";
            // 
            // titleLabel2
            // 
            this.titleLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleLabel2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel2.Location = new System.Drawing.Point(373, 129);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(144, 35);
            this.titleLabel2.TabIndex = 12;
            this.titleLabel2.Text = "label1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopush.DataModel.Product);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDLabel2);
            this.Controls.Add(minCostForAgentLabel1);
            this.Controls.Add(this.minCostForAgentLabel2);
            this.Controls.Add(titleLabel1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(525, 183);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label iDLabel2;
        private System.Windows.Forms.Label minCostForAgentLabel2;
        private System.Windows.Forms.Label titleLabel2;
    }
}
