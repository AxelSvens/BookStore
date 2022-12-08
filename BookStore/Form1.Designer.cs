namespace BookStore
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnReadAuthor = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnReadBook = new System.Windows.Forms.Button();
            this.btnGtDelete = new System.Windows.Forms.Button();
            this.btnGtAdd = new System.Windows.Forms.Button();
            this.btnGtRead = new System.Windows.Forms.Button();
            this.btnHsDelete = new System.Windows.Forms.Button();
            this.btnHsAdd = new System.Windows.Forms.Button();
            this.lblHs = new System.Windows.Forms.Label();
            this.lblGt = new System.Windows.Forms.Label();
            this.btnHsRead = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteAuthor, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateAuthor, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAddAuthor, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnReadAuthor, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteBook, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateBook, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddBook, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnReadBook, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnGtDelete, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGtAdd, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGtRead, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnHsDelete, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHsAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHs, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnHsRead, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 601);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.Location = new System.Drawing.Point(593, 470);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(154, 111);
            this.btnDeleteAuthor.TabIndex = 17;
            this.btnDeleteAuthor.Text = "Delete Authors";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.Location = new System.Drawing.Point(402, 470);
            this.btnUpdateAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(151, 111);
            this.btnUpdateAuthor.TabIndex = 16;
            this.btnUpdateAuthor.Text = "Update Authors";
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(211, 470);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(151, 111);
            this.btnAddAuthor.TabIndex = 15;
            this.btnAddAuthor.Text = "Add Authors";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnReadAuthor
            // 
            this.btnReadAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAuthor.Location = new System.Drawing.Point(20, 470);
            this.btnReadAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnReadAuthor.Name = "btnReadAuthor";
            this.btnReadAuthor.Size = new System.Drawing.Size(151, 111);
            this.btnReadAuthor.TabIndex = 14;
            this.btnReadAuthor.Text = "View All Authors";
            this.btnReadAuthor.UseVisualStyleBackColor = true;
            this.btnReadAuthor.Click += new System.EventHandler(this.btnReadAuthor_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(593, 320);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(20);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(154, 110);
            this.btnDeleteBook.TabIndex = 13;
            this.btnDeleteBook.Text = "Delete Books";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(402, 320);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(20);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(151, 110);
            this.btnUpdateBook.TabIndex = 12;
            this.btnUpdateBook.Text = "Update Books";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(211, 320);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(151, 110);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Add Books";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnReadBook
            // 
            this.btnReadBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadBook.Location = new System.Drawing.Point(20, 320);
            this.btnReadBook.Margin = new System.Windows.Forms.Padding(20);
            this.btnReadBook.Name = "btnReadBook";
            this.btnReadBook.Size = new System.Drawing.Size(151, 110);
            this.btnReadBook.TabIndex = 10;
            this.btnReadBook.Text = "View All Books";
            this.btnReadBook.UseVisualStyleBackColor = true;
            this.btnReadBook.Click += new System.EventHandler(this.btnReadBook_Click);
            // 
            // btnGtDelete
            // 
            this.btnGtDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGtDelete.Location = new System.Drawing.Point(593, 170);
            this.btnGtDelete.Margin = new System.Windows.Forms.Padding(20);
            this.btnGtDelete.Name = "btnGtDelete";
            this.btnGtDelete.Size = new System.Drawing.Size(154, 110);
            this.btnGtDelete.TabIndex = 9;
            this.btnGtDelete.Text = "Remove Books";
            this.btnGtDelete.UseVisualStyleBackColor = true;
            this.btnGtDelete.Click += new System.EventHandler(this.btnGtDelete_Click);
            // 
            // btnGtAdd
            // 
            this.btnGtAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGtAdd.Location = new System.Drawing.Point(402, 170);
            this.btnGtAdd.Margin = new System.Windows.Forms.Padding(20);
            this.btnGtAdd.Name = "btnGtAdd";
            this.btnGtAdd.Size = new System.Drawing.Size(151, 110);
            this.btnGtAdd.TabIndex = 8;
            this.btnGtAdd.Text = "Add Books";
            this.btnGtAdd.UseVisualStyleBackColor = true;
            this.btnGtAdd.Click += new System.EventHandler(this.btnGtAdd_Click);
            // 
            // btnGtRead
            // 
            this.btnGtRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGtRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGtRead.Location = new System.Drawing.Point(211, 170);
            this.btnGtRead.Margin = new System.Windows.Forms.Padding(20);
            this.btnGtRead.Name = "btnGtRead";
            this.btnGtRead.Size = new System.Drawing.Size(151, 110);
            this.btnGtRead.TabIndex = 7;
            this.btnGtRead.Text = "View Books";
            this.btnGtRead.UseVisualStyleBackColor = true;
            this.btnGtRead.Click += new System.EventHandler(this.btnGtRead_Click);
            // 
            // btnHsDelete
            // 
            this.btnHsDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHsDelete.Location = new System.Drawing.Point(593, 20);
            this.btnHsDelete.Margin = new System.Windows.Forms.Padding(20);
            this.btnHsDelete.Name = "btnHsDelete";
            this.btnHsDelete.Size = new System.Drawing.Size(154, 110);
            this.btnHsDelete.TabIndex = 6;
            this.btnHsDelete.Text = "Remove Books";
            this.btnHsDelete.UseVisualStyleBackColor = true;
            this.btnHsDelete.Click += new System.EventHandler(this.btnHsDelete_Click);
            // 
            // btnHsAdd
            // 
            this.btnHsAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHsAdd.Location = new System.Drawing.Point(402, 20);
            this.btnHsAdd.Margin = new System.Windows.Forms.Padding(20);
            this.btnHsAdd.Name = "btnHsAdd";
            this.btnHsAdd.Size = new System.Drawing.Size(151, 110);
            this.btnHsAdd.TabIndex = 5;
            this.btnHsAdd.Text = "Add Books";
            this.btnHsAdd.UseVisualStyleBackColor = true;
            this.btnHsAdd.Click += new System.EventHandler(this.btnHsAdd_Click);
            // 
            // lblHs
            // 
            this.lblHs.AutoSize = true;
            this.lblHs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHs.Location = new System.Drawing.Point(3, 0);
            this.lblHs.Name = "lblHs";
            this.lblHs.Size = new System.Drawing.Size(185, 150);
            this.lblHs.TabIndex = 1;
            this.lblHs.Text = "Halmstad";
            this.lblHs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGt
            // 
            this.lblGt.AutoSize = true;
            this.lblGt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGt.Location = new System.Drawing.Point(3, 150);
            this.lblGt.Name = "lblGt";
            this.lblGt.Size = new System.Drawing.Size(185, 150);
            this.lblGt.TabIndex = 3;
            this.lblGt.Text = "Göteborg";
            this.lblGt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHsRead
            // 
            this.btnHsRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHsRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHsRead.Location = new System.Drawing.Point(211, 20);
            this.btnHsRead.Margin = new System.Windows.Forms.Padding(20);
            this.btnHsRead.Name = "btnHsRead";
            this.btnHsRead.Size = new System.Drawing.Size(151, 110);
            this.btnHsRead.TabIndex = 4;
            this.btnHsRead.Text = "View Books";
            this.btnHsRead.UseVisualStyleBackColor = true;
            this.btnHsRead.Click += new System.EventHandler(this.btnHsRead_Click);
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(776, 3);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(510, 601);
            this.dgvView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGt;
        private System.Windows.Forms.Label lblHs;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnReadAuthor;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnReadBook;
        private System.Windows.Forms.Button btnGtDelete;
        private System.Windows.Forms.Button btnGtAdd;
        private System.Windows.Forms.Button btnGtRead;
        private System.Windows.Forms.Button btnHsDelete;
        private System.Windows.Forms.Button btnHsAdd;
        private System.Windows.Forms.Button btnHsRead;
        private System.Windows.Forms.DataGridView dgvView;
    }
}

