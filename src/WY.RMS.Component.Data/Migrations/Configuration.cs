using WY.RMS.Component.Data.EF;

namespace WY.RMS.Component.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WY.RMS.Domain.Model.Member;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Module> modules = new List<Module>
            {
                new Module { Id = 1, ParentId = null, Name = "Ȩ�޹���", Code = "20",LinkUrl=null, OrderSort = 1, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now},
                new Module { Id = 2, ParentId = 1, Name = "��ɫ����", LinkUrl = "~/Member/Role/Index",  Code = "2001", OrderSort = 2, Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now},
                new Module { Id = 3, ParentId = 1, Name = "�û�����", LinkUrl = "~/Member/User/Index", Code = "2002", OrderSort = 3, Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now },
                new Module { Id = 4, ParentId = 1, Name = "ģ�����", LinkUrl = "~/Member/Module/Index",  Code = "2003", OrderSort = 4, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 5, ParentId = 1, Name = "Ȩ�޹���", LinkUrl = "~/Member/Permission/Index",  Code = "2004", OrderSort = 5, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                 new Module { Id = 6, ParentId = null, Name = "ϵͳӦ��", LinkUrl = null,  Code = "30", OrderSort = 1, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 7, ParentId = 6, Name = "������־����", LinkUrl = "~/SysConfig/OperateLog/Index",Code = "3001", OrderSort = 2, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
            };
            DbSet<Module> moduleSet = context.Set<Module>();
            moduleSet.AddOrUpdate(t => new { t.Id }, modules.ToArray());
            context.SaveChanges();

            List<Permission> permissions = new List<Permission>
            {
                new Permission{Id=1, PermissionType=1, TypeKey=1,UpdateDate=DateTime.Now},
                new Permission{Id=2, PermissionType=1, TypeKey=2,UpdateDate=DateTime.Now},
                new Permission{Id=3, PermissionType=1, TypeKey=3,UpdateDate=DateTime.Now},
                new Permission{Id=4, PermissionType=1, TypeKey=4,UpdateDate=DateTime.Now},
                new Permission{Id=5, PermissionType=1, TypeKey=5,UpdateDate=DateTime.Now},
                new Permission{Id=6, PermissionType=1, TypeKey=6,UpdateDate=DateTime.Now},
                new Permission{Id=7, PermissionType=1, TypeKey=7,UpdateDate=DateTime.Now}
            };
            DbSet<Permission> permissionSet = context.Set<Permission>();
            permissionSet.AddOrUpdate(m => new { m.Id }, permissionSet.ToArray());
            context.SaveChanges();
            List<Role> roles = new List<Role>
            {
                new Role { Id=1,  RoleName = "superadmin", Description="��������Ա",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=2,  RoleName = "����Ա", Description="ϵͳ����Ա",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now,Permissions=permissions},
                 new Role { Id=3,  RoleName = "��ͨ��ɫ1", Description="��ͨ��ɫ1",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                  new Role { Id=4,  RoleName = "��ͨ��ɫ2", Description="��ͨ��ɫ2",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                   new Role { Id=5,  RoleName = "��ͨ��ɫ3", Description="��ͨ��ɫ3",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                    new Role { Id=6,  RoleName = "��ͨ��ɫ4", Description="��ͨ��ɫ4",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                     new Role { Id=7,  RoleName = "��ͨ��ɫ5", Description="��ͨ��ɫ5",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                      new Role { Id=8,  RoleName = "��ͨ��ɫ6", Description="��ͨ��ɫ6",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                       new Role { Id=9,  RoleName = "��ͨ��ɫ7", Description="��ͨ��ɫ7",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                        new Role { Id=10,  RoleName = "��ͨ��ɫ8", Description="��ͨ��ɫ8",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                         new Role { Id=11,  RoleName = "��ͨ��ɫ9", Description="��ͨ��ɫ9",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                                new Role { Id=12,  RoleName = "��ͨ��ɫ10", Description="��ͨ��ɫ10",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now }
            };
            DbSet<Role> roleSet = context.Set<Role>();
            roleSet.AddOrUpdate(m => new { m.RoleName }, roles.ToArray());
            context.SaveChanges();

            List<User> members = new List<User>
            {
                new User { Id=1, UserName = "admin", Password = "000102030405060708090a0b0c0d0e0f", Email = "375368093@qq.com", TrueName = "����Ա",Phone="18181818181",Address="�㶫���������������·XX��XX��XXX��X��" ,Enabled=true,Roles=new List<Role>{roles[1]} },
                new User { Id=2, UserName = "xiaowu", Password = "000102030405060708090a0b0c0d0e0f", Email = "wu_yi@minnov.com", TrueName = "С��",Phone="18181818181",Address="�㶫���������������·XX��X�㶫���������������·XX��XX��XXX��X��",Enabled=true,Roles=new List<Role>{roles[1]} }
            };
            DbSet<User> memberSet = context.Set<User>();
            memberSet.AddOrUpdate(m => new { m.UserName }, members.ToArray());
            context.SaveChanges();
        }
    }
}
