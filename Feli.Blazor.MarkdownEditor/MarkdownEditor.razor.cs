using Markdig;
using Microsoft.AspNetCore.Components;

namespace Feli.Blazor.MarkdownEditor
{
    public partial class MarkdownEditor
    {
        [Parameter]
        public string Content { get; set; }

        [Parameter]
        public int Height { get; set; } = 400;

        [Parameter]
        public string InfoText { get; set; } = "Styling with Markdown is supported";

        [Parameter]
        public string Placeholder { get; set; } = string.Empty;

        private string _previewContent = string.Empty;

        public string GetMarkdown()
        {
            return Content;
        }

        public string GetHTML()
        {
            return Markdown.ToHtml(Content);
        }

        private void UpdatePreviewContent()
        {
            _previewContent = GetHTML();
        }
    }
}
