namespace Nuty.Authorization.Core {

    using System.Web.Mvc;

    public class AuthorizationAttribute : AuthorizeAttribute {

        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext) { return base.AuthorizeCore(httpContext); }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext) { base.HandleUnauthorizedRequest(filterContext); }

        public override void OnAuthorization(AuthorizationContext filterContext) { base.OnAuthorization(filterContext); }

    }
}
