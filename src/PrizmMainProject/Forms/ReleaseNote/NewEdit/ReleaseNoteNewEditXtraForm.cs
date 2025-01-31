﻿using System;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;

using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;
using System.Drawing;
using Prizm.Main.Controls;

namespace Prizm.Main.Forms.ReleaseNote.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ReleaseNoteNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private Guid id;
        private ICommandManager commandManager = new CommandManager();
        private ReleaseNoteViewModel viewModel;
        private ExternalFilesXtraForm filesForm = null;
        private Dictionary<PipeMillStatus, string> statusTypeDict
            = new Dictionary<PipeMillStatus, string>();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
        public bool IsMatchedByGuid(Guid id) { return this.id == id; }

        public ReleaseNoteNewEditXtraForm(Guid id)
        {
            this.id = id;

            InitializeComponent();
            Bitmap bmp = Resources.shipment_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            viewModel = (ReleaseNoteViewModel)Program.Kernel.Get<ReleaseNoteViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.validatableView = this;
            viewModel.PropertyChanged += (s, e) => IsModified = true;

            releaseNoteDate.Properties.NullDate = DateTime.MinValue;
            releaseNoteDate.Properties.NullText = string.Empty;

            this.releaseNoteDate.SetRequiredText();
            this.releaseNoteNumber.SetRequiredText();
            SetControlsTextLength();
            this.certificateNumber.SetAsIdentifier();
            this.pipeNumberLookUp.SetAsIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();

            SetAlwaysReadOnly(textEditReleaseNoteStatus);

            attachmentsButton.Enabled = true;
        }

        public ReleaseNoteNewEditXtraForm() : this(Guid.Empty) { }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            statusTypeDict.Clear();
            statusTypeDict.Add(PipeMillStatus.Produced, Resources.Produced);
            statusTypeDict.Add(PipeMillStatus.Shipped, Resources.Shipped);
            statusTypeDict.Add(PipeMillStatus.Stocked, Resources.Stocked);
            repositoryGridLookUpEditStatus.DataSource = statusTypeDict;

            BindCommands();
            BindToViewModel();
            IsModified = false;
            IsEditMode = !viewModel.Shipped && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);

            releaseNoteDate.SetLimits();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releasedNoteNumberLayout, StringResources.ReleaseNoteNewEdit_ReleaseNumberLabel.Id),
                new LocalizedItem(releasedNoteDateLayout, StringResources.ReleaseNoteNewEdit_ReleaseDateLabel.Id),
                new LocalizedItem(railcarNumberLayout, StringResources.ReleaseNoteNewEdit_RailcarNumberLabel.Id),
                new LocalizedItem(certificateNumberLayout, StringResources.ReleaseNoteNewEdit_CertificateLabel.Id),
                new LocalizedItem(layoutControlDestination, StringResources.ReleaseNoteNewEdit_DestinationLabel.Id),
                new LocalizedItem(pipeNumberLayout, StringResources.ReleaseNoteNewEdit_PipeNumberLayout.Id),

                //buttons
                new LocalizedItem(addPipeButton, StringResources.ReleaseNoteNewEdit_AddPipeButton.Id),
                new LocalizedItem(removePipe, StringResources.ReleaseNoteNewEdit_RemovePipeButton.Id),
                new LocalizedItem(attachmentsButton, StringResources.ReleaseNoteNewEdit_AttachmentsButton.Id),
                new LocalizedItem(shipButton, StringResources.ReleaseNoteNewEdit_ShipButton.Id),
                new LocalizedItem(unshipButton, StringResources.ReleaseNoteNewEdit_UnshipButton.Id),
                new LocalizedItem(saveButton, StringResources.ReleaseNoteNewEdit_SaveButton.Id),

                //columns
                new LocalizedItem(pipeNumberGridColumn, StringResources.ReleaseNoteNewEdit_PipeNumberColumn.Id),
                new LocalizedItem(pipeSizeGridColumn, StringResources.ReleaseNoteNewEdit_PipeTypeSizeColumn.Id),
                new LocalizedItem(pipeStatusGridColumn, StringResources.ReleaseNoteNewEdit_PipeStatusColumn.Id),
                new LocalizedItem(railcarNumberGridColumn, StringResources.ReleaseNoteNewEdit_RailcarNumberColumn.Id),
                new LocalizedItem(railcarCertificateGridColumn, StringResources.ReleaseNoteNewEdit_RailcarCertificateColumn.Id),
                new LocalizedItem(railcarDestinationGridColumn, StringResources.ReleaseNoteNewEdit_RailcarDestinationColumn.Id),

                new LocalizedItem(railcarLayoutControlGroup, StringResources.ReleaseNoteNewEdit_RailcarLayoutControlGroup.Id),
                new LocalizedItem(addPipeLayoutGroup, StringResources.ReleaseNoteNewEdit_AddPipeLayoutGroup.Id),
                new LocalizedItem(pipesListLayoutGroup, StringResources.ReleaseNoteNewEdit_PipesListLayoutGroup.Id),

                new LocalizedItem(this, localizedHeader, new string[] {StringResources.ReleaseNoteNewEdit_Title.Id} )
            };
        }

        #endregion // --- Localization ---

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.Properties.DataSource = viewModel.Railcars;
            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Railcar");

            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            pipesList.DataBindings.Add("DataSource", bindingSource, "ReleaseNotePipes");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            releaseNoteDate.DataBindings.Add("EditValue", bindingSource, "Date");

            textEditReleaseNoteStatus.DataBindings.Add(BindingHelper.CreateOneWayReadToString("Text", bindingSource, "Shipped",
                (value) => { return Program.LanguageManager.GetString(
                    (bool)value ? StringResources.ReleaseNoteNewEdit_ShippedStatus : StringResources.ReleaseNoteNewEdit_PendingStatus);
                }));
            
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
            pipeNumberLookUp.Properties.DisplayMember = "Number";
            pipeNumberLookUp.Properties.ValueMember = "Id";
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Ship"].Executor(viewModel.ShipCommand).AttachTo(shipButton);
            commandManager["Unship"].Executor(viewModel.UnshipCommand).AttachTo(unshipButton);
            commandManager.RefreshVisualState();

            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.ShipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.UnshipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void addPipeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pipeNumberLookUp.Text))
            {
                viewModel.AddPipe((Guid)pipeNumberLookUp.EditValue);
                pipesList.RefreshDataSource();
                pipeNumberLookUp.EditValue = null;
                pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
                IsModified = true;
                commandManager.RefreshVisualState();
            }

        }

        private void removePipe_Click(object sender, EventArgs e)
        {
            Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteViewModel.PlainPipe pipe =
                pipesListView.GetRow(pipesListView.FocusedRowHandle) as Prizm.Main.Forms.ReleaseNote.NewEdit.ReleaseNoteViewModel.PlainPipe;
            if (pipe != null)
            {
                viewModel.RemovePipe(pipe);
                pipesList.RefreshDataSource();
                pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
                IsModified = true;
                commandManager.RefreshVisualState();
            }
        }

        private void repositoryGridLookUpEditStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value is PipeMillStatus)
            {
                e.DisplayText = statusTypeDict[(PipeMillStatus)e.Value];
            }
        }

        private void SetControlsTextLength()
        {
            railcarNumber.Properties.MaxLength = LengthLimit.MaxRailcarNumber;
            destination.Properties.MaxLength = LengthLimit.MaxRailcarDestination;
            certificateNumber.Properties.MaxLength = LengthLimit.MaxRailcarCertificate;
            releaseNoteNumber.Properties.MaxLength = LengthLimit.MaxReleaseNoteNumber;
        }

        private void RailcarNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            viewModel.GetStoredPipes();
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipesToAdd;
            pipeNumberLookUp.Refresh();
        }

        private void AttachmentsButton_Click(object sender, EventArgs e)
        {
            if(filesForm == null)
            {
                filesForm = new ExternalFilesXtraForm();
                viewModel.FilesFormViewModel = filesForm.ViewModel;
                viewModel.FilesFormViewModel.RefreshFiles(viewModel.ReleaseNote.Id);
            }
            filesForm.SetData(IsEditMode);
            filesForm.ShowDialog();
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate();
        }

        #endregion

        private void railcarNumber_EditValueChanged(object sender, EventArgs e)
        {
            certificateNumber.Refresh();
            destination.Refresh();
        }

        private void releaseNoteNumber_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void releaseNoteDate_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void railcarNumber_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var currentRailcar = sender as LookUpEdit;
            viewModel.Railcar = currentRailcar.EditValue as Prizm.Domain.Entity.Mill.Railcar;

        }

        private void railcarNumber_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            Prizm.Domain.Entity.Mill.Railcar r = new Prizm.Domain.Entity.Mill.Railcar
            {
                Number = railcarNumber.Text,
                Certificate = "",
                Destination = ""
            };

            viewModel.Railcars.Add(r);
            railcarNumber.EditValue = viewModel.Railcar = r;
            e.Handled = true;
        }

    }
} 
