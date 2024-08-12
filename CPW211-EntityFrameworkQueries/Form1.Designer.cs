namespace CPW211_EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectAllVendors = new Button();
            btnAllCaliforniaVendors = new Button();
            btnSelectSpecificColumns = new Button();
            btnMiscQueries = new Button();
            btnVendorsAndInvoices = new Button();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(50, 39);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(180, 42);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * FROM Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnAllCaliforniaVendors
            // 
            btnAllCaliforniaVendors.Location = new Point(50, 116);
            btnAllCaliforniaVendors.Name = "btnAllCaliforniaVendors";
            btnAllCaliforniaVendors.Size = new Size(464, 39);
            btnAllCaliforniaVendors.TabIndex = 1;
            btnAllCaliforniaVendors.Text = "Select * From Vendors Where VendorState = 'CA' OrderBy VendorName ASC";
            btnAllCaliforniaVendors.UseVisualStyleBackColor = true;
            btnAllCaliforniaVendors.Click += btnAllCaliforniaVendors_Click;
            // 
            // btnSelectSpecificColumns
            // 
            btnSelectSpecificColumns.Location = new Point(50, 188);
            btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            btnSelectSpecificColumns.Size = new Size(464, 42);
            btnSelectSpecificColumns.TabIndex = 2;
            btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState\r\nFROM Vendors\r\n";
            btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            btnSelectSpecificColumns.Click += btnSelectSpecificColumns_Click;
            // 
            // btnMiscQueries
            // 
            btnMiscQueries.Location = new Point(62, 271);
            btnMiscQueries.Name = "btnMiscQueries";
            btnMiscQueries.Size = new Size(267, 97);
            btnMiscQueries.TabIndex = 3;
            btnMiscQueries.Text = "Misc. Queries";
            btnMiscQueries.UseVisualStyleBackColor = true;
            btnMiscQueries.Click += btnMiscQueries_Click;
            // 
            // btnVendorsAndInvoices
            // 
            btnVendorsAndInvoices.Location = new Point(384, 273);
            btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            btnVendorsAndInvoices.Size = new Size(249, 95);
            btnVendorsAndInvoices.TabIndex = 4;
            btnVendorsAndInvoices.Text = "Select Vendors with their Invoices";
            btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            btnVendorsAndInvoices.Click += btnVendorsAndInvoices_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVendorsAndInvoices);
            Controls.Add(btnMiscQueries);
            Controls.Add(btnSelectSpecificColumns);
            Controls.Add(btnAllCaliforniaVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliforniaVendors;
        private Button btnSelectSpecificColumns;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}
