using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datlich
{
    abstract public class Controller
    {
        abstract public bool GuiMail(string to);
        abstract public System.Data.DataSet GetDataBaseCommand(string query);
    }
}
