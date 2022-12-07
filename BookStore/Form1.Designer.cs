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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblHs = new System.Windows.Forms.Label();
            this.lblGt = new System.Windows.Forms.Label();
            this.btnHsRead = new System.Windows.Forms.Button();
            this.btnHsAdd = new System.Windows.Forms.Button();
            this.btnHsDelete = new System.Windows.Forms.Button();
            this.btnGtRead = new System.Windows.Forms.Button();
            this.btnGtAdd = new System.Windows.Forms.Button();
            this.btnGtDelete = new System.Windows.Forms.Button();
            this.btnReadBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnReadAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
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
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.lblPrice, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAuthor, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(776, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(510, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 44);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(54, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 44);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(207, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(147, 44);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(360, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(147, 44);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblGt;
        private System.Windows.Forms.Label lblHs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
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
    }
}

