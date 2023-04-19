using HanControls.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanControls.ViewModel
{
    public class Dialog_SingleStringViewModel
    {

        public delegate void OnDialogResultCallback(string result);
        public event OnDialogResultCallback OnResultCallback;

        public string DialogTitle { get; set; }

        public string StringData { get; set; }

        public Dialog_SingleStringViewModel()
        {

        }

        public Dialog_SingleStringViewModel(string dialogTitle)
        {

            DialogTitle = dialogTitle;

        }


        public CommandBase Cmd_OK
        {
            get => new CommandBase()
            {
                DoExecute = new Action<object>((o) =>
                {
                    OnResultCallback.Invoke(StringData);
                }),
            };
        }
    }
}
