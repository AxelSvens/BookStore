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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadAuthor = new System.Windows.Forms.Button();
            this.btnDeleteBookOrAuthor = new System.Windows.Forms.Button();
            this.btnUpdateBookOrAuthor = new System.Windows.Forms.Button();
            this.btnAddBookOrAuthor = new System.Windows.Forms.Button();
            this.btnReadBook = new System.Windows.Forms.Button();
            this.btnGtDelete = new System.Windows.Forms.Button();
            this.btnGtAdd = new System.Windows.Forms.Button();
            this.btnGtRead = new System.Windows.Forms.Button();
            this.btnHsDelete = new System.Windows.Forms.Button();
            this.btnHsAdd = new System.Windows.Forms.Button();
            this.lblHs = new System.Windows.Forms.Label();
            this.lblGt = new System.Windows.Forms.Label();
            this.btnHsRead = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04045F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47977F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47977F));
            this.tableLayoutPanel3.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAuthor, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTitle, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(776, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 601F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(510, 601);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(69, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(215, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthor.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(290, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnReadAuthor, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteBookOrAuthor, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateBookOrAuthor, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddBookOrAuthor, 1, 2);
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
            // btnDeleteBookOrAuthor
            // 
            this.btnDeleteBookOrAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBookOrAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBookOrAuthor.Location = new System.Drawing.Point(593, 320);
            this.btnDeleteBookOrAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnDeleteBookOrAuthor.Name = "btnDeleteBookOrAuthor";
            this.btnDeleteBookOrAuthor.Size = new System.Drawing.Size(154, 110);
            this.btnDeleteBookOrAuthor.TabIndex = 13;
            this.btnDeleteBookOrAuthor.Text = "Delete Book Or Author";
            this.btnDeleteBookOrAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteBookOrAuthor.Click += new System.EventHandler(this.btnDeleteBookOrAuthor_Click);
            // 
            // btnUpdateBookOrAuthor
            // 
            this.btnUpdateBookOrAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateBookOrAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBookOrAuthor.Location = new System.Drawing.Point(402, 320);
            this.btnUpdateBookOrAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnUpdateBookOrAuthor.Name = "btnUpdateBookOrAuthor";
            this.btnUpdateBookOrAuthor.Size = new System.Drawing.Size(151, 110);
            this.btnUpdateBookOrAuthor.TabIndex = 12;
            this.btnUpdateBookOrAuthor.Text = "Update Book Or Author";
            this.btnUpdateBookOrAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateBookOrAuthor.Click += new System.EventHandler(this.btnUpdateBookOrAuthor_Click);
            // 
            // btnAddBookOrAuthor
            // 
            this.btnAddBookOrAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBookOrAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookOrAuthor.Location = new System.Drawing.Point(211, 320);
            this.btnAddBookOrAuthor.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddBookOrAuthor.Name = "btnAddBookOrAuthor";
            this.btnAddBookOrAuthor.Size = new System.Drawing.Size(151, 110);
            this.btnAddBookOrAuthor.TabIndex = 11;
            this.btnAddBookOrAuthor.Text = "Add Book Or Author";
            this.btnAddBookOrAuthor.UseVisualStyleBackColor = true;
            this.btnAddBookOrAuthor.Click += new System.EventHandler(this.btnAddBookOrAuthor_Click);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGt;
        private System.Windows.Forms.Label lblHs;
        private System.Windows.Forms.Button btnReadAuthor;
        private System.Windows.Forms.Button btnDeleteBookOrAuthor;
        private System.Windows.Forms.Button btnUpdateBookOrAuthor;
        private System.Windows.Forms.Button btnAddBookOrAuthor;
        private System.Windows.Forms.Button btnReadBook;
        private System.Windows.Forms.Button btnGtDelete;
        private System.Windows.Forms.Button btnGtAdd;
        private System.Windows.Forms.Button btnGtRead;
        private System.Windows.Forms.Button btnHsDelete;
        private System.Windows.Forms.Button btnHsAdd;
        private System.Windows.Forms.Button btnHsRead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
    }
}

