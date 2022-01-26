using leaveManagement.Contracts;
using leaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leaveManagement.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Data.LeaveRequest entity)
        {
            _db.LeaveRequests.Add(entity);
            return Save();
        }

        public bool Delete(Data.LeaveRequest entity)
        {
            _db.LeaveRequests.Remove(entity);
            return Save();
        }

        public ICollection<Data.LeaveRequest> FindAll()
        {
            var LeaveHistories = _db.LeaveRequests
                .Include(q => q.RequestingEmployee)
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .ToList();
            return LeaveHistories;
        }

        public Data.LeaveRequest FindById(int id)
        {
            var LeaveHistory = _db.LeaveRequests
                .Include(q => q.RequestingEmployee)
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .FirstOrDefault(q => q.Id == id);
            return LeaveHistory;
        }

        public ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeid)
        {
            var leaveRequests = FindAll()
                .Where(q => q.RequestingEmployeeId == employeeid)
                .ToList();
            return leaveRequests;
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveRequests.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Data.LeaveRequest entity)
        {
            _db.LeaveRequests.Update(entity);
            return Save();
        }
    }
}
