using sistemaESDO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sistemaESDO.Filters
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string[] allowedroles;
        public CustomAuthorizeAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            var userID = httpContext.Session["Session"];
            if (userID != null)
            {
                using (var context = new sistemaESDOEntities())
                {
                    var userRole = (from u in context.usuarioData
                                    join r in context.usuarioRolData on u.userRolID equals r.rolID
                                    where u.userID == (int)userID
                                    select new
                                    {
                                        r.rolNombre
                                    }).FirstOrDefault();

                    foreach (var role in allowedroles)
                    {
                        if (role.ToUpper() == userRole.rolNombre.ToUpper())
                            return true;
                    }
                }
            }
            return authorize;
        }
    }
}