using Convertor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Convertor.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class RequestsTagHelper : TagHelper
    {
        public IUrlHelperFactory urlHelperFactory { get; }
        public RequestsTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder link = new TagBuilder("a");
                link.Attributes["href"] = urlHelper.Action(PageAction,
                                            new { pageNumber = i });
                link.InnerHtml.Append(i.ToString() + " ");
                if(i.Equals(PageModel.CurrentPage))
                    link.Attributes["class"] = "text-danger";
                result.InnerHtml.AppendHtml(link);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
