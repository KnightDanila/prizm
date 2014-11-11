﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrizmMain.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Data.DAL.Mill;

namespace PrizmMain.Forms.PipeMill.Search
{
    public class MillPipeSearchCommand : ICommand
    {

        readonly IPipeRepository repo;
        readonly MillPipeSearchViewModel viewModel;

        public MillPipeSearchCommand(MillPipeSearchViewModel viewModel, IPipeRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.Pipes = repo.GetAll();
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}
