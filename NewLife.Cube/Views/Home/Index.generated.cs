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
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "首页";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("featured", () => {

WriteLiteral("\r\n    <section");

WriteLiteral(" class=\"featured\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"content-wrapper\"");

WriteLiteral(">\r\n            <hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n                <h1>");

            
            #line 8 "..\..\Views\Home\Index.cshtml"
               Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n                <h2>");

            
            #line 9 "..\..\Views\Home\Index.cshtml"
               Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n            </hgroup>\r\n            <p>\r\n                魔方平台NewLife.Cube由新" +
"生命团队开发，基于数据映射框架NewLife.XCode，集成权限管理体系，插件机制，作为Mvc项目的默认管理后台。\r\n            </p>\r\n  " +
"      </div>\r\n    </section>\r\n");

});

WriteLiteral("<h3>使用方法：</h3>\r\n<ol");

WriteLiteral(" class=\"round\"");

WriteLiteral(">\r\n    <li");

WriteLiteral(" class=\"one\"");

WriteLiteral(">\r\n        <h5>下载</h5>\r\n        从新生命网站下载最新魔方压缩包NewLife.Cube.zip和X组件Fx4版本，<a");

WriteLiteral(" href=\"http://www.newlifex.com/showtopic-51.aspx\"");

WriteLiteral(">http://www.NewLifeX.com/showtopic-51.aspx</a><br />\r\n        <a");

WriteLiteral(" href=\"http://www.newlifex.com/showtopic-51.aspx\"");

WriteLiteral(">更多…</a>\r\n    </li>\r\n\r\n    <li");

WriteLiteral(" class=\"two\"");

WriteLiteral(">\r\n        <h5>安装</h5>\r\n        新建Mvc4项目（使用.Net 4.0），把压缩包NewLife.Cube.zip解压到Mvc项目" +
"中，注意Web.config等配置文件的覆盖，根据需要调整<br />\r\n        下载X组件Fx4版本，<a");

WriteLiteral(" href=\"ftp://ftp.newlifex.com/x/DLL4.zip\"");

WriteLiteral(">ftp://ftp.newlifex.com/x/DLL4.zip</a><br />\r\n        解压到Mvc项目并排的DLL目录<br />\r\n   " +
"     Mvc项目引用NewLife.Core.dll、XCode.dll、NewLife.Cube.dll，编译Mvc项目<br />\r\n        编" +
"译通过后即可预览效果<br />\r\n        <a");

WriteLiteral(" href=\"http://www.newlifex.com/showtopic-51.aspx\"");

WriteLiteral(">更多…</a>\r\n    </li>\r\n\r\n    <li");

WriteLiteral(" class=\"three\"");

WriteLiteral(">\r\n        <h5>NuGet</h5>\r\n        也可以通过NuGet安装NewLife.Cube\r\n        <a");

WriteLiteral(" href=\"http://www.newlifex.com/showtopic-51.aspx\"");

WriteLiteral(">更多…</a>\r\n    </li>\r\n</ol>\r\n");

        }
    }
}
#pragma warning restore 1591