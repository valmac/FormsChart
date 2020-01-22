/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 15.01.2020
 * Time: 1:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudA;
		private System.Windows.Forms.NumericUpDown nudB;
		private System.Windows.Forms.Button btDrawChart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudA = new System.Windows.Forms.NumericUpDown();
			this.nudB = new System.Windows.Forms.NumericUpDown();
			this.btDrawChart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 143);
			this.label1.TabIndex = 0;
			this.label1.Text = string.Concat(
				"ЗАДАНИЕ:\n",
				"Создайте 2 формы. В первой должны располагаться компоненты для изменения параметров функции.\n",
				"Во второй Chart.\n",
				"Построить графики функции при разных параметрах:\n",
				"Ro=A/Fi + B\n",
				"Ro это греческая буква.\n",
				"Fi это тоже греческа буква.\n",
				"A и B это параметры числовые.\n",
				"Fi изменяется от 0 до 360");
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(14, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "A ";
			// 
			// nudA
			// 
			this.nudA.DecimalPlaces = 1;
			this.nudA.Location = new System.Drawing.Point(14, 73);
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
			1000,
			0,
			0,
			0});
			// 
			// nudB
			// 
			this.nudB.DecimalPlaces = 1;
			this.nudB.Location = new System.Drawing.Point(172, 73);
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
			this.nudB.Value = new decimal(new int[] {
			1000,
			0,
			0,
			0});
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
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nudB);
			this.groupBox1.Controls.Add(this.nudA);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(9, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 138);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры функции:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(33, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ro=A/Fi + B";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(172, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 20);
			this.label12.TabIndex = 1;
			this.label12.Text = "B";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(9, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(316, 41);
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
			this.Text = "FormsChart: Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
