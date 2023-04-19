using HanControls.Command;
using HanControls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HanControls.ViewModel
{
    public class MainViewModel
    {
        public CommandBase Cmd_DialogSingleString
        {
            get => new CommandBase()
            {
                DoExecute = new Action<object>((o) =>
                {

                    Dialog_SingleStringViewModel viewModel = new Dialog_SingleStringViewModel("Single String");
                    viewModel.OnResultCallback += (result) => {
                        (o as Button).Content = result;
                    };

                    Dialog_SingleStringResult dialog = new Dialog_SingleStringResult();
                    dialog.DataContext = viewModel;
                    dialog.ShowDialog();

                }),

            };
        }

    }
}
