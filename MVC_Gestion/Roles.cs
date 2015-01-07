using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVC_Gestion
{
    public class Roles: RoleProvider
    {
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (Models.EntitiesGestion db = new Models.EntitiesGestion()) 
            {
                var objRolUsr = db.TBLUSUARIO.FirstOrDefault(it => it.USER_NICK == username);
                if (objRolUsr == null)
                {
                    return null;
                }
                else 
                {
                    string[] rol = Convert.ToString(db.TBLUSUARIO.Where(it => it.USER_NICK == username).Select(it => it.USER_PERFIL)).ToArray();
                }
            }


            using (SampleDBEntities objContext = new SampleDBEntities())
            {
                var objUser = objContext.Users.FirstOrDefault(x => x.AppUserName == username);
                if (objUser == null)
                {
                    return null;
                }
                else
                {
                    string[] ret = objUser.Roles.Select(x => x.RoleName).ToArray();
                    return ret;
                }
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}