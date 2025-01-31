﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Ninject.Parameters;
using Ninject;

using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.ReleaseNote.NewEdit;
using Prizm.Main.Forms.ReleaseNote.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;

using Prizm.Main.Properties;
using DevExpress.XtraBars.Alerter;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.Audit;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Parts.Inspection;
using Prizm.Main.Forms.Common;
using PrizmMain.Forms.Notifications;
using DevExpress.XtraSplashScreen;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Security;
using Domain.Entity.Security;
using Prizm.Main.Forms.Synch;
using System.Linq;
using Prizm.Main.Forms.Reports.Construction.PipeReport;
using System.Globalization;
using System.Resources;
using Prizm.Main.Forms.Reports.Construction.WeldDateReports;
using Prizm.Main.Languages;
using Prizm.Domain.Entity.Setup;
using System.Drawing;

namespace Prizm.Main.Forms.MainChildForm
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PrizmApplicationXtraForm : PrizmForm, IUserNotify
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PrizmApplicationXtraForm));
        private PrizmApplicationViewModel viewModel;

        private const string emptyString = "";

        private int previousLanguageBarItemIndex = -1;

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.prizma_appIcon_32;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            FormManager.Initialize(this, log);
        }

        /// <summary>
        /// Old function, will be delete
        /// </summary>
        /// <param name="formType"></param>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public ChildForm OpenChildForm(Type formType, Guid id = default(Guid), string number = emptyString)
        {
            List<KeyValuePair<string, object>> parametrs = new List<KeyValuePair<string, object>>();
            if (id != Guid.Empty)
            {
                parametrs.Add(new KeyValuePair<string, object>("id", id));
            }
            if (number != string.Empty)
            {
                parametrs.Add(new KeyValuePair<string, object>("number", number));
            }
            return FormManager.Instance.OpenChildForm(formType, parametrs, id);
        }

        /// <summary>
        /// Create and show Settings child form. Starting tab page is set or first page if page doesn't exist.
        /// </summary>
        /// <param name="page">number of starting page</param>
        public void CreateSettingsChildForm(int page)
        {
            FormManager.Instance.CreateSettingsChildForm(page);
        }

        #region Menu buttons
        private void barButtonItemNewPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(MillPipeNewEditXtraForm));
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(ReleaseNoteNewEditXtraForm));
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(MillPipeSearchXtraForm));
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(MillReportsXtraForm));
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(ComponentNewEditXtraForm));
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(InspectionReportsXtraForm));
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(JointNewEditXtraForm));
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(JointSearchXtraForm));
        }

        private void barButtonItemPartIncomingInspection_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(PartInspectionXtraForm));
        }

        private void pipeConstructionRepoBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(PipeConstractionReportXtraForm));
        }

        private void weldConstructionRepoBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(WeldDateReportXtraForm));
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(ConstructionReportsXtraForm));
        }

        private void barButtonItemSettingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 6);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 7);
        }

        private void barButtonItemSettingsWelders_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 4);
        }

        private void barButtonItemSettingsInspectors_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 5);
        }

        private void barButtonItemComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 3);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(ReleaseNoteSearchXtraForm));
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(PartSearchXtraForm));
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(SpoolsXtraForm));
        }

        private void barButtonItemFindEditParts_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(PartSearchXtraForm));
        }

        private void barButtonItemAudit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(typeof(AuditXtraForm));
        }
        #endregion


        #region IUserNotify
        /// <summary>
        /// Error message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="header"></param>
        public void ShowError(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Warning message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowWarning(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Informational message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowInfo(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Message that requires user confirmation or denial (yes/no)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>true if yes, false if no</returns>
        public bool ShowYesNo(string text, string header)
        {
            return (DialogResult.Yes == XtraMessageBox.Show(text, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }
        /// <summary>
        /// Message that requires user confirmation, denial or operation cancellation (yes/no/cancel)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>1 if yes, 0 if no, -1 if cancel</returns>
        public int ShowYesNoCancel(string text, string header)
        {
            DialogResult dlg = XtraMessageBox.Show(text, header, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            sbyte result;
            switch(dlg)
            {
                case DialogResult.Cancel:
                    result = -1;
                    break;
                case DialogResult.No:
                    result = 0;
                    break;
                case DialogResult.Yes:
                    result = 1;
                    break;
                default:
                    var e = new ArgumentOutOfRangeException(string.Format("Unknown dialog answer - {0}", dlg));
                    log.Error(e.Message);
                    throw e;
            }
            return result;
        }
        /// <summary>
        /// Message about success, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowSuccess(string text, string header)
        {
            StatusNotifyText(text);

        }
        /// <summary>
        /// Message about failure, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowFailure(string text, string header)
        {
            StatusNotifyText(text);
        }
        /// <summary>
        /// Informational message, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowNotify(string text, string header)
        {
            StatusNotifyText(text);
        }

        private void StatusNotifyText(string text)
        {
            Program.MainForm.UpdateStatusBar(string.Format("[{0}] - {1}", DateTime.Now.ToShortTimeString().Trim(), text));
        }

        private int currentProcessingStep;
        private int targetProcessingSteps;

        /// <summary>
        /// Show wait form. Call it at times when UI thread will be unresponsible
        /// For now used 1. on Executing commands through the CommandManager
        ///              2. when creating and showing child forms
        /// </summary>
        /// <param name="text">message body, optional</param>
        /// <param name="header">message header, optional</param>
        /// <param name="steps">overall steps provide to show progress bar, and on each step call IncProcessingState(), optional</param>
        public void ShowProcessing(string text = "", string header = "", int steps = 0)
        {
            targetProcessingSteps = steps;
            currentProcessingStep = 0;
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), false, false, false);
            if(!string.IsNullOrEmpty(header))
                SplashScreenManager.Default.SetWaitFormCaption(header);
            if(!string.IsNullOrEmpty(text))
                SplashScreenManager.Default.SetWaitFormDescription(text);
            Application.DoEvents();
        }

        /// <summary>
        /// Hide wait form, when UI thread will be responsible again
        /// </summary>
        public void HideProcessing()
        {
            SplashScreenManager.CloseForm(false);
        }

        /// <summary>
        /// Update progress on wait form, should be called on each processing step
        /// of the long processing with known number of steps.
        /// To init progress on the wait form you should previously call ShowProcessing(, , steps) 
        /// </summary>
        public void IncProcessingState()
        {
            currentProcessingStep++;
            float percent = (float)currentProcessingStep / targetProcessingSteps * 100;
            SplashScreenManager.Default.SetWaitFormDescription(percent.ToString() + "%");
        }
        #endregion

        private void PrizmApplicationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PrizmApplicationViewModel)Program.Kernel.GetService(typeof(PrizmApplicationViewModel));

            localizedHeader.Clear();

            localizedHeader.Add(Resources.MainWindowHeader_Title);  // usage of Resources is OK - setting default values here
            localizedHeader.Add(WorkstationType.Mill.ToString());
            localizedHeader.Add(WorkstationType.Master.ToString());
            localizedHeader.Add(WorkstationType.Construction.ToString());

            CreateLanguageBarListItem();
            ProvideAccessToMenuItems();

            NotificationService.Instance.NotificationReload += OnNotificationRefresh;
            NotificationService.Instance.RequestAllNotification();

            ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
            if (Program.LanguageManager.ApplyUsersLanguage(ctx.LoggedUser))
                this.CascadeChangeLanguage();
        }

        private void barButtonItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutXtraForm form = new AboutXtraForm();
            form.ShowDialog();
        }

        private void barButtonItemExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateStatusBar(string text)
        {
            notifyBarStaticItem.Caption = text;
            notifyHistory.Items.Add(text);
        }

        private void notifyBarStaticItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(flyoutPanel.Visible)
            {
                flyoutPanel.HidePopup();
            }
            else
            {
                flyoutPanel.ShowPopup();
            }

        }

        private void barButtonStatusNotifications_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNotificationForm();
        }

        private void ShowNotificationForm()
        {
            OpenChildForm(typeof(NotificationXtraForm));
        }

        /// <summary>
        /// Update count system notification on status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNotificationRefresh(object sender, EventArgs e)
        {
            int NotificationCount = NotificationService.Instance.NotificationCount;
            barButtonStatusNotifications.Caption = string.Format("{0} ({1})",
                localizedNotificationPanelButton.Count > 0 ? localizedNotificationPanelButton[0] : "", NotificationCount);
        }

        private void importantMessages_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNotificationForm();
        }

        private void ProvideAccessToMenuItems()
        {
            ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();
            barButtonItemAudit.Enabled = ctx.HasAccess(Privileges.Audit);
            
            barButtonItemSettingsProject.Enabled =
                barButtonItemSettingsPipe.Enabled =
                barButtonItemSettingsPipeline.Enabled =
                barButtonItemComponentry.Enabled =
                barButtonItemSettingsWelders.Enabled =
                barButtonItemSettingsInspectors.Enabled =
                barButtonItemSettingsUsers.Enabled =
                barButtonItemRoles.Enabled = ctx.HasAccess(Privileges.ViewSettings) || ctx.HasAccess(Privileges.EditSettings);

            barButtonItemMillReports.Enabled = ctx.HasAccess(Privileges.PrintMillReports);

            pipeConstructionRepoBarButton.Enabled =
                weldConstructionRepoBarButton.Enabled =
                barButtonItemConstructionReports.Enabled = ctx.HasAccess(Privileges.PrintConstructionReports);

            barButtonItemInspectionReports.Enabled = ctx.HasAccess(Privileges.PrintInspectionReports);
            barButtonItemNewPipe.Enabled = ctx.HasAccess(Privileges.CreatePipe);
            barButtonItemNewRailcar.Enabled = ctx.HasAccess(Privileges.CreateReleaseNote);
            barButtonItemNewJoint.Enabled = ctx.HasAccess(Privileges.CreateJoint);
            barButtonItemNewComponent.Enabled = ctx.HasAccess(Privileges.CreateComponent);
            barButtonItemSpool.Enabled = ctx.HasAccess(Privileges.CreateSpool) || ctx.HasAccess(Privileges.EditSpool);
            barButtonItemExport.Enabled = ctx.HasAccess(Privileges.ExportDataFromMaster) || ctx.HasAccess(Privileges.ExportDataFromConstruction) || ctx.HasAccess(Privileges.ExportDataFromMill);
            barButtonItemImport.Enabled = ctx.HasAccess(Privileges.ImportDataAtMaster) || ctx.HasAccess(Privileges.ImportDataAtConstruction);

            barButtonItemFindEditJoints.Enabled = ctx.HasAccess(Privileges.SearchJoints);

            barButtonItemFindEditParts.Enabled = ctx.HasAccess(Privileges.SearchParts);

            barButtonItemPartIncomingInspection.Enabled = ctx.HasAccess(Privileges.PartsInspection);

            barButtonItemMillFindEditPipes.Enabled = ctx.HasAccess(Privileges.SearchPipes);

            barButtonItemFindEditShipRailcars.Enabled = ctx.HasAccess(Privileges.SearchReleaseNotes);
        }

        private Dictionary<int, CultureInfo> cultures = new Dictionary<int, CultureInfo>();

        private void CreateLanguageBarListItem()
        {
            cultures.Clear();
            languageBarListItem.ShowChecks = true;
            int indexDefault = 0;
            var list = Program.LanguageManager.GetCultures(out indexDefault);
            foreach (var culture in list)
            {
                int index = languageBarListItem.Strings.Add(culture.EnglishName + ", " + culture.NativeName);
                cultures[index] = culture;
            }
            previousLanguageBarItemIndex = languageBarListItem.DataIndex = indexDefault;
        }

        private void barButtonItemExport_ItemClick(object sender, ItemClickEventArgs e)
        {
           OpenChildForm(typeof(ExportForm), Guid.Empty, string.Empty);
        }

        private void barButtonItemImport_ItemClick(object sender, ItemClickEventArgs e)
        {
           ImportForm form = Program.Kernel.Get<ImportForm>();
           form.ShowDialog();
        }
        /// <summary>
        /// On choosing language in main program menu
        /// </summary>
        /// <param name="sender">menu item</param>
        /// <param name="e">list item click parameters</param>
        private void languageBarListItem_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            int index = languageBarListItem.DataIndex;
            if (cultures.ContainsKey(e.Index) && Program.LanguageManager.LoadTranslation(cultures[e.Index]))
            {
                CascadeChangeLanguage();
            }
            else
            {
                languageBarListItem.DataIndex = previousLanguageBarItemIndex;
                // ShowError(); TODO: write message about being not able to change language
            }
        }

        /// <summary>
        /// Main window will modify own text according to current language, and impel it's children to do so.
        /// </summary>
        void CascadeChangeLanguage()
        {
            Program.LanguageManager.ChangeLanguage(this);

            foreach (var child in FormManager.Instance.ChildForms)
            {
                ILocalizable localizable = child as ILocalizable;
                Program.LanguageManager.ChangeLanguage(child as ILocalizable);
            }

        }


        #region --- Localization ---

        // do NOT re-create it because reference passed to localization item. Clean it instead.
        protected List<string> localizedNotificationPanelButton = new List<string>();

        public override void UpdateTitle()
        {
            // base.UpdateTitle(); should not be called
            this.Text = string.Concat(localizedHeader[0], " [", 
                viewModel.ProjectSettings.WorkstationType == WorkstationType.Mill 
                ? localizedHeader[1]
                : viewModel.ProjectSettings.WorkstationType == WorkstationType.Master
                    ? localizedHeader[2]
                    : viewModel.ProjectSettings.WorkstationType == WorkstationType.Construction
                        ? localizedHeader[3]
                        : ""
            , "]");

            if (!string.IsNullOrWhiteSpace(viewModel.ProjectSettings.Title))
            {
                this.Text = string.Concat(this.Text, " [", viewModel.ProjectSettings.Title, "]");
            }
        }

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // menu items
                new LocalizedItem(barSubItemApplication, "Menu_File"),
                new LocalizedItem(barButtonItemExport, "Menu_File_Export"),
                new LocalizedItem(barButtonItemImport, "Menu_File_Import"),
                new LocalizedItem(barButtonItemExit, "Menu_File_Exit"),
                new LocalizedItem(barSubItemMill, "Menu_Mill"),
                new LocalizedItem(barButtonItemNewPipe, "Menu_Mill_NewPipe"),
                new LocalizedItem(barButtonItemMillFindEditPipes, "Menu_Mill_SearchPipes"),
                new LocalizedItem(barButtonItemNewRailcar, "Menu_Mill_NewReleaseNote"),
                new LocalizedItem(barButtonItemFindEditShipRailcars, "Menu_Mill_SearchReleaseNotes"),
                new LocalizedItem(barButtonItemMillReports, "Menu_Mill_Reports"),
                new LocalizedItem(barSubItemConstruction, "Menu_Construction"),
                new LocalizedItem(barButtonItemNewComponent, "Menu_Construction_NewComponent"),
                new LocalizedItem(barButtonItemNewJoint, "Menu_Construction_NewJoint"),
                new LocalizedItem(barButtonItemPartIncomingInspection, "Menu_Construction_PartIncomingInspection"),
                new LocalizedItem(barButtonItemFindEditParts, "Menu_Construction_FindParts"),
                new LocalizedItem(barButtonItemFindEditJoints, "Menu_Construction_FindJoints"),
                new LocalizedItem(barButtonItemSpool, "Menu_Construction_Spool"),
                new LocalizedItem(barButtonItemInspectionReports, "Menu_Construction_InspectionReports"),
                new LocalizedItem(pipeConstructionRepoBarButton, "Menu_Construction_PipeReports"),
                new LocalizedItem(weldConstructionRepoBarButton, "Menu_Construction_WeldReports"),
                new LocalizedItem(barButtonItemConstructionReports, "Menu_Construction_JointPKReports"),
                new LocalizedItem(barSubItemSettings, "Menu_Settings"),
                new LocalizedItem(barButtonItemSettingsProject, "Menu_Settings_Project"),
                new LocalizedItem(barButtonItemSettingsPipe, "Menu_Settings_Pipe"),
                new LocalizedItem(barButtonItemSettingsPipeline, "Menu_Settings_Pipeline"),
                new LocalizedItem(barButtonItemComponentry, "Menu_Settings_Componentry"),
                new LocalizedItem(barButtonItemSettingsWelders, "Menu_Settings_Welders"),
                new LocalizedItem(barButtonItemSettingsInspectors, "Menu_Settings_Inspectors"),
                new LocalizedItem(barButtonItemSettingsUsers, "Menu_Settings_Users"),
                new LocalizedItem(barButtonItemRoles, "Menu_Settings_Roles"),
                new LocalizedItem(barSubItemLanguage, "Menu_Settings_Language"),
                new LocalizedItem(barSubItemMisc, "Menu_Misc"),
                new LocalizedItem(barButtonItemAudit, "Menu_Misc_Audit"),
                new LocalizedItem(barButtonItemImportantMessages, "Menu_Misc_ImportantMessages"),
                new LocalizedItem(barSubItemHelp, "Menu_Help"),
                new LocalizedItem(barButtonItemAbout, "Menu_Help_About"),

                // header
                new LocalizedItem(this, localizedHeader, new string[] { "MainWindowHeader_Title", 
                    "MainWindowHeader_Mill", "MainWindowHeader_Master", "MainWindowHeader_Construction" } ),

                // status bar notifications panel button
                new LocalizedItem(barButtonStatusNotifications, localizedNotificationPanelButton, new string[] {"MainWindow_StatusNotificationsHeader" }),
            };
        }

        #endregion // --- Localization ---
    }
}