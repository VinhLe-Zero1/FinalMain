using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datlich
{
    abstract public class SendMail
    {
        abstract public bool GuiMail(string to);
        abstract public DataSet GetDataBaseCommand(string query);

    }
}
