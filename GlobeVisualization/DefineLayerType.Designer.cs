namespace GlobeVisualization
{
	partial class DefineLayerType
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && ( components != null ))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.gbLayerType = new System.Windows.Forms.GroupBox();
			this.rbtnDraped = new System.Windows.Forms.RadioButton();
			this.rbtnElevation = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbLayerType.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbLayerType
			// 
			this.gbLayerType.Controls.Add(this.label2);
			this.gbLayerType.Controls.Add(this.label1);
			this.gbLayerType.Controls.Add(this.rbtnElevation);
			this.gbLayerType.Controls.Add(this.rbtnDraped);
			this.gbLayerType.Location = new System.Drawing.Point(41, 28);
			this.gbLayerType.Name = "gbLayerType";
			this.gbLayerType.Size = new System.Drawing.Size(313, 158);
			this.gbLayerType.TabIndex = 0;
			this.gbLayerType.TabStop = false;
			this.gbLayerType.Text = "图层类型选择";
			// 
			// rbtnDraped
			// 
			this.rbtnDraped.AutoSize = true;
			this.rbtnDraped.Location = new System.Drawing.Point(57, 32);
			this.rbtnDraped.Name = "rbtnDraped";
			this.rbtnDraped.Size = new System.Drawing.Size(119, 16);
			this.rbtnDraped.TabIndex = 0;
			this.rbtnDraped.TabStop = true;
			this.rbtnDraped.Text = "将图层作为图像源";
			this.rbtnDraped.UseVisualStyleBackColor = true;
			// 
			// rbtnElevation
			// 
			this.rbtnElevation.AutoSize = true;
			this.rbtnElevation.Location = new System.Drawing.Point(57, 93);
			this.rbtnElevation.Name = "rbtnElevation";
			this.rbtnElevation.Size = new System.Drawing.Size(119, 16);
			this.rbtnElevation.TabIndex = 1;
			this.rbtnElevation.TabStop = true;
			this.rbtnElevation.Text = "将图层作为高程源";
			this.rbtnElevation.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "图层会被叠加到球表面";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(89, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "图层为其他图层提供高程数据";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(178, 219);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "确定";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(279, 219);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// DefineLayerType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 273);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.gbLayerType);
			this.Name = "DefineLayerType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "添加图层";
			this.gbLayerType.ResumeLayout(false);
			this.gbLayerType.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbLayerType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbtnElevation;
		private System.Windows.Forms.RadioButton rbtnDraped;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}