﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Typographies.Renders;
using Util.Ui.NgZorro.Enums;
using Util.Ui.Renders;

namespace Util.Ui.NgZorro.Components.Typographies; 

/// <summary>
/// span，生成的标签为&lt;span&gt;&lt;/span&gt;
/// </summary>
[HtmlTargetElement( "util-span" )]
public class SpanTagHelper : TypographyTagHelper {
    /// <summary>
    /// 子标签
    /// </summary>
    public SpanChildTag ChildTag { get; set; }
    /// <summary>
    /// 是否排版组件
    /// </summary>
    public bool Typography { get; set; }
    /// <summary>
    /// (contextmenu),上下文菜单事件
    /// </summary>
    public string OnContextmenu { get; set; }

    /// <inheritdoc />
    protected override bool IsEnableTypography() {
        return false;
    }

    /// <inheritdoc />
    protected override IRender GetRender( TagHelperContext context, TagHelperOutput output, TagHelperContent content ) {
        var config = new Config( context, output, content );
        return new SpanRender( config, GetTagBuilder() );
    }

    /// <summary>
    /// 获取标签生成器
    /// </summary>
    protected override TagBuilder GetTagBuilder() {
        return new SpanBuilder();
    }
}