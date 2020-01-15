/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 15.01.2020
 * Time: 1:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FormsChart
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudA;
		private System.Windows.Forms.NumericUpDown nudF;
		private System.Windows.Forms.NumericUpDown nudB;
		private System.Windows.Forms.Button btDrawChart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudStep;
		private System.Windows.Forms.NumericUpDown nudMax;
		private System.Windows.Forms.NumericUpDown nudMin;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudA = new System.Windows.Forms.NumericUpDown();
			this.nudF = new System.Windows.Forms.NumericUpDown();
			this.nudB = new System.Windows.Forms.NumericUpDown();
			this.btDrawChart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudStep = new System.Windows.Forms.NumericUpDown();
			this.nudMax = new System.Windows.Forms.NumericUpDown();
			this.nudMin = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 88);
			this.label1.TabIndex = 0;
			this.label1.Text = "ЗАДАНИЕ: Создайте 2 формы. В первой должны распологаться компоненты для изменения" +
	" параметров функции. Во второй Chart. Построить график функции при разных параме" +
	"трах Ro=A/(F*i) + B";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "A ";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "F";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(11, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "i ";
			// 
			// nudA
			// 
			this.nudA.DecimalPlaces = 1;
			this.nudA.Location = new System.Drawing.Point(49, 18);
			this.nudA.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudA.Minimum = new decimal(new int[] {
			1000,
			0,
			0,
			-2147483648});
			this.nudA.Name = "nudA";
			this.nudA.Size = new System.Drawing.Size(82, 20);
			this.nudA.TabIndex = 0;
			this.nudA.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// nudF
			// 
			this.nudF.DecimalPlaces = 1;
			this.nudF.Location = new System.Drawing.Point(49, 42);
			this.nudF.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudF.Minimum = new decimal(new int[] {
			1000,
			0,
			0,
			-2147483648});
			this.nudF.Name = "nudF";
			this.nudF.Size = new System.Drawing.Size(82, 20);
			this.nudF.TabIndex = 1;
			this.nudF.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// nudB
			// 
			this.nudB.DecimalPlaces = 1;
			this.nudB.Location = new System.Drawing.Point(49, 66);
			this.nudB.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudB.Minimum = new decimal(new int[] {
			1000,
			0,
			0,
			-2147483648});
			this.nudB.Name = "nudB";
			this.nudB.Size = new System.Drawing.Size(82, 20);
			this.nudB.TabIndex = 2;
			// 
			// btDrawChart
			// 
			this.btDrawChart.Location = new System.Drawing.Point(12, 354);
			this.btDrawChart.Name = "btDrawChart";
			this.btDrawChart.Size = new System.Drawing.Size(305, 27);
			this.btDrawChart.TabIndex = 6;
			this.btDrawChart.Text = "Построить график";
			this.btDrawChart.UseVisualStyleBackColor = true;
			this.btDrawChart.Click += new System.EventHandler(this.btDrawChartClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudStep);
			this.groupBox1.Controls.Add(this.nudMax);
			this.groupBox1.Controls.Add(this.nudMin);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.nudB);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.nudF);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.nudA);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(9, 196);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 152);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры функции:";
			// 
			// nudStep
			// 
			this.nudStep.DecimalPlaces = 1;
			this.nudStep.Location = new System.Drawing.Point(199, 115);
			this.nudStep.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudStep.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			65536});
			this.nudStep.Name = "nudStep";
			this.nudStep.Size = new System.Drawing.Size(69, 20);
			this.nudStep.TabIndex = 5;
			this.nudStep.Value = new decimal(new int[] {
			1,
			0,
			0,
			65536});
			// 
			// nudMax
			// 
			this.nudMax.DecimalPlaces = 1;
			this.nudMax.Location = new System.Drawing.Point(124, 115);
			this.nudMax.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudMax.Minimum = new decimal(new int[] {
			1000,
			0,
			0,
			-2147483648});
			this.nudMax.Name = "nudMax";
			this.nudMax.Size = new System.Drawing.Size(69, 20);
			this.nudMax.TabIndex = 4;
			this.nudMax.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// nudMin
			// 
			this.nudMin.DecimalPlaces = 1;
			this.nudMin.Location = new System.Drawing.Point(49, 115);
			this.nudMin.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudMin.Minimum = new decimal(new int[] {
			1000,
			0,
			0,
			-2147483648});
			this.nudMin.Name = "nudMin";
			this.nudMin.Size = new System.Drawing.Size(69, 20);
			this.nudMin.TabIndex = 4;
			this.nudMin.Value = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(199, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "Step";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(124, 97);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 23);
			this.label9.TabIndex = 7;
			this.label9.Text = "Max";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(49, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Min";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(12, 68);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 18);
			this.label12.TabIndex = 1;
			this.label12.Text = "B";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(251, 41);
			this.label5.TabIndex = 5;
			this.label5.Text = "ПЕРВАЯ ФОРМА \"Параметры функции\"";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 393);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btDrawChart);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "TwinForms: Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
