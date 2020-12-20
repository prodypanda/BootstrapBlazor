﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：Apache-2.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BootstrapBlazor.Shared.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageLayout
    {
        /// <summary>
        /// 获得/设置 是否固定页头
        /// </summary>
        [Parameter]
        public bool IsFixedHeader { get; set; } = true;

        /// <summary>
        /// 获得/设置 是否固定页脚
        /// </summary>
        [Parameter]
        public bool IsFixedFooter { get; set; } = true;

        /// <summary>
        /// 获得/设置 侧边栏是否外置
        /// </summary>
        [Parameter]
        public bool IsFullSide { get; set; } = true;

        /// <summary>
        /// 获得/设置 是否显示页脚
        /// </summary>
        [Parameter]
        public bool ShowFooter { get; set; } = true;

        private bool UseTabSet { get; set; }

        /// <summary>
        /// 更新组件方法
        /// </summary>
        public void Update() => StateHasChanged();

        private IEnumerable<MenuItem> GetIconSideMenuItems() => new List<MenuItem>
        {
            new MenuItem() { Text = "返回组件库", Icon = "fa fa-fw fa-home", Url = "layouts" },
            new MenuItem() { Text = "布局网页", Icon = "fa fa-fw fa-desktop", Url = "layout-page" },
            new MenuItem() { Text = "示例网页", Icon = "fa fa-fw fa-laptop", Url = "layout-demo" }
        };
    }
}
