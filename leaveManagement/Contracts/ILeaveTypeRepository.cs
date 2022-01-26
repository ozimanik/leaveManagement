using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leaveManagement.Data;

namespace leaveManagement.Contracts
{

    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        Task<ICollection<LeaveType>> GetEmployeesByLeaveType(int id);
    }
}
