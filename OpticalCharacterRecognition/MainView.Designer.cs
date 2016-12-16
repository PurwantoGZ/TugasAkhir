namespace OpticalCharacterRecognition
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save2PdftoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save2TexttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomIntoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotatetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcesstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.newImageTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave2Pdf = new System.Windows.Forms.ToolStripButton();
            this.toolSave2Text = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolRotate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolConvert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.ProcessMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(27, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(838, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpentoolStripMenuItem,
            this.Save2PdftoolStripMenuItem,
            this.Save2TexttoolStripMenuItem,
            this.toolStripSeparator3,
            this.ExittoolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 19);
            this.fileMenu.Text = "&File";
            // 
            // OpentoolStripMenuItem
            // 
            this.OpentoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpentoolStripMenuItem.Image")));
            this.OpentoolStripMenuItem.Name = "OpentoolStripMenuItem";
            this.OpentoolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.OpentoolStripMenuItem.Text = "Open Image";
            this.OpentoolStripMenuItem.Click += new System.EventHandler(this.OpentoolStripMenuItem_Click);
            // 
            // Save2PdftoolStripMenuItem
            // 
            this.Save2PdftoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.PDF_2_32;
            this.Save2PdftoolStripMenuItem.Name = "Save2PdftoolStripMenuItem";
            this.Save2PdftoolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.Save2PdftoolStripMenuItem.Text = "Save as Pdf";
            // 
            // Save2TexttoolStripMenuItem
            // 
            this.Save2TexttoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Word_48;
            this.Save2TexttoolStripMenuItem.Name = "Save2TexttoolStripMenuItem";
            this.Save2TexttoolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.Save2TexttoolStripMenuItem.Text = "Save as Text";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // ExittoolStripMenuItem
            // 
            this.ExittoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Close_Window_321;
            this.ExittoolStripMenuItem.Name = "ExittoolStripMenuItem";
            this.ExittoolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExittoolStripMenuItem.Text = "&Exit";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomIntoolStripMenuItem,
            this.ZoomOuttoolStripMenuItem,
            this.RotatetoolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 19);
            this.viewMenu.Text = "&View";
            // 
            // ZoomIntoolStripMenuItem
            // 
            this.ZoomIntoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Zoom_In_48;
            this.ZoomIntoolStripMenuItem.Name = "ZoomIntoolStripMenuItem";
            this.ZoomIntoolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ZoomIntoolStripMenuItem.Text = "Zoom &In";
            this.ZoomIntoolStripMenuItem.ToolTipText = "Zoom In";
            // 
            // ZoomOuttoolStripMenuItem
            // 
            this.ZoomOuttoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Zoom_Out_48;
            this.ZoomOuttoolStripMenuItem.Name = "ZoomOuttoolStripMenuItem";
            this.ZoomOuttoolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ZoomOuttoolStripMenuItem.Text = "Zoom &Out";
            this.ZoomOuttoolStripMenuItem.ToolTipText = "Zoom Out";
            // 
            // RotatetoolStripMenuItem
            // 
            this.RotatetoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Rotate_Left_48;
            this.RotatetoolStripMenuItem.Name = "RotatetoolStripMenuItem";
            this.RotatetoolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RotatetoolStripMenuItem.Text = "Rotate";
            this.RotatetoolStripMenuItem.ToolTipText = "Rotate";
            // 
            // ProcessMenu
            // 
            this.ProcessMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProcesstoolStripMenuItem});
            this.ProcessMenu.Name = "ProcessMenu";
            this.ProcessMenu.Size = new System.Drawing.Size(59, 19);
            this.ProcessMenu.Text = "Process";
            // 
            // ProcesstoolStripMenuItem
            // 
            this.ProcesstoolStripMenuItem.Image = global::OpticalCharacterRecognition.Properties.Resources.Process_48;
            this.ProcesstoolStripMenuItem.Name = "ProcesstoolStripMenuItem";
            this.ProcesstoolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ProcesstoolStripMenuItem.Text = "Convert to Text";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 19);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.newImageTool,
            this.toolStripSeparator1,
            this.toolSave2Pdf,
            this.toolSave2Text,
            this.toolStripSeparator2,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolRotate,
            this.toolStripSeparator9,
            this.toolConvert,
            this.toolStripSeparator4,
            this.toolHelp});
            this.toolStrip.Location = new System.Drawing.Point(27, 85);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(838, 35);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 32);
            // 
            // newImageTool
            // 
            this.newImageTool.Image = global::OpticalCharacterRecognition.Properties.Resources.add_image_48;
            this.newImageTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newImageTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newImageTool.Name = "newImageTool";
            this.newImageTool.Size = new System.Drawing.Size(104, 32);
            this.newImageTool.Text = "Open Image";
            this.newImageTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newImageTool.Click += new System.EventHandler(this.newImageTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolSave2Pdf
            // 
            this.toolSave2Pdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave2Pdf.Enabled = false;
            this.toolSave2Pdf.Image = global::OpticalCharacterRecognition.Properties.Resources.PDF_2_48;
            this.toolSave2Pdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave2Pdf.Name = "toolSave2Pdf";
            this.toolSave2Pdf.Size = new System.Drawing.Size(32, 32);
            this.toolSave2Pdf.Text = "Save As Pdf";
            this.toolSave2Pdf.Click += new System.EventHandler(this.toolSave2Pdf_Click);
            // 
            // toolSave2Text
            // 
            this.toolSave2Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave2Text.Enabled = false;
            this.toolSave2Text.Image = global::OpticalCharacterRecognition.Properties.Resources.Word_48;
            this.toolSave2Text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave2Text.Name = "toolSave2Text";
            this.toolSave2Text.Size = new System.Drawing.Size(32, 32);
            this.toolSave2Text.Text = "Save As Text";
            this.toolSave2Text.Click += new System.EventHandler(this.toolSave2Text_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Enabled = false;
            this.toolZoomIn.Image = global::OpticalCharacterRecognition.Properties.Resources.Zoom_In_48;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(32, 32);
            this.toolZoomIn.Text = "Zoom In";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Enabled = false;
            this.toolZoomOut.Image = global::OpticalCharacterRecognition.Properties.Resources.Zoom_Out_48;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(32, 32);
            this.toolZoomOut.Text = "Zoom Out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolRotate
            // 
            this.toolRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRotate.Enabled = false;
            this.toolRotate.Image = global::OpticalCharacterRecognition.Properties.Resources.Rotate_Left_48;
            this.toolRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRotate.Name = "toolRotate";
            this.toolRotate.Size = new System.Drawing.Size(32, 32);
            this.toolRotate.Text = "Rotate";
            this.toolRotate.Click += new System.EventHandler(this.toolRotate_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // toolConvert
            // 
            this.toolConvert.Enabled = false;
            this.toolConvert.Image = global::OpticalCharacterRecognition.Properties.Resources.Process_48;
            this.toolConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConvert.Name = "toolConvert";
            this.toolConvert.Size = new System.Drawing.Size(117, 32);
            this.toolConvert.Text = "Convert to text";
            this.toolConvert.Click += new System.EventHandler(this.toolConvert_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolHelp
            // 
            this.toolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHelp.Image = global::OpticalCharacterRecognition.Properties.Resources.Help_48__1_;
            this.toolHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(32, 32);
            this.toolHelp.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(27, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(838, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(27, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Optical C.R";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::OpticalCharacterRecognition.Properties.Resources.Printed_OCR_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add User Male-48.png");
            this.imageList1.Images.SetKeyName(1, "add_image-48.png");
            this.imageList1.Images.SetKeyName(2, "add_user-24.png");
            this.imageList1.Images.SetKeyName(3, "add_user-36.png");
            this.imageList1.Images.SetKeyName(4, "Administrator Male-96.png");
            this.imageList1.Images.SetKeyName(5, "automatic-24.png");
            this.imageList1.Images.SetKeyName(6, "automatic-48.png");
            this.imageList1.Images.SetKeyName(7, "BGScreen.png");
            this.imageList1.Images.SetKeyName(8, "Box Filled-48.png");
            this.imageList1.Images.SetKeyName(9, "bullish-48.png");
            this.imageList1.Images.SetKeyName(10, "businessman-48.png");
            this.imageList1.Images.SetKeyName(11, "camera_addon-48.png");
            this.imageList1.Images.SetKeyName(12, "cancel-24.png");
            this.imageList1.Images.SetKeyName(13, "Close Window-32.png");
            this.imageList1.Images.SetKeyName(14, "Close Window-321.png");
            this.imageList1.Images.SetKeyName(15, "Collapse-48.png");
            this.imageList1.Images.SetKeyName(16, "Combo Chart-48.png");
            this.imageList1.Images.SetKeyName(17, "Curriculum-48.png");
            this.imageList1.Images.SetKeyName(18, "Data Sheet-48.png");
            this.imageList1.Images.SetKeyName(19, "Expression.png");
            this.imageList1.Images.SetKeyName(20, "Face_Recognition_FR_Pic.png");
            this.imageList1.Images.SetKeyName(21, "Facial Recognition Scan-48.png");
            this.imageList1.Images.SetKeyName(22, "Facial Recognition Scan-481.png");
            this.imageList1.Images.SetKeyName(23, "Facial Recognition Scan-482.png");
            this.imageList1.Images.SetKeyName(24, "Facial Recognition Scan-483.png");
            this.imageList1.Images.SetKeyName(25, "Facial Recognition Scan-484.png");
            this.imageList1.Images.SetKeyName(26, "Help-48 (1).png");
            this.imageList1.Images.SetKeyName(27, "Help-48.png");
            this.imageList1.Images.SetKeyName(28, "Identity Theft-48.png");
            this.imageList1.Images.SetKeyName(29, "Identity Theft-96.png");
            this.imageList1.Images.SetKeyName(30, "Identity Theft-481.png");
            this.imageList1.Images.SetKeyName(31, "list-96.png");
            this.imageList1.Images.SetKeyName(32, "Lock-48.png");
            this.imageList1.Images.SetKeyName(33, "Login As User-96.png");
            this.imageList1.Images.SetKeyName(34, "Login As User-961.png");
            this.imageList1.Images.SetKeyName(35, "manager-48.png");
            this.imageList1.Images.SetKeyName(36, "Menu-48.png");
            this.imageList1.Images.SetKeyName(37, "Menu-96.png");
            this.imageList1.Images.SetKeyName(38, "Menu-481.png");
            this.imageList1.Images.SetKeyName(39, "mind_map-24.png");
            this.imageList1.Images.SetKeyName(40, "mind_map-48.png");
            this.imageList1.Images.SetKeyName(41, "mind_map-481.png");
            this.imageList1.Images.SetKeyName(42, "PDF 2_32.png");
            this.imageList1.Images.SetKeyName(43, "PDF 2_48.png");
            this.imageList1.Images.SetKeyName(44, "PDF_32.png");
            this.imageList1.Images.SetKeyName(45, "PDF_48.png");
            this.imageList1.Images.SetKeyName(46, "PDF-48 (1).png");
            this.imageList1.Images.SetKeyName(47, "PDF-48.png");
            this.imageList1.Images.SetKeyName(48, "Print_32.png");
            this.imageList1.Images.SetKeyName(49, "Print_48.png");
            this.imageList1.Images.SetKeyName(50, "Printed OCR-48.png");
            this.imageList1.Images.SetKeyName(51, "reading-32.png");
            this.imageList1.Images.SetKeyName(52, "Seminar-Purwanto_FIX.jpg");
            this.imageList1.Images.SetKeyName(53, "Settings-48.png");
            this.imageList1.Images.SetKeyName(54, "statistics-48.png");
            this.imageList1.Images.SetKeyName(55, "survey-48.png");
            this.imageList1.Images.SetKeyName(56, "survey-481.png");
            this.imageList1.Images.SetKeyName(57, "todo_list-48.png");
            this.imageList1.Images.SetKeyName(58, "Training-48.png");
            this.imageList1.Images.SetKeyName(59, "Training-481.png");
            this.imageList1.Images.SetKeyName(60, "Training-482.png");
            this.imageList1.Images.SetKeyName(61, "User Menu Male-48.png");
            this.imageList1.Images.SetKeyName(62, "User Menu Male-96.png");
            this.imageList1.Images.SetKeyName(63, "User-96.png");
            this.imageList1.Images.SetKeyName(64, "Word_32.png");
            this.imageList1.Images.SetKeyName(65, "Word_48.png");
            this.imageList1.Images.SetKeyName(66, "Zoom In-48.png");
            this.imageList1.Images.SetKeyName(67, "Zoom Out-48.png");
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(27, 60, 27, 29);
            this.Text = "MainView";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton newImageTool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolSave2Pdf;
        private System.Windows.Forms.ToolStripButton toolSave2Text;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolConvert;
        private System.Windows.Forms.ToolStripButton toolRotate;
        private System.Windows.Forms.ToolStripButton toolHelp;
        private System.Windows.Forms.ToolStripMenuItem OpentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save2PdftoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save2TexttoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ExittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomIntoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomOuttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RotatetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcessMenu;
        private System.Windows.Forms.ToolStripMenuItem ProcesstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}



