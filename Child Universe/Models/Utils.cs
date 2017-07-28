using System.Collections.Generic;
using System.Net;
using System.Web;

namespace Child_Universe.Models
{
    public static class Utils
    {
        /// <summary>
        /// Toy's tags for searching
        /// </summary>
        public enum Tag
        {
            // Age tags
            // fXtoY - from X to Y years
            // older - 7 years and more
            f0to1, f1to2, f2to3, f3to4, f4to5, f5to6, f6to7, older

        }
        /// <summary>
        /// It's used to associate tag with text.
        /// </summary>
        public static Dictionary<Tag, string> TagTexts = new Dictionary<Tag, string>(new Dictionary<Tag, string>
        {
            { Tag.f0to1, "До 1 року" },
            { Tag.f1to2, "Від 1 до 2 років" },
            { Tag.f2to3, "Від 2 до 3 років" },
            { Tag.f3to4, "Від 3 до 4 років" },
            { Tag.f4to5, "Від 4 до 5 років" },
            { Tag.f5to6, "Від 5 до 6 років" },
            { Tag.f6to7, "Від 6 до 7 років" },
            { Tag.older, "Старше 7 років" }
        });
    }
}