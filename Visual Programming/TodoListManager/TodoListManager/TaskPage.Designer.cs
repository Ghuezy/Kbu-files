namespace TodoListManager
{
    partial class TaskPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lv_tasks = new System.Windows.Forms.ListView();
            this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_taskpage = new Bunifu.UI.WinForms.BunifuPanel();
            this.txt_task = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_newtask = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_done = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_logoff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_stats = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_taskpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_tasks
            // 
            this.lv_tasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskName,
            this.Status});
            this.lv_tasks.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_tasks.HideSelection = false;
            this.lv_tasks.Location = new System.Drawing.Point(364, 42);
            this.lv_tasks.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lv_tasks.Name = "lv_tasks";
            this.lv_tasks.Size = new System.Drawing.Size(399, 235);
            this.lv_tasks.TabIndex = 0;
            this.lv_tasks.UseCompatibleStateImageBehavior = false;
            this.lv_tasks.View = System.Windows.Forms.View.Details;
            // 
            // TaskName
            // 
            this.TaskName.Text = "TaskName";
            this.TaskName.Width = 194;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 200;
            // 
            // pnl_taskpage
            // 
            this.pnl_taskpage.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_taskpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_taskpage.BackgroundImage")));
            this.pnl_taskpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_taskpage.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_taskpage.BorderRadius = 10;
            this.pnl_taskpage.BorderThickness = 1;
            this.pnl_taskpage.Controls.Add(this.txt_task);
            this.pnl_taskpage.Controls.Add(this.btn_newtask);
            this.pnl_taskpage.Location = new System.Drawing.Point(36, 42);
            this.pnl_taskpage.Name = "pnl_taskpage";
            this.pnl_taskpage.ShowBorders = true;
            this.pnl_taskpage.Size = new System.Drawing.Size(307, 235);
            this.pnl_taskpage.TabIndex = 9;
            // 
            // txt_task
            // 
            this.txt_task.AcceptsReturn = false;
            this.txt_task.AcceptsTab = false;
            this.txt_task.AnimationSpeed = 200;
            this.txt_task.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_task.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_task.AutoSizeHeight = true;
            this.txt_task.BackColor = System.Drawing.Color.Transparent;
            this.txt_task.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_task.BackgroundImage")));
            this.txt_task.BorderColorActive = System.Drawing.Color.Silver;
            this.txt_task.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_task.BorderColorHover = System.Drawing.Color.WhiteSmoke;
            this.txt_task.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txt_task.BorderRadius = 10;
            this.txt_task.BorderThickness = 1;
            this.txt_task.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txt_task.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_task.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_task.DefaultFont = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_task.DefaultText = "";
            this.txt_task.FillColor = System.Drawing.Color.Silver;
            this.txt_task.HideSelection = true;
            this.txt_task.IconLeft = null;
            this.txt_task.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_task.IconPadding = 10;
            this.txt_task.IconRight = null;
            this.txt_task.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_task.Lines = new string[0];
            this.txt_task.Location = new System.Drawing.Point(13, 21);
            this.txt_task.MaxLength = 32767;
            this.txt_task.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_task.Modified = false;
            this.txt_task.Multiline = true;
            this.txt_task.Name = "txt_task";
            stateProperties1.BorderColor = System.Drawing.Color.Silver;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_task.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_task.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_task.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties4.FillColor = System.Drawing.Color.Silver;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_task.OnIdleState = stateProperties4;
            this.txt_task.Padding = new System.Windows.Forms.Padding(3);
            this.txt_task.PasswordChar = '\0';
            this.txt_task.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_task.PlaceholderText = "Enter New Tasks";
            this.txt_task.ReadOnly = false;
            this.txt_task.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_task.SelectedText = "";
            this.txt_task.SelectionLength = 0;
            this.txt_task.SelectionStart = 0;
            this.txt_task.ShortcutsEnabled = true;
            this.txt_task.Size = new System.Drawing.Size(278, 82);
            this.txt_task.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_task.TabIndex = 6;
            this.txt_task.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_task.TextMarginBottom = 0;
            this.txt_task.TextMarginLeft = 3;
            this.txt_task.TextMarginTop = 1;
            this.txt_task.TextPlaceholder = "Enter New Tasks";
            this.txt_task.UseSystemPasswordChar = false;
            this.txt_task.WordWrap = true;
            // 
            // btn_newtask
            // 
            this.btn_newtask.AllowAnimations = true;
            this.btn_newtask.AllowMouseEffects = true;
            this.btn_newtask.AllowToggling = false;
            this.btn_newtask.AnimationSpeed = 200;
            this.btn_newtask.AutoGenerateColors = false;
            this.btn_newtask.AutoRoundBorders = false;
            this.btn_newtask.AutoSizeLeftIcon = true;
            this.btn_newtask.AutoSizeRightIcon = true;
            this.btn_newtask.BackColor = System.Drawing.Color.Transparent;
            this.btn_newtask.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_newtask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_newtask.BackgroundImage")));
            this.btn_newtask.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_newtask.ButtonText = "Add New Task";
            this.btn_newtask.ButtonTextMarginLeft = 0;
            this.btn_newtask.ColorContrastOnClick = 45;
            this.btn_newtask.ColorContrastOnHover = 45;
            this.btn_newtask.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_newtask.CustomizableEdges = borderEdges1;
            this.btn_newtask.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_newtask.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_newtask.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_newtask.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_newtask.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_newtask.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newtask.ForeColor = System.Drawing.Color.DimGray;
            this.btn_newtask.IconLeft = null;
            this.btn_newtask.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newtask.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_newtask.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_newtask.IconMarginLeft = 11;
            this.btn_newtask.IconPadding = 10;
            this.btn_newtask.IconRight = null;
            this.btn_newtask.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_newtask.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_newtask.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_newtask.IconSize = 25;
            this.btn_newtask.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_newtask.IdleBorderRadius = 0;
            this.btn_newtask.IdleBorderThickness = 0;
            this.btn_newtask.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_newtask.IdleIconLeftImage = null;
            this.btn_newtask.IdleIconRightImage = null;
            this.btn_newtask.IndicateFocus = false;
            this.btn_newtask.Location = new System.Drawing.Point(162, 195);
            this.btn_newtask.Name = "btn_newtask";
            this.btn_newtask.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_newtask.OnDisabledState.BorderRadius = 10;
            this.btn_newtask.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_newtask.OnDisabledState.BorderThickness = 1;
            this.btn_newtask.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_newtask.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_newtask.OnDisabledState.IconLeftImage = null;
            this.btn_newtask.OnDisabledState.IconRightImage = null;
            this.btn_newtask.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_newtask.onHoverState.BorderRadius = 10;
            this.btn_newtask.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_newtask.onHoverState.BorderThickness = 1;
            this.btn_newtask.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_newtask.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_newtask.onHoverState.IconLeftImage = null;
            this.btn_newtask.onHoverState.IconRightImage = null;
            this.btn_newtask.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btn_newtask.OnIdleState.BorderRadius = 10;
            this.btn_newtask.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_newtask.OnIdleState.BorderThickness = 1;
            this.btn_newtask.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btn_newtask.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_newtask.OnIdleState.IconLeftImage = null;
            this.btn_newtask.OnIdleState.IconRightImage = null;
            this.btn_newtask.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_newtask.OnPressedState.BorderRadius = 10;
            this.btn_newtask.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_newtask.OnPressedState.BorderThickness = 1;
            this.btn_newtask.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_newtask.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_newtask.OnPressedState.IconLeftImage = null;
            this.btn_newtask.OnPressedState.IconRightImage = null;
            this.btn_newtask.Size = new System.Drawing.Size(129, 27);
            this.btn_newtask.TabIndex = 5;
            this.btn_newtask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_newtask.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_newtask.TextMarginLeft = 0;
            this.btn_newtask.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_newtask.UseDefaultRadiusAndThickness = true;
            this.btn_newtask.Click += new System.EventHandler(this.btn_newtask_Click);
            // 
            // btn_done
            // 
            this.btn_done.AllowAnimations = true;
            this.btn_done.AllowMouseEffects = true;
            this.btn_done.AllowToggling = false;
            this.btn_done.AnimationSpeed = 200;
            this.btn_done.AutoGenerateColors = false;
            this.btn_done.AutoRoundBorders = false;
            this.btn_done.AutoSizeLeftIcon = true;
            this.btn_done.AutoSizeRightIcon = true;
            this.btn_done.BackColor = System.Drawing.Color.Transparent;
            this.btn_done.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_done.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_done.BackgroundImage")));
            this.btn_done.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.ButtonText = "Done";
            this.btn_done.ButtonTextMarginLeft = 0;
            this.btn_done.ColorContrastOnClick = 45;
            this.btn_done.ColorContrastOnHover = 45;
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_done.CustomizableEdges = borderEdges2;
            this.btn_done.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_done.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_done.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_done.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_done.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_done.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.DimGray;
            this.btn_done.IconLeft = null;
            this.btn_done.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_done.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_done.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_done.IconMarginLeft = 11;
            this.btn_done.IconPadding = 10;
            this.btn_done.IconRight = null;
            this.btn_done.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_done.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_done.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_done.IconSize = 25;
            this.btn_done.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_done.IdleBorderRadius = 0;
            this.btn_done.IdleBorderThickness = 0;
            this.btn_done.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_done.IdleIconLeftImage = null;
            this.btn_done.IdleIconRightImage = null;
            this.btn_done.IndicateFocus = false;
            this.btn_done.Location = new System.Drawing.Point(676, 283);
            this.btn_done.Name = "btn_done";
            this.btn_done.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_done.OnDisabledState.BorderRadius = 10;
            this.btn_done.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnDisabledState.BorderThickness = 1;
            this.btn_done.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_done.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_done.OnDisabledState.IconLeftImage = null;
            this.btn_done.OnDisabledState.IconRightImage = null;
            this.btn_done.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_done.onHoverState.BorderRadius = 10;
            this.btn_done.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.onHoverState.BorderThickness = 1;
            this.btn_done.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btn_done.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_done.onHoverState.IconLeftImage = null;
            this.btn_done.onHoverState.IconRightImage = null;
            this.btn_done.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_done.OnIdleState.BorderRadius = 10;
            this.btn_done.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnIdleState.BorderThickness = 1;
            this.btn_done.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_done.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_done.OnIdleState.IconLeftImage = null;
            this.btn_done.OnIdleState.IconRightImage = null;
            this.btn_done.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_done.OnPressedState.BorderRadius = 10;
            this.btn_done.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnPressedState.BorderThickness = 1;
            this.btn_done.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_done.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_done.OnPressedState.IconLeftImage = null;
            this.btn_done.OnPressedState.IconRightImage = null;
            this.btn_done.Size = new System.Drawing.Size(87, 27);
            this.btn_done.TabIndex = 10;
            this.btn_done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_done.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_done.TextMarginLeft = 0;
            this.btn_done.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_done.UseDefaultRadiusAndThickness = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_logoff
            // 
            this.btn_logoff.AllowAnimations = true;
            this.btn_logoff.AllowMouseEffects = true;
            this.btn_logoff.AllowToggling = false;
            this.btn_logoff.AnimationSpeed = 200;
            this.btn_logoff.AutoGenerateColors = false;
            this.btn_logoff.AutoRoundBorders = false;
            this.btn_logoff.AutoSizeLeftIcon = true;
            this.btn_logoff.AutoSizeRightIcon = true;
            this.btn_logoff.BackColor = System.Drawing.Color.Transparent;
            this.btn_logoff.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_logoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logoff.BackgroundImage")));
            this.btn_logoff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logoff.ButtonText = "Log Off";
            this.btn_logoff.ButtonTextMarginLeft = 0;
            this.btn_logoff.ColorContrastOnClick = 45;
            this.btn_logoff.ColorContrastOnHover = 45;
            this.btn_logoff.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_logoff.CustomizableEdges = borderEdges3;
            this.btn_logoff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logoff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_logoff.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_logoff.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_logoff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_logoff.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoff.ForeColor = System.Drawing.Color.DimGray;
            this.btn_logoff.IconLeft = null;
            this.btn_logoff.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoff.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_logoff.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_logoff.IconMarginLeft = 11;
            this.btn_logoff.IconPadding = 10;
            this.btn_logoff.IconRight = null;
            this.btn_logoff.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logoff.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_logoff.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_logoff.IconSize = 25;
            this.btn_logoff.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_logoff.IdleBorderRadius = 0;
            this.btn_logoff.IdleBorderThickness = 0;
            this.btn_logoff.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_logoff.IdleIconLeftImage = null;
            this.btn_logoff.IdleIconRightImage = null;
            this.btn_logoff.IndicateFocus = false;
            this.btn_logoff.Location = new System.Drawing.Point(36, 402);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_logoff.OnDisabledState.BorderRadius = 10;
            this.btn_logoff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logoff.OnDisabledState.BorderThickness = 1;
            this.btn_logoff.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_logoff.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_logoff.OnDisabledState.IconLeftImage = null;
            this.btn_logoff.OnDisabledState.IconRightImage = null;
            this.btn_logoff.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_logoff.onHoverState.BorderRadius = 10;
            this.btn_logoff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logoff.onHoverState.BorderThickness = 1;
            this.btn_logoff.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btn_logoff.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logoff.onHoverState.IconLeftImage = null;
            this.btn_logoff.onHoverState.IconRightImage = null;
            this.btn_logoff.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_logoff.OnIdleState.BorderRadius = 10;
            this.btn_logoff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logoff.OnIdleState.BorderThickness = 1;
            this.btn_logoff.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_logoff.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_logoff.OnIdleState.IconLeftImage = null;
            this.btn_logoff.OnIdleState.IconRightImage = null;
            this.btn_logoff.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_logoff.OnPressedState.BorderRadius = 10;
            this.btn_logoff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_logoff.OnPressedState.BorderThickness = 1;
            this.btn_logoff.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_logoff.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_logoff.OnPressedState.IconLeftImage = null;
            this.btn_logoff.OnPressedState.IconRightImage = null;
            this.btn_logoff.Size = new System.Drawing.Size(87, 27);
            this.btn_logoff.TabIndex = 11;
            this.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logoff.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logoff.TextMarginLeft = 0;
            this.btn_logoff.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_logoff.UseDefaultRadiusAndThickness = true;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AllowAnimations = true;
            this.btn_delete.AllowMouseEffects = true;
            this.btn_delete.AllowToggling = false;
            this.btn_delete.AnimationSpeed = 200;
            this.btn_delete.AutoGenerateColors = false;
            this.btn_delete.AutoRoundBorders = false;
            this.btn_delete.AutoSizeLeftIcon = true;
            this.btn_delete.AutoSizeRightIcon = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.ButtonTextMarginLeft = 0;
            this.btn_delete.ColorContrastOnClick = 45;
            this.btn_delete.ColorContrastOnHover = 45;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_delete.CustomizableEdges = borderEdges4;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_delete.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_delete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.DimGray;
            this.btn_delete.IconLeft = null;
            this.btn_delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_delete.IconMarginLeft = 11;
            this.btn_delete.IconPadding = 10;
            this.btn_delete.IconRight = null;
            this.btn_delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_delete.IconSize = 25;
            this.btn_delete.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_delete.IdleBorderRadius = 0;
            this.btn_delete.IdleBorderThickness = 0;
            this.btn_delete.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_delete.IdleIconLeftImage = null;
            this.btn_delete.IdleIconRightImage = null;
            this.btn_delete.IndicateFocus = false;
            this.btn_delete.Location = new System.Drawing.Point(583, 283);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.OnDisabledState.BorderRadius = 10;
            this.btn_delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnDisabledState.BorderThickness = 1;
            this.btn_delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.OnDisabledState.IconLeftImage = null;
            this.btn_delete.OnDisabledState.IconRightImage = null;
            this.btn_delete.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_delete.onHoverState.BorderRadius = 10;
            this.btn_delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.onHoverState.BorderThickness = 1;
            this.btn_delete.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btn_delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.onHoverState.IconLeftImage = null;
            this.btn_delete.onHoverState.IconRightImage = null;
            this.btn_delete.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.OnIdleState.BorderRadius = 10;
            this.btn_delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnIdleState.BorderThickness = 1;
            this.btn_delete.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_delete.OnIdleState.IconLeftImage = null;
            this.btn_delete.OnIdleState.IconRightImage = null;
            this.btn_delete.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_delete.OnPressedState.BorderRadius = 10;
            this.btn_delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnPressedState.BorderThickness = 1;
            this.btn_delete.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_delete.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.OnPressedState.IconLeftImage = null;
            this.btn_delete.OnPressedState.IconRightImage = null;
            this.btn_delete.Size = new System.Drawing.Size(87, 27);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.TextMarginLeft = 0;
            this.btn_delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_delete.UseDefaultRadiusAndThickness = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.AllowAnimations = true;
            this.btn_stats.AllowMouseEffects = true;
            this.btn_stats.AllowToggling = false;
            this.btn_stats.AnimationSpeed = 200;
            this.btn_stats.AutoGenerateColors = false;
            this.btn_stats.AutoRoundBorders = false;
            this.btn_stats.AutoSizeLeftIcon = true;
            this.btn_stats.AutoSizeRightIcon = true;
            this.btn_stats.BackColor = System.Drawing.Color.Transparent;
            this.btn_stats.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_stats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stats.BackgroundImage")));
            this.btn_stats.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stats.ButtonText = "Show Statistics";
            this.btn_stats.ButtonTextMarginLeft = 0;
            this.btn_stats.ColorContrastOnClick = 45;
            this.btn_stats.ColorContrastOnHover = 45;
            this.btn_stats.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_stats.CustomizableEdges = borderEdges5;
            this.btn_stats.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stats.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stats.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_stats.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_stats.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_stats.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.ForeColor = System.Drawing.Color.DimGray;
            this.btn_stats.IconLeft = null;
            this.btn_stats.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stats.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stats.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_stats.IconMarginLeft = 11;
            this.btn_stats.IconPadding = 10;
            this.btn_stats.IconRight = null;
            this.btn_stats.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stats.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_stats.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_stats.IconSize = 25;
            this.btn_stats.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_stats.IdleBorderRadius = 0;
            this.btn_stats.IdleBorderThickness = 0;
            this.btn_stats.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_stats.IdleIconLeftImage = null;
            this.btn_stats.IdleIconRightImage = null;
            this.btn_stats.IndicateFocus = false;
            this.btn_stats.Location = new System.Drawing.Point(601, 402);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_stats.OnDisabledState.BorderRadius = 10;
            this.btn_stats.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stats.OnDisabledState.BorderThickness = 1;
            this.btn_stats.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_stats.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_stats.OnDisabledState.IconLeftImage = null;
            this.btn_stats.OnDisabledState.IconRightImage = null;
            this.btn_stats.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btn_stats.onHoverState.BorderRadius = 10;
            this.btn_stats.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stats.onHoverState.BorderThickness = 1;
            this.btn_stats.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btn_stats.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_stats.onHoverState.IconLeftImage = null;
            this.btn_stats.onHoverState.IconRightImage = null;
            this.btn_stats.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_stats.OnIdleState.BorderRadius = 10;
            this.btn_stats.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stats.OnIdleState.BorderThickness = 1;
            this.btn_stats.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_stats.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_stats.OnIdleState.IconLeftImage = null;
            this.btn_stats.OnIdleState.IconRightImage = null;
            this.btn_stats.OnPressedState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_stats.OnPressedState.BorderRadius = 10;
            this.btn_stats.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_stats.OnPressedState.BorderThickness = 1;
            this.btn_stats.OnPressedState.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_stats.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_stats.OnPressedState.IconLeftImage = null;
            this.btn_stats.OnPressedState.IconRightImage = null;
            this.btn_stats.Size = new System.Drawing.Size(162, 27);
            this.btn_stats.TabIndex = 13;
            this.btn_stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stats.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_stats.TextMarginLeft = 0;
            this.btn_stats.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_stats.UseDefaultRadiusAndThickness = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_logoff);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.pnl_taskpage);
            this.Controls.Add(this.lv_tasks);
            this.Name = "TaskPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskPage";
            this.pnl_taskpage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_tasks;
        private Bunifu.UI.WinForms.BunifuPanel pnl_taskpage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_newtask;
        private Bunifu.UI.WinForms.BunifuTextBox txt_task;
        private System.Windows.Forms.ColumnHeader TaskName;
        private System.Windows.Forms.ColumnHeader Status;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_done;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_logoff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_delete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_stats;
    }
}