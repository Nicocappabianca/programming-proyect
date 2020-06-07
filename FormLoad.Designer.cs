﻿namespace proyecto
{
    partial class FormLoad
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
            this.btnSend = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entryDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(61, 290);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(217, 40);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Enviar orden";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 159);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(288, 102);
            this.description.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripción de problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de producto";
            // 
            // entryDate
            // 
            this.entryDate.Location = new System.Drawing.Point(168, 27);
            this.entryDate.Name = "entryDate";
            this.entryDate.ReadOnly = true;
            this.entryDate.Size = new System.Drawing.Size(128, 20);
            this.entryDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha de ingreso";
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(12, 27);
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Size = new System.Drawing.Size(132, 20);
            this.orderId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Pedido";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.Items.AddRange(new object[] {
            "Computadora",
            "Notebook",
            "Tablet",
            "Celular",
            "Programacion III"});
            this.productType.Location = new System.Drawing.Point(12, 106);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(161, 21);
            this.productType.TabIndex = 22;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 342);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.label1);
            this.Name = "FormLoad";
            this.Text = "FormLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productType;
    }
}