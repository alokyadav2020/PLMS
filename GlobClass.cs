using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMS
{
    class GlobClass
    {
        public static string sname { get; set; }
        public static int sid { get; set; }
        public static int pid { get; set; }
        public static int headerid { get; set; }
        public static int termid { get; set; }
        public static int newsid { get; set; }
        public static int directprint { get; set; }
        public static int printpreview { get; set; }
        public static int printPDF { get; set; }
        public static int printmethod { get; set; }
        public static int checkprint { get; set; }
        public static int idforprint { get; set; }
        public static string username { get; set; }
        public static int adid { get; set; }
        public static int planid { get; set; }// plan statics get plan id for retriev data from admission
        public static string HN { get; set; } // geting header name in MDI load form
        public static int expiryid { get; set; } // get Expiry id from PrintDate
        public static double expiryDAY { get; set; } // get total expiry in day
        public static string mt1 { get; set; } // geting header name for email
        public static string mt2 { get; set; } // geting header mobile for email
        public static string mt3 { get; set; } // geting header addredd for email
        public static string mt4 { get; set; } // geting header registration for email
        public static string version { get; set; }
        public static DateTime expirydate { get; set; }
    }
}
