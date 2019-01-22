using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CodeProjectWizardDemoo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Gui.Wizard.Wizard wizard1;
		private Gui.Wizard.WizardPage wizardPage1;
		private Gui.Wizard.WizardPage wizardPage3;
		private Gui.Wizard.InfoPage infoPage1;
		private Gui.Wizard.Header header1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private Gui.Wizard.Header header2;
		private System.Windows.Forms.ProgressBar pbPPP;
		private System.Windows.Forms.Timer timPPP;
		private System.Windows.Forms.Label lblPPP;
		private Gui.Wizard.WizardPage wpPPP;
		private Gui.Wizard.WizardPage wpButtonJump;
		private Gui.Wizard.Header header3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private Gui.Wizard.WizardPage wpValidationDemo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPostCode;
		private System.Windows.Forms.TextBox txtStreetAnswer;
		private System.Windows.Forms.TextBox txtTownAnswer;
		private System.Windows.Forms.TextBox txtPostCodeAnswer;
		private System.Windows.Forms.Label label5;
		private Gui.Wizard.Header hdrValidationDemo;
		private System.Windows.Forms.Button btnQuickFill;
		private Gui.Wizard.InfoContainer infoContainer1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Gui.Wizard.WizardPage wizardPage4;
		private Gui.Wizard.Header header4;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private Gui.Wizard.WizardPage wpAlternateFinish;
		private Gui.Wizard.InfoContainer infoContainer2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Gui.Wizard.WizardPage wpChooseRoute;
		private Gui.Wizard.Header hdrChooseRoute;
		private System.Windows.Forms.RadioButton radFullDemo;
		private System.Windows.Forms.RadioButton radQuickDemo;
		private Gui.Wizard.WizardPage wpLicenceValidate;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.wizard1 = new Gui.Wizard.Wizard();
			this.wizardPage1 = new Gui.Wizard.WizardPage();
			this.infoContainer1 = new Gui.Wizard.InfoContainer();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.wizardPage3 = new Gui.Wizard.WizardPage();
			this.infoPage1 = new Gui.Wizard.InfoPage();
			this.wizardPage4 = new Gui.Wizard.WizardPage();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.header4 = new Gui.Wizard.Header();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.wpButtonJump = new Gui.Wizard.WizardPage();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.header3 = new Gui.Wizard.Header();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.wpPPP = new Gui.Wizard.WizardPage();
			this.lblPPP = new System.Windows.Forms.Label();
			this.header2 = new Gui.Wizard.Header();
			this.pbPPP = new System.Windows.Forms.ProgressBar();
			this.wpValidationDemo = new Gui.Wizard.WizardPage();
			this.hdrValidationDemo = new Gui.Wizard.Header();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtStreetAnswer = new System.Windows.Forms.TextBox();
			this.btnQuickFill = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTown = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPostCode = new System.Windows.Forms.TextBox();
			this.txtTownAnswer = new System.Windows.Forms.TextBox();
			this.txtPostCodeAnswer = new System.Windows.Forms.TextBox();
			this.wpLicenceValidate = new Gui.Wizard.WizardPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.header1 = new Gui.Wizard.Header();
			this.wpAlternateFinish = new Gui.Wizard.WizardPage();
			this.infoContainer2 = new Gui.Wizard.InfoContainer();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.wpChooseRoute = new Gui.Wizard.WizardPage();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.radFullDemo = new System.Windows.Forms.RadioButton();
			this.hdrChooseRoute = new Gui.Wizard.Header();
			this.radQuickDemo = new System.Windows.Forms.RadioButton();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.timPPP = new System.Windows.Forms.Timer(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.wizard1.SuspendLayout();
			this.wizardPage1.SuspendLayout();
			this.infoContainer1.SuspendLayout();
			this.wizardPage3.SuspendLayout();
			this.wizardPage4.SuspendLayout();
			this.wpButtonJump.SuspendLayout();
			this.wpPPP.SuspendLayout();
			this.wpValidationDemo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.wpLicenceValidate.SuspendLayout();
			this.wpAlternateFinish.SuspendLayout();
			this.infoContainer2.SuspendLayout();
			this.wpChooseRoute.SuspendLayout();
			this.SuspendLayout();
			// 
			// wizard1
			// 
			this.wizard1.Controls.Add(this.wizardPage3);
			this.wizard1.Controls.Add(this.wizardPage4);
			this.wizard1.Controls.Add(this.wpButtonJump);
			this.wizard1.Controls.Add(this.wpPPP);
			this.wizard1.Controls.Add(this.wpValidationDemo);
			this.wizard1.Controls.Add(this.wpLicenceValidate);
			this.wizard1.Controls.Add(this.wpAlternateFinish);
			this.wizard1.Controls.Add(this.wpChooseRoute);
			this.wizard1.Controls.Add(this.wizardPage1);
			this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizard1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wizard1.Location = new System.Drawing.Point(0, 0);
			this.wizard1.Name = "wizard1";
			this.wizard1.Pages.AddRange(new Gui.Wizard.WizardPage[] {
																		this.wizardPage1,
																		this.wpChooseRoute,
																		this.wpAlternateFinish,
																		this.wpLicenceValidate,
																		this.wpValidationDemo,
																		this.wpPPP,
																		this.wpButtonJump,
																		this.wizardPage4,
																		this.wizardPage3});
			this.wizard1.Size = new System.Drawing.Size(428, 305);
			this.wizard1.TabIndex = 0;
			this.wizard1.CloseFromCancel += new System.ComponentModel.CancelEventHandler(this.wizard1_CloseFromCancel);
			// 
			// wizardPage1
			// 
			this.wizardPage1.Controls.Add(this.infoContainer1);
			this.wizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardPage1.IsFinishPage = false;
			this.wizardPage1.Location = new System.Drawing.Point(0, 0);
			this.wizardPage1.Name = "wizardPage1";
			this.wizardPage1.Size = new System.Drawing.Size(428, 257);
			this.wizardPage1.TabIndex = 1;
			// 
			// infoContainer1
			// 
			this.infoContainer1.BackColor = System.Drawing.Color.White;
			this.infoContainer1.Controls.Add(this.label8);
			this.infoContainer1.Controls.Add(this.pictureBox2);
			this.infoContainer1.Controls.Add(this.label7);
			this.infoContainer1.Controls.Add(this.pictureBox1);
			this.infoContainer1.Controls.Add(this.label6);
			this.infoContainer1.Controls.Add(this.label10);
			this.infoContainer1.Controls.Add(this.pictureBox4);
			this.infoContainer1.Controls.Add(this.label11);
			this.infoContainer1.Controls.Add(this.label14);
			this.infoContainer1.Controls.Add(this.pictureBox7);
			this.infoContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infoContainer1.Image = ((System.Drawing.Image)(resources.GetObject("infoContainer1.Image")));
			this.infoContainer1.Location = new System.Drawing.Point(0, 0);
			this.infoContainer1.Name = "infoContainer1";
			this.infoContainer1.PageTitle = "Welcome to the / Completing the <Title> Wizard";
			this.infoContainer1.Size = new System.Drawing.Size(428, 257);
			this.infoContainer1.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(192, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(232, 28);
			this.label8.TabIndex = 12;
			this.label8.Text = "BugFix. Enforces controls only contained in WizardPages";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(172, 160);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 16);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(192, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(232, 60);
			this.label7.TabIndex = 10;
			this.label7.Text = "New InfoContainer control provides an InfoPage look and feel as a container to de" +
				"sign windows controls into.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(172, 192);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(172, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(252, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "And v1 enhancements. ";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label10.Location = new System.Drawing.Point(192, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(232, 16);
			this.label10.TabIndex = 12;
			this.label10.Text = "Allows multiple finish pages";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(172, 76);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label11.Location = new System.Drawing.Point(172, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(252, 16);
			this.label11.TabIndex = 8;
			this.label11.Text = "Now with v1.1 enhancements. ";
			// 
			// wizardPage3
			// 
			this.wizardPage3.Controls.Add(this.infoPage1);
			this.wizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardPage3.IsFinishPage = true;
			this.wizardPage3.Location = new System.Drawing.Point(0, 0);
			this.wizardPage3.Name = "wizardPage3";
			this.wizardPage3.Size = new System.Drawing.Size(428, 257);
			this.wizardPage3.TabIndex = 3;
			this.wizardPage3.ShowFromNext += new System.EventHandler(this.wizardPage3_ShowFromNext);
			// 
			// infoPage1
			// 
			this.infoPage1.BackColor = System.Drawing.Color.White;
			this.infoPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infoPage1.Image = ((System.Drawing.Image)(resources.GetObject("infoPage1.Image")));
			this.infoPage1.Location = new System.Drawing.Point(0, 0);
			this.infoPage1.Name = "infoPage1";
			this.infoPage1.PageText = "This wizard has now shown you all of its functionality examples. Hope you enjoyed" +
				" it.";
			this.infoPage1.PageTitle = "Completing the Wizard demonstration";
			this.infoPage1.Size = new System.Drawing.Size(428, 257);
			this.infoPage1.TabIndex = 3;
			// 
			// wizardPage4
			// 
			this.wizardPage4.Controls.Add(this.checkBox2);
			this.wizardPage4.Controls.Add(this.header4);
			this.wizardPage4.Controls.Add(this.checkBox3);
			this.wizardPage4.Controls.Add(this.checkBox4);
			this.wizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardPage4.IsFinishPage = false;
			this.wizardPage4.Location = new System.Drawing.Point(0, 0);
			this.wizardPage4.Name = "wizardPage4";
			this.wizardPage4.Size = new System.Drawing.Size(428, 257);
			this.wizardPage4.TabIndex = 7;
			this.wizardPage4.ShowFromBack += new System.EventHandler(this.wizardPage4_Show);
			this.wizardPage4.ShowFromNext += new System.EventHandler(this.wizardPage4_Show);
			// 
			// checkBox2
			// 
			this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2.Location = new System.Drawing.Point(16, 112);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(404, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "B&ack enabled";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// header4
			// 
			this.header4.BackColor = System.Drawing.SystemColors.Control;
			this.header4.CausesValidation = false;
			this.header4.Description = "This page allows you to control the enabled state of the buttons on the wizard";
			this.header4.Dock = System.Windows.Forms.DockStyle.Top;
			this.header4.Image = ((System.Drawing.Image)(resources.GetObject("header4.Image")));
			this.header4.Location = new System.Drawing.Point(0, 0);
			this.header4.Name = "header4";
			this.header4.Size = new System.Drawing.Size(428, 64);
			this.header4.TabIndex = 0;
			this.header4.Title = "Wizard Button enabling/disabling";
			// 
			// checkBox3
			// 
			this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3.Location = new System.Drawing.Point(16, 144);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(404, 24);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "N&ext enabled";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox4.Location = new System.Drawing.Point(16, 176);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(404, 24);
			this.checkBox4.TabIndex = 1;
			this.checkBox4.Text = "&Cancel enabled";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// wpButtonJump
			// 
			this.wpButtonJump.Controls.Add(this.label1);
			this.wpButtonJump.Controls.Add(this.button1);
			this.wpButtonJump.Controls.Add(this.header3);
			this.wpButtonJump.Controls.Add(this.button2);
			this.wpButtonJump.Controls.Add(this.button3);
			this.wpButtonJump.Controls.Add(this.button4);
			this.wpButtonJump.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpButtonJump.IsFinishPage = false;
			this.wpButtonJump.Location = new System.Drawing.Point(0, 0);
			this.wpButtonJump.Name = "wpButtonJump";
			this.wpButtonJump.Size = new System.Drawing.Size(428, 257);
			this.wpButtonJump.TabIndex = 5;
			this.wpButtonJump.CloseFromNext += new Gui.Wizard.PageEventHandler(this.wpButtonJump_Close);
			this.wpButtonJump.CloseFromBack += new Gui.Wizard.PageEventHandler(this.wpButtonJump_Close);
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(36, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 44);
			this.label1.TabIndex = 2;
			this.label1.Text = "This Page has close events on either Next or Back, try using the buttons to see t" +
				"he different effects that happen by using the REAL buttons or the user buttons (" +
				"which change page programatically).";
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(180, 232);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "Back";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// header3
			// 
			this.header3.BackColor = System.Drawing.SystemColors.Window;
			this.header3.CausesValidation = false;
			this.header3.Description = "This page demonstrates programatically changing pages";
			this.header3.Dock = System.Windows.Forms.DockStyle.Top;
			this.header3.Image = ((System.Drawing.Image)(resources.GetObject("header3.Image")));
			this.header3.Location = new System.Drawing.Point(0, 0);
			this.header3.Name = "header3";
			this.header3.Size = new System.Drawing.Size(428, 64);
			this.header3.TabIndex = 0;
			this.header3.Title = "Button Jump";
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(140, 204);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Back to first Page";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(256, 232);
			this.button3.Name = "button3";
			this.button3.TabIndex = 1;
			this.button3.Text = "Next";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Default;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(256, 204);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Next to Last Page";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// wpPPP
			// 
			this.wpPPP.Controls.Add(this.lblPPP);
			this.wpPPP.Controls.Add(this.header2);
			this.wpPPP.Controls.Add(this.pbPPP);
			this.wpPPP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpPPP.IsFinishPage = false;
			this.wpPPP.Location = new System.Drawing.Point(0, 0);
			this.wpPPP.Name = "wpPPP";
			this.wpPPP.Size = new System.Drawing.Size(428, 257);
			this.wpPPP.TabIndex = 4;
			this.wpPPP.ShowFromNext += new System.EventHandler(this.wpPPP_ShowFromNext);
			// 
			// lblPPP
			// 
			this.lblPPP.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblPPP.Location = new System.Drawing.Point(8, 72);
			this.lblPPP.Name = "lblPPP";
			this.lblPPP.Size = new System.Drawing.Size(176, 24);
			this.lblPPP.TabIndex = 10;
			this.lblPPP.Text = "Performing Processing";
			// 
			// header2
			// 
			this.header2.BackColor = System.Drawing.SystemColors.Control;
			this.header2.CausesValidation = false;
			this.header2.Description = "The \'Perform Processing Page and Next() example\' ";
			this.header2.Dock = System.Windows.Forms.DockStyle.Top;
			this.header2.Image = ((System.Drawing.Image)(resources.GetObject("header2.Image")));
			this.header2.Location = new System.Drawing.Point(0, 0);
			this.header2.Name = "header2";
			this.header2.Size = new System.Drawing.Size(428, 64);
			this.header2.TabIndex = 6;
			this.header2.Title = "Perform Processing Page";
			// 
			// pbPPP
			// 
			this.pbPPP.Location = new System.Drawing.Point(16, 96);
			this.pbPPP.Name = "pbPPP";
			this.pbPPP.Size = new System.Drawing.Size(392, 23);
			this.pbPPP.TabIndex = 9;
			// 
			// wpValidationDemo
			// 
			this.wpValidationDemo.Controls.Add(this.hdrValidationDemo);
			this.wpValidationDemo.Controls.Add(this.label5);
			this.wpValidationDemo.Controls.Add(this.groupBox1);
			this.wpValidationDemo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpValidationDemo.IsFinishPage = false;
			this.wpValidationDemo.Location = new System.Drawing.Point(0, 0);
			this.wpValidationDemo.Name = "wpValidationDemo";
			this.wpValidationDemo.Size = new System.Drawing.Size(428, 257);
			this.wpValidationDemo.TabIndex = 6;
			this.wpValidationDemo.CloseFromNext += new Gui.Wizard.PageEventHandler(this.wpValidationDemo_CloseFromNext);
			// 
			// hdrValidationDemo
			// 
			this.hdrValidationDemo.BackColor = System.Drawing.SystemColors.Window;
			this.hdrValidationDemo.CausesValidation = false;
			this.hdrValidationDemo.Description = "Additional validation demonstration using the CloseFromNext event";
			this.hdrValidationDemo.Dock = System.Windows.Forms.DockStyle.Top;
			this.hdrValidationDemo.Image = ((System.Drawing.Image)(resources.GetObject("hdrValidationDemo.Image")));
			this.hdrValidationDemo.Location = new System.Drawing.Point(0, 0);
			this.hdrValidationDemo.Name = "hdrValidationDemo";
			this.hdrValidationDemo.Size = new System.Drawing.Size(428, 64);
			this.hdrValidationDemo.TabIndex = 12;
			this.hdrValidationDemo.Title = "Validation demonstration";
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(28, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(372, 44);
			this.label5.TabIndex = 11;
			this.label5.Text = "To complete the validation, the address must be the same as the one on the right." +
				" However if you click Quick Fill it will copy it over for you.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtStreetAnswer);
			this.groupBox1.Controls.Add(this.btnQuickFill);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtStreet);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTown);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPostCode);
			this.groupBox1.Controls.Add(this.txtTownAnswer);
			this.groupBox1.Controls.Add(this.txtPostCodeAnswer);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(24, 124);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(380, 128);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Complex validation";
			// 
			// txtStreetAnswer
			// 
			this.txtStreetAnswer.Enabled = false;
			this.txtStreetAnswer.Location = new System.Drawing.Point(232, 40);
			this.txtStreetAnswer.Name = "txtStreetAnswer";
			this.txtStreetAnswer.ReadOnly = true;
			this.txtStreetAnswer.Size = new System.Drawing.Size(104, 21);
			this.txtStreetAnswer.TabIndex = 3;
			this.txtStreetAnswer.Text = "Liverpool St";
			// 
			// btnQuickFill
			// 
			this.btnQuickFill.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnQuickFill.Location = new System.Drawing.Point(296, 96);
			this.btnQuickFill.Name = "btnQuickFill";
			this.btnQuickFill.TabIndex = 2;
			this.btnQuickFill.Text = "Quick Fill";
			this.btnQuickFill.Click += new System.EventHandler(this.btnQuickFill_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Street";
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(92, 40);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(136, 21);
			this.txtStreet.TabIndex = 0;
			this.txtStreet.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Town";
			// 
			// txtTown
			// 
			this.txtTown.Location = new System.Drawing.Point(92, 64);
			this.txtTown.Name = "txtTown";
			this.txtTown.Size = new System.Drawing.Size(136, 21);
			this.txtTown.TabIndex = 0;
			this.txtTown.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "PostCode";
			// 
			// txtPostCode
			// 
			this.txtPostCode.Location = new System.Drawing.Point(92, 88);
			this.txtPostCode.Name = "txtPostCode";
			this.txtPostCode.Size = new System.Drawing.Size(92, 21);
			this.txtPostCode.TabIndex = 0;
			this.txtPostCode.Text = "";
			// 
			// txtTownAnswer
			// 
			this.txtTownAnswer.Enabled = false;
			this.txtTownAnswer.Location = new System.Drawing.Point(232, 64);
			this.txtTownAnswer.Name = "txtTownAnswer";
			this.txtTownAnswer.ReadOnly = true;
			this.txtTownAnswer.Size = new System.Drawing.Size(104, 21);
			this.txtTownAnswer.TabIndex = 3;
			this.txtTownAnswer.Text = "London";
			// 
			// txtPostCodeAnswer
			// 
			this.txtPostCodeAnswer.Enabled = false;
			this.txtPostCodeAnswer.Location = new System.Drawing.Point(232, 88);
			this.txtPostCodeAnswer.Name = "txtPostCodeAnswer";
			this.txtPostCodeAnswer.ReadOnly = true;
			this.txtPostCodeAnswer.Size = new System.Drawing.Size(60, 21);
			this.txtPostCodeAnswer.TabIndex = 3;
			this.txtPostCodeAnswer.Text = "EC4V";
			// 
			// wpLicenceValidate
			// 
			this.wpLicenceValidate.Controls.Add(this.richTextBox1);
			this.wpLicenceValidate.Controls.Add(this.checkBox1);
			this.wpLicenceValidate.Controls.Add(this.header1);
			this.wpLicenceValidate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpLicenceValidate.IsFinishPage = false;
			this.wpLicenceValidate.Location = new System.Drawing.Point(0, 0);
			this.wpLicenceValidate.Name = "wpLicenceValidate";
			this.wpLicenceValidate.Size = new System.Drawing.Size(428, 257);
			this.wpLicenceValidate.TabIndex = 2;
			this.wpLicenceValidate.ShowFromNext += new System.EventHandler(this.wizardPage2_ShowFromNext);
			this.wpLicenceValidate.CloseFromBack += new Gui.Wizard.PageEventHandler(this.wpLicenceValidate_CloseFromBack);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(8, 76);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(412, 144);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "Some really long winded licence that you have to agree to";
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(8, 224);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(416, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "I accept this licence agreement";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// header1
			// 
			this.header1.BackColor = System.Drawing.SystemColors.Control;
			this.header1.CausesValidation = false;
			this.header1.Description = "Click \'I accept...\' to go to the next page";
			this.header1.Dock = System.Windows.Forms.DockStyle.Top;
			this.header1.Image = ((System.Drawing.Image)(resources.GetObject("header1.Image")));
			this.header1.Location = new System.Drawing.Point(0, 0);
			this.header1.Name = "header1";
			this.header1.Size = new System.Drawing.Size(428, 64);
			this.header1.TabIndex = 5;
			this.header1.Title = "Agree Demo";
			// 
			// wpAlternateFinish
			// 
			this.wpAlternateFinish.Controls.Add(this.infoContainer2);
			this.wpAlternateFinish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpAlternateFinish.IsFinishPage = true;
			this.wpAlternateFinish.Location = new System.Drawing.Point(0, 0);
			this.wpAlternateFinish.Name = "wpAlternateFinish";
			this.wpAlternateFinish.Size = new System.Drawing.Size(428, 257);
			this.wpAlternateFinish.TabIndex = 8;
			// 
			// infoContainer2
			// 
			this.infoContainer2.BackColor = System.Drawing.Color.White;
			this.infoContainer2.Controls.Add(this.label9);
			this.infoContainer2.Controls.Add(this.pictureBox3);
			this.infoContainer2.Controls.Add(this.label12);
			this.infoContainer2.Controls.Add(this.label13);
			this.infoContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infoContainer2.Image = ((System.Drawing.Image)(resources.GetObject("infoContainer2.Image")));
			this.infoContainer2.Location = new System.Drawing.Point(0, 0);
			this.infoContainer2.Name = "infoContainer2";
			this.infoContainer2.PageTitle = "Alternate Finish Page";
			this.infoContainer2.Size = new System.Drawing.Size(428, 257);
			this.infoContainer2.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label9.Location = new System.Drawing.Point(188, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(236, 92);
			this.label9.TabIndex = 12;
			this.label9.Text = @"This page demonstrates the ability to have multiple finish pages. On the previous page you selected a short demo and pressed next. The WizardPage that is now displayed has its IsFinishPage property set to true, so that the next button will now perform finish functionality, instead of Next.";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(168, 52);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(16, 16);
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// wpChooseRoute
			// 
			this.wpChooseRoute.Controls.Add(this.pictureBox5);
			this.wpChooseRoute.Controls.Add(this.radFullDemo);
			this.wpChooseRoute.Controls.Add(this.hdrChooseRoute);
			this.wpChooseRoute.Controls.Add(this.radQuickDemo);
			this.wpChooseRoute.Controls.Add(this.pictureBox6);
			this.wpChooseRoute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wpChooseRoute.IsFinishPage = false;
			this.wpChooseRoute.Location = new System.Drawing.Point(0, 0);
			this.wpChooseRoute.Name = "wpChooseRoute";
			this.wpChooseRoute.Size = new System.Drawing.Size(428, 257);
			this.wpChooseRoute.TabIndex = 9;
			this.wpChooseRoute.CloseFromNext += new Gui.Wizard.PageEventHandler(this.wpChooseRoute_CloseFromNext);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(24, 112);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(16, 16);
			this.pictureBox5.TabIndex = 2;
			this.pictureBox5.TabStop = false;
			// 
			// radFullDemo
			// 
			this.radFullDemo.Checked = true;
			this.radFullDemo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radFullDemo.Location = new System.Drawing.Point(44, 108);
			this.radFullDemo.Name = "radFullDemo";
			this.radFullDemo.Size = new System.Drawing.Size(348, 24);
			this.radFullDemo.TabIndex = 1;
			this.radFullDemo.TabStop = true;
			this.radFullDemo.Text = "A &full demonstration showing lots of pages";
			// 
			// hdrChooseRoute
			// 
			this.hdrChooseRoute.BackColor = System.Drawing.SystemColors.Control;
			this.hdrChooseRoute.CausesValidation = false;
			this.hdrChooseRoute.Description = "This page allows to choose a full demonstration of all features or just a short d" +
				"emo straight to an alternate finish page";
			this.hdrChooseRoute.Dock = System.Windows.Forms.DockStyle.Top;
			this.hdrChooseRoute.Image = ((System.Drawing.Image)(resources.GetObject("hdrChooseRoute.Image")));
			this.hdrChooseRoute.Location = new System.Drawing.Point(0, 0);
			this.hdrChooseRoute.Name = "hdrChooseRoute";
			this.hdrChooseRoute.Size = new System.Drawing.Size(428, 64);
			this.hdrChooseRoute.TabIndex = 0;
			this.hdrChooseRoute.Title = "Choose Route";
			// 
			// radQuickDemo
			// 
			this.radQuickDemo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radQuickDemo.Location = new System.Drawing.Point(44, 148);
			this.radQuickDemo.Name = "radQuickDemo";
			this.radQuickDemo.Size = new System.Drawing.Size(348, 24);
			this.radQuickDemo.TabIndex = 1;
			this.radQuickDemo.Text = "&Quick demo showing only an alternate finish page";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(24, 152);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(16, 16);
			this.pictureBox6.TabIndex = 2;
			this.pictureBox6.TabStop = false;
			// 
			// timPPP
			// 
			this.timPPP.Tick += new System.EventHandler(this.timPPP_Tick);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label12.Location = new System.Drawing.Point(188, 148);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(232, 68);
			this.label12.TabIndex = 12;
			this.label12.Text = "If you had selected the other demo, then a handler for the previous pages Close e" +
				"vent would have skipped over this page. There is a similar handler to skip over " +
				"this page if you press back from the following page.";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label13.Location = new System.Drawing.Point(188, 220);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(232, 28);
			this.label13.TabIndex = 12;
			this.label13.Text = "You will notice that the Next functionality while in Design Mode is unchanged.";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label14.Location = new System.Drawing.Point(192, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(232, 40);
			this.label14.TabIndex = 12;
			this.label14.Text = "ReCode. The WizardDesigner now avoids WndProc and uses GetHitTest, making it comp" +
				"atible with SharpDevelop.";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(172, 96);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(16, 16);
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(428, 305);
			this.Controls.Add(this.wizard1);
			this.MinimumSize = new System.Drawing.Size(436, 332);
			this.Name = "Form1";
			this.Text = "Form1";
			this.wizard1.ResumeLayout(false);
			this.wizardPage1.ResumeLayout(false);
			this.infoContainer1.ResumeLayout(false);
			this.wizardPage3.ResumeLayout(false);
			this.wizardPage4.ResumeLayout(false);
			this.wpButtonJump.ResumeLayout(false);
			this.wpPPP.ResumeLayout(false);
			this.wpValidationDemo.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.wpLicenceValidate.ResumeLayout(false);
			this.wpAlternateFinish.ResumeLayout(false);
			this.infoContainer2.ResumeLayout(false);
			this.wpChooseRoute.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		
		#region Licence accept example
		private void wizardPage2_ShowFromNext(object sender, System.EventArgs e)
		{
			wizard1.NextEnabled = checkBox1.Checked;
		}
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			wizard1.NextEnabled = checkBox1.Checked;
		}
		#endregion

		#region Perform Processing Page and Next example
		private void wpPPP_ShowFromNext(object sender, System.EventArgs e)
		{
			//Set up Gui
			wizard1.NextEnabled = false;
			wizard1.BackEnabled = false;
			wizard1.CancelEnabled = false;
			pbPPP.Value = 0;

			//Start Processing
			timPPP.Interval = 100;
			timPPP.Enabled = true;
		}

		private void timPPP_Tick(object sender, System.EventArgs e)
		{
			pbPPP.PerformStep();
			//Have we finished
			if (pbPPP.Value >= pbPPP.Maximum)
			{
				//Stop the processing
				timPPP.Enabled = false;

				//Go to Next Page
				wizard1.Next();
				//OR 
				//wizard1.NextTo(wizardPage3);
			}
		}

		private void wizardPage3_ShowFromNext(object sender, System.EventArgs e)
		{
			wizard1.NextEnabled = true;
			wizard1.BackEnabled = true;
			wizard1.CancelEnabled = true;
		}


		#endregion

		#region Back, BackTo, Next and NextTo
		private void button2_Click(object sender, System.EventArgs e)
		{
			wizard1.BackTo(wizardPage1);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			wizard1.Back();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			wizard1.NextTo(wizardPage3);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			wizard1.Next();
		}

		private void wpButtonJump_Close(object sender, Gui.Wizard.PageEventArgs e)
		{
			MessageBox.Show("This happened in the Close Event");
		}

		#endregion

		#region Complex Validation example
		private void wpValidationDemo_CloseFromNext(object sender, Gui.Wizard.PageEventArgs e)
		{
			if (txtStreet.Text == txtStreetAnswer.Text
				&& txtTown.Text == txtTownAnswer.Text
				&& txtPostCode.Text == txtPostCodeAnswer.Text)
			{
				//Success but we don't do anything
			}
			else
			{
				//First warn the user
				MessageBox.Show(this, 
					"Validation failed. Hit QuickFill to copy",
					"Validation Example",
					MessageBoxButtons.OK);
				//Then ensure we DONT goto the NEXT PAGE
				e.Page = wpValidationDemo;
			}
		}
	
		private void btnQuickFill_Click(object sender, System.EventArgs e)
		{
			txtStreet.Text = txtStreetAnswer.Text;
			txtTown.Text = txtTownAnswer.Text;
			txtPostCode.Text = txtPostCodeAnswer.Text;
		}
	


		#endregion

		private void wizard1_CloseFromCancel(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (MessageBox.Show(this, 
				"Are you sure you want to close this?",
				"Wizard Cancelled", MessageBoxButtons.YesNo
				) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			wizard1.BackEnabled = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			wizard1.NextEnabled = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			wizard1.CancelEnabled = checkBox4.Checked;
		}

		private void wizardPage4_Show(object sender, System.EventArgs e)
		{
			checkBox2_CheckedChanged(sender,e);
			checkBox3_CheckedChanged(sender,e);
			checkBox4_CheckedChanged(sender,e);
		}

		private void wpChooseRoute_CloseFromNext(object sender, Gui.Wizard.PageEventArgs e)
		{
			if (radFullDemo.Checked == true)
				e.Page = wpLicenceValidate;
			else
				e.Page = wpAlternateFinish;
		}

		private void wpLicenceValidate_CloseFromBack(object sender, Gui.Wizard.PageEventArgs e)
		{
			e.Page = wpChooseRoute;
		}

	
	}
}
