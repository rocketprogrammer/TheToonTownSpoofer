namespace ns17
{
	// Token: 0x02000264 RID: 612
	internal sealed partial class CustomizeEstatePlanting : global::System.Windows.Forms.Form
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x00009461 File Offset: 0x00007661
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0004A214 File Offset: 0x00048414
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns17.CustomizeEstatePlanting));
			this.OKBtn = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.smoothGroup1 = new global::ns24.Class310();
			this.GardeningLayout = new global::System.Windows.Forms.Panel();
			this.FlowerBox = new global::System.Windows.Forms.PictureBox();
			this.FlowerIcon1 = new global::System.Windows.Forms.PictureBox();
			this.FlowerIcon5 = new global::System.Windows.Forms.PictureBox();
			this.TreeBox0 = new global::ns23.GardenTreeSelector();
			this.FlowerIcon8 = new global::System.Windows.Forms.PictureBox();
			this.HouseEstate = new global::ns27.Control10();
			this.FlowerIcon9 = new global::System.Windows.Forms.PictureBox();
			this.FlowerBox1 = new global::ns17.GardeningFlowerSelector();
			this.FlowerIcon2 = new global::System.Windows.Forms.PictureBox();
			this.FlowerBox0 = new global::ns17.GardeningFlowerSelector();
			this.FlowerIcon0 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.FlowerIcon7 = new global::System.Windows.Forms.PictureBox();
			this.FlowerBox9 = new global::ns17.GardeningFlowerSelector();
			this.FlowerIcon3 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.FlowerIcon4 = new global::System.Windows.Forms.PictureBox();
			this.FlowerBox8 = new global::ns17.GardeningFlowerSelector();
			this.FlowerIcon6 = new global::System.Windows.Forms.PictureBox();
			this.TreeBox = new global::System.Windows.Forms.PictureBox();
			this.TreeBox1 = new global::ns23.GardenTreeSelector();
			this.FlowerBox2 = new global::ns17.GardeningFlowerSelector();
			this.TreeBox2 = new global::ns23.GardenTreeSelector();
			this.TreeBox7 = new global::ns23.GardenTreeSelector();
			this.FlowerBox5 = new global::ns17.GardeningFlowerSelector();
			this.FlowerBox3 = new global::ns17.GardeningFlowerSelector();
			this.TreeBox3 = new global::ns23.GardenTreeSelector();
			this.TreeBox6 = new global::ns23.GardenTreeSelector();
			this.FlowerBox4 = new global::ns17.GardeningFlowerSelector();
			this.FlowerBox7 = new global::ns17.GardeningFlowerSelector();
			this.TreeBox4 = new global::ns23.GardenTreeSelector();
			this.TreeBox5 = new global::ns23.GardenTreeSelector();
			this.FlowerBox6 = new global::ns17.GardeningFlowerSelector();
			this.lblContentPackStatus = new global::System.Windows.Forms.Label();
			this.lblContentPackTitle = new global::System.Windows.Forms.Label();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.smoothGroup1.SuspendLayout();
			this.GardeningLayout.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon8).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon9).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.TreeBox).BeginInit();
			base.SuspendLayout();
			this.OKBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.OKBtn.Location = new global::System.Drawing.Point(444, 522);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new global::System.Drawing.Size(75, 23);
			this.OKBtn.TabIndex = 0;
			this.OKBtn.Text = "&OK";
			this.OKBtn.UseVisualStyleBackColor = true;
			this.OKBtn.Click += new global::System.EventHandler(this.OKBtn_Click);
			this.CancelBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(363, 522);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.smoothGroup1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.LightGreen;
			this.smoothGroup1.Controls.Add(this.GardeningLayout);
			this.smoothGroup1.Controls.Add(this.lblContentPackStatus);
			this.smoothGroup1.Controls.Add(this.lblContentPackTitle);
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(4, 4);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(515, 514);
			this.smoothGroup1.TabIndex = 18;
			this.GardeningLayout.BackColor = global::System.Drawing.Color.LightGreen;
			this.GardeningLayout.Controls.Add(this.FlowerBox);
			this.GardeningLayout.Controls.Add(this.FlowerIcon1);
			this.GardeningLayout.Controls.Add(this.FlowerIcon5);
			this.GardeningLayout.Controls.Add(this.TreeBox0);
			this.GardeningLayout.Controls.Add(this.FlowerIcon8);
			this.GardeningLayout.Controls.Add(this.HouseEstate);
			this.GardeningLayout.Controls.Add(this.FlowerIcon9);
			this.GardeningLayout.Controls.Add(this.FlowerBox1);
			this.GardeningLayout.Controls.Add(this.FlowerIcon2);
			this.GardeningLayout.Controls.Add(this.FlowerBox0);
			this.GardeningLayout.Controls.Add(this.FlowerIcon0);
			this.GardeningLayout.Controls.Add(this.label2);
			this.GardeningLayout.Controls.Add(this.FlowerIcon7);
			this.GardeningLayout.Controls.Add(this.FlowerBox9);
			this.GardeningLayout.Controls.Add(this.FlowerIcon3);
			this.GardeningLayout.Controls.Add(this.label1);
			this.GardeningLayout.Controls.Add(this.FlowerIcon4);
			this.GardeningLayout.Controls.Add(this.FlowerBox8);
			this.GardeningLayout.Controls.Add(this.FlowerIcon6);
			this.GardeningLayout.Controls.Add(this.TreeBox);
			this.GardeningLayout.Controls.Add(this.TreeBox1);
			this.GardeningLayout.Controls.Add(this.FlowerBox2);
			this.GardeningLayout.Controls.Add(this.TreeBox2);
			this.GardeningLayout.Controls.Add(this.TreeBox7);
			this.GardeningLayout.Controls.Add(this.FlowerBox5);
			this.GardeningLayout.Controls.Add(this.FlowerBox3);
			this.GardeningLayout.Controls.Add(this.TreeBox3);
			this.GardeningLayout.Controls.Add(this.TreeBox6);
			this.GardeningLayout.Controls.Add(this.FlowerBox4);
			this.GardeningLayout.Controls.Add(this.FlowerBox7);
			this.GardeningLayout.Controls.Add(this.TreeBox4);
			this.GardeningLayout.Controls.Add(this.TreeBox5);
			this.GardeningLayout.Controls.Add(this.FlowerBox6);
			this.GardeningLayout.Location = new global::System.Drawing.Point(4, 35);
			this.GardeningLayout.Name = "GardeningLayout";
			this.GardeningLayout.Size = new global::System.Drawing.Size(506, 476);
			this.GardeningLayout.TabIndex = 18;
			this.FlowerBox.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerBox.Image");
			this.FlowerBox.Location = new global::System.Drawing.Point(5, 438);
			this.FlowerBox.Name = "FlowerBox";
			this.FlowerBox.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerBox.TabIndex = 12;
			this.FlowerBox.TabStop = false;
			this.FlowerBox.Click += new global::System.EventHandler(this.FlowerBox_Click);
			this.FlowerIcon1.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon1.Image");
			this.FlowerIcon1.Location = new global::System.Drawing.Point(179, 258);
			this.FlowerIcon1.Name = "FlowerIcon1";
			this.FlowerIcon1.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon1.TabIndex = 12;
			this.FlowerIcon1.TabStop = false;
			this.FlowerIcon1.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.FlowerIcon5.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon5.Image");
			this.FlowerIcon5.Location = new global::System.Drawing.Point(255, 155);
			this.FlowerIcon5.Name = "FlowerIcon5";
			this.FlowerIcon5.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon5.TabIndex = 12;
			this.FlowerIcon5.TabStop = false;
			this.FlowerIcon5.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.TreeBox0.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox0.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox0.Location = new global::System.Drawing.Point(360, 295);
			this.TreeBox0.Name = "TreeBox0";
			this.TreeBox0.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox0.TabIndex = 13;
			this.TreeBox0.TabStop = false;
			this.TreeBox0.TreeEnabled = false;
			this.TreeBox0.TreeNumber = 1;
			this.FlowerIcon8.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon8.Image");
			this.FlowerIcon8.Location = new global::System.Drawing.Point(294, 259);
			this.FlowerIcon8.Name = "FlowerIcon8";
			this.FlowerIcon8.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon8.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon8.TabIndex = 12;
			this.FlowerIcon8.TabStop = false;
			this.FlowerIcon8.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.HouseEstate.BackColor = global::System.Drawing.Color.LightGreen;
			this.HouseEstate.EstateHome = global::ns14.Enum13.const_3;
			this.HouseEstate.Location = new global::System.Drawing.Point(227, 207);
			this.HouseEstate.Name = "HouseEstate";
			this.HouseEstate.Size = new global::System.Drawing.Size(56, 64);
			this.HouseEstate.TabIndex = 0;
			this.HouseEstate.Text = "estateRenderer1";
			this.FlowerIcon9.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon9.Image");
			this.FlowerIcon9.Location = new global::System.Drawing.Point(273, 295);
			this.FlowerIcon9.Name = "FlowerIcon9";
			this.FlowerIcon9.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon9.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon9.TabIndex = 12;
			this.FlowerIcon9.TabStop = false;
			this.FlowerIcon9.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.FlowerBox1.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox1.FlowerNumber = 2;
			this.FlowerBox1.Location = new global::System.Drawing.Point(145, 259);
			this.FlowerBox1.Name = "FlowerBox1";
			this.FlowerBox1.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox1.TabIndex = 1;
			this.FlowerBox1.TabStop = false;
			this.FlowerIcon2.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon2.Image");
			this.FlowerIcon2.Location = new global::System.Drawing.Point(179, 224);
			this.FlowerIcon2.Name = "FlowerIcon2";
			this.FlowerIcon2.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon2.TabIndex = 12;
			this.FlowerIcon2.TabStop = false;
			this.FlowerIcon2.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.FlowerBox0.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox0.FlowerNumber = 1;
			this.FlowerBox0.Location = new global::System.Drawing.Point(198, 327);
			this.FlowerBox0.Name = "FlowerBox0";
			this.FlowerBox0.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox0.TabIndex = 1;
			this.FlowerBox0.TabStop = false;
			this.FlowerIcon0.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon0.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon0.Image");
			this.FlowerIcon0.Location = new global::System.Drawing.Point(201, 295);
			this.FlowerIcon0.Name = "FlowerIcon0";
			this.FlowerIcon0.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon0.TabIndex = 12;
			this.FlowerIcon0.TabStop = false;
			this.FlowerIcon0.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.LightGreen;
			this.label2.Location = new global::System.Drawing.Point(43, 457);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(43, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Flowers";
			this.FlowerIcon7.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon7.Image");
			this.FlowerIcon7.Location = new global::System.Drawing.Point(294, 225);
			this.FlowerIcon7.Name = "FlowerIcon7";
			this.FlowerIcon7.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon7.TabIndex = 12;
			this.FlowerIcon7.TabStop = false;
			this.FlowerIcon7.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.FlowerBox9.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox9.FlowerNumber = 10;
			this.FlowerBox9.Location = new global::System.Drawing.Point(270, 327);
			this.FlowerBox9.Name = "FlowerBox9";
			this.FlowerBox9.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox9.TabIndex = 10;
			this.FlowerBox9.TabStop = false;
			this.FlowerIcon3.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon3.Image");
			this.FlowerIcon3.Location = new global::System.Drawing.Point(179, 190);
			this.FlowerIcon3.Name = "FlowerIcon3";
			this.FlowerIcon3.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon3.TabIndex = 12;
			this.FlowerIcon3.TabStop = false;
			this.FlowerIcon3.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.LightGreen;
			this.label1.Location = new global::System.Drawing.Point(130, 457);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(34, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Trees";
			this.FlowerIcon4.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon4.Image");
			this.FlowerIcon4.Location = new global::System.Drawing.Point(221, 155);
			this.FlowerIcon4.Name = "FlowerIcon4";
			this.FlowerIcon4.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon4.TabIndex = 12;
			this.FlowerIcon4.TabStop = false;
			this.FlowerIcon4.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.FlowerBox8.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox8.FlowerNumber = 9;
			this.FlowerBox8.Location = new global::System.Drawing.Point(323, 259);
			this.FlowerBox8.Name = "FlowerBox8";
			this.FlowerBox8.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox8.TabIndex = 1;
			this.FlowerBox8.TabStop = false;
			this.FlowerIcon6.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerIcon6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FlowerIcon6.Image");
			this.FlowerIcon6.Location = new global::System.Drawing.Point(294, 191);
			this.FlowerIcon6.Name = "FlowerIcon6";
			this.FlowerIcon6.Size = new global::System.Drawing.Size(32, 32);
			this.FlowerIcon6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FlowerIcon6.TabIndex = 12;
			this.FlowerIcon6.TabStop = false;
			this.FlowerIcon6.Click += new global::System.EventHandler(this.FlowerIcon6_Click);
			this.TreeBox.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TreeBox.Image");
			this.TreeBox.Location = new global::System.Drawing.Point(92, 438);
			this.TreeBox.Name = "TreeBox";
			this.TreeBox.Size = new global::System.Drawing.Size(32, 32);
			this.TreeBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.TreeBox.TabIndex = 14;
			this.TreeBox.TabStop = false;
			this.TreeBox.Click += new global::System.EventHandler(this.TreeBox_Click);
			this.TreeBox1.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox1.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox1.Location = new global::System.Drawing.Point(428, 295);
			this.TreeBox1.Name = "TreeBox1";
			this.TreeBox1.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox1.TabIndex = 13;
			this.TreeBox1.TabStop = false;
			this.TreeBox1.TreeEnabled = false;
			this.TreeBox1.TreeNumber = 2;
			this.FlowerBox2.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox2.FlowerNumber = 3;
			this.FlowerBox2.Location = new global::System.Drawing.Point(145, 225);
			this.FlowerBox2.Name = "FlowerBox2";
			this.FlowerBox2.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox2.TabIndex = 1;
			this.FlowerBox2.TabStop = false;
			this.TreeBox2.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox2.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox2.Location = new global::System.Drawing.Point(360, 333);
			this.TreeBox2.Name = "TreeBox2";
			this.TreeBox2.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox2.TabIndex = 13;
			this.TreeBox2.TabStop = false;
			this.TreeBox2.TreeEnabled = false;
			this.TreeBox2.TreeNumber = 3;
			this.TreeBox7.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox7.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox7.Location = new global::System.Drawing.Point(428, 409);
			this.TreeBox7.Name = "TreeBox7";
			this.TreeBox7.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox7.TabIndex = 13;
			this.TreeBox7.TabStop = false;
			this.TreeBox7.TreeEnabled = false;
			this.TreeBox7.TreeNumber = 8;
			this.FlowerBox5.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox5.FlowerNumber = 6;
			this.FlowerBox5.Location = new global::System.Drawing.Point(253, 124);
			this.FlowerBox5.Name = "FlowerBox5";
			this.FlowerBox5.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox5.TabIndex = 1;
			this.FlowerBox5.TabStop = false;
			this.FlowerBox3.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox3.FlowerNumber = 4;
			this.FlowerBox3.Location = new global::System.Drawing.Point(145, 191);
			this.FlowerBox3.Name = "FlowerBox3";
			this.FlowerBox3.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox3.TabIndex = 1;
			this.FlowerBox3.TabStop = false;
			this.TreeBox3.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox3.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox3.Location = new global::System.Drawing.Point(428, 333);
			this.TreeBox3.Name = "TreeBox3";
			this.TreeBox3.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox3.TabIndex = 13;
			this.TreeBox3.TabStop = false;
			this.TreeBox3.TreeEnabled = false;
			this.TreeBox3.TreeNumber = 4;
			this.TreeBox6.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox6.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox6.Location = new global::System.Drawing.Point(360, 409);
			this.TreeBox6.Name = "TreeBox6";
			this.TreeBox6.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox6.TabIndex = 13;
			this.TreeBox6.TabStop = false;
			this.TreeBox6.TreeEnabled = false;
			this.TreeBox6.TreeNumber = 7;
			this.FlowerBox4.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox4.FlowerNumber = 5;
			this.FlowerBox4.Location = new global::System.Drawing.Point(219, 124);
			this.FlowerBox4.Name = "FlowerBox4";
			this.FlowerBox4.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox4.TabIndex = 1;
			this.FlowerBox4.TabStop = false;
			this.FlowerBox7.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox7.FlowerNumber = 8;
			this.FlowerBox7.Location = new global::System.Drawing.Point(323, 225);
			this.FlowerBox7.Name = "FlowerBox7";
			this.FlowerBox7.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox7.TabIndex = 1;
			this.FlowerBox7.TabStop = false;
			this.TreeBox4.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox4.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox4.Location = new global::System.Drawing.Point(360, 371);
			this.TreeBox4.Name = "TreeBox4";
			this.TreeBox4.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox4.TabIndex = 13;
			this.TreeBox4.TabStop = false;
			this.TreeBox4.TreeEnabled = false;
			this.TreeBox4.TreeNumber = 5;
			this.TreeBox5.BackColor = global::System.Drawing.Color.LightGreen;
			this.TreeBox5.GardeningActions = global::ns21.Enum36.flag_0;
			this.TreeBox5.Location = new global::System.Drawing.Point(428, 371);
			this.TreeBox5.Name = "TreeBox5";
			this.TreeBox5.Size = new global::System.Drawing.Size(62, 32);
			this.TreeBox5.TabIndex = 13;
			this.TreeBox5.TabStop = false;
			this.TreeBox5.TreeEnabled = false;
			this.TreeBox5.TreeNumber = 6;
			this.FlowerBox6.BackColor = global::System.Drawing.Color.LightGreen;
			this.FlowerBox6.FlowerNumber = 7;
			this.FlowerBox6.Location = new global::System.Drawing.Point(323, 191);
			this.FlowerBox6.Name = "FlowerBox6";
			this.FlowerBox6.Size = new global::System.Drawing.Size(36, 30);
			this.FlowerBox6.TabIndex = 1;
			this.FlowerBox6.TabStop = false;
			this.lblContentPackStatus.AutoSize = true;
			this.lblContentPackStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblContentPackStatus.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblContentPackStatus.ForeColor = global::System.Drawing.Color.DarkGray;
			this.lblContentPackStatus.Location = new global::System.Drawing.Point(173, 8);
			this.lblContentPackStatus.Name = "lblContentPackStatus";
			this.lblContentPackStatus.Size = new global::System.Drawing.Size(208, 19);
			this.lblContentPackStatus.TabIndex = 17;
			this.lblContentPackStatus.Text = "Flower and Tree Customization";
			this.lblContentPackTitle.AutoSize = true;
			this.lblContentPackTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblContentPackTitle.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblContentPackTitle.ForeColor = global::System.Drawing.Color.Gray;
			this.lblContentPackTitle.Location = new global::System.Drawing.Point(10, 8);
			this.lblContentPackTitle.Name = "lblContentPackTitle";
			this.lblContentPackTitle.Size = new global::System.Drawing.Size(157, 19);
			this.lblContentPackTitle.TabIndex = 16;
			this.lblContentPackTitle.Text = "Customize Gardening:";
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(1, 536);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 19;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			base.AcceptButton = this.OKBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(522, 550);
			base.Controls.Add(this.HowToOpenHelpLabel);
			base.Controls.Add(this.smoothGroup1);
			base.Controls.Add(this.OKBtn);
			base.Controls.Add(this.CancelBtn);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "CustomizeEstatePlanting";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gardener Flora : Customize Gardening";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.CustomizeEstatePlanting_HelpRequested);
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			this.GardeningLayout.ResumeLayout(false);
			this.GardeningLayout.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon8).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon9).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FlowerIcon6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.TreeBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000794 RID: 1940
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000795 RID: 1941
		private global::ns27.Control10 HouseEstate;

		// Token: 0x04000796 RID: 1942
		private global::ns17.GardeningFlowerSelector FlowerBox1;

		// Token: 0x04000797 RID: 1943
		private global::ns17.GardeningFlowerSelector FlowerBox2;

		// Token: 0x04000798 RID: 1944
		private global::ns17.GardeningFlowerSelector FlowerBox3;

		// Token: 0x04000799 RID: 1945
		private global::ns17.GardeningFlowerSelector FlowerBox0;

		// Token: 0x0400079A RID: 1946
		private global::ns17.GardeningFlowerSelector FlowerBox4;

		// Token: 0x0400079B RID: 1947
		private global::ns17.GardeningFlowerSelector FlowerBox5;

		// Token: 0x0400079C RID: 1948
		private global::ns17.GardeningFlowerSelector FlowerBox8;

		// Token: 0x0400079D RID: 1949
		private global::ns17.GardeningFlowerSelector FlowerBox7;

		// Token: 0x0400079E RID: 1950
		private global::ns17.GardeningFlowerSelector FlowerBox6;

		// Token: 0x0400079F RID: 1951
		private global::ns17.GardeningFlowerSelector FlowerBox9;

		// Token: 0x040007A0 RID: 1952
		private global::System.Windows.Forms.Button OKBtn;

		// Token: 0x040007A1 RID: 1953
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x040007A2 RID: 1954
		private global::System.Windows.Forms.PictureBox FlowerIcon6;

		// Token: 0x040007A3 RID: 1955
		private global::System.Windows.Forms.PictureBox FlowerIcon5;

		// Token: 0x040007A4 RID: 1956
		private global::System.Windows.Forms.PictureBox FlowerIcon4;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Forms.PictureBox FlowerIcon7;

		// Token: 0x040007A6 RID: 1958
		private global::System.Windows.Forms.PictureBox FlowerIcon8;

		// Token: 0x040007A7 RID: 1959
		private global::System.Windows.Forms.PictureBox FlowerIcon3;

		// Token: 0x040007A8 RID: 1960
		private global::System.Windows.Forms.PictureBox FlowerIcon2;

		// Token: 0x040007A9 RID: 1961
		private global::System.Windows.Forms.PictureBox FlowerIcon1;

		// Token: 0x040007AA RID: 1962
		private global::System.Windows.Forms.PictureBox FlowerIcon9;

		// Token: 0x040007AB RID: 1963
		private global::System.Windows.Forms.PictureBox FlowerIcon0;

		// Token: 0x040007AC RID: 1964
		private global::ns23.GardenTreeSelector TreeBox0;

		// Token: 0x040007AD RID: 1965
		private global::ns23.GardenTreeSelector TreeBox1;

		// Token: 0x040007AE RID: 1966
		private global::ns23.GardenTreeSelector TreeBox2;

		// Token: 0x040007AF RID: 1967
		private global::ns23.GardenTreeSelector TreeBox3;

		// Token: 0x040007B0 RID: 1968
		private global::ns23.GardenTreeSelector TreeBox4;

		// Token: 0x040007B1 RID: 1969
		private global::ns23.GardenTreeSelector TreeBox5;

		// Token: 0x040007B2 RID: 1970
		private global::ns23.GardenTreeSelector TreeBox6;

		// Token: 0x040007B3 RID: 1971
		private global::ns23.GardenTreeSelector TreeBox7;

		// Token: 0x040007B4 RID: 1972
		private global::System.Windows.Forms.PictureBox TreeBox;

		// Token: 0x040007B5 RID: 1973
		private global::System.Windows.Forms.PictureBox FlowerBox;

		// Token: 0x040007B6 RID: 1974
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040007B7 RID: 1975
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040007B8 RID: 1976
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x040007B9 RID: 1977
		private global::System.Windows.Forms.Label lblContentPackStatus;

		// Token: 0x040007BA RID: 1978
		private global::System.Windows.Forms.Label lblContentPackTitle;

		// Token: 0x040007BB RID: 1979
		private global::System.Windows.Forms.Panel GardeningLayout;

		// Token: 0x040007BC RID: 1980
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;
	}
}
