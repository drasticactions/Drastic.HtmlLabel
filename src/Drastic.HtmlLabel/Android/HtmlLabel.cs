// <copyright file="HtmlLabel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Android.Content;
using Android.Runtime;
using Android.Text;
using Android.Util;

namespace Drastic.Controls
{
    public class HtmlLabel : TextView, IHtmlLabel
    {
        public HtmlLabel(Context? context)
            : base(context)
        {
        }

        public HtmlLabel(Context? context, IAttributeSet? attrs)
            : base(context, attrs)
        {
        }

        public HtmlLabel(Context? context, IAttributeSet? attrs, int defStyleAttr)
            : base(context, attrs, defStyleAttr)
        {
        }

        public HtmlLabel(Context? context, IAttributeSet? attrs, int defStyleAttr, int defStyleRes)
            : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected HtmlLabel(nint javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        /// <inheritdoc/>
        public void SetHtml(string txt)
        {
            var newText = txt ?? string.Empty;
            this.SetText(Html.FromHtml(newText, FromHtmlOptions.ModeCompact), BufferType.Spannable);
        }
    }
}
