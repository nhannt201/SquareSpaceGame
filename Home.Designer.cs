namespace NoelGame
{
    partial class Home
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
            this.users = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.thong1 = new System.Windows.Forms.PictureBox();
            this.thong2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.users.Location = new System.Drawing.Point(348, 394);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(158, 212);
            this.users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.users.TabIndex = 0;
            this.users.TabStop = false;
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rock.Location = new System.Drawing.Point(1537, 444);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(146, 213);
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            // 
            // thong1
            // 
            this.thong1.BackColor = System.Drawing.Color.Green;
            this.thong1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thong1.Location = new System.Drawing.Point(1547, 311);
            this.thong1.Name = "thong1";
            this.thong1.Size = new System.Drawing.Size(180, 205);
            this.thong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thong1.TabIndex = 2;
            this.thong1.TabStop = false;
            // 
            // thong2
            // 
            this.thong2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.thong2.Location = new System.Drawing.Point(1772, 206);
            this.thong2.Name = "thong2";
            this.thong2.Size = new System.Drawing.Size(241, 310);
            this.thong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thong2.TabIndex = 3;
            this.thong2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1889, 470);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.MintCream;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbScore.Location = new System.Drawing.Point(28, 22);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(189, 60);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "Score: 0";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1464, 829);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.users);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.thong1);
            this.Controls.Add(this.thong2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square Game";
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox users;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox thong1;
        private System.Windows.Forms.PictureBox thong2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbScore;
    }
}
