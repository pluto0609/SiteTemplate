using System.Web.Mvc;

namespace Jaap.Web.Framework.Attributes
{
    /// <summary>
    /// ��ɫ��Ȩ������
    /// </summary>
    public class RoleAuthorAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
        }
    }
}