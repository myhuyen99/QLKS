using System;
using System.Collections.Generic;

namespace QLKS.Models
{
    public partial class Trangbi
    {
        public string TbMa { get; set; }
        public string TbTen { get; set; }
        public string TbMota { get; set; }
        public string PMa { get; set; }

        public virtual Phong PMaNavigation { get; set; }
    }
}
