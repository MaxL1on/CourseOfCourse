using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CourseOfCourse
{
    class Context : DbContext
    {
        public Context()
            :base("DataBase")
        {

        }
        DbSet<UserAuth> UsersAuth { get; set; }
        DbSet<UserData> UsersData { get; set; }
    }
    class UserAuth
    {
        [Key]
        string Login { get; set; }
        string Password { get; set; }
        string Mail { get; set; }
    }
    class UserData
    {
        string Name { get; set; }
        DateTime Birth { get; set; }
        bool Sex { get; set; }
    }
}
