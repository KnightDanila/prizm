﻿namespace PrizmMain.Forms.Spool
{
    partial class SpoolsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpoolsXtraForm));
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.inspectionHistory = new DevExpress.XtraGrid.GridControl();
            this.inspectionHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionResultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spoolLength = new DevExpress.XtraEditors.TextEdit();
            this.cutButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.spoolNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeSearchayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.upperSearchEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.incomingInspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionHistoryLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoolLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spoolNumberLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutlengthGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipelengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoonlengthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.curButtonmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cutLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.spoolNumberEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.spoolCreationEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SpoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSearchayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curButtonmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolCreationEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(261, 62);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 22);
            this.searchButton.StyleController = this.mainLayoutControl;
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "&Поиск";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.saveButton);
            this.mainLayoutControl.Controls.Add(this.attachmentsButton);
            this.mainLayoutControl.Controls.Add(this.inspectionHistory);
            this.mainLayoutControl.Controls.Add(this.spoolLength);
            this.mainLayoutControl.Controls.Add(this.cutButton);
            this.mainLayoutControl.Controls.Add(this.pipeLength);
            this.mainLayoutControl.Controls.Add(this.spoolNumber);
            this.mainLayoutControl.Controls.Add(this.searchButton);
            this.mainLayoutControl.Controls.Add(this.pipeNumber);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 129, 250, 350);
            this.mainLayoutControl.Root = this.layoutRootGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(940, 450);
            this.mainLayoutControl.TabIndex = 44;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(802, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 22);
            this.saveButton.StyleController = this.mainLayoutControl;
            this.saveButton.TabIndex = 46;
            this.saveButton.Text = "Сохранить";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("attachmentsButton.Image")));
            this.attachmentsButton.Location = new System.Drawing.Point(18, 419);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(116, 22);
            this.attachmentsButton.StyleController = this.mainLayoutControl;
            this.attachmentsButton.TabIndex = 45;
            this.attachmentsButton.Text = "Вложения";
            this.attachmentsButton.Click += new System.EventHandler(this.attachmentsButton_Click);
            // 
            // inspectionHistory
            // 
            this.inspectionHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionHistory.Location = new System.Drawing.Point(382, 50);
            this.inspectionHistory.MainView = this.inspectionHistoryGridView;
            this.inspectionHistory.Name = "inspectionHistory";
            this.inspectionHistory.Size = new System.Drawing.Size(528, 346);
            this.inspectionHistory.TabIndex = 44;
            this.inspectionHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionHistoryGridView});
            // 
            // inspectionHistoryGridView
            // 
            this.inspectionHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionDateGridColumn,
            this.inspectionResultGridColumn,
            this.inspectorsGridColumn,
            this.reasonGridColumn});
            this.inspectionHistoryGridView.GridControl = this.inspectionHistory;
            this.inspectionHistoryGridView.Name = "inspectionHistoryGridView";
            this.inspectionHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // inspectionDateGridColumn
            // 
            this.inspectionDateGridColumn.Caption = "Дата";
            this.inspectionDateGridColumn.Name = "inspectionDateGridColumn";
            this.inspectionDateGridColumn.Visible = true;
            this.inspectionDateGridColumn.VisibleIndex = 0;
            // 
            // inspectionResultGridColumn
            // 
            this.inspectionResultGridColumn.Caption = "Результат";
            this.inspectionResultGridColumn.Name = "inspectionResultGridColumn";
            this.inspectionResultGridColumn.Visible = true;
            this.inspectionResultGridColumn.VisibleIndex = 1;
            // 
            // inspectorsGridColumn
            // 
            this.inspectorsGridColumn.Caption = "Инспектор";
            this.inspectorsGridColumn.Name = "inspectorsGridColumn";
            this.inspectorsGridColumn.Visible = true;
            this.inspectorsGridColumn.VisibleIndex = 2;
            // 
            // reasonGridColumn
            // 
            this.reasonGridColumn.Caption = "Причина";
            this.reasonGridColumn.Name = "reasonGridColumn";
            this.reasonGridColumn.Visible = true;
            this.reasonGridColumn.VisibleIndex = 3;
            // 
            // spoolLength
            // 
            this.spoolLength.Location = new System.Drawing.Point(196, 246);
            this.spoolLength.Name = "spoolLength";
            this.spoolLength.Size = new System.Drawing.Size(120, 20);
            this.spoolLength.StyleController = this.mainLayoutControl;
            this.spoolLength.TabIndex = 16;
            // 
            // cutButton
            // 
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.Location = new System.Drawing.Point(219, 280);
            this.cutButton.MaximumSize = new System.Drawing.Size(100, 0);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(97, 22);
            this.cutButton.StyleController = this.mainLayoutControl;
            this.cutButton.TabIndex = 43;
            this.cutButton.Text = "&Отрезать";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(49, 246);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.ReadOnly = true;
            this.pipeLength.Size = new System.Drawing.Size(126, 20);
            this.pipeLength.StyleController = this.mainLayoutControl;
            this.pipeLength.TabIndex = 13;
            // 
            // spoolNumber
            // 
            this.spoolNumber.Location = new System.Drawing.Point(33, 162);
            this.spoolNumber.Name = "spoolNumber";
            this.spoolNumber.Size = new System.Drawing.Size(213, 20);
            this.spoolNumber.StyleController = this.mainLayoutControl;
            this.spoolNumber.TabIndex = 41;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(31, 64);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Size = new System.Drawing.Size(212, 20);
            this.pipeNumber.StyleController = this.mainLayoutControl;
            this.pipeNumber.TabIndex = 38;
            // 
            // layoutRootGroup
            // 
            this.layoutRootGroup.CustomizationFormText = "Root";
            this.layoutRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutRootGroup.GroupBordersVisible = false;
            this.layoutRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeSearchayoutGroup,
            this.incomingInspectionLayoutGroup,
            this.spoolLayoutGroup,
            this.attachmentsButtonLayout,
            this.saveButtonLayout,
            this.buttonsEmptySpace});
            this.layoutRootGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutRootGroup.Name = "layoutRootGroup";
            this.layoutRootGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutRootGroup.Size = new System.Drawing.Size(940, 450);
            this.layoutRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(14, 14, 15, 5);
            this.layoutRootGroup.Text = "layoutRootGroup";
            this.layoutRootGroup.TextVisible = false;
            // 
            // pipeSearchayoutGroup
            // 
            this.pipeSearchayoutGroup.CustomizationFormText = "Поиск трубы";
            this.pipeSearchayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.upperSearchEmptySpace,
            this.searchLayoutControlItem,
            this.pipeNumberLabel});
            this.pipeSearchayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeSearchayoutGroup.Name = "pipeSearchayoutGroup";
            this.pipeSearchayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 9);
            this.pipeSearchayoutGroup.Size = new System.Drawing.Size(339, 93);
            this.pipeSearchayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 7);
            this.pipeSearchayoutGroup.Text = "Поиск трубы";
            // 
            // upperSearchEmptySpace
            // 
            this.upperSearchEmptySpace.AllowHotTrack = false;
            this.upperSearchEmptySpace.CustomizationFormText = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Location = new System.Drawing.Point(233, 0);
            this.upperSearchEmptySpace.Name = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.Size = new System.Drawing.Size(100, 14);
            this.upperSearchEmptySpace.Text = "upperSearchEmptySpace";
            this.upperSearchEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchLayoutControlItem
            // 
            this.searchLayoutControlItem.Control = this.searchButton;
            this.searchLayoutControlItem.CustomizationFormText = "searchLayoutControlItem";
            this.searchLayoutControlItem.Location = new System.Drawing.Point(233, 14);
            this.searchLayoutControlItem.Name = "searchLayoutControlItem";
            this.searchLayoutControlItem.Size = new System.Drawing.Size(100, 40);
            this.searchLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 13, 7, 7);
            this.searchLayoutControlItem.Text = "searchLayoutControlItem";
            this.searchLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.searchLayoutControlItem.TextToControlDistance = 0;
            this.searchLayoutControlItem.TextVisible = false;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Control = this.pipeNumber;
            this.pipeNumberLabel.CustomizationFormText = "Номер трубы";
            this.pipeNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(233, 54);
            this.pipeNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 7, 7, 7);
            this.pipeNumberLabel.Text = "Номер трубы";
            this.pipeNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // incomingInspectionLayoutGroup
            // 
            this.incomingInspectionLayoutGroup.CustomizationFormText = "Входной контроль";
            this.incomingInspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionHistoryLayout});
            this.incomingInspectionLayoutGroup.Location = new System.Drawing.Point(339, 0);
            this.incomingInspectionLayoutGroup.Name = "incomingInspectionLayoutGroup";
            this.incomingInspectionLayoutGroup.Size = new System.Drawing.Size(569, 393);
            this.incomingInspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 2, 2, 2);
            this.incomingInspectionLayoutGroup.Text = "Входной контроль";
            // 
            // inspectionHistoryLayout
            // 
            this.inspectionHistoryLayout.Control = this.inspectionHistory;
            this.inspectionHistoryLayout.CustomizationFormText = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectionHistoryLayout.Name = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.Size = new System.Drawing.Size(532, 350);
            this.inspectionHistoryLayout.Text = "inspectionHistoryLayout";
            this.inspectionHistoryLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionHistoryLayout.TextToControlDistance = 0;
            this.inspectionHistoryLayout.TextVisible = false;
            // 
            // spoolLayoutGroup
            // 
            this.spoolLayoutGroup.CustomizationFormText = "Создание катушки";
            this.spoolLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.spoolNumberLabel,
            this.layoutlengthGroup,
            this.spoolNumberEmptySpace,
            this.spoolCreationEmptySpace});
            this.spoolLayoutGroup.Location = new System.Drawing.Point(0, 93);
            this.spoolLayoutGroup.Name = "spoolLayoutGroup";
            this.spoolLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 9, 0, 9);
            this.spoolLayoutGroup.Size = new System.Drawing.Size(339, 300);
            this.spoolLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 7, 2);
            this.spoolLayoutGroup.Text = "Создание катушки";
            // 
            // spoolNumberLabel
            // 
            this.spoolNumberLabel.Control = this.spoolNumber;
            this.spoolNumberLabel.CustomizationFormText = "Номер катушки";
            this.spoolNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.spoolNumberLabel.Name = "spoolNumberLabel";
            this.spoolNumberLabel.Size = new System.Drawing.Size(244, 62);
            this.spoolNumberLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 15, 7, 15);
            this.spoolNumberLabel.Text = "Номер катушки";
            this.spoolNumberLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoolNumberLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutlengthGroup
            // 
            this.layoutlengthGroup.CustomizationFormText = "Длинна";
            this.layoutlengthGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipelengthLabel,
            this.spoonlengthLabel,
            this.curButtonmptySpace,
            this.cutLayoutControlItem});
            this.layoutlengthGroup.Location = new System.Drawing.Point(0, 62);
            this.layoutlengthGroup.Name = "layoutlengthGroup";
            this.layoutlengthGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutlengthGroup.Size = new System.Drawing.Size(324, 136);
            this.layoutlengthGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 7, 0, 15);
            this.layoutlengthGroup.Text = "Длина";
            // 
            // pipelengthLabel
            // 
            this.pipelengthLabel.Control = this.pipeLength;
            this.pipelengthLabel.CustomizationFormText = "Труба";
            this.pipelengthLabel.Location = new System.Drawing.Point(0, 0);
            this.pipelengthLabel.Name = "pipelengthLabel";
            this.pipelengthLabel.Size = new System.Drawing.Size(147, 54);
            this.pipelengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 7, 7, 7);
            this.pipelengthLabel.Text = "Труба";
            this.pipelengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipelengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // spoonlengthLabel
            // 
            this.spoonlengthLabel.Control = this.spoolLength;
            this.spoonlengthLabel.CustomizationFormText = "Катушка";
            this.spoonlengthLabel.Location = new System.Drawing.Point(147, 0);
            this.spoonlengthLabel.MinSize = new System.Drawing.Size(82, 41);
            this.spoonlengthLabel.Name = "spoonlengthLabel";
            this.spoonlengthLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.spoonlengthLabel.Size = new System.Drawing.Size(149, 54);
            this.spoonlengthLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.spoonlengthLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 15, 7, 15);
            this.spoonlengthLabel.Text = "Катушка";
            this.spoonlengthLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.spoonlengthLabel.TextSize = new System.Drawing.Size(78, 13);
            // 
            // curButtonmptySpace
            // 
            this.curButtonmptySpace.AllowHotTrack = false;
            this.curButtonmptySpace.CustomizationFormText = "curButtonmptySpace";
            this.curButtonmptySpace.Location = new System.Drawing.Point(0, 54);
            this.curButtonmptySpace.Name = "curButtonmptySpace";
            this.curButtonmptySpace.Size = new System.Drawing.Size(100, 42);
            this.curButtonmptySpace.Text = "curButtonmptySpace";
            this.curButtonmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cutLayoutControlItem
            // 
            this.cutLayoutControlItem.Control = this.cutButton;
            this.cutLayoutControlItem.CustomizationFormText = "cutLayoutControlItem";
            this.cutLayoutControlItem.Location = new System.Drawing.Point(100, 54);
            this.cutLayoutControlItem.Name = "cutLayoutControlItem";
            this.cutLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.cutLayoutControlItem.Size = new System.Drawing.Size(196, 42);
            this.cutLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(80, 15, 3, 15);
            this.cutLayoutControlItem.Text = "cutLayoutControlItem";
            this.cutLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cutLayoutControlItem.TextToControlDistance = 0;
            this.cutLayoutControlItem.TextVisible = false;
            // 
            // spoolNumberEmptySpace
            // 
            this.spoolNumberEmptySpace.AllowHotTrack = false;
            this.spoolNumberEmptySpace.CustomizationFormText = "spoolNumberEmptySpace";
            this.spoolNumberEmptySpace.Location = new System.Drawing.Point(244, 0);
            this.spoolNumberEmptySpace.Name = "spoolNumberEmptySpace";
            this.spoolNumberEmptySpace.Size = new System.Drawing.Size(80, 62);
            this.spoolNumberEmptySpace.Text = "spoolNumberEmptySpace";
            this.spoolNumberEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // spoolCreationEmptySpace
            // 
            this.spoolCreationEmptySpace.AllowHotTrack = false;
            this.spoolCreationEmptySpace.CustomizationFormText = "spoolCreationEmptySpace";
            this.spoolCreationEmptySpace.Location = new System.Drawing.Point(0, 198);
            this.spoolCreationEmptySpace.Name = "spoolCreationEmptySpace";
            this.spoolCreationEmptySpace.Size = new System.Drawing.Size(324, 63);
            this.spoolCreationEmptySpace.Text = "spoolCreationEmptySpace";
            this.spoolCreationEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.CustomizationFormText = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 393);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(135, 33);
            this.attachmentsButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 0);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextToControlDistance = 0;
            this.attachmentsButtonLayout.TextVisible = false;
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(769, 393);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(139, 33);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 7, 0);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // buttonsEmptySpace
            // 
            this.buttonsEmptySpace.AllowHotTrack = false;
            this.buttonsEmptySpace.CustomizationFormText = "buttonsEmptySpace";
            this.buttonsEmptySpace.Location = new System.Drawing.Point(135, 393);
            this.buttonsEmptySpace.Name = "buttonsEmptySpace";
            this.buttonsEmptySpace.Size = new System.Drawing.Size(634, 33);
            this.buttonsEmptySpace.Text = "buttonsEmptySpace";
            this.buttonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SpoolsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.mainLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpoolsXtraForm";
            this.Text = "Создание катушки";
            this.Load += new System.EventHandler(this.SpoolsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSearchayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperSearchEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingInspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionHistoryLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutlengthGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoonlengthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curButtonmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumberEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolCreationEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpoolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit spoolNumber;
        private DevExpress.XtraEditors.SimpleButton cutButton;
        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLabel;
        private DevExpress.XtraLayout.LayoutControlItem spoolNumberLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutlengthGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipelengthLabel;
        private DevExpress.XtraLayout.LayoutControlItem searchLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem cutLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem upperSearchEmptySpace;
        private DevExpress.XtraLayout.LayoutControlGroup pipeSearchayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup spoolLayoutGroup;
        private DevExpress.XtraGrid.GridControl inspectionHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionHistoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorsGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn reasonGridColumn;
        private DevExpress.XtraLayout.LayoutControlGroup incomingInspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionHistoryLayout;
        private DevExpress.XtraLayout.EmptySpaceItem spoolNumberEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem spoolCreationEmptySpace;
        private DevExpress.XtraEditors.TextEdit spoolLength;
        private DevExpress.XtraLayout.LayoutControlItem spoonlengthLabel;
        private DevExpress.XtraLayout.EmptySpaceItem curButtonmptySpace;
        private System.Windows.Forms.BindingSource SpoolBindingSource;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton attachmentsButton;
        private DevExpress.XtraLayout.LayoutControlItem attachmentsButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpace;
        private DevExpress.XtraEditors.TextEdit pipeNumber;
    }
}