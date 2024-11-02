using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huong_doi_tuong
{
    internal class HocSinh
    {
        //Auto-Implemented Properties
        //gép phần khai báo,Contructor và Properties thành 1
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }

        //phương thức tostring
        public override string ToString()
        {
            return this.Name + "\t" + this.Email + "\t" + this.Phone;
        }
    }
}
