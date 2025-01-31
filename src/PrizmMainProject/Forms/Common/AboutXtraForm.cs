﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using System.Reflection;
using Prizm.Main.Properties;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Common
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class AboutXtraForm : PrizmForm
    {
        public AboutXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.prizma_appIcon_32;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void AboutXtraForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = Program.LanguageManager.GetString(StringResources.AboutForm_TitleLabel);
            textEditVersionNumber.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            textEditVersionNumber.ReadOnly = true;
        }
        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>() 
                { 
                    new LocalizedItem(titleLabel, StringResources.AboutForm_TitleLabel.Id),

                    new LocalizedItem(labelVersion, StringResources.About_VersionLabel.Id),

                    new LocalizedItem(acceptButton, StringResources.About_AcceptButton.Id),

                    // header
                    new LocalizedItem(this, localizedHeader, new string[] {
                        StringResources.AboutXtraForm_Title.Id} )
                };
        }

        #endregion // --- Localization ---
    }
}