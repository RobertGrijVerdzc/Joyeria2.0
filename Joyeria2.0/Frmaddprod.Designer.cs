namespace Joyeria2._0
{
    partial class Frmaddprod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaddprod));
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblnamedesc = new System.Windows.Forms.Label();
            this.txtdescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblcate = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblcan = new System.Windows.Forms.Label();
            this.lblnamepre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.btnimage = new System.Windows.Forms.Button();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pctprod = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtidprod = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtprecio = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblfrm = new System.Windows.Forms.Label();
            this.CMBcateg = new Bunifu.UI.WinForms.BunifuDropdown();
            this.CMBestilo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblcolor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcolor = new DevExpress.XtraEditors.ColorEdit();
            this.txtgrosor = new System.Windows.Forms.TextBox();
            this.txtlargo = new System.Windows.Forms.TextBox();
            this.lblmarc = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombre.HintText = "Nombre";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre.LineThickness = 3;
            this.txtnombre.Location = new System.Drawing.Point(16, 42);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(372, 33);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtnombre, "Nombre");
            this.toolTipController1.SetToolTip(this.txtnombre, "Nombre de producto");
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(13, 11);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre";
            this.toolTipController1.SetTitle(this.lblname, "Nombre");
            // 
            // lblnamedesc
            // 
            this.lblnamedesc.AutoSize = true;
            this.lblnamedesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamedesc.Location = new System.Drawing.Point(25, 455);
            this.lblnamedesc.Name = "lblnamedesc";
            this.lblnamedesc.Size = new System.Drawing.Size(118, 16);
            this.lblnamedesc.TabIndex = 6;
            this.lblnamedesc.Text = "Descripcion Corta:";
            this.toolTipController1.SetTitle(this.lblnamedesc, "Descripcion");
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdescripcion.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtdescripcion.HintText = "Descripcion del producto";
            this.txtdescripcion.isPassword = false;
            this.txtdescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdescripcion.LineThickness = 3;
            this.txtdescripcion.Location = new System.Drawing.Point(20, 475);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.MaxLength = 32767;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(372, 31);
            this.txtdescripcion.TabIndex = 5;
            this.txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipController1.SetTitle(this.txtdescripcion, "Descripcion");
            this.toolTipController1.SetToolTip(this.txtdescripcion, "Descripcion del producto, esto para identificarlo");
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // lblcate
            // 
            this.lblcate.AutoSize = true;
            this.lblcate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcate.Location = new System.Drawing.Point(20, 152);
            this.lblcate.Name = "lblcate";
            this.lblcate.Size = new System.Drawing.Size(70, 16);
            this.lblcate.TabIndex = 7;
            this.lblcate.Text = "Categoria:";
            this.toolTipController1.SetTitle(this.lblcate, "Categoria");
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(20, 89);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(59, 16);
            this.lbltipo.TabIndex = 8;
            this.lbltipo.Text = "Material:";
            this.toolTipController1.SetTitle(this.lbltipo, "Tipo");
            // 
            // lblcan
            // 
            this.lblcan.AutoSize = true;
            this.lblcan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcan.Location = new System.Drawing.Point(20, 269);
            this.lblcan.Name = "lblcan";
            this.lblcan.Size = new System.Drawing.Size(65, 16);
            this.lblcan.TabIndex = 9;
            this.lblcan.Text = "Cantidad:";
            this.toolTipController1.SetTitle(this.lblcan, "Cantidad");
            // 
            // lblnamepre
            // 
            this.lblnamepre.AutoSize = true;
            this.lblnamepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamepre.Location = new System.Drawing.Point(28, 415);
            this.lblnamepre.Name = "lblnamepre";
            this.lblnamepre.Size = new System.Drawing.Size(50, 16);
            this.lblnamepre.TabIndex = 10;
            this.lblnamepre.Text = "Precio:";
            this.toolTipController1.SetTitle(this.lblnamepre, "Precio");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(598, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(23, 288);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 22);
            this.txtcantidad.TabIndex = 14;
            this.toolTipController1.SetTitle(this.txtcantidad, "Cantidad");
            this.toolTipController1.SetToolTip(this.txtcantidad, "Ingrese la cantidad del producto");
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUD_KeyPress);
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(584, 211);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(42, 23);
            this.btnimage.TabIndex = 16;
            this.btnimage.Text = "...";
            this.toolTipController1.SetTitle(this.btnimage, "Explorer");
            this.toolTipController1.SetToolTip(this.btnimage, "Elegir una imagen del producto");
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Active = false;
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = -20;
            this.btnguardar.ButtonText = "Guardar";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnguardar.Iconimage")));
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 90D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(533, 446);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(158, 48);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.SetTitle(this.btnguardar, "Guardar");
            this.toolTipController1.SetToolTip(this.btnguardar, "Click para guardar el producto");
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // pctprod
            // 
            this.pctprod.AllowFocused = false;
            this.pctprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctprod.BorderRadius = 50;
            this.pctprod.Image = ((System.Drawing.Image)(resources.GetObject("pctprod.Image")));
            this.pctprod.IsCircle = true;
            this.pctprod.Location = new System.Drawing.Point(559, 89);
            this.pctprod.Name = "pctprod";
            this.pctprod.Size = new System.Drawing.Size(100, 100);
            this.pctprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctprod.TabIndex = 11;
            this.pctprod.TabStop = false;
            this.toolTipController1.SetTitle(this.pctprod, "Imagen");
            this.toolTipController1.SetToolTip(this.pctprod, "Imagen del producto");
            this.pctprod.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // txtidprod
            // 
            this.txtidprod.AcceptsReturn = false;
            this.txtidprod.AcceptsTab = false;
            this.txtidprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtidprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtidprod.BackColor = System.Drawing.Color.Transparent;
            this.txtidprod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtidprod.BackgroundImage")));
            this.txtidprod.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtidprod.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtidprod.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtidprod.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtidprod.BorderRadius = 1;
            this.txtidprod.BorderThickness = 2;
            this.txtidprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtidprod.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidprod.DefaultText = "";
            this.txtidprod.FillColor = System.Drawing.Color.White;
            this.txtidprod.HideSelection = true;
            this.txtidprod.IconLeft = null;
            this.txtidprod.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtidprod.IconPadding = 10;
            this.txtidprod.IconRight = null;
            this.txtidprod.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtidprod.Location = new System.Drawing.Point(520, 26);
            this.txtidprod.MaxLength = 32767;
            this.txtidprod.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtidprod.Modified = false;
            this.txtidprod.Name = "txtidprod";
            this.txtidprod.PasswordChar = '\0';
            this.txtidprod.ReadOnly = false;
            this.txtidprod.SelectedText = "";
            this.txtidprod.SelectionLength = 0;
            this.txtidprod.SelectionStart = 0;
            this.txtidprod.ShortcutsEnabled = true;
            this.txtidprod.Size = new System.Drawing.Size(171, 35);
            this.txtidprod.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtidprod.TabIndex = 1;
            this.txtidprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtidprod.TextMarginLeft = 5;
            this.txtidprod.TextPlaceholder = "";
            this.toolTipController1.SetTitle(this.txtidprod, "ID");
            this.toolTipController1.SetToolTip(this.txtidprod, "ID producto");
            this.txtidprod.UseSystemPasswordChar = false;
            this.txtidprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidprod_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtprecio
            // 
            this.txtprecio.AcceptsReturn = false;
            this.txtprecio.AcceptsTab = false;
            this.txtprecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtprecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtprecio.BackColor = System.Drawing.Color.Transparent;
            this.txtprecio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtprecio.BackgroundImage")));
            this.txtprecio.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtprecio.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtprecio.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtprecio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtprecio.BorderRadius = 1;
            this.txtprecio.BorderThickness = 2;
            this.txtprecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtprecio.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.DefaultText = "";
            this.txtprecio.FillColor = System.Drawing.Color.White;
            this.txtprecio.HideSelection = true;
            this.txtprecio.IconLeft = null;
            this.txtprecio.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtprecio.IconPadding = 10;
            this.txtprecio.IconRight = null;
            this.txtprecio.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtprecio.Location = new System.Drawing.Point(84, 406);
            this.txtprecio.MaxLength = 32767;
            this.txtprecio.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtprecio.Modified = false;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.ReadOnly = false;
            this.txtprecio.SelectedText = "";
            this.txtprecio.SelectionLength = 0;
            this.txtprecio.SelectionStart = 0;
            this.txtprecio.ShortcutsEnabled = true;
            this.txtprecio.Size = new System.Drawing.Size(189, 35);
            this.txtprecio.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtprecio.TabIndex = 15;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtprecio.TextMarginLeft = 5;
            this.txtprecio.TextPlaceholder = "";
            this.txtprecio.UseSystemPasswordChar = false;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // lblfrm
            // 
            this.lblfrm.AutoSize = true;
            this.lblfrm.Location = new System.Drawing.Point(315, 7);
            this.lblfrm.Name = "lblfrm";
            this.lblfrm.Size = new System.Drawing.Size(44, 13);
            this.lblfrm.TabIndex = 17;
            this.lblfrm.Text = "Agregar";
            // 
            // CMBcateg
            // 
            this.CMBcateg.BackColor = System.Drawing.SystemColors.Control;
            this.CMBcateg.BorderRadius = 1;
            this.CMBcateg.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CMBcateg.DisabledColor = System.Drawing.Color.Gray;
            this.CMBcateg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBcateg.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.CMBcateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBcateg.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CMBcateg.FillDropDown = false;
            this.CMBcateg.FillIndicator = false;
            this.CMBcateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBcateg.ForeColor = System.Drawing.Color.Purple;
            this.CMBcateg.FormattingEnabled = true;
            this.CMBcateg.Icon = null;
            this.CMBcateg.IndicatorColor = System.Drawing.Color.Purple;
            this.CMBcateg.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CMBcateg.ItemBackColor = System.Drawing.Color.White;
            this.CMBcateg.ItemBorderColor = System.Drawing.Color.White;
            this.CMBcateg.ItemForeColor = System.Drawing.Color.Purple;
            this.CMBcateg.ItemHeight = 26;
            this.CMBcateg.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.CMBcateg.Location = new System.Drawing.Point(20, 108);
            this.CMBcateg.Name = "CMBcateg";
            this.CMBcateg.Size = new System.Drawing.Size(192, 32);
            this.CMBcateg.TabIndex = 18;
            this.CMBcateg.Text = "1";
            // 
            // CMBestilo
            // 
            this.CMBestilo.BackColor = System.Drawing.SystemColors.Control;
            this.CMBestilo.BorderRadius = 1;
            this.CMBestilo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CMBestilo.DisabledColor = System.Drawing.Color.Gray;
            this.CMBestilo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBestilo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.CMBestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBestilo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CMBestilo.FillDropDown = false;
            this.CMBestilo.FillIndicator = false;
            this.CMBestilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBestilo.ForeColor = System.Drawing.Color.Purple;
            this.CMBestilo.FormattingEnabled = true;
            this.CMBestilo.Icon = null;
            this.CMBestilo.IndicatorColor = System.Drawing.Color.Purple;
            this.CMBestilo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CMBestilo.ItemBackColor = System.Drawing.Color.White;
            this.CMBestilo.ItemBorderColor = System.Drawing.Color.White;
            this.CMBestilo.ItemForeColor = System.Drawing.Color.Purple;
            this.CMBestilo.ItemHeight = 26;
            this.CMBestilo.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.CMBestilo.Location = new System.Drawing.Point(20, 171);
            this.CMBestilo.Name = "CMBestilo";
            this.CMBestilo.Size = new System.Drawing.Size(192, 32);
            this.CMBestilo.TabIndex = 19;
            this.CMBestilo.Text = "sdfsdf";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(25, 328);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(34, 13);
            this.lblcolor.TabIndex = 20;
            this.lblcolor.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Grosor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Largo:";
            // 
            // txtcolor
            // 
            this.txtcolor.EditValue = System.Drawing.Color.Empty;
            this.txtcolor.Location = new System.Drawing.Point(28, 344);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcolor.Size = new System.Drawing.Size(100, 20);
            this.txtcolor.TabIndex = 23;
            // 
            // txtgrosor
            // 
            this.txtgrosor.Location = new System.Drawing.Point(163, 344);
            this.txtgrosor.Name = "txtgrosor";
            this.txtgrosor.Size = new System.Drawing.Size(100, 20);
            this.txtgrosor.TabIndex = 24;
            // 
            // txtlargo
            // 
            this.txtlargo.Location = new System.Drawing.Point(301, 344);
            this.txtlargo.Name = "txtlargo";
            this.txtlargo.Size = new System.Drawing.Size(100, 20);
            this.txtlargo.TabIndex = 25;
            // 
            // lblmarc
            // 
            this.lblmarc.AutoSize = true;
            this.lblmarc.Location = new System.Drawing.Point(20, 221);
            this.lblmarc.Name = "lblmarc";
            this.lblmarc.Size = new System.Drawing.Size(40, 13);
            this.lblmarc.TabIndex = 26;
            this.lblmarc.Text = "Marca:";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(23, 237);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(189, 26);
            this.txtmarca.TabIndex = 27;
            // 
            // Frmaddprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 506);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarc);
            this.Controls.Add(this.txtlargo);
            this.Controls.Add(this.txtgrosor);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.CMBestilo);
            this.Controls.Add(this.CMBcateg);
            this.Controls.Add(this.lblfrm);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pctprod);
            this.Controls.Add(this.lblnamepre);
            this.Controls.Add(this.lblcan);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblcate);
            this.Controls.Add(this.lblnamedesc);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtidprod);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmaddprod";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmaddprod_FormClosing);
            this.Load += new System.EventHandler(this.Frmaddprod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnamedesc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdescripcion;
        private System.Windows.Forms.Label lblcate;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblcan;
        private System.Windows.Forms.Label lblnamepre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtprecio;
        private System.Windows.Forms.Button btnimage;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label lblfrm;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtidprod;
        private Bunifu.UI.WinForms.BunifuDropdown CMBcateg;
        public Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.UI.WinForms.BunifuDropdown CMBestilo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ColorEdit txtcolor;
        private System.Windows.Forms.TextBox txtgrosor;
        private System.Windows.Forms.TextBox txtlargo;
        private System.Windows.Forms.Label lblmarc;
        private System.Windows.Forms.TextBox txtmarca;
        public Bunifu.UI.WinForms.BunifuPictureBox pctprod;
    }
}