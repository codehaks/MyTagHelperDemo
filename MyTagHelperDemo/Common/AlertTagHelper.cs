using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTagHelperDemo.Common
{
    
    //[HtmlTargetElement("tag-name")]
    public class AlertTagHelper : TagHelper
    {
        public string Message { get; set; }
        public enum AlertType
        {
            Primary=0,
            Secondary=1,
            Success=2
        }

        public AlertType Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", "alert alert-"+Type.ToString().ToLower());
            output.Attributes.Add("role", "alert");

            output.Content.SetContent(Message);
        }
    }
}
