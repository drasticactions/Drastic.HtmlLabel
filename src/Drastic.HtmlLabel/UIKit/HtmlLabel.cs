// <copyright file="HtmlLabel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using ObjCRuntime;

namespace Drastic.Controls
{
    public class HtmlLabel
        : UILabel, IHtmlLabel
    {
        public HtmlLabel()
        {
        }

        public HtmlLabel(NSCoder coder)
            : base(coder)
        {
        }

        public HtmlLabel(CGRect frame)
            : base(frame)
        {
        }

        protected HtmlLabel(NSObjectFlag t)
            : base(t)
        {
        }

        protected internal HtmlLabel(NativeHandle handle)
            : base(handle)
        {
        }

        /// <inheritdoc/>
        public void SetHtml(string text)
        {
            var attr = this.GetNSAttributedStringDocumentAttributes();
            NSError? nsError = null;
            this.AttributedText = new NSAttributedString(text, attr, ref nsError);
        }

        protected virtual NSAttributedStringDocumentAttributes GetNSAttributedStringDocumentAttributes()
        {
            return new NSAttributedStringDocumentAttributes
            {
                DocumentType = NSDocumentType.HTML,
                StringEncoding = NSStringEncoding.UTF8,
            };
        }
    }
}
