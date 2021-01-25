
namespace GATES
{
    partial class NewGateForm
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
            this.cmbGateType = new MetroFramework.Controls.MetroComboBox();
            this.lblGateType = new MetroFramework.Controls.MetroLabel();
            this.cmbInputbit = new MetroFramework.Controls.MetroComboBox();
            this.cmbOutputbit = new MetroFramework.Controls.MetroComboBox();
            this.lblInputBit = new MetroFramework.Controls.MetroLabel();
            this.lblOutputBit = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbInputBit2 = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbGateType
            // 
            this.cmbGateType.DisplayMember = "negus";
            this.cmbGateType.FormattingEnabled = true;
            this.cmbGateType.ItemHeight = 23;
            this.cmbGateType.Items.AddRange(new object[] {
            "AND",
            "NAND",
            "NOR",
            "NOT",
            "OR",
            "XNOR",
            "XOR"});
            this.cmbGateType.Location = new System.Drawing.Point(60, 108);
            this.cmbGateType.Name = "cmbGateType";
            this.cmbGateType.Size = new System.Drawing.Size(196, 29);
            this.cmbGateType.Sorted = true;
            this.cmbGateType.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbGateType.TabIndex = 2;
            this.cmbGateType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbGateType.UseSelectable = true;
            // 
            // lblGateType
            // 
            this.lblGateType.AutoSize = true;
            this.lblGateType.Location = new System.Drawing.Point(125, 77);
            this.lblGateType.Name = "lblGateType";
            this.lblGateType.Size = new System.Drawing.Size(67, 19);
            this.lblGateType.TabIndex = 3;
            this.lblGateType.Text = "Gate Type";
            this.lblGateType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbInputbit
            // 
            this.cmbInputbit.FormattingEnabled = true;
            this.cmbInputbit.ItemHeight = 23;
            this.cmbInputbit.Location = new System.Drawing.Point(61, 199);
            this.cmbInputbit.Name = "cmbInputbit";
            this.cmbInputbit.Size = new System.Drawing.Size(196, 29);
            this.cmbInputbit.Sorted = true;
            this.cmbInputbit.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbInputbit.TabIndex = 4;
            this.cmbInputbit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbInputbit.UseSelectable = true;
            // 
            // cmbOutputbit
            // 
            this.cmbOutputbit.FormattingEnabled = true;
            this.cmbOutputbit.ItemHeight = 23;
            this.cmbOutputbit.Location = new System.Drawing.Point(60, 355);
            this.cmbOutputbit.Name = "cmbOutputbit";
            this.cmbOutputbit.Size = new System.Drawing.Size(196, 29);
            this.cmbOutputbit.Sorted = true;
            this.cmbOutputbit.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbOutputbit.TabIndex = 5;
            this.cmbOutputbit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbOutputbit.UseSelectable = true;
            // 
            // lblInputBit
            // 
            this.lblInputBit.AutoSize = true;
            this.lblInputBit.Location = new System.Drawing.Point(131, 177);
            this.lblInputBit.Name = "lblInputBit";
            this.lblInputBit.Size = new System.Drawing.Size(57, 19);
            this.lblInputBit.TabIndex = 6;
            this.lblInputBit.Text = "Input Bit";
            this.lblInputBit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblOutputBit
            // 
            this.lblOutputBit.AutoSize = true;
            this.lblOutputBit.Location = new System.Drawing.Point(124, 333);
            this.lblOutputBit.Name = "lblOutputBit";
            this.lblOutputBit.Size = new System.Drawing.Size(69, 19);
            this.lblOutputBit.TabIndex = 7;
            this.lblOutputBit.Text = "Output Bit";
            this.lblOutputBit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 241);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Input Bit 2";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbInputBit2
            // 
            this.cmbInputBit2.FormattingEnabled = true;
            this.cmbInputBit2.ItemHeight = 23;
            this.cmbInputBit2.Location = new System.Drawing.Point(61, 263);
            this.cmbInputBit2.Name = "cmbInputBit2";
            this.cmbInputBit2.Size = new System.Drawing.Size(196, 29);
            this.cmbInputBit2.Sorted = true;
            this.cmbInputBit2.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbInputBit2.TabIndex = 8;
            this.cmbInputBit2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbInputBit2.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.Location = new System.Drawing.Point(84, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 65);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NewGateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 506);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbInputBit2);
            this.Controls.Add(this.lblOutputBit);
            this.Controls.Add(this.lblInputBit);
            this.Controls.Add(this.cmbOutputbit);
            this.Controls.Add(this.cmbInputbit);
            this.Controls.Add(this.lblGateType);
            this.Controls.Add(this.cmbGateType);
            this.MaximizeBox = false;
            this.Name = "NewGateForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "New Gate";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.NewGateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbGateType;
        private MetroFramework.Controls.MetroLabel lblGateType;
        private MetroFramework.Controls.MetroComboBox cmbInputbit;
        private MetroFramework.Controls.MetroComboBox cmbOutputbit;
        private MetroFramework.Controls.MetroLabel lblInputBit;
        private MetroFramework.Controls.MetroLabel lblOutputBit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbInputBit2;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}