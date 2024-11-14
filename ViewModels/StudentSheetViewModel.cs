using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Basics.Models;

namespace Wpf_Basics.ViewModels
{
    internal class StudentSheetViewModel : Bases.ViewModelBase
    {
        private List<Student> students = default!;
        public List<Student> Students { get { return students; } set { SetProperty(ref students, value); } }

        public StudentSheetViewModel()
        {
            Students = Student.Students;
        }
    }
}
