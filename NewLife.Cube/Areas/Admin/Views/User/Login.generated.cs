﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\User\Login.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/Login.cshtml")]
    public partial class _Areas_Admin_Views_User_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\Login.cshtml"
  
    Layout = null;
    ViewBag.Title = "登录";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->\r\n\r\n    <title>");

            
            #line 14 "..\..\Areas\Admin\Views\User\Login.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 14 "..\..\Areas\Admin\Views\User\Login.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 419), Tuple.Create("\"", 439)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 426), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- 文本字体 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 532), Tuple.Create("\"", 574)
, Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-fonts.min.css")
, 539), false)
);

WriteLiteral(" />\r\n    <!-- ace 样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 627), Tuple.Create("\"", 663)
, Tuple.Create(Tuple.Create("", 634), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace.min.css")
, 634), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" id=\"main-ace-style\"");

WriteLiteral(" />\r\n\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 773), Tuple.Create("\"", 815)
, Tuple.Create(Tuple.Create("", 780), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-part2.min.css")
, 780), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" />\r\n    <![endif]-->\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 921), Tuple.Create("\"", 960)
, Tuple.Create(Tuple.Create("", 928), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-ie.min.css")
, 928), false)
);

WriteLiteral(" />\r\n    <![endif]-->\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1012), Tuple.Create("\"", 1037)
, Tuple.Create(Tuple.Create("", 1019), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Site.css")
, 1019), false)
);

WriteLiteral(" />\r\n\r\n    <!-- 最后引入基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1094), Tuple.Create("\"", 1142)
, Tuple.Create(Tuple.Create("", 1101), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 1101), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1174), Tuple.Create("\"", 1225)
, Tuple.Create(Tuple.Create("", 1181), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 1181), false)
);

WriteLiteral(" />\r\n</head>\r\n<body");

WriteLiteral(" class=\"login-layout\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"main-container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"main-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-10 col-sm-offset-1\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"login-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"center\"");

WriteLiteral(">\r\n                            <h1>\r\n                                <i");

WriteLiteral(" class=\"ace-icon fa fa-leaf green\"");

WriteLiteral("></i>\r\n                                <span");

WriteLiteral(" class=\"red\"");

WriteLiteral(">");

            
            #line 44 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                             Write(SysConfig.Current.DisplayName.Substring(0, 3));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <span");

WriteLiteral(" class=\"white\"");

WriteLiteral(" id=\"id-text2\"");

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                                             Write(SysConfig.Current.DisplayName.Substring(3));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </h1>\r\n                            <h4");

WriteLiteral(" class=\"blue\"");

WriteLiteral(" id=\"id-company-text\"");

WriteLiteral(">&copy; ");

            
            #line 47 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                                                    Write(SysConfig.Current.Company);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n\r\n                        <div");

WriteLiteral(" class=\"position-relative\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" id=\"login-box\"");

WriteLiteral(" class=\"login-box visible widget-box no-border\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"widget-body\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"widget-main\"");

WriteLiteral(">\r\n                                        <h4");

WriteLiteral(" class=\"header blue lighter bigger\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"ace-icon fa fa-coffee green\"");

WriteLiteral("></i>\r\n                                            精彩总在登录后\r\n                     " +
"                   </h4>\r\n\r\n                                        <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n\r\n");

            
            #line 63 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                         using (Html.BeginForm("Login", "User", new { ReturnUrl = ViewBag.ReturnUrl }))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                                                     

            
            #line default
            #line hidden
WriteLiteral("                                            <fieldset>\r\n                         " +
"                       <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" name=\"username\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"用户名\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-user\"");

WriteLiteral("></i>");

            
            #line 70 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                                                                      Write(Html.ValidationMessage("username"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </span>\r\n                  " +
"                              </label>\r\n\r\n                                      " +
"          <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" name=\"password\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"密码\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-lock\"");

WriteLiteral("></i>");

            
            #line 77 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                                                                      Write(Html.ValidationMessage("password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </span>\r\n                  " +
"                              </label>\r\n\r\n                                      " +
"          <div");

WriteLiteral(" class=\"space\"");

WriteLiteral("></div>\r\n\r\n                                                <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                                                    <label");

WriteLiteral(" class=\"inline\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" name=\"remember\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n                                                        <span");

WriteLiteral(" class=\"lbl\"");

WriteLiteral("> 自动登录</span>\r\n                                                    </label>\r\n\r\n  " +
"                                                  <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"width-35 pull-right btn btn-sm btn-primary\"");

WriteLiteral(">\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-key\"");

