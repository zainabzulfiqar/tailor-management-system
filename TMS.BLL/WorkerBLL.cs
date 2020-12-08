using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.BLL
{
    public class WorkerBLL
    {
        public void CreateNewWorker(Worker w)
        {
            TMS.DAL.WorkerDAL.AddWorker(w);
        }

        public List<Worker> GetAllWorkers()
        {
            return TMS.DAL.WorkerDAL.WorkerList;
        }
    }
}
