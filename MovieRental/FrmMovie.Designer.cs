namespace MovieRental
{
    partial class frmMovie
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
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.lblSearchMov = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMoviePrice = new System.Windows.Forms.Label();
            this.lblMovieAvail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(96, 40);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(146, 20);
            this.txtSearchMovie.TabIndex = 2;
            // 
            // lblSearchMov
            // 
            this.lblSearchMov.AutoSize = true;
            this.lblSearchMov.Location = new System.Drawing.Point(12, 43);
            this.lblSearchMov.Name = "lblSearchMov";
            this.lblSearchMov.Size = new System.Drawing.Size(78, 13);
            this.lblSearchMov.TabIndex = 3;
            this.lblSearchMov.Text = "Search Movies";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(12, 102);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(38, 13);
            this.lblMovieName.TabIndex = 5;
            this.lblMovieName.Text = "Name:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Location = new System.Drawing.Point(12, 135);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(39, 13);
            this.lblMovieGenre.TabIndex = 6;
            this.lblMovieGenre.Text = "Genre:";
            // 
            // lblMoviePrice
            // 
            this.lblMoviePrice.AutoSize = true;
            this.lblMoviePrice.Location = new System.Drawing.Point(12, 165);
            this.lblMoviePrice.Name = "lblMoviePrice";
            this.lblMoviePrice.Size = new System.Drawing.Size(37, 13);
            this.lblMoviePrice.TabIndex = 7;
            this.lblMoviePrice.Text = "Price: ";
            // 
            // lblMovieAvail
            // 
            this.lblMovieAvail.AutoSize = true;
            this.lblMovieAvail.Location = new System.Drawing.Point(12, 200);
            this.lblMovieAvail.Name = "lblMovieAvail";
            this.lblMovieAvail.Size = new System.Drawing.Size(62, 13);
            this.lblMovieAvail.TabIndex = 8;
            this.lblMovieAvail.Text = "Availability: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(673, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMovieAvail);
            this.Controls.Add(this.lblMoviePrice);
            this.Controls.Add(this.lblMovieGenre);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblSearchMov);
            this.Controls.Add(this.txtSearchMovie);
            this.Name = "frmMovie";
            this.Text = "Movie Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Label lblSearchMov;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMoviePrice;
        private System.Windows.Forms.Label lblMovieAvail;
        private System.Windows.Forms.Button button1;
    }
}

