using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns14;
using ns15;
using ns17;
using ns20;
using ns21;
using ns23;
using ns24;
using ns26;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns16
{
	// Token: 0x020003C6 RID: 966
	internal sealed partial class GardenerFloraCaptureSetup : CaptureSetupForm
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x00080CD4 File Offset: 0x0007EED4
		public GardenerFloraCaptureSetup()
		{
			this.InitializeComponent_2();
			this.class114_0 = Class110.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles;
			this.NewFileMenuItem.Click += base.method_0;
			this.OpenFileMenuItem.Click += base.method_1;
			this.SaveFileMenuItem.Click += base.method_2;
			this.SaveAsFileMenuItem.Click += base.method_3;
			this.CloseFileMenuItem.Click += base.method_4;
			base.method_5();
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00080D7C File Offset: 0x0007EF7C
		protected override bool vmethod_3(out Class524 filePath)
		{
			using (StringInputForm stringInputForm = new StringInputForm())
			{
				stringInputForm.LabelMessage = GardenerFloraCaptureSetup.string_0;
				stringInputForm.Text = GardenerFloraCaptureSetup.string_1;
				if (stringInputForm.ShowDialog() == DialogResult.OK)
				{
					filePath = new Class524(stringInputForm.Value, Class266.smethod_2(Class291.GardenerFloraCaptureSettingsDirectory, ".gfc"));
					return true;
				}
			}
			filePath = null;
			return false;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000107AD File Offset: 0x0000E9AD
		protected override void vmethod_1(Class524 fileName)
		{
			this.method_13(fileName);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00080DF0 File Offset: 0x0007EFF0
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class88_0.method_1(fileName.string_1);
				this.method_13(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000107B6 File Offset: 0x0000E9B6
		private void method_13(Class524 fileName)
		{
			if (!this.class114_0.Files.Contains(fileName))
			{
				this.class114_0.Files.Add(fileName);
				Class110.smethod_1();
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00080E3C File Offset: 0x0007F03C
		protected override bool vmethod_6(out Class524 fileName)
		{
			Class524 @class;
			bool result;
			if (result = Class460.smethod_3(out @class))
			{
				fileName = @class;
			}
			else
			{
				fileName = null;
			}
			return result;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00080E60 File Offset: 0x0007F060
		protected override bool vmethod_5(Class524 fileName)
		{
			bool result;
			try
			{
				Class88 @class = new Class88(fileName.string_1);
				if (this.class88_0 != null)
				{
					this.class88_0.Dispose();
				}
				this.class88_0 = @class;
				this.method_14();
				result = true;
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(GardenerFloraCaptureSetup.string_2, fileName.string_1)
				});
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000107E2 File Offset: 0x0000E9E2
		protected override void vmethod_0()
		{
			if (this.class88_0 != null)
			{
				this.class88_0.Dispose();
			}
			this.class88_0 = new Class88();
			this.method_14();
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00080EE0 File Offset: 0x0007F0E0
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (Class524.smethod_0(fileName, null))
			{
				if (modified)
				{
					this.Text = GardenerFloraCaptureSetup.string_3;
					return;
				}
				this.Text = GardenerFloraCaptureSetup.string_4;
				return;
			}
			else
			{
				if (modified)
				{
					this.Text = string.Format(GardenerFloraCaptureSetup.string_5, fileName.string_0);
					return;
				}
				this.Text = GardenerFloraCaptureSetup.string_6 + fileName.string_0;
				return;
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00080F44 File Offset: 0x0007F144
		private void method_14()
		{
			CaptureSetupForm.smethod_0(this.class88_0.PlantFailedCapture, this.PlantFailedButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.FinalPlantCapture, this.FinalPlantButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.NoWaterCapture, this.NoWaterButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.PickFlowerCapture, this.PickFlowerButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.PlantFlowerCapture, this.PlantFlowerButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.PlantSuccessCapture, this.PlantSuccessButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.WaterPlantCapture, this.WaterPlantButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.BasketFullCapture, this.BasketFullButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.SellFlowersCapture, this.SellFlowersButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.DisabledBeanSlotCapture, this.DisabledBeanSlotState);
			CaptureSetupForm.smethod_0(this.class88_0.FinalPickCapture, this.FinalPickButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.CancelPlantCapture, this.CancelPlantButtonState);
			CaptureSetupForm.smethod_0(this.class88_0.NoRemoveCapture, this.NoRemoveButtonState);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00007128 File Offset: 0x00005328
		private void SelectWindowMenuItem_Click(object sender, EventArgs e)
		{
			this.class141_0.smethod_2(this, null);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00081070 File Offset: 0x0007F270
		private void PickFlowerButton_Click(object sender, EventArgs e)
		{
			base.method_12();
			Class125 @class = null;
			try
			{
				Struct46 @struct;
				if (object.ReferenceEquals(sender, this.FinalPlantButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_7, GardenerFloraCaptureSetup.string_8, this.class88_0.FinalPlantBounds, out @class, out @struct))
					{
						if (this.class88_0.FinalPlantCapture != null)
						{
							this.class88_0.FinalPlantCapture.Dispose();
							this.class88_0.FinalPlantCapture = null;
						}
						this.class88_0.FinalPlantCapture = new Class150(@class);
						this.class88_0.FinalPlantBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.PlantButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_9, GardenerFloraCaptureSetup.string_10, this.class88_0.PlantFlowerBounds, out @class, out @struct))
					{
						if (this.class88_0.PlantFlowerCapture != null)
						{
							this.class88_0.PlantFlowerCapture.Dispose();
							this.class88_0.PlantFlowerCapture = null;
						}
						this.class88_0.PlantFlowerCapture = new Class150(@class);
						this.class88_0.PlantFlowerBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.PlantFailedButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_11, GardenerFloraCaptureSetup.string_12, this.class88_0.PlantFailedBounds, out @class, out @struct))
					{
						if (this.class88_0.PlantFailedCapture != null)
						{
							this.class88_0.PlantFailedCapture.Dispose();
							this.class88_0.PlantFailedCapture = null;
						}
						this.class88_0.PlantFailedCapture = new Class150(@class);
						this.class88_0.PlantFailedBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.PlantSuccessButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_11, GardenerFloraCaptureSetup.string_13, this.class88_0.PlantSuccessBounds, out @class, out @struct))
					{
						if (this.class88_0.PlantSuccessCapture != null)
						{
							this.class88_0.PlantSuccessCapture.Dispose();
							this.class88_0.PlantSuccessCapture = null;
						}
						this.class88_0.PlantSuccessCapture = new Class150(@class);
						this.class88_0.PlantSuccessBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.WaterButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_14, GardenerFloraCaptureSetup.string_15, this.class88_0.WaterPlantBounds, out @class, out @struct))
					{
						if (this.class88_0.WaterPlantCapture != null)
						{
							this.class88_0.WaterPlantCapture.Dispose();
							this.class88_0.WaterPlantCapture = null;
						}
						this.class88_0.WaterPlantCapture = new Class150(@class);
						this.class88_0.WaterPlantBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.NoWaterButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_16, GardenerFloraCaptureSetup.string_17, this.class88_0.NoWaterBounds, out @class, out @struct))
					{
						if (this.class88_0.NoWaterCapture != null)
						{
							this.class88_0.NoWaterCapture.Dispose();
							this.class88_0.NoWaterCapture = null;
						}
						this.class88_0.NoWaterCapture = new Class150(@class);
						this.class88_0.NoWaterBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.PickFlowerButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_18, GardenerFloraCaptureSetup.string_19, this.class88_0.PickFlowerBounds, out @class, out @struct))
					{
						if (this.class88_0.PickFlowerCapture != null)
						{
							this.class88_0.PickFlowerCapture.Dispose();
							this.class88_0.PickFlowerCapture = null;
						}
						this.class88_0.PickFlowerCapture = new Class150(@class);
						this.class88_0.PickFlowerBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.BasketFullButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_20, GardenerFloraCaptureSetup.string_21, this.class88_0.BasketFullBounds, out @class, out @struct))
					{
						if (this.class88_0.BasketFullCapture != null)
						{
							this.class88_0.BasketFullCapture.Dispose();
							this.class88_0.BasketFullCapture = null;
						}
						this.class88_0.BasketFullCapture = new Class150(@class);
						this.class88_0.BasketFullBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.SellFlowersButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_22, GardenerFloraCaptureSetup.string_23, this.class88_0.SellFlowersBounds, out @class, out @struct))
					{
						if (this.class88_0.SellFlowersCapture != null)
						{
							this.class88_0.SellFlowersCapture.Dispose();
							this.class88_0.SellFlowersCapture = null;
						}
						this.class88_0.SellFlowersCapture = new Class150(@class);
						this.class88_0.SellFlowersBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.DisabledBeanSlot))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_24, GardenerFloraCaptureSetup.string_25, this.class88_0.DisabledBeanSlotBounds, out @class, out @struct))
					{
						if (this.class88_0.DisabledBeanSlotCapture != null)
						{
							this.class88_0.DisabledBeanSlotCapture.Dispose();
							this.class88_0.DisabledBeanSlotCapture = null;
						}
						this.class88_0.DisabledBeanSlotCapture = new Class150(@class);
						this.class88_0.DisabledBeanSlotBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.FinalPickButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_26, GardenerFloraCaptureSetup.string_27, this.class88_0.FinalPickBounds, out @class, out @struct))
					{
						if (this.class88_0.FinalPickCapture != null)
						{
							this.class88_0.FinalPickCapture.Dispose();
							this.class88_0.FinalPickCapture = null;
						}
						this.class88_0.FinalPickCapture = new Class150(@class);
						this.class88_0.FinalPickBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.CancelPlantButton))
				{
					if (base.method_10(GardenerFloraCaptureSetup.string_28, GardenerFloraCaptureSetup.string_8, this.class88_0.CancelPlantBounds, out @class, out @struct))
					{
						if (this.class88_0.CancelPlantCapture != null)
						{
							this.class88_0.CancelPlantCapture.Dispose();
							this.class88_0.CancelPlantCapture = null;
						}
						this.class88_0.CancelPlantCapture = new Class150(@class);
						this.class88_0.CancelPlantBounds = @struct;
						base.FileModified = true;
					}
				}
				else if (object.ReferenceEquals(sender, this.NoRemoveButton) && base.method_10(GardenerFloraCaptureSetup.string_29, GardenerFloraCaptureSetup.string_30, this.class88_0.NoRemoveBounds, out @class, out @struct))
				{
					if (this.class88_0.NoRemoveCapture != null)
					{
						this.class88_0.NoRemoveCapture.Dispose();
						this.class88_0.NoRemoveCapture = null;
					}
					this.class88_0.NoRemoveCapture = new Class150(@class);
					this.class88_0.NoRemoveBounds = @struct;
					base.FileModified = true;
				}
			}
			catch
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				throw;
			}
			this.method_14();
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00081760 File Offset: 0x0007F960
		private void PickFlowerButton_MouseHover(object sender, EventArgs e)
		{
			Class150 @class;
			Control control;
			if (object.ReferenceEquals(sender, this.PlantButton))
			{
				@class = this.class88_0.PlantFlowerCapture;
				control = this.PlantButton;
			}
			else if (object.ReferenceEquals(sender, this.FinalPlantButton))
			{
				@class = this.class88_0.FinalPlantCapture;
				control = this.FinalPlantButton;
			}
			else if (object.ReferenceEquals(sender, this.NoWaterButton))
			{
				@class = this.class88_0.NoWaterCapture;
				control = this.NoWaterButton;
			}
			else if (object.ReferenceEquals(sender, this.PickFlowerButton))
			{
				@class = this.class88_0.PickFlowerCapture;
				control = this.PickFlowerButton;
			}
			else if (object.ReferenceEquals(sender, this.PlantSuccessButton))
			{
				@class = this.class88_0.PlantSuccessCapture;
				control = this.PlantSuccessButton;
			}
			else if (object.ReferenceEquals(sender, this.PlantFailedButton))
			{
				@class = this.class88_0.PlantFailedCapture;
				control = this.PlantFailedButton;
			}
			else if (object.ReferenceEquals(sender, this.WaterButton))
			{
				@class = this.class88_0.WaterPlantCapture;
				control = this.WaterButton;
			}
			else if (object.ReferenceEquals(sender, this.BasketFullButton))
			{
				@class = this.class88_0.BasketFullCapture;
				control = this.BasketFullButton;
			}
			else if (object.ReferenceEquals(sender, this.SellFlowersButton))
			{
				@class = this.class88_0.SellFlowersCapture;
				control = this.SellFlowersButton;
			}
			else if (object.ReferenceEquals(sender, this.DisabledBeanSlot))
			{
				@class = this.class88_0.DisabledBeanSlotCapture;
				control = this.DisabledBeanSlot;
			}
			else if (object.ReferenceEquals(sender, this.FinalPickButton))
			{
				@class = this.class88_0.FinalPickCapture;
				control = this.FinalPickButton;
			}
			else if (object.ReferenceEquals(sender, this.CancelPlantButton))
			{
				@class = this.class88_0.CancelPlantCapture;
				control = this.CancelPlantButton;
			}
			else
			{
				if (!object.ReferenceEquals(sender, this.NoRemoveButton))
				{
					return;
				}
				@class = this.class88_0.NoRemoveCapture;
				control = this.NoRemoveButton;
			}
			if (@class != null && control != null)
			{
				base.method_11(@class, control);
			}
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00007138 File Offset: 0x00005338
		private void PickFlowerButton_MouseLeave(object sender, EventArgs e)
		{
			base.method_12();
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00007140 File Offset: 0x00005340
		private void GuideHelpMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_21);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00081960 File Offset: 0x0007FB60
		private void InitializeComponent_2()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GardenerFloraCaptureSetup));
			this.JoeFishCaptureSetupPanel = new Class310();
			this.PlantButton = new LinkLabel();
			this.PlantFailedButton = new LinkLabel();
			this.FinalPickButtonState = new Control12();
			this.NoRemoveButtonState = new Control12();
			this.FinalPlantButtonState = new Control12();
			this.WaterButton = new LinkLabel();
			this.PickFlowerButtonState = new Control12();
			this.CaptureLabel = new Label();
			this.PlantSuccessButton = new LinkLabel();
			this.CaptureLogo = new PictureBox();
			this.StatusLabel = new Label();
			this.CancelPlantButton = new LinkLabel();
			this.DisabledBeanSlot = new LinkLabel();
			this.SellFlowersButton = new LinkLabel();
			this.BasketFullButton = new LinkLabel();
			this.NoWaterButton = new LinkLabel();
			this.CancelPlantButtonState = new Control12();
			this.PlantSuccessButtonState = new Control12();
			this.DisabledBeanSlotState = new Control12();
			this.HelpDescription = new Label();
			this.SellFlowersButtonState = new Control12();
			this.BasketFullButtonState = new Control12();
			this.PlantFailedButtonState = new Control12();
			this.NoWaterButtonState = new Control12();
			this.PlantFlowerButtonState = new Control12();
			this.NoRemoveButton = new LinkLabel();
			this.FinalPickButton = new LinkLabel();
			this.FinalPlantButton = new LinkLabel();
			this.PickFlowerButton = new LinkLabel();
			this.WaterPlantButtonState = new Control12();
			this.lblContentPackTitle = new Label();
			this.CaptureSetupContainer = new Panel();
			this.GardenerFloraCaptureSetupMenu = new MenuStrip();
			this.FileMenu = new ToolStripMenuItem();
			this.NewFileMenuItem = new ToolStripMenuItem();
			this.OpenFileMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.SaveFileMenuItem = new ToolStripMenuItem();
			this.SaveAsFileMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.CloseFileMenuItem = new ToolStripMenuItem();
			this.WindowMenu = new ToolStripMenuItem();
			this.SelectWindowMenuItem = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideHelpMenuItem = new ToolStripMenuItem();
			this.JoeFishCaptureSetupPanel.SuspendLayout();
			((ISupportInitialize)this.CaptureLogo).BeginInit();
			this.CaptureSetupContainer.SuspendLayout();
			this.GardenerFloraCaptureSetupMenu.SuspendLayout();
			base.SuspendLayout();
			this.JoeFishCaptureSetupPanel.CenterColor = Color.FromArgb(224, 224, 224);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantFailedButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FinalPickButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoRemoveButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FinalPlantButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.WaterButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PickFlowerButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CaptureLabel);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantSuccessButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CaptureLogo);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.StatusLabel);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CancelPlantButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.DisabledBeanSlot);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.SellFlowersButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BasketFullButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoWaterButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.CancelPlantButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantSuccessButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.DisabledBeanSlotState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.HelpDescription);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.SellFlowersButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.BasketFullButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantFailedButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoWaterButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PlantFlowerButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.NoRemoveButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FinalPickButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.FinalPlantButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.PickFlowerButton);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.WaterPlantButtonState);
			this.JoeFishCaptureSetupPanel.Controls.Add(this.lblContentPackTitle);
			this.JoeFishCaptureSetupPanel.Dock = DockStyle.Fill;
			this.JoeFishCaptureSetupPanel.HeaderHeight = 30;
			this.JoeFishCaptureSetupPanel.ImageBounds = new Rectangle(0, 0, 0, 0);
			this.JoeFishCaptureSetupPanel.ImageLocation = new Point(0, 0);
			this.JoeFishCaptureSetupPanel.Location = new Point(0, 0);
			this.JoeFishCaptureSetupPanel.Name = "JoeFishCaptureSetupPanel";
			this.JoeFishCaptureSetupPanel.Size = new Size(468, 358);
			this.JoeFishCaptureSetupPanel.TabIndex = 32;
			this.PlantButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.PlantButton.AutoSize = true;
			this.PlantButton.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantButton.Font = new Font("Calibri", 12f);
			this.PlantButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.PlantButton.Location = new Point(55, 236);
			this.PlantButton.Name = "PlantButton";
			this.PlantButton.Size = new Size(136, 19);
			this.PlantButton.TabIndex = 40;
			this.PlantButton.TabStop = true;
			this.PlantButton.Text = "Plant Flower Button";
			this.PlantButton.Click += this.PickFlowerButton_Click;
			this.PlantButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.PlantButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.PlantFailedButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.PlantFailedButton.AutoSize = true;
			this.PlantFailedButton.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantFailedButton.Font = new Font("Calibri", 12f);
			this.PlantFailedButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.PlantFailedButton.Location = new Point(55, 215);
			this.PlantFailedButton.Name = "PlantFailedButton";
			this.PlantFailedButton.Size = new Size(132, 19);
			this.PlantFailedButton.TabIndex = 36;
			this.PlantFailedButton.TabStop = true;
			this.PlantFailedButton.Text = "Plant Failed Button";
			this.PlantFailedButton.Click += this.PickFlowerButton_Click;
			this.PlantFailedButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.PlantFailedButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.FinalPickButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.FinalPickButtonState.Location = new Point(24, 131);
			this.FinalPickButtonState.Name = "FinalPickButtonState";
			this.FinalPickButtonState.On = true;
			this.FinalPickButtonState.Size = new Size(19, 19);
			this.FinalPickButtonState.TabIndex = 27;
			this.FinalPickButtonState.Text = "led1";
			this.NoRemoveButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.NoRemoveButtonState.Location = new Point(24, 173);
			this.NoRemoveButtonState.Name = "NoRemoveButtonState";
			this.NoRemoveButtonState.On = true;
			this.NoRemoveButtonState.Size = new Size(19, 19);
			this.NoRemoveButtonState.TabIndex = 27;
			this.NoRemoveButtonState.Text = "led1";
			this.FinalPlantButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.FinalPlantButtonState.Location = new Point(24, 152);
			this.FinalPlantButtonState.Name = "FinalPlantButtonState";
			this.FinalPlantButtonState.On = true;
			this.FinalPlantButtonState.Size = new Size(19, 19);
			this.FinalPlantButtonState.TabIndex = 27;
			this.FinalPlantButtonState.Text = "led1";
			this.WaterButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.WaterButton.AutoSize = true;
			this.WaterButton.BackColor = Color.FromArgb(224, 224, 224);
			this.WaterButton.Font = new Font("Calibri", 12f);
			this.WaterButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.WaterButton.Location = new Point(55, 320);
			this.WaterButton.Name = "WaterButton";
			this.WaterButton.Size = new Size(132, 19);
			this.WaterButton.TabIndex = 35;
			this.WaterButton.TabStop = true;
			this.WaterButton.Text = "Water Plant Button";
			this.WaterButton.Click += this.PickFlowerButton_Click;
			this.WaterButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.WaterButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.PickFlowerButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.PickFlowerButtonState.Location = new Point(24, 278);
			this.PickFlowerButtonState.Name = "PickFlowerButtonState";
			this.PickFlowerButtonState.On = true;
			this.PickFlowerButtonState.Size = new Size(19, 19);
			this.PickFlowerButtonState.TabIndex = 30;
			this.PickFlowerButtonState.Text = "led1";
			this.CaptureLabel.AutoSize = true;
			this.CaptureLabel.BackColor = Color.FromArgb(224, 224, 224);
			this.CaptureLabel.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.CaptureLabel.ForeColor = Color.DimGray;
			this.CaptureLabel.Location = new Point(55, 46);
			this.CaptureLabel.Name = "CaptureLabel";
			this.CaptureLabel.Size = new Size(60, 19);
			this.CaptureLabel.TabIndex = 44;
			this.CaptureLabel.Text = "Capture";
			this.PlantSuccessButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.PlantSuccessButton.AutoSize = true;
			this.PlantSuccessButton.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantSuccessButton.Font = new Font("Calibri", 12f);
			this.PlantSuccessButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.PlantSuccessButton.Location = new Point(55, 257);
			this.PlantSuccessButton.Name = "PlantSuccessButton";
			this.PlantSuccessButton.Size = new Size(144, 19);
			this.PlantSuccessButton.TabIndex = 39;
			this.PlantSuccessButton.TabStop = true;
			this.PlantSuccessButton.Text = "Plant Success Button";
			this.PlantSuccessButton.Click += this.PickFlowerButton_Click;
			this.PlantSuccessButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.PlantSuccessButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.CaptureLogo.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.CaptureLogo.BackColor = Color.FromArgb(224, 224, 224);
			this.CaptureLogo.Image = (Image)componentResourceManager.GetObject("CaptureLogo.Image");
			this.CaptureLogo.Location = new Point(397, 288);
			this.CaptureLogo.Name = "CaptureLogo";
			this.CaptureLogo.Size = new Size(64, 64);
			this.CaptureLogo.SizeMode = PictureBoxSizeMode.AutoSize;
			this.CaptureLogo.TabIndex = 46;
			this.CaptureLogo.TabStop = false;
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = Color.FromArgb(224, 224, 224);
			this.StatusLabel.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.StatusLabel.ForeColor = Color.DimGray;
			this.StatusLabel.Location = new Point(13, 46);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new Size(42, 19);
			this.StatusLabel.TabIndex = 45;
			this.StatusLabel.Text = "State";
			this.CancelPlantButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.CancelPlantButton.AutoSize = true;
			this.CancelPlantButton.BackColor = Color.FromArgb(224, 224, 224);
			this.CancelPlantButton.Font = new Font("Calibri", 12f);
			this.CancelPlantButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.CancelPlantButton.Location = new Point(55, 89);
			this.CancelPlantButton.Name = "CancelPlantButton";
			this.CancelPlantButton.Size = new Size(137, 19);
			this.CancelPlantButton.TabIndex = 43;
			this.CancelPlantButton.TabStop = true;
			this.CancelPlantButton.Text = "Cancel Plant Button";
			this.CancelPlantButton.Click += this.PickFlowerButton_Click;
			this.CancelPlantButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.CancelPlantButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.DisabledBeanSlot.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.DisabledBeanSlot.AutoSize = true;
			this.DisabledBeanSlot.BackColor = Color.FromArgb(224, 224, 224);
			this.DisabledBeanSlot.Font = new Font("Calibri", 12f);
			this.DisabledBeanSlot.LinkColor = Color.FromArgb(51, 153, 255);
			this.DisabledBeanSlot.Location = new Point(55, 110);
			this.DisabledBeanSlot.Name = "DisabledBeanSlot";
			this.DisabledBeanSlot.Size = new Size(131, 19);
			this.DisabledBeanSlot.TabIndex = 43;
			this.DisabledBeanSlot.TabStop = true;
			this.DisabledBeanSlot.Text = "Disabled Bean Slot";
			this.DisabledBeanSlot.Click += this.PickFlowerButton_Click;
			this.DisabledBeanSlot.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.DisabledBeanSlot.MouseHover += this.PickFlowerButton_MouseHover;
			this.SellFlowersButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.SellFlowersButton.AutoSize = true;
			this.SellFlowersButton.BackColor = Color.FromArgb(224, 224, 224);
			this.SellFlowersButton.Font = new Font("Calibri", 12f);
			this.SellFlowersButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.SellFlowersButton.Location = new Point(55, 299);
			this.SellFlowersButton.Name = "SellFlowersButton";
			this.SellFlowersButton.Size = new Size(133, 19);
			this.SellFlowersButton.TabIndex = 43;
			this.SellFlowersButton.TabStop = true;
			this.SellFlowersButton.Text = "Sell Flowers Button";
			this.SellFlowersButton.Click += this.PickFlowerButton_Click;
			this.SellFlowersButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.SellFlowersButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.BasketFullButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.BasketFullButton.AutoSize = true;
			this.BasketFullButton.BackColor = Color.FromArgb(224, 224, 224);
			this.BasketFullButton.Font = new Font("Calibri", 12f);
			this.BasketFullButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.BasketFullButton.Location = new Point(55, 68);
			this.BasketFullButton.Name = "BasketFullButton";
			this.BasketFullButton.Size = new Size(126, 19);
			this.BasketFullButton.TabIndex = 43;
			this.BasketFullButton.TabStop = true;
			this.BasketFullButton.Text = "Basket Full Button";
			this.BasketFullButton.Click += this.PickFlowerButton_Click;
			this.BasketFullButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.BasketFullButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.NoWaterButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.NoWaterButton.AutoSize = true;
			this.NoWaterButton.BackColor = Color.FromArgb(224, 224, 224);
			this.NoWaterButton.Font = new Font("Calibri", 12f);
			this.NoWaterButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.NoWaterButton.Location = new Point(55, 194);
			this.NoWaterButton.Name = "NoWaterButton";
			this.NoWaterButton.Size = new Size(117, 19);
			this.NoWaterButton.TabIndex = 43;
			this.NoWaterButton.TabStop = true;
			this.NoWaterButton.Text = "No Water Button";
			this.NoWaterButton.Click += this.PickFlowerButton_Click;
			this.NoWaterButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.NoWaterButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.CancelPlantButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.CancelPlantButtonState.Location = new Point(24, 89);
			this.CancelPlantButtonState.Name = "CancelPlantButtonState";
			this.CancelPlantButtonState.On = true;
			this.CancelPlantButtonState.Size = new Size(19, 19);
			this.CancelPlantButtonState.TabIndex = 29;
			this.CancelPlantButtonState.Text = "led1";
			this.PlantSuccessButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantSuccessButtonState.Location = new Point(24, 257);
			this.PlantSuccessButtonState.Name = "PlantSuccessButtonState";
			this.PlantSuccessButtonState.On = true;
			this.PlantSuccessButtonState.Size = new Size(19, 19);
			this.PlantSuccessButtonState.TabIndex = 21;
			this.PlantSuccessButtonState.Text = "led1";
			this.DisabledBeanSlotState.BackColor = Color.FromArgb(224, 224, 224);
			this.DisabledBeanSlotState.Location = new Point(24, 110);
			this.DisabledBeanSlotState.Name = "DisabledBeanSlotState";
			this.DisabledBeanSlotState.On = true;
			this.DisabledBeanSlotState.Size = new Size(19, 19);
			this.DisabledBeanSlotState.TabIndex = 29;
			this.DisabledBeanSlotState.Text = "led1";
			this.HelpDescription.BackColor = Color.FromArgb(224, 224, 224);
			this.HelpDescription.ForeColor = Color.DimGray;
			this.HelpDescription.Location = new Point(214, 72);
			this.HelpDescription.Name = "HelpDescription";
			this.HelpDescription.Size = new Size(238, 163);
			this.HelpDescription.TabIndex = 33;
			this.HelpDescription.Text = componentResourceManager.GetString("HelpDescription.Text");
			this.SellFlowersButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.SellFlowersButtonState.Location = new Point(24, 299);
			this.SellFlowersButtonState.Name = "SellFlowersButtonState";
			this.SellFlowersButtonState.On = true;
			this.SellFlowersButtonState.Size = new Size(19, 19);
			this.SellFlowersButtonState.TabIndex = 29;
			this.SellFlowersButtonState.Text = "led1";
			this.BasketFullButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.BasketFullButtonState.Location = new Point(24, 68);
			this.BasketFullButtonState.Name = "BasketFullButtonState";
			this.BasketFullButtonState.On = true;
			this.BasketFullButtonState.Size = new Size(19, 19);
			this.BasketFullButtonState.TabIndex = 29;
			this.BasketFullButtonState.Text = "led1";
			this.PlantFailedButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantFailedButtonState.Location = new Point(24, 215);
			this.PlantFailedButtonState.Name = "PlantFailedButtonState";
			this.PlantFailedButtonState.On = true;
			this.PlantFailedButtonState.Size = new Size(19, 19);
			this.PlantFailedButtonState.TabIndex = 26;
			this.PlantFailedButtonState.Text = "led1";
			this.NoWaterButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.NoWaterButtonState.Location = new Point(24, 194);
			this.NoWaterButtonState.Name = "NoWaterButtonState";
			this.NoWaterButtonState.On = true;
			this.NoWaterButtonState.Size = new Size(19, 19);
			this.NoWaterButtonState.TabIndex = 29;
			this.NoWaterButtonState.Text = "led1";
			this.PlantFlowerButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.PlantFlowerButtonState.Location = new Point(24, 236);
			this.PlantFlowerButtonState.Name = "PlantFlowerButtonState";
			this.PlantFlowerButtonState.On = true;
			this.PlantFlowerButtonState.Size = new Size(19, 19);
			this.PlantFlowerButtonState.TabIndex = 25;
			this.PlantFlowerButtonState.Text = "led1";
			this.NoRemoveButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.NoRemoveButton.AutoSize = true;
			this.NoRemoveButton.BackColor = Color.FromArgb(224, 224, 224);
			this.NoRemoveButton.Font = new Font("Calibri", 12f);
			this.NoRemoveButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.NoRemoveButton.Location = new Point(55, 173);
			this.NoRemoveButton.Name = "NoRemoveButton";
			this.NoRemoveButton.Size = new Size(130, 19);
			this.NoRemoveButton.TabIndex = 42;
			this.NoRemoveButton.TabStop = true;
			this.NoRemoveButton.Text = "No Remove Button";
			this.NoRemoveButton.Click += this.PickFlowerButton_Click;
			this.NoRemoveButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.NoRemoveButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.FinalPickButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.FinalPickButton.AutoSize = true;
			this.FinalPickButton.BackColor = Color.FromArgb(224, 224, 224);
			this.FinalPickButton.Font = new Font("Calibri", 12f);
			this.FinalPickButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.FinalPickButton.Location = new Point(55, 131);
			this.FinalPickButton.Name = "FinalPickButton";
			this.FinalPickButton.Size = new Size(117, 19);
			this.FinalPickButton.TabIndex = 42;
			this.FinalPickButton.TabStop = true;
			this.FinalPickButton.Text = "Final Pick Button";
			this.FinalPickButton.Click += this.PickFlowerButton_Click;
			this.FinalPickButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.FinalPickButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.FinalPlantButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.FinalPlantButton.AutoSize = true;
			this.FinalPlantButton.BackColor = Color.FromArgb(224, 224, 224);
			this.FinalPlantButton.Font = new Font("Calibri", 12f);
			this.FinalPlantButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.FinalPlantButton.Location = new Point(55, 152);
			this.FinalPlantButton.Name = "FinalPlantButton";
			this.FinalPlantButton.Size = new Size(124, 19);
			this.FinalPlantButton.TabIndex = 42;
			this.FinalPlantButton.TabStop = true;
			this.FinalPlantButton.Text = "Final Plant Button";
			this.FinalPlantButton.Click += this.PickFlowerButton_Click;
			this.FinalPlantButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.FinalPlantButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.PickFlowerButton.ActiveLinkColor = Color.FromArgb(51, 153, 255);
			this.PickFlowerButton.AutoSize = true;
			this.PickFlowerButton.BackColor = Color.FromArgb(224, 224, 224);
			this.PickFlowerButton.Font = new Font("Calibri", 12f);
			this.PickFlowerButton.LinkColor = Color.FromArgb(51, 153, 255);
			this.PickFlowerButton.Location = new Point(55, 278);
			this.PickFlowerButton.Name = "PickFlowerButton";
			this.PickFlowerButton.Size = new Size(129, 19);
			this.PickFlowerButton.TabIndex = 41;
			this.PickFlowerButton.TabStop = true;
			this.PickFlowerButton.Text = "Pick Flower Button";
			this.PickFlowerButton.Click += this.PickFlowerButton_Click;
			this.PickFlowerButton.MouseLeave += this.PickFlowerButton_MouseLeave;
			this.PickFlowerButton.MouseHover += this.PickFlowerButton_MouseHover;
			this.WaterPlantButtonState.BackColor = Color.FromArgb(224, 224, 224);
			this.WaterPlantButtonState.Location = new Point(24, 320);
			this.WaterPlantButtonState.Name = "WaterPlantButtonState";
			this.WaterPlantButtonState.On = true;
			this.WaterPlantButtonState.Size = new Size(19, 19);
			this.WaterPlantButtonState.TabIndex = 24;
			this.WaterPlantButtonState.Text = "led1";
			this.lblContentPackTitle.AutoSize = true;
			this.lblContentPackTitle.BackColor = Color.Transparent;
			this.lblContentPackTitle.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.lblContentPackTitle.ForeColor = Color.Gray;
			this.lblContentPackTitle.Location = new Point(10, 8);
			this.lblContentPackTitle.Name = "lblContentPackTitle";
			this.lblContentPackTitle.Size = new Size(221, 19);
			this.lblContentPackTitle.TabIndex = 32;
			this.lblContentPackTitle.Text = "Gardener Flora : Capture Setup";
			this.CaptureSetupContainer.Controls.Add(this.JoeFishCaptureSetupPanel);
			this.CaptureSetupContainer.Dock = DockStyle.Fill;
			this.CaptureSetupContainer.Location = new Point(0, 24);
			this.CaptureSetupContainer.Name = "CaptureSetupContainer";
			this.CaptureSetupContainer.Size = new Size(468, 358);
			this.CaptureSetupContainer.TabIndex = 34;
			this.GardenerFloraCaptureSetupMenu.Items.AddRange(new ToolStripItem[]
			{
				this.FileMenu,
				this.WindowMenu,
				this.HelpMenuItem
			});
			this.GardenerFloraCaptureSetupMenu.Location = new Point(0, 0);
			this.GardenerFloraCaptureSetupMenu.Name = "GardenerFloraCaptureSetupMenu";
			this.GardenerFloraCaptureSetupMenu.Size = new Size(468, 24);
			this.GardenerFloraCaptureSetupMenu.TabIndex = 35;
			this.GardenerFloraCaptureSetupMenu.Text = "menuStrip1";
			this.FileMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NewFileMenuItem,
				this.OpenFileMenuItem,
				this.toolStripSeparator1,
				this.SaveFileMenuItem,
				this.SaveAsFileMenuItem,
				this.toolStripSeparator2,
				this.CloseFileMenuItem
			});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new Size(37, 20);
			this.FileMenu.Text = "&File";
			this.NewFileMenuItem.Name = "NewFileMenuItem";
			this.NewFileMenuItem.ShortcutKeys = (Keys)131150;
			this.NewFileMenuItem.Size = new Size(192, 22);
			this.NewFileMenuItem.Text = "&New";
			this.OpenFileMenuItem.Name = "OpenFileMenuItem";
			this.OpenFileMenuItem.ShortcutKeys = (Keys)131151;
			this.OpenFileMenuItem.Size = new Size(192, 22);
			this.OpenFileMenuItem.Text = "&Open";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(189, 6);
			this.SaveFileMenuItem.Name = "SaveFileMenuItem";
			this.SaveFileMenuItem.ShortcutKeys = (Keys)131155;
			this.SaveFileMenuItem.Size = new Size(192, 22);
			this.SaveFileMenuItem.Text = "&Save";
			this.SaveAsFileMenuItem.Name = "SaveAsFileMenuItem";
			this.SaveAsFileMenuItem.ShortcutKeys = (Keys)196691;
			this.SaveAsFileMenuItem.Size = new Size(192, 22);
			this.SaveAsFileMenuItem.Text = "Save &As..";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(189, 6);
			this.CloseFileMenuItem.Name = "CloseFileMenuItem";
			this.CloseFileMenuItem.ShortcutKeys = (Keys)131159;
			this.CloseFileMenuItem.Size = new Size(192, 22);
			this.CloseFileMenuItem.Text = "&Close";
			this.WindowMenu.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.SelectWindowMenuItem
			});
			this.WindowMenu.Name = "WindowMenu";
			this.WindowMenu.Size = new Size(63, 20);
			this.WindowMenu.Text = "&Window";
			this.SelectWindowMenuItem.Name = "SelectWindowMenuItem";
			this.SelectWindowMenuItem.Size = new Size(213, 22);
			this.SelectWindowMenuItem.Text = "&Select ToonTown Window";
			this.SelectWindowMenuItem.Click += this.SelectWindowMenuItem_Click;
			this.HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.GuideHelpMenuItem
			});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			this.GuideHelpMenuItem.Name = "GuideHelpMenuItem";
			this.GuideHelpMenuItem.ShortcutKeys = Keys.F1;
			this.GuideHelpMenuItem.Size = new Size(124, 22);
			this.GuideHelpMenuItem.Text = "&Guide";
			this.GuideHelpMenuItem.Click += this.GuideHelpMenuItem_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(218, 228, 246);
			base.ClientSize = new Size(468, 382);
			base.Controls.Add(this.CaptureSetupContainer);
			base.Controls.Add(this.GardenerFloraCaptureSetupMenu);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MainMenuStrip = this.GardenerFloraCaptureSetupMenu;
			base.MaximizeBox = false;
			this.MaximumSize = new Size(474, 410);
			this.MinimumSize = new Size(474, 410);
			base.Name = "GardenerFloraCaptureSetup";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Gardener Flora : Capture Setup : New File";
			this.JoeFishCaptureSetupPanel.ResumeLayout(false);
			this.JoeFishCaptureSetupPanel.PerformLayout();
			((ISupportInitialize)this.CaptureLogo).EndInit();
			this.CaptureSetupContainer.ResumeLayout(false);
			this.GardenerFloraCaptureSetupMenu.ResumeLayout(false);
			this.GardenerFloraCaptureSetupMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400118E RID: 4494
		private static readonly string string_0 = "Please enter a reference name for this capture file.";

		// Token: 0x0400118F RID: 4495
		private static readonly string string_1 = "The ToonTown Spoofer : Gardener Flora Capture Setup File Name";

		// Token: 0x04001190 RID: 4496
		private static readonly string string_2 = "Gardener Flora Capture Setup filename: '{0}'.";

		// Token: 0x04001191 RID: 4497
		private static readonly string string_3 = "Gardener Flora : Capture Setup : New File*";

		// Token: 0x04001192 RID: 4498
		private static readonly string string_4 = "Gardener Flora : Capture Setup : New File";

		// Token: 0x04001193 RID: 4499
		private static readonly string string_5 = "Gardener Flora : Capture Setup : {0}*";

		// Token: 0x04001194 RID: 4500
		private static readonly string string_6 = "Gardener Flora : Capture Setup : ";

		// Token: 0x04001195 RID: 4501
		private static readonly string string_7 = "Click the Plant button and click to drag a selection rectangle around the final Plant button on the bean select panel.";

		// Token: 0x04001196 RID: 4502
		private static readonly string string_8 = "Please click the Plant button.";

		// Token: 0x04001197 RID: 4503
		private static readonly string string_9 = "Click to drag a selection rectangle around the Plant button.";

		// Token: 0x04001198 RID: 4504
		private static readonly string string_10 = "Please stand near an empty planter where the Plant button is visible.";

		// Token: 0x04001199 RID: 4505
		private static readonly string string_11 = "Click to drag a selection rectangle around the OK button.";

		// Token: 0x0400119A RID: 4506
		private static readonly string string_12 = "Attempt to plant a flower with an invalid bean combination (hint: single red bean).";

		// Token: 0x0400119B RID: 4507
		private static readonly string string_13 = "Plant a flower with any combination (hint: single green bean).";

		// Token: 0x0400119C RID: 4508
		private static readonly string string_14 = "Click to drag a selection rectangle around the Water button.";

		// Token: 0x0400119D RID: 4509
		private static readonly string string_15 = "Please stand near a plant where the Water button is visible.";

		// Token: 0x0400119E RID: 4510
		private static readonly string string_16 = "Click to drag a selection rectangle, at a location where there is no plant, around the location where the Water button should appear.";

		// Token: 0x0400119F RID: 4511
		private static readonly string string_17 = "Please stand near an empty planter.";

		// Token: 0x040011A0 RID: 4512
		private static readonly string string_18 = "Click to drag a selection rectangle around the Pick button.";

		// Token: 0x040011A1 RID: 4513
		private static readonly string string_19 = "Please stand near a flower where the Pick button is visible.";

		// Token: 0x040011A2 RID: 4514
		private static readonly string string_20 = "Click to drag a selection rectangle around the OK button on the basket full panel.";

		// Token: 0x040011A3 RID: 4515
		private static readonly string string_21 = "Please attempt to pick a flower when your basket is full.";

		// Token: 0x040011A4 RID: 4516
		private static readonly string string_22 = "Click to drag a selection rectangle around the Sell All button.";

		// Token: 0x040011A5 RID: 4517
		private static readonly string string_23 = "Please stand near the wheelbarrow where the Sell All button is visible.";

		// Token: 0x040011A6 RID: 4518
		private static readonly string string_24 = "Click to drag a selection rectangle in an empty, disabled bean slot.";

		// Token: 0x040011A7 RID: 4519
		private static readonly string string_25 = "Please click the Plant button. If you do not have any disabled bean slots due to being able to plant 8 bean flowers, you may need to create a new toon.";

		// Token: 0x040011A8 RID: 4520
		private static readonly string string_26 = "Click to drag a selection rectangle around the final pick (Yes) button.";

		// Token: 0x040011A9 RID: 4521
		private static readonly string string_27 = "Please click the Pick button.";

		// Token: 0x040011AA RID: 4522
		private static readonly string string_28 = "Click to drag a selection rectangle around the button to cancel planting.";

		// Token: 0x040011AB RID: 4523
		private static readonly string string_29 = "Click to drag a selection rectangle around the No button to cancel removing a flower.";

		// Token: 0x040011AC RID: 4524
		private static readonly string string_30 = "Please locate a flower that has not bloomed and click the Remove button.";

		// Token: 0x040011AE RID: 4526
		private Class114 class114_0;

		// Token: 0x040011B0 RID: 4528
		private Class310 JoeFishCaptureSetupPanel;

		// Token: 0x040011B1 RID: 4529
		private LinkLabel PlantButton;

		// Token: 0x040011B2 RID: 4530
		private LinkLabel PlantFailedButton;

		// Token: 0x040011B3 RID: 4531
		private Control12 FinalPlantButtonState;

		// Token: 0x040011B4 RID: 4532
		private LinkLabel WaterButton;

		// Token: 0x040011B5 RID: 4533
		private Control12 PickFlowerButtonState;

		// Token: 0x040011B6 RID: 4534
		private Label CaptureLabel;

		// Token: 0x040011B7 RID: 4535
		private LinkLabel PlantSuccessButton;

		// Token: 0x040011B8 RID: 4536
		private PictureBox CaptureLogo;

		// Token: 0x040011B9 RID: 4537
		private Label StatusLabel;

		// Token: 0x040011BA RID: 4538
		private LinkLabel NoWaterButton;

		// Token: 0x040011BB RID: 4539
		private Control12 PlantSuccessButtonState;

		// Token: 0x040011BC RID: 4540
		private Label HelpDescription;

		// Token: 0x040011BD RID: 4541
		private Control12 PlantFailedButtonState;

		// Token: 0x040011BE RID: 4542
		private Control12 NoWaterButtonState;

		// Token: 0x040011BF RID: 4543
		private Control12 PlantFlowerButtonState;

		// Token: 0x040011C0 RID: 4544
		private LinkLabel FinalPlantButton;

		// Token: 0x040011C1 RID: 4545
		private LinkLabel PickFlowerButton;

		// Token: 0x040011C2 RID: 4546
		private Control12 WaterPlantButtonState;

		// Token: 0x040011C3 RID: 4547
		private Label lblContentPackTitle;

		// Token: 0x040011C4 RID: 4548
		private LinkLabel BasketFullButton;

		// Token: 0x040011C5 RID: 4549
		private Control12 BasketFullButtonState;

		// Token: 0x040011C6 RID: 4550
		private LinkLabel SellFlowersButton;

		// Token: 0x040011C7 RID: 4551
		private Control12 SellFlowersButtonState;

		// Token: 0x040011C8 RID: 4552
		private LinkLabel DisabledBeanSlot;

		// Token: 0x040011C9 RID: 4553
		private Control12 DisabledBeanSlotState;

		// Token: 0x040011CA RID: 4554
		private Control12 FinalPickButtonState;

		// Token: 0x040011CB RID: 4555
		private LinkLabel FinalPickButton;

		// Token: 0x040011CC RID: 4556
		private LinkLabel CancelPlantButton;

		// Token: 0x040011CD RID: 4557
		private Control12 CancelPlantButtonState;

		// Token: 0x040011CE RID: 4558
		private Control12 NoRemoveButtonState;

		// Token: 0x040011CF RID: 4559
		private LinkLabel NoRemoveButton;

		// Token: 0x040011D0 RID: 4560
		private Panel CaptureSetupContainer;

		// Token: 0x040011D1 RID: 4561
		private MenuStrip GardenerFloraCaptureSetupMenu;

		// Token: 0x040011D2 RID: 4562
		private ToolStripMenuItem FileMenu;

		// Token: 0x040011D3 RID: 4563
		private ToolStripMenuItem NewFileMenuItem;

		// Token: 0x040011D4 RID: 4564
		private ToolStripMenuItem OpenFileMenuItem;

		// Token: 0x040011D5 RID: 4565
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x040011D6 RID: 4566
		private ToolStripMenuItem SaveFileMenuItem;

		// Token: 0x040011D7 RID: 4567
		private ToolStripMenuItem SaveAsFileMenuItem;

		// Token: 0x040011D8 RID: 4568
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x040011D9 RID: 4569
		private ToolStripMenuItem CloseFileMenuItem;

		// Token: 0x040011DA RID: 4570
		private ToolStripMenuItem WindowMenu;

		// Token: 0x040011DB RID: 4571
		private ToolStripMenuItem SelectWindowMenuItem;

		// Token: 0x040011DC RID: 4572
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x040011DD RID: 4573
		private ToolStripMenuItem GuideHelpMenuItem;
	}
}
