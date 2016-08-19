using System.Web.Mvc;

namespace Jaap.Web.Framework.Attributes
{
    /// <summary>
    /// ½ÇÉ«ÊÚÈ¨¹ýÂËÆ÷
    /// </summary>
    public class RoleAuthorAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
        }
    }
}