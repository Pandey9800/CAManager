using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAManager
{
    public class ClientFile
    {
        public int id { get; set; }
        public string groupCode { get; set; }
        public string clientGroup { get; set; }
        public string clientName { get; set; }
        public string fileNo { get; set; }
        public string Department { get; set; }
        public DateTime workingDate { get; set; }
        public DateTime registrationDate { get; set; }
        public string forwardTo { get; set; }
        public string clientFor { get; set; }
        public string registrationDetails { get; set; }
        public string comments { get; set; }
        public string remark { get; set; }
        public int status { get; set; }
        public string receiptNo { get; set; }
        public string FilingFees { get; set; }
        public DateTime lastupdate { get; set; }
        public string enteredby { get; set; }
        public string lastupdateBy { get; set; }
        public string forwardBy { get; set; }
    }
}
