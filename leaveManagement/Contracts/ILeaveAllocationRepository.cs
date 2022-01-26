using leaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckedAllocation(int leavetypeid, string employeeid);

        Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string id);

        Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string id, int leavetypeid);
    }
}
