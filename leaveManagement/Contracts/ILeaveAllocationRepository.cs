using leaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckedAllocation(int leavetypeid, string employeeid);

        ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string id);
    }
}
