﻿using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveOrUpdateJointCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveOrUpdateJointCommand));

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;
        private int numberOfOperationWithoutInspectors = 0;
        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveOrUpdateJointCommand(
            IConstructionRepository repo,
            JointNewEditViewModel viewModel,
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        public void Execute()
        {
            foreach (JointTestResult t in viewModel.JointTestResults)
            {
                if (t.Inspectors.Count <= 0)
                {
                    numberOfOperationWithoutInspectors++;
                }
            }
            if (numberOfOperationWithoutInspectors == 0)
            {
                try
                {
                    viewModel.Joint.Number = viewModel.Joint.Number.ToUpper();
                    repo.BeginTransaction();
                    repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                    repo.Commit();
                    repo.RepoJoint.Evict(viewModel.Joint);

                    viewModel.ModifiableView.IsModified = false;

                    //saving attached documents
                    if (viewModel.FilesFormViewModel != null)
                    {
                        viewModel.FilesFormViewModel.Item = viewModel.Joint.Id;
                        viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    }

                    viewModel.ModifiableView.UpdateState();

                    notify.ShowNotify(
                        string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Saved), viewModel.Number),
                        Program.LanguageManager.GetString(StringResources.Joint_SavedHeader));

                    log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                        viewModel.Joint.Number,
                        viewModel.Joint.Id));
                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            else
            {
                notify.ShowError(
                    Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResult),
                    Program.LanguageManager.GetString(StringResources.SelectInspectorsForTestResultHeader));
            }
        }


        public bool CanExecute()
        {
            return
                !string.IsNullOrEmpty(viewModel.Number)
                &&
                   ((viewModel.FirstElement != null && viewModel.SecondElement != null)
                   ||
                   viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                &&
                viewModel.Joint.IsActive
                &&
                ctx.HasAccess(viewModel.IsNew
                                   ? global::Domain.Entity.Security.Privileges.CreateJoint
                                   : global::Domain.Entity.Security.Privileges.EditJoint);
        }
    }
}