WriteLiteral("></i>\r\n                                                        <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">登录</span>\r\n                                                    </button>\r\n      " +
"                                          </div>\r\n\r\n                            " +
"                    <div");

WriteLiteral(" class=\"space-4\"");

WriteLiteral("></div>\r\n                                            </fieldset>\r\n");

            
            #line 97 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div><!-- /.widget-main -->\r\n\r\n             " +
"                       <div");

WriteLiteral(" class=\"toolbar clearfix\"");

WriteLiteral(">\r\n                                        <div>\r\n                               " +
"             <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#forgot-box\"");

WriteLiteral(" class=\"forgot-password-link\"");

WriteLiteral(">\r\n                                                <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-left\"");

WriteLiteral("></i>\r\n                                                忘记密码？\r\n                   " +
"                         </a>\r\n                                        </div>\r\n\r" +
"\n                                        <div>\r\n                                " +
"            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#signup-box\"");

WriteLiteral(" class=\"user-signup-link\"");

WriteLiteral(">\r\n                                                我要注册\r\n                        " +
"                        <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-right\"");

WriteLiteral(@"></i>
                                            </a>
                                        </div>
                                    </div>
                                </div><!-- /.widget-body -->
                            </div><!-- /.login-box -->

                            <div");

WriteLiteral(" id=\"forgot-box\"");

WriteLiteral(" class=\"forgot-box widget-box no-border\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"widget-body\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"widget-main\"");

WriteLiteral(">\r\n                                        <h4");

WriteLiteral(" class=\"header red lighter bigger\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"ace-icon fa fa-key\"");

WriteLiteral("></i>\r\n                                            取回密码\r\n                        " +
"                </h4>\r\n\r\n                                        <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n                                        <p>\r\n                           " +
"                 输入你的邮箱地址\r\n                                        </p>\r\n\r\n");

            
            #line 131 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 131 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                         using (Html.BeginForm("ForgetPassword"))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <fieldset>\r\n                         " +
"                       <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"Email\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-envelope\"");

WriteLiteral("></i>\r\n                                                    </span>\r\n             " +
"                                   </label>\r\n\r\n                                 " +
"               <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"width-35 pull-right btn btn-sm btn-danger\"");

WriteLiteral(">\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-lightbulb-o\"");

WriteLiteral("></i>\r\n                                                        <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">发送</span>\r\n                                                    </button>\r\n      " +
"                                          </div>\r\n                              " +
"              </fieldset>\r\n");

            
            #line 148 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div><!-- /.widget-main -->\r\n\r\n             " +
"                       <div");

WriteLiteral(" class=\"toolbar center\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#login-box\"");

WriteLiteral(" class=\"back-to-login-link\"");

WriteLiteral(">\r\n                                            回到登录\r\n                            " +
"                <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                                        </a>\r\n                            " +
"        </div>\r\n                                </div><!-- /.widget-body -->\r\n  " +
"                          </div><!-- /.forgot-box -->\r\n\r\n                       " +
"     <div");

WriteLiteral(" id=\"signup-box\"");

WriteLiteral(" class=\"signup-box widget-box no-border\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"widget-body\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"widget-main\"");

WriteLiteral(">\r\n                                        <h4");

WriteLiteral(" class=\"header green lighter bigger\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"ace-icon fa fa-users blue\"");

WriteLiteral("></i>\r\n                                            新用户注册\r\n                       " +
"                 </h4>\r\n\r\n                                        <div");

WriteLiteral(" class=\"space-6\"");

WriteLiteral("></div>\r\n                                        <p> 输入你的信息 </p>\r\n\r\n");

            
            #line 171 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 171 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                         using (Html.BeginForm("Register"))
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <fieldset>\r\n                         " +
"                       <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"Email\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-envelope\"");

WriteLiteral("></i>\r\n                                                    </span>\r\n             " +
"                                   </label>\r\n\r\n                                 " +
"               <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"用户名\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-user\"");

WriteLiteral("></i>\r\n                                                    </span>\r\n             " +
"                                   </label>\r\n\r\n                                 " +
"               <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"密码\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-lock\"");

WriteLiteral("></i>\r\n                                                    </span>\r\n             " +
"                                   </label>\r\n\r\n                                 " +
"               <label");

WriteLiteral(" class=\"block clearfix\"");

WriteLiteral(">\r\n                                                    <span");

WriteLiteral(" class=\"block input-icon input-icon-right\"");

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"重复密码\"");

WriteLiteral(" />\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-retweet\"");

WriteLiteral("></i>\r\n                                                    </span>\r\n             " +
"                                   </label>\r\n\r\n                                 " +
"               <label");

WriteLiteral(" class=\"block\"");

