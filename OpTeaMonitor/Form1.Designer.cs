namespace OpTeaMonitor
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
            this.components = new System.ComponentModel.Container();
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.circularProgressBarRAM = new CircularProgressBar.CircularProgressBar();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circularProgressBarGPU = new CircularProgressBar.CircularProgressBar();
            this.GPU = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU)).BeginInit();
            this.SuspendLayout();
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(63, 41);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarCPU.ProgressWidth = 25;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPU.Size = new System.Drawing.Size(221, 220);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = "";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "";
            this.circularProgressBarCPU.TabIndex = 0;
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPU.Value = 68;
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // circularProgressBarRAM
            // 
            this.circularProgressBarRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarRAM.AnimationSpeed = 500;
            this.circularProgressBarRAM.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarRAM.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarRAM.InnerMargin = 2;
            this.circularProgressBarRAM.InnerWidth = -1;
            this.circularProgressBarRAM.Location = new System.Drawing.Point(357, 41);
            this.circularProgressBarRAM.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRAM.Name = "circularProgressBarRAM";
            this.circularProgressBarRAM.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarRAM.OuterMargin = -25;
            this.circularProgressBarRAM.OuterWidth = 26;
            this.circularProgressBarRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarRAM.ProgressWidth = 25;
            this.circularProgressBarRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarRAM.Size = new System.Drawing.Size(221, 220);
            this.circularProgressBarRAM.StartAngle = 270;
            this.circularProgressBarRAM.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRAM.SubscriptText = "";
            this.circularProgressBarRAM.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRAM.SuperscriptText = "";
            this.circularProgressBarRAM.TabIndex = 1;
            this.circularProgressBarRAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarRAM.Value = 68;
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "GPU";
            // 
            // circularProgressBarGPU
            // 
            this.circularProgressBarGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarGPU.AnimationSpeed = 500;
            this.circularProgressBarGPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarGPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarGPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarGPU.InnerMargin = 2;
            this.circularProgressBarGPU.InnerWidth = -1;
            this.circularProgressBarGPU.Location = new System.Drawing.Point(656, 41);
            this.circularProgressBarGPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarGPU.Name = "circularProgressBarGPU";
            this.circularProgressBarGPU.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarGPU.OuterMargin = -25;
            this.circularProgressBarGPU.OuterWidth = 26;
            this.circularProgressBarGPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarGPU.ProgressWidth = 25;
            this.circularProgressBarGPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarGPU.Size = new System.Drawing.Size(221, 220);
            this.circularProgressBarGPU.StartAngle = 270;
            this.circularProgressBarGPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarGPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarGPU.SubscriptText = "";
            this.circularProgressBarGPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarGPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarGPU.SuperscriptText = "";
            this.circularProgressBarGPU.TabIndex = 5;
            this.circularProgressBarGPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarGPU.Value = 68;
            // 
            // GPU
            // 
            this.GPU.CategoryName = "GPU Process Memory";
            this.GPU.CounterName = "Local Usage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.circularProgressBarGPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularProgressBarRAM);
            this.Controls.Add(this.circularProgressBarCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private System.Diagnostics.PerformanceCounter CPU;
        private CircularProgressBar.CircularProgressBar circularProgressBarRAM;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar circularProgressBarGPU;
        private System.Diagnostics.PerformanceCounter GPU;
    }
}

