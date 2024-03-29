﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//Harder to maintain. Better use notmal HTML <img> tag
    public static class HtmlHelperExtensions
    {

        public static string Image(this HtmlHelper helper,
                                    string url,
                                    string altText,
                                    object htmlAttributes)
        {
            TagBuilder builder = new TagBuilder("img");
            builder.Attributes.Add("src", url);
            builder.Attributes.Add("alt", altText);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return builder.ToString(TagRenderMode.SelfClosing);
        }
    }