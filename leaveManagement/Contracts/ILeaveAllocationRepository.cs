using leaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Contracts
{
    interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        ICollection<LeaveAllocation> GetLeaveAllocations(int id);
    }
}
