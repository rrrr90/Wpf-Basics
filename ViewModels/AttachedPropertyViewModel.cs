using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Basics.ViewModels
{
    class AttachedPropertyViewModel : Bases.ViewModelBase
    {
		private string _inputText = "";

		public string InputText
		{
			get
			{
				return _inputText;
			}
			set
			{
				SetProperty(ref _inputText, value);
                OutputText = _inputText;
            }
		}

		private string _outputText = "";

        public string OutputText
		{
			get { return _outputText; }
			set
			{
				SetProperty(ref _outputText, value);
			}
		}

		private string _inputPassword = "";

        public string InputPassword
		{
			get { return _inputPassword; }
			set
			{
				SetProperty(ref _inputPassword, value);
                OutputPassword = _inputPassword;
            }
		}

		private string _outputPassword = "";

        public string OutputPassword
		{
			get { return _outputPassword; }
			set
			{
				SetProperty(ref _outputPassword, value);
			}
		}

		public AttachedPropertyViewModel() { }
    }
}
