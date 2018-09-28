namespace CCTV_CameraCapture
{
    partial class CameraForm
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
            this.components = new System.ComponentModel.Container();
            this.lb_CameraView = new System.Windows.Forms.Label();
            this.ib_Frame = new Emgu.CV.UI.ImageBox();
            this.btn_StartStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ib_Frame)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CameraView
            // 
            this.lb_CameraView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_CameraView.AutoSize = true;
            this.lb_CameraView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CameraView.ForeColor = System.Drawing.Color.DimGray;
            this.lb_CameraView.Location = new System.Drawing.Point(11, 396);
            this.lb_CameraView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CameraView.Name = "lb_CameraView";
            this.lb_CameraView.Size = new System.Drawing.Size(99, 20);
            this.lb_CameraView.TabIndex = 3;
            this.lb_CameraView.Text = "Camera view";
            // 
            // ib_Frame
            // 
            this.ib_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ib_Frame.Location = new System.Drawing.Point(12, 12);
            this.ib_Frame.Name = "ib_Frame";
            this.ib_Frame.Size = new System.Drawing.Size(512, 373);
            this.ib_Frame.TabIndex = 2;
            this.ib_Frame.TabStop = false;
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StartStop.Location = new System.Drawing.Point(449, 396);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(75, 23);
            this.btn_StartStop.TabIndex = 4;
            this.btn_StartStop.Text = "Start";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 428);
            this.Controls.Add(this.btn_StartStop);
            this.Controls.Add(this.ib_Frame);
            this.Controls.Add(this.lb_CameraView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CameraForm";
            this.Text = "CCTV";
            ((System.ComponentModel.ISupportInitialize)(this.ib_Frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_CameraView;
        private Emgu.CV.UI.ImageBox ib_Frame;
        private System.Windows.Forms.Button btn_StartStop;
    }
}

