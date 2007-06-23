<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim AssociateLinkLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.AssociateLinkTextBox = New System.Windows.Forms.TextBox
        Me.ItemResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemResultBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ItemResultDataGridView = New System.Windows.Forms.DataGridView
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopybooktitleaslinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopybookimageaslinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopybothaslinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BrowsetoitemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gridContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyTitleaslinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyimageaslinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtAssociateID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeAmazoneWSCredientialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutAmazonerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoysBlogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeamAgileshomepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QueryWorker = New System.ComponentModel.BackgroundWorker
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pbQuery = New System.Windows.Forms.ProgressBar
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        AssociateLinkLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.ItemResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemResultBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemResultBindingNavigator.SuspendLayout()
        CType(Me.ItemResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssociateLinkLabel
        '
        AssociateLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        AssociateLinkLabel.AutoSize = True
        AssociateLinkLabel.Location = New System.Drawing.Point(12, 365)
        AssociateLinkLabel.Name = "AssociateLinkLabel"
        AssociateLinkLabel.Size = New System.Drawing.Size(79, 13)
        AssociateLinkLabel.TabIndex = 4
        AssociateLinkLabel.Text = "Associate Link:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 393)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 13)
        Label1.TabIndex = 9
        Label1.Text = "Associate ID:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Search books by title:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Amazoner.Settings.Default, "LastSearch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(221, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 0
        '
        'AssociateLinkTextBox
        '
        Me.AssociateLinkTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AssociateLinkTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AssociateLinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemResultBindingSource, "AssociateLink", True))
        Me.AssociateLinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ItemResultBindingSource, "AssociateLink", True))
        Me.AssociateLinkTextBox.Location = New System.Drawing.Point(93, 362)
        Me.AssociateLinkTextBox.Name = "AssociateLinkTextBox"
        Me.AssociateLinkTextBox.ReadOnly = True
        Me.AssociateLinkTextBox.Size = New System.Drawing.Size(453, 20)
        Me.AssociateLinkTextBox.TabIndex = 5
        '
        'ItemResultBindingSource
        '
        Me.ItemResultBindingSource.DataSource = GetType(Amazoner.ItemResult)
        '
        'ItemResultBindingNavigator
        '
        Me.ItemResultBindingNavigator.AddNewItem = Nothing
        Me.ItemResultBindingNavigator.BindingSource = Me.ItemResultBindingSource
        Me.ItemResultBindingNavigator.CountItem = Me.bindingNavigatorCountItem
        Me.ItemResultBindingNavigator.DeleteItem = Nothing
        Me.ItemResultBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
        Me.ItemResultBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ItemResultBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.ItemResultBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.ItemResultBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.ItemResultBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.ItemResultBindingNavigator.Name = "ItemResultBindingNavigator"
        Me.ItemResultBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.ItemResultBindingNavigator.Size = New System.Drawing.Size(559, 25)
        Me.ItemResultBindingNavigator.TabIndex = 7
        Me.ItemResultBindingNavigator.Text = "BindingNavigator1"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ItemResultDataGridView
        '
        Me.ItemResultDataGridView.AllowUserToAddRows = False
        Me.ItemResultDataGridView.AllowUserToDeleteRows = False
        Me.ItemResultDataGridView.AllowUserToOrderColumns = True
        Me.ItemResultDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemResultDataGridView.AutoGenerateColumns = False
        Me.ItemResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ItemResultDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ItemResultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Image, Me.Author})
        Me.ItemResultDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ItemResultDataGridView.DataSource = Me.ItemResultBindingSource
        Me.ItemResultDataGridView.Location = New System.Drawing.Point(13, 79)
        Me.ItemResultDataGridView.MultiSelect = False
        Me.ItemResultDataGridView.Name = "ItemResultDataGridView"
        Me.ItemResultDataGridView.ReadOnly = True
        Me.ItemResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemResultDataGridView.Size = New System.Drawing.Size(404, 277)
        Me.ItemResultDataGridView.TabIndex = 3
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.FormatProvider = New System.Globalization.CultureInfo("en-US")
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Title.DefaultCellStyle = DataGridViewCellStyle1
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Title.ToolTipText = "Right click here to get the link HTML"
        '
        'Image
        '
        Me.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = "Image"
        Me.Image.MinimumWidth = 100
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
        '
        'Author
        '
        Me.Author.DataPropertyName = "Author"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.FormatProvider = New System.Globalization.CultureInfo("en-US")
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Author.DefaultCellStyle = DataGridViewCellStyle2
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopybooktitleaslinkToolStripMenuItem, Me.CopybookimageaslinkToolStripMenuItem, Me.CopybothaslinkToolStripMenuItem, Me.ToolStripSeparator1, Me.BrowsetoitemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 98)
        '
        'CopybooktitleaslinkToolStripMenuItem
        '
        Me.CopybooktitleaslinkToolStripMenuItem.Image = CType(resources.GetObject("CopybooktitleaslinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopybooktitleaslinkToolStripMenuItem.Name = "CopybooktitleaslinkToolStripMenuItem"
        Me.CopybooktitleaslinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CopybooktitleaslinkToolStripMenuItem.Text = "Copy &title as link"
        '
        'CopybookimageaslinkToolStripMenuItem
        '
        Me.CopybookimageaslinkToolStripMenuItem.Image = CType(resources.GetObject("CopybookimageaslinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopybookimageaslinkToolStripMenuItem.Name = "CopybookimageaslinkToolStripMenuItem"
        Me.CopybookimageaslinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CopybookimageaslinkToolStripMenuItem.Text = "Copy &image as link"
        '
        'CopybothaslinkToolStripMenuItem
        '
        Me.CopybothaslinkToolStripMenuItem.Image = CType(resources.GetObject("CopybothaslinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopybothaslinkToolStripMenuItem.Name = "CopybothaslinkToolStripMenuItem"
        Me.CopybothaslinkToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CopybothaslinkToolStripMenuItem.Text = "Copy &both as link"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'BrowsetoitemToolStripMenuItem
        '
        Me.BrowsetoitemToolStripMenuItem.Image = CType(resources.GetObject("BrowsetoitemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowsetoitemToolStripMenuItem.Name = "BrowsetoitemToolStripMenuItem"
        Me.BrowsetoitemToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.BrowsetoitemToolStripMenuItem.Text = "&Browse to item..."
        '
        'gridContextMenu
        '
        Me.gridContextMenu.Name = "gridContextMenu"
        Me.gridContextMenu.Size = New System.Drawing.Size(61, 4)
        '
        'CopyTitleaslinkToolStripMenuItem
        '
        Me.CopyTitleaslinkToolStripMenuItem.Name = "CopyTitleaslinkToolStripMenuItem"
        Me.CopyTitleaslinkToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CopyTitleaslinkToolStripMenuItem.Text = "Copy &title as link"
        '
        'CopyimageaslinkToolStripMenuItem
        '
        Me.CopyimageaslinkToolStripMenuItem.Name = "CopyimageaslinkToolStripMenuItem"
        Me.CopyimageaslinkToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CopyimageaslinkToolStripMenuItem.Text = "Copy &image as link"
        '
        'txtAssociateID
        '
        Me.txtAssociateID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAssociateID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Amazoner.Settings.Default, "AssociateID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAssociateID.Location = New System.Drawing.Point(93, 391)
        Me.txtAssociateID.Name = "txtAssociateID"
        Me.txtAssociateID.Size = New System.Drawing.Size(153, 20)
        Me.txtAssociateID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 144)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "1) Enter a search query and press the search button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Right click on the row " & _
            "to copy the link as a title, an image, or both! (HTML format)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ISBN
        '
        Me.ISBN.DataPropertyName = "ISBN"
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.Name = "ISBN"
        Me.ISBN.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeAmazoneWSCredientialsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ChangeAmazoneWSCredientialsToolStripMenuItem
        '
        Me.ChangeAmazoneWSCredientialsToolStripMenuItem.Image = CType(resources.GetObject("ChangeAmazoneWSCredientialsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeAmazoneWSCredientialsToolStripMenuItem.Name = "ChangeAmazoneWSCredientialsToolStripMenuItem"
        Me.ChangeAmazoneWSCredientialsToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ChangeAmazoneWSCredientialsToolStripMenuItem.Text = "Change Amazon WS Credientials..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutAmazonerToolStripMenuItem, Me.RoysBlogToolStripMenuItem, Me.TeamAgileshomepageToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutAmazonerToolStripMenuItem
        '
        Me.AboutAmazonerToolStripMenuItem.Image = CType(resources.GetObject("AboutAmazonerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutAmazonerToolStripMenuItem.Name = "AboutAmazonerToolStripMenuItem"
        Me.AboutAmazonerToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AboutAmazonerToolStripMenuItem.Text = "&About Amazoner..."
        '
        'RoysBlogToolStripMenuItem
        '
        Me.RoysBlogToolStripMenuItem.Image = CType(resources.GetObject("RoysBlogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RoysBlogToolStripMenuItem.Name = "RoysBlogToolStripMenuItem"
        Me.RoysBlogToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RoysBlogToolStripMenuItem.Text = "Roy's Blog..."
        '
        'TeamAgileshomepageToolStripMenuItem
        '
        Me.TeamAgileshomepageToolStripMenuItem.Image = CType(resources.GetObject("TeamAgileshomepageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TeamAgileshomepageToolStripMenuItem.Name = "TeamAgileshomepageToolStripMenuItem"
        Me.TeamAgileshomepageToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TeamAgileshomepageToolStripMenuItem.Text = "Team Agile's home page..."
        '
        'QueryWorker
        '
        Me.QueryWorker.WorkerReportsProgress = True
        Me.QueryWorker.WorkerSupportsCancellation = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(423, 135)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(120, 20)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'pbQuery
        '
        Me.pbQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbQuery.ForeColor = System.Drawing.Color.Teal
        Me.pbQuery.Location = New System.Drawing.Point(423, 158)
        Me.pbQuery.Name = "pbQuery"
        Me.pbQuery.Size = New System.Drawing.Size(120, 15)
        Me.pbQuery.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbQuery.TabIndex = 14
        Me.pbQuery.Value = 45
        Me.pbQuery.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(421, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 422)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pbQuery)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtAssociateID)
        Me.Controls.Add(Me.ItemResultDataGridView)
        Me.Controls.Add(AssociateLinkLabel)
        Me.Controls.Add(Me.AssociateLinkTextBox)
        Me.Controls.Add(Me.ItemResultBindingNavigator)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Amazoner"
        CType(Me.ItemResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemResultBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemResultBindingNavigator.ResumeLayout(False)
        Me.ItemResultBindingNavigator.PerformLayout()
        CType(Me.ItemResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssociateLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemResultBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItemResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtAssociateID As System.Windows.Forms.TextBox
    Friend WithEvents gridContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTitleaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopybothtitleandimageaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyimageaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutAmazonerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QueryWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pbQuery As System.Windows.Forms.ProgressBar
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopybooktitleaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopybookimageaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopybothaslinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowsetoitemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeAmazoneWSCredientialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoysBlogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamAgileshomepageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox


End Class
