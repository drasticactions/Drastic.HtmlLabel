// <copyright file="HtmlLabel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Drastic.Controls
{
    public class HtmlLabel : UserControl, IHtmlLabel
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.Register("Html", typeof(string), typeof(HtmlLabel), new PropertyMetadata(null));

        private TextBlock innerTextBlock;

        public HtmlLabel()
        {
            this.innerTextBlock = new TextBlock();
            this.Content = innerTextBlock;
        }

        public string Html
        {
            get
            {
                return (string)this.GetValue(HtmlProperty);
            }

            set
            {
                this.SetValue(HtmlProperty, value);
                this.SetupHtml(value);
            }
        }

        /// <inheritdoc/>
        public void SetHtml(string text)
        {
            this.Html = text;
        }

        private void SetupHtml(string text)
        {
            // Just in case we are not given text with elements.
            var modifiedText = string.Format("<div>{0}</div>", text);
            modifiedText = Regex.Replace(modifiedText, "<br>", "<br></br>", RegexOptions.IgnoreCase);

            // Reset the text because we will add to it.
            this.innerTextBlock.Inlines.Clear();

            try
            {
                var element = XElement.Parse(modifiedText);
                LabelHtmlHelper.ParseText(element, this.innerTextBlock.Inlines);
            }
            catch (Exception)
            {
                // If anything goes wrong just show the html
                this.innerTextBlock.Text = global::Windows.Data.Html.HtmlUtilities.ConvertToText(text);
            }
        }
    }
}
