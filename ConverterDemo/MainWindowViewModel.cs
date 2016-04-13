using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class MainWindowViewModel
    {

        private double? myDouble;
        public double? MyDouble
        {
            get { return myDouble; }
            set
            {
                myDouble = value;
            }
        }
    }
}

class MainWindowViewModel
{

    private double? myDouble;
    public double? MyDouble
    {
        get { return myDouble; }
        set
        {
            myDouble = value;
        }
    }
}
