using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteek
{
    public struct PageModel
    {
        public PageTitle PageTitle { get; }

        public PageModel(PageTitle pageTitle)
        {
            PageTitle = pageTitle;
        }
    }

    public struct PageTitle
    {
        private readonly string _title;

        private PageTitle(string title)
        {
            _title = title;
        }

        public static explicit operator PageTitle(string title) => new PageTitle(title);
        public static explicit operator string(PageTitle title) => title._title;

        public override string ToString()
            => _title;
    }
}