WriteLiteral(">\r\n                                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace\"");

WriteLiteral(" />\r\n                                                    <span");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(">\r\n                                                        我接受\r\n                 " +
"                                       <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">用户协议</a>\r\n                                                    </span>\r\n         " +
"                                       </label>\r\n\r\n                             " +
"                   <div");

WriteLiteral(" class=\"space-24\"");

WriteLiteral("></div>\r\n\r\n                                                <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                                                    <button");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"width-30 pull-left btn btn-sm\"");

WriteLiteral(">\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-refresh\"");

WriteLiteral("></i>\r\n                                                        <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">重置</span>\r\n                                                    </button>\r\n\r\n    " +
"                                                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"width-65 pull-right btn btn-sm btn-success\"");

WriteLiteral(">\r\n                                                        <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">注册</span>\r\n\r\n                                                        <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-right icon-on-right\"");

WriteLiteral("></i>\r\n                                                    </button>\r\n           " +
"                                     </div>\r\n                                   " +
"         </fieldset>\r\n");

            
            #line 225 "..\..\Areas\Admin\Views\User\Login.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div>\r\n\r\n                                   " +
" <div");

WriteLiteral(" class=\"toolbar center\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-target=\"#login-box\"");

WriteLiteral(" class=\"back-to-login-link\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-left\"");

WriteLiteral(@"></i>
                                            回到登录
                                        </a>
                                    </div>
                                </div><!-- /.widget-body -->
                            </div><!-- /.signup-box -->
                        </div><!-- /.position-relative -->

                        <div");

WriteLiteral(" class=\"navbar-fixed-top align-right\"");

WriteLiteral(">\r\n                            <br />\r\n                            &nbsp;\r\n      " +
"                      <a");

WriteLiteral(" id=\"btn-login-dark\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">暗黑</a>\r\n                            &nbsp;\r\n                            <span");

WriteLiteral(" class=\"blue\"");

WriteLiteral(">/</span>\r\n                            &nbsp;\r\n                            <a");

WriteLiteral(" id=\"btn-login-blur\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">蓝色</a>\r\n                            &nbsp;\r\n                            <span");

WriteLiteral(" class=\"blue\"");

WriteLiteral(">/</span>\r\n                            &nbsp;\r\n                            <a");

WriteLiteral(" id=\"btn-login-light\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(@">明亮</a>
                            &nbsp; &nbsp; &nbsp;
                        </div>
                    </div>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.main-content -->
    </div><!-- /.main-container -->
    <!-- JQuery作为一等公民，页面内部随时可能使用 -->
    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 14896), Tuple.Create("\"", 14934)
, Tuple.Create(Tuple.Create("", 14902), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 14902), false)
);

WriteLiteral("></script>\r\n    <!-- 最早引入基本脚本 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 14981), Tuple.Create("\"", 15026)
, Tuple.Create(Tuple.Create("", 14987), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 14987), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 15050), Tuple.Create("\"", 15092)
, Tuple.Create(Tuple.Create("", 15056), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-ui.custom.min.js")
, 15056), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 15116), Tuple.Create("\"", 15163)
, Tuple.Create(Tuple.Create("", 15122), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery.ui.touch-punch.min.js")
, 15122), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- HTML5shiv and Respond.js for IE8 to support HTML5 elements" +
" and media queries -->\r\n    <!--[if lte IE 8]>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 15304), Tuple.Create("\"", 15339)
, Tuple.Create(Tuple.Create("", 15310), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/html5shiv.min.js")
, 15310), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 15363), Tuple.Create("\"", 15396)
, Tuple.Create(Tuple.Create("", 15369), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/respond.min.js")
, 15369), false)
);

WriteLiteral("></script>\r\n    <![endif]-->\r\n    <!-- inline scripts related to this page -->\r\n " +
"   <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        jQuery(function ($) {
            $(document).on('click', '.toolbar a[data-target]', function (e) {
                e.preventDefault();
                var target = $(this).data('target');
                $('.widget-box.visible').removeClass('visible');//hide others
                $(target).addClass('visible');//show target
            });
        });



        //you don't need this, just used for changing background
        jQuery(function ($) {
            $('#btn-login-dark').on('click', function (e) {
                $('body').attr('class', 'login-layout');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-light').on('click', function (e) {
                $('body').attr('class', 'login-layout light-login');
                $('#id-text2').attr('class', 'grey');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-blur').on('click', function (e) {
                $('body').attr('class', 'login-layout blur-login');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'light-blue');

                e.preventDefault();
            });

        });
    </script>
</body>
</html>");

        }
    }
}
#pragma warning restore 1591
