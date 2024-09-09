using System;

namespace BlazorApp.Model.Entities
{
    public class UserRoleModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public virtual RoleModel Role { get; set; }
        public virtual UserModel User { get; set; }
    }
}
