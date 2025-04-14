using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.BL
{
    class StudentAccount : Account
    {
        string InstituteName;
        string StudyDuration;

        public StudentAccount(int accountNo, string accountName, double balance, string institute, string studyDuration) : base(accountNo, accountName, balance)
        {
            InstituteName = institute;
            StudyDuration = studyDuration;
        }

        public string GetInstituteName()
        {
            return InstituteName;
        }
        public string GetStudyDuration()
        {
            return StudyDuration;
        }
        public void SetInstituteName(string institute)
        {
            InstituteName = institute;
        }
        public void SetStudyDuration(string studyDuration)
        {
            StudyDuration = studyDuration;
        }
        public new bool Credit(double increment)
        {
            if (increment <= 500000)
            {
                base.Credit(increment);
                return true;
            }
            return false;
        }
    }
}