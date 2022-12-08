namespace BookStore
{
    partial class UpdateBookOrAuthorForm
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
            this.lblUpdateBooks = new System.Windows.Forms.Label();
            this.lblUpdateAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblIdAuthor = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUpdateBooks
            // 
            this.lblUpdateBooks.AutoSize = true;
            this.lblUpdateBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBooks.Location = new System.Drawing.Point(112, 50);
            this.lblUpdateBooks.Name = "lblUpdateBooks";
            this.lblUpdateBooks.Size = new System.Drawing.Size(177, 29);
            this.lblUpdateBooks.TabIndex = 7;
            this.lblUpdateBooks.Text = "Update Books";
            // 
            // lblUpdateAuthor
            // 
            this.lblUpdateAuthor.AutoSize = true;
            this.lblUpdateAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAuthor.Location = new System.Drawing.Point(437, 50);
            this.lblUpdateAuthor.Name = "lblUpdateAuthor";
            this.lblUpdateAuthor.Size = new System.Drawing.Size(179, 29);
            this.lblUpdateAuthor.TabIndex = 8;
            this.lblUpdateAuthor.Text = "Update Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(117, 196);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 31);
            this.txtTitle.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(43, 199);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorId.Location = new System.Drawing.Point(20, 285);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(81, 25);
            this.lblAuthorId.TabIndex = 11;
            this.lblAuthorId.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(117, 279);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(202, 31);
            this.txtAuthor.TabIndex = 12;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(364, 199);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(72, 25);
            this.lblAuthorName.TabIndex = 13;
            this.lblAuthorName.Text = "Name";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(442, 193);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(202, 31);
            this.txtAuthorName.TabIndex = 14;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.AutoSize = true;
            this.btnBookUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookUpdate.Location = new System.Drawing.Point(117, 364);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnBookUpdate.TabIndex = 15;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.AutoSize = true;
            this.btnAuthorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorUpdate.Location = new System.Drawing.Point(442, 364);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnAuthorUpdate.TabIndex = 16;
            this.btnAuthorUpdate.Text = "Update";
            this.btnAuthorUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(718, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblIdAuthor
            // 
            this.lblIdAuthor.AutoSize = true;
            this.lblIdAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAuthor.Location = new System.Drawing.Point(402, 127);
            this.lblIdAuthor.Name = "lblIdAuthor";
            this.lblIdAuthor.Size = new System.Drawing.Size(34, 25);
            this.lblIdAuthor.TabIndex = 18;
            this.lblIdAuthor.Text = "ID";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(67, 127);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(34, 25);
            this.lblBookId.TabIndex = 18;
            this.lblBookId.Text = "ID";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(117, 121);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(202, 31);
            this.txtBookId.TabIndex = 9;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorId.Location = new System.Drawing.Point(442, 121);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(202, 31);
            this.txtAuthorId.TabIndex = 14;
            // 
            // UpdateBookOrAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 463);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblIdAuthor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAuthorUpdate);
            this.Controls.Add(this.btnBookUpdate);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthorId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblUpdateAuthor);
            this.Controls.Add(this.lblUpdateBooks);
            this.Name = "UpdateBookOrAuthorForm";
            this.Text = "UpdateBookOrAuthorForm";
            this.Load += new System.EventHandler(this.UpdateBookOrAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateBooks;
        private System.Windows.Forms.Label lblUpdateAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnAuthorUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblIdAuthor;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtAuthorId;
    }
}