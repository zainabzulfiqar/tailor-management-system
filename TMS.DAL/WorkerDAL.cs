using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class WorkerDAL
    {
        public static List<Worker> WorkerList = new List<Worker>();

        public static void AddWorker(Worker w)
        {
            WorkerList.Add(w);
        }
    }
}
