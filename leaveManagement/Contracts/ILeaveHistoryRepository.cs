using leaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Contracts
{
    interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
        ICollection<LeaveHistory> GetLeaveHistories(int id);
    }
}
