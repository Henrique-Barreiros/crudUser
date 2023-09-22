using System;
using System.Collections.Generic;
using System.Linq;

public class UserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public List<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public User GetUserById(int id)
    {
        return _context.Users.FirstOrDefault(u => u.Id == id);
    }

    public void UpdateUser(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void RemoveUser(User user)
    {
        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}
