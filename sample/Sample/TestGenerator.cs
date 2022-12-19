// <copyright file="TestGenerator.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace Sample
{
    public static class TestGenerator
    {
        public static string GenerateHtml()
        {
            var test = "<div>\r\n<p>This is paragraph 1</p>\r\n<p>This is paragraph 2</p>\r\n<p>This is paragraph 3</p>\r\n<tagname>\r\ncontent...\r\n</tagname>\r\n<h1>This is heading 1</h1>\r\n<h2>This is heading 2</h2>\r\n<h3>This is heading 3</h3>\r\n<h4>This is heading 4</h4>\r\n<h5>This is heading 5</h5>\r\n<h6>This is heading 6</h6>\r\n<p>Unordered List:</p>\r\n<ul>\r\n<li>item 1</li>\r\n<li>item 2</li>\r\n</ul>\r\n\r\n<p>Ordered List:</p>\r\n<ol>\r\n<li>item 1</li>\r\n<li>item 2</li>\r\n</ol>\r\n<img src=\"https://via.placeholder.com/300/09f/fff.png\" alt=\"test\"/>\r\n\r\n</div>";
            return test;
        }
    }
}
