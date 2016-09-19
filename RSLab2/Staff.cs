using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSLab2
{
    class Staff
    {
        private string _FirstName, _LastName, _Patronymic;

        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
                set
            {
                this._FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this._LastName = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return this._Patronymic;
            }
            set
            {
                this._Patronymic = value;
            }
        }

        public string FIO {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }

        public Staff()
        {
            FirstName = LastName = Patronymic = "";   
        }
    }
}
