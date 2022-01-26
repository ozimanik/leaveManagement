using leaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<Data.LeaveRequest>
    {
        ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeid);
    }
}
